using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genesis
{
    public static class GenesisDevice
    {
        public static SyntaxTree Genesis(SyntaxTree syntaxTree)
        {
            CodeGenSyntaxVisitor cbs = new CodeGenSyntaxVisitor(syntaxTree.GetCompilationUnitRoot());
            cbs.Visit();

            var @class = SyntaxFactory.ClassDeclaration("MyGenerator")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PartialKeyword))
                .AddMembers(cbs.Generated.ToArray());

            var @namespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName("MyGenerator"))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.Collections.Generic")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.Linq")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.Text")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.Reflection")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("Microsoft.CodeAnalysis")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("Microsoft.CodeAnalysis.CSharp")))
                .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("Microsoft.CodeAnalysis.CSharp.Syntax")))
                .AddMembers(@class);

            syntaxTree = SyntaxFactory.SyntaxTree(@namespace, path: "output");

            return syntaxTree;
        }
    }

}
