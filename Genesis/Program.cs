using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Genesis
{
    class Program
    {
        static void Main(string[] arg)
        {
            string code = File.ReadAllText(arg[0]);

            SyntaxTree syntaxTree = SyntaxFactory.ParseSyntaxTree(code, path: arg[0]);
            syntaxTree = GenesisDevice.Genesis(syntaxTree);
            string outputPath = Path.Combine(Path.GetDirectoryName(arg[0]), string.Format("Generator.cs")); // Path.GetFileNameWithoutExtension(arg[0]), Path.GetExtension(arg[0])));

            using (var sw = new StreamWriter(File.Open(outputPath, FileMode.Create, FileAccess.Write)))
            {
                syntaxTree.GetRoot().NormalizeWhitespace().WriteTo(sw);
                sw.Flush();
            }
        }
    }

}
