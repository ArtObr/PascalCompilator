using System;
using System.Globalization;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

using MathLang.Semantics;
using MathLang.CodeGen;
using System.IO;


namespace MathLang
{
    public class Program
    {
        public static readonly NumberFormatInfo NFI = new NumberFormatInfo();


        public static void Main(string[] args)
        {
            //try
            //{
            ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                                 : (ICharStream)new ANTLRReaderStream(Console.In);
            MathLangLexer lexer = new MathLangLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            MathLangParser parser = new MathLangParser(tokens);
            parser.TreeAdaptor = new TreeAdapterSSKA();
            NodeData program = (NodeData)parser.execute().Tree;

            Console.WriteLine("ƒерево с проведенным синтаксическим разбором:");
            SyntaxParsing semantic = new SyntaxParsing(program);
            semantic.Check();

            MyPrinter.Print(program);
            MSIL msil = new MSIL();

            string sb = msil.Start((NodeData)program);

            FileWorker.WriteToFile(sb);
            //MathLangIntepreter.Execute(program);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: {0}", e.Message);
            //}
            Console.ReadLine();
        }
    }
}
