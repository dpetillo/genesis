using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyGenerator
{
   //using GenesisGenerator;

    class Program
    {
        static void Main(string[] args)
        {
            MyGenerator g = new MyGenerator();
            CompilationUnitSyntax cus = g.Ast_CompilationUnit();
            SyntaxTree syntaxTree = SyntaxFactory.SyntaxTree(cus);

            using (var sw = new StreamWriter(File.Open("Generator.cs", FileMode.Create, FileAccess.Write)))
            {
                syntaxTree.GetRoot().NormalizeWhitespace().WriteTo(sw);
                sw.Flush();
            }
        }
    }
}
