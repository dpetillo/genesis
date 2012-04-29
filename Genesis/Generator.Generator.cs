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
        protected virtual List<SyntaxNodeOrToken> ast0n8n4n5n5n2n2n2arguments()
        {
            return new List<SyntaxNodeOrToken>
            {
            }

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.ArgumentListSyntax ast0n8n4n5n5n2n2n2()
        {
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: Syntax.SeparatedList<ArgumentSyntax>(this.ast0n8n4n5n5n2n2n2arguments()),closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        protected virtual Roslyn.Compilers.CSharp.InvocationExpressionSyntax ast0n8n4n5n5n2n2()
        {
            return Syntax.InvocationExpression(Syntax.IdentifierName("ast0"),this.ast0n8n4n5n5n2n2n2());
        }

        protected virtual Roslyn.Compilers.CSharp.ReturnStatementSyntax ast0n8n4n5n5n2()
        {
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: this.ast0n8n4n5n5n2n2(),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual List<StatementSyntax> ast0n8n4n5n5statements()
        {
            return new List<StatementSyntax>
            {
            this.ast0n8n4n5n5n2()}

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.BlockSyntax ast0n8n4n5n5()
        {
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: Syntax.List<StatementSyntax>(this.ast0n8n4n5n5statements()),closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        protected virtual List<SyntaxNodeOrToken> ast0n8n4n5n4parameters()
        {
            return new List<SyntaxNodeOrToken>
            {
            }

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.ParameterListSyntax ast0n8n4n5n4()
        {
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: Syntax.SeparatedList<ParameterSyntax>(this.ast0n8n4n5n4parameters()),closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        protected virtual List<AttributeDeclarationSyntax> ast0n8n4n5attributes()
        {
            return new List<AttributeDeclarationSyntax>
            {
            }

            ;
        }

        protected virtual List<Roslyn.Compilers.CSharp.SyntaxToken> ast0n8n4n5modifiers()
        {
            return new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PublicKeyword)}

            ;
        }

        protected virtual SyntaxToken ast0n8n4n5n3()
        {
            return Syntax.Identifier("GetCompilationUnit");
        }

        protected virtual List<TypeParameterConstraintClauseSyntax> ast0n8n4n5constraintClauses()
        {
            return new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.MethodDeclarationSyntax ast0n8n4n5()
        {
            return Syntax.MethodDeclaration(attributes: Syntax.List<AttributeDeclarationSyntax>(this.ast0n8n4n5attributes()),modifiers: Syntax.TokenList(this.ast0n8n4n5modifiers()),returnType: Syntax.IdentifierName("CompilationUnitSyntax"),explicitInterfaceSpecifierOpt: null ,identifier: this.ast0n8n4n5n3(),typeParameterListOpt: null ,parameterList: this.ast0n8n4n5n4(),constraintClauses: Syntax.List<TypeParameterConstraintClauseSyntax>(this.ast0n8n4n5constraintClauses()),bodyOpt: this.ast0n8n4n5n5(),semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        protected virtual List<AttributeDeclarationSyntax> ast0n8n4attributes()
        {
            return new List<AttributeDeclarationSyntax>
            {
            }

            ;
        }

        protected virtual List<Roslyn.Compilers.CSharp.SyntaxToken> ast0n8n4modifiers()
        {
            return new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PublicKeyword)}

            ;
        }

        protected virtual SyntaxToken ast0n8n4n3()
        {
            return Syntax.Identifier("Generator");
        }

        protected virtual List<TypeParameterConstraintClauseSyntax> ast0n8n4constraintClauses()
        {
            return new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
        }

        protected virtual List<MemberDeclarationSyntax> ast0n8n4members()
        {
            return new List<MemberDeclarationSyntax>
            {
            this.ast0n8n4n5()}

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.ClassDeclarationSyntax ast0n8n4()
        {
            return Syntax.ClassDeclaration(attributes: Syntax.List<AttributeDeclarationSyntax>(this.ast0n8n4attributes()),modifiers: Syntax.TokenList(this.ast0n8n4modifiers()),keyword: Syntax.Token(SyntaxKind.ClassKeyword),identifier: this.ast0n8n4n3(),typeParameterListOpt: null ,baseListOpt: null ,constraintClauses: Syntax.List<TypeParameterConstraintClauseSyntax>(this.ast0n8n4constraintClauses()),openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),members: Syntax.List<MemberDeclarationSyntax>(this.ast0n8n4members()),closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken),semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        protected virtual List<ExternAliasDirectiveSyntax> ast0n8externs()
        {
            return new List<ExternAliasDirectiveSyntax>
            {
            }

            ;
        }

        protected virtual List<UsingDirectiveSyntax> ast0n8usings()
        {
            return new List<UsingDirectiveSyntax>
            {
            }

            ;
        }

        protected virtual List<MemberDeclarationSyntax> ast0n8members()
        {
            return new List<MemberDeclarationSyntax>
            {
            this.ast0n8n4()}

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.NamespaceDeclarationSyntax ast0n8()
        {
            return Syntax.NamespaceDeclaration(namespaceKeyword: Syntax.Token(SyntaxKind.NamespaceKeyword),name: Syntax.IdentifierName("GenesisGenerator"),openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),externs: Syntax.List<ExternAliasDirectiveSyntax>(this.ast0n8externs()),usings: Syntax.List<UsingDirectiveSyntax>(this.ast0n8usings()),members: Syntax.List<MemberDeclarationSyntax>(this.ast0n8members()),closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken),semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax ast0n7n2n1()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("Roslyn"),dotToken: Syntax.Token(SyntaxKind.DotToken),right: Syntax.IdentifierName("Compilers"));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax ast0n7n2()
        {
            return Syntax.QualifiedName(this.ast0n7n2n1(),dotToken: Syntax.Token(SyntaxKind.DotToken),right: Syntax.IdentifierName("CSharp"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax ast0n7()
        {
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: this.ast0n7n2(),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax ast0n6n2()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("Roslyn"),dotToken: Syntax.Token(SyntaxKind.DotToken),right: Syntax.IdentifierName("Compilers"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax ast0n6()
        {
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: this.ast0n6n2(),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax ast0n5n2()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("System"),dotToken: Syntax.Token(SyntaxKind.DotToken),right: Syntax.IdentifierName("Reflection"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax ast0n5()
        {
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: this.ast0n5n2(),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax ast0n4n2()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("System"),dotToken: Syntax.Token(SyntaxKind.DotToken),right: Syntax.IdentifierName("Text"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax ast0n4()
        {
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: this.ast0n4n2(),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax ast0n3n2()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("System"),dotToken: Syntax.Token(SyntaxKind.DotToken),right: Syntax.IdentifierName("Linq"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax ast0n3()
        {
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: this.ast0n3n2(),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax ast0n2n2n1()
        {
            return Syntax.QualifiedName(Syntax.IdentifierName("System"),dotToken: Syntax.Token(SyntaxKind.DotToken),right: Syntax.IdentifierName("Collections"));
        }

        protected virtual Roslyn.Compilers.CSharp.QualifiedNameSyntax ast0n2n2()
        {
            return Syntax.QualifiedName(this.ast0n2n2n1(),dotToken: Syntax.Token(SyntaxKind.DotToken),right: Syntax.IdentifierName("Generic"));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax ast0n2()
        {
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: this.ast0n2n2(),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual Roslyn.Compilers.CSharp.UsingDirectiveSyntax ast0n1()
        {
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: Syntax.IdentifierName("System"),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        protected virtual List<ExternAliasDirectiveSyntax> ast0externs()
        {
            return new List<ExternAliasDirectiveSyntax>
            {
            }

            ;
        }

        protected virtual List<UsingDirectiveSyntax> ast0usings()
        {
            return new List<UsingDirectiveSyntax>
            {
            this.ast0n1(),this.ast0n2(),this.ast0n3(),this.ast0n4(),this.ast0n5(),this.ast0n6(),this.ast0n7()}

            ;
        }

        protected virtual List<AttributeDeclarationSyntax> ast0attributes()
        {
            return new List<AttributeDeclarationSyntax>
            {
            }

            ;
        }

        protected virtual List<MemberDeclarationSyntax> ast0members()
        {
            return new List<MemberDeclarationSyntax>
            {
            this.ast0n8()}

            ;
        }

        protected virtual Roslyn.Compilers.CSharp.CompilationUnitSyntax ast0()
        {
            return Syntax.CompilationUnit(externs: Syntax.List<ExternAliasDirectiveSyntax>(this.ast0externs()),usings: Syntax.List<UsingDirectiveSyntax>(this.ast0usings()),attributes: Syntax.List<AttributeDeclarationSyntax>(this.ast0attributes()),members: Syntax.List<MemberDeclarationSyntax>(this.ast0members()),endOfFileToken: Syntax.Token(SyntaxKind.EndOfFileToken));
        }

        public CompilationUnitSyntax GetCompilationUnit()
        {
            return ast0();
        }
    }
}