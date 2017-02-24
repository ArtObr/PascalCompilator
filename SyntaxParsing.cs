using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathLang.CodeGen;

namespace MathLang.Semantics
{
    class SyntaxParsing
    {
        
        public static DataType strToDataType(string type)
        {
            switch (type)
            {
                case "array":
                    return DataType.Array;
                case "integer":
                    return DataType.Integer;
                case "double":
                    return DataType.Real;
                case "boolean":
                    return DataType.Bool;
                case "VOID":
                case "":
                    return DataType.Void;
                default:
                    throw new ApplicationException("Invalid data type");
            }
        }

        public static string dataTypeToStr(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Array:
                    return "array";
                case DataType.Integer:
                    return "int";
                case DataType.Real:
                    return "double";
                case DataType.Bool:
                    return "bool";
                case DataType.Void:
                    return "void";
                default:
                    return "unknown";
            }
        }

        private static void convert(NodeData node, DataType dataType)
        {
            NodeData convert = new NodeData(new Antlr.Runtime.CommonToken(MathLangLexer.CALL, "CONVERT"));
            node.Parent.SetChild(node.ChildIndex, convert);
            convert.DataType = dataType;
            convert.AddChild(node);
            convert.AddChild(new NodeData(new Antlr.Runtime.CommonToken(MathLangLexer.IDENT, dataTypeToStr(dataType))));
        }
        //------------------

        public SyntaxParsing(NodeData Node)
        {
            FirstNode = Node;
            //Check();
        }

        public void Check()
        {
            RecCheck(FirstNode, null);
        }
        NodeData FirstNode;
        string ProgramName;
        private void CheckNode(NodeData node, Context context, int start = 0)
        {
            for (int i = start; i < node.ChildCount; i++)
                RecCheck((NodeData)node.GetChild(i), context);
        }

        private DataType RecCheck(NodeData node, Context context)
        {
            switch (node.Type)
            {
                case MathLangLexer.PROGRAM:
                    return CheckProgram(node, context);
                case MathLangLexer.DECL:
                case MathLangLexer.BLOCK:
                    return Check_Decl_Block(node, context);
                case MathLangLexer.CONST_DECL:
                    return CheckConstant(node, context);
                case MathLangLexer.VAR_DECL:
                    return CheckVar(node, context, 0);




                case MathLangLexer.FUNC_DECL:
                    return CheckFunction_Procedure(node, context);
                case MathLangLexer.PROC_DECL:
                    return CheckFunction_Procedure(node, context, false);





                case MathLangLexer.ASSIGN:
                    return CheckAssign(node, context);
                case MathLangLexer.IDENT:
                    return CheckIdent(node, context);
                case MathLangLexer.NUMBER:
                    return CheckNumber(node, context);
                case MathLangLexer.TRUE:
                case MathLangLexer.FALSE:
                    return CheckBool(node, context);
                case MathLangLexer.OR:
                case MathLangLexer.AND:
                    return Check_And_Or(node, context);
                case MathLangLexer.MUL:
                case MathLangLexer.DIVIS:
                case MathLangLexer.ADD:
                case MathLangLexer.SUB:
                case MathLangLexer.DIV:
                case MathLangLexer.MOD:

                case MathLangLexer.GE:
                case MathLangLexer.LE:
                case MathLangLexer.NEQUALS:
                case MathLangLexer.EQUALS:
                case MathLangLexer.GT:
                case MathLangLexer.LT:
                    return CheckOperations(node, context);
                case MathLangLexer.ARRAY:
                    return CheckArray(node, context);



                case MathLangLexer.CALL:
                    return CheckCall(node, context);



                case MathLangLexer.NOT:
                    return CheckNot(node, context);
                case MathLangLexer.IF:
                    return CheckIf(node, context);
                case MathLangLexer.THEN:
                case MathLangLexer.ELSE:
                    return Check_Decl_Block(node, context);

                case MathLangLexer.FOR:
                    context = new Context(context);
                    return Check_Decl_Block(node, context);
                case MathLangLexer.FROM:
                    return CheckFrom(node, context);
                case MathLangLexer.TO:
                    return CheckTo(node, context);
                case MathLangLexer.DO:
                    return Check_Decl_Block(node, context);

                case MathLangLexer.WRITE:
                case MathLangLexer.WRITELN:
                    return CheckWrite(node, context);

                case MathLangLexer.READ:
                case MathLangLexer.READLN:
                    return CheckRead(node, context);
            }
            return new DataType();
        }

