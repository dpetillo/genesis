using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Reflection;

namespace Genesis
{
    class Program
    {
        static void Main(string[] arg)
        {
            string code = File.ReadAllText(arg[0]);

            SyntaxTree syntaxTree = SyntaxFactory.ParseSyntaxTree(code, path: arg[0]);
            syntaxTree = GenesisDevice.Genesis(syntaxTree);
            string directory = Path.Combine(Path.GetDirectoryName(arg[0]), "Output");
            string outputPath = Path.Combine(directory, string.Format("MyGenerator.cs")); // Path.GetFileNameWithoutExtension(arg[0]), Path.GetExtension(arg[0])));

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            //Write contents of OutputProject (a sample project) so this is easy to compile 
            var assembly = Assembly.GetExecutingAssembly();
            foreach (var resource in assembly.GetManifestResourceNames())
            {
                if (resource.StartsWith("Genesis.OutputProject"))
                {
                    string resourceContent;
                    string fileName = Path.Combine(directory, resource.Replace("Genesis.OutputProject.", string.Empty));
                    using (Stream stream = assembly.GetManifestResourceStream(resource))
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        resourceContent = reader.ReadToEnd();
                    }
                    using (var fileStream = File.Open(fileName, FileMode.Create))
                    using (var sr = new StreamWriter(fileStream))
                    {
                        sr.Write(resourceContent);
                    }
                }
            }

            var targetLib = Path.Combine(directory, "Genesis.exe");
            if (!File.Exists(targetLib))
            {
                File.Copy(Path.Combine(AssemblyDirectory, "Genesis.exe"), targetLib);
            }

            using (var sw = new StreamWriter(File.Open(outputPath, FileMode.Create, FileAccess.Write)))
            {
                syntaxTree.GetRoot().NormalizeWhitespace().WriteTo(sw);
                sw.Flush();
            }
        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

    }

}
