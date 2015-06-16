using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.CodeAnalysis.Syntax;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

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

        protected virtual ArgumentListSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2_2()
        {
            return SyntaxFactory.ArgumentList(SyntaxFactory.Token(SyntaxKind.OpenParenToken), SyntaxFactory.SeparatedList<ArgumentSyntax>(this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2_2_arguments()), SyntaxFactory.Token(SyntaxKind.CloseParenToken));
        }

        protected virtual InvocationExpressionSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2()
        {
            return SyntaxFactory.InvocationExpression(SyntaxFactory.IdentifierName("CompilationUnit"), this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2_2());
        }

        protected virtual ReturnStatementSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2()
        {
            return SyntaxFactory.ReturnStatement(SyntaxFactory.Token(SyntaxKind.ReturnKeyword), this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2_2(), SyntaxFactory.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual List<StatementSyntax> Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_statements()
        {
            return new List<StatementSyntax>
            {
            this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_2()}

            ;
        }

        protected virtual BlockSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5()
        {
            return SyntaxFactory.Block(SyntaxFactory.Token(SyntaxKind.OpenBraceToken), SyntaxFactory.List<StatementSyntax>(this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5_statements()), SyntaxFactory.Token(SyntaxKind.CloseBraceToken));
        }

        protected virtual List<SyntaxNodeOrToken> Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_4_parameters()
        {
            return new List<SyntaxNodeOrToken>
            {
            }

            ;
        }

        protected virtual ParameterListSyntax Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_4()
        {
            return SyntaxFactory.ParameterList(SyntaxFactory.Token(SyntaxKind.OpenParenToken), SyntaxFactory.SeparatedList<ParameterSyntax>(this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_4_parameters()), SyntaxFactory.Token(SyntaxKind.CloseParenToken));
        }

        protected virtual List<AttributeListSyntax> GetCompilationUnitGenerator_attributeLists()
        {
            return new List<AttributeListSyntax>
            {
            }

            ;
        }

        protected virtual List<SyntaxToken> GetCompilationUnitGenerator_modifiers()
        {
            return new List<SyntaxToken>
            {
            SyntaxFactory.Token(SyntaxKind.PublicKeyword)}

            ;
        }

        protected virtual SyntaxToken Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_GetCompilationUnit3_identifier()
        {
            return SyntaxFactory.Identifier("GetCompilationUnit");
        }

        protected virtual List<TypeParameterConstraintClauseSyntax> GetCompilationUnitGenerator_constraintClauses()
        {
            return new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
        }

        protected virtual MethodDeclarationSyntax GetCompilationUnitGenerator()
        {
            return SyntaxFactory.MethodDeclaration(SyntaxFactory.List<AttributeListSyntax>(this.GetCompilationUnitGenerator_attributeLists()), SyntaxFactory.TokenList(this.GetCompilationUnitGenerator_modifiers()), SyntaxFactory.IdentifierName("CompilationUnitSyntax"), null, this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_GetCompilationUnit3_identifier(), null, this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_4(), SyntaxFactory.List<TypeParameterConstraintClauseSyntax>(this.GetCompilationUnitGenerator_constraintClauses()), this.Ast_0_GenesisGenerator8_Generator4_GetCompilationUnit5_5(), SyntaxFactory.Token(SyntaxKind.None));
        }

        protected virtual List<AttributeListSyntax> GeneratorClass_attributeLists()
        {
            return new List<AttributeListSyntax>
            {
            }

            ;
        }

        protected virtual List<SyntaxToken> GeneratorClass_modifiers()
        {
            return new List<SyntaxToken>
            {
            SyntaxFactory.Token(SyntaxKind.PublicKeyword)}

            ;
        }

        protected virtual SyntaxToken Ast_0_GenesisGenerator8_Generator4_Generator3_identifier()
        {
            return SyntaxFactory.Identifier("Generator");
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

        protected virtual ClassDeclarationSyntax GeneratorClass()
        {
            return SyntaxFactory.ClassDeclaration(SyntaxFactory.List<AttributeListSyntax>(this.GeneratorClass_attributeLists()), SyntaxFactory.TokenList(this.GeneratorClass_modifiers()), SyntaxFactory.Token(SyntaxKind.ClassKeyword), this.Ast_0_GenesisGenerator8_Generator4_Generator3_identifier(), null, null, SyntaxFactory.List<TypeParameterConstraintClauseSyntax>(this.GeneratorClass_constraintClauses()), SyntaxFactory.Token(SyntaxKind.OpenBraceToken), SyntaxFactory.List<MemberDeclarationSyntax>(this.GeneratorClass_members()), SyntaxFactory.Token(SyntaxKind.CloseBraceToken), SyntaxFactory.Token(SyntaxKind.None));
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

        protected virtual NamespaceDeclarationSyntax Namespace()
        {
            return SyntaxFactory.NamespaceDeclaration(SyntaxFactory.Token(SyntaxKind.NamespaceKeyword), SyntaxFactory.IdentifierName("GenesisGenerator"), SyntaxFactory.Token(SyntaxKind.OpenBraceToken), SyntaxFactory.List<ExternAliasDirectiveSyntax>(this.Namespace_externs()), SyntaxFactory.List<UsingDirectiveSyntax>(this.Namespace_usings()), SyntaxFactory.List<MemberDeclarationSyntax>(this.Namespace_members()), SyntaxFactory.Token(SyntaxKind.CloseBraceToken), SyntaxFactory.Token(SyntaxKind.None));
        }

        protected virtual QualifiedNameSyntax Ast_0_7_2_1()
        {
            return SyntaxFactory.QualifiedName(SyntaxFactory.IdentifierName("Microsoft"), SyntaxFactory.Token(SyntaxKind.DotToken), SyntaxFactory.IdentifierName("CodeAnalysis"));
        }

        protected virtual QualifiedNameSyntax Ast_0_7_2()
        {
            return SyntaxFactory.QualifiedName(this.Ast_0_7_2_1(), SyntaxFactory.Token(SyntaxKind.DotToken), SyntaxFactory.IdentifierName("CSharp"));
        }

        protected virtual UsingDirectiveSyntax Ast_0_7()
        {
            return SyntaxFactory.UsingDirective(this.Ast_0_7_2());
        }

        protected virtual QualifiedNameSyntax Ast_0_6_2()
        {
            return SyntaxFactory.QualifiedName(SyntaxFactory.IdentifierName("Microsoft"), SyntaxFactory.Token(SyntaxKind.DotToken), SyntaxFactory.IdentifierName("CodeAnalysis"));
        }

        protected virtual UsingDirectiveSyntax Ast_0_6()
        {
            return SyntaxFactory.UsingDirective(this.Ast_0_6_2());
        }

        protected virtual QualifiedNameSyntax Ast_0_5_2()
        {
            return SyntaxFactory.QualifiedName(SyntaxFactory.IdentifierName("System"), SyntaxFactory.Token(SyntaxKind.DotToken), SyntaxFactory.IdentifierName("Reflection"));
        }

        protected virtual UsingDirectiveSyntax Ast_0_5()
        {
            return SyntaxFactory.UsingDirective(this.Ast_0_5_2());
        }

        protected virtual QualifiedNameSyntax Ast_0_4_2()
        {
            return SyntaxFactory.QualifiedName(SyntaxFactory.IdentifierName("System"), SyntaxFactory.Token(SyntaxKind.DotToken), SyntaxFactory.IdentifierName("Text"));
        }

        protected virtual UsingDirectiveSyntax Ast_0_4()
        {
            return SyntaxFactory.UsingDirective(this.Ast_0_4_2());
        }

        protected virtual QualifiedNameSyntax Ast_0_3_2()
        {
            return SyntaxFactory.QualifiedName(SyntaxFactory.IdentifierName("System"), SyntaxFactory.Token(SyntaxKind.DotToken), SyntaxFactory.IdentifierName("Linq"));
        }

        protected virtual UsingDirectiveSyntax Ast_0_3()
        {
            return SyntaxFactory.UsingDirective(this.Ast_0_3_2());
        }

        protected virtual QualifiedNameSyntax Ast_0_2_2_1()
        {
            return SyntaxFactory.QualifiedName(SyntaxFactory.IdentifierName("System"), SyntaxFactory.Token(SyntaxKind.DotToken), SyntaxFactory.IdentifierName("Collections"));
        }

        protected virtual QualifiedNameSyntax Ast_0_2_2()
        {
            return SyntaxFactory.QualifiedName(this.Ast_0_2_2_1(), SyntaxFactory.Token(SyntaxKind.DotToken), SyntaxFactory.IdentifierName("Generic"));
        }

        protected virtual UsingDirectiveSyntax SecondUsing()
        {
            return SyntaxFactory.UsingDirective(this.Ast_0_2_2());
        }

        protected virtual UsingDirectiveSyntax FirstUsing()
        {
            return SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System"));
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

        protected virtual CompilationUnitSyntax CompilationUnit()
        {
            return SyntaxFactory.CompilationUnit(SyntaxFactory.List<ExternAliasDirectiveSyntax>(this.CompilationUnit_externs()), SyntaxFactory.List<UsingDirectiveSyntax>(this.CompilationUnit_usings()), SyntaxFactory.List<AttributeListSyntax>(this.CompilationUnit_attributeLists()), SyntaxFactory.List<MemberDeclarationSyntax>(this.CompilationUnit_members()), SyntaxFactory.Token(SyntaxKind.EndOfFileToken));
        }

        public CompilationUnitSyntax GetCompilationUnit()
        {
            return CompilationUnit();
        }
    }
}