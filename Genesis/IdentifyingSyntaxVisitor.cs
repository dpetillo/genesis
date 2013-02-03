using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace Genesis
{
    public class IdentifyingSyntaxWalker : SyntaxWalker
    {

        private Dictionary<SyntaxNodeOrToken, IList<string>> identities;

        private Dictionary<SyntaxNodeOrToken, int> greatestChildPosition;


        public string GetId(SyntaxNodeOrToken node)
        {
            return "Ast_" + String.Join("_", identities[node]);
        }

        public IdentifyingSyntaxWalker()
        {
            identities = new Dictionary<SyntaxNodeOrToken, IList<string>>();
            greatestChildPosition = new Dictionary<SyntaxNodeOrToken, int>();
        }

        
        public override void Visit(SyntaxNode node)
        {
            VisitImpl(node);

            base.Visit(node);
        }

        private void VisitImpl(SyntaxNodeOrToken nodeOrToken)
        {
            greatestChildPosition.Add(nodeOrToken, 0);

            SyntaxNode node = nodeOrToken.AsNode();

            if (!(node is CompilationUnitSyntax))
            {
                IList<string> identity = identities[nodeOrToken.Parent].ToList();
                string name = null;
                if (node is NamespaceDeclarationSyntax)
                {
                    name = ((NamespaceDeclarationSyntax)node).Name.PlainName;
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

                identity.Add(
                    string.Format("{0}{1}", name,
                    (++greatestChildPosition[nodeOrToken.Parent]).ToString()));

                identities.Add(nodeOrToken, identity);
            }
        }
        protected override void VisitToken(SyntaxToken token)
        {
            VisitImpl(token);
            base.VisitToken(token);
        }


        protected override void VisitCompilationUnit(CompilationUnitSyntax node)
        {
            //TODO: assuming we run for just one compliation unit!
            identities.Add(node,
                new List<string> { "0" });

            base.VisitCompilationUnit(node);
        }

        

        




    }

}
