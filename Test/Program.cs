using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CodeBootStrapTest
{
    using CodeBootStrap;

    class Program
    {
        static void Main(string[] args)
        {
            MockGeneratorImpl g = new MockGeneratorImpl();
            CompilationUnitSyntax cus = g.GetCompilationUnit();
            SyntaxTree syntaxTree = SyntaxTree.Create("output", cus);
            string outputText = syntaxTree.Root.Format().GetFullText();
            System.IO.File.WriteAllText("..\\output.cs", outputText);
        }
    }
}
