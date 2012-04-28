using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CodeBootStrap
{
    
    public class CodeBootStrapper : SyntaxWalker
    {
        int variableCounter = 0;
        SyntaxTree syntaxTree = null;

        public enum Hierarchy
        {
            CompilationUnit,
            Namespace,
            Type,
            Member,
            Parameter,
            Block,
            Statement,
            Expression
        }

        private struct LocationLevel
        {
            //Hierarchy is essentialy descriptive
            public Hierarchy Hierachery { get; set; }
            public int Count { get; set; }

            public LocationLevel(Hierarchy hierarchy, int count) : this()
            {
                Hierachery = hierarchy;
                Count = count;
            }

        }


        Stack<LocationLevel> location = new Stack<LocationLevel>();

        List<StatementSyntax> generated = new List<StatementSyntax>();

        public List<StatementSyntax> Generated
        {
            get { return generated; }
            set { generated = value; }
        }

        public CodeBootStrapper()
        {
            //CompilationUnitSyntax cus = new CompilationUnitSyntax();
            syntaxTree = SyntaxTree.Create("output", null);
            //SyntaxNode node = new Roslyn.Compilers.CSharp.UsingDirectiveSyntax();
            //container = Syntax.Block();
            variableCounter = 0;


        }
        public override void Visit(SyntaxNode node)
        {
            Type syntaxNodeType = node.GetType();
            MemberInfo[] members = syntaxNodeType.GetMembers(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);

            //if (!(node is CompilationUnitSyntax))
            {

                //GGSyntaxNode(generated, syntaxNodeType, node);
            }
            
            
            base.Visit(node);
        }


        protected override void VisitCompilationUnit(CompilationUnitSyntax node)
        {
            
            base.VisitCompilationUnit(node);
        }
        protected override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        {
            base.VisitAnonymousMethodExpression(node);
        }

        protected override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
        {
            base.VisitObjectCreationExpression(node);
        }
        protected override void VisitVariableDeclaration(VariableDeclarationSyntax node)
        {
            base.VisitVariableDeclaration(node);
        }


        protected override void VisitUsingDirective(UsingDirectiveSyntax node)
        {
            
            Type syntaxNodeType = node.GetType();
            MemberInfo[] members = syntaxNodeType.GetMembers(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);

            GGSyntaxNode(generated, syntaxNodeType, node);
            
            base.VisitUsingDirective(node);
        }

        protected override void VisitUsingStatement(UsingStatementSyntax node)
        {
            base.VisitUsingStatement(node);
        }



        private string GGSyntaxNode(List<StatementSyntax> generated, Type type, SyntaxNode node)
        {
            /*
            LocalDeclarationStatementSyntax fixedStatement = Syntax.LocalDeclarationStatement(
                declaration: Syntax.VariableDeclaration(
                    Syntax.ParseTypeName(type.Name),
                    Syntax.SeparatedList<VariableDeclaratorSyntax>(
                        Syntax.VariableDeclarator(
                          identifier: Syntax.Identifier("1"),
                          initializerOpt: Syntax.EqualsValueClause(
                            value: Syntax.ObjectCreationExpression(
                                type: Syntax.ParseTypeName(type.Name),
                                argumentListOpt: Syntax.ArgumentList())
              ))))
            );
            */

            //Type type = node.GetType();
            List<ArgumentSyntax> arguments = new List<ArgumentSyntax>();
            List<SyntaxToken> separators = new List<SyntaxToken>();
            Type syntaxType = typeof(Syntax);
            

            ExpressionSyntax assignmentValue;
          
            type = node.GetType();
            string createMethodName = GetApiCreateMethod(node.GetType());
            MethodInfo[] createMethods = syntaxType.GetMethods();
            List<MethodInfo> createMethodList = new List<MethodInfo>(createMethods);
            var miq = from m in createMethodList
                        where m.Name == createMethodName
                        orderby m.GetParameters().Count() descending
                        select m;

               

            MethodInfo createMethodInfo = miq.First();

            foreach (ParameterInfo parameterInfo in createMethodInfo.GetParameters())
            {
                string newParameterName = parameterInfo.Name;
                newParameterName = new string(new char[] { newParameterName[0] }).ToUpper() + newParameterName.Substring(1);


                Type typeSearch = parameterInfo.ParameterType;
                bool foundSyntaxNode = false;
                //bool foundSyntaxListNode = false;
                while (typeSearch != null)
                {
                    if (typeSearch == typeof(SyntaxNode))
                    {
                        foundSyntaxNode = true;
                    }
                    /*if (typeSearch.Name == "SyntaxList`1")
                    {
                        foundSyntaxListNode = true;
                    }*/
                    typeSearch = typeSearch.BaseType;
                }
                


                if (foundSyntaxNode)
                {
                    SyntaxNode newNode = (SyntaxNode)type.GetProperty(newParameterName).GetValue(node, null);
                    if (newNode != null)
                    {
                        string id = GGSyntaxNode(generated, parameterInfo.ParameterType, newNode);
                        arguments.Add(CreateArgument(parameterInfo, Syntax.IdentifierName(id)));
                    }
                    else
                    {
                        arguments.Add(CreateArgument(parameterInfo, Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression)));
                    }
                }
                else if (parameterInfo.ParameterType.Name == "SyntaxList`1")
                {


                }
                else if (parameterInfo.ParameterType.Name == "SeparatedSyntaxList`1")
                {

                }
                else if (parameterInfo.ParameterType == typeof(SyntaxToken))
                {
                    ExpressionSyntax exp;
                    if (node is IdentifierNameSyntax)
                    {
                        string value = ((NameSyntax)node).PlainName;
                        exp = Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression, Syntax.Literal("\"" + value + "\"", value));
                        Type instanceType = node.GetType();
                        SyntaxToken newNode = (SyntaxToken)instanceType.GetProperty(newParameterName).GetValue(node, null);
                    }
                    else
                    {
                        Type instanceType = node.GetType();

                        SyntaxToken value = (SyntaxToken)instanceType.GetProperty(newParameterName).GetValue(node, null);

                        exp = Syntax.InvocationExpression(
                            Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression, Syntax.IdentifierName("Syntax"),
                                name: Syntax.IdentifierName("Token")), 
                                    Syntax.ArgumentList( arguments: Syntax.SeparatedList<ArgumentSyntax> (
                                        Syntax.Argument( expression: 
                                            Syntax.MemberAccessExpression(
                                                SyntaxKind.MemberAccessExpression, 
                                                Syntax.IdentifierName("SyntaxKind"), 
                                                name: Syntax.IdentifierName(value.Kind.ToString()))))));

                    }
                    
                    arguments.Add(CreateArgument(parameterInfo, exp));
                }
                else if (parameterInfo.ParameterType == typeof(SyntaxTokenList))
                {

                }
                else if (parameterInfo.ParameterType == typeof(SyntaxKind))
                {
                    arguments.Add(CreateArgument(parameterInfo, Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression, 
                        Syntax.IdentifierName("SyntaxKind"), name: Syntax.IdentifierName(Enum.GetName(typeof(SyntaxKind), node.Kind)))));
                }
                else
                {
                    System.Object value = type.GetProperty(newParameterName, BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance).GetValue(node, null);
                    arguments.Add(CreateArgument(parameterInfo, Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression, Syntax.Literal("asdf", (string)value))));

                }

                if (!(parameterInfo.ParameterType == typeof(LiteralExpressionSyntax)) && !(parameterInfo.ParameterType.Name == "SyntaxList`1") && !(parameterInfo.ParameterType == typeof(SyntaxTokenList)) && !(parameterInfo.ParameterType.Name == "SeparatedSyntaxList`1"))
                {
                    separators.Add(Syntax.Literal(",", ","));
                }   
            }

            separators.RemoveAt(separators.Count - 1);
                                
            InvocationExpressionSyntax ieSyntax = Syntax.InvocationExpression(
                Syntax.MemberAccessExpression(
                kind: SyntaxKind.MemberAccessExpression,
                expression: Syntax.IdentifierName("Syntax"),
                name: Syntax.IdentifierName(GetApiCreateMethod(type)),
                operatorToken: Syntax.Token(SyntaxKind.DotToken)),
                Syntax.ArgumentList(arguments: Syntax.SeparatedList<ArgumentSyntax>(arguments.ToArray(), separators.ToArray())) // 
                );
            assignmentValue = ieSyntax;
            
            variableCounter++;
            string varName = "v" + variableCounter;
            
            LocalDeclarationStatementSyntax ldSyntax = Syntax.LocalDeclarationStatement(
                declaration: Syntax.VariableDeclaration(
                    Syntax.ParseTypeName(type.Name),
                    Syntax.SeparatedList<VariableDeclaratorSyntax>(
                        Syntax.VariableDeclarator(
                          identifier: Syntax.Identifier(varName),
                          initializerOpt: Syntax.EqualsValueClause(
                          value: assignmentValue
                          )))));

            generated.Add(ldSyntax);


            return varName;
        }


        private static ArgumentSyntax CreateArgument(ParameterInfo pi, ExpressionSyntax exp)
        {
            if (pi.IsOptional)
            {
                return Syntax.Argument(
                        nameColonOpt: Syntax.NameColon(Syntax.Identifier(pi.Name)),
                        expression: exp);
            }
            else
            {
                return Syntax.Argument(expression: exp);
            }
        }

        private static string GetApiCreateMethod(Type syntaxNodeType) 
        {
            if (syntaxNodeType == typeof(NameSyntax))
            {
                return "IdentifierName";
            }
            /*if (syntaxNodeType == typeof(StructuredTriviaSyntax))
            {
                return null;
            }*/
            /*switch (syntaxNodeType.Name) 
            {
                case "UsingDirectiveSyntax":
                    return Syntax.us

            }*/

            //Syntax.UsingDirective(
            return syntaxNodeType.Name.Replace("Syntax", string.Empty);
        }
    }


}