        private string FormatOutput(Ident ident)
        {
            return "_" + ident.Number + "_" + ident.DataType + "_" + ident.IdentType;
        }
        private string FormatArrayOutput(Ident ident)
        {
            return "_" + ident.Number + "_" + ident.DataType + "_" + ident.IdentType +
                 "_" + ident.ElementData + "_" + ident.from + "_" + ident.to;
        }
        private DataType CheckProgram(NodeData node, Context context)
        {
            if (context == null)
                context = new Context(context);
            ProgramName = node.GetChild(0).ToString();
            CheckNode(node, context, 1);
            return DataType.Void;
        }

        private DataType Check_Decl_Block(NodeData node, Context context)
        {
            //context = new Context(context);
            CheckNode(node, context);
            return DataType.Void;
        }

        private DataType CheckConstant(NodeData node, Context context)
        {

            for (int i = 0; i < node.ChildCount; i++)
            {
                string name = node.GetChild(i).GetChild(0).Text;
                Ident ident = context.InThisContext(name);
                if (ident != null)
                    throw new ApplicationException(string.Format("Identifier {0} already exists", name));

                DataType dt = DataType.Void;
                string value = node.GetChild(i).GetChild(1).Text;
                double d = 0;
                if (double.TryParse(value, out d))
                {
                    if (value.Contains("."))
                        dt = DataType.Real;
                    else
                        dt = DataType.Integer;
                }
                else
                    if (value == "true" || value == "false")
                    dt = DataType.Bool;
                context[name] = new Ident(name, IdentType.GlobalVar, dt, context.countLocal++);
                ((NodeData)node.GetChild(i).GetChild(0)).Text += FormatOutput(context[name]);

            }
            return DataType.Void;
        }

        private DataType CheckVar(ITree node, Context context, int start = 0)
        {
            for (int i = start; i < node.ChildCount; i++)
            {
                CheckVarList(node.GetChild(i), context, strToDataType(node.GetChild(i).Text));
            }
            return DataType.Void;
        }
        private void CheckVarList(ITree node, Context context, DataType type)
        {
            //int LocalCount = 0;
            for (int i = 0; i < node.ChildCount; i++)
            {
                string name = node.GetChild(i).Text;
                Ident ident = context.InThisContext(name);
                if (ident != null)
                    throw new ApplicationException(string.Format("Identifier {0} already exists", name));
                context[name] = new Ident(name, ((context.ParentContext == null) ?
                       IdentType.GlobalVar : IdentType.LocalVar)
                  , type, context.countLocal++);
                if (type != DataType.Array)
                {
                    ((NodeData)node.GetChild(i)).Text += FormatOutput(context[name]);
                }
                else
                {
                    context[name].ElementData = strToDataType(node.GetChild(i).GetChild(0).Text);
                    context[name].from = int.Parse(node.GetChild(i).GetChild(1).Text);
                    context[name].to = int.Parse(node.GetChild(i).GetChild(1).GetChild(0).Text);
                    ((NodeData)node.GetChild(i)).Text += FormatArrayOutput(context[name]);
                }
            }
        }

        private void CheckParamList(ITree node, Context context, DataType type, ref int a)
        {
            //int LocalCount = 0;
            for (int i = 0; i < node.ChildCount; i++)
            {
                a++;
                string name = node.GetChild(i).Text;
                Ident ident = context.InThisContext(name);
                if (ident != null)
                    throw new ApplicationException(string.Format("Identifier {0} already exists", name));
                context[name] = new Ident(name, IdentType.Param
                    , type, context.countLocal++);
                if (type != DataType.Array)
                    ((NodeData)node.GetChild(i)).Text += FormatOutput(context[name]);
            }
        }

        private DataType CheckFunction_Procedure(NodeData node, Context context, bool function = true)
        {
            string name = node.GetChild(0).Text;
            Ident ident = context.InThisContext(name);
            
            if (ident != null)
                throw new ApplicationException(string.Format("Identifier {0} already exists", name));

            context[name] = new Ident(name, function ? IdentType.Function : IdentType.Procedure, function ? strToDataType(node.GetChild(1).Text)
                : DataType.Void, context.countLocal++);
            ((NodeData)node.GetChild(0)).Text += FormatOutput(context[name]);

            context = new Context(context);

            //context[name] = new Ident(name, function ? IdentType.Function : IdentType.Procedure, function ? strToDataType(node.GetChild(1).Text)
            //    : DataType.Void, context.countLocal++);

            bool a = true;
            int count = 0;
            for (int i = function ? 2 : 1; i < node.ChildCount; i++)
            {
                if (a)
                {
                    CheckParamList(node.GetChild(i), context, strToDataType(node.GetChild(i).Text), ref count);
                    if (node.GetChild(i + 1).Text == "var") a = false;
                }
                else
                {
                    context = new Context(context);
                    context[name].ParamCount = count;
                    context.ParentContext[name].ParamCount = count;
                    context.ParentContext.ParentContext[name].ParamCount = count;
                    context[name] = new Ident(name, function ? IdentType.Function : IdentType.Procedure, function ? strToDataType(node.GetChild(1).Text)
               : DataType.Void, context.countLocal++);
                    RecCheck((NodeData)node.GetChild(i), context);
                }

            }
            
            return function ? context[name].DataType : DataType.Void;
        }

