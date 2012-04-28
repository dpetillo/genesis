using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers.CSharp;

namespace CodeBootStrap
{
    public partial class Generator
    {
        //private ClassDeclarationSyntax _classDeclSyntax;

        public Generator()
        {
           // _methods = methods;
        }

        public CompilationUnitSyntax GetCompilationUnit()
        {
            return this.f7083();
        }

    }
}
