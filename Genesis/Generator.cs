/*
 * This is the sample file a Generator has it's implementation attached to.
 * It is not compiled.  Instead the generator for this file is used to create the
 * actual output of the program.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace GenesisGenerator
{

    public class Generator
    {

        public CompilationUnitSyntax GetCompilationUnit()
        {
            return Ast_0();
        }

    }
}
