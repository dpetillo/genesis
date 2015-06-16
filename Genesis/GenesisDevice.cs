using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genesis
{
    public static class GenesisDevice
    {
        public static SyntaxTree Genesis(SyntaxTree syntaxTree)
        {
            CodeGenSyntaxVisitor cbs = new CodeGenSyntaxVisitor(syntaxTree.GetCompilationUnitRoot());
            cbs.Visit();

            GeneralGenerator generator = new GeneralGenerator(cbs.Generated);

            syntaxTree = SyntaxFactory.SyntaxTree(generator.GetCompilationUnit1(), path: "output");

            return syntaxTree;
        }
    }

}
