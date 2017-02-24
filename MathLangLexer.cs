// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-01-18 18:16:25

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;
namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int T__70=70;
	public const int T__71=71;
	public const int T__72=72;
	public const int T__73=73;
	public const int UNKNOWN=4;
	public const int BEGIN=5;
	public const int END=6;
	public const int PROGRAM=7;
	public const int CHAR=8;
	public const int INTEGER=9;
	public const int BOOLEAN=10;
	public const int ARRAY=11;
	public const int OF=12;
	public const int CONST_DECL=13;
	public const int VAR_DECL=14;
	public const int FUNC_DECL=15;
	public const int PROC_DECL=16;
	public const int WRITE=17;
	public const int WRITELN=18;
	public const int READ=19;
	public const int READLN=20;
	public const int EXPR_LIST=21;
	public const int BLOCK=22;
	public const int DECL=23;
	public const int AND=24;
	public const int OR=25;
	public const int NOT=26;
	public const int PARAMS=27;
	public const int CALL=28;
	public const int IF=29;
	public const int THEN=30;
	public const int ELSE=31;
	public const int IFTHEN=32;
	public const int FOR=33;
	public const int TO=34;
	public const int DOWNTO=35;
	public const int DO=36;
	public const int FROM=37;
	public const int WHILE=38;
	public const int REPEAT=39;
	public const int UNTIL=40;
	public const int VOID=41;
	public const int INC=42;
	public const int DEC=43;
	public const int ABS=44;
	public const int DIV=45;
	public const int MOD=46;
	public const int TRUE=47;
	public const int FALSE=48;
	public const int WS=49;
	public const int SL_COMMENT=50;
	public const int ML_COMMENT=51;
	public const int NUMBER=52;
	public const int IDENT=53;
	public const int ADD=54;
	public const int SUB=55;
	public const int MUL=56;
	public const int DIVIS=57;
	public const int GE=58;
	public const int LE=59;
	public const int NEQUALS=60;
	public const int EQUALS=61;
	public const int GT=62;
	public const int LT=63;
	public const int ASSIGN=64;

    // delegates
    // delegators

	public MathLangLexer()
	{
		OnCreated();
	}

	public MathLangLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MathLangLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "MathLang.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_BEGIN();
	partial void Leave_BEGIN();

	// $ANTLR start "BEGIN"
	[GrammarRule("BEGIN")]
	private void mBEGIN()
	{
		Enter_BEGIN();
		EnterRule("BEGIN", 1);
		TraceIn("BEGIN", 1);
		try
		{
			int _type = BEGIN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:9:7: ( 'begin' )
			DebugEnterAlt(1);
			// MathLang.g:9:9: 'begin'
			{
			DebugLocation(9, 9);
			Match("begin"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BEGIN", 1);
			LeaveRule("BEGIN", 1);
			Leave_BEGIN();
		}
	}
	// $ANTLR end "BEGIN"

	partial void Enter_END();
	partial void Leave_END();

	// $ANTLR start "END"
	[GrammarRule("END")]
	private void mEND()
	{
		Enter_END();
		EnterRule("END", 2);
		TraceIn("END", 2);
		try
		{
			int _type = END;
			int _channel = DefaultTokenChannel;
			// MathLang.g:10:5: ( 'end' )
			DebugEnterAlt(1);
			// MathLang.g:10:7: 'end'
			{
			DebugLocation(10, 7);
			Match("end"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("END", 2);
			LeaveRule("END", 2);
			Leave_END();
		}
	}
	// $ANTLR end "END"

	partial void Enter_PROGRAM();
	partial void Leave_PROGRAM();

	// $ANTLR start "PROGRAM"
	[GrammarRule("PROGRAM")]
	private void mPROGRAM()
	{
		Enter_PROGRAM();
		EnterRule("PROGRAM", 3);
		TraceIn("PROGRAM", 3);
		try
		{
			int _type = PROGRAM;
			int _channel = DefaultTokenChannel;
			// MathLang.g:11:9: ( 'program' )
			DebugEnterAlt(1);
			// MathLang.g:11:11: 'program'
			{
			DebugLocation(11, 11);
			Match("program"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PROGRAM", 3);
			LeaveRule("PROGRAM", 3);
			Leave_PROGRAM();
		}
	}
	// $ANTLR end "PROGRAM"

	partial void Enter_CHAR();
	partial void Leave_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		Enter_CHAR();
		EnterRule("CHAR", 4);
		TraceIn("CHAR", 4);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:12:6: ( 'char' )
			DebugEnterAlt(1);
			// MathLang.g:12:8: 'char'
			{
			DebugLocation(12, 8);
			Match("char"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 4);
			LeaveRule("CHAR", 4);
			Leave_CHAR();
		}
	}
	// $ANTLR end "CHAR"

	partial void Enter_INTEGER();
	partial void Leave_INTEGER();

	// $ANTLR start "INTEGER"
	[GrammarRule("INTEGER")]
	private void mINTEGER()
	{
		Enter_INTEGER();
		EnterRule("INTEGER", 5);
		TraceIn("INTEGER", 5);
		try
		{
			int _type = INTEGER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:13:9: ( 'integer' )
			DebugEnterAlt(1);
			// MathLang.g:13:11: 'integer'
			{
			DebugLocation(13, 11);
			Match("integer"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INTEGER", 5);
			LeaveRule("INTEGER", 5);
			Leave_INTEGER();
		}
	}
	// $ANTLR end "INTEGER"

	partial void Enter_BOOLEAN();
	partial void Leave_BOOLEAN();

	// $ANTLR start "BOOLEAN"
	[GrammarRule("BOOLEAN")]
	private void mBOOLEAN()
	{
		Enter_BOOLEAN();
		EnterRule("BOOLEAN", 6);
		TraceIn("BOOLEAN", 6);
		try
		{
			int _type = BOOLEAN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:14:9: ( 'boolean' )
			DebugEnterAlt(1);
			// MathLang.g:14:11: 'boolean'
			{
			DebugLocation(14, 11);
			Match("boolean"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BOOLEAN", 6);
			LeaveRule("BOOLEAN", 6);
			Leave_BOOLEAN();
		}
	}
	// $ANTLR end "BOOLEAN"

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 7);
		TraceIn("ARRAY", 7);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// MathLang.g:15:7: ( 'array' )
			DebugEnterAlt(1);
			// MathLang.g:15:9: 'array'
			{
			DebugLocation(15, 9);
			Match("array"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 7);
			LeaveRule("ARRAY", 7);
			Leave_ARRAY();
		}
	}
	// $ANTLR end "ARRAY"

	partial void Enter_OF();
	partial void Leave_OF();

	// $ANTLR start "OF"
	[GrammarRule("OF")]
	private void mOF()
	{
		Enter_OF();
		EnterRule("OF", 8);
		TraceIn("OF", 8);
		try
		{
			int _type = OF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:4: ( 'of' )
			DebugEnterAlt(1);
			// MathLang.g:16:6: 'of'
			{
			DebugLocation(16, 6);
			Match("of"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OF", 8);
			LeaveRule("OF", 8);
			Leave_OF();
		}
	}
	// $ANTLR end "OF"

	partial void Enter_CONST_DECL();
	partial void Leave_CONST_DECL();

	// $ANTLR start "CONST_DECL"
	[GrammarRule("CONST_DECL")]
	private void mCONST_DECL()
	{
		Enter_CONST_DECL();
		EnterRule("CONST_DECL", 9);
		TraceIn("CONST_DECL", 9);
		try
		{
			int _type = CONST_DECL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:12: ( 'const' )
			DebugEnterAlt(1);
			// MathLang.g:17:14: 'const'
			{
			DebugLocation(17, 14);
			Match("const"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CONST_DECL", 9);
			LeaveRule("CONST_DECL", 9);
			Leave_CONST_DECL();
		}
	}
	// $ANTLR end "CONST_DECL"

	partial void Enter_VAR_DECL();
	partial void Leave_VAR_DECL();

	// $ANTLR start "VAR_DECL"
	[GrammarRule("VAR_DECL")]
	private void mVAR_DECL()
	{
		Enter_VAR_DECL();
		EnterRule("VAR_DECL", 10);
		TraceIn("VAR_DECL", 10);
		try
		{
			int _type = VAR_DECL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:10: ( 'var' )
			DebugEnterAlt(1);
			// MathLang.g:18:12: 'var'
			{
			DebugLocation(18, 12);
			Match("var"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VAR_DECL", 10);
			LeaveRule("VAR_DECL", 10);
			Leave_VAR_DECL();
		}
	}
	// $ANTLR end "VAR_DECL"

	partial void Enter_FUNC_DECL();
	partial void Leave_FUNC_DECL();

	// $ANTLR start "FUNC_DECL"
	[GrammarRule("FUNC_DECL")]
	private void mFUNC_DECL()
	{
		Enter_FUNC_DECL();
		EnterRule("FUNC_DECL", 11);
		TraceIn("FUNC_DECL", 11);
		try
		{
			int _type = FUNC_DECL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:11: ( 'function' )
			DebugEnterAlt(1);
			// MathLang.g:19:13: 'function'
			{
			DebugLocation(19, 13);
			Match("function"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNC_DECL", 11);
			LeaveRule("FUNC_DECL", 11);
			Leave_FUNC_DECL();
		}
	}
	// $ANTLR end "FUNC_DECL"

	partial void Enter_PROC_DECL();
	partial void Leave_PROC_DECL();

	// $ANTLR start "PROC_DECL"
	[GrammarRule("PROC_DECL")]
	private void mPROC_DECL()
	{
		Enter_PROC_DECL();
		EnterRule("PROC_DECL", 12);
		TraceIn("PROC_DECL", 12);
		try
		{
			int _type = PROC_DECL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:11: ( 'procedure' )
			DebugEnterAlt(1);
			// MathLang.g:20:13: 'procedure'
			{
			DebugLocation(20, 13);
			Match("procedure"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PROC_DECL", 12);
			LeaveRule("PROC_DECL", 12);
			Leave_PROC_DECL();
		}
	}
	// $ANTLR end "PROC_DECL"

	partial void Enter_WRITE();
	partial void Leave_WRITE();

	// $ANTLR start "WRITE"
	[GrammarRule("WRITE")]
	private void mWRITE()
	{
		Enter_WRITE();
		EnterRule("WRITE", 13);
		TraceIn("WRITE", 13);
		try
		{
			int _type = WRITE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:7: ( 'Write' )
			DebugEnterAlt(1);
			// MathLang.g:21:9: 'Write'
			{
			DebugLocation(21, 9);
			Match("Write"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WRITE", 13);
			LeaveRule("WRITE", 13);
			Leave_WRITE();
		}
	}
	// $ANTLR end "WRITE"

	partial void Enter_WRITELN();
	partial void Leave_WRITELN();

	// $ANTLR start "WRITELN"
	[GrammarRule("WRITELN")]
	private void mWRITELN()
	{
		Enter_WRITELN();
		EnterRule("WRITELN", 14);
		TraceIn("WRITELN", 14);
		try
		{
			int _type = WRITELN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:9: ( 'Writeln' )
			DebugEnterAlt(1);
			// MathLang.g:22:11: 'Writeln'
			{
			DebugLocation(22, 11);
			Match("Writeln"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WRITELN", 14);
			LeaveRule("WRITELN", 14);
			Leave_WRITELN();
		}
	}
	// $ANTLR end "WRITELN"

	partial void Enter_READ();
	partial void Leave_READ();

	// $ANTLR start "READ"
	[GrammarRule("READ")]
	private void mREAD()
	{
		Enter_READ();
		EnterRule("READ", 15);
		TraceIn("READ", 15);
		try
		{
			int _type = READ;
			int _channel = DefaultTokenChannel;
			// MathLang.g:23:6: ( 'Read' )
			DebugEnterAlt(1);
			// MathLang.g:23:8: 'Read'
			{
			DebugLocation(23, 8);
			Match("Read"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("READ", 15);
			LeaveRule("READ", 15);
			Leave_READ();
		}
	}
	// $ANTLR end "READ"

	partial void Enter_READLN();
	partial void Leave_READLN();

	// $ANTLR start "READLN"
	[GrammarRule("READLN")]
	private void mREADLN()
	{
		Enter_READLN();
		EnterRule("READLN", 16);
		TraceIn("READLN", 16);
		try
		{
			int _type = READLN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:24:8: ( 'Readln' )
			DebugEnterAlt(1);
			// MathLang.g:24:10: 'Readln'
			{
			DebugLocation(24, 10);
			Match("Readln"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("READLN", 16);
			LeaveRule("READLN", 16);
			Leave_READLN();
		}
	}
	// $ANTLR end "READLN"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 17);
		TraceIn("AND", 17);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:25:5: ( 'and' )
			DebugEnterAlt(1);
			// MathLang.g:25:7: 'and'
			{
			DebugLocation(25, 7);
			Match("and"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 17);
			LeaveRule("AND", 17);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 18);
		TraceIn("OR", 18);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:26:4: ( 'or' )
			DebugEnterAlt(1);
			// MathLang.g:26:6: 'or'
			{
			DebugLocation(26, 6);
			Match("or"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 18);
			LeaveRule("OR", 18);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_NOT();
	partial void Leave_NOT();

	// $ANTLR start "NOT"
	[GrammarRule("NOT")]
	private void mNOT()
	{
		Enter_NOT();
		EnterRule("NOT", 19);
		TraceIn("NOT", 19);
		try
		{
			int _type = NOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:27:5: ( 'not' )
			DebugEnterAlt(1);
			// MathLang.g:27:7: 'not'
			{
			DebugLocation(27, 7);
			Match("not"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NOT", 19);
			LeaveRule("NOT", 19);
			Leave_NOT();
		}
	}
	// $ANTLR end "NOT"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 20);
		TraceIn("IF", 20);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:28:4: ( 'if' )
			DebugEnterAlt(1);
			// MathLang.g:28:6: 'if'
			{
			DebugLocation(28, 6);
			Match("if"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 20);
			LeaveRule("IF", 20);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_THEN();
	partial void Leave_THEN();

	// $ANTLR start "THEN"
	[GrammarRule("THEN")]
	private void mTHEN()
	{
		Enter_THEN();
		EnterRule("THEN", 21);
		TraceIn("THEN", 21);
		try
		{
			int _type = THEN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:29:6: ( 'then' )
			DebugEnterAlt(1);
			// MathLang.g:29:8: 'then'
			{
			DebugLocation(29, 8);
			Match("then"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("THEN", 21);
			LeaveRule("THEN", 21);
			Leave_THEN();
		}
	}
	// $ANTLR end "THEN"

	partial void Enter_ELSE();
	partial void Leave_ELSE();

	// $ANTLR start "ELSE"
	[GrammarRule("ELSE")]
	private void mELSE()
	{
		Enter_ELSE();
		EnterRule("ELSE", 22);
		TraceIn("ELSE", 22);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:30:6: ( 'else' )
			DebugEnterAlt(1);
			// MathLang.g:30:8: 'else'
			{
			DebugLocation(30, 8);
			Match("else"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 22);
			LeaveRule("ELSE", 22);
			Leave_ELSE();
		}
	}
	// $ANTLR end "ELSE"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 23);
		TraceIn("FOR", 23);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:31:5: ( 'for' )
			DebugEnterAlt(1);
			// MathLang.g:31:7: 'for'
			{
			DebugLocation(31, 7);
			Match("for"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 23);
			LeaveRule("FOR", 23);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_TO();
	partial void Leave_TO();

	// $ANTLR start "TO"
	[GrammarRule("TO")]
	private void mTO()
	{
		Enter_TO();
		EnterRule("TO", 24);
		TraceIn("TO", 24);
		try
		{
			int _type = TO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:32:4: ( 'to' )
			DebugEnterAlt(1);
			// MathLang.g:32:6: 'to'
			{
			DebugLocation(32, 6);
			Match("to"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TO", 24);
			LeaveRule("TO", 24);
			Leave_TO();
		}
	}
	// $ANTLR end "TO"

	partial void Enter_DOWNTO();
	partial void Leave_DOWNTO();

	// $ANTLR start "DOWNTO"
	[GrammarRule("DOWNTO")]
	private void mDOWNTO()
	{
		Enter_DOWNTO();
		EnterRule("DOWNTO", 25);
		TraceIn("DOWNTO", 25);
		try
		{
			int _type = DOWNTO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:33:8: ( 'downto' )
			DebugEnterAlt(1);
			// MathLang.g:33:10: 'downto'
			{
			DebugLocation(33, 10);
			Match("downto"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOWNTO", 25);
			LeaveRule("DOWNTO", 25);
			Leave_DOWNTO();
		}
	}
	// $ANTLR end "DOWNTO"

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 26);
		TraceIn("DO", 26);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:34:4: ( 'do' )
			DebugEnterAlt(1);
			// MathLang.g:34:6: 'do'
			{
			DebugLocation(34, 6);
			Match("do"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 26);
			LeaveRule("DO", 26);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 27);
		TraceIn("WHILE", 27);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:35:7: ( 'while' )
			DebugEnterAlt(1);
			// MathLang.g:35:9: 'while'
			{
			DebugLocation(35, 9);
			Match("while"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 27);
			LeaveRule("WHILE", 27);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_REPEAT();
	partial void Leave_REPEAT();

	// $ANTLR start "REPEAT"
	[GrammarRule("REPEAT")]
	private void mREPEAT()
	{
		Enter_REPEAT();
		EnterRule("REPEAT", 28);
		TraceIn("REPEAT", 28);
		try
		{
			int _type = REPEAT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:36:8: ( 'repeat' )
			DebugEnterAlt(1);
			// MathLang.g:36:10: 'repeat'
			{
			DebugLocation(36, 10);
			Match("repeat"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REPEAT", 28);
			LeaveRule("REPEAT", 28);
			Leave_REPEAT();
		}
	}
	// $ANTLR end "REPEAT"

	partial void Enter_UNTIL();
	partial void Leave_UNTIL();

	// $ANTLR start "UNTIL"
	[GrammarRule("UNTIL")]
	private void mUNTIL()
	{
		Enter_UNTIL();
		EnterRule("UNTIL", 29);
		TraceIn("UNTIL", 29);
		try
		{
			int _type = UNTIL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:37:7: ( 'until' )
			DebugEnterAlt(1);
			// MathLang.g:37:9: 'until'
			{
			DebugLocation(37, 9);
			Match("until"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("UNTIL", 29);
			LeaveRule("UNTIL", 29);
			Leave_UNTIL();
		}
	}
	// $ANTLR end "UNTIL"

	partial void Enter_VOID();
	partial void Leave_VOID();

	// $ANTLR start "VOID"
	[GrammarRule("VOID")]
	private void mVOID()
	{
		Enter_VOID();
		EnterRule("VOID", 30);
		TraceIn("VOID", 30);
		try
		{
			int _type = VOID;
			int _channel = DefaultTokenChannel;
			// MathLang.g:38:6: ( 'void' )
			DebugEnterAlt(1);
			// MathLang.g:38:8: 'void'
			{
			DebugLocation(38, 8);
			Match("void"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VOID", 30);
			LeaveRule("VOID", 30);
			Leave_VOID();
		}
	}
	// $ANTLR end "VOID"

	partial void Enter_INC();
	partial void Leave_INC();

	// $ANTLR start "INC"
	[GrammarRule("INC")]
	private void mINC()
	{
		Enter_INC();
		EnterRule("INC", 31);
		TraceIn("INC", 31);
		try
		{
			int _type = INC;
			int _channel = DefaultTokenChannel;
			// MathLang.g:39:5: ( 'Inc' )
			DebugEnterAlt(1);
			// MathLang.g:39:7: 'Inc'
			{
			DebugLocation(39, 7);
			Match("Inc"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INC", 31);
			LeaveRule("INC", 31);
			Leave_INC();
		}
	}
	// $ANTLR end "INC"

	partial void Enter_DEC();
	partial void Leave_DEC();

	// $ANTLR start "DEC"
	[GrammarRule("DEC")]
	private void mDEC()
	{
		Enter_DEC();
		EnterRule("DEC", 32);
		TraceIn("DEC", 32);
		try
		{
			int _type = DEC;
			int _channel = DefaultTokenChannel;
			// MathLang.g:40:5: ( 'Dec' )
			DebugEnterAlt(1);
			// MathLang.g:40:7: 'Dec'
			{
			DebugLocation(40, 7);
			Match("Dec"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DEC", 32);
			LeaveRule("DEC", 32);
			Leave_DEC();
		}
	}
	// $ANTLR end "DEC"

	partial void Enter_ABS();
	partial void Leave_ABS();

	// $ANTLR start "ABS"
	[GrammarRule("ABS")]
	private void mABS()
	{
		Enter_ABS();
		EnterRule("ABS", 33);
		TraceIn("ABS", 33);
		try
		{
			int _type = ABS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:41:5: ( 'Abs' )
			DebugEnterAlt(1);
			// MathLang.g:41:7: 'Abs'
			{
			DebugLocation(41, 7);
			Match("Abs"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ABS", 33);
			LeaveRule("ABS", 33);
			Leave_ABS();
		}
	}
	// $ANTLR end "ABS"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 34);
		TraceIn("DIV", 34);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:42:5: ( 'div' )
			DebugEnterAlt(1);
			// MathLang.g:42:7: 'div'
			{
			DebugLocation(42, 7);
			Match("div"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 34);
			LeaveRule("DIV", 34);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_MOD();
	partial void Leave_MOD();

	// $ANTLR start "MOD"
	[GrammarRule("MOD")]
	private void mMOD()
	{
		Enter_MOD();
		EnterRule("MOD", 35);
		TraceIn("MOD", 35);
		try
		{
			int _type = MOD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:43:5: ( 'mod' )
			DebugEnterAlt(1);
			// MathLang.g:43:7: 'mod'
			{
			DebugLocation(43, 7);
			Match("mod"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MOD", 35);
			LeaveRule("MOD", 35);
			Leave_MOD();
		}
	}
	// $ANTLR end "MOD"

	partial void Enter_TRUE();
	partial void Leave_TRUE();

	// $ANTLR start "TRUE"
	[GrammarRule("TRUE")]
	private void mTRUE()
	{
		Enter_TRUE();
		EnterRule("TRUE", 36);
		TraceIn("TRUE", 36);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:44:6: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:44:8: 'true'
			{
			DebugLocation(44, 8);
			Match("true"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 36);
			LeaveRule("TRUE", 36);
			Leave_TRUE();
		}
	}
	// $ANTLR end "TRUE"

	partial void Enter_FALSE();
	partial void Leave_FALSE();

	// $ANTLR start "FALSE"
	[GrammarRule("FALSE")]
	private void mFALSE()
	{
		Enter_FALSE();
		EnterRule("FALSE", 37);
		TraceIn("FALSE", 37);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:45:7: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:45:9: 'false'
			{
			DebugLocation(45, 9);
			Match("false"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 37);
			LeaveRule("FALSE", 37);
			Leave_FALSE();
		}
	}
	// $ANTLR end "FALSE"

	partial void Enter_T__65();
	partial void Leave_T__65();

	// $ANTLR start "T__65"
	[GrammarRule("T__65")]
	private void mT__65()
	{
		Enter_T__65();
		EnterRule("T__65", 38);
		TraceIn("T__65", 38);
		try
		{
			int _type = T__65;
			int _channel = DefaultTokenChannel;
			// MathLang.g:46:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:46:9: '('
			{
			DebugLocation(46, 9);
			Match('('); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__65", 38);
			LeaveRule("T__65", 38);
			Leave_T__65();
		}
	}
	// $ANTLR end "T__65"

	partial void Enter_T__66();
	partial void Leave_T__66();

	// $ANTLR start "T__66"
	[GrammarRule("T__66")]
	private void mT__66()
	{
		Enter_T__66();
		EnterRule("T__66", 39);
		TraceIn("T__66", 39);
		try
		{
			int _type = T__66;
			int _channel = DefaultTokenChannel;
			// MathLang.g:47:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:47:9: ')'
			{
			DebugLocation(47, 9);
			Match(')'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__66", 39);
			LeaveRule("T__66", 39);
			Leave_T__66();
		}
	}
	// $ANTLR end "T__66"

	partial void Enter_T__67();
	partial void Leave_T__67();

	// $ANTLR start "T__67"
	[GrammarRule("T__67")]
	private void mT__67()
	{
		Enter_T__67();
		EnterRule("T__67", 40);
		TraceIn("T__67", 40);
		try
		{
			int _type = T__67;
			int _channel = DefaultTokenChannel;
			// MathLang.g:48:7: ( '[' )
			DebugEnterAlt(1);
			// MathLang.g:48:9: '['
			{
			DebugLocation(48, 9);
			Match('['); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__67", 40);
			LeaveRule("T__67", 40);
			Leave_T__67();
		}
	}
	// $ANTLR end "T__67"

	partial void Enter_T__68();
	partial void Leave_T__68();

	// $ANTLR start "T__68"
	[GrammarRule("T__68")]
	private void mT__68()
	{
		Enter_T__68();
		EnterRule("T__68", 41);
		TraceIn("T__68", 41);
		try
		{
			int _type = T__68;
			int _channel = DefaultTokenChannel;
			// MathLang.g:49:7: ( ']' )
			DebugEnterAlt(1);
			// MathLang.g:49:9: ']'
			{
			DebugLocation(49, 9);
			Match(']'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__68", 41);
			LeaveRule("T__68", 41);
			Leave_T__68();
		}
	}
	// $ANTLR end "T__68"

	partial void Enter_T__69();
	partial void Leave_T__69();

	// $ANTLR start "T__69"
	[GrammarRule("T__69")]
	private void mT__69()
	{
		Enter_T__69();
		EnterRule("T__69", 42);
		TraceIn("T__69", 42);
		try
		{
			int _type = T__69;
			int _channel = DefaultTokenChannel;
			// MathLang.g:50:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:50:9: ','
			{
			DebugLocation(50, 9);
			Match(','); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__69", 42);
			LeaveRule("T__69", 42);
			Leave_T__69();
		}
	}
	// $ANTLR end "T__69"

	partial void Enter_T__70();
	partial void Leave_T__70();

	// $ANTLR start "T__70"
	[GrammarRule("T__70")]
	private void mT__70()
	{
		Enter_T__70();
		EnterRule("T__70", 43);
		TraceIn("T__70", 43);
		try
		{
			int _type = T__70;
			int _channel = DefaultTokenChannel;
			// MathLang.g:51:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:51:9: ';'
			{
			DebugLocation(51, 9);
			Match(';'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__70", 43);
			LeaveRule("T__70", 43);
			Leave_T__70();
		}
	}
	// $ANTLR end "T__70"

	partial void Enter_T__71();
	partial void Leave_T__71();

	// $ANTLR start "T__71"
	[GrammarRule("T__71")]
	private void mT__71()
	{
		Enter_T__71();
		EnterRule("T__71", 44);
		TraceIn("T__71", 44);
		try
		{
			int _type = T__71;
			int _channel = DefaultTokenChannel;
			// MathLang.g:52:7: ( '..' )
			DebugEnterAlt(1);
			// MathLang.g:52:9: '..'
			{
			DebugLocation(52, 9);
			Match(".."); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__71", 44);
			LeaveRule("T__71", 44);
			Leave_T__71();
		}
	}
	// $ANTLR end "T__71"

	partial void Enter_T__72();
	partial void Leave_T__72();

	// $ANTLR start "T__72"
	[GrammarRule("T__72")]
	private void mT__72()
	{
		Enter_T__72();
		EnterRule("T__72", 45);
		TraceIn("T__72", 45);
		try
		{
			int _type = T__72;
			int _channel = DefaultTokenChannel;
			// MathLang.g:53:7: ( ':' )
			DebugEnterAlt(1);
			// MathLang.g:53:9: ':'
			{
			DebugLocation(53, 9);
			Match(':'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__72", 45);
			LeaveRule("T__72", 45);
			Leave_T__72();
		}
	}
	// $ANTLR end "T__72"

	partial void Enter_T__73();
	partial void Leave_T__73();

	// $ANTLR start "T__73"
	[GrammarRule("T__73")]
	private void mT__73()
	{
		Enter_T__73();
		EnterRule("T__73", 46);
		TraceIn("T__73", 46);
		try
		{
			int _type = T__73;
			int _channel = DefaultTokenChannel;
			// MathLang.g:54:7: ( '.' )
			DebugEnterAlt(1);
			// MathLang.g:54:9: '.'
			{
			DebugLocation(54, 9);
			Match('.'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__73", 46);
			LeaveRule("T__73", 46);
			Leave_T__73();
		}
	}
	// $ANTLR end "T__73"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 47);
		TraceIn("WS", 47);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:85:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:86:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(86, 3);
			// MathLang.g:86:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='\t' && LA1_0<='\n')||(LA1_0>='\f' && LA1_0<='\r')||LA1_0==' '))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(86, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(86, 40);
			if ( state.backtracking == 0 )
			{

				    _channel=Hidden;
				  
			}

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 47);
			LeaveRule("WS", 47);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_SL_COMMENT();
	partial void Leave_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		Enter_SL_COMMENT();
		EnterRule("SL_COMMENT", 48);
		TraceIn("SL_COMMENT", 48);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:91:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:92:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(92, 3);
			Match("//"); if (state.failed) return;

			DebugLocation(92, 8);
			// MathLang.g:92:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='\r'))
				{
					alt2=2;
				}
				else if ((LA2_0=='\n'))
				{
					alt2=2;
				}
				else if (((LA2_0>='\u0000' && LA2_0<='\t')||(LA2_0>='\u000B' && LA2_0<='\f')||(LA2_0>='\u000E' && LA2_0<='\uFFFF')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:92:36: .
					{
					DebugLocation(92, 36);
					MatchAny(); if (state.failed) return;

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(92, 40);
			// MathLang.g:92:40: ( '\\r' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='\r'))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:92:40: '\\r'
				{
				DebugLocation(92, 40);
				Match('\r'); if (state.failed) return;

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(92, 46);
			Match('\n'); if (state.failed) return;
			DebugLocation(92, 51);
			if ( state.backtracking == 0 )
			{

				    _channel=Hidden;
				  
			}

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 48);
			LeaveRule("SL_COMMENT", 48);
			Leave_SL_COMMENT();
		}
	}
	// $ANTLR end "SL_COMMENT"

	partial void Enter_ML_COMMENT();
	partial void Leave_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		Enter_ML_COMMENT();
		EnterRule("ML_COMMENT", 49);
		TraceIn("ML_COMMENT", 49);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:96:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:97:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(97, 3);
			Match("/*"); if (state.failed) return;

			DebugLocation(97, 8);
			// MathLang.g:97:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='*'))
				{
					int LA4_1 = input.LA(2);

					if ((LA4_1=='/'))
					{
						alt4=2;
					}
					else if (((LA4_1>='\u0000' && LA4_1<='.')||(LA4_1>='0' && LA4_1<='\uFFFF')))
					{
						alt4=1;
					}


				}
				else if (((LA4_0>='\u0000' && LA4_0<=')')||(LA4_0>='+' && LA4_0<='\uFFFF')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:97:36: .
					{
					DebugLocation(97, 36);
					MatchAny(); if (state.failed) return;

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(97, 40);
			Match("*/"); if (state.failed) return;

			DebugLocation(97, 45);
			if ( state.backtracking == 0 )
			{

				    _channel=Hidden;
				  
			}

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 49);
			LeaveRule("ML_COMMENT", 49);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 50);
		TraceIn("NUMBER", 50);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:104:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )=> '.' ( '0' .. '9' )+ )? )
			DebugEnterAlt(1);
			// MathLang.g:104:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )=> '.' ( '0' .. '9' )+ )?
			{
			DebugLocation(104, 9);
			// MathLang.g:104:9: ( '0' .. '9' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='0' && LA5_0<='9')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:104:10: '0' .. '9'
					{
					DebugLocation(104, 10);
					MatchRange('0','9'); if (state.failed) return;

					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(104, 21);
			// MathLang.g:104:21: ( '.' ( '0' .. '9' )=> '.' ( '0' .. '9' )+ )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0=='.'))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:104:22: '.' ( '0' .. '9' )=> '.' ( '0' .. '9' )+
				{
				DebugLocation(104, 22);
				Match('.'); if (state.failed) return;
				DebugLocation(104, 40);
				Match('.'); if (state.failed) return;
				DebugLocation(104, 43);
				// MathLang.g:104:43: ( '0' .. '9' )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if (((LA6_0>='0' && LA6_0<='9')))
					{
						alt6=1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:104:44: '0' .. '9'
						{
						DebugLocation(104, 44);
						MatchRange('0','9'); if (state.failed) return;

						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						if (state.backtracking>0) {state.failed=true; return;}
						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }


				}
				break;

			}
			} finally { DebugExitSubRule(7); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 50);
			LeaveRule("NUMBER", 50);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_IDENT();
	partial void Leave_IDENT();

	// $ANTLR start "IDENT"
	[GrammarRule("IDENT")]
	private void mIDENT()
	{
		Enter_IDENT();
		EnterRule("IDENT", 51);
		TraceIn("IDENT", 51);
		try
		{
			int _type = IDENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:106:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
			DebugEnterAlt(1);
			// MathLang.g:106:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			{
			DebugLocation(106, 9);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();
			state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(107, 9);
			// MathLang.g:107:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>='0' && LA8_0<='9')||(LA8_0>='A' && LA8_0<='Z')||LA8_0=='_'||(LA8_0>='a' && LA8_0<='z')))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(107, 9);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();
					state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IDENT", 51);
			LeaveRule("IDENT", 51);
			Leave_IDENT();
		}
	}
	// $ANTLR end "IDENT"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 52);
		TraceIn("ADD", 52);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:111:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:111:11: '+'
			{
			DebugLocation(111, 11);
			Match('+'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 52);
			LeaveRule("ADD", 52);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_SUB();
	partial void Leave_SUB();

	// $ANTLR start "SUB"
	[GrammarRule("SUB")]
	private void mSUB()
	{
		Enter_SUB();
		EnterRule("SUB", 53);
		TraceIn("SUB", 53);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:112:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:112:11: '-'
			{
			DebugLocation(112, 11);
			Match('-'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 53);
			LeaveRule("SUB", 53);
			Leave_SUB();
		}
	}
	// $ANTLR end "SUB"

	partial void Enter_MUL();
	partial void Leave_MUL();

	// $ANTLR start "MUL"
	[GrammarRule("MUL")]
	private void mMUL()
	{
		Enter_MUL();
		EnterRule("MUL", 54);
		TraceIn("MUL", 54);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:113:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:113:11: '*'
			{
			DebugLocation(113, 11);
			Match('*'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 54);
			LeaveRule("MUL", 54);
			Leave_MUL();
		}
	}
	// $ANTLR end "MUL"

	partial void Enter_DIVIS();
	partial void Leave_DIVIS();

	// $ANTLR start "DIVIS"
	[GrammarRule("DIVIS")]
	private void mDIVIS()
	{
		Enter_DIVIS();
		EnterRule("DIVIS", 55);
		TraceIn("DIVIS", 55);
		try
		{
			int _type = DIVIS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:114:6: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:114:10: '/'
			{
			DebugLocation(114, 10);
			Match('/'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIVIS", 55);
			LeaveRule("DIVIS", 55);
			Leave_DIVIS();
		}
	}
	// $ANTLR end "DIVIS"

	partial void Enter_GE();
	partial void Leave_GE();

	// $ANTLR start "GE"
	[GrammarRule("GE")]
	private void mGE()
	{
		Enter_GE();
		EnterRule("GE", 56);
		TraceIn("GE", 56);
		try
		{
			int _type = GE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:116:3: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:116:11: '>='
			{
			DebugLocation(116, 11);
			Match(">="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GE", 56);
			LeaveRule("GE", 56);
			Leave_GE();
		}
	}
	// $ANTLR end "GE"

	partial void Enter_LE();
	partial void Leave_LE();

	// $ANTLR start "LE"
	[GrammarRule("LE")]
	private void mLE()
	{
		Enter_LE();
		EnterRule("LE", 57);
		TraceIn("LE", 57);
		try
		{
			int _type = LE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:117:3: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:117:11: '<='
			{
			DebugLocation(117, 11);
			Match("<="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LE", 57);
			LeaveRule("LE", 57);
			Leave_LE();
		}
	}
	// $ANTLR end "LE"

	partial void Enter_NEQUALS();
	partial void Leave_NEQUALS();

	// $ANTLR start "NEQUALS"
	[GrammarRule("NEQUALS")]
	private void mNEQUALS()
	{
		Enter_NEQUALS();
		EnterRule("NEQUALS", 58);
		TraceIn("NEQUALS", 58);
		try
		{
			int _type = NEQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:118:8: ( '<>' )
			DebugEnterAlt(1);
			// MathLang.g:118:11: '<>'
			{
			DebugLocation(118, 11);
			Match("<>"); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQUALS", 58);
			LeaveRule("NEQUALS", 58);
			Leave_NEQUALS();
		}
	}
	// $ANTLR end "NEQUALS"

	partial void Enter_EQUALS();
	partial void Leave_EQUALS();

	// $ANTLR start "EQUALS"
	[GrammarRule("EQUALS")]
	private void mEQUALS()
	{
		Enter_EQUALS();
		EnterRule("EQUALS", 59);
		TraceIn("EQUALS", 59);
		try
		{
			int _type = EQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:119:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:119:11: '='
			{
			DebugLocation(119, 11);
			Match('='); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUALS", 59);
			LeaveRule("EQUALS", 59);
			Leave_EQUALS();
		}
	}
	// $ANTLR end "EQUALS"

	partial void Enter_GT();
	partial void Leave_GT();

	// $ANTLR start "GT"
	[GrammarRule("GT")]
	private void mGT()
	{
		Enter_GT();
		EnterRule("GT", 60);
		TraceIn("GT", 60);
		try
		{
			int _type = GT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:120:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:120:11: '>'
			{
			DebugLocation(120, 11);
			Match('>'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GT", 60);
			LeaveRule("GT", 60);
			Leave_GT();
		}
	}
	// $ANTLR end "GT"

	partial void Enter_LT();
	partial void Leave_LT();

	// $ANTLR start "LT"
	[GrammarRule("LT")]
	private void mLT()
	{
		Enter_LT();
		EnterRule("LT", 61);
		TraceIn("LT", 61);
		try
		{
			int _type = LT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:121:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:121:11: '<'
			{
			DebugLocation(121, 11);
			Match('<'); if (state.failed) return;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LT", 61);
			LeaveRule("LT", 61);
			Leave_LT();
		}
	}
	// $ANTLR end "LT"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 62);
		TraceIn("ASSIGN", 62);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:123:7: ( ':=' )
			DebugEnterAlt(1);
			// MathLang.g:123:11: ':='
			{
			DebugLocation(123, 11);
			Match(":="); if (state.failed) return;


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 62);
			LeaveRule("ASSIGN", 62);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( BEGIN | END | PROGRAM | CHAR | INTEGER | BOOLEAN | ARRAY | OF | CONST_DECL | VAR_DECL | FUNC_DECL | PROC_DECL | WRITE | WRITELN | READ | READLN | AND | OR | NOT | IF | THEN | ELSE | FOR | TO | DOWNTO | DO | WHILE | REPEAT | UNTIL | VOID | INC | DEC | ABS | DIV | MOD | TRUE | FALSE | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | WS | SL_COMMENT | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIVIS | GE | LE | NEQUALS | EQUALS | GT | LT | ASSIGN )
		int alt9=62;
		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
		try
		{
			alt9 = dfa9.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(9); }
		switch (alt9)
		{
		case 1:
			DebugEnterAlt(1);
			// MathLang.g:1:10: BEGIN
			{
			DebugLocation(1, 10);
			mBEGIN(); if (state.failed) return;

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// MathLang.g:1:16: END
			{
			DebugLocation(1, 16);
			mEND(); if (state.failed) return;

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// MathLang.g:1:20: PROGRAM
			{
			DebugLocation(1, 20);
			mPROGRAM(); if (state.failed) return;

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// MathLang.g:1:28: CHAR
			{
			DebugLocation(1, 28);
			mCHAR(); if (state.failed) return;

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MathLang.g:1:33: INTEGER
			{
			DebugLocation(1, 33);
			mINTEGER(); if (state.failed) return;

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MathLang.g:1:41: BOOLEAN
			{
			DebugLocation(1, 41);
			mBOOLEAN(); if (state.failed) return;

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MathLang.g:1:49: ARRAY
			{
			DebugLocation(1, 49);
			mARRAY(); if (state.failed) return;

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:55: OF
			{
			DebugLocation(1, 55);
			mOF(); if (state.failed) return;

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:58: CONST_DECL
			{
			DebugLocation(1, 58);
			mCONST_DECL(); if (state.failed) return;

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:69: VAR_DECL
			{
			DebugLocation(1, 69);
			mVAR_DECL(); if (state.failed) return;

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:78: FUNC_DECL
			{
			DebugLocation(1, 78);
			mFUNC_DECL(); if (state.failed) return;

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:88: PROC_DECL
			{
			DebugLocation(1, 88);
			mPROC_DECL(); if (state.failed) return;

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:98: WRITE
			{
			DebugLocation(1, 98);
			mWRITE(); if (state.failed) return;

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:104: WRITELN
			{
			DebugLocation(1, 104);
			mWRITELN(); if (state.failed) return;

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:112: READ
			{
			DebugLocation(1, 112);
			mREAD(); if (state.failed) return;

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:117: READLN
			{
			DebugLocation(1, 117);
			mREADLN(); if (state.failed) return;

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:124: AND
			{
			DebugLocation(1, 124);
			mAND(); if (state.failed) return;

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:128: OR
			{
			DebugLocation(1, 128);
			mOR(); if (state.failed) return;

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:131: NOT
			{
			DebugLocation(1, 131);
			mNOT(); if (state.failed) return;

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:135: IF
			{
			DebugLocation(1, 135);
			mIF(); if (state.failed) return;

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:138: THEN
			{
			DebugLocation(1, 138);
			mTHEN(); if (state.failed) return;

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:143: ELSE
			{
			DebugLocation(1, 143);
			mELSE(); if (state.failed) return;

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:148: FOR
			{
			DebugLocation(1, 148);
			mFOR(); if (state.failed) return;

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:152: TO
			{
			DebugLocation(1, 152);
			mTO(); if (state.failed) return;

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:155: DOWNTO
			{
			DebugLocation(1, 155);
			mDOWNTO(); if (state.failed) return;

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:162: DO
			{
			DebugLocation(1, 162);
			mDO(); if (state.failed) return;

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:165: WHILE
			{
			DebugLocation(1, 165);
			mWHILE(); if (state.failed) return;

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:171: REPEAT
			{
			DebugLocation(1, 171);
			mREPEAT(); if (state.failed) return;

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:178: UNTIL
			{
			DebugLocation(1, 178);
			mUNTIL(); if (state.failed) return;

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:184: VOID
			{
			DebugLocation(1, 184);
			mVOID(); if (state.failed) return;

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:189: INC
			{
			DebugLocation(1, 189);
			mINC(); if (state.failed) return;

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:193: DEC
			{
			DebugLocation(1, 193);
			mDEC(); if (state.failed) return;

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:197: ABS
			{
			DebugLocation(1, 197);
			mABS(); if (state.failed) return;

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:201: DIV
			{
			DebugLocation(1, 201);
			mDIV(); if (state.failed) return;

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:205: MOD
			{
			DebugLocation(1, 205);
			mMOD(); if (state.failed) return;

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:209: TRUE
			{
			DebugLocation(1, 209);
			mTRUE(); if (state.failed) return;

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:214: FALSE
			{
			DebugLocation(1, 214);
			mFALSE(); if (state.failed) return;

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:220: T__65
			{
			DebugLocation(1, 220);
			mT__65(); if (state.failed) return;

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:226: T__66
			{
			DebugLocation(1, 226);
			mT__66(); if (state.failed) return;

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:232: T__67
			{
			DebugLocation(1, 232);
			mT__67(); if (state.failed) return;

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// MathLang.g:1:238: T__68
			{
			DebugLocation(1, 238);
			mT__68(); if (state.failed) return;

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// MathLang.g:1:244: T__69
			{
			DebugLocation(1, 244);
			mT__69(); if (state.failed) return;

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// MathLang.g:1:250: T__70
			{
			DebugLocation(1, 250);
			mT__70(); if (state.failed) return;

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// MathLang.g:1:256: T__71
			{
			DebugLocation(1, 256);
			mT__71(); if (state.failed) return;

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// MathLang.g:1:262: T__72
			{
			DebugLocation(1, 262);
			mT__72(); if (state.failed) return;

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// MathLang.g:1:268: T__73
			{
			DebugLocation(1, 268);
			mT__73(); if (state.failed) return;

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// MathLang.g:1:274: WS
			{
			DebugLocation(1, 274);
			mWS(); if (state.failed) return;

			}
			break;
		case 48:
			DebugEnterAlt(48);
			// MathLang.g:1:277: SL_COMMENT
			{
			DebugLocation(1, 277);
			mSL_COMMENT(); if (state.failed) return;

			}
			break;
		case 49:
			DebugEnterAlt(49);
			// MathLang.g:1:288: ML_COMMENT
			{
			DebugLocation(1, 288);
			mML_COMMENT(); if (state.failed) return;

			}
			break;
		case 50:
			DebugEnterAlt(50);
			// MathLang.g:1:299: NUMBER
			{
			DebugLocation(1, 299);
			mNUMBER(); if (state.failed) return;

			}
			break;
		case 51:
			DebugEnterAlt(51);
			// MathLang.g:1:306: IDENT
			{
			DebugLocation(1, 306);
			mIDENT(); if (state.failed) return;

			}
			break;
		case 52:
			DebugEnterAlt(52);
			// MathLang.g:1:312: ADD
			{
			DebugLocation(1, 312);
			mADD(); if (state.failed) return;

			}
			break;
		case 53:
			DebugEnterAlt(53);
			// MathLang.g:1:316: SUB
			{
			DebugLocation(1, 316);
			mSUB(); if (state.failed) return;

			}
			break;
		case 54:
			DebugEnterAlt(54);
			// MathLang.g:1:320: MUL
			{
			DebugLocation(1, 320);
			mMUL(); if (state.failed) return;

			}
			break;
		case 55:
			DebugEnterAlt(55);
			// MathLang.g:1:324: DIVIS
			{
			DebugLocation(1, 324);
			mDIVIS(); if (state.failed) return;

			}
			break;
		case 56:
			DebugEnterAlt(56);
			// MathLang.g:1:330: GE
			{
			DebugLocation(1, 330);
			mGE(); if (state.failed) return;

			}
			break;
		case 57:
			DebugEnterAlt(57);
			// MathLang.g:1:333: LE
			{
			DebugLocation(1, 333);
			mLE(); if (state.failed) return;

			}
			break;
		case 58:
			DebugEnterAlt(58);
			// MathLang.g:1:336: NEQUALS
			{
			DebugLocation(1, 336);
			mNEQUALS(); if (state.failed) return;

			}
			break;
		case 59:
			DebugEnterAlt(59);
			// MathLang.g:1:344: EQUALS
			{
			DebugLocation(1, 344);
			mEQUALS(); if (state.failed) return;

			}
			break;
		case 60:
			DebugEnterAlt(60);
			// MathLang.g:1:351: GT
			{
			DebugLocation(1, 351);
			mGT(); if (state.failed) return;

			}
			break;
		case 61:
			DebugEnterAlt(61);
			// MathLang.g:1:354: LT
			{
			DebugLocation(1, 354);
			mLT(); if (state.failed) return;

			}
			break;
		case 62:
			DebugEnterAlt(62);
			// MathLang.g:1:357: ASSIGN
			{
			DebugLocation(1, 357);
			mASSIGN(); if (state.failed) return;

			}
			break;

		}

	}


	#region DFA
	DFA9 dfa9;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa9 = new DFA9(this);
	}

	private class DFA9 : DFA
	{
		private const string DFA9_eotS =
			"\x1\xFFFF\x15\x21\x6\xFFFF\x1\x4A\x1\x4C\x1\xFFFF\x1\x4F\x5\xFFFF\x1"+
			"\x51\x1\x54\x1\xFFFF\x8\x21\x1\x5D\x2\x21\x1\x60\x1\x61\x9\x21\x1\x6B"+
			"\x1\x21\x1\x6E\x8\x21\xC\xFFFF\x2\x21\x1\x79\x5\x21\x1\xFFFF\x1\x21\x1"+
			"\x81\x2\xFFFF\x1\x82\x2\x21\x1\x85\x3\x21\x1\x89\x1\x21\x1\xFFFF\x2\x21"+
			"\x1\xFFFF\x1\x8D\x3\x21\x1\x91\x1\x92\x1\x93\x1\x94\x2\x21\x1\xFFFF\x1"+
			"\x97\x2\x21\x1\x9A\x3\x21\x2\xFFFF\x1\x9E\x1\x21\x1\xFFFF\x2\x21\x1\xA3"+
			"\x1\xFFFF\x1\xA4\x1\xA5\x1\x21\x1\xFFFF\x3\x21\x4\xFFFF\x1\xAA\x1\x21"+
			"\x1\xFFFF\x2\x21\x1\xFFFF\x1\xAE\x1\x21\x1\xB0\x1\xFFFF\x1\x21\x1\xB2"+
			"\x1\xB4\x1\x21\x3\xFFFF\x1\x21\x1\xB7\x1\x21\x1\xB9\x1\xFFFF\x3\x21\x1"+
			"\xFFFF\x1\x21\x1\xFFFF\x1\x21\x1\xFFFF\x1\x21\x1\xFFFF\x1\xC0\x1\xC1"+
			"\x1\xFFFF\x1\xC2\x1\xFFFF\x1\xC3\x1\xC4\x1\x21\x1\xC6\x1\x21\x1\xC8\x5"+
			"\xFFFF\x1\x21\x1\xFFFF\x1\xCA\x1\xFFFF\x1\xCB\x2\xFFFF";
		private const string DFA9_eofS =
			"\xCC\xFFFF";
		private const string DFA9_minS =
			"\x1\x9\x1\x65\x1\x6C\x1\x72\x1\x68\x1\x66\x1\x6E\x1\x66\x2\x61\x1\x72"+
			"\x1\x65\x1\x6F\x1\x68\x1\x69\x1\x68\x1\x65\x2\x6E\x1\x65\x1\x62\x1\x6F"+
			"\x6\xFFFF\x1\x2E\x1\x3D\x1\xFFFF\x1\x2A\x5\xFFFF\x2\x3D\x1\xFFFF\x1\x67"+
			"\x1\x6F\x1\x64\x1\x73\x1\x6F\x1\x61\x1\x6E\x1\x74\x1\x30\x1\x72\x1\x64"+
			"\x2\x30\x1\x72\x1\x69\x1\x6E\x1\x72\x1\x6C\x1\x69\x1\x61\x1\x74\x1\x65"+
			"\x1\x30\x1\x75\x1\x30\x1\x76\x1\x69\x1\x70\x1\x74\x2\x63\x1\x73\x1\x64"+
			"\xC\xFFFF\x1\x69\x1\x6C\x1\x30\x1\x65\x1\x63\x1\x72\x1\x73\x1\x65\x1"+
			"\xFFFF\x1\x61\x1\x30\x2\xFFFF\x1\x30\x1\x64\x1\x63\x1\x30\x1\x73\x1\x74"+
			"\x1\x64\x1\x30\x1\x6E\x1\xFFFF\x1\x65\x1\x6E\x1\xFFFF\x1\x30\x1\x6C\x1"+
			"\x65\x1\x69\x4\x30\x1\x6E\x1\x65\x1\xFFFF\x1\x30\x1\x72\x1\x65\x1\x30"+
			"\x1\x74\x1\x67\x1\x79\x2\xFFFF\x1\x30\x1\x74\x1\xFFFF\x2\x65\x1\x30\x1"+
			"\xFFFF\x2\x30\x1\x74\x1\xFFFF\x1\x65\x1\x61\x1\x6C\x4\xFFFF\x1\x30\x1"+
			"\x61\x1\xFFFF\x1\x61\x1\x64\x1\xFFFF\x1\x30\x1\x65\x1\x30\x1\xFFFF\x1"+
			"\x69\x2\x30\x1\x6E\x3\xFFFF\x1\x6F\x1\x30\x1\x74\x1\x30\x1\xFFFF\x1\x6E"+
			"\x1\x6D\x1\x75\x1\xFFFF\x1\x72\x1\xFFFF\x1\x6F\x1\xFFFF\x1\x6E\x1\xFFFF"+
			"\x2\x30\x1\xFFFF\x1\x30\x1\xFFFF\x2\x30\x1\x72\x1\x30\x1\x6E\x1\x30\x5"+
			"\xFFFF\x1\x65\x1\xFFFF\x1\x30\x1\xFFFF\x1\x30\x2\xFFFF";
		private const string DFA9_maxS =
			"\x1\x7A\x1\x6F\x1\x6E\x1\x72\x1\x6F\x1\x6E\x2\x72\x1\x6F\x1\x75\x1\x72"+
			"\x1\x65\x1\x6F\x1\x72\x1\x6F\x1\x68\x1\x65\x2\x6E\x1\x65\x1\x62\x1\x6F"+
			"\x6\xFFFF\x1\x2E\x1\x3D\x1\xFFFF\x1\x2F\x5\xFFFF\x1\x3D\x1\x3E\x1\xFFFF"+
			"\x1\x67\x1\x6F\x1\x64\x1\x73\x1\x6F\x1\x61\x1\x6E\x1\x74\x1\x7A\x1\x72"+
			"\x1\x64\x2\x7A\x1\x72\x1\x69\x1\x6E\x1\x72\x1\x6C\x1\x69\x1\x61\x1\x74"+
			"\x1\x65\x1\x7A\x1\x75\x1\x7A\x1\x76\x1\x69\x1\x70\x1\x74\x2\x63\x1\x73"+
			"\x1\x64\xC\xFFFF\x1\x69\x1\x6C\x1\x7A\x1\x65\x1\x67\x1\x72\x1\x73\x1"+
			"\x65\x1\xFFFF\x1\x61\x1\x7A\x2\xFFFF\x1\x7A\x1\x64\x1\x63\x1\x7A\x1\x73"+
			"\x1\x74\x1\x64\x1\x7A\x1\x6E\x1\xFFFF\x1\x65\x1\x6E\x1\xFFFF\x1\x7A\x1"+
			"\x6C\x1\x65\x1\x69\x4\x7A\x1\x6E\x1\x65\x1\xFFFF\x1\x7A\x1\x72\x1\x65"+
			"\x1\x7A\x1\x74\x1\x67\x1\x79\x2\xFFFF\x1\x7A\x1\x74\x1\xFFFF\x2\x65\x1"+
			"\x7A\x1\xFFFF\x2\x7A\x1\x74\x1\xFFFF\x1\x65\x1\x61\x1\x6C\x4\xFFFF\x1"+
			"\x7A\x1\x61\x1\xFFFF\x1\x61\x1\x64\x1\xFFFF\x1\x7A\x1\x65\x1\x7A\x1\xFFFF"+
			"\x1\x69\x2\x7A\x1\x6E\x3\xFFFF\x1\x6F\x1\x7A\x1\x74\x1\x7A\x1\xFFFF\x1"+
			"\x6E\x1\x6D\x1\x75\x1\xFFFF\x1\x72\x1\xFFFF\x1\x6F\x1\xFFFF\x1\x6E\x1"+
			"\xFFFF\x2\x7A\x1\xFFFF\x1\x7A\x1\xFFFF\x2\x7A\x1\x72\x1\x7A\x1\x6E\x1"+
			"\x7A\x5\xFFFF\x1\x65\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x7A\x2\xFFFF";
		private const string DFA9_acceptS =
			"\x16\xFFFF\x1\x26\x1\x27\x1\x28\x1\x29\x1\x2A\x1\x2B\x2\xFFFF\x1\x2F"+
			"\x1\xFFFF\x1\x32\x1\x33\x1\x34\x1\x35\x1\x36\x2\xFFFF\x1\x3B\x21\xFFFF"+
			"\x1\x2C\x1\x2E\x1\x3E\x1\x2D\x1\x30\x1\x31\x1\x37\x1\x38\x1\x3C\x1\x39"+
			"\x1\x3A\x1\x3D\x8\xFFFF\x1\x14\x2\xFFFF\x1\x8\x1\x12\x9\xFFFF\x1\x18"+
			"\x2\xFFFF\x1\x1A\xA\xFFFF\x1\x2\x7\xFFFF\x1\x11\x1\xA\x2\xFFFF\x1\x17"+
			"\x3\xFFFF\x1\x13\x3\xFFFF\x1\x22\x3\xFFFF\x1\x1F\x1\x20\x1\x21\x1\x23"+
			"\x2\xFFFF\x1\x16\x2\xFFFF\x1\x4\x3\xFFFF\x1\x1E\x4\xFFFF\x1\xF\x1\x15"+
			"\x1\x24\x4\xFFFF\x1\x1\x3\xFFFF\x1\x9\x1\xFFFF\x1\x7\x1\xFFFF\x1\x25"+
			"\x1\xFFFF\x1\xD\x2\xFFFF\x1\x1B\x1\xFFFF\x1\x1D\x6\xFFFF\x1\x10\x1\x19"+
			"\x1\x1C\x1\x6\x1\x3\x1\xFFFF\x1\x5\x1\xFFFF\x1\xE\x1\xFFFF\x1\xB\x1\xC";
		private const string DFA9_specialS =
			"\xCC\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x2\x1E\x1\xFFFF\x2\x1E\x12\xFFFF\x1\x1E\x7\xFFFF\x1\x16\x1\x17\x1"+
				"\x24\x1\x22\x1\x1A\x1\x23\x1\x1C\x1\x1F\xA\x20\x1\x1D\x1\x1B\x1\x26"+
				"\x1\x27\x1\x25\x2\xFFFF\x1\x14\x2\x21\x1\x13\x4\x21\x1\x12\x8\x21\x1"+
				"\xB\x4\x21\x1\xA\x3\x21\x1\x18\x1\xFFFF\x1\x19\x1\xFFFF\x1\x21\x1\xFFFF"+
				"\x1\x6\x1\x1\x1\x4\x1\xE\x1\x2\x1\x9\x2\x21\x1\x5\x3\x21\x1\x15\x1\xC"+
				"\x1\x7\x1\x3\x1\x21\x1\x10\x1\x21\x1\xD\x1\x11\x1\x8\x1\xF\x3\x21",
				"\x1\x28\x9\xFFFF\x1\x29",
				"\x1\x2B\x1\xFFFF\x1\x2A",
				"\x1\x2C",
				"\x1\x2D\x6\xFFFF\x1\x2E",
				"\x1\x30\x7\xFFFF\x1\x2F",
				"\x1\x32\x3\xFFFF\x1\x31",
				"\x1\x33\xB\xFFFF\x1\x34",
				"\x1\x35\xD\xFFFF\x1\x36",
				"\x1\x39\xD\xFFFF\x1\x38\x5\xFFFF\x1\x37",
				"\x1\x3A",
				"\x1\x3B",
				"\x1\x3C",
				"\x1\x3D\x6\xFFFF\x1\x3E\x2\xFFFF\x1\x3F",
				"\x1\x41\x5\xFFFF\x1\x40",
				"\x1\x42",
				"\x1\x43",
				"\x1\x44",
				"\x1\x45",
				"\x1\x46",
				"\x1\x47",
				"\x1\x48",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x49",
				"\x1\x4B",
				"",
				"\x1\x4E\x4\xFFFF\x1\x4D",
				"",
				"",
				"",
				"",
				"",
				"\x1\x50",
				"\x1\x52\x1\x53",
				"",
				"\x1\x55",
				"\x1\x56",
				"\x1\x57",
				"\x1\x58",
				"\x1\x59",
				"\x1\x5A",
				"\x1\x5B",
				"\x1\x5C",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x5E",
				"\x1\x5F",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x62",
				"\x1\x63",
				"\x1\x64",
				"\x1\x65",
				"\x1\x66",
				"\x1\x67",
				"\x1\x68",
				"\x1\x69",
				"\x1\x6A",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x6C",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x16\x21\x1\x6D\x3"+
				"\x21",
				"\x1\x6F",
				"\x1\x70",
				"\x1\x71",
				"\x1\x72",
				"\x1\x73",
				"\x1\x74",
				"\x1\x75",
				"\x1\x76",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x77",
				"\x1\x78",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x7A",
				"\x1\x7C\x3\xFFFF\x1\x7B",
				"\x1\x7D",
				"\x1\x7E",
				"\x1\x7F",
				"",
				"\x1\x80",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x83",
				"\x1\x84",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x86",
				"\x1\x87",
				"\x1\x88",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x8A",
				"",
				"\x1\x8B",
				"\x1\x8C",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x8E",
				"\x1\x8F",
				"\x1\x90",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x95",
				"\x1\x96",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x98",
				"\x1\x99",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x9B",
				"\x1\x9C",
				"\x1\x9D",
				"",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\x9F",
				"",
				"\x1\xA0",
				"\x1\xA1",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\xB\x21\x1\xA2\xE"+
				"\x21",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\xA6",
				"",
				"\x1\xA7",
				"\x1\xA8",
				"\x1\xA9",
				"",
				"",
				"",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\xAB",
				"",
				"\x1\xAC",
				"\x1\xAD",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\xAF",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"",
				"\x1\xB1",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\xB\x21\x1\xB3\xE"+
				"\x21",
				"\x1\xB5",
				"",
				"",
				"",
				"\x1\xB6",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\xB8",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"",
				"\x1\xBA",
				"\x1\xBB",
				"\x1\xBC",
				"",
				"\x1\xBD",
				"",
				"\x1\xBE",
				"",
				"\x1\xBF",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\xC5",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"\x1\xC7",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"",
				"",
				"",
				"",
				"",
				"\x1\xC9",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"",
				"\xA\x21\x7\xFFFF\x1A\x21\x4\xFFFF\x1\x21\x1\xFFFF\x1A\x21",
				"",
				""
			};

		private static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
		private static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
		private static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
		private static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
		private static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
		private static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
		private static readonly short[][] DFA9_transition;

		static DFA9()
		{
			int numStates = DFA9_transitionS.Length;
			DFA9_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
			}
		}

		public DFA9( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 9;
			this.eot = DFA9_eot;
			this.eof = DFA9_eof;
			this.min = DFA9_min;
			this.max = DFA9_max;
			this.accept = DFA9_accept;
			this.special = DFA9_special;
			this.transition = DFA9_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( BEGIN | END | PROGRAM | CHAR | INTEGER | BOOLEAN | ARRAY | OF | CONST_DECL | VAR_DECL | FUNC_DECL | PROC_DECL | WRITE | WRITELN | READ | READLN | AND | OR | NOT | IF | THEN | ELSE | FOR | TO | DOWNTO | DO | WHILE | REPEAT | UNTIL | VOID | INC | DEC | ABS | DIV | MOD | TRUE | FALSE | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | WS | SL_COMMENT | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIVIS | GE | LE | NEQUALS | EQUALS | GT | LT | ASSIGN );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 
