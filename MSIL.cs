using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathLang.Semantics;
using System.Collections.Generic;

namespace MathLang.CodeGen
{
    class MSIL
    {
        
        public string Start(NodeData root)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@".assembly program
{
}
.class public Program
{");
            MSIL cg = new MSIL();

            Parsing(root, sb);


            sb.Append(@"}");

            return sb.ToString();
        }

        private void CheckNode(NodeData node, StringBuilder sb, int start = 0)
        {
            for (int i = start; i < node.ChildCount; i++)
                Parsing((NodeData)node.GetChild(i), sb);
        }

        private static int GetVarNum(NodeData node)
        {
            string[] mas = node.Text.Split('_');
            return int.Parse(mas[1]);
        }

        private static string ToMsilType(string st, string buf = "")
        {
            switch (st)
            {
                case "integer":
                case "Integer": return "int32";
                case "Bool": return "bool";
                case "Array": return ToMsilType(buf) + "[]";
                case "VOID": return "void";
                case "Void": return "void";
                    //   Bool
                    // Array
            }
            return "";
        }
        
        int lineNum = 0;
        StringBuilder GlobalVars = new System.Text.StringBuilder();
        StringBuilder AdditionalConst = new StringBuilder();
        StringBuilder AdditionalArray = new StringBuilder();
        StringBuilder Functions = new StringBuilder();
        List<int> FunctionsLineNums = new List<int>();
        
        private static void GenLocalVars(NodeData node, StringBuilder sb)
        {
            if (node.Type == MathLangLexer.VAR_DECL)
            {
                string type = ToMsilType(node.GetChild(0).Text);
                int num;
                if (node.GetChild(1).Type == MathLangLexer.ASSIGN)
                    num = GetVarNum((NodeData)node.GetChild(1).GetChild(0));
                else
                    num = GetVarNum((NodeData)node.GetChild(1));
                sb.Append(string.Format("      [{0}] {1},\n", num, type));
            }
            else
                for (int i = 0; i < node.ChildCount; i++)
                    GenLocalVars((NodeData)node.GetChild(i), sb);
        }

        public void Parsing(NodeData node, StringBuilder sb)
        {
            StringBuilder sb0;

            if (node == null)
                return;

            switch (node.Type)
            {
                case MathLangLexer.PROGRAM:
                    CheckProgram(node, sb);
                    break;
                case MathLangLexer.DECL:
                    CheckDecl(node, sb);
                    break;
                case MathLangLexer.BLOCK:
                    CheckBlock(node, sb);
                    break;
                case MathLangLexer.CONST_DECL:
                    CheckConstant(node, sb);
                    break;
                case MathLangLexer.VAR_DECL:
                    CheckVar(node, sb);
                    break;
                case MathLangLexer.PROC_DECL:
                case MathLangLexer.FUNC_DECL:
                    CheckFuncDecl(node, sb);
                    break;


                case MathLangLexer.ASSIGN:
                    CheckAssign(node, sb);
                    break;
                case MathLangLexer.MUL:
                case MathLangLexer.DIVIS:
                case MathLangLexer.ADD:
                case MathLangLexer.SUB:
                case MathLangLexer.DIV:
                case MathLangLexer.MOD:
                    CheckValueOperation(node, sb);
                    break;

                case MathLangLexer.GE:
                case MathLangLexer.LE:
                case MathLangLexer.NEQUALS:
                case MathLangLexer.EQUALS:
                case MathLangLexer.GT:
                case MathLangLexer.LT:
                    CheckLogicOperation(node, sb);
                    break;
                case MathLangLexer.IDENT:
                    CheckIdent(node, sb);
                    break;
                case MathLangLexer.NUMBER:
                    CheckNumber(node, sb);
                    break;
                case MathLangLexer.WRITE:
                    CheckWrite(node, sb);
                    break;
                case MathLangLexer.WRITELN:
                    CheckWrite(node, sb, true);
                    break;
                case MathLangLexer.READ:
                case MathLangLexer.READLN:
                    CheckRead(node, sb);
                    break;
                case MathLangLexer.TRUE:
                case MathLangLexer.FALSE:
                    CheckBool(node, sb);
                    break;
                case MathLangLexer.OR:
                    CheckOr(node, sb);
                    break;
                case MathLangLexer.AND:
                    CheckAnd(node, sb);
                    break;
                case MathLangLexer.NOT:
                    CheckNot(node, sb);
                    break;
                case MathLangLexer.IF:
                    CheckIf(node, sb);
                    break;
                case MathLangLexer.THEN:
                case MathLangLexer.ELSE:
                    CheckBlock(node, sb);
                    break;
                case MathLangLexer.FOR:
                    CheckFor(node, sb);
                    break;
                case MathLangLexer.CALL:
                    CheckCall(node, sb);
                    break;
            }
        }
        public void CheckCall(NodeData node, StringBuilder sb)
        {
            StringBuilder Params = new StringBuilder();
            string[] mas = node.GetChild(0).Text.Split('_');
            for (int i = 0; i < node.GetChild(1).ChildCount; i++)
            {
                Parsing((NodeData)node.GetChild(1).GetChild(i), sb);
                if (i == 0)
                {
                    if (node.GetChild(1).GetChild(i).Type == MathLangParser.IDENT)
                        Params.Append(ToMsilType(node.GetChild(1).GetChild(i).Text.Split('_')[2]));
                    else
                        Params.Append("int32");
                }
                else
                {
                    if (node.GetChild(1).GetChild(i).Type == MathLangParser.IDENT)
                        Params.Append(", " + ToMsilType(node.GetChild(1).GetChild(i).Text.Split('_')[2]));
                    else
                        Params.Append(", " + "int32");
                }
            }

            sb.Append(string.Format("    L_{0:D6}:  call       " +
                ToMsilType(mas[2]) + " Program::" + mas[0] + "(" + Params + ")\n",
            lineNum++));

        }
        public void CheckParamList(NodeData node, StringBuilder sb)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                string[] mas = node.GetChild(i).Text.Split('_');
                string num = mas[1];

