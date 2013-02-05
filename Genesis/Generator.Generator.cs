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
        protected virtual List<SyntaxNodeOrToken> Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2_2_arguments()
        {
            return new List<SyntaxNodeOrToken>
            {
            }

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.ArgumentListSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2_2()
        {
            return Syntax.ArgumentList(Syntax.Token(SyntaxKind.OpenParenToken), Syntax.SeparatedList<ArgumentSyntax>(this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2_2_arguments()), Syntax.Token(SyntaxKind.CloseParenToken));
        }

        protected virtual Roslyn.Compilers.CSharp.InvocationExpressionSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2()
        {
            return Syntax.InvocationExpression(Syntax.IdentifierName("CompilationUnit"), this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2_2());
        }

        protected virtual Roslyn.Compilers.CSharp.ReturnStatementSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2()
        {
            return Syntax.ReturnStatement(Syntax.Token(SyntaxKind.ReturnKeyword), this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2(), Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual List<StatementSyntax> Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_statements()
        {
            return new List<StatementSyntax>
            {
            this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2()}

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.BlockSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5()
        {
            return Syntax.Block(Syntax.Token(SyntaxKind.OpenBraceToken), Syntax.List<StatementSyntax>(this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_statements()), Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        protected virtual List<SyntaxNodeOrToken> Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_4_parameters()
        {
            return new List<SyntaxNodeOrToken>
            {
            }

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.ParameterListSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_4()
        {
            return Syntax.ParameterList(Syntax.Token(SyntaxKind.OpenParenToken), Syntax.SeparatedList<ParameterSyntax>(this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_4_parameters()), Syntax.Token(SyntaxKind.CloseParenToken));
        }

        protected virtual List<AttributeListSyntax> GetCompilationUnitGenerator_attributeLists()
        {
            return new List<AttributeListSyntax>
            {
            }

            ;
        }

        protected virtual List<Roslyn.Compilers.CSharp.SyntaxToken> GetCompilationUnitGenerator_modifiers()
        {
            return new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PublicKeyword)}

            ;
        }

        protected virtual SyntaxToken Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_GetCompilationUnit3_identifier()
        {
            return Syntax.Identifier("GetCompilationUnit");
        }

        protected virtual List<TypeParameterConstraintClauseSyntax> GetCompilationUnitGenerator_constraintClauses()
        {
            return new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.MethodDeclarationSyntax GetCompilationUnitGenerator()
        {
            return Syntax.MethodDeclaration(Syntax.List<AttributeListSyntax>(this.GetCompilationUnitGenerator_attributeLists()), Syntax.TokenList(this.GetCompilationUnitGenerator_modifiers()), Syntax.IdentifierName("CompilationUnitSyntax"), null, this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_GetCompilationUnit3_identifier(), null, this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_4(), Syntax.List<TypeParameterConstraintClauseSyntax>(this.GetCompilationUnitGenerator_constraintClauses()), this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5(), Syntax.Token(SyntaxKind.None));
        }

        protected virtual List<AttributeListSyntax> GeneratorClass_attributeLists()
        {
            return new List<AttributeListSyntax>
            {
            }

            ;
        }

        protected virtual List<Roslyn.Compilers.CSharp.SyntaxToken> GeneratorClass_modifiers()
        {
            return new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PublicKeyword)}

            ;
        }

        protected virtual SyntaxToken Ast_0_GenesisGenerator8_Generator4_Generator3_identifier()
        {
            return Syntax.Identifier("Generator");
        }

        protected virtual List<TypeParameterConstraintClauseSyntax> GeneratorClass_constraintClauses()
        {
            return new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
        }

        protected virtual List<MemberDeclarationSyntax> GeneratorClass_members()
        {
            return new List<MemberDeclarationSyntax>
            {
            this.GetCompilationUnitGenerator()}

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.ClassDeclarationSyntax GeneratorClass()
        {
            return Syntax.ClassDeclaration(Syntax.List<AttributeListSyntax>(this.GeneratorClass_attributeLists()), Syntax.TokenList(this.GeneratorClass_modifiers()), Syntax.Token(SyntaxKind.ClassKeyword), this.Ast_0_GenesisGenerator8_Generator4_Generator3_identifier(), null, null, Syntax.List<TypeParameterConstraintClauseSyntax>(this.GeneratorClass_constraintClauses()), Syntax.Token(SyntaxKind.OpenBraceToken), Syntax.List<MemberDeclarationSyntax>(this.GeneratorClass_members()), Syntax.Token(SyntaxKind.CloseBraceToken), Syntax.Token(SyntaxKind.None));
        }

        protected virtual List<ExternAliasDirectiveSyntax> Namespace_externs()
        {
            return new List<ExternAliasDirectiveSyntax>
            {
            }

            ;
        }

        protected virtual List<UsingDirectiveSyntax> Namespace_usings()
        {
            return new List<UsingDirectiveSyntax>
            {
            }

            ;
        }

        protected virtual List<MemberDeclarationSyntax> Namespace_members()
        {
            return new List<MemberDeclarationSyntax>
            {
            this.GeneratorClass()}

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.NamespaceDeclarationSyntax Namespace()
        {
            return Syntax.NamespaceDeclaration(Syntax.Token(SyntaxKind.NamespaceKeyword), Syntax.IdentifierName("GenesisGenerator"), Syntax.Token(SyntaxKind.OpenBraceToken), Syntax.List<ExternAliasDirectiveSyntax>(this.Namespace_externs()), Syntax.List<UsingDirectiveSyntax>(this.Namespace_usings()), Syntax.List<MemberDeclarationSyntax>(this.Namespace_members()), Syntax.Token(SyntaxKind.CloseBraceToken), Syntax.Token(SyntaxKind.None));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax Ast_0_7_2_1()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("Roslyn"), Syntax.Token(SyntaxKind.DotToken), Syntax.IdentifierName("Compilers"));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax Ast_0_7_2()
        {
            return Syntax.QualifiedName(this.Ast_0_7_2_1(), Syntax.Token(SyntaxKind.DotToken), Syntax.IdentifierName("CSharp"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax Ast_0_7()
        {
            return Syntax.UsingDirective(Syntax.Token(SyntaxKind.UsingKeyword), null, this.Ast_0_7_2(), Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax Ast_0_6_2()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("Roslyn"), Syntax.Token(SyntaxKind.DotToken), Syntax.IdentifierName("Compilers"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax Ast_0_6()
        {
            return Syntax.UsingDirective(Syntax.Token(SyntaxKind.UsingKeyword), null, this.Ast_0_6_2(), Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax Ast_0_5_2()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("System"), Syntax.Token(SyntaxKind.DotToken), Syntax.IdentifierName("Reflection"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax Ast_0_5()
        {
            return Syntax.UsingDirective(Syntax.Token(SyntaxKind.UsingKeyword), null, this.Ast_0_5_2(), Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax Ast_0_4_2()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("System"), Syntax.Token(SyntaxKind.DotToken), Syntax.IdentifierName("Text"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax Ast_0_4()
        {
            return Syntax.UsingDirective(Syntax.Token(SyntaxKind.UsingKeyword), null, this.Ast_0_4_2(), Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax Ast_0_3_2()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("System"), Syntax.Token(SyntaxKind.DotToken), Syntax.IdentifierName("Linq"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax Ast_0_3()
        {
            return Syntax.UsingDirective(Syntax.Token(SyntaxKind.UsingKeyword), null, this.Ast_0_3_2(), Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax Ast_0_2_2_1()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("System"), Syntax.Token(SyntaxKind.DotToken), Syntax.IdentifierName("Collections"));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax Ast_0_2_2()
        {
            return Syntax.QualifiedName(this.Ast_0_2_2_1(), Syntax.Token(SyntaxKind.DotToken), Syntax.IdentifierName("Generic"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax SecondUsing()
        {
            return Syntax.UsingDirective(Syntax.Token(SyntaxKind.UsingKeyword), null, this.Ast_0_2_2(), Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax FirstUsing()
        {
            return Syntax.UsingDirective(Syntax.Token(SyntaxKind.UsingKeyword), null, Syntax.IdentifierName("System"), Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual List<ExternAliasDirectiveSyntax> CompilationUnit_externs()
        {
            return new List<ExternAliasDirectiveSyntax>
            {
            }

            ;
        }

        protected virtual List<UsingDirectiveSyntax> CompilationUnit_usings()
        {
            return new List<UsingDirectiveSyntax>
            {
            this.FirstUsing(),this.SecondUsing(),this.Ast_0_3(),this.Ast_0_4(),this.Ast_0_5(),this.Ast_0_6(),this.Ast_0_7()}

            ;
        }

        protected virtual List<AttributeListSyntax> CompilationUnit_attributeLists()
        {
            return new List<AttributeListSyntax>
            {
            }

            ;
        }

        protected virtual List<MemberDeclarationSyntax> CompilationUnit_members()
        {
            return new List<MemberDeclarationSyntax>
            {
            this.Namespace()}

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.CompilationUnitSyntax CompilationUnit()
        {
            return Syntax.CompilationUnit(Syntax.List<ExternAliasDirectiveSyntax>(this.CompilationUnit_externs()), Syntax.List<UsingDirectiveSyntax>(this.CompilationUnit_usings()), Syntax.List<AttributeListSyntax>(this.CompilationUnit_attributeLists()), Syntax.List<MemberDeclarationSyntax>(this.CompilationUnit_members()), Syntax.Token(SyntaxKind.EndOfFileToken));
        }

        public CompilationUnitSyntax GetCompilationUnit()
        {
            return CompilationUnit();
        }
    }
}