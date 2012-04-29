using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace Genesis
{
    public class ReverseSyntaxVisitor
    {
        private BreadthFirstQueuingVisitor _breadthFirstQueuingVisitor;
        private SyntaxNode _node;
        public ReverseSyntaxVisitor(SyntaxNode node)
        {
            _node = node;
            _breadthFirstQueuingVisitor = new BreadthFirstQueuingVisitor();
            _breadthFirstQueuingVisitor.Visit(node);
        }

        private class BreadthFirstQueuingVisitor : SyntaxWalker
        {
            private Stack<object> _queue;

            public Stack<object> Stack
            {
                get { return _queue; }
                set { _queue = value; }
            }

            public BreadthFirstQueuingVisitor()
            {
                _queue = new Stack<object>();
            }

            public override void Visit(SyntaxNode node)
            {
                _queue.Push(node);
                base.Visit(node);
            }
            protected override void VisitToken(SyntaxToken token)
            {
                _queue.Push(token);
                base.VisitToken(token);
            }
            protected override void VisitTrivia(SyntaxTrivia trivia)
            {
                _queue.Push(trivia);
                base.VisitTrivia(trivia);
            }
        }

        public void Visit()
        {
            while (_breadthFirstQueuingVisitor.Stack.Count > 0)
            {
                object node = _breadthFirstQueuingVisitor.Stack.Pop();

                if (node is LiteralExpressionSyntax)
                {

                }

                if (node is IdentifierNameSyntax)
                {
                    this.VisitIdentiferNameSyntax((IdentifierNameSyntax)node);
                }
                else if (node is SyntaxNode)
                {
                    this.VisitSyntaxNode((SyntaxNode)node);
                }
                else if (node is SyntaxToken)
                {
                    this.VisitToken((SyntaxToken)node);
                }
                else if (node is SyntaxTrivia)
                {
                    this.VisitTrivia((SyntaxTrivia)node);
                }

            }
            
        }

        protected virtual void VisitIdentiferNameSyntax(IdentifierNameSyntax node)
        {

        }

        protected virtual void VisitSyntaxNode(SyntaxNode node)
        {

        }

        protected virtual void VisitToken(SyntaxToken token)
        {
            
        }

        protected virtual void VisitTrivia(SyntaxTrivia trivia)
        {
            
        }



    }

}
