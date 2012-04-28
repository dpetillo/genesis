using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers.CSharp;

namespace CodeBootStrap
{
    public partial class Generated
    {
        //private ClassDeclarationSyntax _classDeclSyntax;
        List<MethodDeclarationSyntax> _methods;

        public Generated(List<MethodDeclarationSyntax> methods)
        {
            _methods = methods;
        }

        public CompilationUnitSyntax GetCompilationUnit()
        {
            return this.f2827();
        }

        ClassDeclarationSyntax f2753()
        {
            return Syntax.ClassDeclaration(
                        modifiers: Syntax.TokenList( Syntax.Token(SyntaxKind.PartialKeyword)),
                        identifier: Syntax.Identifier("Generator"),
                        members: Syntax.List<MemberDeclarationSyntax>(_methods)
                    );
        }
    }
}
