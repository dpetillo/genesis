using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Genesis
{
    public class IdentifyingSyntaxWalker : SyntaxWalker
    {

        private Dictionary<SyntaxNodeOrToken, IList<string>> identities;

        private Dictionary<SyntaxNodeOrToken, int> greatestChildPosition;

        private Dictionary<SyntaxNodeOrToken, string> names;

        public string GetId(SyntaxNodeOrToken node)
        {
            if (names.ContainsKey(node))
            {
                return names[node];
            }
            else
            {
                return "Ast_" + String.Join("_", identities[node]);
            }
        }

        public IdentifyingSyntaxWalker() : base(SyntaxWalkerDepth.Trivia)
        {
            identities = new Dictionary<SyntaxNodeOrToken, IList<string>>();
            greatestChildPosition = new Dictionary<SyntaxNodeOrToken, int>();
            names = new Dictionary<SyntaxNodeOrToken, string>();
        }

        
        public override void Visit(SyntaxNode node)
        {
            VisitImpl(node);
            NamedImpl(node);
            base.Visit(node);
        }


        private void NamedImpl(SyntaxNodeOrToken nodeOrToken)
        {
            string name = null;
            string astType = null;
            string comments = nodeOrToken.GetLeadingTrivia().ToFullString();
            string parentComments = nodeOrToken.Parent != null ? nodeOrToken.Parent.GetLeadingTrivia().ToFullString() : null;

            //if this is the hightest ast node for this comment, look for 1 bang, else 2 bangs
            string regex = @"@(?<ast_type>[^:\s]+):(?<name>\S+)";

            Match match = Regex.Match(comments, regex);
            if (match.Success)
            {
                name = match.Groups["name"].Value;
                astType = match.Groups["ast_type"].Value;

                SyntaxKind syntaxKind = (SyntaxKind)Enum.Parse(typeof(SyntaxKind), astType);

                if (nodeOrToken.Kind() == syntaxKind)
                {
                    names.Add(nodeOrToken, name);
                }
            }
        }

        private void VisitImpl(SyntaxNodeOrToken nodeOrToken)
        {
            greatestChildPosition.Add(nodeOrToken, 0);

            SyntaxNode node = nodeOrToken.AsNode();

            if ((node is CompilationUnitSyntax))
            {
                identities.Add(nodeOrToken, new List<string>());

            }


            if (!(node is CompilationUnitSyntax))
            {
                IList<string> identity = identities[nodeOrToken.Parent].ToList();
                string name = null;
                if (node is NamespaceDeclarationSyntax)
                {
                    name = ((NamespaceDeclarationSyntax)node).Name.ToString();
                }
                else if (node is ClassDeclarationSyntax)
                {
                    name = ((ClassDeclarationSyntax)node).Identifier.ValueText;
                }
                else if (node is VariableDeclaratorSyntax)
                {
                    name = ((VariableDeclaratorSyntax)node).Identifier.ValueText;
                }
                else if (node is MethodDeclarationSyntax)
                {
                    name = ((MethodDeclarationSyntax)node).Identifier.ValueText;
                }
                else if (node is PropertyDeclarationSyntax)
                {
                    name = ((PropertyDeclarationSyntax)node).Identifier.ValueText;
                }
                else if (node is UsingDirectiveSyntax)
                {
                    name = ((UsingDirectiveSyntax)node).Name.ToFullString().Replace(".", string.Empty) ;
                }
                else if (nodeOrToken.IsToken)
                {
                    name = nodeOrToken.AsToken().ValueText;
                }

                identity.Add(
                    string.Format("{0}{1}", name,
                    (++greatestChildPosition[nodeOrToken.Parent]).ToString()));

                identities.Add(nodeOrToken, identity);
            }
        }
        protected override void VisitToken(SyntaxToken token)
        {
            VisitImpl(token);
            NamedImpl(token);

            base.VisitToken(token);
        }

        /*
        public override void VisitCompilationUnit(CompilationUnitSyntax node)
        {
            //TODO: assuming we run for just one compliation unit!
            identities.Add(node,
                new List<string> { "0" });

            base.VisitCompilationUnit(node);
        }*/
    }
}
