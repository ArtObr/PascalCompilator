using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace MathLang.Semantics
{
    class Commons
    {
    }
    public enum IdentType
    {
        GlobalVar,
        LocalVar,
        Param,
        Function,
        Procedure
    }

    public enum DataType
    {

        Void,
        Integer,
        Real,
        Bool,
        Array
    }

    public class Ident
    {
        public string Name { get; set; }
        public IdentType IdentType { get; set; }
        public DataType DataType { get; set; }
        
        public int Number { get; set; }

        //function
        public int ParamCount { get; set; }

        //array
        public DataType ElementData { get; set;  }
        public int from, to;
        

        

        public Ident(string name, IdentType identType, DataType dataType, int number)
        {
            Name = name;
            IdentType = identType;
            DataType = dataType;
            
            Number = number;
        }
    }


    public class Context
    {
        private Context parentContext;
        public int countLocal = 0,
            countParams = 0
            ;

        private Dictionary<string, Ident> idents = new Dictionary<string, Ident>();

        public Context(Context parentContext)
        {
            this.parentContext = parentContext;
        }

        public Ident this[string name]
        {
            get
            {
                return idents.ContainsKey(name) ? idents[name] :
                           parentContext != null ? parentContext[name] : null;
            }
            set
            {
                idents[name] = value;
            }
        }

        public Ident InThisContext(string name)
        {
            return idents.ContainsKey(name) ? idents[name] : null;
        }

        private Ident function = null;

        public Ident Function
        {
            get
            {
                return function != null ? function :
                           parentContext != null ? parentContext.Function : null;
            }
            set
            {
                function = value;
            }
        }

        public Context ParentContext
        {
            get
            {
                return parentContext;
            }
        }
    }
}
