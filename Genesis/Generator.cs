/*
 * This is the sample file a Generator has it's implementation attached to.
 * It is not compiled.  Instead the generator for this file is used to create the
 * actual output of the program.
 */
/* !CompilationUnit */
/* !!FirstUsing */
using System;
/* !SecondUsing */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

/* !Namespace */
namespace GenesisGenerator
{
    /* !GeneratorClass */
    public class Generator
    {
        /* !GetCompilationUnitGenerator */
        public CompilationUnitSyntax GetCompilationUnit()
        {
            return CompilationUnit();
        }
    }
}
