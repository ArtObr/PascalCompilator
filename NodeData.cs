using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathLang.Semantics;

namespace MathLang.CodeGen
{
    public class NodeData : CommonTree
    {
        private DataType dataType;
        private string text;
        public override string Text
        {
            get
            {
                if (this.text == null)
                    return base.Text;
                else
                    return this.text;
            }

            set
            {
                this.text = value;
                base.Text = value;
            }
        }
        public DataType DataType { get; set; }
        public NodeData()
          : base()
        {
        }

        public NodeData(IToken t)
          : base(t)
        {
        }

        public NodeData(CommonTree node)
          : base(node)
        {
        }

        public override ITree DupNode()
        {
            return new NodeData(this);
        }

        public DataType TypeData
        {
            get { return dataType; }
            set { dataType = value; }
        }

        public Ident IdentDescription
        {
            get;
            set;
        }
    }
}
