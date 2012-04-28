using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CodeBootStrap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           
            string code = System.IO.File.ReadAllText(@"..\..\BootStrapper.cs");
            SyntaxTree syntaxTree = SyntaxTree.ParseCompilationUnit(code, fileName: @"..\..\BootStrapper.cs");
            */
            string code = System.IO.File.ReadAllText(@"..\..\CurrentUser.cs");
            SyntaxTree syntaxTree = SyntaxTree.ParseCompilationUnit(code, fileName: @"..\..\CurrentUser.cs");

            syntaxTree = GenesisDevice.Genesis(syntaxTree);
            string outputText = syntaxTree.Root.Format().GetFullText();


            System.IO.File.WriteAllText("..\\..\\output.cs", outputText);
            /*
            System.IO.File.WriteAllText("..\\..\\..\\CodeBootStrapTest\\Generator.cs", outputText);
            */
        }

        
    }

    public static class GenesisDevice
    {
        public static SyntaxTree Genesis(SyntaxTree syntaxTree)
        {
            BootStrapper cbs = new BootStrapper(syntaxTree.Root);
            cbs.Visit();

            Generated generator = new Generated(cbs.Generated);
            syntaxTree = SyntaxTree.Create("output", generator.GetCompilationUnit());

            return syntaxTree;
        }
    }

}