                string type;
                type = ToMsilType(mas[2]);
                if (i == 0)
                    sb.Append(type + " " + mas[0]);
                else
                    sb.Append(" , " + type + " " + mas[0]);

            }
        }
        public void CheckFuncDecl(NodeData node, StringBuilder sb)
        {


            int buf = lineNum;
            lineNum = 0;
            string s1 = node.GetChild(1).Text;
            StringBuilder Params = new StringBuilder();
            Functions.Append(@"
  .method public static " +
  ToMsilType(s1) +
  " " + node.GetChild(0).Text.Split('_')[0] + "(");
            bool a = true;
            for (int i = 2; i < node.ChildCount - 1; i++)
            {
                if (a)
                {
                    CheckParamList((NodeData)node.GetChild(i), Params);
                    if (node.GetChild(i + 1).Text == "var") a = false;
                }
                else
                {
                    Functions.Append(Params + @") cil managed {
");
                    Functions.Append(@"
    .locals init (
" + (node.GetChild(1).Text != "VOID" ? "      [0] int32," : "") + @"
");
                    CheckVar((NodeData)node.GetChild(i), Functions);
                }
            }
            Functions.Append(@"    )
");
            CheckBlock((NodeData)node.GetChild(node.ChildCount - 1), Functions);
            if (node.GetChild(1).Text != "VOID")
                Functions.Append(string.Format("    L_{0:D6}: ldloc 0\n",
                lineNum++));

            Functions.Append(string.Format("    L_{0:D6}: ret\n", lineNum++));
            Functions.Append("  }\n");
            lineNum = buf;

        }
        public void CheckFor(NodeData node, StringBuilder sb)
        {
            string[] mas = node.GetChild(0).GetChild(0).GetChild(0).Text.Split('_');

            //assignition
            Parsing((NodeData)(node.GetChild(0).GetChild(0)), sb);
            int ThrowToConditionLineNum = lineNum++; //сформировать string

            //action
            StringBuilder additional = new StringBuilder();
            Parsing((NodeData)(node.GetChild(2).GetChild(0)), additional);

            //increment
            additional.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, mas[1]));
            additional.Append(string.Format("    L_{0:D6}: ldc.i4 1\n", lineNum++));
            additional.Append(string.Format("    L_{0:D6}: add\n", lineNum++));
            additional.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, mas[1]));

            //insert in main SB
            sb.Append(string.Format("    L_{0:D6}: br L_{1:D6}\n", ThrowToConditionLineNum, lineNum));
            sb.Append(additional);

            //condition
            sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, mas[1]));
            Parsing((NodeData)(node.GetChild(1).GetChild(0)), sb);
            sb.Append(string.Format("    L_{0:D6}: cgt\n", lineNum++));
            sb.Append(string.Format("    L_{0:D6}: ldc.i4 0\n", lineNum++));
            sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));

            //go to action
            sb.Append(string.Format("    L_{0:D6}: brtrue L_{1:D6}\n", lineNum++, ThrowToConditionLineNum + 1));
        }
        public void CheckIf(NodeData node, StringBuilder sb)
        {
            bool el = node.ChildCount == 3 ? true : false;
            Parsing((NodeData)node.GetChild(0), sb);
            int IFlineNum = lineNum++;

            StringBuilder IFcase = new StringBuilder();
            Parsing((NodeData)node.GetChild(1), IFcase);

            int ELSElineNum = el ? lineNum++ : 0;

            string IF = string.Format("    L_{0:D6}: brfalse L_{1:D6}\n", IFlineNum, lineNum);

            StringBuilder ELSEcase = new StringBuilder();
            string ELSE = "";
            if (el)
            {
                Parsing((NodeData)node.GetChild(2), ELSEcase);
                ELSE = string.Format("    L_{0:D6}: br L_{1:D6}\n", ELSElineNum, lineNum);
            }

            sb.Append(IF);
            sb.Append(IFcase);
            if (el)
            {
                sb.Append(ELSE);
                sb.Append(ELSEcase);
            }
        }
        public void CheckNot(NodeData node, StringBuilder sb)
        {
            Parsing((NodeData)node.GetChild(0), sb);
            sb.Append(string.Format("    L_{0:D6}: ldc.i4.0\n", lineNum++));
            sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
        }
        public void CheckAnd(NodeData node, StringBuilder sb)
        {
            Parsing((NodeData)node.GetChild(0), sb);
            Parsing((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: and\n", lineNum++));
        }
        public void CheckOr(NodeData node, StringBuilder sb)
        {
            Parsing((NodeData)node.GetChild(0), sb);
            Parsing((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: or\n", lineNum++));
        }
        public void CheckConstant(NodeData node, StringBuilder sb)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                string[] mas = node.GetChild(i).GetChild(0).Text.Split('_');
                string num = mas[1];
                string type = ToMsilType(mas[2]);
                sb.Append(string.Format("      [{0}] {1},\n", num, type));
                AdditionalConst.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++,
                    (mas[2] == "Bool" ? (node.GetChild(i).GetChild(1).Text == "true"
                    ? 1.ToString() : 0.ToString()) : node.GetChild(i).GetChild(1).Text))
                    );

                AdditionalConst.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, num));
            }
        }

        public void CheckLogicOperation(NodeData node, StringBuilder sb)
        {
            Parsing((NodeData)node.GetChild(0), sb);
            Parsing((NodeData)node.GetChild(1), sb);
            string[] mas = node.GetChild(0).Text.Split('_');
            switch (node.Type)
            {
                case MathLangLexer.GE:
                    sb.Append(string.Format("    L_{0:D6}: clt\n", lineNum++));
                    sb.Append(string.Format("    L_{0:D6}: ldc.i4.0\n", lineNum++));
                    sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
                    break;
                case MathLangLexer.LE:
                    sb.Append(string.Format("    L_{0:D6}: cgt\n", lineNum++));
                    sb.Append(string.Format("    L_{0:D6}: ldc.i4.0\n", lineNum++));
                    sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
                    break;
                case MathLangLexer.NEQUALS:
                    sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
                    sb.Append(string.Format("    L_{0:D6}: ldc.i4.0\n", lineNum++));
                    sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
                    break;
                case MathLangLexer.EQUALS:
                    sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
                    break;
                case MathLangLexer.GT:
                    sb.Append(string.Format("    L_{0:D6}: cgt\n", lineNum++));
                    break;
                case MathLangLexer.LT:
                    sb.Append(string.Format("    L_{0:D6}: clt\n", lineNum++));
                    break;
            }
        }
        public void CheckValueOperation(NodeData node, StringBuilder sb)
        {
            Parsing((NodeData)node.GetChild(0), sb);
            Parsing((NodeData)node.GetChild(1), sb);
            switch (node.Type)
            {
                case MathLangLexer.MUL:
                    sb.Append(string.Format("    L_{0:D6}: mul\n", lineNum++));
                    break;
                case MathLangLexer.DIVIS:
                    sb.Append(string.Format("    L_{0:D6}: div\n", lineNum++));
                    break;
                case MathLangLexer.ADD:
                    sb.Append(string.Format("    L_{0:D6}: add\n", lineNum++));
                    break;
                case MathLangLexer.SUB:
                    sb.Append(string.Format("    L_{0:D6}: sub\n", lineNum++));
                    break;
                case MathLangLexer.DIV:
                    sb.Append(string.Format("    L_{0:D6}: div\n", lineNum++));
                    break;
                case MathLangLexer.MOD:
                    sb.Append(string.Format("    L_{0:D6}: rem\n", lineNum++));
                    break;
            }

        }
        public void CheckProgram(NodeData node, StringBuilder sb)
        {
            StringBuilder AnotherOne = new StringBuilder();
            AnotherOne.Append(@"
  .method public static void main() cil managed {
    .entrypoint");

            Parsing((NodeData)node.GetChild(1), AnotherOne);
            Parsing((NodeData)node.GetChild(2), AnotherOne);
            AnotherOne.Append(string.Format("    L_{0:D6}: ret\n", lineNum++));
            AnotherOne.Append("  }\n");

            AnotherOne.Append(Functions);
            sb.Append(GlobalVars);
            sb.Append(AnotherOne);
        }

        public void CheckDecl(NodeData node, StringBuilder sb)
        {
            sb.Append(@"
    .locals init (
");

            CheckNode(node, sb);

            sb.Append(@"    )
");
            sb.Append(AdditionalConst);
            sb.Append(AdditionalArray);

        }
        public void CheckBlock(NodeData node, StringBuilder sb)
        {
            CheckNode(node, sb);
        }

        public void CheckVar(NodeData node, StringBuilder sb)
        {



            for (int i = 0; i < node.ChildCount; i++)
            {
                CheckVarList((NodeData)node.GetChild(i), sb);
            }
            sb[sb.Length - 2] = ' ';
            //if (GlobalVars.Length > 1)
            //    GlobalVars[GlobalVars.Length - 2] = ' ';
        }

        public void CheckVarList(NodeData node, StringBuilder sb)
        {

            for (int i = 0; i < node.ChildCount; i++)
            {
                string[] mas = node.GetChild(i).Text.Split('_');
                string num = mas[1];


                string type;
                if (mas[2] == "Array")
                {
                    type = ToMsilType(mas[2], mas[4]);
                    AdditionalArray.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++,
                        (int.Parse(mas[6]) - int.Parse(mas[5]) + 1).ToString()));
                    AdditionalArray.Append(string.Format("    L_{0:D6}: newarr     [mscorlib]System.Int32\n", lineNum++));
                    if (mas[3] == "GlobalVar")

                        AdditionalArray.Append(string.Format("    L_{0:D6}: stsfld     " + type + " Program::{1} \n", lineNum++, mas[0]));

                    else
                        AdditionalArray.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, mas[1]));
                }
                else
                    type = ToMsilType(mas[2]);
                if (mas[3] == "GlobalVar")
                    GlobalVars.Append(string.Format(".field private static {1} {0}\n", mas[0], type));
                else
                    sb.Append(string.Format("      [{0}] {1},\n", num, type));
            }
        }

        public void CheckAssign(NodeData node, StringBuilder sb)
        {
            if (node.Text.Split(';')[1] == "Array")
            {
                string[] mas = node.GetChild(0).Text.Split('_');
                if (mas[3] == "GlobalVar")
                    sb.Append(string.Format("    L_{0:D6}: ldsfld     " + ToMsilType(mas[2], mas[4]) + " Program::" + mas[0] + "\n",
                        lineNum++));
                else
                    sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, mas[1]));
                //sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++,
                //    (int.Parse(node.GetChild(0).GetChild(0).Text) - int.Parse(mas[5]))));
                //sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, node.GetChild(0).GetChild(0).Text));
                Parsing((NodeData)node.GetChild(0).GetChild(0), sb);
                Parsing((NodeData)node.GetChild(1), sb);
                sb.Append(string.Format("    L_{0:D6}: stelem.i4\n", lineNum++));
            }
            else
            {
                Parsing((NodeData)node.GetChild(1), sb);
                string[] mas = node.GetChild(0).Text.Split('_');
                if (mas[3] == "GlobalVar")
                    sb.Append(string.Format("    L_{0:D6}: stsfld     " + ToMsilType(mas[2]) + " Program::" + mas[0] + "\n", 
                        lineNum++));
                else
                    sb.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, mas[1]));
            }
        }
        public void CheckNumber(NodeData node, StringBuilder sb)
        {
            string[] mas2 = node.Parent.Text.Split('_');
            if (mas2.Length > 2 && mas2[2] == "Array")
            {
                sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n",
                lineNum++, int.Parse(node.Text) - int.Parse(mas2[5])));
            }
            else

                sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n",
                    lineNum++, int.Parse(node.Text)));
        }
        public void DownloadElementToStack(NodeData node, StringBuilder sb)
        {
            string[] mas = node.Text.Split('_');

            if (mas[3] == "GlobalVar")
                sb.Append(string.Format("    L_{0:D6}: ldsfld     " + ToMsilType(mas[2]) + " Program::" + mas[0] + "\n",
                    lineNum++));
            else
                sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, mas[1]));
            Parsing((NodeData)node.GetChild(0), sb);
            sb.Append(string.Format("    L_{0:D6}: ldelem.i4\n", lineNum++));
        }
        public void CheckWrite(NodeData node, StringBuilder sb, bool f = false)
        {
            Parsing((NodeData)node.GetChild(0), sb);
            string[] mas = node.GetChild(0).Text.Split('_');
            if (mas[2] == "Array")
                sb.Append(string.Format("    L_{0:D6}: call void [mscorlib]System.Console::Write"
               + (f ? "Line" : "") + "(" + ToMsilType(mas[4]) + ")\n", lineNum++));
            else
                sb.Append(string.Format("    L_{0:D6}: call void [mscorlib]System.Console::Write"
                    + (f ? "Line" : "") + "(" + ToMsilType(mas[2]) + ")\n", lineNum++));
        }
        public void CheckIdent(NodeData node, StringBuilder sb)
        {
            string[] mas = node.Text.Split('_');
            if (mas[3] == "Param")
            {
                sb.Append(string.Format("    L_{0:D6}: ldarg {1}\n", lineNum++, mas[1]));
                return;
            }
            switch (mas[2])
            {
                case "Array":
                    DownloadElementToStack(node, sb);
                    break;
                case "Param":

                    break;
                default:
                    int num = GetVarNum(node);
                    string[] mas2 = node.Parent.Text.Split('_');
                    if (mas.Length == 8 || mas.Length == 5)
                    {
                        //num -= int.Parse(mas2[5]);
                        if (mas[3] == "GlobalVar")
                            sb.Append(string.Format("    L_{0:D6}: ldsfld     " + ToMsilType(mas[2]) + " Program::" + mas[0] + "\n",
                                lineNum++));
                        else
                            sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, num));

                        sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, int.Parse(mas[4])));
                        sb.Append(string.Format("    L_{0:D6}: sub\n", lineNum++));
                    }
                    else
                    {
                        if (mas[3] == "GlobalVar")
                            sb.Append(string.Format("    L_{0:D6}: ldsfld     " + ToMsilType(mas[2]) + " Program::" + mas[0] + "\n",
                                lineNum++));
                        else
                            sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, num));
                    }
                    break;
            }
        }
        public void CheckRead(NodeData node, StringBuilder sb, bool f = false)
        {

            string[] mas = node.GetChild(0).Text.Split('_');
            if (mas[2] == "Array")
            {
                sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, mas[1]));
                sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++,
                    int.Parse(node.GetChild(0).GetChild(0).Text) - int.Parse(mas[5])));
                sb.Append(string.Format("    L_{0:D6}: call " + "string"
                + " [mscorlib]System.Console::ReadLine()\n", lineNum++));
                sb.Append(string.Format("    L_{0:D6}: call " + "int32"
                    + " [mscorlib]System.Convert::ToInt32(string)\n", lineNum++));
                sb.Append(string.Format("    L_{0:D6}: stelem.i4 \n", lineNum++));
            }
            else
            {
                sb.Append(string.Format("    L_{0:D6}: call " + "string"
                + " [mscorlib]System.Console::ReadLine()\n", lineNum++));
                sb.Append(string.Format("    L_{0:D6}: call " + "int32"
                    + " [mscorlib]System.Convert::ToInt32(string)\n", lineNum++));

                sb.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, mas[1]));
            }
        }
        public void CheckBool(NodeData node, StringBuilder sb)
        {
            string[] mas = node.Text.Split('_');
            sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, mas[0] == "true" ? 1 : 0));
        }
    }
}
