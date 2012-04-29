using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace Genesis
{
    public static class GenesisDevice
    {
        public static SyntaxTree Genesis(SyntaxTree syntaxTree)
        {
            CodeGenSyntaxVisitor cbs = new CodeGenSyntaxVisitor(syntaxTree.Root);
            cbs.Visit();

            GeneralGenerator generator = new GeneralGenerator(cbs.Generated);
            syntaxTree = SyntaxTree.Create("output", generator.GetCompilationUnit());

            return syntaxTree;
        }
    }

}
