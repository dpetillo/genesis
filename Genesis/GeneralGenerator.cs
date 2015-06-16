using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenesisGenerator;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Genesis
{
    class GeneralGenerator : Generator
    {
        List<MemberDeclarationSyntax> members;

        public GeneralGenerator(List<MemberDeclarationSyntax> members)
        {
            this.members = members;
        }

        protected override List<MemberDeclarationSyntax> GeneratorClass_members()
        {
            //add on the GetCompilationUnit, like seen in the skeleton file Generator.cs
            foreach (var o in base.GeneratorClass_members())
            {
                this.members.Add(o);
            }
            return members;
        }

        public CompilationUnitSyntax GetCompilationUnit1()
        {
            return CompilationUnit();
        }
    }
}
