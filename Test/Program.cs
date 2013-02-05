using System;
using System.Collections.Generic;
using System.IO;
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
            GenesisGenerator.Generator g = new GenesisGenerator.Generator();
            CompilationUnitSyntax cus = g.GetCompilationUnit();
            SyntaxTree syntaxTree = SyntaxTree.Create(cus);

            using (var sw = new StreamWriter(File.Open("..\\..\\Output\\output.cs", FileMode.Create, FileAccess.Write)))
            {
                syntaxTree.GetRoot().NormalizeWhitespace().WriteTo(sw);
                sw.Flush();
            }
        }
    }
}
