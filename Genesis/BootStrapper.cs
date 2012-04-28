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
    public class BootStrapper : ReverseSyntaxVisitor
    {
        static int variableCounter = 0;
        SyntaxTree syntaxTree = null;

        List<MethodDeclarationSyntax> generated = new List<MethodDeclarationSyntax>();
        
        //Stack<ExpressionSyntax> tokenLocals = new Stack<ExpressionSyntax>();
        //Stack<SyntaxToken> tokenDebugStack = new Stack<SyntaxToken>();

        Stack<LocalDeclarationStatementSyntax> syntaxNodeLocals = new Stack<LocalDeclarationStatementSyntax>();


        public List<MethodDeclarationSyntax> Generated
        {
            get { return generated; }
            set { generated = value; }
        }

        public BootStrapper(SyntaxNode node) : base(node)
        {
            syntaxTree = SyntaxTree.Create("output", null);
        }

        protected override void VisitSyntaxNode(SyntaxNode node)
        {
            Type syntaxNodeType = node.GetType();

            

            MemberInfo[] members = syntaxNodeType.GetMembers(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance);
            GGSyntaxNode(syntaxNodeType, node);
            base.VisitSyntaxNode(node);
        }

        protected override void VisitToken(SyntaxToken token)
        {
         
            
            base.VisitToken(token);
        }


        private ExpressionSyntax CreateToken(SyntaxToken token)
        {
            
            variableCounter++;
            
            string varName = "t" + variableCounter;
            string funcName = "f" + variableCounter;

            
            ExpressionSyntax instantiateExpression;
          
            SyntaxKind literalExpressionSyntaxKind = SyntaxKind.NullLiteralExpression;
            bool createLiteral = true;
            bool createIdentifier = false;
            
            SyntaxToken literalToken = Syntax.Literal("GENERATOR_ERROR", "GENERATOR_ERROR");
            if (token.Kind == SyntaxKind.StaticKeyword)
            {

            }
            string valueText = "GENERATOR_ERROR";
            switch (token.Kind)
            {
                case SyntaxKind.CharacterLiteralToken:
                    literalExpressionSyntaxKind = SyntaxKind.CharacterLiteralExpression;
                    literalToken = Syntax.Literal(token.ValueText, (char)token.Value);
                    valueText = "\"" + EscapeString("\"" + (string)token.ValueText + "\"") + "\"";

                    break;
                case SyntaxKind.NumericLiteralToken:
                    literalExpressionSyntaxKind = SyntaxKind.NumericLiteralExpression;
                    if (token.Value is int)
                    {
                        literalToken = Syntax.Literal(token.ValueText, (int)token.Value);
                        valueText = "\"" + EscapeString((string)token.ValueText) + "\"";
                    }
                    else if (token.Value is decimal)
                    {
                        literalToken = Syntax.Literal(token.ValueText, (decimal)token.Value);
                        valueText = "\"" + EscapeString((string)token.ValueText) + "\"";
                    }
                    else if (token.Value is float)
                    {
                        literalToken = Syntax.Literal(token.ValueText, (float)token.Value);
                        valueText = "\"" + EscapeString((string)token.ValueText) + "\"";
                    }
                    else if (token.Value is long)
                    {
                        literalToken = Syntax.Literal(token.ValueText, (long)token.Value);
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

                    literalToken = Syntax.Literal(valueText, valueText);
                    
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
                
                instantiateExpression = this.Funkify(
                    Syntax.InvocationExpression(
                        Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression, Syntax.IdentifierName("Syntax"),
                            name: Syntax.IdentifierName("Identifier")),
                                Syntax.ArgumentList(arguments: Syntax.SeparatedList<ArgumentSyntax>(
                                    Syntax.Argument(expression:
                                        Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression, Syntax.Literal("\"" + EscapeString((string)token.Value) + "\"", "\"" + EscapeString((string)token.Value) + "\""))
                                            )))), Syntax.ParseTypeName("SyntaxToken"));
            }
            else if (!createLiteral)
            {
                instantiateExpression = Syntax.InvocationExpression(
                Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression, Syntax.IdentifierName("Syntax"),
                    name: Syntax.IdentifierName("Token")),
                        Syntax.ArgumentList(arguments: Syntax.SeparatedList<ArgumentSyntax>(
                            Syntax.Argument(expression:
                                Syntax.MemberAccessExpression(
                                    SyntaxKind.MemberAccessExpression,
                                    Syntax.IdentifierName("SyntaxKind"),
                                    name: Syntax.IdentifierName(token.Kind.ToString())))
                                    )));
            }
            else
            {
                
                instantiateExpression = Syntax.InvocationExpression(
                Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression, Syntax.IdentifierName("Syntax"),
                    name: Syntax.IdentifierName("Literal")),
                        Syntax.ArgumentList(arguments: Syntax.SeparatedList<ArgumentSyntax>(
                            Syntax.Argument(expression: Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression, Syntax.Literal(valueText, valueText))),
                            Syntax.Token(SyntaxKind.CommaToken),
                            Syntax.Argument(expression: Syntax.LiteralExpression(literalExpressionSyntaxKind, literalToken)))));
                
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

            string value = ((NameSyntax)node).PlainName;
            ExpressionSyntax exp = Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression, Syntax.Literal("\"" + value + "\"", value));
            arguments.Add(CreateArgument(exp));

            CreateSyntaxNode(type, "IdentifierName", arguments, separators, null);

            base.VisitIdentiferNameSyntax(node);
        }

        protected override void VisitTrivia(SyntaxTrivia trivia)
        {
            
            base.VisitTrivia(trivia);
        }

        private void GGSyntaxNode(Type type, SyntaxNode node)
        {
            List<ArgumentSyntax> arguments = new List<ArgumentSyntax>();
            List<SyntaxToken> separators = new List<SyntaxToken>();
            Type syntaxType = typeof(Syntax);
            string friendlyName = null;
          
            type = node.GetType();
            string createMethodName = GetApiCreateMethod(node.GetType());
            MethodInfo[] createMethods = syntaxType.GetMethods();
            List<MethodInfo> createMethodList = new List<MethodInfo>(createMethods);
            var miq = from m in createMethodList
                        where m.Name == createMethodName
                        orderby m.GetParameters().Count() descending
                        select m;

            MethodInfo createMethodInfo = miq.First();

            List<SyntaxNode> dependentVariableDefinitions = new List<SyntaxNode>();
            
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
                        LocalDeclarationStatementSyntax decl = this.syntaxNodeLocals.Pop();
                        if (decl.Declaration.Type.PlainName != newNode.GetType().Name)
                        {
                            throw new ApplicationException("Types do not match when popping SyntaxNode declaration stack.");
                        }

                        dependentVariableDefinitions.Add(decl);
                        string id = decl.Declaration.Variables[0].Identifier.ValueText;
                        arguments.Add(CreateArgument(Syntax.IdentifierName(id), parameterInfo.IsOptional ? parameterInfo.Name : null));

                        if (parameterInfo.Name == "identifier")
                        {
                            if (newNode is SimpleNameSyntax)
                            {
                                friendlyName = ((SimpleNameSyntax)newNode).GetFullText();
                            }
                            //parameterInfo.ParameterType.BaseType is NameSyntax 
                        } 

                    }
                    else
                    {
                        arguments.Add(CreateArgument(Syntax.LiteralExpression(SyntaxKind.NullLiteralExpression), parameterInfo.IsOptional ? parameterInfo.Name : null));
                    }
                }
                //TODO: List handling has some repeated code... potential for refactoring
                else if (parameterInfo.ParameterType.Name == "SyntaxList`1")
                {
                    IEnumerable syntaxList = (IEnumerable)type.GetProperty(newParameterName).GetValue(node, null);
                    int count = syntaxList.Cast<SyntaxNode>().Count();

                    Type[] genericTypes = parameterInfo.ParameterType.GetGenericArguments();
                    Type genericType = genericTypes[0];
                    LocalDeclarationStatementSyntax listDecl = CreateListOfType(count, genericType, genericType, dependentVariableDefinitions, false);

                    dependentVariableDefinitions.Add(listDecl);

                    CreateSyntaxNode(parameterInfo.ParameterType, string.Format("List<{0}>", genericType.Name),
                        new List<ArgumentSyntax> { CreateArgument(Syntax.IdentifierName(listDecl.Declaration.Variables[0].Identifier)) },
                        new List<SyntaxToken>(), null);

                    LocalDeclarationStatementSyntax decl = this.syntaxNodeLocals.Pop();
                    dependentVariableDefinitions.Add(decl);
                    string id = decl.Declaration.Variables[0].Identifier.ValueText;
                    arguments.Add(CreateArgument(Syntax.IdentifierName(id), parameterInfo.IsOptional ? parameterInfo.Name : null)); 
                }
                else if (parameterInfo.ParameterType.Name == "SeparatedSyntaxList`1")
                {
                    IEnumerable syntaxList = (IEnumerable)type.GetProperty(newParameterName).GetValue(node, null);
                    int count = syntaxList.Cast<SyntaxNode>().Count();

                    Type[] genericTypes = parameterInfo.ParameterType.GetGenericArguments();
                    Type genericType = genericTypes[0];
                    LocalDeclarationStatementSyntax listDecl = CreateListOfType(count, typeof(SyntaxNodeOrToken), genericType, dependentVariableDefinitions, true);

                    dependentVariableDefinitions.Add(listDecl);

                    CreateSyntaxNode(parameterInfo.ParameterType, string.Format("SeparatedList<{0}>", genericType.Name),
                        new List<ArgumentSyntax> { CreateArgument(Syntax.IdentifierName(listDecl.Declaration.Variables[0].Identifier)) },
                        new List<SyntaxToken>(), null);

                    LocalDeclarationStatementSyntax decl = this.syntaxNodeLocals.Pop();
                    dependentVariableDefinitions.Add(decl);
                    string id = decl.Declaration.Variables[0].Identifier.ValueText;
                    arguments.Add(CreateArgument(Syntax.IdentifierName(id), parameterInfo.IsOptional ? parameterInfo.Name : null)); 
                }
                else if (parameterInfo.ParameterType == typeof(SyntaxToken))
                {
                    SyntaxToken tokenValue = (SyntaxToken)type.GetProperty(newParameterName).GetValue(node, null);
                    ExpressionSyntax tokenExpr = CreateToken(tokenValue);
                    arguments.Add(CreateArgument(tokenExpr, parameterInfo.IsOptional ? parameterInfo.Name : null)); 
                }
                else if (parameterInfo.ParameterType == typeof(SyntaxTokenList))
                {
                    SyntaxTokenList syntaxTokenList = (SyntaxTokenList)type.GetProperty(newParameterName).GetValue(node, null);
                    int count = syntaxTokenList.Count;
                    List<SyntaxNodeOrToken> listInitExpressionList = new List<SyntaxNodeOrToken>();

                    for (int i = 0; i < count; i++)
                    {
                        ExpressionSyntax expressionSyntax = CreateToken(syntaxTokenList[i]);
                        listInitExpressionList.Add(expressionSyntax);
                        if (i + 1 < count)
                        {
                            listInitExpressionList.Add(Syntax.Literal(",", ","));
                        }
                    }
                    LocalDeclarationStatementSyntax listDecl = CreateListOfType(typeof(SyntaxToken), listInitExpressionList);
                    dependentVariableDefinitions.Add(listDecl);

                    CreateSyntaxNode(parameterInfo.ParameterType, "TokenList",
                        new List<ArgumentSyntax> { CreateArgument(Syntax.IdentifierName(listDecl.Declaration.Variables[0].Identifier)) },
                        new List<SyntaxToken>(), null);

                    LocalDeclarationStatementSyntax decl = this.syntaxNodeLocals.Pop();
                    dependentVariableDefinitions.Add(decl);
                    string id = decl.Declaration.Variables[0].Identifier.ValueText;
                    arguments.Add(CreateArgument(Syntax.IdentifierName(id), parameterInfo.IsOptional ? parameterInfo.Name : null)); 
                }
                else if (parameterInfo.ParameterType == typeof(SyntaxKind))
                {
                    arguments.Add(CreateArgument(Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression, 
                        Syntax.IdentifierName("SyntaxKind"), name: Syntax.IdentifierName(Enum.GetName(typeof(SyntaxKind), node.Kind))),
                        parameterInfo.IsOptional ? parameterInfo.Name : null));
                }
                else
                {
                    throw new ApplicationException("Unknown parameter to SyntaxNode creator.");
                    //System.Object value = type.GetProperty(newParameterName, BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance).GetValue(node, null);
                    //arguments.Add(CreateArgument(Syntax.LiteralExpression(SyntaxKind.StringLiteralExpression, Syntax.Literal("asdf", (string)value)), parameterInfo.IsOptional ? parameterInfo.Name : null));
                }

                //if (!(parameterInfo.ParameterType == typeof(LiteralExpressionSyntax)) && !(parameterInfo.ParameterType == typeof(SyntaxTokenList)))
                {
                    separators.Add(Syntax.Literal(",", ","));
                }
            }

            separators.RemoveAt(separators.Count - 1);
            CreateSyntaxNode(type, GetApiCreateMethod(type), arguments, separators, dependentVariableDefinitions, friendlyName);
        }


        //Create list from stack of the memeber stack of syntax node local declarations [syntaxNodeLocals]
        private LocalDeclarationStatementSyntax CreateListOfType(int count, Type genericType, Type popFilter, List<SyntaxNode> dependentVariableDefinitions, bool metaGenCommas, string friendlyName = null)
        {
            List<SyntaxNodeOrToken> listInitExpressionList = new List<SyntaxNodeOrToken>();
            //push all the objects into a generic list, which will then be a parameter to the "Syntax.SeparatedList" invocation
            for (int i = 0; i < count; i++)
            {
                LocalDeclarationStatementSyntax decl = this.syntaxNodeLocals.Pop();
                if (!IsTypeDerived(decl.Declaration.Type.PlainName, popFilter)) 
                {
                    throw new ApplicationException("Unexpected type in syntax node stack.");
                }
                dependentVariableDefinitions.Add(decl);
                listInitExpressionList.Add(Syntax.IdentifierName(decl.Declaration.Variables[0].Identifier));
                if (i + 1 < count)
                {
                    listInitExpressionList.Add(Syntax.Literal(",", ","));
                }
                if (metaGenCommas && i + 1 < count)
                {
                    listInitExpressionList.Add(CreateToken(Syntax.Token(SyntaxKind.CommaToken)));
                    listInitExpressionList.Add(Syntax.Literal(",", ","));
                }
            }
            LocalDeclarationStatementSyntax listDecl = CreateListOfType(genericType, listInitExpressionList);

            /*
            //new stuff
            variableCounter++;
            string varName = "list" + variableCounter;
            string funcName = friendlyName == null ? "f" + variableCounter : "create" + friendlyName + variableCounter;

            TypeSyntax typeSyntax = Syntax.ParseTypeName(string.Format("List<{0}>", genericType.Name));

            BlockSyntax blockSyntax = Syntax.Block(statements: Syntax.List<SyntaxNode>(
                listDecl,
                Syntax.ReturnStatement(expressionOpt: Syntax.IdentifierName(listDecl.)
            )));

            MethodDeclarationSyntax methodDef = Syntax.MethodDeclaration(modifiers: Syntax.TokenList(Syntax.Token(SyntaxKind.ProtectedKeyword), Syntax.Token(SyntaxKind.VirtualKeyword)),
                identifier: Syntax.Identifier(funcName), bodyOpt: blockSyntax, returnType: typeSyntax, parameterList: Syntax.ParameterList());
            generated.Add(methodDef);


            InvocationExpressionSyntax localVarValue = Syntax.InvocationExpression(
                    Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression, Syntax.ThisExpression(), name: Syntax.IdentifierName(funcName)), Syntax.ArgumentList());

            LocalDeclarationStatementSyntax listDecl = Syntax.LocalDeclarationStatement(declaration: Syntax.VariableDeclaration(typeSyntax,
                Syntax.SeparatedList<VariableDeclaratorSyntax>(Syntax.VariableDeclarator(Syntax.Identifier(varName), initializerOpt:
                Syntax.EqualsValueClause(value: localVarValue)
                ))));
            return listDecl;

            */

            return listDecl;
        }

        //wrap an expression in a function
        private ExpressionSyntax Funkify(ExpressionSyntax expression, TypeSyntax typeSyntax, string friendlyName = null)
        {
            variableCounter++;
            string funcName = friendlyName == null ? "f" + variableCounter : "create" + friendlyName + variableCounter;
            
            BlockSyntax blockSyntax = Syntax.Block(statements: Syntax.List<SyntaxNode>(
                Syntax.ReturnStatement(expressionOpt: expression)));

            MethodDeclarationSyntax methodDef = Syntax.MethodDeclaration(modifiers: Syntax.TokenList(Syntax.Token(SyntaxKind.ProtectedKeyword), Syntax.Token(SyntaxKind.VirtualKeyword)),
                identifier: Syntax.Identifier(funcName), bodyOpt: blockSyntax, returnType: typeSyntax, parameterList: Syntax.ParameterList());
            generated.Add(methodDef);

            InvocationExpressionSyntax localVarValue = Syntax.InvocationExpression(
                    Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression, Syntax.ThisExpression(), name: Syntax.IdentifierName(funcName)), Syntax.ArgumentList());

            return localVarValue;
        }


        private LocalDeclarationStatementSyntax CreateListOfType(Type genericType, List<SyntaxNodeOrToken> listInitExpressionList)
        {
            
            variableCounter++;
            string varName = "list" + variableCounter;
            TypeSyntax typeSyntax = Syntax.ParseTypeName(string.Format("List<{0}>", genericType.Name));

            LocalDeclarationStatementSyntax listDecl = Syntax.LocalDeclarationStatement(declaration: Syntax.VariableDeclaration(typeSyntax,
                Syntax.SeparatedList<VariableDeclaratorSyntax>(Syntax.VariableDeclarator(Syntax.Identifier(varName), initializerOpt:
                Syntax.EqualsValueClause(value:
                Syntax.ObjectCreationExpression(type: typeSyntax, initializerOpt:
                Syntax.InitializerExpression(expressions: Syntax.SeparatedList<ExpressionSyntax>(listInitExpressionList))))))));
            return listDecl;



            
        }

        private bool IsTypeDerived(string typeName, Type parentType)
        {
            bool foundType = false;
            Type typeSearch = typeof(Syntax).Assembly.GetType("Roslyn.Compilers.CSharp." + typeName);

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

        private void CreateSyntaxNode(Type type, string createMethodName, List<ArgumentSyntax> arguments, List<SyntaxToken> separators, List<SyntaxNode> dependentVariableDefinitions, string friendlyName = null)
        {
            ExpressionSyntax assignmentValue;

            variableCounter++;
            string varName = "v" + variableCounter;
            string funcName = friendlyName == null? "f" + variableCounter : "create" + friendlyName + variableCounter;
            
            TypeSyntax typeSyntax = null;
            if (type.IsGenericType)
            {
                typeSyntax = Syntax.ParseTypeName(string.Format("{0}<{1}>", type.Name.Replace("`1", string.Empty), type.GetGenericArguments()[0].Name));
            }
            else
            {
                typeSyntax = Syntax.ParseTypeName(type.FullName);
            }

            InvocationExpressionSyntax ieSyntax = Syntax.InvocationExpression(
                Syntax.MemberAccessExpression(
                kind: SyntaxKind.MemberAccessExpression,
                expression: Syntax.IdentifierName("Syntax"),
                name: Syntax.IdentifierName(createMethodName),
                operatorToken: Syntax.Token(SyntaxKind.DotToken)),
                Syntax.ArgumentList(arguments: Syntax.SeparatedList<ArgumentSyntax>(arguments.ToArray(), separators.ToArray())) // 
                );
            assignmentValue = ieSyntax;

            InvocationExpressionSyntax localVarValue = null;
            if (dependentVariableDefinitions == null)
            {
                localVarValue = ieSyntax;
            }
            else
            {
                dependentVariableDefinitions.Add(Syntax.ReturnStatement(expressionOpt: ieSyntax));
                BlockSyntax blockSyntax = Syntax.Block(statements: Syntax.List<SyntaxNode>(dependentVariableDefinitions));

                MethodDeclarationSyntax methodDef = Syntax.MethodDeclaration(modifiers: Syntax.TokenList(Syntax.Token(SyntaxKind.ProtectedKeyword), Syntax.Token(SyntaxKind.VirtualKeyword)), 
                    identifier: Syntax.Identifier(funcName), bodyOpt: blockSyntax, returnType: typeSyntax, parameterList: Syntax.ParameterList());
                generated.Add(methodDef);

                localVarValue = Syntax.InvocationExpression(
                    Syntax.MemberAccessExpression(SyntaxKind.MemberAccessExpression, Syntax.ThisExpression(), name: Syntax.IdentifierName(funcName)), Syntax.ArgumentList());
            }

            //local variable calling the node assembly function 
            LocalDeclarationStatementSyntax ldSyntax = Syntax.LocalDeclarationStatement(
                declaration: Syntax.VariableDeclaration(
                typeSyntax,
                Syntax.SeparatedList<VariableDeclaratorSyntax>(
                Syntax.VariableDeclarator(
                identifier: Syntax.Identifier(varName),
                initializerOpt: Syntax.EqualsValueClause(
                value: localVarValue
                )))));

            this.syntaxNodeLocals.Push(ldSyntax);
        }

        private static ArgumentSyntax CreateArgument(ExpressionSyntax exp, string name = null)
        {
            if (name != null)
            {
                return Syntax.Argument(
                        nameColonOpt: Syntax.NameColon(Syntax.Identifier(name)),
                        expression: exp);
            }
            else
            {
                return Syntax.Argument(expression: exp);
            }
        }

        private static string GetApiCreateMethod(Type syntaxNodeType) 
        {
            return syntaxNodeType.Name.Replace("Syntax", string.Empty);
        }

    }
}
