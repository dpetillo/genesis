using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CodeBootStrap
{
    partial class Generator
    {
        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f3()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v3 = this.f3();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1 = Syntax.IdentifierName("Empty");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f7()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5 = this.f5();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f9()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Syntax\"", "\"Syntax\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f11()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v9 = this.f9();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v9);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f17()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v11 = this.f11();
            Roslyn.Compilers.CSharp.ArgumentSyntax v7 = this.f7();
            List<SyntaxNodeOrToken> list14 = new List<SyntaxNodeOrToken>
            {
            v11,Syntax.Token(SyntaxKind.CommaToken),v7
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v15 = Syntax.SeparatedList<ArgumentSyntax>(list14);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v15,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f22()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v20 = Syntax.IdentifierName("syntaxNodeType");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v19 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v20,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v19);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f24()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v22 = this.f22();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v18 = Syntax.IdentifierName("Replace");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v22,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v18);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f25()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v24 = this.f24();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v17 = this.f17();
            return Syntax.InvocationExpression(v24,v17);
        }

        Roslyn.Compilers.CSharp.ReturnStatementSyntax f28()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v25 = this.f25();
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: v25,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f33()
        {
            Roslyn.Compilers.CSharp.ReturnStatementSyntax v28 = this.f28();
            List<StatementSyntax> list30 = new List<StatementSyntax>
            {
            v28
            }

            ;
            SyntaxList<StatementSyntax> v31 = Syntax.List<StatementSyntax>(list30);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v31,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f40()
        {
            List<AttributeDeclarationSyntax> list35 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v36 = Syntax.List<AttributeDeclarationSyntax>(list35);
            List<SyntaxToken> list37 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v38 = Syntax.TokenList(list37);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v34 = Syntax.IdentifierName("Type");
            return Syntax.Parameter(attributes: v36,modifiers: v38,typeOpt: v34,identifier: Syntax.Identifier("syntaxNodeType"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f45()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v40 = this.f40();
            List<SyntaxNodeOrToken> list42 = new List<SyntaxNodeOrToken>
            {
            v40
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v43 = Syntax.SeparatedList<ParameterSyntax>(list42);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v43,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f47()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f58()
        {
            List<AttributeDeclarationSyntax> list48 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v49 = Syntax.List<AttributeDeclarationSyntax>(list48);
            List<SyntaxToken> list52 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PrivateKeyword),Syntax.Token(SyntaxKind.StaticKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v53 = Syntax.TokenList(list52);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v47 = this.f47();
            Roslyn.Compilers.CSharp.ParameterListSyntax v45 = this.f45();
            List<TypeParameterConstraintClauseSyntax> list55 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v56 = Syntax.List<TypeParameterConstraintClauseSyntax>(list55);
            Roslyn.Compilers.CSharp.BlockSyntax v33 = this.f33();
            return Syntax.MethodDeclaration(attributes: v49,modifiers: v53,returnType: v47,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("GetApiCreateMethod"),typeParameterListOpt: null ,parameterList: v45,constraintClauses: v56,bodyOpt: v33,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f62()
        {
            return Syntax.NameColon(Syntax.Identifier("expression"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f64()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v62 = this.f62();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v59 = Syntax.IdentifierName("exp");
            return Syntax.Argument(nameColonOpt: v62,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v59);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f69()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v64 = this.f64();
            List<SyntaxNodeOrToken> list66 = new List<SyntaxNodeOrToken>
            {
            v64
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v67 = Syntax.SeparatedList<ArgumentSyntax>(list66);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v67,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f73()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v71 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v70 = Syntax.IdentifierName("Argument");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v71,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v70);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f74()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v73 = this.f73();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v69 = this.f69();
            return Syntax.InvocationExpression(v73,v69);
        }

        Roslyn.Compilers.CSharp.ReturnStatementSyntax f77()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v74 = this.f74();
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: v74,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f82()
        {
            Roslyn.Compilers.CSharp.ReturnStatementSyntax v77 = this.f77();
            List<StatementSyntax> list79 = new List<StatementSyntax>
            {
            v77
            }

            ;
            SyntaxList<StatementSyntax> v80 = Syntax.List<StatementSyntax>(list79);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v80,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f84()
        {
            Roslyn.Compilers.CSharp.BlockSyntax v82 = this.f82();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v82);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f88()
        {
            return Syntax.NameColon(Syntax.Identifier("expression"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f90()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v88 = this.f88();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v85 = Syntax.IdentifierName("exp");
            return Syntax.Argument(nameColonOpt: v88,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v85);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f93()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v91 = Syntax.IdentifierName("name");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v91);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f98()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v93 = this.f93();
            List<SyntaxNodeOrToken> list95 = new List<SyntaxNodeOrToken>
            {
            v93
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v96 = Syntax.SeparatedList<ArgumentSyntax>(list95);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v96,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f102()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v100 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v99 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v100,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v99);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f103()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v102 = this.f102();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v98 = this.f98();
            return Syntax.InvocationExpression(v102,v98);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f105()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v103 = this.f103();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v103);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f110()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v105 = this.f105();
            List<SyntaxNodeOrToken> list107 = new List<SyntaxNodeOrToken>
            {
            v105
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v108 = Syntax.SeparatedList<ArgumentSyntax>(list107);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v108,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f114()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v112 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v111 = Syntax.IdentifierName("NameColon");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v112,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v111);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f115()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v114 = this.f114();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v110 = this.f110();
            return Syntax.InvocationExpression(v114,v110);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f118()
        {
            return Syntax.NameColon(Syntax.Identifier("nameColonOpt"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f120()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v118 = this.f118();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v115 = this.f115();
            return Syntax.Argument(nameColonOpt: v118,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v115);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f126()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v120 = this.f120();
            Roslyn.Compilers.CSharp.ArgumentSyntax v90 = this.f90();
            List<SyntaxNodeOrToken> list123 = new List<SyntaxNodeOrToken>
            {
            v120,Syntax.Token(SyntaxKind.CommaToken),v90
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v124 = Syntax.SeparatedList<ArgumentSyntax>(list123);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v124,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f130()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v128 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v127 = Syntax.IdentifierName("Argument");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v128,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v127);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f131()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v130 = this.f130();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v126 = this.f126();
            return Syntax.InvocationExpression(v130,v126);
        }

        Roslyn.Compilers.CSharp.ReturnStatementSyntax f134()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v131 = this.f131();
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: v131,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f139()
        {
            Roslyn.Compilers.CSharp.ReturnStatementSyntax v134 = this.f134();
            List<StatementSyntax> list136 = new List<StatementSyntax>
            {
            v134
            }

            ;
            SyntaxList<StatementSyntax> v137 = Syntax.List<StatementSyntax>(list136);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v137,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f141()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f144()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v142 = Syntax.IdentifierName("name");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v141 = this.f141();
            return Syntax.BinaryExpression(SyntaxKind.NotEqualsExpression,v142,operatorToken: Syntax.Token(SyntaxKind.ExclamationEqualsToken),right: v141);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f148()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v144 = this.f144();
            Roslyn.Compilers.CSharp.BlockSyntax v139 = this.f139();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v84 = this.f84();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v144,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v139,elseOpt: v84);
        }

        Roslyn.Compilers.CSharp.BlockSyntax f153()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v148 = this.f148();
            List<StatementSyntax> list150 = new List<StatementSyntax>
            {
            v148
            }

            ;
            SyntaxList<StatementSyntax> v151 = Syntax.List<StatementSyntax>(list150);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v151,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f155()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f157()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v155 = this.f155();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v155);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f159()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f165()
        {
            List<AttributeDeclarationSyntax> list160 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v161 = Syntax.List<AttributeDeclarationSyntax>(list160);
            List<SyntaxToken> list162 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v163 = Syntax.TokenList(list162);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v159 = this.f159();
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v157 = this.f157();
            return Syntax.Parameter(attributes: v161,modifiers: v163,typeOpt: v159,identifier: Syntax.Identifier("name"),defaultOpt: v157);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f172()
        {
            List<AttributeDeclarationSyntax> list167 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v168 = Syntax.List<AttributeDeclarationSyntax>(list167);
            List<SyntaxToken> list169 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v170 = Syntax.TokenList(list169);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v166 = Syntax.IdentifierName("ExpressionSyntax");
            return Syntax.Parameter(attributes: v168,modifiers: v170,typeOpt: v166,identifier: Syntax.Identifier("exp"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f178()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v172 = this.f172();
            Roslyn.Compilers.CSharp.ParameterSyntax v165 = this.f165();
            List<SyntaxNodeOrToken> list175 = new List<SyntaxNodeOrToken>
            {
            v172,Syntax.Token(SyntaxKind.CommaToken),v165
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v176 = Syntax.SeparatedList<ParameterSyntax>(list175);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v176,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f190()
        {
            List<AttributeDeclarationSyntax> list180 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v181 = Syntax.List<AttributeDeclarationSyntax>(list180);
            List<SyntaxToken> list184 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PrivateKeyword),Syntax.Token(SyntaxKind.StaticKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v185 = Syntax.TokenList(list184);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v179 = Syntax.IdentifierName("ArgumentSyntax");
            Roslyn.Compilers.CSharp.ParameterListSyntax v178 = this.f178();
            List<TypeParameterConstraintClauseSyntax> list187 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v188 = Syntax.List<TypeParameterConstraintClauseSyntax>(list187);
            Roslyn.Compilers.CSharp.BlockSyntax v153 = this.f153();
            return Syntax.MethodDeclaration(attributes: v181,modifiers: v185,returnType: v179,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("CreateArgument"),typeParameterListOpt: null ,parameterList: v178,constraintClauses: v188,bodyOpt: v153,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f193()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v191 = Syntax.IdentifierName("ldSyntax");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v191);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f198()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v193 = this.f193();
            List<SyntaxNodeOrToken> list195 = new List<SyntaxNodeOrToken>
            {
            v193
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v196 = Syntax.SeparatedList<ArgumentSyntax>(list195);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v196,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ThisExpressionSyntax f202()
        {
            return Syntax.ThisExpression(token: Syntax.Token(SyntaxKind.ThisKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f204()
        {
            Roslyn.Compilers.CSharp.ThisExpressionSyntax v202 = this.f202();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v200 = Syntax.IdentifierName("syntaxNodeLocals");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v202,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v200);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f206()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v204 = this.f204();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v199 = Syntax.IdentifierName("Push");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v204,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v199);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f207()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v206 = this.f206();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v198 = this.f198();
            return Syntax.InvocationExpression(v206,v198);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f209()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v207 = this.f207();
            return Syntax.ExpressionStatement(v207,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f213()
        {
            return Syntax.NameColon(Syntax.Identifier("value"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f215()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v213 = this.f213();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v210 = Syntax.IdentifierName("localVarValue");
            return Syntax.Argument(nameColonOpt: v213,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v210);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f220()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v215 = this.f215();
            List<SyntaxNodeOrToken> list217 = new List<SyntaxNodeOrToken>
            {
            v215
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v218 = Syntax.SeparatedList<ArgumentSyntax>(list217);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v218,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f224()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v222 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v221 = Syntax.IdentifierName("EqualsValueClause");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v222,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v221);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f225()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v224 = this.f224();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v220 = this.f220();
            return Syntax.InvocationExpression(v224,v220);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f228()
        {
            return Syntax.NameColon(Syntax.Identifier("initializerOpt"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f230()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v228 = this.f228();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v225 = this.f225();
            return Syntax.Argument(nameColonOpt: v228,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v225);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f233()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v231 = Syntax.IdentifierName("varName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v231);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f238()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v233 = this.f233();
            List<SyntaxNodeOrToken> list235 = new List<SyntaxNodeOrToken>
            {
            v233
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v236 = Syntax.SeparatedList<ArgumentSyntax>(list235);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v236,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f242()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v240 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v239 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v240,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v239);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f243()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v242 = this.f242();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v238 = this.f238();
            return Syntax.InvocationExpression(v242,v238);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f246()
        {
            return Syntax.NameColon(Syntax.Identifier("identifier"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f248()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v246 = this.f246();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v243 = this.f243();
            return Syntax.Argument(nameColonOpt: v246,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v243);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f254()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v248 = this.f248();
            Roslyn.Compilers.CSharp.ArgumentSyntax v230 = this.f230();
            List<SyntaxNodeOrToken> list251 = new List<SyntaxNodeOrToken>
            {
            v248,Syntax.Token(SyntaxKind.CommaToken),v230
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v252 = Syntax.SeparatedList<ArgumentSyntax>(list251);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v252,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f258()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v256 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v255 = Syntax.IdentifierName("VariableDeclarator");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v256,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v255);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f259()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v258 = this.f258();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v254 = this.f254();
            return Syntax.InvocationExpression(v258,v254);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f261()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v259 = this.f259();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v259);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f266()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v261 = this.f261();
            List<SyntaxNodeOrToken> list263 = new List<SyntaxNodeOrToken>
            {
            v261
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v264 = Syntax.SeparatedList<ArgumentSyntax>(list263);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v264,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f272()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v267 = Syntax.IdentifierName("VariableDeclaratorSyntax");
            List<SyntaxNodeOrToken> list269 = new List<SyntaxNodeOrToken>
            {
            v267
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v270 = Syntax.SeparatedList<TypeSyntax>(list269);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v270,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f274()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v272 = this.f272();
            return Syntax.GenericName(Syntax.Identifier("SeparatedList"),v272);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f277()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v275 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.GenericNameSyntax v274 = this.f274();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v275,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v274);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f278()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v277 = this.f277();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v266 = this.f266();
            return Syntax.InvocationExpression(v277,v266);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f280()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v278 = this.f278();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v278);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f283()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v281 = Syntax.IdentifierName("typeSyntax");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v281);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f289()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v283 = this.f283();
            Roslyn.Compilers.CSharp.ArgumentSyntax v280 = this.f280();
            List<SyntaxNodeOrToken> list286 = new List<SyntaxNodeOrToken>
            {
            v283,Syntax.Token(SyntaxKind.CommaToken),v280
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v287 = Syntax.SeparatedList<ArgumentSyntax>(list286);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v287,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f293()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v291 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v290 = Syntax.IdentifierName("VariableDeclaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v291,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v290);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f294()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v293 = this.f293();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v289 = this.f289();
            return Syntax.InvocationExpression(v293,v289);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f297()
        {
            return Syntax.NameColon(Syntax.Identifier("declaration"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f299()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v297 = this.f297();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v294 = this.f294();
            return Syntax.Argument(nameColonOpt: v297,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v294);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f304()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v299 = this.f299();
            List<SyntaxNodeOrToken> list301 = new List<SyntaxNodeOrToken>
            {
            v299
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v302 = Syntax.SeparatedList<ArgumentSyntax>(list301);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v302,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f308()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v306 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v305 = Syntax.IdentifierName("LocalDeclarationStatement");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v306,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v305);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f309()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v308 = this.f308();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v304 = this.f304();
            return Syntax.InvocationExpression(v308,v304);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f311()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v309 = this.f309();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v309);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f313()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v311 = this.f311();
            return Syntax.VariableDeclarator(Syntax.Identifier("ldSyntax"),argumentListOpt: null ,initializerOpt: v311);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f317()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v314 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v313 = this.f313();
            List<SyntaxNodeOrToken> list315 = new List<SyntaxNodeOrToken>
            {
            v313
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v316 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list315);
            return Syntax.VariableDeclaration(v314,variables: v316);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f321()
        {
            List<SyntaxToken> list318 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v319 = Syntax.TokenList(list318);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v317 = this.f317();
            return Syntax.LocalDeclarationStatement(modifiers: v319,declaration: v317,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f326()
        {
            List<SyntaxNodeOrToken> list323 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v324 = Syntax.SeparatedList<ArgumentSyntax>(list323);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v324,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f330()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v328 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v327 = Syntax.IdentifierName("ArgumentList");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v328,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v327);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f331()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v330 = this.f330();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v326 = this.f326();
            return Syntax.InvocationExpression(v330,v326);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f333()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v331 = this.f331();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v331);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f336()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v334 = Syntax.IdentifierName("funcName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v334);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f341()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v336 = this.f336();
            List<SyntaxNodeOrToken> list338 = new List<SyntaxNodeOrToken>
            {
            v336
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v339 = Syntax.SeparatedList<ArgumentSyntax>(list338);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v339,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f345()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v343 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v342 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v343,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v342);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f346()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v345 = this.f345();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v341 = this.f341();
            return Syntax.InvocationExpression(v345,v341);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f349()
        {
            return Syntax.NameColon(Syntax.Identifier("name"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f351()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v349 = this.f349();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v346 = this.f346();
            return Syntax.Argument(nameColonOpt: v349,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v346);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f356()
        {
            List<SyntaxNodeOrToken> list353 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v354 = Syntax.SeparatedList<ArgumentSyntax>(list353);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v354,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f360()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v358 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v357 = Syntax.IdentifierName("ThisExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v358,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v357);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f361()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v360 = this.f360();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v356 = this.f356();
            return Syntax.InvocationExpression(v360,v356);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f363()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v361 = this.f361();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v361);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f367()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v365 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v364 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v365,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v364);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f369()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v367 = this.f367();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v367);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f376()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v369 = this.f369();
            Roslyn.Compilers.CSharp.ArgumentSyntax v363 = this.f363();
            Roslyn.Compilers.CSharp.ArgumentSyntax v351 = this.f351();
            List<SyntaxNodeOrToken> list373 = new List<SyntaxNodeOrToken>
            {
            v369,Syntax.Token(SyntaxKind.CommaToken),v363,Syntax.Token(SyntaxKind.CommaToken),v351
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v374 = Syntax.SeparatedList<ArgumentSyntax>(list373);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v374,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f380()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v378 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v377 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v378,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v377);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f381()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v380 = this.f380();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v376 = this.f376();
            return Syntax.InvocationExpression(v380,v376);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f383()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v381 = this.f381();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v381);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f389()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v383 = this.f383();
            Roslyn.Compilers.CSharp.ArgumentSyntax v333 = this.f333();
            List<SyntaxNodeOrToken> list386 = new List<SyntaxNodeOrToken>
            {
            v383,Syntax.Token(SyntaxKind.CommaToken),v333
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v387 = Syntax.SeparatedList<ArgumentSyntax>(list386);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v387,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f393()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v391 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v390 = Syntax.IdentifierName("InvocationExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v391,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v390);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f394()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v393 = this.f393();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v389 = this.f389();
            return Syntax.InvocationExpression(v393,v389);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f397()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v395 = Syntax.IdentifierName("localVarValue");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v394 = this.f394();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v395,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v394);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f399()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v397 = this.f397();
            return Syntax.ExpressionStatement(v397,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f402()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v400 = Syntax.IdentifierName("methodDef");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v400);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f407()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v402 = this.f402();
            List<SyntaxNodeOrToken> list404 = new List<SyntaxNodeOrToken>
            {
            v402
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v405 = Syntax.SeparatedList<ArgumentSyntax>(list404);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v405,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f411()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v409 = Syntax.IdentifierName("generated");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v408 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v409,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v408);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f412()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v411 = this.f411();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v407 = this.f407();
            return Syntax.InvocationExpression(v411,v407);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f414()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v412 = this.f412();
            return Syntax.ExpressionStatement(v412,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f419()
        {
            List<SyntaxNodeOrToken> list416 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v417 = Syntax.SeparatedList<ArgumentSyntax>(list416);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v417,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f423()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v421 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v420 = Syntax.IdentifierName("ParameterList");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v421,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v420);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f424()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v423 = this.f423();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v419 = this.f419();
            return Syntax.InvocationExpression(v423,v419);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f427()
        {
            return Syntax.NameColon(Syntax.Identifier("parameterList"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f429()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v427 = this.f427();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v424 = this.f424();
            return Syntax.Argument(nameColonOpt: v427,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v424);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f433()
        {
            return Syntax.NameColon(Syntax.Identifier("returnType"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f435()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v433 = this.f433();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v430 = Syntax.IdentifierName("typeSyntax");
            return Syntax.Argument(nameColonOpt: v433,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v430);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f439()
        {
            return Syntax.NameColon(Syntax.Identifier("bodyOpt"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f441()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v439 = this.f439();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v436 = Syntax.IdentifierName("blockSyntax");
            return Syntax.Argument(nameColonOpt: v439,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v436);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f444()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v442 = Syntax.IdentifierName("funcName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v442);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f449()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v444 = this.f444();
            List<SyntaxNodeOrToken> list446 = new List<SyntaxNodeOrToken>
            {
            v444
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v447 = Syntax.SeparatedList<ArgumentSyntax>(list446);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v447,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f453()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v451 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v450 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v451,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v450);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f454()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v453 = this.f453();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v449 = this.f449();
            return Syntax.InvocationExpression(v453,v449);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f457()
        {
            return Syntax.NameColon(Syntax.Identifier("identifier"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f459()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v457 = this.f457();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v454 = this.f454();
            return Syntax.Argument(nameColonOpt: v457,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v454);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f467()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v459 = this.f459();
            Roslyn.Compilers.CSharp.ArgumentSyntax v441 = this.f441();
            Roslyn.Compilers.CSharp.ArgumentSyntax v435 = this.f435();
            Roslyn.Compilers.CSharp.ArgumentSyntax v429 = this.f429();
            List<SyntaxNodeOrToken> list464 = new List<SyntaxNodeOrToken>
            {
            v459,Syntax.Token(SyntaxKind.CommaToken),v441,Syntax.Token(SyntaxKind.CommaToken),v435,Syntax.Token(SyntaxKind.CommaToken),v429
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v465 = Syntax.SeparatedList<ArgumentSyntax>(list464);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v465,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f471()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v469 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v468 = Syntax.IdentifierName("MethodDeclaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v469,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v468);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f472()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v471 = this.f471();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v467 = this.f467();
            return Syntax.InvocationExpression(v471,v467);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f474()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v472 = this.f472();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v472);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f476()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v474 = this.f474();
            return Syntax.VariableDeclarator(Syntax.Identifier("methodDef"),argumentListOpt: null ,initializerOpt: v474);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f480()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v477 = Syntax.IdentifierName("MethodDeclarationSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v476 = this.f476();
            List<SyntaxNodeOrToken> list478 = new List<SyntaxNodeOrToken>
            {
            v476
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v479 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list478);
            return Syntax.VariableDeclaration(v477,variables: v479);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f484()
        {
            List<SyntaxToken> list481 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v482 = Syntax.TokenList(list481);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v480 = this.f480();
            return Syntax.LocalDeclarationStatement(modifiers: v482,declaration: v480,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f487()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v485 = Syntax.IdentifierName("dependentVariableDefinitions");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v485);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f492()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v487 = this.f487();
            List<SyntaxNodeOrToken> list489 = new List<SyntaxNodeOrToken>
            {
            v487
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v490 = Syntax.SeparatedList<ArgumentSyntax>(list489);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v490,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f498()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v493 = Syntax.IdentifierName("SyntaxNode");
            List<SyntaxNodeOrToken> list495 = new List<SyntaxNodeOrToken>
            {
            v493
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v496 = Syntax.SeparatedList<TypeSyntax>(list495);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v496,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f500()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v498 = this.f498();
            return Syntax.GenericName(Syntax.Identifier("List"),v498);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f503()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v501 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.GenericNameSyntax v500 = this.f500();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v501,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v500);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f504()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v503 = this.f503();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v492 = this.f492();
            return Syntax.InvocationExpression(v503,v492);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f507()
        {
            return Syntax.NameColon(Syntax.Identifier("statements"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f509()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v507 = this.f507();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v504 = this.f504();
            return Syntax.Argument(nameColonOpt: v507,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v504);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f514()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v509 = this.f509();
            List<SyntaxNodeOrToken> list511 = new List<SyntaxNodeOrToken>
            {
            v509
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v512 = Syntax.SeparatedList<ArgumentSyntax>(list511);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v512,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f518()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v516 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v515 = Syntax.IdentifierName("Block");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v516,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v515);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f519()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v518 = this.f518();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v514 = this.f514();
            return Syntax.InvocationExpression(v518,v514);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f521()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v519 = this.f519();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v519);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f523()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v521 = this.f521();
            return Syntax.VariableDeclarator(Syntax.Identifier("blockSyntax"),argumentListOpt: null ,initializerOpt: v521);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f527()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v524 = Syntax.IdentifierName("BlockSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v523 = this.f523();
            List<SyntaxNodeOrToken> list525 = new List<SyntaxNodeOrToken>
            {
            v523
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v526 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list525);
            return Syntax.VariableDeclaration(v524,variables: v526);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f531()
        {
            List<SyntaxToken> list528 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v529 = Syntax.TokenList(list528);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v527 = this.f527();
            return Syntax.LocalDeclarationStatement(modifiers: v529,declaration: v527,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f535()
        {
            return Syntax.NameColon(Syntax.Identifier("expressionOpt"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f537()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v535 = this.f535();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v532 = Syntax.IdentifierName("ieSyntax");
            return Syntax.Argument(nameColonOpt: v535,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v532);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f542()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v537 = this.f537();
            List<SyntaxNodeOrToken> list539 = new List<SyntaxNodeOrToken>
            {
            v537
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v540 = Syntax.SeparatedList<ArgumentSyntax>(list539);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v540,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f546()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v544 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v543 = Syntax.IdentifierName("ReturnStatement");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v544,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v543);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f547()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v546 = this.f546();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v542 = this.f542();
            return Syntax.InvocationExpression(v546,v542);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f549()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v547 = this.f547();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v547);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f554()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v549 = this.f549();
            List<SyntaxNodeOrToken> list551 = new List<SyntaxNodeOrToken>
            {
            v549
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v552 = Syntax.SeparatedList<ArgumentSyntax>(list551);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v552,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f558()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v556 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v555 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v556,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v555);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f559()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v558 = this.f558();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v554 = this.f554();
            return Syntax.InvocationExpression(v558,v554);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f561()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v559 = this.f559();
            return Syntax.ExpressionStatement(v559,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f566()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v561 = this.f561();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v531 = this.f531();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v484 = this.f484();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v414 = this.f414();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v399 = this.f399();
            List<StatementSyntax> list563 = new List<StatementSyntax>
            {
            v561,v531,v484,v414,v399
            }

            ;
            SyntaxList<StatementSyntax> v564 = Syntax.List<StatementSyntax>(list563);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v564,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f568()
        {
            Roslyn.Compilers.CSharp.BlockSyntax v566 = this.f566();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v566);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f572()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v570 = Syntax.IdentifierName("localVarValue");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v569 = Syntax.IdentifierName("ieSyntax");
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v570,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v569);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f574()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v572 = this.f572();
            return Syntax.ExpressionStatement(v572,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f579()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v574 = this.f574();
            List<StatementSyntax> list576 = new List<StatementSyntax>
            {
            v574
            }

            ;
            SyntaxList<StatementSyntax> v577 = Syntax.List<StatementSyntax>(list576);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v577,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f581()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f584()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v582 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v581 = this.f581();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v582,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v581);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f588()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v584 = this.f584();
            Roslyn.Compilers.CSharp.BlockSyntax v579 = this.f579();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v568 = this.f568();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v584,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v579,elseOpt: v568);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f590()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f592()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v590 = this.f590();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v590);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f594()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v592 = this.f592();
            return Syntax.VariableDeclarator(Syntax.Identifier("localVarValue"),argumentListOpt: null ,initializerOpt: v592);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f598()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v595 = Syntax.IdentifierName("InvocationExpressionSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v594 = this.f594();
            List<SyntaxNodeOrToken> list596 = new List<SyntaxNodeOrToken>
            {
            v594
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v597 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list596);
            return Syntax.VariableDeclaration(v595,variables: v597);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f602()
        {
            List<SyntaxToken> list599 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v600 = Syntax.TokenList(list599);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v598 = this.f598();
            return Syntax.LocalDeclarationStatement(modifiers: v600,declaration: v598,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f606()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v604 = Syntax.IdentifierName("assignmentValue");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v603 = Syntax.IdentifierName("ieSyntax");
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v604,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v603);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f608()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v606 = this.f606();
            return Syntax.ExpressionStatement(v606,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f613()
        {
            List<SyntaxNodeOrToken> list610 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v611 = Syntax.SeparatedList<ArgumentSyntax>(list610);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v611,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f617()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v615 = Syntax.IdentifierName("separators");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v614 = Syntax.IdentifierName("ToArray");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v615,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v614);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f618()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v617 = this.f617();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v613 = this.f613();
            return Syntax.InvocationExpression(v617,v613);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f620()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v618 = this.f618();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v618);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f625()
        {
            List<SyntaxNodeOrToken> list622 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v623 = Syntax.SeparatedList<ArgumentSyntax>(list622);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v623,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f629()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v627 = Syntax.IdentifierName("arguments");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v626 = Syntax.IdentifierName("ToArray");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v627,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v626);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f630()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v629 = this.f629();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v625 = this.f625();
            return Syntax.InvocationExpression(v629,v625);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f632()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v630 = this.f630();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v630);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f638()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v632 = this.f632();
            Roslyn.Compilers.CSharp.ArgumentSyntax v620 = this.f620();
            List<SyntaxNodeOrToken> list635 = new List<SyntaxNodeOrToken>
            {
            v632,Syntax.Token(SyntaxKind.CommaToken),v620
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v636 = Syntax.SeparatedList<ArgumentSyntax>(list635);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v636,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f644()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v639 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list641 = new List<SyntaxNodeOrToken>
            {
            v639
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v642 = Syntax.SeparatedList<TypeSyntax>(list641);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v642,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f646()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v644 = this.f644();
            return Syntax.GenericName(Syntax.Identifier("SeparatedList"),v644);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f649()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v647 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.GenericNameSyntax v646 = this.f646();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v647,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v646);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f650()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v649 = this.f649();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v638 = this.f638();
            return Syntax.InvocationExpression(v649,v638);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f653()
        {
            return Syntax.NameColon(Syntax.Identifier("arguments"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f655()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v653 = this.f653();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v650 = this.f650();
            return Syntax.Argument(nameColonOpt: v653,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v650);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f660()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v655 = this.f655();
            List<SyntaxNodeOrToken> list657 = new List<SyntaxNodeOrToken>
            {
            v655
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v658 = Syntax.SeparatedList<ArgumentSyntax>(list657);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v658,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f664()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v662 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v661 = Syntax.IdentifierName("ArgumentList");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v662,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v661);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f665()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v664 = this.f664();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v660 = this.f660();
            return Syntax.InvocationExpression(v664,v660);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f667()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v665 = this.f665();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v665);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f671()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v669 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v668 = Syntax.IdentifierName("DotToken");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v669,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v668);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f673()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v671 = this.f671();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v671);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f678()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v673 = this.f673();
            List<SyntaxNodeOrToken> list675 = new List<SyntaxNodeOrToken>
            {
            v673
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v676 = Syntax.SeparatedList<ArgumentSyntax>(list675);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v676,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f682()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v680 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v679 = Syntax.IdentifierName("Token");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v680,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v679);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f683()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v682 = this.f682();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v678 = this.f678();
            return Syntax.InvocationExpression(v682,v678);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f686()
        {
            return Syntax.NameColon(Syntax.Identifier("operatorToken"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f688()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v686 = this.f686();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v683 = this.f683();
            return Syntax.Argument(nameColonOpt: v686,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v683);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f691()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v689 = Syntax.IdentifierName("createMethodName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v689);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f696()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v691 = this.f691();
            List<SyntaxNodeOrToken> list693 = new List<SyntaxNodeOrToken>
            {
            v691
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v694 = Syntax.SeparatedList<ArgumentSyntax>(list693);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v694,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f700()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v698 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v697 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v698,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v697);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f701()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v700 = this.f700();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v696 = this.f696();
            return Syntax.InvocationExpression(v700,v696);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f704()
        {
            return Syntax.NameColon(Syntax.Identifier("name"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f706()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v704 = this.f704();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v701 = this.f701();
            return Syntax.Argument(nameColonOpt: v704,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v701);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f708()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Syntax\"", "\"Syntax\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f710()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v708 = this.f708();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v708);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f715()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v710 = this.f710();
            List<SyntaxNodeOrToken> list712 = new List<SyntaxNodeOrToken>
            {
            v710
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v713 = Syntax.SeparatedList<ArgumentSyntax>(list712);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v713,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f719()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v717 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v716 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v717,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v716);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f720()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v719 = this.f719();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v715 = this.f715();
            return Syntax.InvocationExpression(v719,v715);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f723()
        {
            return Syntax.NameColon(Syntax.Identifier("expression"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f725()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v723 = this.f723();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v720 = this.f720();
            return Syntax.Argument(nameColonOpt: v723,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v720);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f729()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v727 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v726 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v727,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v726);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f732()
        {
            return Syntax.NameColon(Syntax.Identifier("kind"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f734()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v732 = this.f732();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v729 = this.f729();
            return Syntax.Argument(nameColonOpt: v732,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v729);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f742()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v734 = this.f734();
            Roslyn.Compilers.CSharp.ArgumentSyntax v725 = this.f725();
            Roslyn.Compilers.CSharp.ArgumentSyntax v706 = this.f706();
            Roslyn.Compilers.CSharp.ArgumentSyntax v688 = this.f688();
            List<SyntaxNodeOrToken> list739 = new List<SyntaxNodeOrToken>
            {
            v734,Syntax.Token(SyntaxKind.CommaToken),v725,Syntax.Token(SyntaxKind.CommaToken),v706,Syntax.Token(SyntaxKind.CommaToken),v688
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v740 = Syntax.SeparatedList<ArgumentSyntax>(list739);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v740,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f746()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v744 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v743 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v744,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v743);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f747()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v746 = this.f746();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v742 = this.f742();
            return Syntax.InvocationExpression(v746,v742);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f749()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v747 = this.f747();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v747);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f755()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v749 = this.f749();
            Roslyn.Compilers.CSharp.ArgumentSyntax v667 = this.f667();
            List<SyntaxNodeOrToken> list752 = new List<SyntaxNodeOrToken>
            {
            v749,Syntax.Token(SyntaxKind.CommaToken),v667
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v753 = Syntax.SeparatedList<ArgumentSyntax>(list752);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v753,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f759()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v757 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v756 = Syntax.IdentifierName("InvocationExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v757,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v756);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f760()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v759 = this.f759();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v755 = this.f755();
            return Syntax.InvocationExpression(v759,v755);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f762()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v760 = this.f760();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v760);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f764()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v762 = this.f762();
            return Syntax.VariableDeclarator(Syntax.Identifier("ieSyntax"),argumentListOpt: null ,initializerOpt: v762);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f768()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v765 = Syntax.IdentifierName("InvocationExpressionSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v764 = this.f764();
            List<SyntaxNodeOrToken> list766 = new List<SyntaxNodeOrToken>
            {
            v764
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v767 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list766);
            return Syntax.VariableDeclaration(v765,variables: v767);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f772()
        {
            List<SyntaxToken> list769 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v770 = Syntax.TokenList(list769);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v768 = this.f768();
            return Syntax.LocalDeclarationStatement(modifiers: v770,declaration: v768,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f776()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v774 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v773 = Syntax.IdentifierName("FullName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v774,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v773);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f778()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v776 = this.f776();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v776);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f783()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v778 = this.f778();
            List<SyntaxNodeOrToken> list780 = new List<SyntaxNodeOrToken>
            {
            v778
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v781 = Syntax.SeparatedList<ArgumentSyntax>(list780);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v781,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f787()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v785 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v784 = Syntax.IdentifierName("ParseTypeName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v785,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v784);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f788()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v787 = this.f787();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v783 = this.f783();
            return Syntax.InvocationExpression(v787,v783);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f791()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v789 = Syntax.IdentifierName("typeSyntax");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v788 = this.f788();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v789,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v788);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f793()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v791 = this.f791();
            return Syntax.ExpressionStatement(v791,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f798()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v793 = this.f793();
            List<StatementSyntax> list795 = new List<StatementSyntax>
            {
            v793
            }

            ;
            SyntaxList<StatementSyntax> v796 = Syntax.List<StatementSyntax>(list795);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v796,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f800()
        {
            Roslyn.Compilers.CSharp.BlockSyntax v798 = this.f798();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v798);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f803()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f805()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v803 = this.f803();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v803);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f810()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v805 = this.f805();
            List<SyntaxNodeOrToken> list807 = new List<SyntaxNodeOrToken>
            {
            v805
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v808 = Syntax.SeparatedList<ArgumentSyntax>(list807);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v808,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f815()
        {
            List<SyntaxNodeOrToken> list812 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v813 = Syntax.SeparatedList<ArgumentSyntax>(list812);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v813,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f819()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v817 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v816 = Syntax.IdentifierName("GetGenericArguments");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v817,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v816);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f820()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v819 = this.f819();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v815 = this.f815();
            return Syntax.InvocationExpression(v819,v815);
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f821()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v820 = this.f820();
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v810 = this.f810();
            return Syntax.ElementAccessExpression(v820,v810);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f823()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v821 = this.f821();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v801 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v821,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v801);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f825()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v823 = this.f823();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v823);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f828()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f830()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v828 = this.f828();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v826 = Syntax.IdentifierName("Empty");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v828,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v826);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f832()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v830 = this.f830();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v830);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f834()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"`1\"", "\"`1\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f836()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v834 = this.f834();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v834);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f842()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v836 = this.f836();
            Roslyn.Compilers.CSharp.ArgumentSyntax v832 = this.f832();
            List<SyntaxNodeOrToken> list839 = new List<SyntaxNodeOrToken>
            {
            v836,Syntax.Token(SyntaxKind.CommaToken),v832
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v840 = Syntax.SeparatedList<ArgumentSyntax>(list839);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v840,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f847()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v845 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v844 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v845,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v844);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f849()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v847 = this.f847();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v843 = Syntax.IdentifierName("Replace");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v847,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v843);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f850()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v849 = this.f849();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v842 = this.f842();
            return Syntax.InvocationExpression(v849,v842);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f852()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v850 = this.f850();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v850);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f854()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"{0}<{1}>\"", "\"{0}<{1}>\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f856()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v854 = this.f854();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v854);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f863()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v856 = this.f856();
            Roslyn.Compilers.CSharp.ArgumentSyntax v852 = this.f852();
            Roslyn.Compilers.CSharp.ArgumentSyntax v825 = this.f825();
            List<SyntaxNodeOrToken> list860 = new List<SyntaxNodeOrToken>
            {
            v856,Syntax.Token(SyntaxKind.CommaToken),v852,Syntax.Token(SyntaxKind.CommaToken),v825
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v861 = Syntax.SeparatedList<ArgumentSyntax>(list860);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v861,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f866()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f868()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v866 = this.f866();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v864 = Syntax.IdentifierName("Format");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v866,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v864);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f869()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v868 = this.f868();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v863 = this.f863();
            return Syntax.InvocationExpression(v868,v863);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f871()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v869 = this.f869();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v869);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f876()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v871 = this.f871();
            List<SyntaxNodeOrToken> list873 = new List<SyntaxNodeOrToken>
            {
            v871
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v874 = Syntax.SeparatedList<ArgumentSyntax>(list873);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v874,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f880()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v878 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v877 = Syntax.IdentifierName("ParseTypeName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v878,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v877);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f881()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v880 = this.f880();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v876 = this.f876();
            return Syntax.InvocationExpression(v880,v876);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f884()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v882 = Syntax.IdentifierName("typeSyntax");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v881 = this.f881();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v882,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v881);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f886()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v884 = this.f884();
            return Syntax.ExpressionStatement(v884,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f891()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v886 = this.f886();
            List<StatementSyntax> list888 = new List<StatementSyntax>
            {
            v886
            }

            ;
            SyntaxList<StatementSyntax> v889 = Syntax.List<StatementSyntax>(list888);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v889,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f895()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v893 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v892 = Syntax.IdentifierName("IsGenericType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v893,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v892);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f899()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v895 = this.f895();
            Roslyn.Compilers.CSharp.BlockSyntax v891 = this.f891();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v800 = this.f800();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v895,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v891,elseOpt: v800);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f901()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f903()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v901 = this.f901();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v901);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f905()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v903 = this.f903();
            return Syntax.VariableDeclarator(Syntax.Identifier("typeSyntax"),argumentListOpt: null ,initializerOpt: v903);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f909()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v906 = Syntax.IdentifierName("TypeSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v905 = this.f905();
            List<SyntaxNodeOrToken> list907 = new List<SyntaxNodeOrToken>
            {
            v905
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v908 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list907);
            return Syntax.VariableDeclaration(v906,variables: v908);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f913()
        {
            List<SyntaxToken> list910 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v911 = Syntax.TokenList(list910);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v909 = this.f909();
            return Syntax.LocalDeclarationStatement(modifiers: v911,declaration: v909,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f917()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"create\"", "\"create\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f919()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v917 = this.f917();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v915 = Syntax.IdentifierName("friendlyName");
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v917,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v915);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f921()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v919 = this.f919();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v914 = Syntax.IdentifierName("variableCounter");
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v919,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v914);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f924()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"f\"", "\"f\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f926()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v924 = this.f924();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v922 = Syntax.IdentifierName("variableCounter");
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v924,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v922);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f928()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f931()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v929 = Syntax.IdentifierName("friendlyName");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v928 = this.f928();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v929,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v928);
        }

        Roslyn.Compilers.CSharp.ConditionalExpressionSyntax f934()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v931 = this.f931();
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v926 = this.f926();
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v921 = this.f921();
            return Syntax.ConditionalExpression(v931,questionToken: Syntax.Token(SyntaxKind.QuestionToken),whenTrue: v926,colonToken: Syntax.Token(SyntaxKind.ColonToken),whenFalse: v921);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f936()
        {
            Roslyn.Compilers.CSharp.ConditionalExpressionSyntax v934 = this.f934();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v934);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f938()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v936 = this.f936();
            return Syntax.VariableDeclarator(Syntax.Identifier("funcName"),argumentListOpt: null ,initializerOpt: v936);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f940()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f943()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v940 = this.f940();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v938 = this.f938();
            List<SyntaxNodeOrToken> list941 = new List<SyntaxNodeOrToken>
            {
            v938
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v942 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list941);
            return Syntax.VariableDeclaration(v940,variables: v942);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f947()
        {
            List<SyntaxToken> list944 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v945 = Syntax.TokenList(list944);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v943 = this.f943();
            return Syntax.LocalDeclarationStatement(modifiers: v945,declaration: v943,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f950()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"v\"", "\"v\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f952()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v950 = this.f950();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v948 = Syntax.IdentifierName("variableCounter");
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v950,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v948);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f954()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v952 = this.f952();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v952);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f956()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v954 = this.f954();
            return Syntax.VariableDeclarator(Syntax.Identifier("varName"),argumentListOpt: null ,initializerOpt: v954);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f958()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f961()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v958 = this.f958();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v956 = this.f956();
            List<SyntaxNodeOrToken> list959 = new List<SyntaxNodeOrToken>
            {
            v956
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v960 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list959);
            return Syntax.VariableDeclaration(v958,variables: v960);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f965()
        {
            List<SyntaxToken> list962 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v963 = Syntax.TokenList(list962);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v961 = this.f961();
            return Syntax.LocalDeclarationStatement(modifiers: v963,declaration: v961,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax f968()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v966 = Syntax.IdentifierName("variableCounter");
            return Syntax.PostfixUnaryExpression(SyntaxKind.PostIncrementExpression,v966,operatorToken: Syntax.Token(SyntaxKind.PlusPlusToken));
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f970()
        {
            Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax v968 = this.f968();
            return Syntax.ExpressionStatement(v968,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f972()
        {
            return Syntax.VariableDeclarator(Syntax.Identifier("assignmentValue"),argumentListOpt: null ,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f976()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v973 = Syntax.IdentifierName("ExpressionSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v972 = this.f972();
            List<SyntaxNodeOrToken> list974 = new List<SyntaxNodeOrToken>
            {
            v972
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v975 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list974);
            return Syntax.VariableDeclaration(v973,variables: v975);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f980()
        {
            List<SyntaxToken> list977 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v978 = Syntax.TokenList(list977);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v976 = this.f976();
            return Syntax.LocalDeclarationStatement(modifiers: v978,declaration: v976,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f985()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v980 = this.f980();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v970 = this.f970();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v965 = this.f965();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v947 = this.f947();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v913 = this.f913();
            Roslyn.Compilers.CSharp.IfStatementSyntax v899 = this.f899();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v772 = this.f772();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v608 = this.f608();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v602 = this.f602();
            Roslyn.Compilers.CSharp.IfStatementSyntax v588 = this.f588();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v321 = this.f321();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v209 = this.f209();
            List<StatementSyntax> list982 = new List<StatementSyntax>
            {
            v980,v970,v965,v947,v913,v899,v772,v608,v602,v588,v321,v209
            }

            ;
            SyntaxList<StatementSyntax> v983 = Syntax.List<StatementSyntax>(list982);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v983,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f987()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f989()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v987 = this.f987();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v987);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f991()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f997()
        {
            List<AttributeDeclarationSyntax> list992 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v993 = Syntax.List<AttributeDeclarationSyntax>(list992);
            List<SyntaxToken> list994 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v995 = Syntax.TokenList(list994);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v991 = this.f991();
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v989 = this.f989();
            return Syntax.Parameter(attributes: v993,modifiers: v995,typeOpt: v991,identifier: Syntax.Identifier("friendlyName"),defaultOpt: v989);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f1003()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v998 = Syntax.IdentifierName("SyntaxNode");
            List<SyntaxNodeOrToken> list1000 = new List<SyntaxNodeOrToken>
            {
            v998
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v1001 = Syntax.SeparatedList<TypeSyntax>(list1000);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v1001,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f1005()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v1003 = this.f1003();
            return Syntax.GenericName(Syntax.Identifier("List"),v1003);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1011()
        {
            List<AttributeDeclarationSyntax> list1006 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1007 = Syntax.List<AttributeDeclarationSyntax>(list1006);
            List<SyntaxToken> list1008 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1009 = Syntax.TokenList(list1008);
            Roslyn.Compilers.CSharp.GenericNameSyntax v1005 = this.f1005();
            return Syntax.Parameter(attributes: v1007,modifiers: v1009,typeOpt: v1005,identifier: Syntax.Identifier("dependentVariableDefinitions"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f1017()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1012 = Syntax.IdentifierName("SyntaxToken");
            List<SyntaxNodeOrToken> list1014 = new List<SyntaxNodeOrToken>
            {
            v1012
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v1015 = Syntax.SeparatedList<TypeSyntax>(list1014);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v1015,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f1019()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v1017 = this.f1017();
            return Syntax.GenericName(Syntax.Identifier("List"),v1017);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1025()
        {
            List<AttributeDeclarationSyntax> list1020 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1021 = Syntax.List<AttributeDeclarationSyntax>(list1020);
            List<SyntaxToken> list1022 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1023 = Syntax.TokenList(list1022);
            Roslyn.Compilers.CSharp.GenericNameSyntax v1019 = this.f1019();
            return Syntax.Parameter(attributes: v1021,modifiers: v1023,typeOpt: v1019,identifier: Syntax.Identifier("separators"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f1031()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1026 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list1028 = new List<SyntaxNodeOrToken>
            {
            v1026
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v1029 = Syntax.SeparatedList<TypeSyntax>(list1028);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v1029,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f1033()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v1031 = this.f1031();
            return Syntax.GenericName(Syntax.Identifier("List"),v1031);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1039()
        {
            List<AttributeDeclarationSyntax> list1034 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1035 = Syntax.List<AttributeDeclarationSyntax>(list1034);
            List<SyntaxToken> list1036 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1037 = Syntax.TokenList(list1036);
            Roslyn.Compilers.CSharp.GenericNameSyntax v1033 = this.f1033();
            return Syntax.Parameter(attributes: v1035,modifiers: v1037,typeOpt: v1033,identifier: Syntax.Identifier("arguments"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1041()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1047()
        {
            List<AttributeDeclarationSyntax> list1042 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1043 = Syntax.List<AttributeDeclarationSyntax>(list1042);
            List<SyntaxToken> list1044 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1045 = Syntax.TokenList(list1044);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1041 = this.f1041();
            return Syntax.Parameter(attributes: v1043,modifiers: v1045,typeOpt: v1041,identifier: Syntax.Identifier("createMethodName"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1054()
        {
            List<AttributeDeclarationSyntax> list1049 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1050 = Syntax.List<AttributeDeclarationSyntax>(list1049);
            List<SyntaxToken> list1051 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1052 = Syntax.TokenList(list1051);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1048 = Syntax.IdentifierName("Type");
            return Syntax.Parameter(attributes: v1050,modifiers: v1052,typeOpt: v1048,identifier: Syntax.Identifier("type"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f1064()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v1054 = this.f1054();
            Roslyn.Compilers.CSharp.ParameterSyntax v1047 = this.f1047();
            Roslyn.Compilers.CSharp.ParameterSyntax v1039 = this.f1039();
            Roslyn.Compilers.CSharp.ParameterSyntax v1025 = this.f1025();
            Roslyn.Compilers.CSharp.ParameterSyntax v1011 = this.f1011();
            Roslyn.Compilers.CSharp.ParameterSyntax v997 = this.f997();
            List<SyntaxNodeOrToken> list1061 = new List<SyntaxNodeOrToken>
            {
            v1054,Syntax.Token(SyntaxKind.CommaToken),v1047,Syntax.Token(SyntaxKind.CommaToken),v1039,Syntax.Token(SyntaxKind.CommaToken),v1025,Syntax.Token(SyntaxKind.CommaToken),v1011,Syntax.Token(SyntaxKind.CommaToken),v997
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v1062 = Syntax.SeparatedList<ParameterSyntax>(list1061);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v1062,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1066()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.VoidKeyword));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f1076()
        {
            List<AttributeDeclarationSyntax> list1067 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1068 = Syntax.List<AttributeDeclarationSyntax>(list1067);
            List<SyntaxToken> list1070 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PrivateKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1071 = Syntax.TokenList(list1070);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1066 = this.f1066();
            Roslyn.Compilers.CSharp.ParameterListSyntax v1064 = this.f1064();
            List<TypeParameterConstraintClauseSyntax> list1073 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v1074 = Syntax.List<TypeParameterConstraintClauseSyntax>(list1073);
            Roslyn.Compilers.CSharp.BlockSyntax v985 = this.f985();
            return Syntax.MethodDeclaration(attributes: v1068,modifiers: v1071,returnType: v1066,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("CreateSyntaxNode"),typeParameterListOpt: null ,parameterList: v1064,constraintClauses: v1074,bodyOpt: v985,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ReturnStatementSyntax f1080()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1077 = Syntax.IdentifierName("foundType");
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: v1077,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1084()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1082 = Syntax.IdentifierName("typeSearch");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1081 = Syntax.IdentifierName("BaseType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1082,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1081);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1087()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1085 = Syntax.IdentifierName("typeSearch");
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1084 = this.f1084();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v1085,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v1084);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f1089()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1087 = this.f1087();
            return Syntax.ExpressionStatement(v1087,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1091()
        {
            return Syntax.LiteralExpression(SyntaxKind.TrueLiteralExpression,token: Syntax.Token(SyntaxKind.TrueKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1094()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1092 = Syntax.IdentifierName("foundType");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1091 = this.f1091();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v1092,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v1091);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f1096()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1094 = this.f1094();
            return Syntax.ExpressionStatement(v1094,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1101()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v1096 = this.f1096();
            List<StatementSyntax> list1098 = new List<StatementSyntax>
            {
            v1096
            }

            ;
            SyntaxList<StatementSyntax> v1099 = Syntax.List<StatementSyntax>(list1098);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1099,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1105()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1103 = Syntax.IdentifierName("typeSearch");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1102 = Syntax.IdentifierName("parentType");
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v1103,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v1102);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f1109()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1105 = this.f1105();
            Roslyn.Compilers.CSharp.BlockSyntax v1101 = this.f1101();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v1105,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v1101,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1114()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v1109 = this.f1109();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v1089 = this.f1089();
            List<StatementSyntax> list1111 = new List<StatementSyntax>
            {
            v1109,v1089
            }

            ;
            SyntaxList<StatementSyntax> v1112 = Syntax.List<StatementSyntax>(list1111);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1112,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1116()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1119()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1117 = Syntax.IdentifierName("typeSearch");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1116 = this.f1116();
            return Syntax.BinaryExpression(SyntaxKind.NotEqualsExpression,v1117,operatorToken: Syntax.Token(SyntaxKind.ExclamationEqualsToken),right: v1116);
        }

        Roslyn.Compilers.CSharp.WhileStatementSyntax f1123()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1119 = this.f1119();
            Roslyn.Compilers.CSharp.BlockSyntax v1114 = this.f1114();
            return Syntax.WhileStatement(whileKeyword: Syntax.Token(SyntaxKind.WhileKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v1119,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v1114);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1126()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1124 = Syntax.IdentifierName("typeName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1124);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1128()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Could not find the type {0}\"", "\"Could not find the type {0}\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1130()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1128 = this.f1128();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1128);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1136()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1130 = this.f1130();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1126 = this.f1126();
            List<SyntaxNodeOrToken> list1133 = new List<SyntaxNodeOrToken>
            {
            v1130,Syntax.Token(SyntaxKind.CommaToken),v1126
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1134 = Syntax.SeparatedList<ArgumentSyntax>(list1133);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1134,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1139()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1141()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1139 = this.f1139();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1137 = Syntax.IdentifierName("Format");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1139,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1137);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1142()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1141 = this.f1141();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1136 = this.f1136();
            return Syntax.InvocationExpression(v1141,v1136);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1144()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1142 = this.f1142();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1142);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1149()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1144 = this.f1144();
            List<SyntaxNodeOrToken> list1146 = new List<SyntaxNodeOrToken>
            {
            v1144
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1147 = Syntax.SeparatedList<ArgumentSyntax>(list1146);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1147,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f1152()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1150 = Syntax.IdentifierName("ApplicationException");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1149 = this.f1149();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v1150,argumentListOpt: v1149,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.ThrowStatementSyntax f1155()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v1152 = this.f1152();
            return Syntax.ThrowStatement(throwKeyword: Syntax.Token(SyntaxKind.ThrowKeyword),expressionOpt: v1152,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1160()
        {
            Roslyn.Compilers.CSharp.ThrowStatementSyntax v1155 = this.f1155();
            List<StatementSyntax> list1157 = new List<StatementSyntax>
            {
            v1155
            }

            ;
            SyntaxList<StatementSyntax> v1158 = Syntax.List<StatementSyntax>(list1157);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1158,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1162()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1165()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1163 = Syntax.IdentifierName("typeSearch");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1162 = this.f1162();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v1163,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v1162);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f1169()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1165 = this.f1165();
            Roslyn.Compilers.CSharp.BlockSyntax v1160 = this.f1160();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v1165,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v1160,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1172()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Roslyn.Compilers.CSharp.\"", "\"Roslyn.Compilers.CSharp.\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1174()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1172 = this.f1172();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1170 = Syntax.IdentifierName("typeName");
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v1172,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v1170);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1176()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1174 = this.f1174();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1174);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1181()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1176 = this.f1176();
            List<SyntaxNodeOrToken> list1178 = new List<SyntaxNodeOrToken>
            {
            v1176
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1179 = Syntax.SeparatedList<ArgumentSyntax>(list1178);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1179,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1186()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1184 = Syntax.IdentifierName("Syntax");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1184);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1191()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1186 = this.f1186();
            List<SyntaxNodeOrToken> list1188 = new List<SyntaxNodeOrToken>
            {
            v1186
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1189 = Syntax.SeparatedList<ArgumentSyntax>(list1188);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1189,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeOfExpressionSyntax f1193()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1191 = this.f1191();
            return Syntax.TypeOfExpression(keyword: Syntax.Token(SyntaxKind.TypeOfKeyword),argumentList: v1191);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1195()
        {
            Roslyn.Compilers.CSharp.TypeOfExpressionSyntax v1193 = this.f1193();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1183 = Syntax.IdentifierName("Assembly");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1193,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1183);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1197()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1195 = this.f1195();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1182 = Syntax.IdentifierName("GetType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1195,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1182);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1198()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1197 = this.f1197();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1181 = this.f1181();
            return Syntax.InvocationExpression(v1197,v1181);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f1200()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1198 = this.f1198();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v1198);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f1202()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v1200 = this.f1200();
            return Syntax.VariableDeclarator(Syntax.Identifier("typeSearch"),argumentListOpt: null ,initializerOpt: v1200);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f1206()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1203 = Syntax.IdentifierName("Type");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v1202 = this.f1202();
            List<SyntaxNodeOrToken> list1204 = new List<SyntaxNodeOrToken>
            {
            v1202
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v1205 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list1204);
            return Syntax.VariableDeclaration(v1203,variables: v1205);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f1210()
        {
            List<SyntaxToken> list1207 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1208 = Syntax.TokenList(list1207);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v1206 = this.f1206();
            return Syntax.LocalDeclarationStatement(modifiers: v1208,declaration: v1206,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1212()
        {
            return Syntax.LiteralExpression(SyntaxKind.FalseLiteralExpression,token: Syntax.Token(SyntaxKind.FalseKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f1214()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1212 = this.f1212();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v1212);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f1216()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v1214 = this.f1214();
            return Syntax.VariableDeclarator(Syntax.Identifier("foundType"),argumentListOpt: null ,initializerOpt: v1214);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1218()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.BoolKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f1221()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1218 = this.f1218();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v1216 = this.f1216();
            List<SyntaxNodeOrToken> list1219 = new List<SyntaxNodeOrToken>
            {
            v1216
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v1220 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list1219);
            return Syntax.VariableDeclaration(v1218,variables: v1220);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f1225()
        {
            List<SyntaxToken> list1222 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1223 = Syntax.TokenList(list1222);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v1221 = this.f1221();
            return Syntax.LocalDeclarationStatement(modifiers: v1223,declaration: v1221,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1230()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v1225 = this.f1225();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v1210 = this.f1210();
            Roslyn.Compilers.CSharp.IfStatementSyntax v1169 = this.f1169();
            Roslyn.Compilers.CSharp.WhileStatementSyntax v1123 = this.f1123();
            Roslyn.Compilers.CSharp.ReturnStatementSyntax v1080 = this.f1080();
            List<StatementSyntax> list1227 = new List<StatementSyntax>
            {
            v1225,v1210,v1169,v1123,v1080
            }

            ;
            SyntaxList<StatementSyntax> v1228 = Syntax.List<StatementSyntax>(list1227);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1228,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1237()
        {
            List<AttributeDeclarationSyntax> list1232 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1233 = Syntax.List<AttributeDeclarationSyntax>(list1232);
            List<SyntaxToken> list1234 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1235 = Syntax.TokenList(list1234);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1231 = Syntax.IdentifierName("Type");
            return Syntax.Parameter(attributes: v1233,modifiers: v1235,typeOpt: v1231,identifier: Syntax.Identifier("parentType"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1239()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1245()
        {
            List<AttributeDeclarationSyntax> list1240 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1241 = Syntax.List<AttributeDeclarationSyntax>(list1240);
            List<SyntaxToken> list1242 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1243 = Syntax.TokenList(list1242);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1239 = this.f1239();
            return Syntax.Parameter(attributes: v1241,modifiers: v1243,typeOpt: v1239,identifier: Syntax.Identifier("typeName"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f1251()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v1245 = this.f1245();
            Roslyn.Compilers.CSharp.ParameterSyntax v1237 = this.f1237();
            List<SyntaxNodeOrToken> list1248 = new List<SyntaxNodeOrToken>
            {
            v1245,Syntax.Token(SyntaxKind.CommaToken),v1237
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v1249 = Syntax.SeparatedList<ParameterSyntax>(list1248);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v1249,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1253()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.BoolKeyword));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f1263()
        {
            List<AttributeDeclarationSyntax> list1254 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1255 = Syntax.List<AttributeDeclarationSyntax>(list1254);
            List<SyntaxToken> list1257 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PrivateKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1258 = Syntax.TokenList(list1257);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1253 = this.f1253();
            Roslyn.Compilers.CSharp.ParameterListSyntax v1251 = this.f1251();
            List<TypeParameterConstraintClauseSyntax> list1260 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v1261 = Syntax.List<TypeParameterConstraintClauseSyntax>(list1260);
            Roslyn.Compilers.CSharp.BlockSyntax v1230 = this.f1230();
            return Syntax.MethodDeclaration(attributes: v1255,modifiers: v1258,returnType: v1253,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("IsTypeDerived"),typeParameterListOpt: null ,parameterList: v1251,constraintClauses: v1261,bodyOpt: v1230,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ReturnStatementSyntax f1267()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1264 = Syntax.IdentifierName("listDecl");
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: v1264,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1270()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1268 = Syntax.IdentifierName("listInitExpressionList");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1268);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1275()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1270 = this.f1270();
            List<SyntaxNodeOrToken> list1272 = new List<SyntaxNodeOrToken>
            {
            v1270
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1273 = Syntax.SeparatedList<ArgumentSyntax>(list1272);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1273,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f1281()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1276 = Syntax.IdentifierName("ExpressionSyntax");
            List<SyntaxNodeOrToken> list1278 = new List<SyntaxNodeOrToken>
            {
            v1276
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v1279 = Syntax.SeparatedList<TypeSyntax>(list1278);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v1279,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f1283()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v1281 = this.f1281();
            return Syntax.GenericName(Syntax.Identifier("SeparatedList"),v1281);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1286()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1284 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.GenericNameSyntax v1283 = this.f1283();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1284,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1283);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1287()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1286 = this.f1286();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1275 = this.f1275();
            return Syntax.InvocationExpression(v1286,v1275);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f1290()
        {
            return Syntax.NameColon(Syntax.Identifier("expressions"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1292()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v1290 = this.f1290();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1287 = this.f1287();
            return Syntax.Argument(nameColonOpt: v1290,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1287);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1297()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1292 = this.f1292();
            List<SyntaxNodeOrToken> list1294 = new List<SyntaxNodeOrToken>
            {
            v1292
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1295 = Syntax.SeparatedList<ArgumentSyntax>(list1294);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1295,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1301()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1299 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1298 = Syntax.IdentifierName("InitializerExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1299,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1298);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1302()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1301 = this.f1301();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1297 = this.f1297();
            return Syntax.InvocationExpression(v1301,v1297);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f1305()
        {
            return Syntax.NameColon(Syntax.Identifier("initializerOpt"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1307()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v1305 = this.f1305();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1302 = this.f1302();
            return Syntax.Argument(nameColonOpt: v1305,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1302);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f1311()
        {
            return Syntax.NameColon(Syntax.Identifier("type"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1313()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v1311 = this.f1311();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1308 = Syntax.IdentifierName("typeSyntax");
            return Syntax.Argument(nameColonOpt: v1311,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1308);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1319()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1313 = this.f1313();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1307 = this.f1307();
            List<SyntaxNodeOrToken> list1316 = new List<SyntaxNodeOrToken>
            {
            v1313,Syntax.Token(SyntaxKind.CommaToken),v1307
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1317 = Syntax.SeparatedList<ArgumentSyntax>(list1316);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1317,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1323()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1321 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1320 = Syntax.IdentifierName("ObjectCreationExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1321,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1320);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1324()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1323 = this.f1323();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1319 = this.f1319();
            return Syntax.InvocationExpression(v1323,v1319);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f1327()
        {
            return Syntax.NameColon(Syntax.Identifier("value"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1329()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v1327 = this.f1327();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1324 = this.f1324();
            return Syntax.Argument(nameColonOpt: v1327,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1324);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1334()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1329 = this.f1329();
            List<SyntaxNodeOrToken> list1331 = new List<SyntaxNodeOrToken>
            {
            v1329
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1332 = Syntax.SeparatedList<ArgumentSyntax>(list1331);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1332,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1338()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1336 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1335 = Syntax.IdentifierName("EqualsValueClause");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1336,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1335);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1339()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1338 = this.f1338();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1334 = this.f1334();
            return Syntax.InvocationExpression(v1338,v1334);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f1342()
        {
            return Syntax.NameColon(Syntax.Identifier("initializerOpt"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1344()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v1342 = this.f1342();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1339 = this.f1339();
            return Syntax.Argument(nameColonOpt: v1342,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1339);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1347()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1345 = Syntax.IdentifierName("varName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1345);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1352()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1347 = this.f1347();
            List<SyntaxNodeOrToken> list1349 = new List<SyntaxNodeOrToken>
            {
            v1347
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1350 = Syntax.SeparatedList<ArgumentSyntax>(list1349);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1350,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1356()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1354 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1353 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1354,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1353);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1357()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1356 = this.f1356();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1352 = this.f1352();
            return Syntax.InvocationExpression(v1356,v1352);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1359()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1357 = this.f1357();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1357);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1365()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1359 = this.f1359();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1344 = this.f1344();
            List<SyntaxNodeOrToken> list1362 = new List<SyntaxNodeOrToken>
            {
            v1359,Syntax.Token(SyntaxKind.CommaToken),v1344
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1363 = Syntax.SeparatedList<ArgumentSyntax>(list1362);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1363,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1369()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1367 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1366 = Syntax.IdentifierName("VariableDeclarator");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1367,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1366);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1370()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1369 = this.f1369();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1365 = this.f1365();
            return Syntax.InvocationExpression(v1369,v1365);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1372()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1370 = this.f1370();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1370);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1377()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1372 = this.f1372();
            List<SyntaxNodeOrToken> list1374 = new List<SyntaxNodeOrToken>
            {
            v1372
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1375 = Syntax.SeparatedList<ArgumentSyntax>(list1374);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1375,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f1383()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1378 = Syntax.IdentifierName("VariableDeclaratorSyntax");
            List<SyntaxNodeOrToken> list1380 = new List<SyntaxNodeOrToken>
            {
            v1378
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v1381 = Syntax.SeparatedList<TypeSyntax>(list1380);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v1381,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f1385()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v1383 = this.f1383();
            return Syntax.GenericName(Syntax.Identifier("SeparatedList"),v1383);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1388()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1386 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.GenericNameSyntax v1385 = this.f1385();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1386,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1385);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1389()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1388 = this.f1388();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1377 = this.f1377();
            return Syntax.InvocationExpression(v1388,v1377);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1391()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1389 = this.f1389();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1389);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1394()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1392 = Syntax.IdentifierName("typeSyntax");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1392);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1400()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1394 = this.f1394();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1391 = this.f1391();
            List<SyntaxNodeOrToken> list1397 = new List<SyntaxNodeOrToken>
            {
            v1394,Syntax.Token(SyntaxKind.CommaToken),v1391
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1398 = Syntax.SeparatedList<ArgumentSyntax>(list1397);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1398,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1404()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1402 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1401 = Syntax.IdentifierName("VariableDeclaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1402,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1401);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1405()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1404 = this.f1404();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1400 = this.f1400();
            return Syntax.InvocationExpression(v1404,v1400);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f1408()
        {
            return Syntax.NameColon(Syntax.Identifier("declaration"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1410()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v1408 = this.f1408();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1405 = this.f1405();
            return Syntax.Argument(nameColonOpt: v1408,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1405);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1415()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1410 = this.f1410();
            List<SyntaxNodeOrToken> list1412 = new List<SyntaxNodeOrToken>
            {
            v1410
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1413 = Syntax.SeparatedList<ArgumentSyntax>(list1412);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1413,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1419()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1417 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1416 = Syntax.IdentifierName("LocalDeclarationStatement");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1417,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1416);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1420()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1419 = this.f1419();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1415 = this.f1415();
            return Syntax.InvocationExpression(v1419,v1415);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f1422()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1420 = this.f1420();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v1420);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f1424()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v1422 = this.f1422();
            return Syntax.VariableDeclarator(Syntax.Identifier("listDecl"),argumentListOpt: null ,initializerOpt: v1422);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f1428()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1425 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v1424 = this.f1424();
            List<SyntaxNodeOrToken> list1426 = new List<SyntaxNodeOrToken>
            {
            v1424
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v1427 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list1426);
            return Syntax.VariableDeclaration(v1425,variables: v1427);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f1432()
        {
            List<SyntaxToken> list1429 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1430 = Syntax.TokenList(list1429);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v1428 = this.f1428();
            return Syntax.LocalDeclarationStatement(modifiers: v1430,declaration: v1428,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1436()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1434 = Syntax.IdentifierName("genericType");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1433 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1434,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1433);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1438()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1436 = this.f1436();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1436);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1440()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"List<{0}>\"", "\"List<{0}>\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1442()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1440 = this.f1440();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1440);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1448()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1442 = this.f1442();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1438 = this.f1438();
            List<SyntaxNodeOrToken> list1445 = new List<SyntaxNodeOrToken>
            {
            v1442,Syntax.Token(SyntaxKind.CommaToken),v1438
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1446 = Syntax.SeparatedList<ArgumentSyntax>(list1445);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1446,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1451()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1453()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1451 = this.f1451();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1449 = Syntax.IdentifierName("Format");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1451,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1449);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1454()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1453 = this.f1453();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1448 = this.f1448();
            return Syntax.InvocationExpression(v1453,v1448);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1456()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1454 = this.f1454();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1454);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1461()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1456 = this.f1456();
            List<SyntaxNodeOrToken> list1458 = new List<SyntaxNodeOrToken>
            {
            v1456
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1459 = Syntax.SeparatedList<ArgumentSyntax>(list1458);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1459,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1465()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1463 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1462 = Syntax.IdentifierName("ParseTypeName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1463,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1462);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1466()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1465 = this.f1465();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1461 = this.f1461();
            return Syntax.InvocationExpression(v1465,v1461);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f1468()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1466 = this.f1466();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v1466);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f1470()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v1468 = this.f1468();
            return Syntax.VariableDeclarator(Syntax.Identifier("typeSyntax"),argumentListOpt: null ,initializerOpt: v1468);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f1474()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1471 = Syntax.IdentifierName("TypeSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v1470 = this.f1470();
            List<SyntaxNodeOrToken> list1472 = new List<SyntaxNodeOrToken>
            {
            v1470
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v1473 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list1472);
            return Syntax.VariableDeclaration(v1471,variables: v1473);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f1478()
        {
            List<SyntaxToken> list1475 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1476 = Syntax.TokenList(list1475);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v1474 = this.f1474();
            return Syntax.LocalDeclarationStatement(modifiers: v1476,declaration: v1474,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1481()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"list\"", "\"list\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1483()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1481 = this.f1481();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1479 = Syntax.IdentifierName("variableCounter");
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v1481,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v1479);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f1485()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1483 = this.f1483();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v1483);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f1487()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v1485 = this.f1485();
            return Syntax.VariableDeclarator(Syntax.Identifier("varName"),argumentListOpt: null ,initializerOpt: v1485);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1489()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f1492()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1489 = this.f1489();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v1487 = this.f1487();
            List<SyntaxNodeOrToken> list1490 = new List<SyntaxNodeOrToken>
            {
            v1487
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v1491 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list1490);
            return Syntax.VariableDeclaration(v1489,variables: v1491);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f1496()
        {
            List<SyntaxToken> list1493 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1494 = Syntax.TokenList(list1493);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v1492 = this.f1492();
            return Syntax.LocalDeclarationStatement(modifiers: v1494,declaration: v1492,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax f1499()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1497 = Syntax.IdentifierName("variableCounter");
            return Syntax.PostfixUnaryExpression(SyntaxKind.PostIncrementExpression,v1497,operatorToken: Syntax.Token(SyntaxKind.PlusPlusToken));
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f1501()
        {
            Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax v1499 = this.f1499();
            return Syntax.ExpressionStatement(v1499,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1506()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v1501 = this.f1501();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v1496 = this.f1496();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v1478 = this.f1478();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v1432 = this.f1432();
            Roslyn.Compilers.CSharp.ReturnStatementSyntax v1267 = this.f1267();
            List<StatementSyntax> list1503 = new List<StatementSyntax>
            {
            v1501,v1496,v1478,v1432,v1267
            }

            ;
            SyntaxList<StatementSyntax> v1504 = Syntax.List<StatementSyntax>(list1503);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1504,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f1512()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1507 = Syntax.IdentifierName("SyntaxNodeOrToken");
            List<SyntaxNodeOrToken> list1509 = new List<SyntaxNodeOrToken>
            {
            v1507
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v1510 = Syntax.SeparatedList<TypeSyntax>(list1509);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v1510,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f1514()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v1512 = this.f1512();
            return Syntax.GenericName(Syntax.Identifier("List"),v1512);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1520()
        {
            List<AttributeDeclarationSyntax> list1515 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1516 = Syntax.List<AttributeDeclarationSyntax>(list1515);
            List<SyntaxToken> list1517 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1518 = Syntax.TokenList(list1517);
            Roslyn.Compilers.CSharp.GenericNameSyntax v1514 = this.f1514();
            return Syntax.Parameter(attributes: v1516,modifiers: v1518,typeOpt: v1514,identifier: Syntax.Identifier("listInitExpressionList"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1527()
        {
            List<AttributeDeclarationSyntax> list1522 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1523 = Syntax.List<AttributeDeclarationSyntax>(list1522);
            List<SyntaxToken> list1524 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1525 = Syntax.TokenList(list1524);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1521 = Syntax.IdentifierName("Type");
            return Syntax.Parameter(attributes: v1523,modifiers: v1525,typeOpt: v1521,identifier: Syntax.Identifier("genericType"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f1533()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v1527 = this.f1527();
            Roslyn.Compilers.CSharp.ParameterSyntax v1520 = this.f1520();
            List<SyntaxNodeOrToken> list1530 = new List<SyntaxNodeOrToken>
            {
            v1527,Syntax.Token(SyntaxKind.CommaToken),v1520
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v1531 = Syntax.SeparatedList<ParameterSyntax>(list1530);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v1531,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f1545()
        {
            List<AttributeDeclarationSyntax> list1535 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1536 = Syntax.List<AttributeDeclarationSyntax>(list1535);
            List<SyntaxToken> list1539 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PrivateKeyword),Syntax.Token(SyntaxKind.StaticKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1540 = Syntax.TokenList(list1539);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1534 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.ParameterListSyntax v1533 = this.f1533();
            List<TypeParameterConstraintClauseSyntax> list1542 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v1543 = Syntax.List<TypeParameterConstraintClauseSyntax>(list1542);
            Roslyn.Compilers.CSharp.BlockSyntax v1506 = this.f1506();
            return Syntax.MethodDeclaration(attributes: v1536,modifiers: v1540,returnType: v1534,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("CreateListOfType"),typeParameterListOpt: null ,parameterList: v1533,constraintClauses: v1543,bodyOpt: v1506,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ReturnStatementSyntax f1549()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1546 = Syntax.IdentifierName("listDecl");
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: v1546,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1552()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1550 = Syntax.IdentifierName("listInitExpressionList");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1550);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1555()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1553 = Syntax.IdentifierName("genericType");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1553);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1561()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1555 = this.f1555();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1552 = this.f1552();
            List<SyntaxNodeOrToken> list1558 = new List<SyntaxNodeOrToken>
            {
            v1555,Syntax.Token(SyntaxKind.CommaToken),v1552
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1559 = Syntax.SeparatedList<ArgumentSyntax>(list1558);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1559,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1563()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1562 = Syntax.IdentifierName("CreateListOfType");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1561 = this.f1561();
            return Syntax.InvocationExpression(v1562,v1561);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f1565()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1563 = this.f1563();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v1563);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f1567()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v1565 = this.f1565();
            return Syntax.VariableDeclarator(Syntax.Identifier("listDecl"),argumentListOpt: null ,initializerOpt: v1565);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f1571()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1568 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v1567 = this.f1567();
            List<SyntaxNodeOrToken> list1569 = new List<SyntaxNodeOrToken>
            {
            v1567
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v1570 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list1569);
            return Syntax.VariableDeclaration(v1568,variables: v1570);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f1575()
        {
            List<SyntaxToken> list1572 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1573 = Syntax.TokenList(list1572);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v1571 = this.f1571();
            return Syntax.LocalDeclarationStatement(modifiers: v1573,declaration: v1571,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1577()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\",\"", "\",\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1579()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1577 = this.f1577();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1577);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1581()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\",\"", "\",\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1583()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1581 = this.f1581();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1581);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1589()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1583 = this.f1583();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1579 = this.f1579();
            List<SyntaxNodeOrToken> list1586 = new List<SyntaxNodeOrToken>
            {
            v1583,Syntax.Token(SyntaxKind.CommaToken),v1579
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1587 = Syntax.SeparatedList<ArgumentSyntax>(list1586);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1587,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1593()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1591 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1590 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1591,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1590);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1594()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1593 = this.f1593();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1589 = this.f1589();
            return Syntax.InvocationExpression(v1593,v1589);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1596()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1594 = this.f1594();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1594);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1601()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1596 = this.f1596();
            List<SyntaxNodeOrToken> list1598 = new List<SyntaxNodeOrToken>
            {
            v1596
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1599 = Syntax.SeparatedList<ArgumentSyntax>(list1598);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1599,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1605()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1603 = Syntax.IdentifierName("listInitExpressionList");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1602 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1603,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1602);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1606()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1605 = this.f1605();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1601 = this.f1601();
            return Syntax.InvocationExpression(v1605,v1601);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f1608()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1606 = this.f1606();
            return Syntax.ExpressionStatement(v1606,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1612()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1610 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1609 = Syntax.IdentifierName("CommaToken");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1610,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1609);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1614()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1612 = this.f1612();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1612);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1619()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1614 = this.f1614();
            List<SyntaxNodeOrToken> list1616 = new List<SyntaxNodeOrToken>
            {
            v1614
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1617 = Syntax.SeparatedList<ArgumentSyntax>(list1616);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1617,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1623()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1621 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1620 = Syntax.IdentifierName("Token");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1621,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1620);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1624()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1623 = this.f1623();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1619 = this.f1619();
            return Syntax.InvocationExpression(v1623,v1619);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1626()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1624 = this.f1624();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1624);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1631()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1626 = this.f1626();
            List<SyntaxNodeOrToken> list1628 = new List<SyntaxNodeOrToken>
            {
            v1626
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1629 = Syntax.SeparatedList<ArgumentSyntax>(list1628);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1629,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1633()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1632 = Syntax.IdentifierName("CreateToken");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1631 = this.f1631();
            return Syntax.InvocationExpression(v1632,v1631);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1635()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1633 = this.f1633();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1633);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1640()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1635 = this.f1635();
            List<SyntaxNodeOrToken> list1637 = new List<SyntaxNodeOrToken>
            {
            v1635
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1638 = Syntax.SeparatedList<ArgumentSyntax>(list1637);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1638,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1644()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1642 = Syntax.IdentifierName("listInitExpressionList");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1641 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1642,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1641);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1645()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1644 = this.f1644();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1640 = this.f1640();
            return Syntax.InvocationExpression(v1644,v1640);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f1647()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1645 = this.f1645();
            return Syntax.ExpressionStatement(v1645,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1652()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v1647 = this.f1647();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v1608 = this.f1608();
            List<StatementSyntax> list1649 = new List<StatementSyntax>
            {
            v1647,v1608
            }

            ;
            SyntaxList<StatementSyntax> v1650 = Syntax.List<StatementSyntax>(list1649);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1650,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1655()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("1", 1));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1658()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1656 = Syntax.IdentifierName("i");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1655 = this.f1655();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v1656,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v1655);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1660()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1658 = this.f1658();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1653 = Syntax.IdentifierName("count");
            return Syntax.BinaryExpression(SyntaxKind.LessThanExpression,v1658,operatorToken: Syntax.Token(SyntaxKind.LessThanToken),right: v1653);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1663()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1661 = Syntax.IdentifierName("metaGenCommas");
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1660 = this.f1660();
            return Syntax.BinaryExpression(SyntaxKind.LogicalAndExpression,v1661,operatorToken: Syntax.Token(SyntaxKind.AmpersandAmpersandToken),right: v1660);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f1667()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1663 = this.f1663();
            Roslyn.Compilers.CSharp.BlockSyntax v1652 = this.f1652();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v1663,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v1652,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1669()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\",\"", "\",\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1671()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1669 = this.f1669();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1669);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1673()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\",\"", "\",\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1675()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1673 = this.f1673();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1673);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1681()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1675 = this.f1675();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1671 = this.f1671();
            List<SyntaxNodeOrToken> list1678 = new List<SyntaxNodeOrToken>
            {
            v1675,Syntax.Token(SyntaxKind.CommaToken),v1671
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1679 = Syntax.SeparatedList<ArgumentSyntax>(list1678);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1679,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1685()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1683 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1682 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1683,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1682);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1686()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1685 = this.f1685();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1681 = this.f1681();
            return Syntax.InvocationExpression(v1685,v1681);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1688()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1686 = this.f1686();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1686);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1693()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1688 = this.f1688();
            List<SyntaxNodeOrToken> list1690 = new List<SyntaxNodeOrToken>
            {
            v1688
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1691 = Syntax.SeparatedList<ArgumentSyntax>(list1690);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1691,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1697()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1695 = Syntax.IdentifierName("listInitExpressionList");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1694 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1695,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1694);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1698()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1697 = this.f1697();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1693 = this.f1693();
            return Syntax.InvocationExpression(v1697,v1693);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f1700()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1698 = this.f1698();
            return Syntax.ExpressionStatement(v1698,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1705()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v1700 = this.f1700();
            List<StatementSyntax> list1702 = new List<StatementSyntax>
            {
            v1700
            }

            ;
            SyntaxList<StatementSyntax> v1703 = Syntax.List<StatementSyntax>(list1702);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1703,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1708()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("1", 1));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1711()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1709 = Syntax.IdentifierName("i");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1708 = this.f1708();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v1709,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v1708);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1713()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1711 = this.f1711();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1706 = Syntax.IdentifierName("count");
            return Syntax.BinaryExpression(SyntaxKind.LessThanExpression,v1711,operatorToken: Syntax.Token(SyntaxKind.LessThanToken),right: v1706);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f1717()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1713 = this.f1713();
            Roslyn.Compilers.CSharp.BlockSyntax v1705 = this.f1705();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v1713,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v1705,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1720()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1722()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1720 = this.f1720();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1720);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f1727()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1722 = this.f1722();
            List<SyntaxNodeOrToken> list1724 = new List<SyntaxNodeOrToken>
            {
            v1722
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1725 = Syntax.SeparatedList<ArgumentSyntax>(list1724);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v1725,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1732()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1730 = Syntax.IdentifierName("decl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1729 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1730,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1729);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1734()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1732 = this.f1732();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1728 = Syntax.IdentifierName("Variables");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1732,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1728);
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f1735()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1734 = this.f1734();
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v1727 = this.f1727();
            return Syntax.ElementAccessExpression(v1734,v1727);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1737()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v1735 = this.f1735();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1718 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1735,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1718);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1739()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1737 = this.f1737();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1737);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1744()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1739 = this.f1739();
            List<SyntaxNodeOrToken> list1741 = new List<SyntaxNodeOrToken>
            {
            v1739
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1742 = Syntax.SeparatedList<ArgumentSyntax>(list1741);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1742,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1748()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1746 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1745 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1746,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1745);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1749()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1748 = this.f1748();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1744 = this.f1744();
            return Syntax.InvocationExpression(v1748,v1744);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1751()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1749 = this.f1749();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1749);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1756()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1751 = this.f1751();
            List<SyntaxNodeOrToken> list1753 = new List<SyntaxNodeOrToken>
            {
            v1751
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1754 = Syntax.SeparatedList<ArgumentSyntax>(list1753);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1754,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1760()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1758 = Syntax.IdentifierName("listInitExpressionList");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1757 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1758,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1757);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1761()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1760 = this.f1760();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1756 = this.f1756();
            return Syntax.InvocationExpression(v1760,v1756);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f1763()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1761 = this.f1761();
            return Syntax.ExpressionStatement(v1761,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1766()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1764 = Syntax.IdentifierName("decl");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1764);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1771()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1766 = this.f1766();
            List<SyntaxNodeOrToken> list1768 = new List<SyntaxNodeOrToken>
            {
            v1766
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1769 = Syntax.SeparatedList<ArgumentSyntax>(list1768);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1769,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1775()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1773 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1772 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1773,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1772);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1776()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1775 = this.f1775();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1771 = this.f1771();
            return Syntax.InvocationExpression(v1775,v1771);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f1778()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1776 = this.f1776();
            return Syntax.ExpressionStatement(v1776,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1780()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Unexpected type in syntax node stack.\"", "\"Unexpected type in syntax node stack.\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1782()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1780 = this.f1780();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1780);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1787()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1782 = this.f1782();
            List<SyntaxNodeOrToken> list1784 = new List<SyntaxNodeOrToken>
            {
            v1782
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1785 = Syntax.SeparatedList<ArgumentSyntax>(list1784);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1785,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f1790()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1788 = Syntax.IdentifierName("ApplicationException");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1787 = this.f1787();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v1788,argumentListOpt: v1787,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.ThrowStatementSyntax f1793()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v1790 = this.f1790();
            return Syntax.ThrowStatement(throwKeyword: Syntax.Token(SyntaxKind.ThrowKeyword),expressionOpt: v1790,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1798()
        {
            Roslyn.Compilers.CSharp.ThrowStatementSyntax v1793 = this.f1793();
            List<StatementSyntax> list1795 = new List<StatementSyntax>
            {
            v1793
            }

            ;
            SyntaxList<StatementSyntax> v1796 = Syntax.List<StatementSyntax>(list1795);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1796,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1801()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1799 = Syntax.IdentifierName("popFilter");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1799);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1807()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1805 = Syntax.IdentifierName("decl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1804 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1805,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1804);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1809()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1807 = this.f1807();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1803 = Syntax.IdentifierName("Type");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1807,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1803);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1811()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1809 = this.f1809();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1802 = Syntax.IdentifierName("PlainName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1809,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1802);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1813()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1811 = this.f1811();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1811);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1819()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v1813 = this.f1813();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1801 = this.f1801();
            List<SyntaxNodeOrToken> list1816 = new List<SyntaxNodeOrToken>
            {
            v1813,Syntax.Token(SyntaxKind.CommaToken),v1801
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1817 = Syntax.SeparatedList<ArgumentSyntax>(list1816);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1817,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1821()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1820 = Syntax.IdentifierName("IsTypeDerived");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1819 = this.f1819();
            return Syntax.InvocationExpression(v1820,v1819);
        }

        Roslyn.Compilers.CSharp.PrefixUnaryExpressionSyntax f1823()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1821 = this.f1821();
            return Syntax.PrefixUnaryExpression(SyntaxKind.LogicalNotExpression,operatorToken: Syntax.Token(SyntaxKind.ExclamationToken),operand: v1821);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f1827()
        {
            Roslyn.Compilers.CSharp.PrefixUnaryExpressionSyntax v1823 = this.f1823();
            Roslyn.Compilers.CSharp.BlockSyntax v1798 = this.f1798();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v1823,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v1798,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1832()
        {
            List<SyntaxNodeOrToken> list1829 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1830 = Syntax.SeparatedList<ArgumentSyntax>(list1829);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1830,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ThisExpressionSyntax f1836()
        {
            return Syntax.ThisExpression(token: Syntax.Token(SyntaxKind.ThisKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1838()
        {
            Roslyn.Compilers.CSharp.ThisExpressionSyntax v1836 = this.f1836();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1834 = Syntax.IdentifierName("syntaxNodeLocals");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1836,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1834);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f1840()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1838 = this.f1838();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1833 = Syntax.IdentifierName("Pop");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v1838,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v1833);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f1841()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v1840 = this.f1840();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1832 = this.f1832();
            return Syntax.InvocationExpression(v1840,v1832);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f1843()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v1841 = this.f1841();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v1841);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f1845()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v1843 = this.f1843();
            return Syntax.VariableDeclarator(Syntax.Identifier("decl"),argumentListOpt: null ,initializerOpt: v1843);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f1849()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1846 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v1845 = this.f1845();
            List<SyntaxNodeOrToken> list1847 = new List<SyntaxNodeOrToken>
            {
            v1845
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v1848 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list1847);
            return Syntax.VariableDeclaration(v1846,variables: v1848);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f1853()
        {
            List<SyntaxToken> list1850 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1851 = Syntax.TokenList(list1850);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v1849 = this.f1849();
            return Syntax.LocalDeclarationStatement(modifiers: v1851,declaration: v1849,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1858()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v1853 = this.f1853();
            Roslyn.Compilers.CSharp.IfStatementSyntax v1827 = this.f1827();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v1778 = this.f1778();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v1763 = this.f1763();
            Roslyn.Compilers.CSharp.IfStatementSyntax v1717 = this.f1717();
            Roslyn.Compilers.CSharp.IfStatementSyntax v1667 = this.f1667();
            List<StatementSyntax> list1855 = new List<StatementSyntax>
            {
            v1853,v1827,v1778,v1763,v1717,v1667
            }

            ;
            SyntaxList<StatementSyntax> v1856 = Syntax.List<StatementSyntax>(list1855);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1856,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax f1861()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1859 = Syntax.IdentifierName("i");
            return Syntax.PostfixUnaryExpression(SyntaxKind.PostIncrementExpression,v1859,operatorToken: Syntax.Token(SyntaxKind.PlusPlusToken));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f1865()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1863 = Syntax.IdentifierName("i");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1862 = Syntax.IdentifierName("count");
            return Syntax.BinaryExpression(SyntaxKind.LessThanExpression,v1863,operatorToken: Syntax.Token(SyntaxKind.LessThanToken),right: v1862);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f1867()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f1869()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v1867 = this.f1867();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v1867);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f1871()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v1869 = this.f1869();
            return Syntax.VariableDeclarator(Syntax.Identifier("i"),argumentListOpt: null ,initializerOpt: v1869);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1873()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.IntKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f1876()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1873 = this.f1873();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v1871 = this.f1871();
            List<SyntaxNodeOrToken> list1874 = new List<SyntaxNodeOrToken>
            {
            v1871
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v1875 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list1874);
            return Syntax.VariableDeclaration(v1873,variables: v1875);
        }

        Roslyn.Compilers.CSharp.ForStatementSyntax f1886()
        {
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v1876 = this.f1876();
            List<SyntaxNodeOrToken> list1879 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v1880 = Syntax.SeparatedList<ExpressionSyntax>(list1879);
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v1865 = this.f1865();
            Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax v1861 = this.f1861();
            List<SyntaxNodeOrToken> list1883 = new List<SyntaxNodeOrToken>
            {
            v1861
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v1884 = Syntax.SeparatedList<ExpressionSyntax>(list1883);
            Roslyn.Compilers.CSharp.BlockSyntax v1858 = this.f1858();
            return Syntax.ForStatement(forKeyword: Syntax.Token(SyntaxKind.ForKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),declarationOpt: v1876,initializers: v1880,firstSemicolonToken: Syntax.Token(SyntaxKind.SemicolonToken),conditionOpt: v1865,secondSemicolonToken: Syntax.Token(SyntaxKind.SemicolonToken),incrementors: v1884,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v1858);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f1891()
        {
            List<SyntaxNodeOrToken> list1888 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v1889 = Syntax.SeparatedList<ArgumentSyntax>(list1888);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v1889,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f1897()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1892 = Syntax.IdentifierName("SyntaxNodeOrToken");
            List<SyntaxNodeOrToken> list1894 = new List<SyntaxNodeOrToken>
            {
            v1892
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v1895 = Syntax.SeparatedList<TypeSyntax>(list1894);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v1895,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f1899()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v1897 = this.f1897();
            return Syntax.GenericName(Syntax.Identifier("List"),v1897);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f1901()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v1899 = this.f1899();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v1891 = this.f1891();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v1899,argumentListOpt: v1891,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f1903()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v1901 = this.f1901();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v1901);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f1905()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v1903 = this.f1903();
            return Syntax.VariableDeclarator(Syntax.Identifier("listInitExpressionList"),argumentListOpt: null ,initializerOpt: v1903);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f1911()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1906 = Syntax.IdentifierName("SyntaxNodeOrToken");
            List<SyntaxNodeOrToken> list1908 = new List<SyntaxNodeOrToken>
            {
            v1906
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v1909 = Syntax.SeparatedList<TypeSyntax>(list1908);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v1909,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f1913()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v1911 = this.f1911();
            return Syntax.GenericName(Syntax.Identifier("List"),v1911);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f1916()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v1913 = this.f1913();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v1905 = this.f1905();
            List<SyntaxNodeOrToken> list1914 = new List<SyntaxNodeOrToken>
            {
            v1905
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v1915 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list1914);
            return Syntax.VariableDeclaration(v1913,variables: v1915);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f1920()
        {
            List<SyntaxToken> list1917 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1918 = Syntax.TokenList(list1917);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v1916 = this.f1916();
            return Syntax.LocalDeclarationStatement(modifiers: v1918,declaration: v1916,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f1925()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v1920 = this.f1920();
            Roslyn.Compilers.CSharp.ForStatementSyntax v1886 = this.f1886();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v1575 = this.f1575();
            Roslyn.Compilers.CSharp.ReturnStatementSyntax v1549 = this.f1549();
            List<StatementSyntax> list1922 = new List<StatementSyntax>
            {
            v1920,v1886,v1575,v1549
            }

            ;
            SyntaxList<StatementSyntax> v1923 = Syntax.List<StatementSyntax>(list1922);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v1923,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1927()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.BoolKeyword));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1933()
        {
            List<AttributeDeclarationSyntax> list1928 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1929 = Syntax.List<AttributeDeclarationSyntax>(list1928);
            List<SyntaxToken> list1930 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1931 = Syntax.TokenList(list1930);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1927 = this.f1927();
            return Syntax.Parameter(attributes: v1929,modifiers: v1931,typeOpt: v1927,identifier: Syntax.Identifier("metaGenCommas"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f1939()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1934 = Syntax.IdentifierName("SyntaxNode");
            List<SyntaxNodeOrToken> list1936 = new List<SyntaxNodeOrToken>
            {
            v1934
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v1937 = Syntax.SeparatedList<TypeSyntax>(list1936);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v1937,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f1941()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v1939 = this.f1939();
            return Syntax.GenericName(Syntax.Identifier("List"),v1939);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1947()
        {
            List<AttributeDeclarationSyntax> list1942 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1943 = Syntax.List<AttributeDeclarationSyntax>(list1942);
            List<SyntaxToken> list1944 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1945 = Syntax.TokenList(list1944);
            Roslyn.Compilers.CSharp.GenericNameSyntax v1941 = this.f1941();
            return Syntax.Parameter(attributes: v1943,modifiers: v1945,typeOpt: v1941,identifier: Syntax.Identifier("dependentVariableDefinitions"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1954()
        {
            List<AttributeDeclarationSyntax> list1949 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1950 = Syntax.List<AttributeDeclarationSyntax>(list1949);
            List<SyntaxToken> list1951 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1952 = Syntax.TokenList(list1951);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1948 = Syntax.IdentifierName("Type");
            return Syntax.Parameter(attributes: v1950,modifiers: v1952,typeOpt: v1948,identifier: Syntax.Identifier("popFilter"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1961()
        {
            List<AttributeDeclarationSyntax> list1956 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1957 = Syntax.List<AttributeDeclarationSyntax>(list1956);
            List<SyntaxToken> list1958 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1959 = Syntax.TokenList(list1958);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1955 = Syntax.IdentifierName("Type");
            return Syntax.Parameter(attributes: v1957,modifiers: v1959,typeOpt: v1955,identifier: Syntax.Identifier("genericType"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f1963()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.IntKeyword));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f1969()
        {
            List<AttributeDeclarationSyntax> list1964 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1965 = Syntax.List<AttributeDeclarationSyntax>(list1964);
            List<SyntaxToken> list1966 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1967 = Syntax.TokenList(list1966);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v1963 = this.f1963();
            return Syntax.Parameter(attributes: v1965,modifiers: v1967,typeOpt: v1963,identifier: Syntax.Identifier("count"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f1978()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v1969 = this.f1969();
            Roslyn.Compilers.CSharp.ParameterSyntax v1961 = this.f1961();
            Roslyn.Compilers.CSharp.ParameterSyntax v1954 = this.f1954();
            Roslyn.Compilers.CSharp.ParameterSyntax v1947 = this.f1947();
            Roslyn.Compilers.CSharp.ParameterSyntax v1933 = this.f1933();
            List<SyntaxNodeOrToken> list1975 = new List<SyntaxNodeOrToken>
            {
            v1969,Syntax.Token(SyntaxKind.CommaToken),v1961,Syntax.Token(SyntaxKind.CommaToken),v1954,Syntax.Token(SyntaxKind.CommaToken),v1947,Syntax.Token(SyntaxKind.CommaToken),v1933
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v1976 = Syntax.SeparatedList<ParameterSyntax>(list1975);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v1976,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f1989()
        {
            List<AttributeDeclarationSyntax> list1980 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v1981 = Syntax.List<AttributeDeclarationSyntax>(list1980);
            List<SyntaxToken> list1983 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PrivateKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v1984 = Syntax.TokenList(list1983);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1979 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.ParameterListSyntax v1978 = this.f1978();
            List<TypeParameterConstraintClauseSyntax> list1986 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v1987 = Syntax.List<TypeParameterConstraintClauseSyntax>(list1986);
            Roslyn.Compilers.CSharp.BlockSyntax v1925 = this.f1925();
            return Syntax.MethodDeclaration(attributes: v1981,modifiers: v1984,returnType: v1979,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("CreateListOfType"),typeParameterListOpt: null ,parameterList: v1978,constraintClauses: v1987,bodyOpt: v1925,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1992()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1990 = Syntax.IdentifierName("friendlyName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1990);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1995()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1993 = Syntax.IdentifierName("dependentVariableDefinitions");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1993);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f1998()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1996 = Syntax.IdentifierName("separators");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1996);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2001()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v1999 = Syntax.IdentifierName("arguments");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v1999);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2004()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2002 = Syntax.IdentifierName("type");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2002);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2009()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2004 = this.f2004();
            List<SyntaxNodeOrToken> list2006 = new List<SyntaxNodeOrToken>
            {
            v2004
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2007 = Syntax.SeparatedList<ArgumentSyntax>(list2006);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2007,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2011()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2010 = Syntax.IdentifierName("GetApiCreateMethod");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2009 = this.f2009();
            return Syntax.InvocationExpression(v2010,v2009);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2013()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2011 = this.f2011();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2011);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2016()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2014 = Syntax.IdentifierName("type");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2014);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2026()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2016 = this.f2016();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2013 = this.f2013();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2001 = this.f2001();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1998 = this.f1998();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1995 = this.f1995();
            Roslyn.Compilers.CSharp.ArgumentSyntax v1992 = this.f1992();
            List<SyntaxNodeOrToken> list2023 = new List<SyntaxNodeOrToken>
            {
            v2016,Syntax.Token(SyntaxKind.CommaToken),v2013,Syntax.Token(SyntaxKind.CommaToken),v2001,Syntax.Token(SyntaxKind.CommaToken),v1998,Syntax.Token(SyntaxKind.CommaToken),v1995,Syntax.Token(SyntaxKind.CommaToken),v1992
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2024 = Syntax.SeparatedList<ArgumentSyntax>(list2023);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2024,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2028()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2027 = Syntax.IdentifierName("CreateSyntaxNode");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2026 = this.f2026();
            return Syntax.InvocationExpression(v2027,v2026);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2030()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2028 = this.f2028();
            return Syntax.ExpressionStatement(v2028,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2032()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("1", 1));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2036()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2034 = Syntax.IdentifierName("separators");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2033 = Syntax.IdentifierName("Count");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2034,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2033);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f2038()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2036 = this.f2036();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2032 = this.f2032();
            return Syntax.BinaryExpression(SyntaxKind.SubtractExpression,v2036,operatorToken: Syntax.Token(SyntaxKind.MinusToken),right: v2032);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2040()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v2038 = this.f2038();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2038);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2045()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2040 = this.f2040();
            List<SyntaxNodeOrToken> list2042 = new List<SyntaxNodeOrToken>
            {
            v2040
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2043 = Syntax.SeparatedList<ArgumentSyntax>(list2042);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2043,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2049()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2047 = Syntax.IdentifierName("separators");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2046 = Syntax.IdentifierName("RemoveAt");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2047,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2046);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2050()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2049 = this.f2049();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2045 = this.f2045();
            return Syntax.InvocationExpression(v2049,v2045);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2052()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2050 = this.f2050();
            return Syntax.ExpressionStatement(v2050,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2054()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\",\"", "\",\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2056()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2054 = this.f2054();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2054);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2058()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\",\"", "\",\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2060()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2058 = this.f2058();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2058);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2066()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2060 = this.f2060();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2056 = this.f2056();
            List<SyntaxNodeOrToken> list2063 = new List<SyntaxNodeOrToken>
            {
            v2060,Syntax.Token(SyntaxKind.CommaToken),v2056
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2064 = Syntax.SeparatedList<ArgumentSyntax>(list2063);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2064,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2070()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2068 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2067 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2068,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2067);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2071()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2070 = this.f2070();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2066 = this.f2066();
            return Syntax.InvocationExpression(v2070,v2066);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2073()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2071 = this.f2071();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2071);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2078()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2073 = this.f2073();
            List<SyntaxNodeOrToken> list2075 = new List<SyntaxNodeOrToken>
            {
            v2073
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2076 = Syntax.SeparatedList<ArgumentSyntax>(list2075);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2076,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2082()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2080 = Syntax.IdentifierName("separators");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2079 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2080,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2079);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2083()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2082 = this.f2082();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2078 = this.f2078();
            return Syntax.InvocationExpression(v2082,v2078);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2085()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2083 = this.f2083();
            return Syntax.ExpressionStatement(v2083,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f2090()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2085 = this.f2085();
            List<StatementSyntax> list2087 = new List<StatementSyntax>
            {
            v2085
            }

            ;
            SyntaxList<StatementSyntax> v2088 = Syntax.List<StatementSyntax>(list2087);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v2088,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2092()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Unknown parameter to SyntaxNode creator.\"", "\"Unknown parameter to SyntaxNode creator.\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2094()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2092 = this.f2092();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2092);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2099()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2094 = this.f2094();
            List<SyntaxNodeOrToken> list2096 = new List<SyntaxNodeOrToken>
            {
            v2094
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2097 = Syntax.SeparatedList<ArgumentSyntax>(list2096);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2097,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f2102()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2100 = Syntax.IdentifierName("ApplicationException");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2099 = this.f2099();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v2100,argumentListOpt: v2099,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.ThrowStatementSyntax f2105()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v2102 = this.f2102();
            return Syntax.ThrowStatement(throwKeyword: Syntax.Token(SyntaxKind.ThrowKeyword),expressionOpt: v2102,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f2110()
        {
            Roslyn.Compilers.CSharp.ThrowStatementSyntax v2105 = this.f2105();
            List<StatementSyntax> list2107 = new List<StatementSyntax>
            {
            v2105
            }

            ;
            SyntaxList<StatementSyntax> v2108 = Syntax.List<StatementSyntax>(list2107);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v2108,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f2112()
        {
            Roslyn.Compilers.CSharp.BlockSyntax v2110 = this.f2110();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v2110);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2114()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2118()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2116 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2115 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2116,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2115);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2122()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2120 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2119 = Syntax.IdentifierName("IsOptional");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2120,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2119);
        }

        Roslyn.Compilers.CSharp.ConditionalExpressionSyntax f2125()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2122 = this.f2122();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2118 = this.f2118();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2114 = this.f2114();
            return Syntax.ConditionalExpression(v2122,questionToken: Syntax.Token(SyntaxKind.QuestionToken),whenTrue: v2118,colonToken: Syntax.Token(SyntaxKind.ColonToken),whenFalse: v2114);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2127()
        {
            Roslyn.Compilers.CSharp.ConditionalExpressionSyntax v2125 = this.f2125();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2125);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2131()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2129 = Syntax.IdentifierName("node");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2128 = Syntax.IdentifierName("Kind");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2129,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2128);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2133()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2131 = this.f2131();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2131);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2136()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2134 = Syntax.IdentifierName("SyntaxKind");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2134);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2141()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2136 = this.f2136();
            List<SyntaxNodeOrToken> list2138 = new List<SyntaxNodeOrToken>
            {
            v2136
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2139 = Syntax.SeparatedList<ArgumentSyntax>(list2138);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2139,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeOfExpressionSyntax f2143()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2141 = this.f2141();
            return Syntax.TypeOfExpression(keyword: Syntax.Token(SyntaxKind.TypeOfKeyword),argumentList: v2141);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2145()
        {
            Roslyn.Compilers.CSharp.TypeOfExpressionSyntax v2143 = this.f2143();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2143);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2151()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2145 = this.f2145();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2133 = this.f2133();
            List<SyntaxNodeOrToken> list2148 = new List<SyntaxNodeOrToken>
            {
            v2145,Syntax.Token(SyntaxKind.CommaToken),v2133
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2149 = Syntax.SeparatedList<ArgumentSyntax>(list2148);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2149,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2155()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2153 = Syntax.IdentifierName("Enum");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2152 = Syntax.IdentifierName("GetName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2153,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2152);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2156()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2155 = this.f2155();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2151 = this.f2151();
            return Syntax.InvocationExpression(v2155,v2151);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2158()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2156 = this.f2156();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2156);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2163()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2158 = this.f2158();
            List<SyntaxNodeOrToken> list2160 = new List<SyntaxNodeOrToken>
            {
            v2158
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2161 = Syntax.SeparatedList<ArgumentSyntax>(list2160);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2161,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2167()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2165 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2164 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2165,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2164);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2168()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2167 = this.f2167();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2163 = this.f2163();
            return Syntax.InvocationExpression(v2167,v2163);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f2171()
        {
            return Syntax.NameColon(Syntax.Identifier("name"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2173()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v2171 = this.f2171();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2168 = this.f2168();
            return Syntax.Argument(nameColonOpt: v2171,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2168);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2175()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"SyntaxKind\"", "\"SyntaxKind\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2177()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2175 = this.f2175();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2175);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2182()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2177 = this.f2177();
            List<SyntaxNodeOrToken> list2179 = new List<SyntaxNodeOrToken>
            {
            v2177
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2180 = Syntax.SeparatedList<ArgumentSyntax>(list2179);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2180,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2186()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2184 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2183 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2184,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2183);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2187()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2186 = this.f2186();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2182 = this.f2182();
            return Syntax.InvocationExpression(v2186,v2182);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2189()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2187 = this.f2187();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2187);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2193()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2191 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2190 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2191,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2190);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2195()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2193 = this.f2193();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2193);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2202()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2195 = this.f2195();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2189 = this.f2189();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2173 = this.f2173();
            List<SyntaxNodeOrToken> list2199 = new List<SyntaxNodeOrToken>
            {
            v2195,Syntax.Token(SyntaxKind.CommaToken),v2189,Syntax.Token(SyntaxKind.CommaToken),v2173
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2200 = Syntax.SeparatedList<ArgumentSyntax>(list2199);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2200,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2206()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2204 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2203 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2204,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2203);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2207()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2206 = this.f2206();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2202 = this.f2202();
            return Syntax.InvocationExpression(v2206,v2202);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2209()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2207 = this.f2207();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2207);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2215()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2209 = this.f2209();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2127 = this.f2127();
            List<SyntaxNodeOrToken> list2212 = new List<SyntaxNodeOrToken>
            {
            v2209,Syntax.Token(SyntaxKind.CommaToken),v2127
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2213 = Syntax.SeparatedList<ArgumentSyntax>(list2212);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2213,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2217()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2216 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2215 = this.f2215();
            return Syntax.InvocationExpression(v2216,v2215);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2219()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2217 = this.f2217();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2217);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2224()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2219 = this.f2219();
            List<SyntaxNodeOrToken> list2221 = new List<SyntaxNodeOrToken>
            {
            v2219
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2222 = Syntax.SeparatedList<ArgumentSyntax>(list2221);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2222,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2228()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2226 = Syntax.IdentifierName("arguments");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2225 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2226,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2225);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2229()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2228 = this.f2228();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2224 = this.f2224();
            return Syntax.InvocationExpression(v2228,v2224);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2231()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2229 = this.f2229();
            return Syntax.ExpressionStatement(v2229,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f2236()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2231 = this.f2231();
            List<StatementSyntax> list2233 = new List<StatementSyntax>
            {
            v2231
            }

            ;
            SyntaxList<StatementSyntax> v2234 = Syntax.List<StatementSyntax>(list2233);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v2234,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2239()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2237 = Syntax.IdentifierName("SyntaxKind");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2237);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2244()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2239 = this.f2239();
            List<SyntaxNodeOrToken> list2241 = new List<SyntaxNodeOrToken>
            {
            v2239
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2242 = Syntax.SeparatedList<ArgumentSyntax>(list2241);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2242,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeOfExpressionSyntax f2246()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2244 = this.f2244();
            return Syntax.TypeOfExpression(keyword: Syntax.Token(SyntaxKind.TypeOfKeyword),argumentList: v2244);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2250()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2248 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2247 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2248,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2247);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f2252()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2250 = this.f2250();
            Roslyn.Compilers.CSharp.TypeOfExpressionSyntax v2246 = this.f2246();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v2250,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v2246);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f2256()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v2252 = this.f2252();
            Roslyn.Compilers.CSharp.BlockSyntax v2236 = this.f2236();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v2112 = this.f2112();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v2252,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v2236,elseOpt: v2112);
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f2258()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v2256 = this.f2256();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v2256);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2260()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2264()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2262 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2261 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2262,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2261);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2268()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2266 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2265 = Syntax.IdentifierName("IsOptional");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2266,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2265);
        }

        Roslyn.Compilers.CSharp.ConditionalExpressionSyntax f2271()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2268 = this.f2268();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2264 = this.f2264();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2260 = this.f2260();
            return Syntax.ConditionalExpression(v2268,questionToken: Syntax.Token(SyntaxKind.QuestionToken),whenTrue: v2264,colonToken: Syntax.Token(SyntaxKind.ColonToken),whenFalse: v2260);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2273()
        {
            Roslyn.Compilers.CSharp.ConditionalExpressionSyntax v2271 = this.f2271();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2271);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2276()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2274 = Syntax.IdentifierName("id");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2274);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2281()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2276 = this.f2276();
            List<SyntaxNodeOrToken> list2278 = new List<SyntaxNodeOrToken>
            {
            v2276
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2279 = Syntax.SeparatedList<ArgumentSyntax>(list2278);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2279,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2285()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2283 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2282 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2283,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2282);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2286()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2285 = this.f2285();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2281 = this.f2281();
            return Syntax.InvocationExpression(v2285,v2281);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2288()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2286 = this.f2286();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2286);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2294()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2288 = this.f2288();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2273 = this.f2273();
            List<SyntaxNodeOrToken> list2291 = new List<SyntaxNodeOrToken>
            {
            v2288,Syntax.Token(SyntaxKind.CommaToken),v2273
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2292 = Syntax.SeparatedList<ArgumentSyntax>(list2291);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2292,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2296()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2295 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2294 = this.f2294();
            return Syntax.InvocationExpression(v2295,v2294);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2298()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2296 = this.f2296();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2296);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2303()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2298 = this.f2298();
            List<SyntaxNodeOrToken> list2300 = new List<SyntaxNodeOrToken>
            {
            v2298
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2301 = Syntax.SeparatedList<ArgumentSyntax>(list2300);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2301,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2307()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2305 = Syntax.IdentifierName("arguments");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2304 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2305,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2304);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2308()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2307 = this.f2307();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2303 = this.f2303();
            return Syntax.InvocationExpression(v2307,v2303);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2310()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2308 = this.f2308();
            return Syntax.ExpressionStatement(v2308,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2314()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2316()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2314 = this.f2314();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2314);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f2321()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2316 = this.f2316();
            List<SyntaxNodeOrToken> list2318 = new List<SyntaxNodeOrToken>
            {
            v2316
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2319 = Syntax.SeparatedList<ArgumentSyntax>(list2318);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v2319,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2326()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2324 = Syntax.IdentifierName("decl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2323 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2324,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2323);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2328()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2326 = this.f2326();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2322 = Syntax.IdentifierName("Variables");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2326,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2322);
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f2329()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2328 = this.f2328();
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v2321 = this.f2321();
            return Syntax.ElementAccessExpression(v2328,v2321);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2331()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v2329 = this.f2329();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2312 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2329,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2312);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2333()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2331 = this.f2331();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2311 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2331,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2311);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2335()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2333 = this.f2333();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2333);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2337()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2335 = this.f2335();
            return Syntax.VariableDeclarator(Syntax.Identifier("id"),argumentListOpt: null ,initializerOpt: v2335);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f2339()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2342()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v2339 = this.f2339();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2337 = this.f2337();
            List<SyntaxNodeOrToken> list2340 = new List<SyntaxNodeOrToken>
            {
            v2337
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2341 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2340);
            return Syntax.VariableDeclaration(v2339,variables: v2341);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f2346()
        {
            List<SyntaxToken> list2343 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v2344 = Syntax.TokenList(list2343);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2342 = this.f2342();
            return Syntax.LocalDeclarationStatement(modifiers: v2344,declaration: v2342,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2349()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2347 = Syntax.IdentifierName("decl");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2347);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2354()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2349 = this.f2349();
            List<SyntaxNodeOrToken> list2351 = new List<SyntaxNodeOrToken>
            {
            v2349
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2352 = Syntax.SeparatedList<ArgumentSyntax>(list2351);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2352,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2358()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2356 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2355 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2356,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2355);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2359()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2358 = this.f2358();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2354 = this.f2354();
            return Syntax.InvocationExpression(v2358,v2354);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2361()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2359 = this.f2359();
            return Syntax.ExpressionStatement(v2359,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2366()
        {
            List<SyntaxNodeOrToken> list2363 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2364 = Syntax.SeparatedList<ArgumentSyntax>(list2363);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2364,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ThisExpressionSyntax f2370()
        {
            return Syntax.ThisExpression(token: Syntax.Token(SyntaxKind.ThisKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2372()
        {
            Roslyn.Compilers.CSharp.ThisExpressionSyntax v2370 = this.f2370();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2368 = Syntax.IdentifierName("syntaxNodeLocals");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2370,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2368);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2374()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2372 = this.f2372();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2367 = Syntax.IdentifierName("Pop");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2372,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2367);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2375()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2374 = this.f2374();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2366 = this.f2366();
            return Syntax.InvocationExpression(v2374,v2366);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2377()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2375 = this.f2375();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2375);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2379()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2377 = this.f2377();
            return Syntax.VariableDeclarator(Syntax.Identifier("decl"),argumentListOpt: null ,initializerOpt: v2377);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2383()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2380 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2379 = this.f2379();
            List<SyntaxNodeOrToken> list2381 = new List<SyntaxNodeOrToken>
            {
            v2379
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2382 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2381);
            return Syntax.VariableDeclaration(v2380,variables: v2382);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f2387()
        {
            List<SyntaxToken> list2384 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v2385 = Syntax.TokenList(list2384);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2383 = this.f2383();
            return Syntax.LocalDeclarationStatement(modifiers: v2385,declaration: v2383,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2389()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2391()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2389 = this.f2389();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2389);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2396()
        {
            List<SyntaxNodeOrToken> list2393 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2394 = Syntax.SeparatedList<ArgumentSyntax>(list2393);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2394,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f2402()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2397 = Syntax.IdentifierName("SyntaxToken");
            List<SyntaxNodeOrToken> list2399 = new List<SyntaxNodeOrToken>
            {
            v2397
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v2400 = Syntax.SeparatedList<TypeSyntax>(list2399);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v2400,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f2404()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v2402 = this.f2402();
            return Syntax.GenericName(Syntax.Identifier("List"),v2402);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f2406()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v2404 = this.f2404();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2396 = this.f2396();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v2404,argumentListOpt: v2396,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2408()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v2406 = this.f2406();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2406);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2411()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2413()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2411 = this.f2411();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2411);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f2418()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2413 = this.f2413();
            List<SyntaxNodeOrToken> list2415 = new List<SyntaxNodeOrToken>
            {
            v2413
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2416 = Syntax.SeparatedList<ArgumentSyntax>(list2415);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v2416,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2423()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2421 = Syntax.IdentifierName("listDecl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2420 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2421,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2420);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2425()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2423 = this.f2423();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2419 = Syntax.IdentifierName("Variables");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2423,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2419);
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f2426()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2425 = this.f2425();
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v2418 = this.f2418();
            return Syntax.ElementAccessExpression(v2425,v2418);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2428()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v2426 = this.f2426();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2409 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2426,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2409);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2430()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2428 = this.f2428();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2428);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2435()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2430 = this.f2430();
            List<SyntaxNodeOrToken> list2432 = new List<SyntaxNodeOrToken>
            {
            v2430
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2433 = Syntax.SeparatedList<ArgumentSyntax>(list2432);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2433,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2439()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2437 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2436 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2437,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2436);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2440()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2439 = this.f2439();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2435 = this.f2435();
            return Syntax.InvocationExpression(v2439,v2435);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2442()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2440 = this.f2440();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2440);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2447()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2442 = this.f2442();
            List<SyntaxNodeOrToken> list2444 = new List<SyntaxNodeOrToken>
            {
            v2442
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2445 = Syntax.SeparatedList<ArgumentSyntax>(list2444);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2445,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2449()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2448 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2447 = this.f2447();
            return Syntax.InvocationExpression(v2448,v2447);
        }

        Roslyn.Compilers.CSharp.InitializerExpressionSyntax f2454()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2449 = this.f2449();
            List<SyntaxNodeOrToken> list2451 = new List<SyntaxNodeOrToken>
            {
            v2449
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v2452 = Syntax.SeparatedList<ExpressionSyntax>(list2451);
            return Syntax.InitializerExpression(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),expressions: v2452,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f2460()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2455 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list2457 = new List<SyntaxNodeOrToken>
            {
            v2455
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v2458 = Syntax.SeparatedList<TypeSyntax>(list2457);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v2458,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f2462()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v2460 = this.f2460();
            return Syntax.GenericName(Syntax.Identifier("List"),v2460);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f2464()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v2462 = this.f2462();
            Roslyn.Compilers.CSharp.InitializerExpressionSyntax v2454 = this.f2454();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v2462,argumentListOpt: null ,initializerOpt: v2454);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2466()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v2464 = this.f2464();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2464);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2468()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"TokenList\"", "\"TokenList\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2470()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2468 = this.f2468();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2468);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2474()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2472 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2471 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2472,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2471);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2476()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2474 = this.f2474();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2474);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2485()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2476 = this.f2476();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2470 = this.f2470();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2466 = this.f2466();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2408 = this.f2408();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2391 = this.f2391();
            List<SyntaxNodeOrToken> list2482 = new List<SyntaxNodeOrToken>
            {
            v2476,Syntax.Token(SyntaxKind.CommaToken),v2470,Syntax.Token(SyntaxKind.CommaToken),v2466,Syntax.Token(SyntaxKind.CommaToken),v2408,Syntax.Token(SyntaxKind.CommaToken),v2391
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2483 = Syntax.SeparatedList<ArgumentSyntax>(list2482);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2483,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2487()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2486 = Syntax.IdentifierName("CreateSyntaxNode");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2485 = this.f2485();
            return Syntax.InvocationExpression(v2486,v2485);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2489()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2487 = this.f2487();
            return Syntax.ExpressionStatement(v2487,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2492()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2490 = Syntax.IdentifierName("listDecl");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2490);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2497()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2492 = this.f2492();
            List<SyntaxNodeOrToken> list2494 = new List<SyntaxNodeOrToken>
            {
            v2492
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2495 = Syntax.SeparatedList<ArgumentSyntax>(list2494);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2495,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2501()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2499 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2498 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2499,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2498);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2502()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2501 = this.f2501();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2497 = this.f2497();
            return Syntax.InvocationExpression(v2501,v2497);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2504()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2502 = this.f2502();
            return Syntax.ExpressionStatement(v2502,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2507()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2505 = Syntax.IdentifierName("listInitExpressionList");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2505);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2510()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2508 = Syntax.IdentifierName("SyntaxToken");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2508);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2515()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2510 = this.f2510();
            List<SyntaxNodeOrToken> list2512 = new List<SyntaxNodeOrToken>
            {
            v2510
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2513 = Syntax.SeparatedList<ArgumentSyntax>(list2512);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2513,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeOfExpressionSyntax f2517()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2515 = this.f2515();
            return Syntax.TypeOfExpression(keyword: Syntax.Token(SyntaxKind.TypeOfKeyword),argumentList: v2515);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2519()
        {
            Roslyn.Compilers.CSharp.TypeOfExpressionSyntax v2517 = this.f2517();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2517);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2525()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2519 = this.f2519();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2507 = this.f2507();
            List<SyntaxNodeOrToken> list2522 = new List<SyntaxNodeOrToken>
            {
            v2519,Syntax.Token(SyntaxKind.CommaToken),v2507
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2523 = Syntax.SeparatedList<ArgumentSyntax>(list2522);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2523,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2527()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2526 = Syntax.IdentifierName("CreateListOfType");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2525 = this.f2525();
            return Syntax.InvocationExpression(v2526,v2525);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2529()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2527 = this.f2527();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2527);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2531()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2529 = this.f2529();
            return Syntax.VariableDeclarator(Syntax.Identifier("listDecl"),argumentListOpt: null ,initializerOpt: v2529);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2535()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2532 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2531 = this.f2531();
            List<SyntaxNodeOrToken> list2533 = new List<SyntaxNodeOrToken>
            {
            v2531
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2534 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2533);
            return Syntax.VariableDeclaration(v2532,variables: v2534);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f2539()
        {
            List<SyntaxToken> list2536 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v2537 = Syntax.TokenList(list2536);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2535 = this.f2535();
            return Syntax.LocalDeclarationStatement(modifiers: v2537,declaration: v2535,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2541()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\",\"", "\",\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2543()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2541 = this.f2541();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2541);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2545()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\",\"", "\",\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2547()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2545 = this.f2545();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2545);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2553()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2547 = this.f2547();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2543 = this.f2543();
            List<SyntaxNodeOrToken> list2550 = new List<SyntaxNodeOrToken>
            {
            v2547,Syntax.Token(SyntaxKind.CommaToken),v2543
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2551 = Syntax.SeparatedList<ArgumentSyntax>(list2550);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2551,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2557()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2555 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2554 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2555,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2554);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2558()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2557 = this.f2557();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2553 = this.f2553();
            return Syntax.InvocationExpression(v2557,v2553);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2560()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2558 = this.f2558();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2558);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2565()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2560 = this.f2560();
            List<SyntaxNodeOrToken> list2562 = new List<SyntaxNodeOrToken>
            {
            v2560
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2563 = Syntax.SeparatedList<ArgumentSyntax>(list2562);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2563,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2569()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2567 = Syntax.IdentifierName("listInitExpressionList");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2566 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2567,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2566);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2570()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2569 = this.f2569();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2565 = this.f2565();
            return Syntax.InvocationExpression(v2569,v2565);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2572()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2570 = this.f2570();
            return Syntax.ExpressionStatement(v2570,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f2577()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2572 = this.f2572();
            List<StatementSyntax> list2574 = new List<StatementSyntax>
            {
            v2572
            }

            ;
            SyntaxList<StatementSyntax> v2575 = Syntax.List<StatementSyntax>(list2574);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v2575,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2580()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("1", 1));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f2583()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2581 = Syntax.IdentifierName("i");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2580 = this.f2580();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v2581,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v2580);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f2585()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v2583 = this.f2583();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2578 = Syntax.IdentifierName("count");
            return Syntax.BinaryExpression(SyntaxKind.LessThanExpression,v2583,operatorToken: Syntax.Token(SyntaxKind.LessThanToken),right: v2578);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f2589()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v2585 = this.f2585();
            Roslyn.Compilers.CSharp.BlockSyntax v2577 = this.f2577();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v2585,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v2577,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2592()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2590 = Syntax.IdentifierName("expressionSyntax");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2590);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2597()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2592 = this.f2592();
            List<SyntaxNodeOrToken> list2594 = new List<SyntaxNodeOrToken>
            {
            v2592
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2595 = Syntax.SeparatedList<ArgumentSyntax>(list2594);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2595,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2601()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2599 = Syntax.IdentifierName("listInitExpressionList");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2598 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2599,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2598);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2602()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2601 = this.f2601();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2597 = this.f2597();
            return Syntax.InvocationExpression(v2601,v2597);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2604()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2602 = this.f2602();
            return Syntax.ExpressionStatement(v2602,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2607()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2605 = Syntax.IdentifierName("i");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2605);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f2612()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2607 = this.f2607();
            List<SyntaxNodeOrToken> list2609 = new List<SyntaxNodeOrToken>
            {
            v2607
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2610 = Syntax.SeparatedList<ArgumentSyntax>(list2609);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v2610,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f2614()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2613 = Syntax.IdentifierName("syntaxTokenList");
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v2612 = this.f2612();
            return Syntax.ElementAccessExpression(v2613,v2612);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2616()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v2614 = this.f2614();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2614);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2621()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2616 = this.f2616();
            List<SyntaxNodeOrToken> list2618 = new List<SyntaxNodeOrToken>
            {
            v2616
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2619 = Syntax.SeparatedList<ArgumentSyntax>(list2618);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2619,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2623()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2622 = Syntax.IdentifierName("CreateToken");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2621 = this.f2621();
            return Syntax.InvocationExpression(v2622,v2621);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2625()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2623 = this.f2623();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2623);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2627()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2625 = this.f2625();
            return Syntax.VariableDeclarator(Syntax.Identifier("expressionSyntax"),argumentListOpt: null ,initializerOpt: v2625);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2631()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2628 = Syntax.IdentifierName("ExpressionSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2627 = this.f2627();
            List<SyntaxNodeOrToken> list2629 = new List<SyntaxNodeOrToken>
            {
            v2627
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2630 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2629);
            return Syntax.VariableDeclaration(v2628,variables: v2630);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f2635()
        {
            List<SyntaxToken> list2632 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v2633 = Syntax.TokenList(list2632);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2631 = this.f2631();
            return Syntax.LocalDeclarationStatement(modifiers: v2633,declaration: v2631,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f2640()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v2635 = this.f2635();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2604 = this.f2604();
            Roslyn.Compilers.CSharp.IfStatementSyntax v2589 = this.f2589();
            List<StatementSyntax> list2637 = new List<StatementSyntax>
            {
            v2635,v2604,v2589
            }

            ;
            SyntaxList<StatementSyntax> v2638 = Syntax.List<StatementSyntax>(list2637);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v2638,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax f2643()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2641 = Syntax.IdentifierName("i");
            return Syntax.PostfixUnaryExpression(SyntaxKind.PostIncrementExpression,v2641,operatorToken: Syntax.Token(SyntaxKind.PlusPlusToken));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f2647()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2645 = Syntax.IdentifierName("i");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2644 = Syntax.IdentifierName("count");
            return Syntax.BinaryExpression(SyntaxKind.LessThanExpression,v2645,operatorToken: Syntax.Token(SyntaxKind.LessThanToken),right: v2644);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2649()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2651()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2649 = this.f2649();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2649);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2653()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2651 = this.f2651();
            return Syntax.VariableDeclarator(Syntax.Identifier("i"),argumentListOpt: null ,initializerOpt: v2651);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f2655()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.IntKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2658()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v2655 = this.f2655();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2653 = this.f2653();
            List<SyntaxNodeOrToken> list2656 = new List<SyntaxNodeOrToken>
            {
            v2653
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2657 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2656);
            return Syntax.VariableDeclaration(v2655,variables: v2657);
        }

        Roslyn.Compilers.CSharp.ForStatementSyntax f2668()
        {
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2658 = this.f2658();
            List<SyntaxNodeOrToken> list2661 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v2662 = Syntax.SeparatedList<ExpressionSyntax>(list2661);
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v2647 = this.f2647();
            Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax v2643 = this.f2643();
            List<SyntaxNodeOrToken> list2665 = new List<SyntaxNodeOrToken>
            {
            v2643
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v2666 = Syntax.SeparatedList<ExpressionSyntax>(list2665);
            Roslyn.Compilers.CSharp.BlockSyntax v2640 = this.f2640();
            return Syntax.ForStatement(forKeyword: Syntax.Token(SyntaxKind.ForKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),declarationOpt: v2658,initializers: v2662,firstSemicolonToken: Syntax.Token(SyntaxKind.SemicolonToken),conditionOpt: v2647,secondSemicolonToken: Syntax.Token(SyntaxKind.SemicolonToken),incrementors: v2666,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v2640);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2673()
        {
            List<SyntaxNodeOrToken> list2670 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2671 = Syntax.SeparatedList<ArgumentSyntax>(list2670);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2671,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f2679()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2674 = Syntax.IdentifierName("SyntaxNodeOrToken");
            List<SyntaxNodeOrToken> list2676 = new List<SyntaxNodeOrToken>
            {
            v2674
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v2677 = Syntax.SeparatedList<TypeSyntax>(list2676);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v2677,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f2681()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v2679 = this.f2679();
            return Syntax.GenericName(Syntax.Identifier("List"),v2679);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f2683()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v2681 = this.f2681();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2673 = this.f2673();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v2681,argumentListOpt: v2673,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2685()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v2683 = this.f2683();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2683);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2687()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2685 = this.f2685();
            return Syntax.VariableDeclarator(Syntax.Identifier("listInitExpressionList"),argumentListOpt: null ,initializerOpt: v2685);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f2693()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2688 = Syntax.IdentifierName("SyntaxNodeOrToken");
            List<SyntaxNodeOrToken> list2690 = new List<SyntaxNodeOrToken>
            {
            v2688
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v2691 = Syntax.SeparatedList<TypeSyntax>(list2690);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v2691,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f2695()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v2693 = this.f2693();
            return Syntax.GenericName(Syntax.Identifier("List"),v2693);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2698()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v2695 = this.f2695();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2687 = this.f2687();
            List<SyntaxNodeOrToken> list2696 = new List<SyntaxNodeOrToken>
            {
            v2687
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2697 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2696);
            return Syntax.VariableDeclaration(v2695,variables: v2697);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f2702()
        {
            List<SyntaxToken> list2699 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v2700 = Syntax.TokenList(list2699);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2698 = this.f2698();
            return Syntax.LocalDeclarationStatement(modifiers: v2700,declaration: v2698,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2706()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2704 = Syntax.IdentifierName("syntaxTokenList");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2703 = Syntax.IdentifierName("Count");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2704,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2703);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2708()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2706 = this.f2706();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2706);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2710()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2708 = this.f2708();
            return Syntax.VariableDeclarator(Syntax.Identifier("count"),argumentListOpt: null ,initializerOpt: v2708);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f2712()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.IntKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2715()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v2712 = this.f2712();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2710 = this.f2710();
            List<SyntaxNodeOrToken> list2713 = new List<SyntaxNodeOrToken>
            {
            v2710
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2714 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2713);
            return Syntax.VariableDeclaration(v2712,variables: v2714);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f2719()
        {
            List<SyntaxToken> list2716 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v2717 = Syntax.TokenList(list2716);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2715 = this.f2715();
            return Syntax.LocalDeclarationStatement(modifiers: v2717,declaration: v2715,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2721()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2723()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2721 = this.f2721();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2721);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2726()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2724 = Syntax.IdentifierName("node");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2724);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2732()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2726 = this.f2726();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2723 = this.f2723();
            List<SyntaxNodeOrToken> list2729 = new List<SyntaxNodeOrToken>
            {
            v2726,Syntax.Token(SyntaxKind.CommaToken),v2723
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2730 = Syntax.SeparatedList<ArgumentSyntax>(list2729);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2730,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2736()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2734 = Syntax.IdentifierName("newParameterName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2734);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2741()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2736 = this.f2736();
            List<SyntaxNodeOrToken> list2738 = new List<SyntaxNodeOrToken>
            {
            v2736
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2739 = Syntax.SeparatedList<ArgumentSyntax>(list2738);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2739,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2745()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2743 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2742 = Syntax.IdentifierName("GetProperty");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2743,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2742);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2746()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2745 = this.f2745();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2741 = this.f2741();
            return Syntax.InvocationExpression(v2745,v2741);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2748()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2746 = this.f2746();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2733 = Syntax.IdentifierName("GetValue");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2746,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2733);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2749()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2748 = this.f2748();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2732 = this.f2732();
            return Syntax.InvocationExpression(v2748,v2732);
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f2753()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2750 = Syntax.IdentifierName("SyntaxTokenList");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2749 = this.f2749();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v2750,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v2749);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2755()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v2753 = this.f2753();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2753);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2757()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2755 = this.f2755();
            return Syntax.VariableDeclarator(Syntax.Identifier("syntaxTokenList"),argumentListOpt: null ,initializerOpt: v2755);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2761()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2758 = Syntax.IdentifierName("SyntaxTokenList");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2757 = this.f2757();
            List<SyntaxNodeOrToken> list2759 = new List<SyntaxNodeOrToken>
            {
            v2757
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2760 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2759);
            return Syntax.VariableDeclaration(v2758,variables: v2760);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f2765()
        {
            List<SyntaxToken> list2762 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v2763 = Syntax.TokenList(list2762);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2761 = this.f2761();
            return Syntax.LocalDeclarationStatement(modifiers: v2763,declaration: v2761,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f2770()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v2765 = this.f2765();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v2719 = this.f2719();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v2702 = this.f2702();
            Roslyn.Compilers.CSharp.ForStatementSyntax v2668 = this.f2668();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v2539 = this.f2539();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2504 = this.f2504();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2489 = this.f2489();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v2387 = this.f2387();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2361 = this.f2361();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v2346 = this.f2346();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2310 = this.f2310();
            List<StatementSyntax> list2767 = new List<StatementSyntax>
            {
            v2765,v2719,v2702,v2668,v2539,v2504,v2489,v2387,v2361,v2346,v2310
            }

            ;
            SyntaxList<StatementSyntax> v2768 = Syntax.List<StatementSyntax>(list2767);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v2768,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2773()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2771 = Syntax.IdentifierName("SyntaxTokenList");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2771);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2778()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2773 = this.f2773();
            List<SyntaxNodeOrToken> list2775 = new List<SyntaxNodeOrToken>
            {
            v2773
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2776 = Syntax.SeparatedList<ArgumentSyntax>(list2775);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2776,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeOfExpressionSyntax f2780()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2778 = this.f2778();
            return Syntax.TypeOfExpression(keyword: Syntax.Token(SyntaxKind.TypeOfKeyword),argumentList: v2778);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2784()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2782 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2781 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2782,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2781);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f2786()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2784 = this.f2784();
            Roslyn.Compilers.CSharp.TypeOfExpressionSyntax v2780 = this.f2780();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v2784,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v2780);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f2790()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v2786 = this.f2786();
            Roslyn.Compilers.CSharp.BlockSyntax v2770 = this.f2770();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v2258 = this.f2258();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v2786,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v2770,elseOpt: v2258);
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f2792()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v2790 = this.f2790();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v2790);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2794()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2798()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2796 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2795 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2796,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2795);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2802()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2800 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2799 = Syntax.IdentifierName("IsOptional");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2800,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2799);
        }

        Roslyn.Compilers.CSharp.ConditionalExpressionSyntax f2805()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2802 = this.f2802();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2798 = this.f2798();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2794 = this.f2794();
            return Syntax.ConditionalExpression(v2802,questionToken: Syntax.Token(SyntaxKind.QuestionToken),whenTrue: v2798,colonToken: Syntax.Token(SyntaxKind.ColonToken),whenFalse: v2794);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2807()
        {
            Roslyn.Compilers.CSharp.ConditionalExpressionSyntax v2805 = this.f2805();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2805);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2810()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2808 = Syntax.IdentifierName("tokenExpr");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2808);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2816()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2810 = this.f2810();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2807 = this.f2807();
            List<SyntaxNodeOrToken> list2813 = new List<SyntaxNodeOrToken>
            {
            v2810,Syntax.Token(SyntaxKind.CommaToken),v2807
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2814 = Syntax.SeparatedList<ArgumentSyntax>(list2813);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2814,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2818()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2817 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2816 = this.f2816();
            return Syntax.InvocationExpression(v2817,v2816);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2820()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2818 = this.f2818();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2818);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2825()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2820 = this.f2820();
            List<SyntaxNodeOrToken> list2822 = new List<SyntaxNodeOrToken>
            {
            v2820
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2823 = Syntax.SeparatedList<ArgumentSyntax>(list2822);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2823,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2829()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2827 = Syntax.IdentifierName("arguments");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2826 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2827,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2826);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2830()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2829 = this.f2829();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2825 = this.f2825();
            return Syntax.InvocationExpression(v2829,v2825);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2832()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2830 = this.f2830();
            return Syntax.ExpressionStatement(v2830,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2835()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2833 = Syntax.IdentifierName("tokenValue");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2833);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2840()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2835 = this.f2835();
            List<SyntaxNodeOrToken> list2837 = new List<SyntaxNodeOrToken>
            {
            v2835
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2838 = Syntax.SeparatedList<ArgumentSyntax>(list2837);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2838,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2842()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2841 = Syntax.IdentifierName("CreateToken");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2840 = this.f2840();
            return Syntax.InvocationExpression(v2841,v2840);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2844()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2842 = this.f2842();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2842);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2846()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2844 = this.f2844();
            return Syntax.VariableDeclarator(Syntax.Identifier("tokenExpr"),argumentListOpt: null ,initializerOpt: v2844);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2850()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2847 = Syntax.IdentifierName("ExpressionSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2846 = this.f2846();
            List<SyntaxNodeOrToken> list2848 = new List<SyntaxNodeOrToken>
            {
            v2846
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2849 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2848);
            return Syntax.VariableDeclaration(v2847,variables: v2849);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f2854()
        {
            List<SyntaxToken> list2851 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v2852 = Syntax.TokenList(list2851);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2850 = this.f2850();
            return Syntax.LocalDeclarationStatement(modifiers: v2852,declaration: v2850,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2856()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2858()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2856 = this.f2856();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2856);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2861()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2859 = Syntax.IdentifierName("node");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2859);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2867()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2861 = this.f2861();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2858 = this.f2858();
            List<SyntaxNodeOrToken> list2864 = new List<SyntaxNodeOrToken>
            {
            v2861,Syntax.Token(SyntaxKind.CommaToken),v2858
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2865 = Syntax.SeparatedList<ArgumentSyntax>(list2864);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2865,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2871()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2869 = Syntax.IdentifierName("newParameterName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2869);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2876()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2871 = this.f2871();
            List<SyntaxNodeOrToken> list2873 = new List<SyntaxNodeOrToken>
            {
            v2871
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2874 = Syntax.SeparatedList<ArgumentSyntax>(list2873);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2874,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2880()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2878 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2877 = Syntax.IdentifierName("GetProperty");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2878,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2877);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2881()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2880 = this.f2880();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2876 = this.f2876();
            return Syntax.InvocationExpression(v2880,v2876);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2883()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2881 = this.f2881();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2868 = Syntax.IdentifierName("GetValue");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2881,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2868);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2884()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2883 = this.f2883();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2867 = this.f2867();
            return Syntax.InvocationExpression(v2883,v2867);
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f2888()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2885 = Syntax.IdentifierName("SyntaxToken");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2884 = this.f2884();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v2885,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v2884);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f2890()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v2888 = this.f2888();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v2888);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f2892()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v2890 = this.f2890();
            return Syntax.VariableDeclarator(Syntax.Identifier("tokenValue"),argumentListOpt: null ,initializerOpt: v2890);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f2896()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2893 = Syntax.IdentifierName("SyntaxToken");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v2892 = this.f2892();
            List<SyntaxNodeOrToken> list2894 = new List<SyntaxNodeOrToken>
            {
            v2892
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v2895 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list2894);
            return Syntax.VariableDeclaration(v2893,variables: v2895);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f2900()
        {
            List<SyntaxToken> list2897 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v2898 = Syntax.TokenList(list2897);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v2896 = this.f2896();
            return Syntax.LocalDeclarationStatement(modifiers: v2898,declaration: v2896,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f2905()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v2900 = this.f2900();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v2854 = this.f2854();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2832 = this.f2832();
            List<StatementSyntax> list2902 = new List<StatementSyntax>
            {
            v2900,v2854,v2832
            }

            ;
            SyntaxList<StatementSyntax> v2903 = Syntax.List<StatementSyntax>(list2902);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v2903,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2908()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2906 = Syntax.IdentifierName("SyntaxToken");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2906);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2913()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2908 = this.f2908();
            List<SyntaxNodeOrToken> list2910 = new List<SyntaxNodeOrToken>
            {
            v2908
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2911 = Syntax.SeparatedList<ArgumentSyntax>(list2910);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2911,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeOfExpressionSyntax f2915()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2913 = this.f2913();
            return Syntax.TypeOfExpression(keyword: Syntax.Token(SyntaxKind.TypeOfKeyword),argumentList: v2913);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2919()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2917 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2916 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2917,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2916);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f2921()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2919 = this.f2919();
            Roslyn.Compilers.CSharp.TypeOfExpressionSyntax v2915 = this.f2915();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v2919,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v2915);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f2925()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v2921 = this.f2921();
            Roslyn.Compilers.CSharp.BlockSyntax v2905 = this.f2905();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v2792 = this.f2792();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v2921,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v2905,elseOpt: v2792);
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f2927()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v2925 = this.f2925();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v2925);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2929()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2933()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2931 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2930 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2931,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2930);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2937()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2935 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2934 = Syntax.IdentifierName("IsOptional");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2935,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2934);
        }

        Roslyn.Compilers.CSharp.ConditionalExpressionSyntax f2940()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2937 = this.f2937();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2933 = this.f2933();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2929 = this.f2929();
            return Syntax.ConditionalExpression(v2937,questionToken: Syntax.Token(SyntaxKind.QuestionToken),whenTrue: v2933,colonToken: Syntax.Token(SyntaxKind.ColonToken),whenFalse: v2929);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2942()
        {
            Roslyn.Compilers.CSharp.ConditionalExpressionSyntax v2940 = this.f2940();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2940);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2945()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2943 = Syntax.IdentifierName("id");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2943);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2950()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2945 = this.f2945();
            List<SyntaxNodeOrToken> list2947 = new List<SyntaxNodeOrToken>
            {
            v2945
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2948 = Syntax.SeparatedList<ArgumentSyntax>(list2947);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2948,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2954()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2952 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2951 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2952,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2951);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2955()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2954 = this.f2954();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2950 = this.f2950();
            return Syntax.InvocationExpression(v2954,v2950);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2957()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2955 = this.f2955();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2955);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2963()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2957 = this.f2957();
            Roslyn.Compilers.CSharp.ArgumentSyntax v2942 = this.f2942();
            List<SyntaxNodeOrToken> list2960 = new List<SyntaxNodeOrToken>
            {
            v2957,Syntax.Token(SyntaxKind.CommaToken),v2942
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2961 = Syntax.SeparatedList<ArgumentSyntax>(list2960);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2961,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2965()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2964 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2963 = this.f2963();
            return Syntax.InvocationExpression(v2964,v2963);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2967()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2965 = this.f2965();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2965);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f2972()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2967 = this.f2967();
            List<SyntaxNodeOrToken> list2969 = new List<SyntaxNodeOrToken>
            {
            v2967
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2970 = Syntax.SeparatedList<ArgumentSyntax>(list2969);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v2970,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2976()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2974 = Syntax.IdentifierName("arguments");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2973 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2974,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2973);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f2977()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2976 = this.f2976();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v2972 = this.f2972();
            return Syntax.InvocationExpression(v2976,v2972);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f2979()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v2977 = this.f2977();
            return Syntax.ExpressionStatement(v2977,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f2983()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f2985()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v2983 = this.f2983();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v2983);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f2990()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v2985 = this.f2985();
            List<SyntaxNodeOrToken> list2987 = new List<SyntaxNodeOrToken>
            {
            v2985
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v2988 = Syntax.SeparatedList<ArgumentSyntax>(list2987);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v2988,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2995()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2993 = Syntax.IdentifierName("decl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2992 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2993,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2992);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f2997()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2995 = this.f2995();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2991 = Syntax.IdentifierName("Variables");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2995,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2991);
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f2998()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v2997 = this.f2997();
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v2990 = this.f2990();
            return Syntax.ElementAccessExpression(v2997,v2990);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3000()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v2998 = this.f2998();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2981 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v2998,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2981);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3002()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3000 = this.f3000();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v2980 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3000,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v2980);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3004()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3002 = this.f3002();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3002);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3006()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3004 = this.f3004();
            return Syntax.VariableDeclarator(Syntax.Identifier("id"),argumentListOpt: null ,initializerOpt: v3004);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f3008()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3011()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v3008 = this.f3008();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3006 = this.f3006();
            List<SyntaxNodeOrToken> list3009 = new List<SyntaxNodeOrToken>
            {
            v3006
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3010 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3009);
            return Syntax.VariableDeclaration(v3008,variables: v3010);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3015()
        {
            List<SyntaxToken> list3012 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3013 = Syntax.TokenList(list3012);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3011 = this.f3011();
            return Syntax.LocalDeclarationStatement(modifiers: v3013,declaration: v3011,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3018()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3016 = Syntax.IdentifierName("decl");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3016);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3023()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3018 = this.f3018();
            List<SyntaxNodeOrToken> list3020 = new List<SyntaxNodeOrToken>
            {
            v3018
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3021 = Syntax.SeparatedList<ArgumentSyntax>(list3020);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3021,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3027()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3025 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3024 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3025,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3024);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3028()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3027 = this.f3027();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3023 = this.f3023();
            return Syntax.InvocationExpression(v3027,v3023);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f3030()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3028 = this.f3028();
            return Syntax.ExpressionStatement(v3028,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3035()
        {
            List<SyntaxNodeOrToken> list3032 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3033 = Syntax.SeparatedList<ArgumentSyntax>(list3032);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3033,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ThisExpressionSyntax f3039()
        {
            return Syntax.ThisExpression(token: Syntax.Token(SyntaxKind.ThisKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3041()
        {
            Roslyn.Compilers.CSharp.ThisExpressionSyntax v3039 = this.f3039();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3037 = Syntax.IdentifierName("syntaxNodeLocals");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3039,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3037);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3043()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3041 = this.f3041();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3036 = Syntax.IdentifierName("Pop");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3041,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3036);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3044()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3043 = this.f3043();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3035 = this.f3035();
            return Syntax.InvocationExpression(v3043,v3035);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3046()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3044 = this.f3044();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3044);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3048()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3046 = this.f3046();
            return Syntax.VariableDeclarator(Syntax.Identifier("decl"),argumentListOpt: null ,initializerOpt: v3046);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3052()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3049 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3048 = this.f3048();
            List<SyntaxNodeOrToken> list3050 = new List<SyntaxNodeOrToken>
            {
            v3048
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3051 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3050);
            return Syntax.VariableDeclaration(v3049,variables: v3051);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3056()
        {
            List<SyntaxToken> list3053 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3054 = Syntax.TokenList(list3053);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3052 = this.f3052();
            return Syntax.LocalDeclarationStatement(modifiers: v3054,declaration: v3052,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3058()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3060()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3058 = this.f3058();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3058);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3065()
        {
            List<SyntaxNodeOrToken> list3062 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3063 = Syntax.SeparatedList<ArgumentSyntax>(list3062);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3063,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f3071()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3066 = Syntax.IdentifierName("SyntaxToken");
            List<SyntaxNodeOrToken> list3068 = new List<SyntaxNodeOrToken>
            {
            v3066
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v3069 = Syntax.SeparatedList<TypeSyntax>(list3068);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v3069,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f3073()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v3071 = this.f3071();
            return Syntax.GenericName(Syntax.Identifier("List"),v3071);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f3075()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v3073 = this.f3073();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3065 = this.f3065();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v3073,argumentListOpt: v3065,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3077()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v3075 = this.f3075();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3075);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3080()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3082()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3080 = this.f3080();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3080);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f3087()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3082 = this.f3082();
            List<SyntaxNodeOrToken> list3084 = new List<SyntaxNodeOrToken>
            {
            v3082
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3085 = Syntax.SeparatedList<ArgumentSyntax>(list3084);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v3085,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3092()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3090 = Syntax.IdentifierName("listDecl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3089 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3090,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3089);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3094()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3092 = this.f3092();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3088 = Syntax.IdentifierName("Variables");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3092,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3088);
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f3095()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3094 = this.f3094();
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v3087 = this.f3087();
            return Syntax.ElementAccessExpression(v3094,v3087);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3097()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v3095 = this.f3095();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3078 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3095,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3078);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3099()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3097 = this.f3097();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3097);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3104()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3099 = this.f3099();
            List<SyntaxNodeOrToken> list3101 = new List<SyntaxNodeOrToken>
            {
            v3099
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3102 = Syntax.SeparatedList<ArgumentSyntax>(list3101);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3102,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3108()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3106 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3105 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3106,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3105);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3109()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3108 = this.f3108();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3104 = this.f3104();
            return Syntax.InvocationExpression(v3108,v3104);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3111()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3109 = this.f3109();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3109);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3116()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3111 = this.f3111();
            List<SyntaxNodeOrToken> list3113 = new List<SyntaxNodeOrToken>
            {
            v3111
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3114 = Syntax.SeparatedList<ArgumentSyntax>(list3113);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3114,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3118()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3117 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3116 = this.f3116();
            return Syntax.InvocationExpression(v3117,v3116);
        }

        Roslyn.Compilers.CSharp.InitializerExpressionSyntax f3123()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3118 = this.f3118();
            List<SyntaxNodeOrToken> list3120 = new List<SyntaxNodeOrToken>
            {
            v3118
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v3121 = Syntax.SeparatedList<ExpressionSyntax>(list3120);
            return Syntax.InitializerExpression(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),expressions: v3121,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f3129()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3124 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list3126 = new List<SyntaxNodeOrToken>
            {
            v3124
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v3127 = Syntax.SeparatedList<TypeSyntax>(list3126);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v3127,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f3131()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v3129 = this.f3129();
            return Syntax.GenericName(Syntax.Identifier("List"),v3129);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f3133()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v3131 = this.f3131();
            Roslyn.Compilers.CSharp.InitializerExpressionSyntax v3123 = this.f3123();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v3131,argumentListOpt: null ,initializerOpt: v3123);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3135()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v3133 = this.f3133();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3133);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3139()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3137 = Syntax.IdentifierName("genericType");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3136 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3137,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3136);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3141()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3139 = this.f3139();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3139);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3143()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"SeparatedList<{0}>\"", "\"SeparatedList<{0}>\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3145()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3143 = this.f3143();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3143);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3151()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3145 = this.f3145();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3141 = this.f3141();
            List<SyntaxNodeOrToken> list3148 = new List<SyntaxNodeOrToken>
            {
            v3145,Syntax.Token(SyntaxKind.CommaToken),v3141
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3149 = Syntax.SeparatedList<ArgumentSyntax>(list3148);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3149,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f3154()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3156()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v3154 = this.f3154();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3152 = Syntax.IdentifierName("Format");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3154,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3152);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3157()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3156 = this.f3156();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3151 = this.f3151();
            return Syntax.InvocationExpression(v3156,v3151);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3159()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3157 = this.f3157();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3157);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3163()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3161 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3160 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3161,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3160);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3165()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3163 = this.f3163();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3163);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3174()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3165 = this.f3165();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3159 = this.f3159();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3135 = this.f3135();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3077 = this.f3077();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3060 = this.f3060();
            List<SyntaxNodeOrToken> list3171 = new List<SyntaxNodeOrToken>
            {
            v3165,Syntax.Token(SyntaxKind.CommaToken),v3159,Syntax.Token(SyntaxKind.CommaToken),v3135,Syntax.Token(SyntaxKind.CommaToken),v3077,Syntax.Token(SyntaxKind.CommaToken),v3060
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3172 = Syntax.SeparatedList<ArgumentSyntax>(list3171);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3172,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3176()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3175 = Syntax.IdentifierName("CreateSyntaxNode");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3174 = this.f3174();
            return Syntax.InvocationExpression(v3175,v3174);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f3178()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3176 = this.f3176();
            return Syntax.ExpressionStatement(v3176,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3181()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3179 = Syntax.IdentifierName("listDecl");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3179);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3186()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3181 = this.f3181();
            List<SyntaxNodeOrToken> list3183 = new List<SyntaxNodeOrToken>
            {
            v3181
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3184 = Syntax.SeparatedList<ArgumentSyntax>(list3183);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3184,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3190()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3188 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3187 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3188,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3187);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3191()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3190 = this.f3190();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3186 = this.f3186();
            return Syntax.InvocationExpression(v3190,v3186);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f3193()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3191 = this.f3191();
            return Syntax.ExpressionStatement(v3191,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3195()
        {
            return Syntax.LiteralExpression(SyntaxKind.TrueLiteralExpression,token: Syntax.Token(SyntaxKind.TrueKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3197()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3195 = this.f3195();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3195);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3200()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3198 = Syntax.IdentifierName("dependentVariableDefinitions");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3198);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3203()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3201 = Syntax.IdentifierName("genericType");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3201);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3206()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3204 = Syntax.IdentifierName("SyntaxNodeOrToken");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3204);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3211()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3206 = this.f3206();
            List<SyntaxNodeOrToken> list3208 = new List<SyntaxNodeOrToken>
            {
            v3206
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3209 = Syntax.SeparatedList<ArgumentSyntax>(list3208);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3209,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeOfExpressionSyntax f3213()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3211 = this.f3211();
            return Syntax.TypeOfExpression(keyword: Syntax.Token(SyntaxKind.TypeOfKeyword),argumentList: v3211);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3215()
        {
            Roslyn.Compilers.CSharp.TypeOfExpressionSyntax v3213 = this.f3213();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3213);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3218()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3216 = Syntax.IdentifierName("count");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3216);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3227()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3218 = this.f3218();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3215 = this.f3215();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3203 = this.f3203();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3200 = this.f3200();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3197 = this.f3197();
            List<SyntaxNodeOrToken> list3224 = new List<SyntaxNodeOrToken>
            {
            v3218,Syntax.Token(SyntaxKind.CommaToken),v3215,Syntax.Token(SyntaxKind.CommaToken),v3203,Syntax.Token(SyntaxKind.CommaToken),v3200,Syntax.Token(SyntaxKind.CommaToken),v3197
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3225 = Syntax.SeparatedList<ArgumentSyntax>(list3224);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3225,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3229()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3228 = Syntax.IdentifierName("CreateListOfType");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3227 = this.f3227();
            return Syntax.InvocationExpression(v3228,v3227);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3231()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3229 = this.f3229();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3229);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3233()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3231 = this.f3231();
            return Syntax.VariableDeclarator(Syntax.Identifier("listDecl"),argumentListOpt: null ,initializerOpt: v3231);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3237()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3234 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3233 = this.f3233();
            List<SyntaxNodeOrToken> list3235 = new List<SyntaxNodeOrToken>
            {
            v3233
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3236 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3235);
            return Syntax.VariableDeclaration(v3234,variables: v3236);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3241()
        {
            List<SyntaxToken> list3238 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3239 = Syntax.TokenList(list3238);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3237 = this.f3237();
            return Syntax.LocalDeclarationStatement(modifiers: v3239,declaration: v3237,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3243()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3245()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3243 = this.f3243();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3243);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f3250()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3245 = this.f3245();
            List<SyntaxNodeOrToken> list3247 = new List<SyntaxNodeOrToken>
            {
            v3245
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3248 = Syntax.SeparatedList<ArgumentSyntax>(list3247);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v3248,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f3252()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3251 = Syntax.IdentifierName("genericTypes");
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v3250 = this.f3250();
            return Syntax.ElementAccessExpression(v3251,v3250);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3254()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v3252 = this.f3252();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3252);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3256()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3254 = this.f3254();
            return Syntax.VariableDeclarator(Syntax.Identifier("genericType"),argumentListOpt: null ,initializerOpt: v3254);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3260()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3257 = Syntax.IdentifierName("Type");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3256 = this.f3256();
            List<SyntaxNodeOrToken> list3258 = new List<SyntaxNodeOrToken>
            {
            v3256
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3259 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3258);
            return Syntax.VariableDeclaration(v3257,variables: v3259);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3264()
        {
            List<SyntaxToken> list3261 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3262 = Syntax.TokenList(list3261);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3260 = this.f3260();
            return Syntax.LocalDeclarationStatement(modifiers: v3262,declaration: v3260,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3269()
        {
            List<SyntaxNodeOrToken> list3266 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3267 = Syntax.SeparatedList<ArgumentSyntax>(list3266);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3267,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3274()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3272 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3271 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3272,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3271);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3276()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3274 = this.f3274();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3270 = Syntax.IdentifierName("GetGenericArguments");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3274,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3270);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3277()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3276 = this.f3276();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3269 = this.f3269();
            return Syntax.InvocationExpression(v3276,v3269);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3279()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3277 = this.f3277();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3277);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3281()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3279 = this.f3279();
            return Syntax.VariableDeclarator(Syntax.Identifier("genericTypes"),argumentListOpt: null ,initializerOpt: v3279);
        }

        Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax f3286()
        {
            List<SyntaxNodeOrToken> list3283 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v3284 = Syntax.SeparatedList<ExpressionSyntax>(list3283);
            return Syntax.ArrayRankSpecifier(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),sizes: v3284,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.ArrayTypeSyntax f3290()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3287 = Syntax.IdentifierName("Type");
            Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax v3286 = this.f3286();
            List<ArrayRankSpecifierSyntax> list3288 = new List<ArrayRankSpecifierSyntax>
            {
            v3286
            }

            ;
            SyntaxList<ArrayRankSpecifierSyntax> v3289 = Syntax.List<ArrayRankSpecifierSyntax>(list3288);
            return Syntax.ArrayType(v3287,rankSpecifiers: v3289);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3293()
        {
            Roslyn.Compilers.CSharp.ArrayTypeSyntax v3290 = this.f3290();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3281 = this.f3281();
            List<SyntaxNodeOrToken> list3291 = new List<SyntaxNodeOrToken>
            {
            v3281
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3292 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3291);
            return Syntax.VariableDeclaration(v3290,variables: v3292);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3297()
        {
            List<SyntaxToken> list3294 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3295 = Syntax.TokenList(list3294);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3293 = this.f3293();
            return Syntax.LocalDeclarationStatement(modifiers: v3295,declaration: v3293,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3302()
        {
            List<SyntaxNodeOrToken> list3299 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3300 = Syntax.SeparatedList<ArgumentSyntax>(list3299);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3300,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3308()
        {
            List<SyntaxNodeOrToken> list3305 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3306 = Syntax.SeparatedList<ArgumentSyntax>(list3305);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3306,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f3314()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3309 = Syntax.IdentifierName("SyntaxNode");
            List<SyntaxNodeOrToken> list3311 = new List<SyntaxNodeOrToken>
            {
            v3309
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v3312 = Syntax.SeparatedList<TypeSyntax>(list3311);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v3312,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f3316()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v3314 = this.f3314();
            return Syntax.GenericName(Syntax.Identifier("Cast"),v3314);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3319()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3317 = Syntax.IdentifierName("syntaxList");
            Roslyn.Compilers.CSharp.GenericNameSyntax v3316 = this.f3316();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3317,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3316);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3320()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3319 = this.f3319();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3308 = this.f3308();
            return Syntax.InvocationExpression(v3319,v3308);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3322()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3320 = this.f3320();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3303 = Syntax.IdentifierName("Count");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3320,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3303);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3323()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3322 = this.f3322();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3302 = this.f3302();
            return Syntax.InvocationExpression(v3322,v3302);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3325()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3323 = this.f3323();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3323);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3327()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3325 = this.f3325();
            return Syntax.VariableDeclarator(Syntax.Identifier("count"),argumentListOpt: null ,initializerOpt: v3325);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f3329()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.IntKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3332()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v3329 = this.f3329();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3327 = this.f3327();
            List<SyntaxNodeOrToken> list3330 = new List<SyntaxNodeOrToken>
            {
            v3327
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3331 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3330);
            return Syntax.VariableDeclaration(v3329,variables: v3331);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3336()
        {
            List<SyntaxToken> list3333 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3334 = Syntax.TokenList(list3333);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3332 = this.f3332();
            return Syntax.LocalDeclarationStatement(modifiers: v3334,declaration: v3332,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3338()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3340()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3338 = this.f3338();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3338);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3343()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3341 = Syntax.IdentifierName("node");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3341);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3349()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3343 = this.f3343();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3340 = this.f3340();
            List<SyntaxNodeOrToken> list3346 = new List<SyntaxNodeOrToken>
            {
            v3343,Syntax.Token(SyntaxKind.CommaToken),v3340
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3347 = Syntax.SeparatedList<ArgumentSyntax>(list3346);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3347,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3353()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3351 = Syntax.IdentifierName("newParameterName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3351);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3358()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3353 = this.f3353();
            List<SyntaxNodeOrToken> list3355 = new List<SyntaxNodeOrToken>
            {
            v3353
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3356 = Syntax.SeparatedList<ArgumentSyntax>(list3355);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3356,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3362()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3360 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3359 = Syntax.IdentifierName("GetProperty");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3360,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3359);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3363()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3362 = this.f3362();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3358 = this.f3358();
            return Syntax.InvocationExpression(v3362,v3358);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3365()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3363 = this.f3363();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3350 = Syntax.IdentifierName("GetValue");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3363,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3350);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3366()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3365 = this.f3365();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3349 = this.f3349();
            return Syntax.InvocationExpression(v3365,v3349);
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f3370()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3367 = Syntax.IdentifierName("IEnumerable");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3366 = this.f3366();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v3367,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v3366);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3372()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v3370 = this.f3370();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3370);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3374()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3372 = this.f3372();
            return Syntax.VariableDeclarator(Syntax.Identifier("syntaxList"),argumentListOpt: null ,initializerOpt: v3372);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3378()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3375 = Syntax.IdentifierName("IEnumerable");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3374 = this.f3374();
            List<SyntaxNodeOrToken> list3376 = new List<SyntaxNodeOrToken>
            {
            v3374
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3377 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3376);
            return Syntax.VariableDeclaration(v3375,variables: v3377);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3382()
        {
            List<SyntaxToken> list3379 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3380 = Syntax.TokenList(list3379);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3378 = this.f3378();
            return Syntax.LocalDeclarationStatement(modifiers: v3380,declaration: v3378,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f3387()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3382 = this.f3382();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3336 = this.f3336();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3297 = this.f3297();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3264 = this.f3264();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3241 = this.f3241();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v3193 = this.f3193();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v3178 = this.f3178();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3056 = this.f3056();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v3030 = this.f3030();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3015 = this.f3015();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2979 = this.f2979();
            List<StatementSyntax> list3384 = new List<StatementSyntax>
            {
            v3382,v3336,v3297,v3264,v3241,v3193,v3178,v3056,v3030,v3015,v2979
            }

            ;
            SyntaxList<StatementSyntax> v3385 = Syntax.List<StatementSyntax>(list3384);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v3385,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3389()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"SeparatedSyntaxList`1\"", "\"SeparatedSyntaxList`1\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3394()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3392 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3391 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3392,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3391);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3396()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3394 = this.f3394();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3390 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3394,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3390);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f3398()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3396 = this.f3396();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3389 = this.f3389();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v3396,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v3389);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f3402()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v3398 = this.f3398();
            Roslyn.Compilers.CSharp.BlockSyntax v3387 = this.f3387();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v2927 = this.f2927();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v3398,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v3387,elseOpt: v2927);
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f3404()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v3402 = this.f3402();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v3402);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3406()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3410()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3408 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3407 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3408,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3407);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3414()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3412 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3411 = Syntax.IdentifierName("IsOptional");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3412,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3411);
        }

        Roslyn.Compilers.CSharp.ConditionalExpressionSyntax f3417()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3414 = this.f3414();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3410 = this.f3410();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3406 = this.f3406();
            return Syntax.ConditionalExpression(v3414,questionToken: Syntax.Token(SyntaxKind.QuestionToken),whenTrue: v3410,colonToken: Syntax.Token(SyntaxKind.ColonToken),whenFalse: v3406);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3419()
        {
            Roslyn.Compilers.CSharp.ConditionalExpressionSyntax v3417 = this.f3417();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3417);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3422()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3420 = Syntax.IdentifierName("id");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3420);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3427()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3422 = this.f3422();
            List<SyntaxNodeOrToken> list3424 = new List<SyntaxNodeOrToken>
            {
            v3422
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3425 = Syntax.SeparatedList<ArgumentSyntax>(list3424);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3425,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3431()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3429 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3428 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3429,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3428);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3432()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3431 = this.f3431();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3427 = this.f3427();
            return Syntax.InvocationExpression(v3431,v3427);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3434()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3432 = this.f3432();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3432);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3440()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3434 = this.f3434();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3419 = this.f3419();
            List<SyntaxNodeOrToken> list3437 = new List<SyntaxNodeOrToken>
            {
            v3434,Syntax.Token(SyntaxKind.CommaToken),v3419
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3438 = Syntax.SeparatedList<ArgumentSyntax>(list3437);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3438,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3442()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3441 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3440 = this.f3440();
            return Syntax.InvocationExpression(v3441,v3440);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3444()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3442 = this.f3442();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3442);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3449()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3444 = this.f3444();
            List<SyntaxNodeOrToken> list3446 = new List<SyntaxNodeOrToken>
            {
            v3444
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3447 = Syntax.SeparatedList<ArgumentSyntax>(list3446);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3447,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3453()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3451 = Syntax.IdentifierName("arguments");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3450 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3451,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3450);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3454()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3453 = this.f3453();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3449 = this.f3449();
            return Syntax.InvocationExpression(v3453,v3449);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f3456()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3454 = this.f3454();
            return Syntax.ExpressionStatement(v3454,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3460()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3462()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3460 = this.f3460();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3460);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f3467()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3462 = this.f3462();
            List<SyntaxNodeOrToken> list3464 = new List<SyntaxNodeOrToken>
            {
            v3462
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3465 = Syntax.SeparatedList<ArgumentSyntax>(list3464);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v3465,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3472()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3470 = Syntax.IdentifierName("decl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3469 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3470,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3469);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3474()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3472 = this.f3472();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3468 = Syntax.IdentifierName("Variables");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3472,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3468);
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f3475()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3474 = this.f3474();
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v3467 = this.f3467();
            return Syntax.ElementAccessExpression(v3474,v3467);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3477()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v3475 = this.f3475();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3458 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3475,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3458);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3479()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3477 = this.f3477();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3457 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3477,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3457);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3481()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3479 = this.f3479();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3479);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3483()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3481 = this.f3481();
            return Syntax.VariableDeclarator(Syntax.Identifier("id"),argumentListOpt: null ,initializerOpt: v3481);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f3485()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3488()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v3485 = this.f3485();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3483 = this.f3483();
            List<SyntaxNodeOrToken> list3486 = new List<SyntaxNodeOrToken>
            {
            v3483
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3487 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3486);
            return Syntax.VariableDeclaration(v3485,variables: v3487);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3492()
        {
            List<SyntaxToken> list3489 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3490 = Syntax.TokenList(list3489);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3488 = this.f3488();
            return Syntax.LocalDeclarationStatement(modifiers: v3490,declaration: v3488,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3495()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3493 = Syntax.IdentifierName("decl");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3493);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3500()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3495 = this.f3495();
            List<SyntaxNodeOrToken> list3497 = new List<SyntaxNodeOrToken>
            {
            v3495
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3498 = Syntax.SeparatedList<ArgumentSyntax>(list3497);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3498,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3504()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3502 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3501 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3502,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3501);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3505()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3504 = this.f3504();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3500 = this.f3500();
            return Syntax.InvocationExpression(v3504,v3500);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f3507()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3505 = this.f3505();
            return Syntax.ExpressionStatement(v3505,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3512()
        {
            List<SyntaxNodeOrToken> list3509 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3510 = Syntax.SeparatedList<ArgumentSyntax>(list3509);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3510,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ThisExpressionSyntax f3516()
        {
            return Syntax.ThisExpression(token: Syntax.Token(SyntaxKind.ThisKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3518()
        {
            Roslyn.Compilers.CSharp.ThisExpressionSyntax v3516 = this.f3516();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3514 = Syntax.IdentifierName("syntaxNodeLocals");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3516,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3514);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3520()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3518 = this.f3518();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3513 = Syntax.IdentifierName("Pop");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3518,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3513);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3521()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3520 = this.f3520();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3512 = this.f3512();
            return Syntax.InvocationExpression(v3520,v3512);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3523()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3521 = this.f3521();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3521);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3525()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3523 = this.f3523();
            return Syntax.VariableDeclarator(Syntax.Identifier("decl"),argumentListOpt: null ,initializerOpt: v3523);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3529()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3526 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3525 = this.f3525();
            List<SyntaxNodeOrToken> list3527 = new List<SyntaxNodeOrToken>
            {
            v3525
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3528 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3527);
            return Syntax.VariableDeclaration(v3526,variables: v3528);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3533()
        {
            List<SyntaxToken> list3530 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3531 = Syntax.TokenList(list3530);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3529 = this.f3529();
            return Syntax.LocalDeclarationStatement(modifiers: v3531,declaration: v3529,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3535()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3537()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3535 = this.f3535();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3535);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3542()
        {
            List<SyntaxNodeOrToken> list3539 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3540 = Syntax.SeparatedList<ArgumentSyntax>(list3539);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3540,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f3548()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3543 = Syntax.IdentifierName("SyntaxToken");
            List<SyntaxNodeOrToken> list3545 = new List<SyntaxNodeOrToken>
            {
            v3543
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v3546 = Syntax.SeparatedList<TypeSyntax>(list3545);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v3546,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f3550()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v3548 = this.f3548();
            return Syntax.GenericName(Syntax.Identifier("List"),v3548);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f3552()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v3550 = this.f3550();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3542 = this.f3542();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v3550,argumentListOpt: v3542,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3554()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v3552 = this.f3552();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3552);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3557()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3559()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3557 = this.f3557();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3557);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f3564()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3559 = this.f3559();
            List<SyntaxNodeOrToken> list3561 = new List<SyntaxNodeOrToken>
            {
            v3559
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3562 = Syntax.SeparatedList<ArgumentSyntax>(list3561);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v3562,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3569()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3567 = Syntax.IdentifierName("listDecl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3566 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3567,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3566);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3571()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3569 = this.f3569();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3565 = Syntax.IdentifierName("Variables");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3569,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3565);
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f3572()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3571 = this.f3571();
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v3564 = this.f3564();
            return Syntax.ElementAccessExpression(v3571,v3564);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3574()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v3572 = this.f3572();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3555 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3572,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3555);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3576()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3574 = this.f3574();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3574);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3581()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3576 = this.f3576();
            List<SyntaxNodeOrToken> list3578 = new List<SyntaxNodeOrToken>
            {
            v3576
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3579 = Syntax.SeparatedList<ArgumentSyntax>(list3578);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3579,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3585()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3583 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3582 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3583,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3582);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3586()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3585 = this.f3585();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3581 = this.f3581();
            return Syntax.InvocationExpression(v3585,v3581);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3588()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3586 = this.f3586();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3586);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3593()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3588 = this.f3588();
            List<SyntaxNodeOrToken> list3590 = new List<SyntaxNodeOrToken>
            {
            v3588
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3591 = Syntax.SeparatedList<ArgumentSyntax>(list3590);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3591,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3595()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3594 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3593 = this.f3593();
            return Syntax.InvocationExpression(v3594,v3593);
        }

        Roslyn.Compilers.CSharp.InitializerExpressionSyntax f3600()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3595 = this.f3595();
            List<SyntaxNodeOrToken> list3597 = new List<SyntaxNodeOrToken>
            {
            v3595
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v3598 = Syntax.SeparatedList<ExpressionSyntax>(list3597);
            return Syntax.InitializerExpression(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),expressions: v3598,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f3606()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3601 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list3603 = new List<SyntaxNodeOrToken>
            {
            v3601
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v3604 = Syntax.SeparatedList<TypeSyntax>(list3603);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v3604,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f3608()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v3606 = this.f3606();
            return Syntax.GenericName(Syntax.Identifier("List"),v3606);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f3610()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v3608 = this.f3608();
            Roslyn.Compilers.CSharp.InitializerExpressionSyntax v3600 = this.f3600();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v3608,argumentListOpt: null ,initializerOpt: v3600);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3612()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v3610 = this.f3610();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3610);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3616()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3614 = Syntax.IdentifierName("genericType");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3613 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3614,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3613);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3618()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3616 = this.f3616();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3616);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3620()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"List<{0}>\"", "\"List<{0}>\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3622()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3620 = this.f3620();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3620);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3628()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3622 = this.f3622();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3618 = this.f3618();
            List<SyntaxNodeOrToken> list3625 = new List<SyntaxNodeOrToken>
            {
            v3622,Syntax.Token(SyntaxKind.CommaToken),v3618
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3626 = Syntax.SeparatedList<ArgumentSyntax>(list3625);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3626,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f3631()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3633()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v3631 = this.f3631();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3629 = Syntax.IdentifierName("Format");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3631,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3629);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3634()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3633 = this.f3633();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3628 = this.f3628();
            return Syntax.InvocationExpression(v3633,v3628);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3636()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3634 = this.f3634();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3634);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3640()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3638 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3637 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3638,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3637);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3642()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3640 = this.f3640();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3640);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3651()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3642 = this.f3642();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3636 = this.f3636();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3612 = this.f3612();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3554 = this.f3554();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3537 = this.f3537();
            List<SyntaxNodeOrToken> list3648 = new List<SyntaxNodeOrToken>
            {
            v3642,Syntax.Token(SyntaxKind.CommaToken),v3636,Syntax.Token(SyntaxKind.CommaToken),v3612,Syntax.Token(SyntaxKind.CommaToken),v3554,Syntax.Token(SyntaxKind.CommaToken),v3537
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3649 = Syntax.SeparatedList<ArgumentSyntax>(list3648);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3649,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3653()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3652 = Syntax.IdentifierName("CreateSyntaxNode");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3651 = this.f3651();
            return Syntax.InvocationExpression(v3652,v3651);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f3655()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3653 = this.f3653();
            return Syntax.ExpressionStatement(v3653,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3658()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3656 = Syntax.IdentifierName("listDecl");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3656);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3663()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3658 = this.f3658();
            List<SyntaxNodeOrToken> list3660 = new List<SyntaxNodeOrToken>
            {
            v3658
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3661 = Syntax.SeparatedList<ArgumentSyntax>(list3660);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3661,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3667()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3665 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3664 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3665,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3664);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3668()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3667 = this.f3667();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3663 = this.f3663();
            return Syntax.InvocationExpression(v3667,v3663);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f3670()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3668 = this.f3668();
            return Syntax.ExpressionStatement(v3668,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3672()
        {
            return Syntax.LiteralExpression(SyntaxKind.FalseLiteralExpression,token: Syntax.Token(SyntaxKind.FalseKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3674()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3672 = this.f3672();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3672);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3677()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3675 = Syntax.IdentifierName("dependentVariableDefinitions");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3675);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3680()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3678 = Syntax.IdentifierName("genericType");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3678);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3683()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3681 = Syntax.IdentifierName("genericType");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3681);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3686()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3684 = Syntax.IdentifierName("count");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3684);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3695()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3686 = this.f3686();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3683 = this.f3683();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3680 = this.f3680();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3677 = this.f3677();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3674 = this.f3674();
            List<SyntaxNodeOrToken> list3692 = new List<SyntaxNodeOrToken>
            {
            v3686,Syntax.Token(SyntaxKind.CommaToken),v3683,Syntax.Token(SyntaxKind.CommaToken),v3680,Syntax.Token(SyntaxKind.CommaToken),v3677,Syntax.Token(SyntaxKind.CommaToken),v3674
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3693 = Syntax.SeparatedList<ArgumentSyntax>(list3692);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3693,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3697()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3696 = Syntax.IdentifierName("CreateListOfType");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3695 = this.f3695();
            return Syntax.InvocationExpression(v3696,v3695);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3699()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3697 = this.f3697();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3697);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3701()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3699 = this.f3699();
            return Syntax.VariableDeclarator(Syntax.Identifier("listDecl"),argumentListOpt: null ,initializerOpt: v3699);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3705()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3702 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3701 = this.f3701();
            List<SyntaxNodeOrToken> list3703 = new List<SyntaxNodeOrToken>
            {
            v3701
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3704 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3703);
            return Syntax.VariableDeclaration(v3702,variables: v3704);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3709()
        {
            List<SyntaxToken> list3706 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3707 = Syntax.TokenList(list3706);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3705 = this.f3705();
            return Syntax.LocalDeclarationStatement(modifiers: v3707,declaration: v3705,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3711()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3713()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3711 = this.f3711();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3711);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f3718()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3713 = this.f3713();
            List<SyntaxNodeOrToken> list3715 = new List<SyntaxNodeOrToken>
            {
            v3713
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3716 = Syntax.SeparatedList<ArgumentSyntax>(list3715);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v3716,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f3720()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3719 = Syntax.IdentifierName("genericTypes");
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v3718 = this.f3718();
            return Syntax.ElementAccessExpression(v3719,v3718);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3722()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v3720 = this.f3720();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3720);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3724()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3722 = this.f3722();
            return Syntax.VariableDeclarator(Syntax.Identifier("genericType"),argumentListOpt: null ,initializerOpt: v3722);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3728()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3725 = Syntax.IdentifierName("Type");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3724 = this.f3724();
            List<SyntaxNodeOrToken> list3726 = new List<SyntaxNodeOrToken>
            {
            v3724
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3727 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3726);
            return Syntax.VariableDeclaration(v3725,variables: v3727);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3732()
        {
            List<SyntaxToken> list3729 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3730 = Syntax.TokenList(list3729);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3728 = this.f3728();
            return Syntax.LocalDeclarationStatement(modifiers: v3730,declaration: v3728,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3737()
        {
            List<SyntaxNodeOrToken> list3734 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3735 = Syntax.SeparatedList<ArgumentSyntax>(list3734);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3735,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3742()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3740 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3739 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3740,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3739);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3744()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3742 = this.f3742();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3738 = Syntax.IdentifierName("GetGenericArguments");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3742,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3738);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3745()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3744 = this.f3744();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3737 = this.f3737();
            return Syntax.InvocationExpression(v3744,v3737);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3747()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3745 = this.f3745();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3745);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3749()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3747 = this.f3747();
            return Syntax.VariableDeclarator(Syntax.Identifier("genericTypes"),argumentListOpt: null ,initializerOpt: v3747);
        }

        Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax f3754()
        {
            List<SyntaxNodeOrToken> list3751 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v3752 = Syntax.SeparatedList<ExpressionSyntax>(list3751);
            return Syntax.ArrayRankSpecifier(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),sizes: v3752,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.ArrayTypeSyntax f3758()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3755 = Syntax.IdentifierName("Type");
            Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax v3754 = this.f3754();
            List<ArrayRankSpecifierSyntax> list3756 = new List<ArrayRankSpecifierSyntax>
            {
            v3754
            }

            ;
            SyntaxList<ArrayRankSpecifierSyntax> v3757 = Syntax.List<ArrayRankSpecifierSyntax>(list3756);
            return Syntax.ArrayType(v3755,rankSpecifiers: v3757);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3761()
        {
            Roslyn.Compilers.CSharp.ArrayTypeSyntax v3758 = this.f3758();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3749 = this.f3749();
            List<SyntaxNodeOrToken> list3759 = new List<SyntaxNodeOrToken>
            {
            v3749
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3760 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3759);
            return Syntax.VariableDeclaration(v3758,variables: v3760);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3765()
        {
            List<SyntaxToken> list3762 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3763 = Syntax.TokenList(list3762);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3761 = this.f3761();
            return Syntax.LocalDeclarationStatement(modifiers: v3763,declaration: v3761,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3770()
        {
            List<SyntaxNodeOrToken> list3767 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3768 = Syntax.SeparatedList<ArgumentSyntax>(list3767);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3768,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3776()
        {
            List<SyntaxNodeOrToken> list3773 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3774 = Syntax.SeparatedList<ArgumentSyntax>(list3773);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3774,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f3782()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3777 = Syntax.IdentifierName("SyntaxNode");
            List<SyntaxNodeOrToken> list3779 = new List<SyntaxNodeOrToken>
            {
            v3777
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v3780 = Syntax.SeparatedList<TypeSyntax>(list3779);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v3780,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f3784()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v3782 = this.f3782();
            return Syntax.GenericName(Syntax.Identifier("Cast"),v3782);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3787()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3785 = Syntax.IdentifierName("syntaxList");
            Roslyn.Compilers.CSharp.GenericNameSyntax v3784 = this.f3784();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3785,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3784);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3788()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3787 = this.f3787();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3776 = this.f3776();
            return Syntax.InvocationExpression(v3787,v3776);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3790()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3788 = this.f3788();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3771 = Syntax.IdentifierName("Count");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3788,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3771);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3791()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3790 = this.f3790();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3770 = this.f3770();
            return Syntax.InvocationExpression(v3790,v3770);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3793()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3791 = this.f3791();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3791);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3795()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3793 = this.f3793();
            return Syntax.VariableDeclarator(Syntax.Identifier("count"),argumentListOpt: null ,initializerOpt: v3793);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f3797()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.IntKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3800()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v3797 = this.f3797();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3795 = this.f3795();
            List<SyntaxNodeOrToken> list3798 = new List<SyntaxNodeOrToken>
            {
            v3795
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3799 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3798);
            return Syntax.VariableDeclaration(v3797,variables: v3799);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3804()
        {
            List<SyntaxToken> list3801 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3802 = Syntax.TokenList(list3801);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3800 = this.f3800();
            return Syntax.LocalDeclarationStatement(modifiers: v3802,declaration: v3800,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3806()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3808()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3806 = this.f3806();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3806);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3811()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3809 = Syntax.IdentifierName("node");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3809);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3817()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3811 = this.f3811();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3808 = this.f3808();
            List<SyntaxNodeOrToken> list3814 = new List<SyntaxNodeOrToken>
            {
            v3811,Syntax.Token(SyntaxKind.CommaToken),v3808
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3815 = Syntax.SeparatedList<ArgumentSyntax>(list3814);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3815,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3821()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3819 = Syntax.IdentifierName("newParameterName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3819);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3826()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3821 = this.f3821();
            List<SyntaxNodeOrToken> list3823 = new List<SyntaxNodeOrToken>
            {
            v3821
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3824 = Syntax.SeparatedList<ArgumentSyntax>(list3823);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3824,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3830()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3828 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3827 = Syntax.IdentifierName("GetProperty");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3828,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3827);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3831()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3830 = this.f3830();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3826 = this.f3826();
            return Syntax.InvocationExpression(v3830,v3826);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3833()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3831 = this.f3831();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3818 = Syntax.IdentifierName("GetValue");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3831,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3818);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3834()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3833 = this.f3833();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3817 = this.f3817();
            return Syntax.InvocationExpression(v3833,v3817);
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f3838()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3835 = Syntax.IdentifierName("IEnumerable");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3834 = this.f3834();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v3835,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v3834);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f3840()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v3838 = this.f3838();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v3838);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f3842()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v3840 = this.f3840();
            return Syntax.VariableDeclarator(Syntax.Identifier("syntaxList"),argumentListOpt: null ,initializerOpt: v3840);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f3846()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3843 = Syntax.IdentifierName("IEnumerable");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v3842 = this.f3842();
            List<SyntaxNodeOrToken> list3844 = new List<SyntaxNodeOrToken>
            {
            v3842
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v3845 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list3844);
            return Syntax.VariableDeclaration(v3843,variables: v3845);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f3850()
        {
            List<SyntaxToken> list3847 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v3848 = Syntax.TokenList(list3847);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v3846 = this.f3846();
            return Syntax.LocalDeclarationStatement(modifiers: v3848,declaration: v3846,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f3855()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3850 = this.f3850();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3804 = this.f3804();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3765 = this.f3765();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3732 = this.f3732();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3709 = this.f3709();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v3670 = this.f3670();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v3655 = this.f3655();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3533 = this.f3533();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v3507 = this.f3507();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v3492 = this.f3492();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v3456 = this.f3456();
            List<StatementSyntax> list3852 = new List<StatementSyntax>
            {
            v3850,v3804,v3765,v3732,v3709,v3670,v3655,v3533,v3507,v3492,v3456
            }

            ;
            SyntaxList<StatementSyntax> v3853 = Syntax.List<StatementSyntax>(list3852);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v3853,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3857()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"SyntaxList`1\"", "\"SyntaxList`1\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3862()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3860 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3859 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3860,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3859);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3864()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3862 = this.f3862();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3858 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3862,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3858);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f3866()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3864 = this.f3864();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3857 = this.f3857();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v3864,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v3857);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f3870()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v3866 = this.f3866();
            Roslyn.Compilers.CSharp.BlockSyntax v3855 = this.f3855();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v3404 = this.f3404();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v3866,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v3855,elseOpt: v3404);
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f3872()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v3870 = this.f3870();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v3870);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3874()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3878()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3876 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3875 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3876,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3875);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3882()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3880 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3879 = Syntax.IdentifierName("IsOptional");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3880,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3879);
        }

        Roslyn.Compilers.CSharp.ConditionalExpressionSyntax f3885()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3882 = this.f3882();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3878 = this.f3878();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3874 = this.f3874();
            return Syntax.ConditionalExpression(v3882,questionToken: Syntax.Token(SyntaxKind.QuestionToken),whenTrue: v3878,colonToken: Syntax.Token(SyntaxKind.ColonToken),whenFalse: v3874);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3887()
        {
            Roslyn.Compilers.CSharp.ConditionalExpressionSyntax v3885 = this.f3885();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3885);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3891()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3889 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3888 = Syntax.IdentifierName("NullLiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3889,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3888);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3893()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3891 = this.f3891();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3891);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3898()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3893 = this.f3893();
            List<SyntaxNodeOrToken> list3895 = new List<SyntaxNodeOrToken>
            {
            v3893
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3896 = Syntax.SeparatedList<ArgumentSyntax>(list3895);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3896,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3902()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3900 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3899 = Syntax.IdentifierName("LiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3900,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3899);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3903()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3902 = this.f3902();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3898 = this.f3898();
            return Syntax.InvocationExpression(v3902,v3898);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3905()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3903 = this.f3903();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3903);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3911()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3905 = this.f3905();
            Roslyn.Compilers.CSharp.ArgumentSyntax v3887 = this.f3887();
            List<SyntaxNodeOrToken> list3908 = new List<SyntaxNodeOrToken>
            {
            v3905,Syntax.Token(SyntaxKind.CommaToken),v3887
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3909 = Syntax.SeparatedList<ArgumentSyntax>(list3908);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3909,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3913()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3912 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3911 = this.f3911();
            return Syntax.InvocationExpression(v3912,v3911);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f3915()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3913 = this.f3913();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3913);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3920()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v3915 = this.f3915();
            List<SyntaxNodeOrToken> list3917 = new List<SyntaxNodeOrToken>
            {
            v3915
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3918 = Syntax.SeparatedList<ArgumentSyntax>(list3917);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3918,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3924()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3922 = Syntax.IdentifierName("arguments");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3921 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3922,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3921);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3925()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3924 = this.f3924();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3920 = this.f3920();
            return Syntax.InvocationExpression(v3924,v3920);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f3927()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3925 = this.f3925();
            return Syntax.ExpressionStatement(v3925,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f3932()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v3927 = this.f3927();
            List<StatementSyntax> list3929 = new List<StatementSyntax>
            {
            v3927
            }

            ;
            SyntaxList<StatementSyntax> v3930 = Syntax.List<StatementSyntax>(list3929);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v3930,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f3934()
        {
            Roslyn.Compilers.CSharp.BlockSyntax v3932 = this.f3932();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v3932);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f3939()
        {
            List<SyntaxNodeOrToken> list3936 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v3937 = Syntax.SeparatedList<ArgumentSyntax>(list3936);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v3937,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f3945()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3942 = Syntax.IdentifierName("SimpleNameSyntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3941 = Syntax.IdentifierName("newNode");
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v3942,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v3941);
        }

        Roslyn.Compilers.CSharp.ParenthesizedExpressionSyntax f3948()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v3945 = this.f3945();
            return Syntax.ParenthesizedExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),expression: v3945,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3950()
        {
            Roslyn.Compilers.CSharp.ParenthesizedExpressionSyntax v3948 = this.f3948();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3940 = Syntax.IdentifierName("GetFullText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3948,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3940);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f3951()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3950 = this.f3950();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v3939 = this.f3939();
            return Syntax.InvocationExpression(v3950,v3939);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f3954()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3952 = Syntax.IdentifierName("friendlyName");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v3951 = this.f3951();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v3952,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v3951);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f3956()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v3954 = this.f3954();
            return Syntax.ExpressionStatement(v3954,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f3961()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v3956 = this.f3956();
            List<StatementSyntax> list3958 = new List<StatementSyntax>
            {
            v3956
            }

            ;
            SyntaxList<StatementSyntax> v3959 = Syntax.List<StatementSyntax>(list3958);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v3959,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f3965()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3963 = Syntax.IdentifierName("newNode");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3962 = Syntax.IdentifierName("SimpleNameSyntax");
            return Syntax.BinaryExpression(SyntaxKind.IsExpression,v3963,operatorToken: Syntax.Token(SyntaxKind.IsKeyword),right: v3962);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f3969()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v3965 = this.f3965();
            Roslyn.Compilers.CSharp.BlockSyntax v3961 = this.f3961();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v3965,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v3961,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.BlockSyntax f3974()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v3969 = this.f3969();
            List<StatementSyntax> list3971 = new List<StatementSyntax>
            {
            v3969
            }

            ;
            SyntaxList<StatementSyntax> v3972 = Syntax.List<StatementSyntax>(list3971);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v3972,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3976()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"identifier\"", "\"identifier\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3980()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3978 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3977 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3978,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3977);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f3982()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3980 = this.f3980();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3976 = this.f3976();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v3980,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v3976);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f3986()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v3982 = this.f3982();
            Roslyn.Compilers.CSharp.BlockSyntax v3974 = this.f3974();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v3982,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v3974,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f3988()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3992()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3990 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3989 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3990,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3989);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f3996()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3994 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v3993 = Syntax.IdentifierName("IsOptional");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v3994,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v3993);
        }

        Roslyn.Compilers.CSharp.ConditionalExpressionSyntax f3999()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3996 = this.f3996();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v3992 = this.f3992();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v3988 = this.f3988();
            return Syntax.ConditionalExpression(v3996,questionToken: Syntax.Token(SyntaxKind.QuestionToken),whenTrue: v3992,colonToken: Syntax.Token(SyntaxKind.ColonToken),whenFalse: v3988);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4001()
        {
            Roslyn.Compilers.CSharp.ConditionalExpressionSyntax v3999 = this.f3999();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v3999);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4004()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4002 = Syntax.IdentifierName("id");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4002);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4009()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4004 = this.f4004();
            List<SyntaxNodeOrToken> list4006 = new List<SyntaxNodeOrToken>
            {
            v4004
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4007 = Syntax.SeparatedList<ArgumentSyntax>(list4006);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4007,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4013()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4011 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4010 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4011,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4010);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4014()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4013 = this.f4013();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4009 = this.f4009();
            return Syntax.InvocationExpression(v4013,v4009);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4016()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4014 = this.f4014();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4014);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4022()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4016 = this.f4016();
            Roslyn.Compilers.CSharp.ArgumentSyntax v4001 = this.f4001();
            List<SyntaxNodeOrToken> list4019 = new List<SyntaxNodeOrToken>
            {
            v4016,Syntax.Token(SyntaxKind.CommaToken),v4001
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4020 = Syntax.SeparatedList<ArgumentSyntax>(list4019);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4020,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4024()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4023 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4022 = this.f4022();
            return Syntax.InvocationExpression(v4023,v4022);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4026()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4024 = this.f4024();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4024);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4031()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4026 = this.f4026();
            List<SyntaxNodeOrToken> list4028 = new List<SyntaxNodeOrToken>
            {
            v4026
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4029 = Syntax.SeparatedList<ArgumentSyntax>(list4028);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4029,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4035()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4033 = Syntax.IdentifierName("arguments");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4032 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4033,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4032);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4036()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4035 = this.f4035();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4031 = this.f4031();
            return Syntax.InvocationExpression(v4035,v4031);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4038()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4036 = this.f4036();
            return Syntax.ExpressionStatement(v4036,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4042()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4044()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4042 = this.f4042();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4042);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f4049()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4044 = this.f4044();
            List<SyntaxNodeOrToken> list4046 = new List<SyntaxNodeOrToken>
            {
            v4044
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4047 = Syntax.SeparatedList<ArgumentSyntax>(list4046);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v4047,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4054()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4052 = Syntax.IdentifierName("decl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4051 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4052,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4051);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4056()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4054 = this.f4054();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4050 = Syntax.IdentifierName("Variables");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4054,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4050);
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f4057()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4056 = this.f4056();
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v4049 = this.f4049();
            return Syntax.ElementAccessExpression(v4056,v4049);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4059()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v4057 = this.f4057();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4040 = Syntax.IdentifierName("Identifier");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4057,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4040);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4061()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4059 = this.f4059();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4039 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4059,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4039);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4063()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4061 = this.f4061();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4061);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4065()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4063 = this.f4063();
            return Syntax.VariableDeclarator(Syntax.Identifier("id"),argumentListOpt: null ,initializerOpt: v4063);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4067()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4070()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4067 = this.f4067();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4065 = this.f4065();
            List<SyntaxNodeOrToken> list4068 = new List<SyntaxNodeOrToken>
            {
            v4065
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4069 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4068);
            return Syntax.VariableDeclaration(v4067,variables: v4069);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4074()
        {
            List<SyntaxToken> list4071 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4072 = Syntax.TokenList(list4071);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4070 = this.f4070();
            return Syntax.LocalDeclarationStatement(modifiers: v4072,declaration: v4070,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4077()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4075 = Syntax.IdentifierName("decl");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4075);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4082()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4077 = this.f4077();
            List<SyntaxNodeOrToken> list4079 = new List<SyntaxNodeOrToken>
            {
            v4077
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4080 = Syntax.SeparatedList<ArgumentSyntax>(list4079);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4080,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4086()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4084 = Syntax.IdentifierName("dependentVariableDefinitions");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4083 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4084,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4083);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4087()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4086 = this.f4086();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4082 = this.f4082();
            return Syntax.InvocationExpression(v4086,v4082);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4089()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4087 = this.f4087();
            return Syntax.ExpressionStatement(v4087,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4091()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Types do not match when popping SyntaxNode declaration stack.\"", "\"Types do not match when popping SyntaxNode declaration stack.\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4093()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4091 = this.f4091();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4091);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4098()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4093 = this.f4093();
            List<SyntaxNodeOrToken> list4095 = new List<SyntaxNodeOrToken>
            {
            v4093
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4096 = Syntax.SeparatedList<ArgumentSyntax>(list4095);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4096,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f4101()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4099 = Syntax.IdentifierName("ApplicationException");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4098 = this.f4098();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v4099,argumentListOpt: v4098,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.ThrowStatementSyntax f4104()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v4101 = this.f4101();
            return Syntax.ThrowStatement(throwKeyword: Syntax.Token(SyntaxKind.ThrowKeyword),expressionOpt: v4101,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f4109()
        {
            Roslyn.Compilers.CSharp.ThrowStatementSyntax v4104 = this.f4104();
            List<StatementSyntax> list4106 = new List<StatementSyntax>
            {
            v4104
            }

            ;
            SyntaxList<StatementSyntax> v4107 = Syntax.List<StatementSyntax>(list4106);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v4107,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4115()
        {
            List<SyntaxNodeOrToken> list4112 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4113 = Syntax.SeparatedList<ArgumentSyntax>(list4112);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4113,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4119()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4117 = Syntax.IdentifierName("newNode");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4116 = Syntax.IdentifierName("GetType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4117,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4116);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4120()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4119 = this.f4119();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4115 = this.f4115();
            return Syntax.InvocationExpression(v4119,v4115);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4122()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4120 = this.f4120();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4110 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4120,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4110);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4128()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4126 = Syntax.IdentifierName("decl");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4125 = Syntax.IdentifierName("Declaration");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4126,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4125);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4130()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4128 = this.f4128();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4124 = Syntax.IdentifierName("Type");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4128,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4124);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4132()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4130 = this.f4130();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4123 = Syntax.IdentifierName("PlainName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4130,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4123);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4134()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4132 = this.f4132();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4122 = this.f4122();
            return Syntax.BinaryExpression(SyntaxKind.NotEqualsExpression,v4132,operatorToken: Syntax.Token(SyntaxKind.ExclamationEqualsToken),right: v4122);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f4138()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4134 = this.f4134();
            Roslyn.Compilers.CSharp.BlockSyntax v4109 = this.f4109();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v4134,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v4109,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4143()
        {
            List<SyntaxNodeOrToken> list4140 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4141 = Syntax.SeparatedList<ArgumentSyntax>(list4140);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4141,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ThisExpressionSyntax f4147()
        {
            return Syntax.ThisExpression(token: Syntax.Token(SyntaxKind.ThisKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4149()
        {
            Roslyn.Compilers.CSharp.ThisExpressionSyntax v4147 = this.f4147();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4145 = Syntax.IdentifierName("syntaxNodeLocals");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4147,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4145);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4151()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4149 = this.f4149();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4144 = Syntax.IdentifierName("Pop");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4149,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4144);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4152()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4151 = this.f4151();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4143 = this.f4143();
            return Syntax.InvocationExpression(v4151,v4143);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4154()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4152 = this.f4152();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4152);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4156()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4154 = this.f4154();
            return Syntax.VariableDeclarator(Syntax.Identifier("decl"),argumentListOpt: null ,initializerOpt: v4154);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4160()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4157 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4156 = this.f4156();
            List<SyntaxNodeOrToken> list4158 = new List<SyntaxNodeOrToken>
            {
            v4156
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4159 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4158);
            return Syntax.VariableDeclaration(v4157,variables: v4159);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4164()
        {
            List<SyntaxToken> list4161 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4162 = Syntax.TokenList(list4161);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4160 = this.f4160();
            return Syntax.LocalDeclarationStatement(modifiers: v4162,declaration: v4160,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f4169()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4164 = this.f4164();
            Roslyn.Compilers.CSharp.IfStatementSyntax v4138 = this.f4138();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4089 = this.f4089();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4074 = this.f4074();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4038 = this.f4038();
            Roslyn.Compilers.CSharp.IfStatementSyntax v3986 = this.f3986();
            List<StatementSyntax> list4166 = new List<StatementSyntax>
            {
            v4164,v4138,v4089,v4074,v4038,v3986
            }

            ;
            SyntaxList<StatementSyntax> v4167 = Syntax.List<StatementSyntax>(list4166);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v4167,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4171()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4174()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4172 = Syntax.IdentifierName("newNode");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4171 = this.f4171();
            return Syntax.BinaryExpression(SyntaxKind.NotEqualsExpression,v4172,operatorToken: Syntax.Token(SyntaxKind.ExclamationEqualsToken),right: v4171);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f4178()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4174 = this.f4174();
            Roslyn.Compilers.CSharp.BlockSyntax v4169 = this.f4169();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v3934 = this.f3934();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v4174,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v4169,elseOpt: v3934);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4180()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4182()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4180 = this.f4180();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4180);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4185()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4183 = Syntax.IdentifierName("node");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4183);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4191()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4185 = this.f4185();
            Roslyn.Compilers.CSharp.ArgumentSyntax v4182 = this.f4182();
            List<SyntaxNodeOrToken> list4188 = new List<SyntaxNodeOrToken>
            {
            v4185,Syntax.Token(SyntaxKind.CommaToken),v4182
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4189 = Syntax.SeparatedList<ArgumentSyntax>(list4188);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4189,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4195()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4193 = Syntax.IdentifierName("newParameterName");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4193);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4200()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4195 = this.f4195();
            List<SyntaxNodeOrToken> list4197 = new List<SyntaxNodeOrToken>
            {
            v4195
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4198 = Syntax.SeparatedList<ArgumentSyntax>(list4197);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4198,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4204()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4202 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4201 = Syntax.IdentifierName("GetProperty");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4202,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4201);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4205()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4204 = this.f4204();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4200 = this.f4200();
            return Syntax.InvocationExpression(v4204,v4200);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4207()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4205 = this.f4205();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4192 = Syntax.IdentifierName("GetValue");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4205,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4192);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4208()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4207 = this.f4207();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4191 = this.f4191();
            return Syntax.InvocationExpression(v4207,v4191);
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f4212()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4209 = Syntax.IdentifierName("SyntaxNode");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4208 = this.f4208();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v4209,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v4208);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4214()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v4212 = this.f4212();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4212);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4216()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4214 = this.f4214();
            return Syntax.VariableDeclarator(Syntax.Identifier("newNode"),argumentListOpt: null ,initializerOpt: v4214);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4220()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4217 = Syntax.IdentifierName("SyntaxNode");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4216 = this.f4216();
            List<SyntaxNodeOrToken> list4218 = new List<SyntaxNodeOrToken>
            {
            v4216
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4219 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4218);
            return Syntax.VariableDeclaration(v4217,variables: v4219);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4224()
        {
            List<SyntaxToken> list4221 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4222 = Syntax.TokenList(list4221);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4220 = this.f4220();
            return Syntax.LocalDeclarationStatement(modifiers: v4222,declaration: v4220,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f4229()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4224 = this.f4224();
            Roslyn.Compilers.CSharp.IfStatementSyntax v4178 = this.f4178();
            List<StatementSyntax> list4226 = new List<StatementSyntax>
            {
            v4224,v4178
            }

            ;
            SyntaxList<StatementSyntax> v4227 = Syntax.List<StatementSyntax>(list4226);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v4227,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f4234()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4230 = Syntax.IdentifierName("foundSyntaxNode");
            Roslyn.Compilers.CSharp.BlockSyntax v4229 = this.f4229();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v3872 = this.f3872();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v4230,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v4229,elseOpt: v3872);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4238()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4236 = Syntax.IdentifierName("typeSearch");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4235 = Syntax.IdentifierName("BaseType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4236,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4235);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4241()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4239 = Syntax.IdentifierName("typeSearch");
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4238 = this.f4238();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v4239,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v4238);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4243()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4241 = this.f4241();
            return Syntax.ExpressionStatement(v4241,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4245()
        {
            return Syntax.LiteralExpression(SyntaxKind.TrueLiteralExpression,token: Syntax.Token(SyntaxKind.TrueKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4248()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4246 = Syntax.IdentifierName("foundSyntaxNode");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4245 = this.f4245();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v4246,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v4245);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4250()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4248 = this.f4248();
            return Syntax.ExpressionStatement(v4248,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f4255()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4250 = this.f4250();
            List<StatementSyntax> list4252 = new List<StatementSyntax>
            {
            v4250
            }

            ;
            SyntaxList<StatementSyntax> v4253 = Syntax.List<StatementSyntax>(list4252);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v4253,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4258()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4256 = Syntax.IdentifierName("SyntaxNode");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4256);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4263()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4258 = this.f4258();
            List<SyntaxNodeOrToken> list4260 = new List<SyntaxNodeOrToken>
            {
            v4258
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4261 = Syntax.SeparatedList<ArgumentSyntax>(list4260);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4261,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeOfExpressionSyntax f4265()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4263 = this.f4263();
            return Syntax.TypeOfExpression(keyword: Syntax.Token(SyntaxKind.TypeOfKeyword),argumentList: v4263);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4268()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4266 = Syntax.IdentifierName("typeSearch");
            Roslyn.Compilers.CSharp.TypeOfExpressionSyntax v4265 = this.f4265();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v4266,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v4265);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f4272()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4268 = this.f4268();
            Roslyn.Compilers.CSharp.BlockSyntax v4255 = this.f4255();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v4268,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v4255,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.BlockSyntax f4277()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v4272 = this.f4272();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4243 = this.f4243();
            List<StatementSyntax> list4274 = new List<StatementSyntax>
            {
            v4272,v4243
            }

            ;
            SyntaxList<StatementSyntax> v4275 = Syntax.List<StatementSyntax>(list4274);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v4275,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4279()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4282()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4280 = Syntax.IdentifierName("typeSearch");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4279 = this.f4279();
            return Syntax.BinaryExpression(SyntaxKind.NotEqualsExpression,v4280,operatorToken: Syntax.Token(SyntaxKind.ExclamationEqualsToken),right: v4279);
        }

        Roslyn.Compilers.CSharp.WhileStatementSyntax f4286()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4282 = this.f4282();
            Roslyn.Compilers.CSharp.BlockSyntax v4277 = this.f4277();
            return Syntax.WhileStatement(whileKeyword: Syntax.Token(SyntaxKind.WhileKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v4282,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v4277);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4288()
        {
            return Syntax.LiteralExpression(SyntaxKind.FalseLiteralExpression,token: Syntax.Token(SyntaxKind.FalseKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4290()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4288 = this.f4288();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4288);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4292()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4290 = this.f4290();
            return Syntax.VariableDeclarator(Syntax.Identifier("foundSyntaxNode"),argumentListOpt: null ,initializerOpt: v4290);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4294()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.BoolKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4297()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4294 = this.f4294();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4292 = this.f4292();
            List<SyntaxNodeOrToken> list4295 = new List<SyntaxNodeOrToken>
            {
            v4292
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4296 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4295);
            return Syntax.VariableDeclaration(v4294,variables: v4296);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4301()
        {
            List<SyntaxToken> list4298 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4299 = Syntax.TokenList(list4298);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4297 = this.f4297();
            return Syntax.LocalDeclarationStatement(modifiers: v4299,declaration: v4297,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4305()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4303 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4302 = Syntax.IdentifierName("ParameterType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4303,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4302);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4307()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4305 = this.f4305();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4305);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4309()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4307 = this.f4307();
            return Syntax.VariableDeclarator(Syntax.Identifier("typeSearch"),argumentListOpt: null ,initializerOpt: v4307);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4313()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4310 = Syntax.IdentifierName("Type");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4309 = this.f4309();
            List<SyntaxNodeOrToken> list4311 = new List<SyntaxNodeOrToken>
            {
            v4309
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4312 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4311);
            return Syntax.VariableDeclaration(v4310,variables: v4312);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4317()
        {
            List<SyntaxToken> list4314 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4315 = Syntax.TokenList(list4314);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4313 = this.f4313();
            return Syntax.LocalDeclarationStatement(modifiers: v4315,declaration: v4313,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4319()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("1", 1));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4321()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4319 = this.f4319();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4319);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4326()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4321 = this.f4321();
            List<SyntaxNodeOrToken> list4323 = new List<SyntaxNodeOrToken>
            {
            v4321
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4324 = Syntax.SeparatedList<ArgumentSyntax>(list4323);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4324,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4330()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4328 = Syntax.IdentifierName("newParameterName");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4327 = Syntax.IdentifierName("Substring");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4328,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4327);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4331()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4330 = this.f4330();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4326 = this.f4326();
            return Syntax.InvocationExpression(v4330,v4326);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4336()
        {
            List<SyntaxNodeOrToken> list4333 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4334 = Syntax.SeparatedList<ArgumentSyntax>(list4333);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4334,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4339()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4341()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4339 = this.f4339();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4339);
        }

        Roslyn.Compilers.CSharp.BracketedArgumentListSyntax f4346()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4341 = this.f4341();
            List<SyntaxNodeOrToken> list4343 = new List<SyntaxNodeOrToken>
            {
            v4341
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4344 = Syntax.SeparatedList<ArgumentSyntax>(list4343);
            return Syntax.BracketedArgumentList(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),arguments: v4344,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax f4348()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4347 = Syntax.IdentifierName("newParameterName");
            Roslyn.Compilers.CSharp.BracketedArgumentListSyntax v4346 = this.f4346();
            return Syntax.ElementAccessExpression(v4347,v4346);
        }

        Roslyn.Compilers.CSharp.InitializerExpressionSyntax f4353()
        {
            Roslyn.Compilers.CSharp.ElementAccessExpressionSyntax v4348 = this.f4348();
            List<SyntaxNodeOrToken> list4350 = new List<SyntaxNodeOrToken>
            {
            v4348
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v4351 = Syntax.SeparatedList<ExpressionSyntax>(list4350);
            return Syntax.InitializerExpression(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),expressions: v4351,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax f4358()
        {
            List<SyntaxNodeOrToken> list4355 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v4356 = Syntax.SeparatedList<ExpressionSyntax>(list4355);
            return Syntax.ArrayRankSpecifier(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),sizes: v4356,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4360()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.CharKeyword));
        }

        Roslyn.Compilers.CSharp.ArrayTypeSyntax f4363()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4360 = this.f4360();
            Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax v4358 = this.f4358();
            List<ArrayRankSpecifierSyntax> list4361 = new List<ArrayRankSpecifierSyntax>
            {
            v4358
            }

            ;
            SyntaxList<ArrayRankSpecifierSyntax> v4362 = Syntax.List<ArrayRankSpecifierSyntax>(list4361);
            return Syntax.ArrayType(v4360,rankSpecifiers: v4362);
        }

        Roslyn.Compilers.CSharp.ArrayCreationExpressionSyntax f4365()
        {
            Roslyn.Compilers.CSharp.ArrayTypeSyntax v4363 = this.f4363();
            Roslyn.Compilers.CSharp.InitializerExpressionSyntax v4353 = this.f4353();
            return Syntax.ArrayCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v4363,initializerOpt: v4353);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4367()
        {
            Roslyn.Compilers.CSharp.ArrayCreationExpressionSyntax v4365 = this.f4365();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4365);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4372()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4367 = this.f4367();
            List<SyntaxNodeOrToken> list4369 = new List<SyntaxNodeOrToken>
            {
            v4367
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4370 = Syntax.SeparatedList<ArgumentSyntax>(list4369);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4370,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4374()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f4376()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4374 = this.f4374();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4372 = this.f4372();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v4374,argumentListOpt: v4372,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4378()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v4376 = this.f4376();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4337 = Syntax.IdentifierName("ToUpper");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4376,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4337);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4379()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4378 = this.f4378();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4336 = this.f4336();
            return Syntax.InvocationExpression(v4378,v4336);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4381()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4379 = this.f4379();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4331 = this.f4331();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v4379,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v4331);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4384()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4382 = Syntax.IdentifierName("newParameterName");
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4381 = this.f4381();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v4382,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v4381);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4386()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4384 = this.f4384();
            return Syntax.ExpressionStatement(v4384,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4390()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4388 = Syntax.IdentifierName("parameterInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4387 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4388,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4387);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4392()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4390 = this.f4390();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4390);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4394()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4392 = this.f4392();
            return Syntax.VariableDeclarator(Syntax.Identifier("newParameterName"),argumentListOpt: null ,initializerOpt: v4392);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4396()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4399()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4396 = this.f4396();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4394 = this.f4394();
            List<SyntaxNodeOrToken> list4397 = new List<SyntaxNodeOrToken>
            {
            v4394
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4398 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4397);
            return Syntax.VariableDeclaration(v4396,variables: v4398);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4403()
        {
            List<SyntaxToken> list4400 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4401 = Syntax.TokenList(list4400);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4399 = this.f4399();
            return Syntax.LocalDeclarationStatement(modifiers: v4401,declaration: v4399,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f4408()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4403 = this.f4403();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4386 = this.f4386();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4317 = this.f4317();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4301 = this.f4301();
            Roslyn.Compilers.CSharp.WhileStatementSyntax v4286 = this.f4286();
            Roslyn.Compilers.CSharp.IfStatementSyntax v4234 = this.f4234();
            Roslyn.Compilers.CSharp.BlockSyntax v2090 = this.f2090();
            List<StatementSyntax> list4405 = new List<StatementSyntax>
            {
            v4403,v4386,v4317,v4301,v4286,v4234,v2090
            }

            ;
            SyntaxList<StatementSyntax> v4406 = Syntax.List<StatementSyntax>(list4405);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v4406,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4413()
        {
            List<SyntaxNodeOrToken> list4410 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4411 = Syntax.SeparatedList<ArgumentSyntax>(list4410);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4411,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4417()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4415 = Syntax.IdentifierName("createMethodInfo");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4414 = Syntax.IdentifierName("GetParameters");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4415,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4414);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4418()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4417 = this.f4417();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4413 = this.f4413();
            return Syntax.InvocationExpression(v4417,v4413);
        }

        Roslyn.Compilers.CSharp.ForEachStatementSyntax f4425()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4419 = Syntax.IdentifierName("ParameterInfo");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4418 = this.f4418();
            Roslyn.Compilers.CSharp.BlockSyntax v4408 = this.f4408();
            return Syntax.ForEachStatement(forEachKeyword: Syntax.Token(SyntaxKind.ForEachKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v4419,identifier: Syntax.Identifier("parameterInfo"),inKeyword: Syntax.Token(SyntaxKind.InKeyword),expression: v4418,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v4408);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4430()
        {
            List<SyntaxNodeOrToken> list4427 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4428 = Syntax.SeparatedList<ArgumentSyntax>(list4427);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4428,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f4436()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4431 = Syntax.IdentifierName("SyntaxNode");
            List<SyntaxNodeOrToken> list4433 = new List<SyntaxNodeOrToken>
            {
            v4431
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v4434 = Syntax.SeparatedList<TypeSyntax>(list4433);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v4434,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f4438()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v4436 = this.f4436();
            return Syntax.GenericName(Syntax.Identifier("List"),v4436);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f4440()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v4438 = this.f4438();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4430 = this.f4430();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v4438,argumentListOpt: v4430,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4442()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v4440 = this.f4440();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4440);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4444()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4442 = this.f4442();
            return Syntax.VariableDeclarator(Syntax.Identifier("dependentVariableDefinitions"),argumentListOpt: null ,initializerOpt: v4442);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f4450()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4445 = Syntax.IdentifierName("SyntaxNode");
            List<SyntaxNodeOrToken> list4447 = new List<SyntaxNodeOrToken>
            {
            v4445
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v4448 = Syntax.SeparatedList<TypeSyntax>(list4447);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v4448,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f4452()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v4450 = this.f4450();
            return Syntax.GenericName(Syntax.Identifier("List"),v4450);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4455()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v4452 = this.f4452();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4444 = this.f4444();
            List<SyntaxNodeOrToken> list4453 = new List<SyntaxNodeOrToken>
            {
            v4444
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4454 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4453);
            return Syntax.VariableDeclaration(v4452,variables: v4454);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4459()
        {
            List<SyntaxToken> list4456 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4457 = Syntax.TokenList(list4456);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4455 = this.f4455();
            return Syntax.LocalDeclarationStatement(modifiers: v4457,declaration: v4455,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4464()
        {
            List<SyntaxNodeOrToken> list4461 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4462 = Syntax.SeparatedList<ArgumentSyntax>(list4461);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4462,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4468()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4466 = Syntax.IdentifierName("miq");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4465 = Syntax.IdentifierName("First");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4466,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4465);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4469()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4468 = this.f4468();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4464 = this.f4464();
            return Syntax.InvocationExpression(v4468,v4464);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4471()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4469 = this.f4469();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4469);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4473()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4471 = this.f4471();
            return Syntax.VariableDeclarator(Syntax.Identifier("createMethodInfo"),argumentListOpt: null ,initializerOpt: v4471);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4477()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4474 = Syntax.IdentifierName("MethodInfo");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4473 = this.f4473();
            List<SyntaxNodeOrToken> list4475 = new List<SyntaxNodeOrToken>
            {
            v4473
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4476 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4475);
            return Syntax.VariableDeclaration(v4474,variables: v4476);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4481()
        {
            List<SyntaxToken> list4478 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4479 = Syntax.TokenList(list4478);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4477 = this.f4477();
            return Syntax.LocalDeclarationStatement(modifiers: v4479,declaration: v4477,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.SelectClauseSyntax f4484()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4482 = Syntax.IdentifierName("m");
            return Syntax.SelectClause(selectKeyword: Syntax.Token(SyntaxKind.SelectKeyword),expression: v4482);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4489()
        {
            List<SyntaxNodeOrToken> list4486 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4487 = Syntax.SeparatedList<ArgumentSyntax>(list4486);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4487,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4495()
        {
            List<SyntaxNodeOrToken> list4492 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4493 = Syntax.SeparatedList<ArgumentSyntax>(list4492);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4493,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4499()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4497 = Syntax.IdentifierName("m");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4496 = Syntax.IdentifierName("GetParameters");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4497,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4496);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4500()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4499 = this.f4499();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4495 = this.f4495();
            return Syntax.InvocationExpression(v4499,v4495);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4502()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4500 = this.f4500();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4490 = Syntax.IdentifierName("Count");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4500,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4490);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4503()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4502 = this.f4502();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4489 = this.f4489();
            return Syntax.InvocationExpression(v4502,v4489);
        }

        Roslyn.Compilers.CSharp.OrderingSyntax f4505()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4503 = this.f4503();
            return Syntax.Ordering(SyntaxKind.DescendingOrdering,v4503,ascendingOrDescendingKeywordOpt: Syntax.Token(SyntaxKind.DescendingKeyword));
        }

        Roslyn.Compilers.CSharp.OrderByClauseSyntax f4509()
        {
            Roslyn.Compilers.CSharp.OrderingSyntax v4505 = this.f4505();
            List<SyntaxNodeOrToken> list4507 = new List<SyntaxNodeOrToken>
            {
            v4505
            }

            ;
            SeparatedSyntaxList<OrderingSyntax> v4508 = Syntax.SeparatedList<OrderingSyntax>(list4507);
            return Syntax.OrderByClause(orderByKeyword: Syntax.Token(SyntaxKind.OrderByKeyword),orderings: v4508);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4514()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4512 = Syntax.IdentifierName("m");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4511 = Syntax.IdentifierName("Name");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4512,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4511);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4516()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4514 = this.f4514();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4510 = Syntax.IdentifierName("createMethodName");
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v4514,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v4510);
        }

        Roslyn.Compilers.CSharp.WhereClauseSyntax f4518()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4516 = this.f4516();
            return Syntax.WhereClause(whereKeyword: Syntax.Token(SyntaxKind.WhereKeyword),condition: v4516);
        }

        Roslyn.Compilers.CSharp.FromClauseSyntax f4523()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4519 = Syntax.IdentifierName("createMethodList");
            return Syntax.FromClause(fromKeyword: Syntax.Token(SyntaxKind.FromKeyword),typeOpt: null ,identifier: Syntax.Identifier("m"),inKeyword: Syntax.Token(SyntaxKind.InKeyword),expression: v4519);
        }

        Roslyn.Compilers.CSharp.QueryExpressionSyntax f4526()
        {
            Roslyn.Compilers.CSharp.FromClauseSyntax v4523 = this.f4523();
            Roslyn.Compilers.CSharp.WhereClauseSyntax v4518 = this.f4518();
            Roslyn.Compilers.CSharp.OrderByClauseSyntax v4509 = this.f4509();
            List<QueryClauseSyntax> list4524 = new List<QueryClauseSyntax>
            {
            v4523,v4518,v4509
            }

            ;
            SyntaxList<QueryClauseSyntax> v4525 = Syntax.List<QueryClauseSyntax>(list4524);
            Roslyn.Compilers.CSharp.SelectClauseSyntax v4484 = this.f4484();
            return Syntax.QueryExpression(clauses: v4525,selectOrGroup: v4484,continuationOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4528()
        {
            Roslyn.Compilers.CSharp.QueryExpressionSyntax v4526 = this.f4526();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4526);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4530()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4528 = this.f4528();
            return Syntax.VariableDeclarator(Syntax.Identifier("miq"),argumentListOpt: null ,initializerOpt: v4528);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4534()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4531 = Syntax.IdentifierName("var");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4530 = this.f4530();
            List<SyntaxNodeOrToken> list4532 = new List<SyntaxNodeOrToken>
            {
            v4530
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4533 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4532);
            return Syntax.VariableDeclaration(v4531,variables: v4533);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4538()
        {
            List<SyntaxToken> list4535 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4536 = Syntax.TokenList(list4535);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4534 = this.f4534();
            return Syntax.LocalDeclarationStatement(modifiers: v4536,declaration: v4534,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4541()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4539 = Syntax.IdentifierName("createMethods");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4539);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4546()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4541 = this.f4541();
            List<SyntaxNodeOrToken> list4543 = new List<SyntaxNodeOrToken>
            {
            v4541
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4544 = Syntax.SeparatedList<ArgumentSyntax>(list4543);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4544,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f4552()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4547 = Syntax.IdentifierName("MethodInfo");
            List<SyntaxNodeOrToken> list4549 = new List<SyntaxNodeOrToken>
            {
            v4547
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v4550 = Syntax.SeparatedList<TypeSyntax>(list4549);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v4550,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f4554()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v4552 = this.f4552();
            return Syntax.GenericName(Syntax.Identifier("List"),v4552);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f4556()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v4554 = this.f4554();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4546 = this.f4546();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v4554,argumentListOpt: v4546,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4558()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v4556 = this.f4556();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4556);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4560()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4558 = this.f4558();
            return Syntax.VariableDeclarator(Syntax.Identifier("createMethodList"),argumentListOpt: null ,initializerOpt: v4558);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f4566()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4561 = Syntax.IdentifierName("MethodInfo");
            List<SyntaxNodeOrToken> list4563 = new List<SyntaxNodeOrToken>
            {
            v4561
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v4564 = Syntax.SeparatedList<TypeSyntax>(list4563);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v4564,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f4568()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v4566 = this.f4566();
            return Syntax.GenericName(Syntax.Identifier("List"),v4566);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4571()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v4568 = this.f4568();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4560 = this.f4560();
            List<SyntaxNodeOrToken> list4569 = new List<SyntaxNodeOrToken>
            {
            v4560
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4570 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4569);
            return Syntax.VariableDeclaration(v4568,variables: v4570);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4575()
        {
            List<SyntaxToken> list4572 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4573 = Syntax.TokenList(list4572);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4571 = this.f4571();
            return Syntax.LocalDeclarationStatement(modifiers: v4573,declaration: v4571,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4580()
        {
            List<SyntaxNodeOrToken> list4577 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4578 = Syntax.SeparatedList<ArgumentSyntax>(list4577);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4578,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4584()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4582 = Syntax.IdentifierName("syntaxType");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4581 = Syntax.IdentifierName("GetMethods");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4582,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4581);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4585()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4584 = this.f4584();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4580 = this.f4580();
            return Syntax.InvocationExpression(v4584,v4580);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4587()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4585 = this.f4585();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4585);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4589()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4587 = this.f4587();
            return Syntax.VariableDeclarator(Syntax.Identifier("createMethods"),argumentListOpt: null ,initializerOpt: v4587);
        }

        Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax f4594()
        {
            List<SyntaxNodeOrToken> list4591 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v4592 = Syntax.SeparatedList<ExpressionSyntax>(list4591);
            return Syntax.ArrayRankSpecifier(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),sizes: v4592,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.ArrayTypeSyntax f4598()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4595 = Syntax.IdentifierName("MethodInfo");
            Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax v4594 = this.f4594();
            List<ArrayRankSpecifierSyntax> list4596 = new List<ArrayRankSpecifierSyntax>
            {
            v4594
            }

            ;
            SyntaxList<ArrayRankSpecifierSyntax> v4597 = Syntax.List<ArrayRankSpecifierSyntax>(list4596);
            return Syntax.ArrayType(v4595,rankSpecifiers: v4597);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4601()
        {
            Roslyn.Compilers.CSharp.ArrayTypeSyntax v4598 = this.f4598();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4589 = this.f4589();
            List<SyntaxNodeOrToken> list4599 = new List<SyntaxNodeOrToken>
            {
            v4589
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4600 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4599);
            return Syntax.VariableDeclaration(v4598,variables: v4600);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4605()
        {
            List<SyntaxToken> list4602 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4603 = Syntax.TokenList(list4602);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4601 = this.f4601();
            return Syntax.LocalDeclarationStatement(modifiers: v4603,declaration: v4601,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4610()
        {
            List<SyntaxNodeOrToken> list4607 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4608 = Syntax.SeparatedList<ArgumentSyntax>(list4607);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4608,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4614()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4612 = Syntax.IdentifierName("node");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4611 = Syntax.IdentifierName("GetType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4612,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4611);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4615()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4614 = this.f4614();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4610 = this.f4610();
            return Syntax.InvocationExpression(v4614,v4610);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4617()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4615 = this.f4615();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4615);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4622()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4617 = this.f4617();
            List<SyntaxNodeOrToken> list4619 = new List<SyntaxNodeOrToken>
            {
            v4617
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4620 = Syntax.SeparatedList<ArgumentSyntax>(list4619);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4620,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4624()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4623 = Syntax.IdentifierName("GetApiCreateMethod");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4622 = this.f4622();
            return Syntax.InvocationExpression(v4623,v4622);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4626()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4624 = this.f4624();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4624);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4628()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4626 = this.f4626();
            return Syntax.VariableDeclarator(Syntax.Identifier("createMethodName"),argumentListOpt: null ,initializerOpt: v4626);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4630()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4633()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4630 = this.f4630();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4628 = this.f4628();
            List<SyntaxNodeOrToken> list4631 = new List<SyntaxNodeOrToken>
            {
            v4628
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4632 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4631);
            return Syntax.VariableDeclaration(v4630,variables: v4632);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4637()
        {
            List<SyntaxToken> list4634 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4635 = Syntax.TokenList(list4634);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4633 = this.f4633();
            return Syntax.LocalDeclarationStatement(modifiers: v4635,declaration: v4633,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4642()
        {
            List<SyntaxNodeOrToken> list4639 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4640 = Syntax.SeparatedList<ArgumentSyntax>(list4639);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4640,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4646()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4644 = Syntax.IdentifierName("node");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4643 = Syntax.IdentifierName("GetType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4644,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4643);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4647()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4646 = this.f4646();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4642 = this.f4642();
            return Syntax.InvocationExpression(v4646,v4642);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4650()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4648 = Syntax.IdentifierName("type");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4647 = this.f4647();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v4648,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v4647);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4652()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4650 = this.f4650();
            return Syntax.ExpressionStatement(v4650,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4654()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4656()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4654 = this.f4654();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4654);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4658()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4656 = this.f4656();
            return Syntax.VariableDeclarator(Syntax.Identifier("friendlyName"),argumentListOpt: null ,initializerOpt: v4656);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4660()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4663()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4660 = this.f4660();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4658 = this.f4658();
            List<SyntaxNodeOrToken> list4661 = new List<SyntaxNodeOrToken>
            {
            v4658
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4662 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4661);
            return Syntax.VariableDeclaration(v4660,variables: v4662);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4667()
        {
            List<SyntaxToken> list4664 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4665 = Syntax.TokenList(list4664);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4663 = this.f4663();
            return Syntax.LocalDeclarationStatement(modifiers: v4665,declaration: v4663,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4670()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4668 = Syntax.IdentifierName("Syntax");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4668);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4675()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4670 = this.f4670();
            List<SyntaxNodeOrToken> list4672 = new List<SyntaxNodeOrToken>
            {
            v4670
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4673 = Syntax.SeparatedList<ArgumentSyntax>(list4672);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4673,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeOfExpressionSyntax f4677()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4675 = this.f4675();
            return Syntax.TypeOfExpression(keyword: Syntax.Token(SyntaxKind.TypeOfKeyword),argumentList: v4675);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4679()
        {
            Roslyn.Compilers.CSharp.TypeOfExpressionSyntax v4677 = this.f4677();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4677);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4681()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4679 = this.f4679();
            return Syntax.VariableDeclarator(Syntax.Identifier("syntaxType"),argumentListOpt: null ,initializerOpt: v4679);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4685()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4682 = Syntax.IdentifierName("Type");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4681 = this.f4681();
            List<SyntaxNodeOrToken> list4683 = new List<SyntaxNodeOrToken>
            {
            v4681
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4684 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4683);
            return Syntax.VariableDeclaration(v4682,variables: v4684);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4689()
        {
            List<SyntaxToken> list4686 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4687 = Syntax.TokenList(list4686);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4685 = this.f4685();
            return Syntax.LocalDeclarationStatement(modifiers: v4687,declaration: v4685,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4694()
        {
            List<SyntaxNodeOrToken> list4691 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4692 = Syntax.SeparatedList<ArgumentSyntax>(list4691);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4692,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f4700()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4695 = Syntax.IdentifierName("SyntaxToken");
            List<SyntaxNodeOrToken> list4697 = new List<SyntaxNodeOrToken>
            {
            v4695
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v4698 = Syntax.SeparatedList<TypeSyntax>(list4697);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v4698,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f4702()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v4700 = this.f4700();
            return Syntax.GenericName(Syntax.Identifier("List"),v4700);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f4704()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v4702 = this.f4702();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4694 = this.f4694();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v4702,argumentListOpt: v4694,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4706()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v4704 = this.f4704();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4704);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4708()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4706 = this.f4706();
            return Syntax.VariableDeclarator(Syntax.Identifier("separators"),argumentListOpt: null ,initializerOpt: v4706);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f4714()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4709 = Syntax.IdentifierName("SyntaxToken");
            List<SyntaxNodeOrToken> list4711 = new List<SyntaxNodeOrToken>
            {
            v4709
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v4712 = Syntax.SeparatedList<TypeSyntax>(list4711);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v4712,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f4716()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v4714 = this.f4714();
            return Syntax.GenericName(Syntax.Identifier("List"),v4714);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4719()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v4716 = this.f4716();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4708 = this.f4708();
            List<SyntaxNodeOrToken> list4717 = new List<SyntaxNodeOrToken>
            {
            v4708
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4718 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4717);
            return Syntax.VariableDeclaration(v4716,variables: v4718);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4723()
        {
            List<SyntaxToken> list4720 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4721 = Syntax.TokenList(list4720);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4719 = this.f4719();
            return Syntax.LocalDeclarationStatement(modifiers: v4721,declaration: v4719,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4728()
        {
            List<SyntaxNodeOrToken> list4725 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4726 = Syntax.SeparatedList<ArgumentSyntax>(list4725);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4726,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f4734()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4729 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list4731 = new List<SyntaxNodeOrToken>
            {
            v4729
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v4732 = Syntax.SeparatedList<TypeSyntax>(list4731);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v4732,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f4736()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v4734 = this.f4734();
            return Syntax.GenericName(Syntax.Identifier("List"),v4734);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f4738()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v4736 = this.f4736();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4728 = this.f4728();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v4736,argumentListOpt: v4728,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4740()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v4738 = this.f4738();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4738);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4742()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4740 = this.f4740();
            return Syntax.VariableDeclarator(Syntax.Identifier("arguments"),argumentListOpt: null ,initializerOpt: v4740);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f4748()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4743 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list4745 = new List<SyntaxNodeOrToken>
            {
            v4743
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v4746 = Syntax.SeparatedList<TypeSyntax>(list4745);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v4746,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f4750()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v4748 = this.f4748();
            return Syntax.GenericName(Syntax.Identifier("List"),v4748);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4753()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v4750 = this.f4750();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4742 = this.f4742();
            List<SyntaxNodeOrToken> list4751 = new List<SyntaxNodeOrToken>
            {
            v4742
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4752 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4751);
            return Syntax.VariableDeclaration(v4750,variables: v4752);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4757()
        {
            List<SyntaxToken> list4754 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4755 = Syntax.TokenList(list4754);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4753 = this.f4753();
            return Syntax.LocalDeclarationStatement(modifiers: v4755,declaration: v4753,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f4762()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4757 = this.f4757();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4723 = this.f4723();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4689 = this.f4689();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4667 = this.f4667();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4652 = this.f4652();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4637 = this.f4637();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4605 = this.f4605();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4575 = this.f4575();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4538 = this.f4538();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4481 = this.f4481();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4459 = this.f4459();
            Roslyn.Compilers.CSharp.ForEachStatementSyntax v4425 = this.f4425();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2052 = this.f2052();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v2030 = this.f2030();
            List<StatementSyntax> list4759 = new List<StatementSyntax>
            {
            v4757,v4723,v4689,v4667,v4652,v4637,v4605,v4575,v4538,v4481,v4459,v4425,v2052,v2030
            }

            ;
            SyntaxList<StatementSyntax> v4760 = Syntax.List<StatementSyntax>(list4759);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v4760,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f4769()
        {
            List<AttributeDeclarationSyntax> list4764 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v4765 = Syntax.List<AttributeDeclarationSyntax>(list4764);
            List<SyntaxToken> list4766 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4767 = Syntax.TokenList(list4766);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4763 = Syntax.IdentifierName("SyntaxNode");
            return Syntax.Parameter(attributes: v4765,modifiers: v4767,typeOpt: v4763,identifier: Syntax.Identifier("node"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f4776()
        {
            List<AttributeDeclarationSyntax> list4771 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v4772 = Syntax.List<AttributeDeclarationSyntax>(list4771);
            List<SyntaxToken> list4773 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4774 = Syntax.TokenList(list4773);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4770 = Syntax.IdentifierName("Type");
            return Syntax.Parameter(attributes: v4772,modifiers: v4774,typeOpt: v4770,identifier: Syntax.Identifier("type"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f4782()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v4776 = this.f4776();
            Roslyn.Compilers.CSharp.ParameterSyntax v4769 = this.f4769();
            List<SyntaxNodeOrToken> list4779 = new List<SyntaxNodeOrToken>
            {
            v4776,Syntax.Token(SyntaxKind.CommaToken),v4769
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v4780 = Syntax.SeparatedList<ParameterSyntax>(list4779);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v4780,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4784()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.VoidKeyword));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f4794()
        {
            List<AttributeDeclarationSyntax> list4785 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v4786 = Syntax.List<AttributeDeclarationSyntax>(list4785);
            List<SyntaxToken> list4788 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PrivateKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4789 = Syntax.TokenList(list4788);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4784 = this.f4784();
            Roslyn.Compilers.CSharp.ParameterListSyntax v4782 = this.f4782();
            List<TypeParameterConstraintClauseSyntax> list4791 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v4792 = Syntax.List<TypeParameterConstraintClauseSyntax>(list4791);
            Roslyn.Compilers.CSharp.BlockSyntax v4762 = this.f4762();
            return Syntax.MethodDeclaration(attributes: v4786,modifiers: v4789,returnType: v4784,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("GGSyntaxNode"),typeParameterListOpt: null ,parameterList: v4782,constraintClauses: v4792,bodyOpt: v4762,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4797()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4795 = Syntax.IdentifierName("trivia");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4795);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4802()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4797 = this.f4797();
            List<SyntaxNodeOrToken> list4799 = new List<SyntaxNodeOrToken>
            {
            v4797
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4800 = Syntax.SeparatedList<ArgumentSyntax>(list4799);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4800,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.BaseExpressionSyntax f4805()
        {
            return Syntax.BaseExpression(token: Syntax.Token(SyntaxKind.BaseKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4807()
        {
            Roslyn.Compilers.CSharp.BaseExpressionSyntax v4805 = this.f4805();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4803 = Syntax.IdentifierName("VisitTrivia");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4805,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4803);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4808()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4807 = this.f4807();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4802 = this.f4802();
            return Syntax.InvocationExpression(v4807,v4802);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4810()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4808 = this.f4808();
            return Syntax.ExpressionStatement(v4808,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f4815()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4810 = this.f4810();
            List<StatementSyntax> list4812 = new List<StatementSyntax>
            {
            v4810
            }

            ;
            SyntaxList<StatementSyntax> v4813 = Syntax.List<StatementSyntax>(list4812);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v4813,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f4822()
        {
            List<AttributeDeclarationSyntax> list4817 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v4818 = Syntax.List<AttributeDeclarationSyntax>(list4817);
            List<SyntaxToken> list4819 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4820 = Syntax.TokenList(list4819);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4816 = Syntax.IdentifierName("SyntaxTrivia");
            return Syntax.Parameter(attributes: v4818,modifiers: v4820,typeOpt: v4816,identifier: Syntax.Identifier("trivia"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f4827()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v4822 = this.f4822();
            List<SyntaxNodeOrToken> list4824 = new List<SyntaxNodeOrToken>
            {
            v4822
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v4825 = Syntax.SeparatedList<ParameterSyntax>(list4824);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v4825,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4829()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.VoidKeyword));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f4840()
        {
            List<AttributeDeclarationSyntax> list4830 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v4831 = Syntax.List<AttributeDeclarationSyntax>(list4830);
            List<SyntaxToken> list4834 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.ProtectedKeyword),Syntax.Token(SyntaxKind.OverrideKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4835 = Syntax.TokenList(list4834);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4829 = this.f4829();
            Roslyn.Compilers.CSharp.ParameterListSyntax v4827 = this.f4827();
            List<TypeParameterConstraintClauseSyntax> list4837 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v4838 = Syntax.List<TypeParameterConstraintClauseSyntax>(list4837);
            Roslyn.Compilers.CSharp.BlockSyntax v4815 = this.f4815();
            return Syntax.MethodDeclaration(attributes: v4831,modifiers: v4835,returnType: v4829,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("VisitTrivia"),typeParameterListOpt: null ,parameterList: v4827,constraintClauses: v4838,bodyOpt: v4815,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4843()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4841 = Syntax.IdentifierName("node");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4841);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4848()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4843 = this.f4843();
            List<SyntaxNodeOrToken> list4845 = new List<SyntaxNodeOrToken>
            {
            v4843
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4846 = Syntax.SeparatedList<ArgumentSyntax>(list4845);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4846,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.BaseExpressionSyntax f4851()
        {
            return Syntax.BaseExpression(token: Syntax.Token(SyntaxKind.BaseKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4853()
        {
            Roslyn.Compilers.CSharp.BaseExpressionSyntax v4851 = this.f4851();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4849 = Syntax.IdentifierName("VisitIdentiferNameSyntax");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4851,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4849);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4854()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4853 = this.f4853();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4848 = this.f4848();
            return Syntax.InvocationExpression(v4853,v4848);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4856()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4854 = this.f4854();
            return Syntax.ExpressionStatement(v4854,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4858()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4860()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4858 = this.f4858();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4858);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4863()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4861 = Syntax.IdentifierName("separators");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4861);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4866()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4864 = Syntax.IdentifierName("arguments");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4864);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4868()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"IdentifierName\"", "\"IdentifierName\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4870()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4868 = this.f4868();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4868);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4873()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4871 = Syntax.IdentifierName("type");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4871);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4882()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4873 = this.f4873();
            Roslyn.Compilers.CSharp.ArgumentSyntax v4870 = this.f4870();
            Roslyn.Compilers.CSharp.ArgumentSyntax v4866 = this.f4866();
            Roslyn.Compilers.CSharp.ArgumentSyntax v4863 = this.f4863();
            Roslyn.Compilers.CSharp.ArgumentSyntax v4860 = this.f4860();
            List<SyntaxNodeOrToken> list4879 = new List<SyntaxNodeOrToken>
            {
            v4873,Syntax.Token(SyntaxKind.CommaToken),v4870,Syntax.Token(SyntaxKind.CommaToken),v4866,Syntax.Token(SyntaxKind.CommaToken),v4863,Syntax.Token(SyntaxKind.CommaToken),v4860
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4880 = Syntax.SeparatedList<ArgumentSyntax>(list4879);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4880,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4884()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4883 = Syntax.IdentifierName("CreateSyntaxNode");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4882 = this.f4882();
            return Syntax.InvocationExpression(v4883,v4882);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4886()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4884 = this.f4884();
            return Syntax.ExpressionStatement(v4884,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4889()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4887 = Syntax.IdentifierName("exp");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4887);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4894()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4889 = this.f4889();
            List<SyntaxNodeOrToken> list4891 = new List<SyntaxNodeOrToken>
            {
            v4889
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4892 = Syntax.SeparatedList<ArgumentSyntax>(list4891);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4892,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4896()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4895 = Syntax.IdentifierName("CreateArgument");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4894 = this.f4894();
            return Syntax.InvocationExpression(v4895,v4894);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4898()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4896 = this.f4896();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4896);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4903()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4898 = this.f4898();
            List<SyntaxNodeOrToken> list4900 = new List<SyntaxNodeOrToken>
            {
            v4898
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4901 = Syntax.SeparatedList<ArgumentSyntax>(list4900);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4901,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4907()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4905 = Syntax.IdentifierName("arguments");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4904 = Syntax.IdentifierName("Add");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4905,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4904);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4908()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4907 = this.f4907();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4903 = this.f4903();
            return Syntax.InvocationExpression(v4907,v4903);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f4910()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4908 = this.f4908();
            return Syntax.ExpressionStatement(v4908,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4913()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4911 = Syntax.IdentifierName("value");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4911);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4915()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f4918()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4920()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4918 = this.f4918();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4916 = Syntax.IdentifierName("value");
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v4918,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v4916);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f4922()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4920 = this.f4920();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v4915 = this.f4915();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v4920,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v4915);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4924()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v4922 = this.f4922();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4922);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4930()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4924 = this.f4924();
            Roslyn.Compilers.CSharp.ArgumentSyntax v4913 = this.f4913();
            List<SyntaxNodeOrToken> list4927 = new List<SyntaxNodeOrToken>
            {
            v4924,Syntax.Token(SyntaxKind.CommaToken),v4913
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4928 = Syntax.SeparatedList<ArgumentSyntax>(list4927);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4928,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4934()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4932 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4931 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4932,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4931);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4935()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4934 = this.f4934();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4930 = this.f4930();
            return Syntax.InvocationExpression(v4934,v4930);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4937()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4935 = this.f4935();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4935);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4941()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4939 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4938 = Syntax.IdentifierName("StringLiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4939,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4938);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f4943()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4941 = this.f4941();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v4941);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4949()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v4943 = this.f4943();
            Roslyn.Compilers.CSharp.ArgumentSyntax v4937 = this.f4937();
            List<SyntaxNodeOrToken> list4946 = new List<SyntaxNodeOrToken>
            {
            v4943,Syntax.Token(SyntaxKind.CommaToken),v4937
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4947 = Syntax.SeparatedList<ArgumentSyntax>(list4946);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4947,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4953()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4951 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4950 = Syntax.IdentifierName("LiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4951,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4950);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f4954()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4953 = this.f4953();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4949 = this.f4949();
            return Syntax.InvocationExpression(v4953,v4949);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4956()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v4954 = this.f4954();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4954);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4958()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4956 = this.f4956();
            return Syntax.VariableDeclarator(Syntax.Identifier("exp"),argumentListOpt: null ,initializerOpt: v4956);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4962()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4959 = Syntax.IdentifierName("ExpressionSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4958 = this.f4958();
            List<SyntaxNodeOrToken> list4960 = new List<SyntaxNodeOrToken>
            {
            v4958
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4961 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4960);
            return Syntax.VariableDeclaration(v4959,variables: v4961);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4966()
        {
            List<SyntaxToken> list4963 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4964 = Syntax.TokenList(list4963);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4962 = this.f4962();
            return Syntax.LocalDeclarationStatement(modifiers: v4964,declaration: v4962,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f4972()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4969 = Syntax.IdentifierName("NameSyntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4968 = Syntax.IdentifierName("node");
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v4969,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v4968);
        }

        Roslyn.Compilers.CSharp.ParenthesizedExpressionSyntax f4975()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v4972 = this.f4972();
            return Syntax.ParenthesizedExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),expression: v4972,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f4977()
        {
            Roslyn.Compilers.CSharp.ParenthesizedExpressionSyntax v4975 = this.f4975();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4967 = Syntax.IdentifierName("PlainName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v4975,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v4967);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f4979()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v4977 = this.f4977();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v4977);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f4981()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v4979 = this.f4979();
            return Syntax.VariableDeclarator(Syntax.Identifier("value"),argumentListOpt: null ,initializerOpt: v4979);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f4983()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f4986()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v4983 = this.f4983();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v4981 = this.f4981();
            List<SyntaxNodeOrToken> list4984 = new List<SyntaxNodeOrToken>
            {
            v4981
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v4985 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list4984);
            return Syntax.VariableDeclaration(v4983,variables: v4985);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f4990()
        {
            List<SyntaxToken> list4987 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v4988 = Syntax.TokenList(list4987);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v4986 = this.f4986();
            return Syntax.LocalDeclarationStatement(modifiers: v4988,declaration: v4986,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f4995()
        {
            List<SyntaxNodeOrToken> list4992 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v4993 = Syntax.SeparatedList<ArgumentSyntax>(list4992);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v4993,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f5001()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v4996 = Syntax.IdentifierName("SyntaxToken");
            List<SyntaxNodeOrToken> list4998 = new List<SyntaxNodeOrToken>
            {
            v4996
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v4999 = Syntax.SeparatedList<TypeSyntax>(list4998);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v4999,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f5003()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v5001 = this.f5001();
            return Syntax.GenericName(Syntax.Identifier("List"),v5001);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f5005()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v5003 = this.f5003();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v4995 = this.f4995();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v5003,argumentListOpt: v4995,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f5007()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v5005 = this.f5005();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v5005);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f5009()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v5007 = this.f5007();
            return Syntax.VariableDeclarator(Syntax.Identifier("separators"),argumentListOpt: null ,initializerOpt: v5007);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f5015()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5010 = Syntax.IdentifierName("SyntaxToken");
            List<SyntaxNodeOrToken> list5012 = new List<SyntaxNodeOrToken>
            {
            v5010
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v5013 = Syntax.SeparatedList<TypeSyntax>(list5012);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v5013,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f5017()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v5015 = this.f5015();
            return Syntax.GenericName(Syntax.Identifier("List"),v5015);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f5020()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v5017 = this.f5017();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v5009 = this.f5009();
            List<SyntaxNodeOrToken> list5018 = new List<SyntaxNodeOrToken>
            {
            v5009
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v5019 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list5018);
            return Syntax.VariableDeclaration(v5017,variables: v5019);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f5024()
        {
            List<SyntaxToken> list5021 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v5022 = Syntax.TokenList(list5021);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v5020 = this.f5020();
            return Syntax.LocalDeclarationStatement(modifiers: v5022,declaration: v5020,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5029()
        {
            List<SyntaxNodeOrToken> list5026 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5027 = Syntax.SeparatedList<ArgumentSyntax>(list5026);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5027,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f5035()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5030 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list5032 = new List<SyntaxNodeOrToken>
            {
            v5030
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v5033 = Syntax.SeparatedList<TypeSyntax>(list5032);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v5033,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f5037()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v5035 = this.f5035();
            return Syntax.GenericName(Syntax.Identifier("List"),v5035);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f5039()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v5037 = this.f5037();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5029 = this.f5029();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v5037,argumentListOpt: v5029,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f5041()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v5039 = this.f5039();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v5039);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f5043()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v5041 = this.f5041();
            return Syntax.VariableDeclarator(Syntax.Identifier("arguments"),argumentListOpt: null ,initializerOpt: v5041);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f5049()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5044 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list5046 = new List<SyntaxNodeOrToken>
            {
            v5044
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v5047 = Syntax.SeparatedList<TypeSyntax>(list5046);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v5047,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f5051()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v5049 = this.f5049();
            return Syntax.GenericName(Syntax.Identifier("List"),v5049);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f5054()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v5051 = this.f5051();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v5043 = this.f5043();
            List<SyntaxNodeOrToken> list5052 = new List<SyntaxNodeOrToken>
            {
            v5043
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v5053 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list5052);
            return Syntax.VariableDeclaration(v5051,variables: v5053);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f5058()
        {
            List<SyntaxToken> list5055 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v5056 = Syntax.TokenList(list5055);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v5054 = this.f5054();
            return Syntax.LocalDeclarationStatement(modifiers: v5056,declaration: v5054,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5063()
        {
            List<SyntaxNodeOrToken> list5060 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5061 = Syntax.SeparatedList<ArgumentSyntax>(list5060);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5061,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5067()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5065 = Syntax.IdentifierName("node");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5064 = Syntax.IdentifierName("GetType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5065,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5064);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5068()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5067 = this.f5067();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5063 = this.f5063();
            return Syntax.InvocationExpression(v5067,v5063);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f5070()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5068 = this.f5068();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v5068);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f5072()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v5070 = this.f5070();
            return Syntax.VariableDeclarator(Syntax.Identifier("type"),argumentListOpt: null ,initializerOpt: v5070);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f5076()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5073 = Syntax.IdentifierName("Type");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v5072 = this.f5072();
            List<SyntaxNodeOrToken> list5074 = new List<SyntaxNodeOrToken>
            {
            v5072
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v5075 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list5074);
            return Syntax.VariableDeclaration(v5073,variables: v5075);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f5080()
        {
            List<SyntaxToken> list5077 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v5078 = Syntax.TokenList(list5077);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v5076 = this.f5076();
            return Syntax.LocalDeclarationStatement(modifiers: v5078,declaration: v5076,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f5085()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v5080 = this.f5080();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v5058 = this.f5058();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v5024 = this.f5024();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4990 = this.f4990();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v4966 = this.f4966();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4910 = this.f4910();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4886 = this.f4886();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v4856 = this.f4856();
            List<StatementSyntax> list5082 = new List<StatementSyntax>
            {
            v5080,v5058,v5024,v4990,v4966,v4910,v4886,v4856
            }

            ;
            SyntaxList<StatementSyntax> v5083 = Syntax.List<StatementSyntax>(list5082);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v5083,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f5092()
        {
            List<AttributeDeclarationSyntax> list5087 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v5088 = Syntax.List<AttributeDeclarationSyntax>(list5087);
            List<SyntaxToken> list5089 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v5090 = Syntax.TokenList(list5089);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5086 = Syntax.IdentifierName("IdentifierNameSyntax");
            return Syntax.Parameter(attributes: v5088,modifiers: v5090,typeOpt: v5086,identifier: Syntax.Identifier("node"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f5097()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v5092 = this.f5092();
            List<SyntaxNodeOrToken> list5094 = new List<SyntaxNodeOrToken>
            {
            v5092
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v5095 = Syntax.SeparatedList<ParameterSyntax>(list5094);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v5095,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f5099()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.VoidKeyword));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f5110()
        {
            List<AttributeDeclarationSyntax> list5100 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v5101 = Syntax.List<AttributeDeclarationSyntax>(list5100);
            List<SyntaxToken> list5104 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.ProtectedKeyword),Syntax.Token(SyntaxKind.OverrideKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v5105 = Syntax.TokenList(list5104);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v5099 = this.f5099();
            Roslyn.Compilers.CSharp.ParameterListSyntax v5097 = this.f5097();
            List<TypeParameterConstraintClauseSyntax> list5107 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v5108 = Syntax.List<TypeParameterConstraintClauseSyntax>(list5107);
            Roslyn.Compilers.CSharp.BlockSyntax v5085 = this.f5085();
            return Syntax.MethodDeclaration(attributes: v5101,modifiers: v5105,returnType: v5099,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("VisitIdentiferNameSyntax"),typeParameterListOpt: null ,parameterList: v5097,constraintClauses: v5108,bodyOpt: v5085,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5112()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\\\\\"\"", "\"\\\\\\\"\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5114()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5112 = this.f5112();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5112);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5116()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5118()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5116 = this.f5116();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5116);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5124()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5118 = this.f5118();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5114 = this.f5114();
            List<SyntaxNodeOrToken> list5121 = new List<SyntaxNodeOrToken>
            {
            v5118,Syntax.Token(SyntaxKind.CommaToken),v5114
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5122 = Syntax.SeparatedList<ArgumentSyntax>(list5121);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5122,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5127()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\\\\\\\"", "\"\\\\\\\\\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5129()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5127 = this.f5127();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5127);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5131()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\\\"", "\"\\\\\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5133()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5131 = this.f5131();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5131);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5139()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5133 = this.f5133();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5129 = this.f5129();
            List<SyntaxNodeOrToken> list5136 = new List<SyntaxNodeOrToken>
            {
            v5133,Syntax.Token(SyntaxKind.CommaToken),v5129
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5137 = Syntax.SeparatedList<ArgumentSyntax>(list5136);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5137,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5143()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5141 = Syntax.IdentifierName("input");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5140 = Syntax.IdentifierName("Replace");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5141,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5140);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5144()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5143 = this.f5143();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5139 = this.f5139();
            return Syntax.InvocationExpression(v5143,v5139);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5146()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5144 = this.f5144();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5125 = Syntax.IdentifierName("Replace");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5144,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5125);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5147()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5146 = this.f5146();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5124 = this.f5124();
            return Syntax.InvocationExpression(v5146,v5124);
        }

        Roslyn.Compilers.CSharp.ReturnStatementSyntax f5150()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5147 = this.f5147();
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: v5147,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f5155()
        {
            Roslyn.Compilers.CSharp.ReturnStatementSyntax v5150 = this.f5150();
            List<StatementSyntax> list5152 = new List<StatementSyntax>
            {
            v5150
            }

            ;
            SyntaxList<StatementSyntax> v5153 = Syntax.List<StatementSyntax>(list5152);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v5153,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f5157()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f5163()
        {
            List<AttributeDeclarationSyntax> list5158 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v5159 = Syntax.List<AttributeDeclarationSyntax>(list5158);
            List<SyntaxToken> list5160 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v5161 = Syntax.TokenList(list5160);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v5157 = this.f5157();
            return Syntax.Parameter(attributes: v5159,modifiers: v5161,typeOpt: v5157,identifier: Syntax.Identifier("input"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f5168()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v5163 = this.f5163();
            List<SyntaxNodeOrToken> list5165 = new List<SyntaxNodeOrToken>
            {
            v5163
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v5166 = Syntax.SeparatedList<ParameterSyntax>(list5165);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v5166,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f5170()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f5181()
        {
            List<AttributeDeclarationSyntax> list5171 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v5172 = Syntax.List<AttributeDeclarationSyntax>(list5171);
            List<SyntaxToken> list5175 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PrivateKeyword),Syntax.Token(SyntaxKind.StaticKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v5176 = Syntax.TokenList(list5175);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v5170 = this.f5170();
            Roslyn.Compilers.CSharp.ParameterListSyntax v5168 = this.f5168();
            List<TypeParameterConstraintClauseSyntax> list5178 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v5179 = Syntax.List<TypeParameterConstraintClauseSyntax>(list5178);
            Roslyn.Compilers.CSharp.BlockSyntax v5155 = this.f5155();
            return Syntax.MethodDeclaration(attributes: v5172,modifiers: v5176,returnType: v5170,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("EscapeString"),typeParameterListOpt: null ,parameterList: v5168,constraintClauses: v5179,bodyOpt: v5155,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ReturnStatementSyntax f5185()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5182 = Syntax.IdentifierName("instantiateExpression");
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: v5182,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5188()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5186 = Syntax.IdentifierName("literalToken");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5186);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5191()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5189 = Syntax.IdentifierName("literalExpressionSyntaxKind");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5189);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5197()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5191 = this.f5191();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5188 = this.f5188();
            List<SyntaxNodeOrToken> list5194 = new List<SyntaxNodeOrToken>
            {
            v5191,Syntax.Token(SyntaxKind.CommaToken),v5188
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5195 = Syntax.SeparatedList<ArgumentSyntax>(list5194);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5195,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5201()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5199 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5198 = Syntax.IdentifierName("LiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5199,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5198);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5202()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5201 = this.f5201();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5197 = this.f5197();
            return Syntax.InvocationExpression(v5201,v5197);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5205()
        {
            return Syntax.NameColon(Syntax.Identifier("expression"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5207()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5205 = this.f5205();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5202 = this.f5202();
            return Syntax.Argument(nameColonOpt: v5205,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5202);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5212()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5207 = this.f5207();
            List<SyntaxNodeOrToken> list5209 = new List<SyntaxNodeOrToken>
            {
            v5207
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5210 = Syntax.SeparatedList<ArgumentSyntax>(list5209);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5210,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5216()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5214 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5213 = Syntax.IdentifierName("Argument");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5214,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5213);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5217()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5216 = this.f5216();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5212 = this.f5212();
            return Syntax.InvocationExpression(v5216,v5212);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5219()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5217 = this.f5217();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5217);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5223()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5221 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5220 = Syntax.IdentifierName("CommaToken");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5221,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5220);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5225()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5223 = this.f5223();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5223);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5230()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5225 = this.f5225();
            List<SyntaxNodeOrToken> list5227 = new List<SyntaxNodeOrToken>
            {
            v5225
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5228 = Syntax.SeparatedList<ArgumentSyntax>(list5227);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5228,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5234()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5232 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5231 = Syntax.IdentifierName("Token");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5232,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5231);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5235()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5234 = this.f5234();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5230 = this.f5230();
            return Syntax.InvocationExpression(v5234,v5230);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5237()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5235 = this.f5235();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5235);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5240()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5238 = Syntax.IdentifierName("valueText");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5238);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5243()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5241 = Syntax.IdentifierName("valueText");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5241);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5249()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5243 = this.f5243();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5240 = this.f5240();
            List<SyntaxNodeOrToken> list5246 = new List<SyntaxNodeOrToken>
            {
            v5243,Syntax.Token(SyntaxKind.CommaToken),v5240
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5247 = Syntax.SeparatedList<ArgumentSyntax>(list5246);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5247,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5253()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5251 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5250 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5251,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5250);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5254()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5253 = this.f5253();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5249 = this.f5249();
            return Syntax.InvocationExpression(v5253,v5249);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5256()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5254 = this.f5254();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5254);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5260()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5258 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5257 = Syntax.IdentifierName("StringLiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5258,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5257);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5262()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5260 = this.f5260();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5260);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5268()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5262 = this.f5262();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5256 = this.f5256();
            List<SyntaxNodeOrToken> list5265 = new List<SyntaxNodeOrToken>
            {
            v5262,Syntax.Token(SyntaxKind.CommaToken),v5256
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5266 = Syntax.SeparatedList<ArgumentSyntax>(list5265);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5266,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5272()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5270 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5269 = Syntax.IdentifierName("LiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5270,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5269);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5273()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5272 = this.f5272();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5268 = this.f5268();
            return Syntax.InvocationExpression(v5272,v5268);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5276()
        {
            return Syntax.NameColon(Syntax.Identifier("expression"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5278()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5276 = this.f5276();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5273 = this.f5273();
            return Syntax.Argument(nameColonOpt: v5276,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5273);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5283()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5278 = this.f5278();
            List<SyntaxNodeOrToken> list5280 = new List<SyntaxNodeOrToken>
            {
            v5278
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5281 = Syntax.SeparatedList<ArgumentSyntax>(list5280);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5281,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5287()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5285 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5284 = Syntax.IdentifierName("Argument");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5285,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5284);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5288()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5287 = this.f5287();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5283 = this.f5283();
            return Syntax.InvocationExpression(v5287,v5283);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5290()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5288 = this.f5288();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5288);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5297()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5290 = this.f5290();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5237 = this.f5237();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5219 = this.f5219();
            List<SyntaxNodeOrToken> list5294 = new List<SyntaxNodeOrToken>
            {
            v5290,Syntax.Token(SyntaxKind.CommaToken),v5237,Syntax.Token(SyntaxKind.CommaToken),v5219
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5295 = Syntax.SeparatedList<ArgumentSyntax>(list5294);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5295,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f5303()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5298 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list5300 = new List<SyntaxNodeOrToken>
            {
            v5298
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v5301 = Syntax.SeparatedList<TypeSyntax>(list5300);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v5301,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f5305()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v5303 = this.f5303();
            return Syntax.GenericName(Syntax.Identifier("SeparatedList"),v5303);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5308()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5306 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.GenericNameSyntax v5305 = this.f5305();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5306,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5305);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5309()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5308 = this.f5308();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5297 = this.f5297();
            return Syntax.InvocationExpression(v5308,v5297);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5312()
        {
            return Syntax.NameColon(Syntax.Identifier("arguments"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5314()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5312 = this.f5312();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5309 = this.f5309();
            return Syntax.Argument(nameColonOpt: v5312,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5309);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5319()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5314 = this.f5314();
            List<SyntaxNodeOrToken> list5316 = new List<SyntaxNodeOrToken>
            {
            v5314
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5317 = Syntax.SeparatedList<ArgumentSyntax>(list5316);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5317,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5323()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5321 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5320 = Syntax.IdentifierName("ArgumentList");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5321,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5320);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5324()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5323 = this.f5323();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5319 = this.f5319();
            return Syntax.InvocationExpression(v5323,v5319);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5326()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5324 = this.f5324();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5324);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5328()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Literal\"", "\"Literal\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5330()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5328 = this.f5328();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5328);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5335()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5330 = this.f5330();
            List<SyntaxNodeOrToken> list5332 = new List<SyntaxNodeOrToken>
            {
            v5330
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5333 = Syntax.SeparatedList<ArgumentSyntax>(list5332);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5333,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5339()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5337 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5336 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5337,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5336);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5340()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5339 = this.f5339();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5335 = this.f5335();
            return Syntax.InvocationExpression(v5339,v5335);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5343()
        {
            return Syntax.NameColon(Syntax.Identifier("name"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5345()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5343 = this.f5343();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5340 = this.f5340();
            return Syntax.Argument(nameColonOpt: v5343,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5340);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5347()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Syntax\"", "\"Syntax\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5349()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5347 = this.f5347();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5347);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5354()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5349 = this.f5349();
            List<SyntaxNodeOrToken> list5351 = new List<SyntaxNodeOrToken>
            {
            v5349
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5352 = Syntax.SeparatedList<ArgumentSyntax>(list5351);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5352,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5358()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5356 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5355 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5356,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5355);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5359()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5358 = this.f5358();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5354 = this.f5354();
            return Syntax.InvocationExpression(v5358,v5354);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5361()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5359 = this.f5359();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5359);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5365()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5363 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5362 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5363,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5362);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5367()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5365 = this.f5365();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5365);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5374()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5367 = this.f5367();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5361 = this.f5361();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5345 = this.f5345();
            List<SyntaxNodeOrToken> list5371 = new List<SyntaxNodeOrToken>
            {
            v5367,Syntax.Token(SyntaxKind.CommaToken),v5361,Syntax.Token(SyntaxKind.CommaToken),v5345
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5372 = Syntax.SeparatedList<ArgumentSyntax>(list5371);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5372,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5378()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5376 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5375 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5376,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5375);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5379()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5378 = this.f5378();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5374 = this.f5374();
            return Syntax.InvocationExpression(v5378,v5374);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5381()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5379 = this.f5379();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5379);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5387()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5381 = this.f5381();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5326 = this.f5326();
            List<SyntaxNodeOrToken> list5384 = new List<SyntaxNodeOrToken>
            {
            v5381,Syntax.Token(SyntaxKind.CommaToken),v5326
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5385 = Syntax.SeparatedList<ArgumentSyntax>(list5384);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5385,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5391()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5389 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5388 = Syntax.IdentifierName("InvocationExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5389,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5388);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5392()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5391 = this.f5391();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5387 = this.f5387();
            return Syntax.InvocationExpression(v5391,v5387);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5395()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5393 = Syntax.IdentifierName("instantiateExpression");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5392 = this.f5392();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v5393,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v5392);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f5397()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5395 = this.f5395();
            return Syntax.ExpressionStatement(v5395,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f5402()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v5397 = this.f5397();
            List<StatementSyntax> list5399 = new List<StatementSyntax>
            {
            v5397
            }

            ;
            SyntaxList<StatementSyntax> v5400 = Syntax.List<StatementSyntax>(list5399);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v5400,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f5404()
        {
            Roslyn.Compilers.CSharp.BlockSyntax v5402 = this.f5402();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v5402);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5409()
        {
            List<SyntaxNodeOrToken> list5406 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5407 = Syntax.SeparatedList<ArgumentSyntax>(list5406);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5407,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5414()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5412 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5411 = Syntax.IdentifierName("Kind");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5412,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5411);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5416()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5414 = this.f5414();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5410 = Syntax.IdentifierName("ToString");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5414,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5410);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5417()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5416 = this.f5416();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5409 = this.f5409();
            return Syntax.InvocationExpression(v5416,v5409);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5419()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5417 = this.f5417();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5417);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5424()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5419 = this.f5419();
            List<SyntaxNodeOrToken> list5421 = new List<SyntaxNodeOrToken>
            {
            v5419
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5422 = Syntax.SeparatedList<ArgumentSyntax>(list5421);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5422,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5428()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5426 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5425 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5426,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5425);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5429()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5428 = this.f5428();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5424 = this.f5424();
            return Syntax.InvocationExpression(v5428,v5424);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5432()
        {
            return Syntax.NameColon(Syntax.Identifier("name"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5434()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5432 = this.f5432();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5429 = this.f5429();
            return Syntax.Argument(nameColonOpt: v5432,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5429);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5436()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"SyntaxKind\"", "\"SyntaxKind\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5438()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5436 = this.f5436();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5436);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5443()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5438 = this.f5438();
            List<SyntaxNodeOrToken> list5440 = new List<SyntaxNodeOrToken>
            {
            v5438
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5441 = Syntax.SeparatedList<ArgumentSyntax>(list5440);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5441,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5447()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5445 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5444 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5445,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5444);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5448()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5447 = this.f5447();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5443 = this.f5443();
            return Syntax.InvocationExpression(v5447,v5443);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5450()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5448 = this.f5448();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5448);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5454()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5452 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5451 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5452,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5451);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5456()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5454 = this.f5454();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5454);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5463()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5456 = this.f5456();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5450 = this.f5450();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5434 = this.f5434();
            List<SyntaxNodeOrToken> list5460 = new List<SyntaxNodeOrToken>
            {
            v5456,Syntax.Token(SyntaxKind.CommaToken),v5450,Syntax.Token(SyntaxKind.CommaToken),v5434
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5461 = Syntax.SeparatedList<ArgumentSyntax>(list5460);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5461,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5467()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5465 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5464 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5465,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5464);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5468()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5467 = this.f5467();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5463 = this.f5463();
            return Syntax.InvocationExpression(v5467,v5463);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5471()
        {
            return Syntax.NameColon(Syntax.Identifier("expression"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5473()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5471 = this.f5471();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5468 = this.f5468();
            return Syntax.Argument(nameColonOpt: v5471,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5468);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5478()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5473 = this.f5473();
            List<SyntaxNodeOrToken> list5475 = new List<SyntaxNodeOrToken>
            {
            v5473
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5476 = Syntax.SeparatedList<ArgumentSyntax>(list5475);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5476,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5482()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5480 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5479 = Syntax.IdentifierName("Argument");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5480,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5479);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5483()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5482 = this.f5482();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5478 = this.f5478();
            return Syntax.InvocationExpression(v5482,v5478);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5485()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5483 = this.f5483();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5483);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5490()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5485 = this.f5485();
            List<SyntaxNodeOrToken> list5487 = new List<SyntaxNodeOrToken>
            {
            v5485
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5488 = Syntax.SeparatedList<ArgumentSyntax>(list5487);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5488,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f5496()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5491 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list5493 = new List<SyntaxNodeOrToken>
            {
            v5491
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v5494 = Syntax.SeparatedList<TypeSyntax>(list5493);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v5494,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f5498()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v5496 = this.f5496();
            return Syntax.GenericName(Syntax.Identifier("SeparatedList"),v5496);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5501()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5499 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.GenericNameSyntax v5498 = this.f5498();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5499,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5498);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5502()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5501 = this.f5501();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5490 = this.f5490();
            return Syntax.InvocationExpression(v5501,v5490);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5505()
        {
            return Syntax.NameColon(Syntax.Identifier("arguments"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5507()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5505 = this.f5505();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5502 = this.f5502();
            return Syntax.Argument(nameColonOpt: v5505,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5502);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5512()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5507 = this.f5507();
            List<SyntaxNodeOrToken> list5509 = new List<SyntaxNodeOrToken>
            {
            v5507
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5510 = Syntax.SeparatedList<ArgumentSyntax>(list5509);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5510,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5516()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5514 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5513 = Syntax.IdentifierName("ArgumentList");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5514,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5513);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5517()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5516 = this.f5516();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5512 = this.f5512();
            return Syntax.InvocationExpression(v5516,v5512);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5519()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5517 = this.f5517();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5517);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5521()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Token\"", "\"Token\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5523()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5521 = this.f5521();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5521);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5528()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5523 = this.f5523();
            List<SyntaxNodeOrToken> list5525 = new List<SyntaxNodeOrToken>
            {
            v5523
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5526 = Syntax.SeparatedList<ArgumentSyntax>(list5525);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5526,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5532()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5530 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5529 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5530,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5529);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5533()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5532 = this.f5532();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5528 = this.f5528();
            return Syntax.InvocationExpression(v5532,v5528);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5536()
        {
            return Syntax.NameColon(Syntax.Identifier("name"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5538()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5536 = this.f5536();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5533 = this.f5533();
            return Syntax.Argument(nameColonOpt: v5536,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5533);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5540()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Syntax\"", "\"Syntax\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5542()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5540 = this.f5540();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5540);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5547()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5542 = this.f5542();
            List<SyntaxNodeOrToken> list5544 = new List<SyntaxNodeOrToken>
            {
            v5542
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5545 = Syntax.SeparatedList<ArgumentSyntax>(list5544);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5545,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5551()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5549 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5548 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5549,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5548);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5552()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5551 = this.f5551();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5547 = this.f5547();
            return Syntax.InvocationExpression(v5551,v5547);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5554()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5552 = this.f5552();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5552);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5558()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5556 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5555 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5556,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5555);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5560()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5558 = this.f5558();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5558);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5567()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5560 = this.f5560();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5554 = this.f5554();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5538 = this.f5538();
            List<SyntaxNodeOrToken> list5564 = new List<SyntaxNodeOrToken>
            {
            v5560,Syntax.Token(SyntaxKind.CommaToken),v5554,Syntax.Token(SyntaxKind.CommaToken),v5538
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5565 = Syntax.SeparatedList<ArgumentSyntax>(list5564);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5565,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5571()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5569 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5568 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5569,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5568);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5572()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5571 = this.f5571();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5567 = this.f5567();
            return Syntax.InvocationExpression(v5571,v5567);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5574()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5572 = this.f5572();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5572);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5580()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5574 = this.f5574();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5519 = this.f5519();
            List<SyntaxNodeOrToken> list5577 = new List<SyntaxNodeOrToken>
            {
            v5574,Syntax.Token(SyntaxKind.CommaToken),v5519
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5578 = Syntax.SeparatedList<ArgumentSyntax>(list5577);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5578,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5584()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5582 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5581 = Syntax.IdentifierName("InvocationExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5582,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5581);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5585()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5584 = this.f5584();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5580 = this.f5580();
            return Syntax.InvocationExpression(v5584,v5580);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5588()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5586 = Syntax.IdentifierName("instantiateExpression");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5585 = this.f5585();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v5586,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v5585);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f5590()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5588 = this.f5588();
            return Syntax.ExpressionStatement(v5588,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f5595()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v5590 = this.f5590();
            List<StatementSyntax> list5592 = new List<StatementSyntax>
            {
            v5590
            }

            ;
            SyntaxList<StatementSyntax> v5593 = Syntax.List<StatementSyntax>(list5592);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v5593,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.PrefixUnaryExpressionSyntax f5598()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5596 = Syntax.IdentifierName("createLiteral");
            return Syntax.PrefixUnaryExpression(SyntaxKind.LogicalNotExpression,operatorToken: Syntax.Token(SyntaxKind.ExclamationToken),operand: v5596);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f5602()
        {
            Roslyn.Compilers.CSharp.PrefixUnaryExpressionSyntax v5598 = this.f5598();
            Roslyn.Compilers.CSharp.BlockSyntax v5595 = this.f5595();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v5404 = this.f5404();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v5598,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v5595,elseOpt: v5404);
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f5604()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v5602 = this.f5602();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v5602);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5606()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5610()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5608 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5607 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5608,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5607);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f5612()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f5615()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v5612 = this.f5612();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5610 = this.f5610();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v5612,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v5610);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5617()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v5615 = this.f5615();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5615);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5622()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5617 = this.f5617();
            List<SyntaxNodeOrToken> list5619 = new List<SyntaxNodeOrToken>
            {
            v5617
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5620 = Syntax.SeparatedList<ArgumentSyntax>(list5619);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5620,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5624()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5623 = Syntax.IdentifierName("EscapeString");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5622 = this.f5622();
            return Syntax.InvocationExpression(v5623,v5622);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5626()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5628()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5626 = this.f5626();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5624 = this.f5624();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v5626,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v5624);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5630()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5628 = this.f5628();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5606 = this.f5606();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v5628,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v5606);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5632()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5630 = this.f5630();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5630);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5634()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5638()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5636 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5635 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5636,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5635);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f5640()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f5643()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v5640 = this.f5640();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5638 = this.f5638();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v5640,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v5638);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5645()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v5643 = this.f5643();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5643);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5650()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5645 = this.f5645();
            List<SyntaxNodeOrToken> list5647 = new List<SyntaxNodeOrToken>
            {
            v5645
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5648 = Syntax.SeparatedList<ArgumentSyntax>(list5647);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5648,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5652()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5651 = Syntax.IdentifierName("EscapeString");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5650 = this.f5650();
            return Syntax.InvocationExpression(v5651,v5650);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5654()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5656()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5654 = this.f5654();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5652 = this.f5652();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v5654,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v5652);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5658()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5656 = this.f5656();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5634 = this.f5634();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v5656,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v5634);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5660()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5658 = this.f5658();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5658);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5666()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5660 = this.f5660();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5632 = this.f5632();
            List<SyntaxNodeOrToken> list5663 = new List<SyntaxNodeOrToken>
            {
            v5660,Syntax.Token(SyntaxKind.CommaToken),v5632
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5664 = Syntax.SeparatedList<ArgumentSyntax>(list5663);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5664,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5670()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5668 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5667 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5668,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5667);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5671()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5670 = this.f5670();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5666 = this.f5666();
            return Syntax.InvocationExpression(v5670,v5666);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5673()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5671 = this.f5671();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5671);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5677()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5675 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5674 = Syntax.IdentifierName("StringLiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5675,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5674);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5679()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5677 = this.f5677();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5677);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5685()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5679 = this.f5679();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5673 = this.f5673();
            List<SyntaxNodeOrToken> list5682 = new List<SyntaxNodeOrToken>
            {
            v5679,Syntax.Token(SyntaxKind.CommaToken),v5673
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5683 = Syntax.SeparatedList<ArgumentSyntax>(list5682);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5683,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5689()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5687 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5686 = Syntax.IdentifierName("LiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5687,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5686);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5690()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5689 = this.f5689();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5685 = this.f5685();
            return Syntax.InvocationExpression(v5689,v5685);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5693()
        {
            return Syntax.NameColon(Syntax.Identifier("expression"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5695()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5693 = this.f5693();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5690 = this.f5690();
            return Syntax.Argument(nameColonOpt: v5693,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5690);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5700()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5695 = this.f5695();
            List<SyntaxNodeOrToken> list5697 = new List<SyntaxNodeOrToken>
            {
            v5695
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5698 = Syntax.SeparatedList<ArgumentSyntax>(list5697);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5698,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5704()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5702 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5701 = Syntax.IdentifierName("Argument");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5702,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5701);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5705()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5704 = this.f5704();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5700 = this.f5700();
            return Syntax.InvocationExpression(v5704,v5700);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5707()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5705 = this.f5705();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5705);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5712()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5707 = this.f5707();
            List<SyntaxNodeOrToken> list5709 = new List<SyntaxNodeOrToken>
            {
            v5707
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5710 = Syntax.SeparatedList<ArgumentSyntax>(list5709);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5710,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f5718()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5713 = Syntax.IdentifierName("ArgumentSyntax");
            List<SyntaxNodeOrToken> list5715 = new List<SyntaxNodeOrToken>
            {
            v5713
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v5716 = Syntax.SeparatedList<TypeSyntax>(list5715);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v5716,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f5720()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v5718 = this.f5718();
            return Syntax.GenericName(Syntax.Identifier("SeparatedList"),v5718);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5723()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5721 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.GenericNameSyntax v5720 = this.f5720();
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5721,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5720);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5724()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5723 = this.f5723();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5712 = this.f5712();
            return Syntax.InvocationExpression(v5723,v5712);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5727()
        {
            return Syntax.NameColon(Syntax.Identifier("arguments"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5729()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5727 = this.f5727();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5724 = this.f5724();
            return Syntax.Argument(nameColonOpt: v5727,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5724);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5734()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5729 = this.f5729();
            List<SyntaxNodeOrToken> list5731 = new List<SyntaxNodeOrToken>
            {
            v5729
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5732 = Syntax.SeparatedList<ArgumentSyntax>(list5731);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5732,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5738()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5736 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5735 = Syntax.IdentifierName("ArgumentList");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5736,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5735);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5739()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5738 = this.f5738();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5734 = this.f5734();
            return Syntax.InvocationExpression(v5738,v5734);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5741()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5739 = this.f5739();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5739);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5743()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Identifier\"", "\"Identifier\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5745()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5743 = this.f5743();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5743);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5750()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5745 = this.f5745();
            List<SyntaxNodeOrToken> list5747 = new List<SyntaxNodeOrToken>
            {
            v5745
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5748 = Syntax.SeparatedList<ArgumentSyntax>(list5747);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5748,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5754()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5752 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5751 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5752,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5751);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5755()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5754 = this.f5754();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5750 = this.f5750();
            return Syntax.InvocationExpression(v5754,v5750);
        }

        Roslyn.Compilers.CSharp.NameColonSyntax f5758()
        {
            return Syntax.NameColon(Syntax.Identifier("name"),colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5760()
        {
            Roslyn.Compilers.CSharp.NameColonSyntax v5758 = this.f5758();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5755 = this.f5755();
            return Syntax.Argument(nameColonOpt: v5758,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5755);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5762()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Syntax\"", "\"Syntax\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5764()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5762 = this.f5762();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5762);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5769()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5764 = this.f5764();
            List<SyntaxNodeOrToken> list5766 = new List<SyntaxNodeOrToken>
            {
            v5764
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5767 = Syntax.SeparatedList<ArgumentSyntax>(list5766);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5767,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5773()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5771 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5770 = Syntax.IdentifierName("IdentifierName");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5771,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5770);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5774()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5773 = this.f5773();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5769 = this.f5769();
            return Syntax.InvocationExpression(v5773,v5769);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5776()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5774 = this.f5774();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5774);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5780()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5778 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5777 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5778,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5777);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5782()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5780 = this.f5780();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5780);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5789()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5782 = this.f5782();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5776 = this.f5776();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5760 = this.f5760();
            List<SyntaxNodeOrToken> list5786 = new List<SyntaxNodeOrToken>
            {
            v5782,Syntax.Token(SyntaxKind.CommaToken),v5776,Syntax.Token(SyntaxKind.CommaToken),v5760
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5787 = Syntax.SeparatedList<ArgumentSyntax>(list5786);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5787,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5793()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5791 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5790 = Syntax.IdentifierName("MemberAccessExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5791,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5790);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5794()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5793 = this.f5793();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5789 = this.f5789();
            return Syntax.InvocationExpression(v5793,v5789);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5796()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5794 = this.f5794();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5794);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5802()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5796 = this.f5796();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5741 = this.f5741();
            List<SyntaxNodeOrToken> list5799 = new List<SyntaxNodeOrToken>
            {
            v5796,Syntax.Token(SyntaxKind.CommaToken),v5741
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5800 = Syntax.SeparatedList<ArgumentSyntax>(list5799);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5800,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5806()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5804 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5803 = Syntax.IdentifierName("InvocationExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5804,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5803);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5807()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5806 = this.f5806();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5802 = this.f5802();
            return Syntax.InvocationExpression(v5806,v5802);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5810()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5808 = Syntax.IdentifierName("instantiateExpression");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5807 = this.f5807();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v5808,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v5807);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f5812()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5810 = this.f5810();
            return Syntax.ExpressionStatement(v5810,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f5817()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v5812 = this.f5812();
            List<StatementSyntax> list5814 = new List<StatementSyntax>
            {
            v5812
            }

            ;
            SyntaxList<StatementSyntax> v5815 = Syntax.List<StatementSyntax>(list5814);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v5815,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f5822()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5818 = Syntax.IdentifierName("createIdentifier");
            Roslyn.Compilers.CSharp.BlockSyntax v5817 = this.f5817();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v5604 = this.f5604();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v5818,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v5817,elseOpt: v5604);
        }

        Roslyn.Compilers.CSharp.BreakStatementSyntax f5825()
        {
            return Syntax.BreakStatement(breakKeyword: Syntax.Token(SyntaxKind.BreakKeyword),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5827()
        {
            return Syntax.LiteralExpression(SyntaxKind.FalseLiteralExpression,token: Syntax.Token(SyntaxKind.FalseKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5830()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5828 = Syntax.IdentifierName("createLiteral");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5827 = this.f5827();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v5828,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v5827);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f5832()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5830 = this.f5830();
            return Syntax.ExpressionStatement(v5830,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.SwitchLabelSyntax f5835()
        {
            return Syntax.SwitchLabel(SyntaxKind.DefaultSwitchLabel,caseOrDefaultKeyword: Syntax.Token(SyntaxKind.DefaultKeyword),valueOpt: null ,colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.SwitchSectionSyntax f5840()
        {
            Roslyn.Compilers.CSharp.SwitchLabelSyntax v5835 = this.f5835();
            List<SwitchLabelSyntax> list5836 = new List<SwitchLabelSyntax>
            {
            v5835
            }

            ;
            SyntaxList<SwitchLabelSyntax> v5837 = Syntax.List<SwitchLabelSyntax>(list5836);
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v5832 = this.f5832();
            Roslyn.Compilers.CSharp.BreakStatementSyntax v5825 = this.f5825();
            List<StatementSyntax> list5838 = new List<StatementSyntax>
            {
            v5832,v5825
            }

            ;
            SyntaxList<StatementSyntax> v5839 = Syntax.List<StatementSyntax>(list5838);
            return Syntax.SwitchSection(labels: v5837,statements: v5839);
        }

        Roslyn.Compilers.CSharp.BreakStatementSyntax f5843()
        {
            return Syntax.BreakStatement(breakKeyword: Syntax.Token(SyntaxKind.BreakKeyword),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5845()
        {
            return Syntax.LiteralExpression(SyntaxKind.TrueLiteralExpression,token: Syntax.Token(SyntaxKind.TrueKeyword));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5848()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5846 = Syntax.IdentifierName("createIdentifier");
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5845 = this.f5845();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v5846,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v5845);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f5850()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5848 = this.f5848();
            return Syntax.ExpressionStatement(v5848,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5854()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5852 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5851 = Syntax.IdentifierName("IdentifierToken");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5852,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5851);
        }

        Roslyn.Compilers.CSharp.SwitchLabelSyntax f5857()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5854 = this.f5854();
            return Syntax.SwitchLabel(SyntaxKind.CaseSwitchLabel,caseOrDefaultKeyword: Syntax.Token(SyntaxKind.CaseKeyword),valueOpt: v5854,colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.SwitchSectionSyntax f5862()
        {
            Roslyn.Compilers.CSharp.SwitchLabelSyntax v5857 = this.f5857();
            List<SwitchLabelSyntax> list5858 = new List<SwitchLabelSyntax>
            {
            v5857
            }

            ;
            SyntaxList<SwitchLabelSyntax> v5859 = Syntax.List<SwitchLabelSyntax>(list5858);
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v5850 = this.f5850();
            Roslyn.Compilers.CSharp.BreakStatementSyntax v5843 = this.f5843();
            List<StatementSyntax> list5860 = new List<StatementSyntax>
            {
            v5850,v5843
            }

            ;
            SyntaxList<StatementSyntax> v5861 = Syntax.List<StatementSyntax>(list5860);
            return Syntax.SwitchSection(labels: v5859,statements: v5861);
        }

        Roslyn.Compilers.CSharp.BreakStatementSyntax f5865()
        {
            return Syntax.BreakStatement(breakKeyword: Syntax.Token(SyntaxKind.BreakKeyword),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5868()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5866 = Syntax.IdentifierName("valueText");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5866);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5871()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5869 = Syntax.IdentifierName("valueText");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5869);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5877()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5871 = this.f5871();
            Roslyn.Compilers.CSharp.ArgumentSyntax v5868 = this.f5868();
            List<SyntaxNodeOrToken> list5874 = new List<SyntaxNodeOrToken>
            {
            v5871,Syntax.Token(SyntaxKind.CommaToken),v5868
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5875 = Syntax.SeparatedList<ArgumentSyntax>(list5874);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5875,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5881()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5879 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5878 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5879,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5878);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5882()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5881 = this.f5881();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5877 = this.f5877();
            return Syntax.InvocationExpression(v5881,v5877);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5885()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5883 = Syntax.IdentifierName("literalToken");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5882 = this.f5882();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v5883,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v5882);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f5887()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5885 = this.f5885();
            return Syntax.ExpressionStatement(v5885,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5889()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5891()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5895()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5893 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5892 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5893,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5892);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f5897()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f5900()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v5897 = this.f5897();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5895 = this.f5895();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v5897,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v5895);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5902()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v5900 = this.f5900();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5900);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5907()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5902 = this.f5902();
            List<SyntaxNodeOrToken> list5904 = new List<SyntaxNodeOrToken>
            {
            v5902
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5905 = Syntax.SeparatedList<ArgumentSyntax>(list5904);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5905,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5909()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5908 = Syntax.IdentifierName("EscapeString");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5907 = this.f5907();
            return Syntax.InvocationExpression(v5908,v5907);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5911()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5913()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5911 = this.f5911();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5909 = this.f5909();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v5911,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v5909);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5915()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5913 = this.f5913();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5891 = this.f5891();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v5913,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v5891);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5917()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5915 = this.f5915();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5915);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5922()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5917 = this.f5917();
            List<SyntaxNodeOrToken> list5919 = new List<SyntaxNodeOrToken>
            {
            v5917
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5920 = Syntax.SeparatedList<ArgumentSyntax>(list5919);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5920,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f5924()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5923 = Syntax.IdentifierName("EscapeString");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5922 = this.f5922();
            return Syntax.InvocationExpression(v5923,v5922);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5926()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5928()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5926 = this.f5926();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v5924 = this.f5924();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v5926,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v5924);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5930()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5928 = this.f5928();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5889 = this.f5889();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v5928,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v5889);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5933()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5931 = Syntax.IdentifierName("valueText");
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5930 = this.f5930();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v5931,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v5930);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f5935()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5933 = this.f5933();
            return Syntax.ExpressionStatement(v5933,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5939()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5937 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5936 = Syntax.IdentifierName("StringLiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5937,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5936);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f5942()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5940 = Syntax.IdentifierName("literalExpressionSyntaxKind");
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5939 = this.f5939();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v5940,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v5939);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f5944()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v5942 = this.f5942();
            return Syntax.ExpressionStatement(v5942,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5948()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5946 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5945 = Syntax.IdentifierName("StringLiteralToken");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5946,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5945);
        }

        Roslyn.Compilers.CSharp.SwitchLabelSyntax f5951()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5948 = this.f5948();
            return Syntax.SwitchLabel(SyntaxKind.CaseSwitchLabel,caseOrDefaultKeyword: Syntax.Token(SyntaxKind.CaseKeyword),valueOpt: v5948,colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.SwitchSectionSyntax f5956()
        {
            Roslyn.Compilers.CSharp.SwitchLabelSyntax v5951 = this.f5951();
            List<SwitchLabelSyntax> list5952 = new List<SwitchLabelSyntax>
            {
            v5951
            }

            ;
            SyntaxList<SwitchLabelSyntax> v5953 = Syntax.List<SwitchLabelSyntax>(list5952);
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v5944 = this.f5944();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v5935 = this.f5935();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v5887 = this.f5887();
            Roslyn.Compilers.CSharp.BreakStatementSyntax v5865 = this.f5865();
            List<StatementSyntax> list5954 = new List<StatementSyntax>
            {
            v5944,v5935,v5887,v5865
            }

            ;
            SyntaxList<StatementSyntax> v5955 = Syntax.List<StatementSyntax>(list5954);
            return Syntax.SwitchSection(labels: v5953,statements: v5955);
        }

        Roslyn.Compilers.CSharp.BreakStatementSyntax f5959()
        {
            return Syntax.BreakStatement(breakKeyword: Syntax.Token(SyntaxKind.BreakKeyword),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5961()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"Unknown NumericLiteralToken.\"", "\"Unknown NumericLiteralToken.\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5963()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5961 = this.f5961();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5961);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5968()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5963 = this.f5963();
            List<SyntaxNodeOrToken> list5965 = new List<SyntaxNodeOrToken>
            {
            v5963
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5966 = Syntax.SeparatedList<ArgumentSyntax>(list5965);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5966,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f5971()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5969 = Syntax.IdentifierName("ApplicationException");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5968 = this.f5968();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v5969,argumentListOpt: v5968,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.ThrowStatementSyntax f5974()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v5971 = this.f5971();
            return Syntax.ThrowStatement(throwKeyword: Syntax.Token(SyntaxKind.ThrowKeyword),expressionOpt: v5971,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f5979()
        {
            Roslyn.Compilers.CSharp.ThrowStatementSyntax v5974 = this.f5974();
            List<StatementSyntax> list5976 = new List<StatementSyntax>
            {
            v5974
            }

            ;
            SyntaxList<StatementSyntax> v5977 = Syntax.List<StatementSyntax>(list5976);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v5977,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f5981()
        {
            Roslyn.Compilers.CSharp.BlockSyntax v5979 = this.f5979();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v5979);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f5983()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f5987()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5985 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v5984 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v5985,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v5984);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f5989()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f5992()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v5989 = this.f5989();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v5987 = this.f5987();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v5989,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v5987);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f5994()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v5992 = this.f5992();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v5992);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f5999()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v5994 = this.f5994();
            List<SyntaxNodeOrToken> list5996 = new List<SyntaxNodeOrToken>
            {
            v5994
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v5997 = Syntax.SeparatedList<ArgumentSyntax>(list5996);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v5997,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6001()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6000 = Syntax.IdentifierName("EscapeString");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v5999 = this.f5999();
            return Syntax.InvocationExpression(v6000,v5999);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6003()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6005()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6003 = this.f6003();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6001 = this.f6001();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6003,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6001);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6007()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6005 = this.f6005();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v5983 = this.f5983();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6005,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v5983);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6010()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6008 = Syntax.IdentifierName("valueText");
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6007 = this.f6007();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6008,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6007);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6012()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6010 = this.f6010();
            return Syntax.ExpressionStatement(v6010,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6016()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6014 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6013 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6014,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6013);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6018()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.LongKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f6021()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6018 = this.f6018();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6016 = this.f6016();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v6018,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v6016);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6023()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v6021 = this.f6021();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6021);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6027()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6025 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6024 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6025,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6024);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6029()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6027 = this.f6027();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6027);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6035()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6029 = this.f6029();
            Roslyn.Compilers.CSharp.ArgumentSyntax v6023 = this.f6023();
            List<SyntaxNodeOrToken> list6032 = new List<SyntaxNodeOrToken>
            {
            v6029,Syntax.Token(SyntaxKind.CommaToken),v6023
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6033 = Syntax.SeparatedList<ArgumentSyntax>(list6032);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6033,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6039()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6037 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6036 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6037,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6036);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6040()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6039 = this.f6039();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6035 = this.f6035();
            return Syntax.InvocationExpression(v6039,v6035);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6043()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6041 = Syntax.IdentifierName("literalToken");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6040 = this.f6040();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6041,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6040);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6045()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6043 = this.f6043();
            return Syntax.ExpressionStatement(v6043,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6050()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6045 = this.f6045();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6012 = this.f6012();
            List<StatementSyntax> list6047 = new List<StatementSyntax>
            {
            v6045,v6012
            }

            ;
            SyntaxList<StatementSyntax> v6048 = Syntax.List<StatementSyntax>(list6047);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6048,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6052()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.LongKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6056()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6054 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6053 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6054,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6053);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6058()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6056 = this.f6056();
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6052 = this.f6052();
            return Syntax.BinaryExpression(SyntaxKind.IsExpression,v6056,operatorToken: Syntax.Token(SyntaxKind.IsKeyword),right: v6052);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f6062()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6058 = this.f6058();
            Roslyn.Compilers.CSharp.BlockSyntax v6050 = this.f6050();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v5981 = this.f5981();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v6058,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v6050,elseOpt: v5981);
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f6064()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v6062 = this.f6062();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v6062);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6066()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6070()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6068 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6067 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6068,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6067);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6072()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f6075()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6072 = this.f6072();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6070 = this.f6070();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v6072,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v6070);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6077()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v6075 = this.f6075();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6075);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6082()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6077 = this.f6077();
            List<SyntaxNodeOrToken> list6079 = new List<SyntaxNodeOrToken>
            {
            v6077
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6080 = Syntax.SeparatedList<ArgumentSyntax>(list6079);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6080,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6084()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6083 = Syntax.IdentifierName("EscapeString");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6082 = this.f6082();
            return Syntax.InvocationExpression(v6083,v6082);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6086()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6088()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6086 = this.f6086();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6084 = this.f6084();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6086,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6084);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6090()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6088 = this.f6088();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6066 = this.f6066();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6088,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6066);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6093()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6091 = Syntax.IdentifierName("valueText");
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6090 = this.f6090();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6091,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6090);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6095()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6093 = this.f6093();
            return Syntax.ExpressionStatement(v6093,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6099()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6097 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6096 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6097,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6096);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6101()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.FloatKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f6104()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6101 = this.f6101();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6099 = this.f6099();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v6101,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v6099);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6106()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v6104 = this.f6104();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6104);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6110()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6108 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6107 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6108,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6107);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6112()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6110 = this.f6110();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6110);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6118()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6112 = this.f6112();
            Roslyn.Compilers.CSharp.ArgumentSyntax v6106 = this.f6106();
            List<SyntaxNodeOrToken> list6115 = new List<SyntaxNodeOrToken>
            {
            v6112,Syntax.Token(SyntaxKind.CommaToken),v6106
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6116 = Syntax.SeparatedList<ArgumentSyntax>(list6115);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6116,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6122()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6120 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6119 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6120,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6119);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6123()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6122 = this.f6122();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6118 = this.f6118();
            return Syntax.InvocationExpression(v6122,v6118);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6126()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6124 = Syntax.IdentifierName("literalToken");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6123 = this.f6123();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6124,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6123);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6128()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6126 = this.f6126();
            return Syntax.ExpressionStatement(v6126,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6133()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6128 = this.f6128();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6095 = this.f6095();
            List<StatementSyntax> list6130 = new List<StatementSyntax>
            {
            v6128,v6095
            }

            ;
            SyntaxList<StatementSyntax> v6131 = Syntax.List<StatementSyntax>(list6130);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6131,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6135()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.FloatKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6139()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6137 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6136 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6137,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6136);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6141()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6139 = this.f6139();
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6135 = this.f6135();
            return Syntax.BinaryExpression(SyntaxKind.IsExpression,v6139,operatorToken: Syntax.Token(SyntaxKind.IsKeyword),right: v6135);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f6145()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6141 = this.f6141();
            Roslyn.Compilers.CSharp.BlockSyntax v6133 = this.f6133();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v6064 = this.f6064();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v6141,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v6133,elseOpt: v6064);
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f6147()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v6145 = this.f6145();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v6145);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6149()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6153()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6151 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6150 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6151,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6150);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6155()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f6158()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6155 = this.f6155();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6153 = this.f6153();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v6155,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v6153);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6160()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v6158 = this.f6158();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6158);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6165()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6160 = this.f6160();
            List<SyntaxNodeOrToken> list6162 = new List<SyntaxNodeOrToken>
            {
            v6160
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6163 = Syntax.SeparatedList<ArgumentSyntax>(list6162);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6163,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6167()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6166 = Syntax.IdentifierName("EscapeString");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6165 = this.f6165();
            return Syntax.InvocationExpression(v6166,v6165);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6169()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6171()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6169 = this.f6169();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6167 = this.f6167();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6169,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6167);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6173()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6171 = this.f6171();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6149 = this.f6149();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6171,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6149);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6176()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6174 = Syntax.IdentifierName("valueText");
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6173 = this.f6173();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6174,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6173);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6178()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6176 = this.f6176();
            return Syntax.ExpressionStatement(v6176,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6182()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6180 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6179 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6180,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6179);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6184()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.DecimalKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f6187()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6184 = this.f6184();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6182 = this.f6182();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v6184,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v6182);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6189()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v6187 = this.f6187();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6187);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6193()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6191 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6190 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6191,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6190);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6195()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6193 = this.f6193();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6193);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6201()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6195 = this.f6195();
            Roslyn.Compilers.CSharp.ArgumentSyntax v6189 = this.f6189();
            List<SyntaxNodeOrToken> list6198 = new List<SyntaxNodeOrToken>
            {
            v6195,Syntax.Token(SyntaxKind.CommaToken),v6189
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6199 = Syntax.SeparatedList<ArgumentSyntax>(list6198);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6199,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6205()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6203 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6202 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6203,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6202);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6206()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6205 = this.f6205();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6201 = this.f6201();
            return Syntax.InvocationExpression(v6205,v6201);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6209()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6207 = Syntax.IdentifierName("literalToken");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6206 = this.f6206();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6207,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6206);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6211()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6209 = this.f6209();
            return Syntax.ExpressionStatement(v6209,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6216()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6211 = this.f6211();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6178 = this.f6178();
            List<StatementSyntax> list6213 = new List<StatementSyntax>
            {
            v6211,v6178
            }

            ;
            SyntaxList<StatementSyntax> v6214 = Syntax.List<StatementSyntax>(list6213);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6214,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6218()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.DecimalKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6222()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6220 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6219 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6220,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6219);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6224()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6222 = this.f6222();
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6218 = this.f6218();
            return Syntax.BinaryExpression(SyntaxKind.IsExpression,v6222,operatorToken: Syntax.Token(SyntaxKind.IsKeyword),right: v6218);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f6228()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6224 = this.f6224();
            Roslyn.Compilers.CSharp.BlockSyntax v6216 = this.f6216();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v6147 = this.f6147();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v6224,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v6216,elseOpt: v6147);
        }

        Roslyn.Compilers.CSharp.ElseClauseSyntax f6230()
        {
            Roslyn.Compilers.CSharp.IfStatementSyntax v6228 = this.f6228();
            return Syntax.ElseClause(elseKeyword: Syntax.Token(SyntaxKind.ElseKeyword),statement: v6228);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6232()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6236()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6234 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6233 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6234,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6233);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6238()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f6241()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6238 = this.f6238();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6236 = this.f6236();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v6238,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v6236);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6243()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v6241 = this.f6241();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6241);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6248()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6243 = this.f6243();
            List<SyntaxNodeOrToken> list6245 = new List<SyntaxNodeOrToken>
            {
            v6243
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6246 = Syntax.SeparatedList<ArgumentSyntax>(list6245);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6246,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6250()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6249 = Syntax.IdentifierName("EscapeString");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6248 = this.f6248();
            return Syntax.InvocationExpression(v6249,v6248);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6252()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6254()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6252 = this.f6252();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6250 = this.f6250();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6252,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6250);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6256()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6254 = this.f6254();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6232 = this.f6232();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6254,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6232);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6259()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6257 = Syntax.IdentifierName("valueText");
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6256 = this.f6256();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6257,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6256);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6261()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6259 = this.f6259();
            return Syntax.ExpressionStatement(v6259,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6265()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6263 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6262 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6263,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6262);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6267()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.IntKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f6270()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6267 = this.f6267();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6265 = this.f6265();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v6267,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v6265);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6272()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v6270 = this.f6270();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6270);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6276()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6274 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6273 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6274,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6273);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6278()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6276 = this.f6276();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6276);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6284()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6278 = this.f6278();
            Roslyn.Compilers.CSharp.ArgumentSyntax v6272 = this.f6272();
            List<SyntaxNodeOrToken> list6281 = new List<SyntaxNodeOrToken>
            {
            v6278,Syntax.Token(SyntaxKind.CommaToken),v6272
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6282 = Syntax.SeparatedList<ArgumentSyntax>(list6281);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6282,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6288()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6286 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6285 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6286,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6285);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6289()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6288 = this.f6288();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6284 = this.f6284();
            return Syntax.InvocationExpression(v6288,v6284);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6292()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6290 = Syntax.IdentifierName("literalToken");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6289 = this.f6289();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6290,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6289);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6294()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6292 = this.f6292();
            return Syntax.ExpressionStatement(v6292,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6299()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6294 = this.f6294();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6261 = this.f6261();
            List<StatementSyntax> list6296 = new List<StatementSyntax>
            {
            v6294,v6261
            }

            ;
            SyntaxList<StatementSyntax> v6297 = Syntax.List<StatementSyntax>(list6296);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6297,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6301()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.IntKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6305()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6303 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6302 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6303,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6302);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6307()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6305 = this.f6305();
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6301 = this.f6301();
            return Syntax.BinaryExpression(SyntaxKind.IsExpression,v6305,operatorToken: Syntax.Token(SyntaxKind.IsKeyword),right: v6301);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f6311()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6307 = this.f6307();
            Roslyn.Compilers.CSharp.BlockSyntax v6299 = this.f6299();
            Roslyn.Compilers.CSharp.ElseClauseSyntax v6230 = this.f6230();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v6307,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v6299,elseOpt: v6230);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6315()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6313 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6312 = Syntax.IdentifierName("NumericLiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6313,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6312);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6318()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6316 = Syntax.IdentifierName("literalExpressionSyntaxKind");
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6315 = this.f6315();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6316,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6315);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6320()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6318 = this.f6318();
            return Syntax.ExpressionStatement(v6318,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6324()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6322 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6321 = Syntax.IdentifierName("NumericLiteralToken");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6322,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6321);
        }

        Roslyn.Compilers.CSharp.SwitchLabelSyntax f6327()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6324 = this.f6324();
            return Syntax.SwitchLabel(SyntaxKind.CaseSwitchLabel,caseOrDefaultKeyword: Syntax.Token(SyntaxKind.CaseKeyword),valueOpt: v6324,colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.SwitchSectionSyntax f6332()
        {
            Roslyn.Compilers.CSharp.SwitchLabelSyntax v6327 = this.f6327();
            List<SwitchLabelSyntax> list6328 = new List<SwitchLabelSyntax>
            {
            v6327
            }

            ;
            SyntaxList<SwitchLabelSyntax> v6329 = Syntax.List<SwitchLabelSyntax>(list6328);
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6320 = this.f6320();
            Roslyn.Compilers.CSharp.IfStatementSyntax v6311 = this.f6311();
            Roslyn.Compilers.CSharp.BreakStatementSyntax v5959 = this.f5959();
            List<StatementSyntax> list6330 = new List<StatementSyntax>
            {
            v6320,v6311,v5959
            }

            ;
            SyntaxList<StatementSyntax> v6331 = Syntax.List<StatementSyntax>(list6330);
            return Syntax.SwitchSection(labels: v6329,statements: v6331);
        }

        Roslyn.Compilers.CSharp.BreakStatementSyntax f6335()
        {
            return Syntax.BreakStatement(breakKeyword: Syntax.Token(SyntaxKind.BreakKeyword),semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6337()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6339()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6343()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6341 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6340 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6341,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6340);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6345()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f6348()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6345 = this.f6345();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6343 = this.f6343();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v6345,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v6343);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6350()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6352()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6350 = this.f6350();
            Roslyn.Compilers.CSharp.CastExpressionSyntax v6348 = this.f6348();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6350,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6348);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6354()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6352 = this.f6352();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6339 = this.f6339();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6352,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6339);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6356()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6354 = this.f6354();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6354);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6361()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6356 = this.f6356();
            List<SyntaxNodeOrToken> list6358 = new List<SyntaxNodeOrToken>
            {
            v6356
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6359 = Syntax.SeparatedList<ArgumentSyntax>(list6358);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6359,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6363()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6362 = Syntax.IdentifierName("EscapeString");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6361 = this.f6361();
            return Syntax.InvocationExpression(v6362,v6361);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6365()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"\\\"\"", "\"\\\"\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6367()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6365 = this.f6365();
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6363 = this.f6363();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6365,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6363);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6369()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6367 = this.f6367();
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6337 = this.f6337();
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6367,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6337);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6372()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6370 = Syntax.IdentifierName("valueText");
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6369 = this.f6369();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6370,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6369);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6374()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6372 = this.f6372();
            return Syntax.ExpressionStatement(v6372,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6378()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6376 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6375 = Syntax.IdentifierName("Value");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6376,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6375);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6380()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.CharKeyword));
        }

        Roslyn.Compilers.CSharp.CastExpressionSyntax f6383()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6380 = this.f6380();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6378 = this.f6378();
            return Syntax.CastExpression(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),type: v6380,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),expression: v6378);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6385()
        {
            Roslyn.Compilers.CSharp.CastExpressionSyntax v6383 = this.f6383();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6383);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6389()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6387 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6386 = Syntax.IdentifierName("ValueText");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6387,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6386);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6391()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6389 = this.f6389();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6389);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6397()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6391 = this.f6391();
            Roslyn.Compilers.CSharp.ArgumentSyntax v6385 = this.f6385();
            List<SyntaxNodeOrToken> list6394 = new List<SyntaxNodeOrToken>
            {
            v6391,Syntax.Token(SyntaxKind.CommaToken),v6385
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6395 = Syntax.SeparatedList<ArgumentSyntax>(list6394);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6395,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6401()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6399 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6398 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6399,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6398);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6402()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6401 = this.f6401();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6397 = this.f6397();
            return Syntax.InvocationExpression(v6401,v6397);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6405()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6403 = Syntax.IdentifierName("literalToken");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6402 = this.f6402();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6403,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6402);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6407()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6405 = this.f6405();
            return Syntax.ExpressionStatement(v6405,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6411()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6409 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6408 = Syntax.IdentifierName("CharacterLiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6409,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6408);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6414()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6412 = Syntax.IdentifierName("literalExpressionSyntaxKind");
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6411 = this.f6411();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6412,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6411);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6416()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6414 = this.f6414();
            return Syntax.ExpressionStatement(v6414,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6420()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6418 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6417 = Syntax.IdentifierName("CharacterLiteralToken");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6418,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6417);
        }

        Roslyn.Compilers.CSharp.SwitchLabelSyntax f6423()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6420 = this.f6420();
            return Syntax.SwitchLabel(SyntaxKind.CaseSwitchLabel,caseOrDefaultKeyword: Syntax.Token(SyntaxKind.CaseKeyword),valueOpt: v6420,colonToken: Syntax.Token(SyntaxKind.ColonToken));
        }

        Roslyn.Compilers.CSharp.SwitchSectionSyntax f6428()
        {
            Roslyn.Compilers.CSharp.SwitchLabelSyntax v6423 = this.f6423();
            List<SwitchLabelSyntax> list6424 = new List<SwitchLabelSyntax>
            {
            v6423
            }

            ;
            SyntaxList<SwitchLabelSyntax> v6425 = Syntax.List<SwitchLabelSyntax>(list6424);
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6416 = this.f6416();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6407 = this.f6407();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6374 = this.f6374();
            Roslyn.Compilers.CSharp.BreakStatementSyntax v6335 = this.f6335();
            List<StatementSyntax> list6426 = new List<StatementSyntax>
            {
            v6416,v6407,v6374,v6335
            }

            ;
            SyntaxList<StatementSyntax> v6427 = Syntax.List<StatementSyntax>(list6426);
            return Syntax.SwitchSection(labels: v6425,statements: v6427);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6432()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6430 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6429 = Syntax.IdentifierName("Kind");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6430,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6429);
        }

        Roslyn.Compilers.CSharp.SwitchStatementSyntax f6440()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6432 = this.f6432();
            Roslyn.Compilers.CSharp.SwitchSectionSyntax v6428 = this.f6428();
            Roslyn.Compilers.CSharp.SwitchSectionSyntax v6332 = this.f6332();
            Roslyn.Compilers.CSharp.SwitchSectionSyntax v5956 = this.f5956();
            Roslyn.Compilers.CSharp.SwitchSectionSyntax v5862 = this.f5862();
            Roslyn.Compilers.CSharp.SwitchSectionSyntax v5840 = this.f5840();
            List<SwitchSectionSyntax> list6437 = new List<SwitchSectionSyntax>
            {
            v6428,v6332,v5956,v5862,v5840
            }

            ;
            SyntaxList<SwitchSectionSyntax> v6438 = Syntax.List<SwitchSectionSyntax>(list6437);
            return Syntax.SwitchStatement(switchKeyword: Syntax.Token(SyntaxKind.SwitchKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),expression: v6432,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),sections: v6438,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6442()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"GENERATOR_ERROR\"", "\"GENERATOR_ERROR\""));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6444()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6442 = this.f6442();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6442);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6446()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6444 = this.f6444();
            return Syntax.VariableDeclarator(Syntax.Identifier("valueText"),argumentListOpt: null ,initializerOpt: v6444);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6448()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6451()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6448 = this.f6448();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6446 = this.f6446();
            List<SyntaxNodeOrToken> list6449 = new List<SyntaxNodeOrToken>
            {
            v6446
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6450 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6449);
            return Syntax.VariableDeclaration(v6448,variables: v6450);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6455()
        {
            List<SyntaxToken> list6452 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6453 = Syntax.TokenList(list6452);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6451 = this.f6451();
            return Syntax.LocalDeclarationStatement(modifiers: v6453,declaration: v6451,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6460()
        {
            List<StatementSyntax> list6457 = new List<StatementSyntax>
            {
            }

            ;
            SyntaxList<StatementSyntax> v6458 = Syntax.List<StatementSyntax>(list6457);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6458,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6464()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6462 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6461 = Syntax.IdentifierName("StaticKeyword");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6462,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6461);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6468()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6466 = Syntax.IdentifierName("token");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6465 = Syntax.IdentifierName("Kind");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6466,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6465);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6470()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6468 = this.f6468();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6464 = this.f6464();
            return Syntax.BinaryExpression(SyntaxKind.EqualsExpression,v6468,operatorToken: Syntax.Token(SyntaxKind.EqualsEqualsToken),right: v6464);
        }

        Roslyn.Compilers.CSharp.IfStatementSyntax f6474()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6470 = this.f6470();
            Roslyn.Compilers.CSharp.BlockSyntax v6460 = this.f6460();
            return Syntax.IfStatement(ifKeyword: Syntax.Token(SyntaxKind.IfKeyword),openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),condition: v6470,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken),statement: v6460,elseOpt: null);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6476()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"GENERATOR_ERROR\"", "\"GENERATOR_ERROR\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6478()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6476 = this.f6476();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6476);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6480()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"GENERATOR_ERROR\"", "\"GENERATOR_ERROR\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6482()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6480 = this.f6480();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6480);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6488()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6482 = this.f6482();
            Roslyn.Compilers.CSharp.ArgumentSyntax v6478 = this.f6478();
            List<SyntaxNodeOrToken> list6485 = new List<SyntaxNodeOrToken>
            {
            v6482,Syntax.Token(SyntaxKind.CommaToken),v6478
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6486 = Syntax.SeparatedList<ArgumentSyntax>(list6485);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6486,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6492()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6490 = Syntax.IdentifierName("Syntax");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6489 = Syntax.IdentifierName("Literal");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6490,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6489);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6493()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6492 = this.f6492();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6488 = this.f6488();
            return Syntax.InvocationExpression(v6492,v6488);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6495()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6493 = this.f6493();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6493);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6497()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6495 = this.f6495();
            return Syntax.VariableDeclarator(Syntax.Identifier("literalToken"),argumentListOpt: null ,initializerOpt: v6495);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6501()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6498 = Syntax.IdentifierName("SyntaxToken");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6497 = this.f6497();
            List<SyntaxNodeOrToken> list6499 = new List<SyntaxNodeOrToken>
            {
            v6497
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6500 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6499);
            return Syntax.VariableDeclaration(v6498,variables: v6500);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6505()
        {
            List<SyntaxToken> list6502 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6503 = Syntax.TokenList(list6502);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6501 = this.f6501();
            return Syntax.LocalDeclarationStatement(modifiers: v6503,declaration: v6501,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6507()
        {
            return Syntax.LiteralExpression(SyntaxKind.FalseLiteralExpression,token: Syntax.Token(SyntaxKind.FalseKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6509()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6507 = this.f6507();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6507);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6511()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6509 = this.f6509();
            return Syntax.VariableDeclarator(Syntax.Identifier("createIdentifier"),argumentListOpt: null ,initializerOpt: v6509);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6513()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.BoolKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6516()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6513 = this.f6513();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6511 = this.f6511();
            List<SyntaxNodeOrToken> list6514 = new List<SyntaxNodeOrToken>
            {
            v6511
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6515 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6514);
            return Syntax.VariableDeclaration(v6513,variables: v6515);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6520()
        {
            List<SyntaxToken> list6517 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6518 = Syntax.TokenList(list6517);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6516 = this.f6516();
            return Syntax.LocalDeclarationStatement(modifiers: v6518,declaration: v6516,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6522()
        {
            return Syntax.LiteralExpression(SyntaxKind.TrueLiteralExpression,token: Syntax.Token(SyntaxKind.TrueKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6524()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6522 = this.f6522();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6522);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6526()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6524 = this.f6524();
            return Syntax.VariableDeclarator(Syntax.Identifier("createLiteral"),argumentListOpt: null ,initializerOpt: v6524);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6528()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.BoolKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6531()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6528 = this.f6528();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6526 = this.f6526();
            List<SyntaxNodeOrToken> list6529 = new List<SyntaxNodeOrToken>
            {
            v6526
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6530 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6529);
            return Syntax.VariableDeclaration(v6528,variables: v6530);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6535()
        {
            List<SyntaxToken> list6532 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6533 = Syntax.TokenList(list6532);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6531 = this.f6531();
            return Syntax.LocalDeclarationStatement(modifiers: v6533,declaration: v6531,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6539()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6537 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6536 = Syntax.IdentifierName("NullLiteralExpression");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6537,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6536);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6541()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6539 = this.f6539();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6539);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6543()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6541 = this.f6541();
            return Syntax.VariableDeclarator(Syntax.Identifier("literalExpressionSyntaxKind"),argumentListOpt: null ,initializerOpt: v6541);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6547()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6544 = Syntax.IdentifierName("SyntaxKind");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6543 = this.f6543();
            List<SyntaxNodeOrToken> list6545 = new List<SyntaxNodeOrToken>
            {
            v6543
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6546 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6545);
            return Syntax.VariableDeclaration(v6544,variables: v6546);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6551()
        {
            List<SyntaxToken> list6548 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6549 = Syntax.TokenList(list6548);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6547 = this.f6547();
            return Syntax.LocalDeclarationStatement(modifiers: v6549,declaration: v6547,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6553()
        {
            return Syntax.VariableDeclarator(Syntax.Identifier("instantiateExpression"),argumentListOpt: null ,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6557()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6554 = Syntax.IdentifierName("ExpressionSyntax");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6553 = this.f6553();
            List<SyntaxNodeOrToken> list6555 = new List<SyntaxNodeOrToken>
            {
            v6553
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6556 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6555);
            return Syntax.VariableDeclaration(v6554,variables: v6556);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6561()
        {
            List<SyntaxToken> list6558 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6559 = Syntax.TokenList(list6558);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6557 = this.f6557();
            return Syntax.LocalDeclarationStatement(modifiers: v6559,declaration: v6557,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6564()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"f\"", "\"f\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6566()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6564 = this.f6564();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6562 = Syntax.IdentifierName("variableCounter");
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6564,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6562);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6568()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6566 = this.f6566();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6566);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6570()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6568 = this.f6568();
            return Syntax.VariableDeclarator(Syntax.Identifier("funcName"),argumentListOpt: null ,initializerOpt: v6568);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6572()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6575()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6572 = this.f6572();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6570 = this.f6570();
            List<SyntaxNodeOrToken> list6573 = new List<SyntaxNodeOrToken>
            {
            v6570
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6574 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6573);
            return Syntax.VariableDeclaration(v6572,variables: v6574);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6579()
        {
            List<SyntaxToken> list6576 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6577 = Syntax.TokenList(list6576);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6575 = this.f6575();
            return Syntax.LocalDeclarationStatement(modifiers: v6577,declaration: v6575,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6582()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"t\"", "\"t\""));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6584()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6582 = this.f6582();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6580 = Syntax.IdentifierName("variableCounter");
            return Syntax.BinaryExpression(SyntaxKind.AddExpression,v6582,operatorToken: Syntax.Token(SyntaxKind.PlusToken),right: v6580);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6586()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6584 = this.f6584();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6584);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6588()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6586 = this.f6586();
            return Syntax.VariableDeclarator(Syntax.Identifier("varName"),argumentListOpt: null ,initializerOpt: v6586);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6590()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.StringKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6593()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6590 = this.f6590();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6588 = this.f6588();
            List<SyntaxNodeOrToken> list6591 = new List<SyntaxNodeOrToken>
            {
            v6588
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6592 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6591);
            return Syntax.VariableDeclaration(v6590,variables: v6592);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6597()
        {
            List<SyntaxToken> list6594 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6595 = Syntax.TokenList(list6594);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6593 = this.f6593();
            return Syntax.LocalDeclarationStatement(modifiers: v6595,declaration: v6593,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax f6600()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6598 = Syntax.IdentifierName("variableCounter");
            return Syntax.PostfixUnaryExpression(SyntaxKind.PostIncrementExpression,v6598,operatorToken: Syntax.Token(SyntaxKind.PlusPlusToken));
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6602()
        {
            Roslyn.Compilers.CSharp.PostfixUnaryExpressionSyntax v6600 = this.f6600();
            return Syntax.ExpressionStatement(v6600,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6607()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6602 = this.f6602();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6597 = this.f6597();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6579 = this.f6579();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6561 = this.f6561();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6551 = this.f6551();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6535 = this.f6535();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6520 = this.f6520();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6505 = this.f6505();
            Roslyn.Compilers.CSharp.IfStatementSyntax v6474 = this.f6474();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6455 = this.f6455();
            Roslyn.Compilers.CSharp.SwitchStatementSyntax v6440 = this.f6440();
            Roslyn.Compilers.CSharp.IfStatementSyntax v5822 = this.f5822();
            Roslyn.Compilers.CSharp.ReturnStatementSyntax v5185 = this.f5185();
            List<StatementSyntax> list6604 = new List<StatementSyntax>
            {
            v6602,v6597,v6579,v6561,v6551,v6535,v6520,v6505,v6474,v6455,v6440,v5822,v5185
            }

            ;
            SyntaxList<StatementSyntax> v6605 = Syntax.List<StatementSyntax>(list6604);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6605,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f6614()
        {
            List<AttributeDeclarationSyntax> list6609 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6610 = Syntax.List<AttributeDeclarationSyntax>(list6609);
            List<SyntaxToken> list6611 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6612 = Syntax.TokenList(list6611);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6608 = Syntax.IdentifierName("SyntaxToken");
            return Syntax.Parameter(attributes: v6610,modifiers: v6612,typeOpt: v6608,identifier: Syntax.Identifier("token"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f6619()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v6614 = this.f6614();
            List<SyntaxNodeOrToken> list6616 = new List<SyntaxNodeOrToken>
            {
            v6614
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v6617 = Syntax.SeparatedList<ParameterSyntax>(list6616);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v6617,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f6630()
        {
            List<AttributeDeclarationSyntax> list6621 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6622 = Syntax.List<AttributeDeclarationSyntax>(list6621);
            List<SyntaxToken> list6624 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PrivateKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6625 = Syntax.TokenList(list6624);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6620 = Syntax.IdentifierName("ExpressionSyntax");
            Roslyn.Compilers.CSharp.ParameterListSyntax v6619 = this.f6619();
            List<TypeParameterConstraintClauseSyntax> list6627 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v6628 = Syntax.List<TypeParameterConstraintClauseSyntax>(list6627);
            Roslyn.Compilers.CSharp.BlockSyntax v6607 = this.f6607();
            return Syntax.MethodDeclaration(attributes: v6622,modifiers: v6625,returnType: v6620,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("CreateToken"),typeParameterListOpt: null ,parameterList: v6619,constraintClauses: v6628,bodyOpt: v6607,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6633()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6631 = Syntax.IdentifierName("node");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6631);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6638()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6633 = this.f6633();
            List<SyntaxNodeOrToken> list6635 = new List<SyntaxNodeOrToken>
            {
            v6633
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6636 = Syntax.SeparatedList<ArgumentSyntax>(list6635);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6636,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.BaseExpressionSyntax f6641()
        {
            return Syntax.BaseExpression(token: Syntax.Token(SyntaxKind.BaseKeyword));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6643()
        {
            Roslyn.Compilers.CSharp.BaseExpressionSyntax v6641 = this.f6641();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6639 = Syntax.IdentifierName("VisitSyntaxNode");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6641,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6639);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6644()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6643 = this.f6643();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6638 = this.f6638();
            return Syntax.InvocationExpression(v6643,v6638);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6646()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6644 = this.f6644();
            return Syntax.ExpressionStatement(v6644,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6649()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6647 = Syntax.IdentifierName("node");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6647);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6652()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6650 = Syntax.IdentifierName("syntaxNodeType");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6650);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6658()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6652 = this.f6652();
            Roslyn.Compilers.CSharp.ArgumentSyntax v6649 = this.f6649();
            List<SyntaxNodeOrToken> list6655 = new List<SyntaxNodeOrToken>
            {
            v6652,Syntax.Token(SyntaxKind.CommaToken),v6649
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6656 = Syntax.SeparatedList<ArgumentSyntax>(list6655);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6656,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6660()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6659 = Syntax.IdentifierName("GGSyntaxNode");
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6658 = this.f6658();
            return Syntax.InvocationExpression(v6659,v6658);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6662()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6660 = this.f6660();
            return Syntax.ExpressionStatement(v6660,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6666()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6664 = Syntax.IdentifierName("BindingFlags");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6663 = Syntax.IdentifierName("Instance");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6664,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6663);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6670()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6668 = Syntax.IdentifierName("BindingFlags");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6667 = Syntax.IdentifierName("DeclaredOnly");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6668,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6667);
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6674()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6672 = Syntax.IdentifierName("BindingFlags");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6671 = Syntax.IdentifierName("Public");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6672,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6671);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6676()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6674 = this.f6674();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6670 = this.f6670();
            return Syntax.BinaryExpression(SyntaxKind.BitwiseOrExpression,v6674,operatorToken: Syntax.Token(SyntaxKind.BarToken),right: v6670);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6678()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6676 = this.f6676();
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6666 = this.f6666();
            return Syntax.BinaryExpression(SyntaxKind.BitwiseOrExpression,v6676,operatorToken: Syntax.Token(SyntaxKind.BarToken),right: v6666);
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6680()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6678 = this.f6678();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6678);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6685()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6680 = this.f6680();
            List<SyntaxNodeOrToken> list6682 = new List<SyntaxNodeOrToken>
            {
            v6680
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6683 = Syntax.SeparatedList<ArgumentSyntax>(list6682);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6683,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6689()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6687 = Syntax.IdentifierName("syntaxNodeType");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6686 = Syntax.IdentifierName("GetMembers");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6687,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6686);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6690()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6689 = this.f6689();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6685 = this.f6685();
            return Syntax.InvocationExpression(v6689,v6685);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6692()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6690 = this.f6690();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6690);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6694()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6692 = this.f6692();
            return Syntax.VariableDeclarator(Syntax.Identifier("members"),argumentListOpt: null ,initializerOpt: v6692);
        }

        Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax f6699()
        {
            List<SyntaxNodeOrToken> list6696 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ExpressionSyntax> v6697 = Syntax.SeparatedList<ExpressionSyntax>(list6696);
            return Syntax.ArrayRankSpecifier(openBracketToken: Syntax.Token(SyntaxKind.OpenBracketToken),sizes: v6697,closeBracketToken: Syntax.Token(SyntaxKind.CloseBracketToken));
        }

        Roslyn.Compilers.CSharp.ArrayTypeSyntax f6703()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6700 = Syntax.IdentifierName("MemberInfo");
            Roslyn.Compilers.CSharp.ArrayRankSpecifierSyntax v6699 = this.f6699();
            List<ArrayRankSpecifierSyntax> list6701 = new List<ArrayRankSpecifierSyntax>
            {
            v6699
            }

            ;
            SyntaxList<ArrayRankSpecifierSyntax> v6702 = Syntax.List<ArrayRankSpecifierSyntax>(list6701);
            return Syntax.ArrayType(v6700,rankSpecifiers: v6702);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6706()
        {
            Roslyn.Compilers.CSharp.ArrayTypeSyntax v6703 = this.f6703();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6694 = this.f6694();
            List<SyntaxNodeOrToken> list6704 = new List<SyntaxNodeOrToken>
            {
            v6694
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6705 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6704);
            return Syntax.VariableDeclaration(v6703,variables: v6705);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6710()
        {
            List<SyntaxToken> list6707 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6708 = Syntax.TokenList(list6707);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6706 = this.f6706();
            return Syntax.LocalDeclarationStatement(modifiers: v6708,declaration: v6706,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6715()
        {
            List<SyntaxNodeOrToken> list6712 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6713 = Syntax.SeparatedList<ArgumentSyntax>(list6712);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6713,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6719()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6717 = Syntax.IdentifierName("node");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6716 = Syntax.IdentifierName("GetType");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6717,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6716);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6720()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6719 = this.f6719();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6715 = this.f6715();
            return Syntax.InvocationExpression(v6719,v6715);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6722()
        {
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6720 = this.f6720();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6720);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6724()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6722 = this.f6722();
            return Syntax.VariableDeclarator(Syntax.Identifier("syntaxNodeType"),argumentListOpt: null ,initializerOpt: v6722);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6728()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6725 = Syntax.IdentifierName("Type");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6724 = this.f6724();
            List<SyntaxNodeOrToken> list6726 = new List<SyntaxNodeOrToken>
            {
            v6724
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6727 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6726);
            return Syntax.VariableDeclaration(v6725,variables: v6727);
        }

        Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax f6732()
        {
            List<SyntaxToken> list6729 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6730 = Syntax.TokenList(list6729);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6728 = this.f6728();
            return Syntax.LocalDeclarationStatement(modifiers: v6730,declaration: v6728,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6737()
        {
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6732 = this.f6732();
            Roslyn.Compilers.CSharp.LocalDeclarationStatementSyntax v6710 = this.f6710();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6662 = this.f6662();
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6646 = this.f6646();
            List<StatementSyntax> list6734 = new List<StatementSyntax>
            {
            v6732,v6710,v6662,v6646
            }

            ;
            SyntaxList<StatementSyntax> v6735 = Syntax.List<StatementSyntax>(list6734);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6735,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f6744()
        {
            List<AttributeDeclarationSyntax> list6739 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6740 = Syntax.List<AttributeDeclarationSyntax>(list6739);
            List<SyntaxToken> list6741 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6742 = Syntax.TokenList(list6741);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6738 = Syntax.IdentifierName("SyntaxNode");
            return Syntax.Parameter(attributes: v6740,modifiers: v6742,typeOpt: v6738,identifier: Syntax.Identifier("node"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f6749()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v6744 = this.f6744();
            List<SyntaxNodeOrToken> list6746 = new List<SyntaxNodeOrToken>
            {
            v6744
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v6747 = Syntax.SeparatedList<ParameterSyntax>(list6746);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v6747,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6751()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.VoidKeyword));
        }

        Roslyn.Compilers.CSharp.MethodDeclarationSyntax f6762()
        {
            List<AttributeDeclarationSyntax> list6752 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6753 = Syntax.List<AttributeDeclarationSyntax>(list6752);
            List<SyntaxToken> list6756 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.ProtectedKeyword),Syntax.Token(SyntaxKind.OverrideKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6757 = Syntax.TokenList(list6756);
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6751 = this.f6751();
            Roslyn.Compilers.CSharp.ParameterListSyntax v6749 = this.f6749();
            List<TypeParameterConstraintClauseSyntax> list6759 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v6760 = Syntax.List<TypeParameterConstraintClauseSyntax>(list6759);
            Roslyn.Compilers.CSharp.BlockSyntax v6737 = this.f6737();
            return Syntax.MethodDeclaration(attributes: v6753,modifiers: v6757,returnType: v6751,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("VisitSyntaxNode"),typeParameterListOpt: null ,parameterList: v6749,constraintClauses: v6760,bodyOpt: v6737,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6764()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6766()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6764 = this.f6764();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6764);
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6768()
        {
            return Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression,token: Syntax.Literal("\"output\"", "\"output\""));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6770()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6768 = this.f6768();
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6768);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6776()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6770 = this.f6770();
            Roslyn.Compilers.CSharp.ArgumentSyntax v6766 = this.f6766();
            List<SyntaxNodeOrToken> list6773 = new List<SyntaxNodeOrToken>
            {
            v6770,Syntax.Token(SyntaxKind.CommaToken),v6766
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6774 = Syntax.SeparatedList<ArgumentSyntax>(list6773);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6774,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax f6780()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6778 = Syntax.IdentifierName("SyntaxTree");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6777 = Syntax.IdentifierName("Create");
            return Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression,v6778,operatorToken: Syntax.Token(SyntaxKind.DotToken),name: v6777);
        }

        Roslyn.Compilers.CSharp.InvocationExpressionSyntax f6781()
        {
            Roslyn.Compilers.CSharp.MemberAccessExpressionSyntax v6780 = this.f6780();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6776 = this.f6776();
            return Syntax.InvocationExpression(v6780,v6776);
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6784()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6782 = Syntax.IdentifierName("syntaxTree");
            Roslyn.Compilers.CSharp.InvocationExpressionSyntax v6781 = this.f6781();
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6782,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6781);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6786()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6784 = this.f6784();
            return Syntax.ExpressionStatement(v6784,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6791()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6786 = this.f6786();
            List<StatementSyntax> list6788 = new List<StatementSyntax>
            {
            v6786
            }

            ;
            SyntaxList<StatementSyntax> v6789 = Syntax.List<StatementSyntax>(list6788);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6789,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.ArgumentSyntax f6794()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6792 = Syntax.IdentifierName("node");
            return Syntax.Argument(nameColonOpt: null ,refOrOutKeywordOpt: Syntax.Token(SyntaxKind.None),expression: v6792);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6799()
        {
            Roslyn.Compilers.CSharp.ArgumentSyntax v6794 = this.f6794();
            List<SyntaxNodeOrToken> list6796 = new List<SyntaxNodeOrToken>
            {
            v6794
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6797 = Syntax.SeparatedList<ArgumentSyntax>(list6796);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6797,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ConstructorInitializerSyntax f6802()
        {
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6799 = this.f6799();
            return Syntax.ConstructorInitializer(SyntaxKind.BaseConstructorInitializer,colonToken: Syntax.Token(SyntaxKind.ColonToken),thisOrBaseKeyword: Syntax.Token(SyntaxKind.BaseKeyword),argumentList: v6799);
        }

        Roslyn.Compilers.CSharp.ParameterSyntax f6809()
        {
            List<AttributeDeclarationSyntax> list6804 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6805 = Syntax.List<AttributeDeclarationSyntax>(list6804);
            List<SyntaxToken> list6806 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6807 = Syntax.TokenList(list6806);
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6803 = Syntax.IdentifierName("SyntaxNode");
            return Syntax.Parameter(attributes: v6805,modifiers: v6807,typeOpt: v6803,identifier: Syntax.Identifier("node"),defaultOpt: null);
        }

        Roslyn.Compilers.CSharp.ParameterListSyntax f6814()
        {
            Roslyn.Compilers.CSharp.ParameterSyntax v6809 = this.f6809();
            List<SyntaxNodeOrToken> list6811 = new List<SyntaxNodeOrToken>
            {
            v6809
            }

            ;
            SeparatedSyntaxList<ParameterSyntax> v6812 = Syntax.SeparatedList<ParameterSyntax>(list6811);
            return Syntax.ParameterList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),parameters: v6812,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.ConstructorDeclarationSyntax f6822()
        {
            List<AttributeDeclarationSyntax> list6815 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6816 = Syntax.List<AttributeDeclarationSyntax>(list6815);
            List<SyntaxToken> list6818 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PublicKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6819 = Syntax.TokenList(list6818);
            Roslyn.Compilers.CSharp.ParameterListSyntax v6814 = this.f6814();
            Roslyn.Compilers.CSharp.ConstructorInitializerSyntax v6802 = this.f6802();
            Roslyn.Compilers.CSharp.BlockSyntax v6791 = this.f6791();
            return Syntax.ConstructorDeclaration(attributes: v6816,modifiers: v6819,identifier: Syntax.Identifier("BootStrapper"),parameterList: v6814,initializerOpt: v6802,bodyOpt: v6791,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.BinaryExpressionSyntax f6826()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6824 = Syntax.IdentifierName("generated");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6823 = Syntax.IdentifierName("value");
            return Syntax.BinaryExpression(SyntaxKind.AssignExpression,v6824,operatorToken: Syntax.Token(SyntaxKind.EqualsToken),right: v6823);
        }

        Roslyn.Compilers.CSharp.ExpressionStatementSyntax f6828()
        {
            Roslyn.Compilers.CSharp.BinaryExpressionSyntax v6826 = this.f6826();
            return Syntax.ExpressionStatement(v6826,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6833()
        {
            Roslyn.Compilers.CSharp.ExpressionStatementSyntax v6828 = this.f6828();
            List<StatementSyntax> list6830 = new List<StatementSyntax>
            {
            v6828
            }

            ;
            SyntaxList<StatementSyntax> v6831 = Syntax.List<StatementSyntax>(list6830);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6831,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.AccessorDeclarationSyntax f6840()
        {
            List<AttributeDeclarationSyntax> list6834 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6835 = Syntax.List<AttributeDeclarationSyntax>(list6834);
            List<SyntaxToken> list6836 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6837 = Syntax.TokenList(list6836);
            Roslyn.Compilers.CSharp.BlockSyntax v6833 = this.f6833();
            return Syntax.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration,attributes: v6835,modifiers: v6837,keyword: Syntax.Token(SyntaxKind.SetKeyword),bodyOpt: v6833,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.ReturnStatementSyntax f6844()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6841 = Syntax.IdentifierName("generated");
            return Syntax.ReturnStatement(returnKeyword: Syntax.Token(SyntaxKind.ReturnKeyword),expressionOpt: v6841,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BlockSyntax f6849()
        {
            Roslyn.Compilers.CSharp.ReturnStatementSyntax v6844 = this.f6844();
            List<StatementSyntax> list6846 = new List<StatementSyntax>
            {
            v6844
            }

            ;
            SyntaxList<StatementSyntax> v6847 = Syntax.List<StatementSyntax>(list6846);
            return Syntax.Block(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),statements: v6847,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.AccessorDeclarationSyntax f6856()
        {
            List<AttributeDeclarationSyntax> list6850 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6851 = Syntax.List<AttributeDeclarationSyntax>(list6850);
            List<SyntaxToken> list6852 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6853 = Syntax.TokenList(list6852);
            Roslyn.Compilers.CSharp.BlockSyntax v6849 = this.f6849();
            return Syntax.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration,attributes: v6851,modifiers: v6853,keyword: Syntax.Token(SyntaxKind.GetKeyword),bodyOpt: v6849,semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.AccessorListSyntax f6861()
        {
            Roslyn.Compilers.CSharp.AccessorDeclarationSyntax v6856 = this.f6856();
            Roslyn.Compilers.CSharp.AccessorDeclarationSyntax v6840 = this.f6840();
            List<AccessorDeclarationSyntax> list6858 = new List<AccessorDeclarationSyntax>
            {
            v6856,v6840
            }

            ;
            SyntaxList<AccessorDeclarationSyntax> v6859 = Syntax.List<AccessorDeclarationSyntax>(list6858);
            return Syntax.AccessorList(openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),accessors: v6859,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f6867()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6862 = Syntax.IdentifierName("MethodDeclarationSyntax");
            List<SyntaxNodeOrToken> list6864 = new List<SyntaxNodeOrToken>
            {
            v6862
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v6865 = Syntax.SeparatedList<TypeSyntax>(list6864);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v6865,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f6869()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v6867 = this.f6867();
            return Syntax.GenericName(Syntax.Identifier("List"),v6867);
        }

        Roslyn.Compilers.CSharp.PropertyDeclarationSyntax f6876()
        {
            List<AttributeDeclarationSyntax> list6870 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6871 = Syntax.List<AttributeDeclarationSyntax>(list6870);
            List<SyntaxToken> list6873 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PublicKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6874 = Syntax.TokenList(list6873);
            Roslyn.Compilers.CSharp.GenericNameSyntax v6869 = this.f6869();
            Roslyn.Compilers.CSharp.AccessorListSyntax v6861 = this.f6861();
            return Syntax.PropertyDeclaration(attributes: v6871,modifiers: v6874,type: v6869,explicitInterfaceSpecifierOpt: null ,identifier: Syntax.Identifier("Generated"),accessorList: v6861);
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6881()
        {
            List<SyntaxNodeOrToken> list6878 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6879 = Syntax.SeparatedList<ArgumentSyntax>(list6878);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6879,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f6887()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6882 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            List<SyntaxNodeOrToken> list6884 = new List<SyntaxNodeOrToken>
            {
            v6882
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v6885 = Syntax.SeparatedList<TypeSyntax>(list6884);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v6885,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f6889()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v6887 = this.f6887();
            return Syntax.GenericName(Syntax.Identifier("Stack"),v6887);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f6891()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v6889 = this.f6889();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6881 = this.f6881();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v6889,argumentListOpt: v6881,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6893()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v6891 = this.f6891();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6891);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6895()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6893 = this.f6893();
            return Syntax.VariableDeclarator(Syntax.Identifier("syntaxNodeLocals"),argumentListOpt: null ,initializerOpt: v6893);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f6901()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6896 = Syntax.IdentifierName("LocalDeclarationStatementSyntax");
            List<SyntaxNodeOrToken> list6898 = new List<SyntaxNodeOrToken>
            {
            v6896
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v6899 = Syntax.SeparatedList<TypeSyntax>(list6898);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v6899,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f6903()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v6901 = this.f6901();
            return Syntax.GenericName(Syntax.Identifier("Stack"),v6901);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6906()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v6903 = this.f6903();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6895 = this.f6895();
            List<SyntaxNodeOrToken> list6904 = new List<SyntaxNodeOrToken>
            {
            v6895
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6905 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6904);
            return Syntax.VariableDeclaration(v6903,variables: v6905);
        }

        Roslyn.Compilers.CSharp.FieldDeclarationSyntax f6912()
        {
            List<AttributeDeclarationSyntax> list6907 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6908 = Syntax.List<AttributeDeclarationSyntax>(list6907);
            List<SyntaxToken> list6909 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6910 = Syntax.TokenList(list6909);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6906 = this.f6906();
            return Syntax.FieldDeclaration(attributes: v6908,modifiers: v6910,declaration: v6906,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.ArgumentListSyntax f6917()
        {
            List<SyntaxNodeOrToken> list6914 = new List<SyntaxNodeOrToken>
            {
            }

            ;
            SeparatedSyntaxList<ArgumentSyntax> v6915 = Syntax.SeparatedList<ArgumentSyntax>(list6914);
            return Syntax.ArgumentList(openParenToken: Syntax.Token(SyntaxKind.OpenParenToken),arguments: v6915,closeParenToken: Syntax.Token(SyntaxKind.CloseParenToken));
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f6923()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6918 = Syntax.IdentifierName("MethodDeclarationSyntax");
            List<SyntaxNodeOrToken> list6920 = new List<SyntaxNodeOrToken>
            {
            v6918
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v6921 = Syntax.SeparatedList<TypeSyntax>(list6920);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v6921,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f6925()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v6923 = this.f6923();
            return Syntax.GenericName(Syntax.Identifier("List"),v6923);
        }

        Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax f6927()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v6925 = this.f6925();
            Roslyn.Compilers.CSharp.ArgumentListSyntax v6917 = this.f6917();
            return Syntax.ObjectCreationExpression(newKeyword: Syntax.Token(SyntaxKind.NewKeyword),type: v6925,argumentListOpt: v6917,initializerOpt: null);
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6929()
        {
            Roslyn.Compilers.CSharp.ObjectCreationExpressionSyntax v6927 = this.f6927();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6927);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6931()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6929 = this.f6929();
            return Syntax.VariableDeclarator(Syntax.Identifier("generated"),argumentListOpt: null ,initializerOpt: v6929);
        }

        Roslyn.Compilers.CSharp.TypeArgumentListSyntax f6937()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6932 = Syntax.IdentifierName("MethodDeclarationSyntax");
            List<SyntaxNodeOrToken> list6934 = new List<SyntaxNodeOrToken>
            {
            v6932
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v6935 = Syntax.SeparatedList<TypeSyntax>(list6934);
            return Syntax.TypeArgumentList(lessThanToken: Syntax.Token(SyntaxKind.LessThanToken),arguments: v6935,greaterThanToken: Syntax.Token(SyntaxKind.GreaterThanToken));
        }

        Roslyn.Compilers.CSharp.GenericNameSyntax f6939()
        {
            Roslyn.Compilers.CSharp.TypeArgumentListSyntax v6937 = this.f6937();
            return Syntax.GenericName(Syntax.Identifier("List"),v6937);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6942()
        {
            Roslyn.Compilers.CSharp.GenericNameSyntax v6939 = this.f6939();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6931 = this.f6931();
            List<SyntaxNodeOrToken> list6940 = new List<SyntaxNodeOrToken>
            {
            v6931
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6941 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6940);
            return Syntax.VariableDeclaration(v6939,variables: v6941);
        }

        Roslyn.Compilers.CSharp.FieldDeclarationSyntax f6948()
        {
            List<AttributeDeclarationSyntax> list6943 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6944 = Syntax.List<AttributeDeclarationSyntax>(list6943);
            List<SyntaxToken> list6945 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6946 = Syntax.TokenList(list6945);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6942 = this.f6942();
            return Syntax.FieldDeclaration(attributes: v6944,modifiers: v6946,declaration: v6942,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6950()
        {
            return Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression,token: Syntax.Token(SyntaxKind.NullKeyword));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6952()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6950 = this.f6950();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6950);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6954()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6952 = this.f6952();
            return Syntax.VariableDeclarator(Syntax.Identifier("syntaxTree"),argumentListOpt: null ,initializerOpt: v6952);
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6958()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6955 = Syntax.IdentifierName("SyntaxTree");
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6954 = this.f6954();
            List<SyntaxNodeOrToken> list6956 = new List<SyntaxNodeOrToken>
            {
            v6954
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6957 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6956);
            return Syntax.VariableDeclaration(v6955,variables: v6957);
        }

        Roslyn.Compilers.CSharp.FieldDeclarationSyntax f6964()
        {
            List<AttributeDeclarationSyntax> list6959 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6960 = Syntax.List<AttributeDeclarationSyntax>(list6959);
            List<SyntaxToken> list6961 = new List<SyntaxToken>
            {
            }

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6962 = Syntax.TokenList(list6961);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6958 = this.f6958();
            return Syntax.FieldDeclaration(attributes: v6960,modifiers: v6962,declaration: v6958,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.LiteralExpressionSyntax f6966()
        {
            return Syntax.LiteralExpression(SyntaxKind.NumericLiteralExpression,token: Syntax.Literal("0", 0));
        }

        Roslyn.Compilers.CSharp.EqualsValueClauseSyntax f6968()
        {
            Roslyn.Compilers.CSharp.LiteralExpressionSyntax v6966 = this.f6966();
            return Syntax.EqualsValueClause(equalsToken: Syntax.Token(SyntaxKind.EqualsToken),value: v6966);
        }

        Roslyn.Compilers.CSharp.VariableDeclaratorSyntax f6970()
        {
            Roslyn.Compilers.CSharp.EqualsValueClauseSyntax v6968 = this.f6968();
            return Syntax.VariableDeclarator(Syntax.Identifier("variableCounter"),argumentListOpt: null ,initializerOpt: v6968);
        }

        Roslyn.Compilers.CSharp.PredefinedTypeSyntax f6972()
        {
            return Syntax.PredefinedType(Syntax.Token(SyntaxKind.IntKeyword));
        }

        Roslyn.Compilers.CSharp.VariableDeclarationSyntax f6975()
        {
            Roslyn.Compilers.CSharp.PredefinedTypeSyntax v6972 = this.f6972();
            Roslyn.Compilers.CSharp.VariableDeclaratorSyntax v6970 = this.f6970();
            List<SyntaxNodeOrToken> list6973 = new List<SyntaxNodeOrToken>
            {
            v6970
            }

            ;
            SeparatedSyntaxList<VariableDeclaratorSyntax> v6974 = Syntax.SeparatedList<VariableDeclaratorSyntax>(list6973);
            return Syntax.VariableDeclaration(v6972,variables: v6974);
        }

        Roslyn.Compilers.CSharp.FieldDeclarationSyntax f6982()
        {
            List<AttributeDeclarationSyntax> list6976 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6977 = Syntax.List<AttributeDeclarationSyntax>(list6976);
            List<SyntaxToken> list6979 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.StaticKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6980 = Syntax.TokenList(list6979);
            Roslyn.Compilers.CSharp.VariableDeclarationSyntax v6975 = this.f6975();
            return Syntax.FieldDeclaration(attributes: v6977,modifiers: v6980,declaration: v6975,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.BaseListSyntax f6987()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v6983 = Syntax.IdentifierName("ReverseSyntaxVisitor");
            List<SyntaxNodeOrToken> list6985 = new List<SyntaxNodeOrToken>
            {
            v6983
            }

            ;
            SeparatedSyntaxList<TypeSyntax> v6986 = Syntax.SeparatedList<TypeSyntax>(list6985);
            return Syntax.BaseList(colonToken: Syntax.Token(SyntaxKind.ColonToken),types: v6986);
        }

        Roslyn.Compilers.CSharp.ClassDeclarationSyntax f7002()
        {
            List<AttributeDeclarationSyntax> list6988 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v6989 = Syntax.List<AttributeDeclarationSyntax>(list6988);
            List<SyntaxToken> list6991 = new List<SyntaxToken>
            {
            Syntax.Token(SyntaxKind.PublicKeyword)}

            ;
            Roslyn.Compilers.CSharp.SyntaxTokenList v6992 = Syntax.TokenList(list6991);
            Roslyn.Compilers.CSharp.BaseListSyntax v6987 = this.f6987();
            List<TypeParameterConstraintClauseSyntax> list6995 = new List<TypeParameterConstraintClauseSyntax>
            {
            }

            ;
            SyntaxList<TypeParameterConstraintClauseSyntax> v6996 = Syntax.List<TypeParameterConstraintClauseSyntax>(list6995);
            Roslyn.Compilers.CSharp.FieldDeclarationSyntax v6982 = this.f6982();
            Roslyn.Compilers.CSharp.FieldDeclarationSyntax v6964 = this.f6964();
            Roslyn.Compilers.CSharp.FieldDeclarationSyntax v6948 = this.f6948();
            Roslyn.Compilers.CSharp.FieldDeclarationSyntax v6912 = this.f6912();
            Roslyn.Compilers.CSharp.PropertyDeclarationSyntax v6876 = this.f6876();
            Roslyn.Compilers.CSharp.ConstructorDeclarationSyntax v6822 = this.f6822();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v6762 = this.f6762();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v6630 = this.f6630();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v5181 = this.f5181();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v5110 = this.f5110();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v4840 = this.f4840();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v4794 = this.f4794();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v1989 = this.f1989();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v1545 = this.f1545();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v1263 = this.f1263();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v1076 = this.f1076();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v190 = this.f190();
            Roslyn.Compilers.CSharp.MethodDeclarationSyntax v58 = this.f58();
            List<MemberDeclarationSyntax> list6998 = new List<MemberDeclarationSyntax>
            {
            v6982,v6964,v6948,v6912,v6876,v6822,v6762,v6630,v5181,v5110,v4840,v4794,v1989,v1545,v1263,v1076,v190,v58
            }

            ;
            SyntaxList<MemberDeclarationSyntax> v6999 = Syntax.List<MemberDeclarationSyntax>(list6998);
            return Syntax.ClassDeclaration(attributes: v6989,modifiers: v6992,keyword: Syntax.Token(SyntaxKind.ClassKeyword),identifier: Syntax.Identifier("BootStrapper"),typeParameterListOpt: null ,baseListOpt: v6987,constraintClauses: v6996,openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),members: v6999,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken),semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.NamespaceDeclarationSyntax f7014()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7003 = Syntax.IdentifierName("CodeBootStrap");
            List<ExternAliasDirectiveSyntax> list7006 = new List<ExternAliasDirectiveSyntax>
            {
            }

            ;
            SyntaxList<ExternAliasDirectiveSyntax> v7007 = Syntax.List<ExternAliasDirectiveSyntax>(list7006);
            List<UsingDirectiveSyntax> list7008 = new List<UsingDirectiveSyntax>
            {
            }

            ;
            SyntaxList<UsingDirectiveSyntax> v7009 = Syntax.List<UsingDirectiveSyntax>(list7008);
            Roslyn.Compilers.CSharp.ClassDeclarationSyntax v7002 = this.f7002();
            List<MemberDeclarationSyntax> list7010 = new List<MemberDeclarationSyntax>
            {
            v7002
            }

            ;
            SyntaxList<MemberDeclarationSyntax> v7011 = Syntax.List<MemberDeclarationSyntax>(list7010);
            return Syntax.NamespaceDeclaration(namespaceKeyword: Syntax.Token(SyntaxKind.NamespaceKeyword),name: v7003,openBraceToken: Syntax.Token(SyntaxKind.OpenBraceToken),externs: v7007,usings: v7009,members: v7011,closeBraceToken: Syntax.Token(SyntaxKind.CloseBraceToken),semicolonTokenOpt: Syntax.Token(SyntaxKind.None));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f7018()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7016 = Syntax.IdentifierName("System");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7015 = Syntax.IdentifierName("Collections");
            return Syntax.QualifiedName(v7016,dotToken: Syntax.Token(SyntaxKind.DotToken),right: v7015);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f7021()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v7018 = this.f7018();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: v7018,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f7026()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7024 = Syntax.IdentifierName("Roslyn");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7023 = Syntax.IdentifierName("Compilers");
            return Syntax.QualifiedName(v7024,dotToken: Syntax.Token(SyntaxKind.DotToken),right: v7023);
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f7028()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v7026 = this.f7026();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7022 = Syntax.IdentifierName("CSharp");
            return Syntax.QualifiedName(v7026,dotToken: Syntax.Token(SyntaxKind.DotToken),right: v7022);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f7031()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v7028 = this.f7028();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: v7028,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f7035()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7033 = Syntax.IdentifierName("Roslyn");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7032 = Syntax.IdentifierName("Compilers");
            return Syntax.QualifiedName(v7033,dotToken: Syntax.Token(SyntaxKind.DotToken),right: v7032);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f7038()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v7035 = this.f7035();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: v7035,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f7042()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7040 = Syntax.IdentifierName("System");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7039 = Syntax.IdentifierName("Reflection");
            return Syntax.QualifiedName(v7040,dotToken: Syntax.Token(SyntaxKind.DotToken),right: v7039);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f7045()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v7042 = this.f7042();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: v7042,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f7049()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7047 = Syntax.IdentifierName("System");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7046 = Syntax.IdentifierName("Text");
            return Syntax.QualifiedName(v7047,dotToken: Syntax.Token(SyntaxKind.DotToken),right: v7046);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f7052()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v7049 = this.f7049();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: v7049,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f7056()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7054 = Syntax.IdentifierName("System");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7053 = Syntax.IdentifierName("Linq");
            return Syntax.QualifiedName(v7054,dotToken: Syntax.Token(SyntaxKind.DotToken),right: v7053);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f7059()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v7056 = this.f7056();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: v7056,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f7064()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7062 = Syntax.IdentifierName("System");
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7061 = Syntax.IdentifierName("Collections");
            return Syntax.QualifiedName(v7062,dotToken: Syntax.Token(SyntaxKind.DotToken),right: v7061);
        }

        Roslyn.Compilers.CSharp.QualifiedNameSyntax f7066()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v7064 = this.f7064();
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7060 = Syntax.IdentifierName("Generic");
            return Syntax.QualifiedName(v7064,dotToken: Syntax.Token(SyntaxKind.DotToken),right: v7060);
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f7069()
        {
            Roslyn.Compilers.CSharp.QualifiedNameSyntax v7066 = this.f7066();
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: v7066,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.UsingDirectiveSyntax f7073()
        {
            Roslyn.Compilers.CSharp.IdentifierNameSyntax v7070 = Syntax.IdentifierName("System");
            return Syntax.UsingDirective(usingKeyword: Syntax.Token(SyntaxKind.UsingKeyword),aliasOpt: null ,name: v7070,semicolonToken: Syntax.Token(SyntaxKind.SemicolonToken));
        }

        Roslyn.Compilers.CSharp.CompilationUnitSyntax f7083()
        {
            List<ExternAliasDirectiveSyntax> list7074 = new List<ExternAliasDirectiveSyntax>
            {
            }

            ;
            SyntaxList<ExternAliasDirectiveSyntax> v7075 = Syntax.List<ExternAliasDirectiveSyntax>(list7074);
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v7073 = this.f7073();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v7069 = this.f7069();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v7059 = this.f7059();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v7052 = this.f7052();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v7045 = this.f7045();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v7038 = this.f7038();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v7031 = this.f7031();
            Roslyn.Compilers.CSharp.UsingDirectiveSyntax v7021 = this.f7021();
            List<UsingDirectiveSyntax> list7076 = new List<UsingDirectiveSyntax>
            {
            v7073,v7069,v7059,v7052,v7045,v7038,v7031,v7021
            }

            ;
            SyntaxList<UsingDirectiveSyntax> v7077 = Syntax.List<UsingDirectiveSyntax>(list7076);
            List<AttributeDeclarationSyntax> list7078 = new List<AttributeDeclarationSyntax>
            {
            }

            ;
            SyntaxList<AttributeDeclarationSyntax> v7079 = Syntax.List<AttributeDeclarationSyntax>(list7078);
            Roslyn.Compilers.CSharp.NamespaceDeclarationSyntax v7014 = this.f7014();
            List<MemberDeclarationSyntax> list7080 = new List<MemberDeclarationSyntax>
            {
            v7014
            }

            ;
            SyntaxList<MemberDeclarationSyntax> v7081 = Syntax.List<MemberDeclarationSyntax>(list7080);
            return Syntax.CompilationUnit(externs: v7075,usings: v7077,attributes: v7079,members: v7081,endOfFileToken: Syntax.Token(SyntaxKind.EndOfFileToken));
        }
    }
}