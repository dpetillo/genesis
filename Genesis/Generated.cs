using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;
using System.Collections;


namespace CodeBootStrap
{
    public partial class Generated
    {

        Roslyn.Compilers.CSharp.NamespaceDeclarationSyntax f2765()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2754 = Syntax.IdentifierName("CodeBootStrap");
            List<ExternAliasDirectiveSyntax> list2757 = new List<ExternAliasDirectiveSyntax>
            {
            }

            ;
            SyntaxList<ExternAliasDirectiveSyntax> v2758 = Syntax.List<ExternAliasDirectiveSyntax>(list2757);
            List<UsingDirectiveSyntax> list2759 = new List<UsingDirectiveSyntax>
            {
            }

            ;
            SyntaxList<UsingDirectiveSyntax> v2760 = Syntax.List<UsingDirectiveSyntax>(list2759);
            Roslyn.Compilers.CSharp.ClassDeclarationSyntax v2753 = this.f2753();
            List<MemberDeclarationSyntax> list2761 = new List<MemberDeclarationSyntax>
        {
        v2753
        }

            ;
            SyntaxList<MemberDeclarationSyntax> v2762 = Syntax.List<MemberDeclarationSyntax>(list2761);
            return Syntax.NamespaceDeclaration(namespaceKeyword: Syntax.Token(SyntaxKind.NamespaceKeyword), name: v2754, openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken), externs: v2758, usings: v2760, members: v2762, closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken), semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f2770()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2768 = Syntax.IdentifierName("Roslyn");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2767 = Syntax.IdentifierName("Compilers");
            return Syntax.QualifiedName(v2768, dotToken: Syntax.Token(SyntaxKind.DotToken), right: v2767);
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f2772()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v2770 = this.f2770();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2766 = Syntax.IdentifierName("CSharp");
            return Syntax.QualifiedName(v2770, dotToken: Syntax.Token(SyntaxKind.DotToken), right: v2766);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f2775()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v2772 = this.f2772();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword), aliasOpt: null, name: v2772, semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f2779()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2777 = Syntax.IdentifierName("Roslyn");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2776 = Syntax.IdentifierName("Compilers");
            return Syntax.QualifiedName(v2777, dotToken: Syntax.Token(SyntaxKind.DotToken), right: v2776);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f2782()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v2779 = this.f2779();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword), aliasOpt: null, name: v2779, semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f2786()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2784 = Syntax.IdentifierName("System");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2783 = Syntax.IdentifierName("Reflection");
            return Syntax.QualifiedName(v2784, dotToken: Syntax.Token(SyntaxKind.DotToken), right: v2783);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f2789()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v2786 = this.f2786();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword), aliasOpt: null, name: v2786, semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f2793()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2791 = Syntax.IdentifierName("System");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2790 = Syntax.IdentifierName("Text");
            return Syntax.QualifiedName(v2791, dotToken: Syntax.Token(SyntaxKind.DotToken), right: v2790);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f2796()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v2793 = this.f2793();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword), aliasOpt: null, name: v2793, semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f2800()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2798 = Syntax.IdentifierName("System");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2797 = Syntax.IdentifierName("Linq");
            return Syntax.QualifiedName(v2798, dotToken: Syntax.Token(SyntaxKind.DotToken), right: v2797);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f2803()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v2800 = this.f2800();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword), aliasOpt: null, name: v2800, semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f2808()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2806 = Syntax.IdentifierName("System");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2805 = Syntax.IdentifierName("Collections");
            return Syntax.QualifiedName(v2806, dotToken: Syntax.Token(SyntaxKind.DotToken), right: v2805);
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f2810()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v2808 = this.f2808();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2804 = Syntax.IdentifierName("Generic");
            return Syntax.QualifiedName(v2808, dotToken: Syntax.Token(SyntaxKind.DotToken), right: v2804);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f2813()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v2810 = this.f2810();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword), aliasOpt: null, name: v2810, semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f2817()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2814 = Syntax.IdentifierName("System");
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword), aliasOpt: null, name: v2814, semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        public Roslyn.Compilers.CSharp.CompilationUnitSyntax f2827()
        {
            List<ExternAliasDirectiveSyntax> list2818 = new List<ExternAliasDirectiveSyntax>
            {
            }

            ;
            SyntaxList<ExternAliasDirectiveSyntax> v2819 = Syntax.List<ExternAliasDirectiveSyntax>(list2818);
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v2817 = this.f2817();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v2813 = this.f2813();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v2803 = this.f2803();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v2796 = this.f2796();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v2789 = this.f2789();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v2782 = this.f2782();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v2775 = this.f2775();
            List<UsingDirectiveSyntax> list2820 = new List<UsingDirectiveSyntax>
        {
        v2817,v2813,v2803,v2796,v2789,v2782,v2775
        }

            ;
            SyntaxList<UsingDirectiveSyntax> v2821 = Syntax.List<UsingDirectiveSyntax>(list2820);
            List<AttributeDeclarationSyntax> list2822 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v2823 = Syntax.List<AttributeDeclarationSyntax>(list2822);
            Roslyn.Compilers.CSharp.NamespaceDeclarationSyntax v2765 = this.f2765();
            List<MemberDeclarationSyntax> list2824 = new List<MemberDeclarationSyntax>
        {
        v2765
        }

            ;
            SyntaxList<MemberDeclarationSyntax> v2825 = Syntax.List<MemberDeclarationSyntax>(list2824);
            return Syntax.CompilationUnit(externs: v2819, usings: v2821, attributes: v2823, members: v2825, endOfFileToken: Syntax.Token(SyntaxKind.EndOfFileToken));
        }
    }
}
