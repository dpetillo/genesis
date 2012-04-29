using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace Genesis.Test
{
    using GenesisGenerator;

    class Program
    {
        static void Main(string[] args)
        {
            GeneralMockGenerator g = new GeneralMockGenerator();
            CompilationUnitSyntax cus = g.GetCompilationUnit();
            SyntaxTree syntaxTree = SyntaxTree.Create("output", cus);
            string outputText = syntaxTree.Root.Format().GetFullText();
            System.IO.File.WriteAllText("..\\..\\Output\\output.cs", outputText);
        }
    }
}
