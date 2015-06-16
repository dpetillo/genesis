using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Genesis
{
    public class CodeGenSyntaxVisitor : ReverseSyntaxVisitor
    {
        SyntaxTree syntaxTree = null;

        List<MemberDeclarationSyntax> generated = new List<MemberDeclarationSyntax>();
        
        Stack<ExpressionSyntax> syntaxNodeLocals = new Stack<ExpressionSyntax>();

        IdentifyingSyntaxWalker identifier = new IdentifyingSyntaxWalker();


        public List<MemberDeclarationSyntax> Generated
        {
            get { return generated; }
            set { generated = value; }
        }
        
        public CodeGenSyntaxVisitor(CompilationUnitSyntax node)
            : base(node)
        {
            syntaxTree = SyntaxFactory.SyntaxTree(node, path: "output");
            identifier.Visit(node);
        }

        protected override void VisitSyntaxNode(SyntaxNode node)
        {
            Type syntaxNodeType = node.GetType();

            MemberInfo[] members = syntaxNodeType.GetMembers(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);
            GenerateSourceSyntaxNode(syntaxNodeType, node);
            base.VisitSyntaxNode(node);
        }

        protected override void VisitToken(SyntaxToken token)
        {
         
            
            base.VisitToken(token);
        }


        private ExpressionSyntax CreateToken(string argumentName, SyntaxToken token)
        {
            
            ExpressionSyntax instantiateExpression;
          
            SyntaxKind literalExpressionSyntaxKind = SyntaxKind.NullLiteralExpression;
            bool createLiteral = true;
            bool createIdentifier = false;

            SyntaxToken literalToken = SyntaxFactory.Literal("GENERATOR_ERROR", "GENERATOR_ERROR");
            if (token.Kind() == SyntaxKind.StaticKeyword)
            {

            }
            string valueText = "GENERATOR_ERROR";
            switch (token.Kind())
            {
                case SyntaxKind.CharacterLiteralToken:
                    literalExpressionSyntaxKind = SyntaxKind.CharacterLiteralExpression;
                    literalToken = SyntaxFactory.Literal(token.ValueText, (char)token.Value);
                    valueText = "\"" + EscapeString("\"" + (string)token.ValueText + "\"") + "\"";

                    break;
                case SyntaxKind.NumericLiteralToken:
                    literalExpressionSyntaxKind = SyntaxKind.NumericLiteralExpression;
                    if (token.Value is int)
                    {
                        literalToken = SyntaxFactory.Literal(token.ValueText, (int)token.Value);
                        valueText = "\"" + EscapeString((string)token.ValueText) + "\"";
                    }
                    else if (token.Value is decimal)
                    {
                        literalToken = SyntaxFactory.Literal(token.ValueText, (decimal)token.Value);
                        valueText = "\"" + EscapeString((string)token.ValueText) + "\"";
                    }
                    else if (token.Value is float)
                    {
                        literalToken = SyntaxFactory.Literal(token.ValueText, (float)token.Value);
                        valueText = "\"" + EscapeString((string)token.ValueText) + "\"";
                    }
                    else if (token.Value is long)
                    {
                        literalToken = SyntaxFactory.Literal(token.ValueText, (long)token.Value);
                        valueText = "\"" + EscapeString((string)token.ValueText) + "\"";
                    }
                    else
                    {
                        throw new ApplicationException("Unknown NumericLiteralToken.");
                    }
                    
                    break;
                case SyntaxKind.StringLiteralToken:
                    literalExpressionSyntaxKind = SyntaxKind.StringLiteralExpression;

                    valueText = "\"" + EscapeString("\"" + EscapeString((string)token.ValueText) + "\"") + "\"";

                    literalToken = SyntaxFactory.Literal(valueText, valueText);
                    
                    break;
                case SyntaxKind.IdentifierToken:
                    createIdentifier = true;
                    break;
                default:
                    createLiteral = false;
                    break;
            }
            if (createIdentifier)
            {

                instantiateExpression = this.Funcify(identifier.GetId(token) + "_" + argumentName,
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.IdentifierName("SyntaxFactory"),
                            name: SyntaxFactory.IdentifierName("Identifier")),
                                SyntaxFactory.ArgumentList(arguments: SyntaxFactory.SeparatedList<ArgumentSyntax>().Add(
                                    SyntaxFactory.Argument(expression:
                                        SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("\"" + EscapeString((string)token.Value) + "\"", "\"" + EscapeString((string)token.Value) + "\""))
                                            )))), SyntaxFactory.ParseTypeName("SyntaxToken"));
            }
            else if (!createLiteral)
            {
                instantiateExpression = SyntaxFactory.InvocationExpression(
                SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.IdentifierName("SyntaxFactory"),
                    name: SyntaxFactory.IdentifierName("Token")),
                        SyntaxFactory.ArgumentList(arguments: SyntaxFactory.SeparatedList<ArgumentSyntax>().Add(
                            SyntaxFactory.Argument(expression:
                                SyntaxFactory.MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    SyntaxFactory.IdentifierName("SyntaxKind"),
                                    name: SyntaxFactory.IdentifierName(token.Kind().ToString())))
                                    )));
            }
            else
            {
                
                instantiateExpression = SyntaxFactory.InvocationExpression(
                SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.IdentifierName("SyntaxFactory"),
                    name: SyntaxFactory.IdentifierName("Literal")),
                        SyntaxFactory.ArgumentList(arguments: SyntaxFactory.SeparatedList<ArgumentSyntax>()
                            .Add(SyntaxFactory.Argument(expression: SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(valueText, valueText))))
                            .Add(SyntaxFactory.Argument(expression: SyntaxFactory.LiteralExpression(literalExpressionSyntaxKind, literalToken)))
                            ));
                
            }
            return instantiateExpression;
        }

        private static string EscapeString(string input)
        {

            return input.Replace(@"\", @"\\").Replace("\"", @"\""");
        }

        protected override void VisitIdentiferNameSyntax(IdentifierNameSyntax node)
        {
            Type type = node.GetType();
            List<ArgumentSyntax> arguments = new List<ArgumentSyntax>();
            List<SyntaxToken> separators = new List<SyntaxToken>();

            string value = ((NameSyntax)node).ToString();
            ExpressionSyntax exp = SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("\"" + value + "\"", value));
            arguments.Add(CreateArgument(exp));

            BuildSyntaxNode(identifier.GetId(node), type, "IdentifierName", arguments, separators, null);

            base.VisitIdentiferNameSyntax(node);
        }

        protected override void VisitTrivia(SyntaxTrivia trivia)
        {
            
            base.VisitTrivia(trivia);
        }

        private void GenerateSourceSyntaxNode(Type type, SyntaxNode node)
        {
            List<ArgumentSyntax> arguments = new List<ArgumentSyntax>();
            List<SyntaxToken> separators = new List<SyntaxToken>();
            Type syntaxType = typeof(SyntaxFactory);

            string nodeId = identifier.GetId(node);
          
            type = node.GetType();
            string createMethodName = GetApiCreateMethod(node.GetType());
            MethodInfo[] createMethods = syntaxType.GetMethods();
            List<MethodInfo> createMethodList = new List<MethodInfo>(createMethods);
            var miq = from m in createMethodList
                        where m.Name == createMethodName
                        orderby m.GetParameters().Count() descending
                        select m;

            MethodInfo createMethodInfo = miq.First();

            List<ExpressionSyntax> dependentVariableDefinitions = new List<ExpressionSyntax>();

            foreach (ParameterInfo parameterInfo in createMethodInfo.GetParameters())
            {
                
                string newParameterName = parameterInfo.Name;
                newParameterName = new string(new char[] { newParameterName[0] }).ToUpper() + newParameterName.Substring(1);

                Type typeSearch = parameterInfo.ParameterType;
                
                

                //determine if node is derived from type "SyntaxNode"
                bool foundSyntaxNode = false;
                while (typeSearch != null)
                {
                    if (typeSearch == typeof(SyntaxNode))
                    {
                        foundSyntaxNode = true;
                    }
                    typeSearch = typeSearch.BaseType;
                }
                

                if (foundSyntaxNode)
                {
                    SyntaxNode newNode = (SyntaxNode)type.GetProperty(newParameterName).GetValue(node, null);
                    if (newNode != null)
                    {
                        ExpressionSyntax decl = this.syntaxNodeLocals.Pop();
                        /*if (decl.Declaration.Type.PlainName != newNode.GetType().Name)
                        {
                            throw new ApplicationException("Types do not match when popping SyntaxNode declaration stack.");
                        }*/

                        dependentVariableDefinitions.Add(decl);
                        arguments.Add(CreateArgument(decl, parameterInfo.IsOptional ? parameterInfo.Name : null));

                        if (parameterInfo.Name == "identifier")
                        {
                            if (newNode is SimpleNameSyntax)
                            {
                                //friendlyName = ((SimpleNameSyntax)newNode).GetFullText();
                            }
                            //parameterInfo.ParameterType.BaseType is NameSyntax 
                        } 

                    }
                    else
                    {
                        arguments.Add(CreateArgument(SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression), parameterInfo.IsOptional ? parameterInfo.Name : null));
                    }
                }
                //TODO: List handling has some repeated code... potential for refactoring
                else if (parameterInfo.ParameterType.Name == "SyntaxList`1")
                {
                    IEnumerable syntaxList = (IEnumerable)type.GetProperty(newParameterName).GetValue(node, null);
                    int count = syntaxList.Cast<SyntaxNode>().Count();

                    Type[] genericTypes = parameterInfo.ParameterType.GetGenericArguments();
                    Type genericType = genericTypes[0];
                    
                    string typeName = string.Format("List<{0}>", genericType.Name);

                    ExpressionSyntax listDecl = Funcify(nodeId + "_" + parameterInfo.Name, CreateListOfType(count, genericType, genericType, dependentVariableDefinitions, false), SyntaxFactory.ParseTypeName(typeName));

                    dependentVariableDefinitions.Add(listDecl);


                    BuildSyntaxNode("pwrap" + parameterInfo.Name, parameterInfo.ParameterType, typeName,
                        new List<ArgumentSyntax> { CreateArgument(listDecl) },
                        new List<SyntaxToken>(), null);

                    ExpressionSyntax decl = this.syntaxNodeLocals.Pop();
                    dependentVariableDefinitions.Add(decl);
                    arguments.Add(CreateArgument(decl, parameterInfo.IsOptional ? parameterInfo.Name : null)); 
                }
                else if (parameterInfo.ParameterType.Name == "SeparatedSyntaxList`1")
                {
                    IEnumerable syntaxList = (IEnumerable)type.GetProperty(newParameterName).GetValue(node, null);
                    int count = syntaxList.Cast<SyntaxNode>().Count();

                    Type[] genericTypes = parameterInfo.ParameterType.GetGenericArguments();
                    Type genericType = genericTypes[0];

                    ExpressionSyntax listDecl = Funcify(nodeId + "_" + parameterInfo.Name, CreateListOfType(count, typeof(SyntaxNodeOrToken), genericType, dependentVariableDefinitions, true), SyntaxFactory.ParseTypeName("List<SyntaxNodeOrToken>"));

                    dependentVariableDefinitions.Add(listDecl);

                    BuildSyntaxNode(nodeId, parameterInfo.ParameterType, string.Format("SeparatedList<{0}>", genericType.Name),
                        new List<ArgumentSyntax> { CreateArgument(listDecl) },
                        new List<SyntaxToken>(), null);

                    ExpressionSyntax decl = this.syntaxNodeLocals.Pop();
                    dependentVariableDefinitions.Add(decl);
                    arguments.Add(CreateArgument(decl, parameterInfo.IsOptional ? parameterInfo.Name : null)); 
                }
                else if (parameterInfo.ParameterType == typeof(SyntaxToken))
                {
                    SyntaxToken tokenValue = (SyntaxToken)type.GetProperty(newParameterName).GetValue(node, null);
                    ExpressionSyntax tokenExpr = CreateToken(parameterInfo.Name, tokenValue);
                    arguments.Add(CreateArgument(tokenExpr, parameterInfo.IsOptional ? parameterInfo.Name : null)); 
                }
                else if (parameterInfo.ParameterType == typeof(SyntaxTokenList))
                {
                    SyntaxTokenList syntaxTokenList = (SyntaxTokenList)type.GetProperty(newParameterName).GetValue(node, null);
                    int count = syntaxTokenList.Count;
                    List<SyntaxNodeOrToken> listInitExpressionList = new List<SyntaxNodeOrToken>();

                    for (int i = 0; i < count; i++)
                    {
                        ExpressionSyntax expressionSyntax = CreateToken(parameterInfo.Name, syntaxTokenList[i]);
                        listInitExpressionList.Add(expressionSyntax);
                        if (i + 1 < count)
                        {
                            listInitExpressionList.Add(SyntaxFactory.Literal(",", ","));
                        }
                    }

                    string typeName = string.Format("List<{0}>", typeof(SyntaxToken).ToString());

                    ExpressionSyntax listDecl = Funcify(nodeId + "_" + parameterInfo.Name, CreateListOfType(typeof(SyntaxToken), listInitExpressionList), SyntaxFactory.ParseTypeName(typeName));
                    dependentVariableDefinitions.Add(listDecl);

                    BuildSyntaxNode(nodeId, parameterInfo.ParameterType, "TokenList",
                        new List<ArgumentSyntax> { CreateArgument( listDecl ) },
                        new List<SyntaxToken>(), null);

                    ExpressionSyntax decl = this.syntaxNodeLocals.Pop();
                    dependentVariableDefinitions.Add(decl);
                    arguments.Add(CreateArgument(decl, parameterInfo.IsOptional ? parameterInfo.Name : null)); 
                }
                else if (parameterInfo.ParameterType == typeof(SyntaxKind))
                {
                    arguments.Add(CreateArgument(SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, 
                        SyntaxFactory.IdentifierName("SyntaxKind"), name: SyntaxFactory.IdentifierName(Enum.GetName(typeof(SyntaxKind), node.Kind()))),
                        parameterInfo.IsOptional ? parameterInfo.Name : null));
                }
                else
                {
                    throw new ApplicationException("Unknown parameter to SyntaxNode creator.");
                    //System.Object value = type.GetProperty(newParameterName, BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance).GetValue(node, null);
                    //arguments.Add(CreateArgument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("asdf", (string)value)), parameterInfo.IsOptional ? parameterInfo.Name : null));
                }

                //if (!(parameterInfo.ParameterType == typeof(LiteralExpressionSyntax)) && !(parameterInfo.ParameterType == typeof(SyntaxTokenList)))
                {
                    separators.Add(SyntaxFactory.Literal(",", ","));
                }
            }

            separators.RemoveAt(separators.Count - 1);
            BuildSyntaxNode(nodeId, type, GetApiCreateMethod(type), arguments, separators, dependentVariableDefinitions);
        }


        //Create list from stack of the memeber stack of syntax node local declarations [syntaxNodeLocals]
        private ExpressionSyntax CreateListOfType(int count, Type genericType, Type popFilter, List<ExpressionSyntax> dependentVariableDefinitions, bool metaGenCommas)
        {
            List<SyntaxNodeOrToken> listInitExpressionList = new List<SyntaxNodeOrToken>();
            //push all the objects into a generic list, which will then be a parameter to the "SyntaxFactory.SeparatedList" invocation
            for (int i = 0; i < count; i++)
            {
                ExpressionSyntax decl = this.syntaxNodeLocals.Pop();
                /*if (!IsTypeDerived(decl.Declaration.Type.PlainName, popFilter)) 
                {
                    throw new ApplicationException("Unexpected type in syntax node stack.");
                }*/
                dependentVariableDefinitions.Add(decl);
                listInitExpressionList.Add(decl);
                if (i + 1 < count)
                {
                    listInitExpressionList.Add(SyntaxFactory.Literal(",", ","));
                }
                if (metaGenCommas && i + 1 < count)
                {
                    listInitExpressionList.Add(CreateToken(null, SyntaxFactory.Token(SyntaxKind.CommaToken)));
                    listInitExpressionList.Add(SyntaxFactory.Literal(",", ","));
                }
            }
            ExpressionSyntax listDecl = CreateListOfType(genericType, listInitExpressionList);

            return listDecl;
        }



        private ExpressionSyntax CreateListOfType( Type genericType, List<SyntaxNodeOrToken> listInitExpressionList)
        {
            TypeSyntax typeSyntax = SyntaxFactory.ParseTypeName(string.Format("List<{0}>", genericType.Name));

            return SyntaxFactory.ObjectCreationExpression(type: typeSyntax, argumentList: null, initializer:
                SyntaxFactory.InitializerExpression(SyntaxKind.ObjectInitializerExpression , expressions: SyntaxFactory.SeparatedList<ExpressionSyntax>(listInitExpressionList)));
        }


        //wrap an expression in a function
        private InvocationExpressionSyntax Funcify(string funcName, ExpressionSyntax expression, TypeSyntax typeSyntax)
        {
            BlockSyntax blockSyntax = SyntaxFactory.Block(statements: SyntaxFactory.List<SyntaxNode>().Add(
                SyntaxFactory.ReturnStatement(expression: expression)));

            return Funcify(funcName, blockSyntax, typeSyntax);
        }
        //wrap a block in a function
        private InvocationExpressionSyntax Funcify(string funcName, BlockSyntax block, TypeSyntax typeSyntax)
        {

            MethodDeclarationSyntax methodDef = SyntaxFactory.MethodDeclaration(typeSyntax, funcName)
                .AddBodyStatements(block);
            
            if (funcName != "Ast_CompilationUnit")
            {
                methodDef = methodDef.AddModifiers(SyntaxFactory.Token(SyntaxKind.ProtectedKeyword));
            }
            else
            {
                methodDef = methodDef.AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));
            }

            methodDef = methodDef.AddModifiers(SyntaxFactory.Token(SyntaxKind.VirtualKeyword));


            generated.Add(methodDef);
            
            InvocationExpressionSyntax localVarValue = SyntaxFactory.InvocationExpression(
                    SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, SyntaxFactory.ThisExpression(), name: SyntaxFactory.IdentifierName(funcName)), SyntaxFactory.ArgumentList());

            return localVarValue;
        }

        private bool IsTypeDerived(string typeName, Type parentType)
        {
            bool foundType = false;
            Type typeSearch = typeof(SyntaxFactory).Assembly.GetType("" + typeName);

            if (typeSearch == null)
            {
                throw new ApplicationException(string.Format("Could not find the type {0}", typeName));
            }

            while (typeSearch != null)
            {
                if (typeSearch == parentType)
                {
                    foundType = true;
                }
                typeSearch = typeSearch.BaseType;
            }
            return foundType;
        }

        private void BuildSyntaxNode(string nodeId, Type type, string createMethodName, List<ArgumentSyntax> arguments, List<SyntaxToken> separators, List<ExpressionSyntax> dependentVariableDefinitions)
        {
            ExpressionSyntax assignmentValue;

            TypeSyntax typeSyntax = null;
            if (type.IsGenericType)
            {
                typeSyntax = SyntaxFactory.ParseTypeName(string.Format("{0}<{1}>", type.Name.Replace("`1", string.Empty), type.GetGenericArguments()[0].Name));
            }
            else
            {
                typeSyntax = SyntaxFactory.ParseTypeName(type.FullName);
            }

            InvocationExpressionSyntax ieSyntax = SyntaxFactory.InvocationExpression(
                SyntaxFactory.MemberAccessExpression(
                kind: SyntaxKind.SimpleMemberAccessExpression,
                expression: SyntaxFactory.IdentifierName("SyntaxFactory"),
                name: SyntaxFactory.IdentifierName(createMethodName),
                operatorToken: SyntaxFactory.Token(SyntaxKind.DotToken)),
                SyntaxFactory.ArgumentList(arguments: SyntaxFactory.SeparatedList<ArgumentSyntax>(arguments.ToArray(), separators.ToArray())) // 
                );
            assignmentValue = ieSyntax;

            InvocationExpressionSyntax localVarValue = null;
            if (dependentVariableDefinitions == null)
            {
                localVarValue = ieSyntax;
            }
            else
            {
                BlockSyntax blockSyntax = SyntaxFactory.Block(statements: SyntaxFactory.List<SyntaxNode>().Add(SyntaxFactory.ReturnStatement(expression: ieSyntax)));

                localVarValue = Funcify(nodeId, blockSyntax, typeSyntax);
            }

            this.syntaxNodeLocals.Push(localVarValue);
        }

        private static ArgumentSyntax CreateArgument(ExpressionSyntax exp, string name = null)
        {
            if (name != null)
            {
                return SyntaxFactory.Argument(
                        nameColon: SyntaxFactory.NameColon(name),
                        refOrOutKeyword: SyntaxFactory.Token(SyntaxKind.None),
                        expression: exp);
            }
            else
            {
                return SyntaxFactory.Argument(expression: exp);
            }
        }

        private static string GetApiCreateMethod(Type syntaxNodeType) 
        {
            return syntaxNodeType.Name.Replace("Syntax", string.Empty);
        }

    }
}