        private DataType CheckAssign(NodeData node, Context context)
        {
            Ident ident = context[node.GetChild(0).Type == MathLangLexer.ARRAY ?
                node.GetChild(0).GetChild(0).Text : node.GetChild(0).Text];
            if (ident == null)
                throw new ApplicationException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
            
            DataType leftDataType = RecCheck((NodeData)node.GetChild(0), context);
            DataType rightDataType = RecCheck((NodeData)node.GetChild(1), context);
            if (leftDataType != rightDataType)
            {
                if (leftDataType == DataType.Real && rightDataType == DataType.Integer)
                    convert((NodeData)node.GetChild(1), DataType.Real);
                else
                    throw new ApplicationException(string.Format("Assign incopotible types {0} {1}",
                        dataTypeToStr(ident.DataType), dataTypeToStr(rightDataType)));
            }
            ((NodeData)node).Text += ";" + ident.DataType.ToString();
            return DataType.Void;

        }



        private DataType CheckIdent(NodeData node, Context context)
        {
            Ident ident = context[node.Text];
            if (ident == null)
                throw new ApplicationException(string.Format("Unknown identifier {0}", node.Text));
            node.DataType = ident.DataType;
            if (ident.DataType == DataType.Array) return CheckArray(node, context);
            ((NodeData)node).Text += FormatOutput(ident);
            return ident.DataType;
        }

        private DataType CheckArray(NodeData node, Context context)
        {
            Ident ident = context[node.Text];
            if (ident == null)
                throw new ApplicationException(string.Format("Unknown identifier {0}", node.Text));
            int s;
            if (int.TryParse(node.GetChild(0).Text, out s))
            {
                if (s < ident.from
                    || s > ident.to)
                    throw new Exception("Index out of borders");
            }
            else
            {
                RecCheck((NodeData)(node.GetChild(0)), context);
                Rec((NodeData)node.GetChild(0), ident.from);
                //((NodeData)node.GetChild(0)).Text += ":" + ident.from;
                //((NodeData)node.GetChild(0)).Text += FormatOutput(context[node.GetChild(0).Text]);
            }


            ((NodeData)node).Text += FormatArrayOutput(ident);
            return ident.DataType == DataType.Array ? ident.ElementData : ident.DataType;
        }

        private void Rec(NodeData node, int from)
        {
            ((NodeData)node).Text += "_" + from;
            for (int a = 0; a < node.ChildCount; a++)
            {
                if (node.GetChild(a).Type == MathLangParser.IDENT)
                    Rec((NodeData)node.GetChild(a), from);
            }
        }
        private DataType Check_And_Or(NodeData node, Context context)
        {
            DataType leftDataType = RecCheck((NodeData)node.GetChild(0), context);
            DataType rightDataType = RecCheck((NodeData)node.GetChild(1), context);
            if (leftDataType != DataType.Bool && rightDataType != DataType.Bool)
                throw new ApplicationException(string.Format("{0} operator with type {1}, {2}", node.Text, dataTypeToStr(leftDataType), dataTypeToStr(rightDataType)));
            node.DataType = DataType.Bool;
            return node.DataType;
        }

        //calculate
        //double a = 0;
        //        if (leftDataType == DataType.Const && double.TryParse(ident.Node.GetChild(1).Text,out a) )
        //        {

        //        }

        //Numbers

        private DataType CheckNumber(NodeData node, Context context)
        {
            node.DataType = node.Text.Contains(".") ? DataType.Real : DataType.Integer;
            return node.DataType;
        }

        private DataType CheckBool(NodeData node, Context context)
        {
            node.DataType = DataType.Bool;
            ((NodeData)node).Text += FormatOutput(new Ident("", IdentType.LocalVar, DataType.Bool, -1));
            return node.DataType;
        }

