using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers.CSharp;
using GenesisGenerator;

namespace Genesis
{
    class GeneralGenerator : Generator
    {
        List<MemberDeclarationSyntax> members;

        public GeneralGenerator(List<MemberDeclarationSyntax> members)
        {
            this.members = members;
        }

        protected override List<MemberDeclarationSyntax> ast0n8n4members()
        {
            //add on the GetCompilationUnit, like seen in the skeleton file Generator.cs
            this.members.Add(ast0n8n4n5());
            return members;
        }

    }
}
