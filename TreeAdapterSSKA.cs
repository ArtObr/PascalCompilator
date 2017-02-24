using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathLang.CodeGen;


namespace MathLang
{
    class TreeAdapterSSKA : CommonTreeAdaptor
    {
        public override object Create(IToken payload)
        {
            return new NodeData(payload);
        }
    }
}