        private DataType CheckOperations(NodeData node, Context context)
        {
            bool compareOperation = true;
            switch (node.Type)
            {
                case MathLangLexer.ADD:
                case MathLangLexer.SUB:
                case MathLangLexer.MUL:
                case MathLangLexer.DIV:
                case MathLangLexer.DIVIS:
                case MathLangLexer.MOD:
                    compareOperation = false;
                    break;
            }

            DataType leftDataType = RecCheck((NodeData)node.GetChild(0), context);
            DataType rightDataType = RecCheck((NodeData)node.GetChild(1), context);
            if (leftDataType != DataType.Real && leftDataType != DataType.Integer)
                throw new ApplicationException(string.Format("Left operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
            if (rightDataType != DataType.Real && rightDataType != DataType.Integer)
                throw new ApplicationException(string.Format("Right operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
            if (leftDataType == DataType.Real)
            {
                if (rightDataType == DataType.Integer)
                    convert((NodeData)node.GetChild(1), DataType.Real);
                node.DataType = compareOperation ? DataType.Bool : DataType.Real;
                return node.DataType;
            }
            if (rightDataType == DataType.Real)
            {
                if (leftDataType == DataType.Integer)
                    convert((NodeData)node.GetChild(0), DataType.Real);
                node.DataType = compareOperation ? DataType.Bool : DataType.Real;
                return node.DataType;
            }
            node.DataType = compareOperation ? DataType.Bool : DataType.Integer;
            Ident id = new Ident("", IdentType.Function, leftDataType, -1);
            id.ElementData = leftDataType;
            ((NodeData)node).Text += FormatArrayOutput(id);
            return node.DataType;
        }

        private DataType CheckCall(NodeData node, Context context)
        {
            Ident ident = context[node.GetChild(0).Text];
            if (ident == null)
                throw new ApplicationException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
            if (ident.IdentType != IdentType.Function && ident.IdentType != IdentType.Procedure)
                throw new ApplicationException(string.Format("Identifier {0} is not function or procedure", node.GetChild(0).Text));
            if (node.GetChild(1).ChildCount != ident.ParamCount)
                throw new ApplicationException(string.Format("Not equals params count in function or procedure {0}", node.GetChild(0).Text));

            for (int i = 0; i < node.GetChild(1).ChildCount; i++)
                RecCheck((NodeData)node.GetChild(1).GetChild(i), context);
            ((NodeData)node.GetChild(0)).Text += FormatOutput(ident);
            return ident.DataType;
        }

        private DataType CheckNot(NodeData node, Context context)
        {
            DataType dataType = RecCheck((NodeData)node.GetChild(0), context);
            if (dataType != DataType.Bool)
                throw new ApplicationException(string.Format("Not operator with type {0}", dataTypeToStr(dataType)));
            node.DataType = DataType.Bool;
            return node.DataType;
        }
        private DataType CheckIf(NodeData node, Context context)
        {
            DataType condDataType = RecCheck((NodeData)node.GetChild(0), context);
            if (condDataType != DataType.Bool)
                throw new ApplicationException(string.Format("In if condition type is {0}", dataTypeToStr(condDataType)));
            // context = new Context(context);
            RecCheck((NodeData)node.GetChild(1), context);
            if (node.ChildCount == 3)
                RecCheck((NodeData)node.GetChild(2), context);
            return DataType.Void;
        }

        private DataType CheckFrom(NodeData node, Context context)
        {
            if (node.GetChild(0).Type == MathLangLexer.ASSIGN)
            {

                if (context[node.GetChild(0).GetChild(0).Text].DataType != DataType.Integer)
                    throw new ApplicationException("Incorrect FOR condition");
                RecCheck((NodeData)node.GetChild(0), context);
            }
            else
            {
                throw new ApplicationException("Incorrect FOR condition");
            }
            return DataType.Void;
        }
        private DataType CheckTo(NodeData node, Context context)
        {
            int i;
            RecCheck((NodeData)node.GetChild(0), context);
            //if (!int.TryParse(node.GetChild(0).Text, out i)) throw new ApplicationException("Incorrect FOR condition");
            return DataType.Void;
        }
        //private DataType CheckWhile(NodeData node, Context context)
        //{ }
        //private DataType CheckFor(NodeData node, Context context)
        //{ }

        private DataType CheckWrite(NodeData node, Context context, bool a = false)
        {
            RecCheck((NodeData)node.GetChild(0), context);
            return DataType.Void;
        }

        private DataType CheckRead(NodeData node, Context context)
        {
            RecCheck((NodeData)node.GetChild(0), context);

            return DataType.Void;
        }

    }
}
