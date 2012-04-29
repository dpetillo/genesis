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
        private Dictionary<SyntaxNode, IList<int>> identities;
        private Dictionary<SyntaxToken, IList<int>> tokenIdentities;
        private Dictionary<SyntaxNode, int> greatestChildPosition;


        public string GetId(SyntaxNode node)
        {
            return "ast" + String.Join("n", identities[node]);
        }

        public string GetId(SyntaxToken token)
        {
            return "ast" + String.Join("n", tokenIdentities[token]);
        }


        public IdentifyingSyntaxWalker()
        {
            identities = new Dictionary<SyntaxNode, IList<int>>();
            tokenIdentities = new Dictionary<SyntaxToken, IList<int>>();
            greatestChildPosition = new Dictionary<SyntaxNode, int>();
        }
        public override void Visit(SyntaxNode node)
        {
            greatestChildPosition.Add(node, 0);

            if (!(node is CompilationUnitSyntax))
            {
                IList<int> identity = identities[node.Parent].ToList();
                identity.Add(++greatestChildPosition[node.Parent]);
                identities.Add(node, identity);
            }

            base.Visit(node);
        }
        protected override void VisitToken(SyntaxToken token)
        {
            IList<int> identity = identities[token.Parent].ToList();
            identity.Add(++greatestChildPosition[token.Parent]);
            tokenIdentities.Add(token, identity);
            base.VisitToken(token);
        }


        protected override void VisitCompilationUnit(CompilationUnitSyntax node)
        {
            //TODO: assuming we run for just one compliation unit!
            identities.Add(node, 
                new List<int> { 0 });

            base.VisitCompilationUnit(node);
        }

        

        




    }

}
