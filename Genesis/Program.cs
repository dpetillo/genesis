using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace Genesis
{
    class Program
    {
        static void Main(string[] arg)
        {
            string code = File.ReadAllText(arg[0]);
            SyntaxTree syntaxTree = SyntaxTree.ParseCompilationUnit(code, fileName: arg[0]);
            syntaxTree = GenesisDevice.Genesis(syntaxTree);
            string outputText = syntaxTree.Root.Format().GetFullText();
            string outputPath = Path.Combine(Path.GetDirectoryName(arg[0]), string.Format("{0}.Generator{1}", Path.GetFileNameWithoutExtension(arg[0]), Path.GetExtension(arg[0])));
            File.WriteAllText(outputPath, outputText);
        }
    }

}
