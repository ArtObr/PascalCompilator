// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-01-18 18:16:24

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

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "UNKNOWN", "BEGIN", "END", "PROGRAM", "CHAR", "INTEGER", "BOOLEAN", "ARRAY", "OF", "CONST_DECL", "VAR_DECL", "FUNC_DECL", "PROC_DECL", "WRITE", "WRITELN", "READ", "READLN", "EXPR_LIST", "BLOCK", "DECL", "AND", "OR", "NOT", "PARAMS", "CALL", "IF", "THEN", "ELSE", "IFTHEN", "FOR", "TO", "DOWNTO", "DO", "FROM", "WHILE", "REPEAT", "UNTIL", "VOID", "INC", "DEC", "ABS", "DIV", "MOD", "TRUE", "FALSE", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "IDENT", "ADD", "SUB", "MUL", "DIVIS", "GE", "LE", "NEQUALS", "EQUALS", "GT", "LT", "ASSIGN", "'('", "')'", "'['", "']'", "','", "';'", "'..'", "':'", "'.'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, true, false, true, false, false, false, false, true, false, false, 
				false, false, false, false, false, false, false, , , , 
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public MathLangParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public MathLangParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[99+1];

		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return MathLangParser.tokenNames; } }
	public override string GrammarFileName { get { return "MathLang.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class bools_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bools();
	partial void Leave_bools();

	// $ANTLR start "bools"
	// MathLang.g:109:1: bools : ( TRUE | FALSE );
	[GrammarRule("bools")]
	private MathLangParser.bools_return bools()
	{
		Enter_bools();
		EnterRule("bools", 1);
		TraceIn("bools", 1);
		MathLangParser.bools_return retval = new MathLangParser.bools_return();
		retval.Start = (IToken)input.LT(1);
		int bools_StartIndex = input.Index;
		object root_0 = null;

		IToken set1=null;

		object set1_tree=null;

		try { DebugEnterRule(GrammarFileName, "bools");
		DebugLocation(109, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:109:7: ( TRUE | FALSE )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 7);
			set1=(IToken)input.LT(1);
			if ((input.LA(1)>=TRUE && input.LA(1)<=FALSE))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set1));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bools", 1);
			LeaveRule("bools", 1);
			Leave_bools();
			if (state.backtracking > 0) { Memoize(input, 1, bools_StartIndex); }
		}
		DebugLocation(110, 0);
		} finally { DebugExitRule(GrammarFileName, "bools"); }
		return retval;

	}
	// $ANTLR end "bools"

	public class group_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_group();
	partial void Leave_group();

	// $ANTLR start "group"
	// MathLang.g:126:1: group : ( '(' term ')' | NUMBER | IDENT | arrayId | bools );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 2);
		TraceIn("group", 2);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal2=null;
		IToken char_literal4=null;
		IToken NUMBER5=null;
		IToken IDENT6=null;
		MathLangParser.term_return term3 = default(MathLangParser.term_return);
		MathLangParser.arrayId_return arrayId7 = default(MathLangParser.arrayId_return);
		MathLangParser.bools_return bools8 = default(MathLangParser.bools_return);

		object char_literal2_tree=null;
		object char_literal4_tree=null;
		object NUMBER5_tree=null;
		object IDENT6_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(126, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:126:6: ( '(' term ')' | NUMBER | IDENT | arrayId | bools )
			int alt1=5;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 65:
				{
				alt1=1;
				}
				break;
			case NUMBER:
				{
				alt1=2;
				}
				break;
			case IDENT:
				{
				int LA1_3 = input.LA(2);

				if ((LA1_3==67))
				{
					alt1=4;
				}
				else if ((LA1_3==EOF||(LA1_3>=AND && LA1_3<=OR)||LA1_3==THEN||LA1_3==DO||LA1_3==UNTIL||(LA1_3>=DIV && LA1_3<=MOD)||(LA1_3>=ADD && LA1_3<=LT)||LA1_3==66||LA1_3==68||LA1_3==70))
				{
					alt1=3;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 3, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case TRUE:
			case FALSE:
				{
				alt1=5;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:127:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(127, 6);
				char_literal2=(IToken)Match(input,65,Follow._65_in_group1036); if (state.failed) return retval;
				DebugLocation(127, 8);
				PushFollow(Follow._term_in_group1039);
				term3=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term3.Tree);
				DebugLocation(127, 16);
				char_literal4=(IToken)Match(input,66,Follow._66_in_group1041); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:128:3: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(128, 3);
				NUMBER5=(IToken)Match(input,NUMBER,Follow._NUMBER_in_group1046); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER5_tree = (object)adaptor.Create(NUMBER5);
				adaptor.AddChild(root_0, NUMBER5_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:129:3: IDENT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(129, 3);
				IDENT6=(IToken)Match(input,IDENT,Follow._IDENT_in_group1050); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT6_tree = (object)adaptor.Create(IDENT6);
				adaptor.AddChild(root_0, IDENT6_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:130:3: arrayId
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(130, 3);
				PushFollow(Follow._arrayId_in_group1054);
				arrayId7=arrayId();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayId7.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:131:3: bools
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(131, 3);
				PushFollow(Follow._bools_in_group1058);
				bools8=bools();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bools8.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("group", 2);
			LeaveRule("group", 2);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 2, group_StartIndex); }
		}
		DebugLocation(132, 0);
		} finally { DebugExitRule(GrammarFileName, "group"); }
		return retval;

	}
	// $ANTLR end "group"

	public class arrayId_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrayId();
	partial void Leave_arrayId();

	// $ANTLR start "arrayId"
	// MathLang.g:135:1: arrayId : IDENT '[' term ']' -> ^( IDENT term ) ;
	[GrammarRule("arrayId")]
	private MathLangParser.arrayId_return arrayId()
	{
		Enter_arrayId();
		EnterRule("arrayId", 3);
		TraceIn("arrayId", 3);
		MathLangParser.arrayId_return retval = new MathLangParser.arrayId_return();
		retval.Start = (IToken)input.LT(1);
		int arrayId_StartIndex = input.Index;
		object root_0 = null;

		IToken IDENT9=null;
		IToken char_literal10=null;
		IToken char_literal12=null;
		MathLangParser.term_return term11 = default(MathLangParser.term_return);

		object IDENT9_tree=null;
		object char_literal10_tree=null;
		object char_literal12_tree=null;
		RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		try { DebugEnterRule(GrammarFileName, "arrayId");
		DebugLocation(135, 47);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:135:8: ( IDENT '[' term ']' -> ^( IDENT term ) )
			DebugEnterAlt(1);
			// MathLang.g:135:10: IDENT '[' term ']'
			{
			DebugLocation(135, 10);
			IDENT9=(IToken)Match(input,IDENT,Follow._IDENT_in_arrayId1067); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT9);

			DebugLocation(135, 16);
			char_literal10=(IToken)Match(input,67,Follow._67_in_arrayId1069); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_67.Add(char_literal10);

			DebugLocation(135, 19);
			PushFollow(Follow._term_in_arrayId1070);
			term11=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_term.Add(term11.Tree);
			DebugLocation(135, 23);
			char_literal12=(IToken)Match(input,68,Follow._68_in_arrayId1071); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_68.Add(char_literal12);



			{
			// AST REWRITE
			// elements: IDENT, term
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 135:27: -> ^( IDENT term )
			{
				DebugLocation(135, 31);
				// MathLang.g:135:31: ^( IDENT term )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(135, 34);
				root_1 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_1);

				DebugLocation(135, 40);
				adaptor.AddChild(root_1, stream_term.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arrayId", 3);
			LeaveRule("arrayId", 3);
			Leave_arrayId();
			if (state.backtracking > 0) { Memoize(input, 3, arrayId_StartIndex); }
		}
		DebugLocation(135, 47);
		} finally { DebugExitRule(GrammarFileName, "arrayId"); }
		return retval;

	}
	// $ANTLR end "arrayId"

	public class character_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_character();
	partial void Leave_character();

	// $ANTLR start "character"
	// MathLang.g:137:1: character : ( NUMBER | IDENT | arrayId );
	[GrammarRule("character")]
	private MathLangParser.character_return character()
	{
		Enter_character();
		EnterRule("character", 4);
		TraceIn("character", 4);
		MathLangParser.character_return retval = new MathLangParser.character_return();
		retval.Start = (IToken)input.LT(1);
		int character_StartIndex = input.Index;
		object root_0 = null;

		IToken NUMBER13=null;
		IToken IDENT14=null;
		MathLangParser.arrayId_return arrayId15 = default(MathLangParser.arrayId_return);

		object NUMBER13_tree=null;
		object IDENT14_tree=null;

		try { DebugEnterRule(GrammarFileName, "character");
		DebugLocation(137, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:137:10: ( NUMBER | IDENT | arrayId )
			int alt2=3;
			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
			int LA2_0 = input.LA(1);

			if ((LA2_0==NUMBER))
			{
				alt2=1;
			}
			else if ((LA2_0==IDENT))
			{
				int LA2_2 = input.LA(2);

				if ((LA2_2==67))
				{
					alt2=3;
				}
				else if ((LA2_2==EOF||LA2_2==TO||LA2_2==66||(LA2_2>=68 && LA2_2<=69)||LA2_2==71))
				{
					alt2=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:138:2: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(138, 2);
				NUMBER13=(IToken)Match(input,NUMBER,Follow._NUMBER_in_character1092); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER13_tree = (object)adaptor.Create(NUMBER13);
				adaptor.AddChild(root_0, NUMBER13_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:139:3: IDENT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(139, 3);
				IDENT14=(IToken)Match(input,IDENT,Follow._IDENT_in_character1096); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT14_tree = (object)adaptor.Create(IDENT14);
				adaptor.AddChild(root_0, IDENT14_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:140:3: arrayId
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(140, 3);
				PushFollow(Follow._arrayId_in_character1100);
				arrayId15=arrayId();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayId15.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("character", 4);
			LeaveRule("character", 4);
			Leave_character();
			if (state.backtracking > 0) { Memoize(input, 4, character_StartIndex); }
		}
		DebugLocation(141, 0);
		} finally { DebugExitRule(GrammarFileName, "character"); }
		return retval;

	}
	// $ANTLR end "character"

	public class not_logic_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_not_logic();
	partial void Leave_not_logic();

	// $ANTLR start "not_logic"
	// MathLang.g:143:1: not_logic : ( NOT )? group ;
	[GrammarRule("not_logic")]
	private MathLangParser.not_logic_return not_logic()
	{
		Enter_not_logic();
		EnterRule("not_logic", 5);
		TraceIn("not_logic", 5);
		MathLangParser.not_logic_return retval = new MathLangParser.not_logic_return();
		retval.Start = (IToken)input.LT(1);
		int not_logic_StartIndex = input.Index;
		object root_0 = null;

		IToken NOT16=null;
		MathLangParser.group_return group17 = default(MathLangParser.group_return);

		object NOT16_tree=null;

		try { DebugEnterRule(GrammarFileName, "not_logic");
		DebugLocation(143, 27);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:143:10: ( ( NOT )? group )
			DebugEnterAlt(1);
			// MathLang.g:143:12: ( NOT )? group
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(143, 12);
			// MathLang.g:143:12: ( NOT )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0==NOT))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:143:14: NOT
				{
				DebugLocation(143, 17);
				NOT16=(IToken)Match(input,NOT,Follow._NOT_in_not_logic1110); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				NOT16_tree = (object)adaptor.Create(NOT16);
				root_0 = (object)adaptor.BecomeRoot(NOT16_tree, root_0);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(143, 22);
			PushFollow(Follow._group_in_not_logic1116);
			group17=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group17.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("not_logic", 5);
			LeaveRule("not_logic", 5);
			Leave_not_logic();
			if (state.backtracking > 0) { Memoize(input, 5, not_logic_StartIndex); }
		}
		DebugLocation(143, 27);
		} finally { DebugExitRule(GrammarFileName, "not_logic"); }
		return retval;

	}
	// $ANTLR end "not_logic"

	public class mult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mult();
	partial void Leave_mult();

	// $ANTLR start "mult"
	// MathLang.g:145:1: mult : not_logic ( ( MUL | DIVIS | MOD | DIV ) not_logic )* ;
	[GrammarRule("mult")]
	private MathLangParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 6);
		TraceIn("mult", 6);
		MathLangParser.mult_return retval = new MathLangParser.mult_return();
		retval.Start = (IToken)input.LT(1);
		int mult_StartIndex = input.Index;
		object root_0 = null;

		IToken set19=null;
		MathLangParser.not_logic_return not_logic18 = default(MathLangParser.not_logic_return);
		MathLangParser.not_logic_return not_logic20 = default(MathLangParser.not_logic_return);

		object set19_tree=null;

		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(145, 62);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:145:5: ( not_logic ( ( MUL | DIVIS | MOD | DIV ) not_logic )* )
			DebugEnterAlt(1);
			// MathLang.g:145:8: not_logic ( ( MUL | DIVIS | MOD | DIV ) not_logic )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(145, 8);
			PushFollow(Follow._not_logic_in_mult1125);
			not_logic18=not_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not_logic18.Tree);
			DebugLocation(145, 18);
			// MathLang.g:145:18: ( ( MUL | DIVIS | MOD | DIV ) not_logic )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if (((LA4_0>=DIV && LA4_0<=MOD)||(LA4_0>=MUL && LA4_0<=DIVIS)))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:145:20: ( MUL | DIVIS | MOD | DIV ) not_logic
					{
					DebugLocation(145, 20);
					set19=(IToken)input.LT(1);
					set19=(IToken)input.LT(1);
					if ((input.LA(1)>=DIV && input.LA(1)<=MOD)||(input.LA(1)>=MUL && input.LA(1)<=DIVIS))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set19), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(145, 49);
					PushFollow(Follow._not_logic_in_mult1148);
					not_logic20=not_logic();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not_logic20.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mult", 6);
			LeaveRule("mult", 6);
			Leave_mult();
			if (state.backtracking > 0) { Memoize(input, 6, mult_StartIndex); }
		}
		DebugLocation(145, 62);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// MathLang.g:146:1: add : mult ( ( ADD | SUB ) mult )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 7);
		TraceIn("add", 7);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set22=null;
		MathLangParser.mult_return mult21 = default(MathLangParser.mult_return);
		MathLangParser.mult_return mult23 = default(MathLangParser.mult_return);

		object set22_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(146, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:146:4: ( mult ( ( ADD | SUB ) mult )* )
			DebugEnterAlt(1);
			// MathLang.g:146:7: mult ( ( ADD | SUB ) mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(146, 7);
			PushFollow(Follow._mult_in_add1160);
			mult21=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult21.Tree);
			DebugLocation(146, 13);
			// MathLang.g:146:13: ( ( ADD | SUB ) mult )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>=ADD && LA5_0<=SUB)))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:146:15: ( ADD | SUB ) mult
					{
					DebugLocation(146, 15);
					set22=(IToken)input.LT(1);
					set22=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set22), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(146, 30);
					PushFollow(Follow._mult_in_add1176);
					mult23=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult23.Tree);

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add", 7);
			LeaveRule("add", 7);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 7, add_StartIndex); }
		}
		DebugLocation(146, 39);
		} finally { DebugExitRule(GrammarFileName, "add"); }
		return retval;

	}
	// $ANTLR end "add"

	public class compare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_compare();
	partial void Leave_compare();

	// $ANTLR start "compare"
	// MathLang.g:147:1: compare : add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 8);
		TraceIn("compare", 8);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set25=null;
		MathLangParser.add_return add24 = default(MathLangParser.add_return);
		MathLangParser.add_return add26 = default(MathLangParser.add_return);

		object set25_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(147, 66);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:147:8: ( add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:147:10: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(147, 10);
			PushFollow(Follow._add_in_compare1188);
			add24=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add24.Tree);
			DebugLocation(147, 16);
			// MathLang.g:147:16: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			int alt6=2;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if (((LA6_0>=GE && LA6_0<=LT)))
			{
				alt6=1;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:147:18: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
				{
				DebugLocation(147, 18);
				set25=(IToken)input.LT(1);
				set25=(IToken)input.LT(1);
				if ((input.LA(1)>=GE && input.LA(1)<=LT))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set25), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(147, 60);
				PushFollow(Follow._add_in_compare1221);
				add26=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add26.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(6); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("compare", 8);
			LeaveRule("compare", 8);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 8, compare_StartIndex); }
		}
		DebugLocation(147, 66);
		} finally { DebugExitRule(GrammarFileName, "compare"); }
		return retval;

	}
	// $ANTLR end "compare"

	public class and_logic_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_and_logic();
	partial void Leave_and_logic();

	// $ANTLR start "and_logic"
	// MathLang.g:149:1: and_logic : compare ( AND compare )* ;
	[GrammarRule("and_logic")]
	private MathLangParser.and_logic_return and_logic()
	{
		Enter_and_logic();
		EnterRule("and_logic", 9);
		TraceIn("and_logic", 9);
		MathLangParser.and_logic_return retval = new MathLangParser.and_logic_return();
		retval.Start = (IToken)input.LT(1);
		int and_logic_StartIndex = input.Index;
		object root_0 = null;

		IToken AND28=null;
		MathLangParser.compare_return compare27 = default(MathLangParser.compare_return);
		MathLangParser.compare_return compare29 = default(MathLangParser.compare_return);

		object AND28_tree=null;

		try { DebugEnterRule(GrammarFileName, "and_logic");
		DebugLocation(149, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:149:10: ( compare ( AND compare )* )
			DebugEnterAlt(1);
			// MathLang.g:149:12: compare ( AND compare )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(149, 12);
			PushFollow(Follow._compare_in_and_logic1232);
			compare27=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare27.Tree);
			DebugLocation(149, 21);
			// MathLang.g:149:21: ( AND compare )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0==AND))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:149:23: AND compare
					{
					DebugLocation(149, 26);
					AND28=(IToken)Match(input,AND,Follow._AND_in_and_logic1237); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND28_tree = (object)adaptor.Create(AND28);
					root_0 = (object)adaptor.BecomeRoot(AND28_tree, root_0);
					}
					DebugLocation(149, 28);
					PushFollow(Follow._compare_in_and_logic1240);
					compare29=compare();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare29.Tree);

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("and_logic", 9);
			LeaveRule("and_logic", 9);
			Leave_and_logic();
			if (state.backtracking > 0) { Memoize(input, 9, and_logic_StartIndex); }
		}
		DebugLocation(149, 38);
		} finally { DebugExitRule(GrammarFileName, "and_logic"); }
		return retval;

	}
	// $ANTLR end "and_logic"

	public class or_logic_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_or_logic();
	partial void Leave_or_logic();

	// $ANTLR start "or_logic"
	// MathLang.g:150:1: or_logic : and_logic ( OR and_logic )* ;
	[GrammarRule("or_logic")]
	private MathLangParser.or_logic_return or_logic()
	{
		Enter_or_logic();
		EnterRule("or_logic", 10);
		TraceIn("or_logic", 10);
		MathLangParser.or_logic_return retval = new MathLangParser.or_logic_return();
		retval.Start = (IToken)input.LT(1);
		int or_logic_StartIndex = input.Index;
		object root_0 = null;

		IToken OR31=null;
		MathLangParser.and_logic_return and_logic30 = default(MathLangParser.and_logic_return);
		MathLangParser.and_logic_return and_logic32 = default(MathLangParser.and_logic_return);

		object OR31_tree=null;

		try { DebugEnterRule(GrammarFileName, "or_logic");
		DebugLocation(150, 40);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:150:9: ( and_logic ( OR and_logic )* )
			DebugEnterAlt(1);
			// MathLang.g:150:11: and_logic ( OR and_logic )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(150, 11);
			PushFollow(Follow._and_logic_in_or_logic1250);
			and_logic30=and_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic30.Tree);
			DebugLocation(150, 21);
			// MathLang.g:150:21: ( OR and_logic )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if ((LA8_0==OR))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:150:23: OR and_logic
					{
					DebugLocation(150, 25);
					OR31=(IToken)Match(input,OR,Follow._OR_in_or_logic1254); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR31_tree = (object)adaptor.Create(OR31);
					root_0 = (object)adaptor.BecomeRoot(OR31_tree, root_0);
					}
					DebugLocation(150, 28);
					PushFollow(Follow._and_logic_in_or_logic1258);
					and_logic32=and_logic();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic32.Tree);

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

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("or_logic", 10);
			LeaveRule("or_logic", 10);
			Leave_or_logic();
			if (state.backtracking > 0) { Memoize(input, 10, or_logic_StartIndex); }
		}
		DebugLocation(150, 40);
		} finally { DebugExitRule(GrammarFileName, "or_logic"); }
		return retval;

	}
	// $ANTLR end "or_logic"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// MathLang.g:152:1: term : or_logic ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 11);
		TraceIn("term", 11);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.or_logic_return or_logic33 = default(MathLangParser.or_logic_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(152, 16);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:152:5: ( or_logic )
			DebugEnterAlt(1);
			// MathLang.g:152:8: or_logic
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(152, 8);
			PushFollow(Follow._or_logic_in_term1270);
			or_logic33=or_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or_logic33.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 11);
			LeaveRule("term", 11);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 11, term_StartIndex); }
		}
		DebugLocation(152, 16);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class paramsad_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_paramsad();
	partial void Leave_paramsad();

	// $ANTLR start "paramsad"
	// MathLang.g:154:1: paramsad : ( assignOrCall | character );
	[GrammarRule("paramsad")]
	private MathLangParser.paramsad_return paramsad()
	{
		Enter_paramsad();
		EnterRule("paramsad", 12);
		TraceIn("paramsad", 12);
		MathLangParser.paramsad_return retval = new MathLangParser.paramsad_return();
		retval.Start = (IToken)input.LT(1);
		int paramsad_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.assignOrCall_return assignOrCall34 = default(MathLangParser.assignOrCall_return);
		MathLangParser.character_return character35 = default(MathLangParser.character_return);


		try { DebugEnterRule(GrammarFileName, "paramsad");
		DebugLocation(154, 37);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:154:9: ( assignOrCall | character )
			int alt9=2;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			int LA9_0 = input.LA(1);

			if ((LA9_0==IDENT))
			{
				int LA9_1 = input.LA(2);

				if (((LA9_1>=ASSIGN && LA9_1<=65)))
				{
					alt9=1;
				}
				else if ((LA9_1==EOF||(LA9_1>=66 && LA9_1<=67)||LA9_1==69))
				{
					alt9=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 9, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA9_0==NUMBER))
			{
				alt9=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:154:11: assignOrCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(154, 11);
				PushFollow(Follow._assignOrCall_in_paramsad1278);
				assignOrCall34=assignOrCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignOrCall34.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:154:26: character
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(154, 26);
				PushFollow(Follow._character_in_paramsad1282);
				character35=character();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, character35.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("paramsad", 12);
			LeaveRule("paramsad", 12);
			Leave_paramsad();
			if (state.backtracking > 0) { Memoize(input, 12, paramsad_StartIndex); }
		}
		DebugLocation(154, 37);
		} finally { DebugExitRule(GrammarFileName, "paramsad"); }
		return retval;

	}
	// $ANTLR end "paramsad"

	public class params__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_params_();
	partial void Leave_params_();

	// $ANTLR start "params_"
	// MathLang.g:156:1: params_ : ( paramsad ( ',' paramsad )* )? -> ^( PARAMS ( paramsad )* ) ;
	[GrammarRule("params_")]
	private MathLangParser.params__return params_()
	{
		Enter_params_();
		EnterRule("params_", 13);
		TraceIn("params_", 13);
		MathLangParser.params__return retval = new MathLangParser.params__return();
		retval.Start = (IToken)input.LT(1);
		int params__StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal37=null;
		MathLangParser.paramsad_return paramsad36 = default(MathLangParser.paramsad_return);
		MathLangParser.paramsad_return paramsad38 = default(MathLangParser.paramsad_return);

		object char_literal37_tree=null;
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleSubtreeStream stream_paramsad=new RewriteRuleSubtreeStream(adaptor,"rule paramsad");
		try { DebugEnterRule(GrammarFileName, "params_");
		DebugLocation(156, 70);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:156:8: ( ( paramsad ( ',' paramsad )* )? -> ^( PARAMS ( paramsad )* ) )
			DebugEnterAlt(1);
			// MathLang.g:156:10: ( paramsad ( ',' paramsad )* )?
			{
			DebugLocation(156, 10);
			// MathLang.g:156:10: ( paramsad ( ',' paramsad )* )?
			int alt11=2;
			try { DebugEnterSubRule(11);
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if (((LA11_0>=NUMBER && LA11_0<=IDENT)))
			{
				alt11=1;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:156:12: paramsad ( ',' paramsad )*
				{
				DebugLocation(156, 12);
				PushFollow(Follow._paramsad_in_params_1294);
				paramsad36=paramsad();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsad.Add(paramsad36.Tree);
				DebugLocation(156, 22);
				// MathLang.g:156:22: ( ',' paramsad )*
				try { DebugEnterSubRule(10);
				while (true)
				{
					int alt10=2;
					try { DebugEnterDecision(10, decisionCanBacktrack[10]);
					int LA10_0 = input.LA(1);

					if ((LA10_0==69))
					{
						alt10=1;
					}


					} finally { DebugExitDecision(10); }
					switch ( alt10 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:156:24: ',' paramsad
						{
						DebugLocation(156, 24);
						char_literal37=(IToken)Match(input,69,Follow._69_in_params_1299); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_69.Add(char_literal37);

						DebugLocation(156, 28);
						PushFollow(Follow._paramsad_in_params_1301);
						paramsad38=paramsad();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_paramsad.Add(paramsad38.Tree);

						}
						break;

					default:
						goto loop10;
					}
				}

				loop10:
					;

				} finally { DebugExitSubRule(10); }


				}
				break;

			}
			} finally { DebugExitSubRule(11); }



			{
			// AST REWRITE
			// elements: paramsad
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 156:44: -> ^( PARAMS ( paramsad )* )
			{
				DebugLocation(156, 48);
				// MathLang.g:156:48: ^( PARAMS ( paramsad )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(156, 51);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_1);

				DebugLocation(156, 58);
				// MathLang.g:156:58: ( paramsad )*
				while ( stream_paramsad.HasNext )
				{
					DebugLocation(156, 58);
					adaptor.AddChild(root_1, stream_paramsad.NextTree());

				}
				stream_paramsad.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("params_", 13);
			LeaveRule("params_", 13);
			Leave_params_();
			if (state.backtracking > 0) { Memoize(input, 13, params__StartIndex); }
		}
		DebugLocation(156, 70);
		} finally { DebugExitRule(GrammarFileName, "params_"); }
		return retval;

	}
	// $ANTLR end "params_"

	public class thenPart_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_thenPart();
	partial void Leave_thenPart();

	// $ANTLR start "thenPart"
	// MathLang.g:159:1: thenPart : THEN operList ;
	[GrammarRule("thenPart")]
	private MathLangParser.thenPart_return thenPart()
	{
		Enter_thenPart();
		EnterRule("thenPart", 14);
		TraceIn("thenPart", 14);
		MathLangParser.thenPart_return retval = new MathLangParser.thenPart_return();
		retval.Start = (IToken)input.LT(1);
		int thenPart_StartIndex = input.Index;
		object root_0 = null;

		IToken THEN39=null;
		MathLangParser.operList_return operList40 = default(MathLangParser.operList_return);

		object THEN39_tree=null;

		try { DebugEnterRule(GrammarFileName, "thenPart");
		DebugLocation(159, 26);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:159:9: ( THEN operList )
			DebugEnterAlt(1);
			// MathLang.g:159:11: THEN operList
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(159, 15);
			THEN39=(IToken)Match(input,THEN,Follow._THEN_in_thenPart1330); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			THEN39_tree = (object)adaptor.Create(THEN39);
			root_0 = (object)adaptor.BecomeRoot(THEN39_tree, root_0);
			}
			DebugLocation(159, 17);
			PushFollow(Follow._operList_in_thenPart1333);
			operList40=operList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operList40.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("thenPart", 14);
			LeaveRule("thenPart", 14);
			Leave_thenPart();
			if (state.backtracking > 0) { Memoize(input, 14, thenPart_StartIndex); }
		}
		DebugLocation(159, 26);
		} finally { DebugExitRule(GrammarFileName, "thenPart"); }
		return retval;

	}
	// $ANTLR end "thenPart"

	public class elsePart_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_elsePart();
	partial void Leave_elsePart();

	// $ANTLR start "elsePart"
	// MathLang.g:160:1: elsePart : ';' ELSE operList ;
	[GrammarRule("elsePart")]
	private MathLangParser.elsePart_return elsePart()
	{
		Enter_elsePart();
		EnterRule("elsePart", 15);
		TraceIn("elsePart", 15);
		MathLangParser.elsePart_return retval = new MathLangParser.elsePart_return();
		retval.Start = (IToken)input.LT(1);
		int elsePart_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal41=null;
		IToken ELSE42=null;
		MathLangParser.operList_return operList43 = default(MathLangParser.operList_return);

		object char_literal41_tree=null;
		object ELSE42_tree=null;

		try { DebugEnterRule(GrammarFileName, "elsePart");
		DebugLocation(160, 30);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:160:9: ( ';' ELSE operList )
			DebugEnterAlt(1);
			// MathLang.g:160:11: ';' ELSE operList
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(160, 14);
			char_literal41=(IToken)Match(input,70,Follow._70_in_elsePart1341); if (state.failed) return retval;
			DebugLocation(160, 20);
			ELSE42=(IToken)Match(input,ELSE,Follow._ELSE_in_elsePart1344); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ELSE42_tree = (object)adaptor.Create(ELSE42);
			root_0 = (object)adaptor.BecomeRoot(ELSE42_tree, root_0);
			}
			DebugLocation(160, 22);
			PushFollow(Follow._operList_in_elsePart1347);
			operList43=operList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operList43.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("elsePart", 15);
			LeaveRule("elsePart", 15);
			Leave_elsePart();
			if (state.backtracking > 0) { Memoize(input, 15, elsePart_StartIndex); }
		}
		DebugLocation(160, 30);
		} finally { DebugExitRule(GrammarFileName, "elsePart"); }
		return retval;

	}
	// $ANTLR end "elsePart"

	public class ifThenElse_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_ifThenElse();
	partial void Leave_ifThenElse();

	// $ANTLR start "ifThenElse"
	// MathLang.g:161:1: ifThenElse : IF term thenPart ( elsePart )? ;
	[GrammarRule("ifThenElse")]
	private MathLangParser.ifThenElse_return ifThenElse()
	{
		Enter_ifThenElse();
		EnterRule("ifThenElse", 16);
		TraceIn("ifThenElse", 16);
		MathLangParser.ifThenElse_return retval = new MathLangParser.ifThenElse_return();
		retval.Start = (IToken)input.LT(1);
		int ifThenElse_StartIndex = input.Index;
		object root_0 = null;

		IToken IF44=null;
		MathLangParser.term_return term45 = default(MathLangParser.term_return);
		MathLangParser.thenPart_return thenPart46 = default(MathLangParser.thenPart_return);
		MathLangParser.elsePart_return elsePart47 = default(MathLangParser.elsePart_return);

		object IF44_tree=null;

		try { DebugEnterRule(GrammarFileName, "ifThenElse");
		DebugLocation(161, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:161:11: ( IF term thenPart ( elsePart )? )
			DebugEnterAlt(1);
			// MathLang.g:161:13: IF term thenPart ( elsePart )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(161, 15);
			IF44=(IToken)Match(input,IF,Follow._IF_in_ifThenElse1354); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF44_tree = (object)adaptor.Create(IF44);
			root_0 = (object)adaptor.BecomeRoot(IF44_tree, root_0);
			}
			DebugLocation(161, 17);
			PushFollow(Follow._term_in_ifThenElse1357);
			term45=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term45.Tree);
			DebugLocation(161, 22);
			PushFollow(Follow._thenPart_in_ifThenElse1359);
			thenPart46=thenPart();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, thenPart46.Tree);
			DebugLocation(161, 31);
			// MathLang.g:161:31: ( elsePart )?
			int alt12=2;
			try { DebugEnterSubRule(12);
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==70))
			{
				int LA12_1 = input.LA(2);

				if ((EvaluatePredicate(synpred26_MathLang_fragment)))
				{
					alt12=1;
				}
			}
			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: elsePart
				{
				DebugLocation(161, 31);
				PushFollow(Follow._elsePart_in_ifThenElse1361);
				elsePart47=elsePart();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elsePart47.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(12); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ifThenElse", 16);
			LeaveRule("ifThenElse", 16);
			Leave_ifThenElse();
			if (state.backtracking > 0) { Memoize(input, 16, ifThenElse_StartIndex); }
		}
		DebugLocation(162, 0);
		} finally { DebugExitRule(GrammarFileName, "ifThenElse"); }
		return retval;

	}
	// $ANTLR end "ifThenElse"

	public class forDo_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_forDo();
	partial void Leave_forDo();

	// $ANTLR start "forDo"
	// MathLang.g:164:1: forDo : FOR main= IDENT ASSIGN from= character TO to= term DO operList -> ^( FOR ^( FROM ^( ASSIGN $main $from) ) ^( TO $to) ^( DO operList ) ) ;
	[GrammarRule("forDo")]
	private MathLangParser.forDo_return forDo()
	{
		Enter_forDo();
		EnterRule("forDo", 17);
		TraceIn("forDo", 17);
		MathLangParser.forDo_return retval = new MathLangParser.forDo_return();
		retval.Start = (IToken)input.LT(1);
		int forDo_StartIndex = input.Index;
		object root_0 = null;

		IToken main=null;
		IToken FOR48=null;
		IToken ASSIGN49=null;
		IToken TO50=null;
		IToken DO51=null;
		MathLangParser.character_return from = default(MathLangParser.character_return);
		MathLangParser.term_return to = default(MathLangParser.term_return);
		MathLangParser.operList_return operList52 = default(MathLangParser.operList_return);

		object main_tree=null;
		object FOR48_tree=null;
		object ASSIGN49_tree=null;
		object TO50_tree=null;
		object DO51_tree=null;
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
		RewriteRuleITokenStream stream_TO=new RewriteRuleITokenStream(adaptor,"token TO");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		RewriteRuleSubtreeStream stream_operList=new RewriteRuleSubtreeStream(adaptor,"rule operList");
		RewriteRuleSubtreeStream stream_character=new RewriteRuleSubtreeStream(adaptor,"rule character");
		try { DebugEnterRule(GrammarFileName, "forDo");
		DebugLocation(164, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:164:6: ( FOR main= IDENT ASSIGN from= character TO to= term DO operList -> ^( FOR ^( FROM ^( ASSIGN $main $from) ) ^( TO $to) ^( DO operList ) ) )
			DebugEnterAlt(1);
			// MathLang.g:164:8: FOR main= IDENT ASSIGN from= character TO to= term DO operList
			{
			DebugLocation(164, 8);
			FOR48=(IToken)Match(input,FOR,Follow._FOR_in_forDo1371); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FOR.Add(FOR48);

			DebugLocation(164, 16);
			main=(IToken)Match(input,IDENT,Follow._IDENT_in_forDo1375); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(main);

			DebugLocation(164, 23);
			ASSIGN49=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_forDo1377); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN49);

			DebugLocation(164, 34);
			PushFollow(Follow._character_in_forDo1381);
			from=character();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_character.Add(from.Tree);
			DebugLocation(164, 45);
			TO50=(IToken)Match(input,TO,Follow._TO_in_forDo1383); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_TO.Add(TO50);

			DebugLocation(164, 50);
			PushFollow(Follow._term_in_forDo1387);
			to=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_term.Add(to.Tree);
			DebugLocation(164, 56);
			DO51=(IToken)Match(input,DO,Follow._DO_in_forDo1389); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DO.Add(DO51);

			DebugLocation(164, 59);
			PushFollow(Follow._operList_in_forDo1391);
			operList52=operList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_operList.Add(operList52.Tree);


			{
			// AST REWRITE
			// elements: FOR, operList, TO, from, main, DO, to, ASSIGN
			// token labels: main
			// rule labels: to, retval, from
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleITokenStream stream_main=new RewriteRuleITokenStream(adaptor,"token main",main);
			RewriteRuleSubtreeStream stream_to=new RewriteRuleSubtreeStream(adaptor,"rule to",to!=null?to.Tree:null);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_from=new RewriteRuleSubtreeStream(adaptor,"rule from",from!=null?from.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 165:4: -> ^( FOR ^( FROM ^( ASSIGN $main $from) ) ^( TO $to) ^( DO operList ) )
			{
				DebugLocation(165, 7);
				// MathLang.g:165:7: ^( FOR ^( FROM ^( ASSIGN $main $from) ) ^( TO $to) ^( DO operList ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(165, 10);
				root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

				DebugLocation(166, 5);
				// MathLang.g:166:5: ^( FROM ^( ASSIGN $main $from) )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(166, 8);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FROM, "FROM"), root_2);

				DebugLocation(166, 13);
				// MathLang.g:166:13: ^( ASSIGN $main $from)
				{
				object root_3 = (object)adaptor.Nil();
				DebugLocation(166, 16);
				root_3 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_3);

				DebugLocation(166, 23);
				adaptor.AddChild(root_3, stream_main.NextNode());
				DebugLocation(166, 29);
				adaptor.AddChild(root_3, stream_from.NextTree());

				adaptor.AddChild(root_2, root_3);
				}

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(167, 5);
				// MathLang.g:167:5: ^( TO $to)
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(167, 8);
				root_2 = (object)adaptor.BecomeRoot(stream_TO.NextNode(), root_2);

				DebugLocation(167, 11);
				adaptor.AddChild(root_2, stream_to.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(168, 5);
				// MathLang.g:168:5: ^( DO operList )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(168, 8);
				root_2 = (object)adaptor.BecomeRoot(stream_DO.NextNode(), root_2);

				DebugLocation(168, 11);
				adaptor.AddChild(root_2, stream_operList.NextTree());

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("forDo", 17);
			LeaveRule("forDo", 17);
			Leave_forDo();
			if (state.backtracking > 0) { Memoize(input, 17, forDo_StartIndex); }
		}
		DebugLocation(169, 1);
		} finally { DebugExitRule(GrammarFileName, "forDo"); }
		return retval;

	}
	// $ANTLR end "forDo"

	public class whileDo_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_whileDo();
	partial void Leave_whileDo();

	// $ANTLR start "whileDo"
	// MathLang.g:171:1: whileDo : WHILE term DO operList -> ^( WHILE term ^( DO operList ) ) ;
	[GrammarRule("whileDo")]
	private MathLangParser.whileDo_return whileDo()
	{
		Enter_whileDo();
		EnterRule("whileDo", 18);
		TraceIn("whileDo", 18);
		MathLangParser.whileDo_return retval = new MathLangParser.whileDo_return();
		retval.Start = (IToken)input.LT(1);
		int whileDo_StartIndex = input.Index;
		object root_0 = null;

		IToken WHILE53=null;
		IToken DO55=null;
		MathLangParser.term_return term54 = default(MathLangParser.term_return);
		MathLangParser.operList_return operList56 = default(MathLangParser.operList_return);

		object WHILE53_tree=null;
		object DO55_tree=null;
		RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
		RewriteRuleITokenStream stream_WHILE=new RewriteRuleITokenStream(adaptor,"token WHILE");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		RewriteRuleSubtreeStream stream_operList=new RewriteRuleSubtreeStream(adaptor,"rule operList");
		try { DebugEnterRule(GrammarFileName, "whileDo");
		DebugLocation(171, 68);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:171:8: ( WHILE term DO operList -> ^( WHILE term ^( DO operList ) ) )
			DebugEnterAlt(1);
			// MathLang.g:171:10: WHILE term DO operList
			{
			DebugLocation(171, 10);
			WHILE53=(IToken)Match(input,WHILE,Follow._WHILE_in_whileDo1459); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_WHILE.Add(WHILE53);

			DebugLocation(171, 16);
			PushFollow(Follow._term_in_whileDo1461);
			term54=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_term.Add(term54.Tree);
			DebugLocation(171, 21);
			DO55=(IToken)Match(input,DO,Follow._DO_in_whileDo1463); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_DO.Add(DO55);

			DebugLocation(171, 24);
			PushFollow(Follow._operList_in_whileDo1465);
			operList56=operList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_operList.Add(operList56.Tree);


			{
			// AST REWRITE
			// elements: term, WHILE, operList, DO
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 171:33: -> ^( WHILE term ^( DO operList ) )
			{
				DebugLocation(171, 36);
				// MathLang.g:171:36: ^( WHILE term ^( DO operList ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(171, 39);
				root_1 = (object)adaptor.BecomeRoot(stream_WHILE.NextNode(), root_1);

				DebugLocation(171, 45);
				adaptor.AddChild(root_1, stream_term.NextTree());
				DebugLocation(171, 50);
				// MathLang.g:171:50: ^( DO operList )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(171, 53);
				root_2 = (object)adaptor.BecomeRoot(stream_DO.NextNode(), root_2);

				DebugLocation(171, 56);
				adaptor.AddChild(root_2, stream_operList.NextTree());

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("whileDo", 18);
			LeaveRule("whileDo", 18);
			Leave_whileDo();
			if (state.backtracking > 0) { Memoize(input, 18, whileDo_StartIndex); }
		}
		DebugLocation(171, 68);
		} finally { DebugExitRule(GrammarFileName, "whileDo"); }
		return retval;

	}
	// $ANTLR end "whileDo"

	public class repeatUntil_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_repeatUntil();
	partial void Leave_repeatUntil();

	// $ANTLR start "repeatUntil"
	// MathLang.g:173:1: repeatUntil : REPEAT operList UNTIL term -> ^( REPEAT operList ^( UNTIL term ) ) ;
	[GrammarRule("repeatUntil")]
	private MathLangParser.repeatUntil_return repeatUntil()
	{
		Enter_repeatUntil();
		EnterRule("repeatUntil", 19);
		TraceIn("repeatUntil", 19);
		MathLangParser.repeatUntil_return retval = new MathLangParser.repeatUntil_return();
		retval.Start = (IToken)input.LT(1);
		int repeatUntil_StartIndex = input.Index;
		object root_0 = null;

		IToken REPEAT57=null;
		IToken UNTIL59=null;
		MathLangParser.operList_return operList58 = default(MathLangParser.operList_return);
		MathLangParser.term_return term60 = default(MathLangParser.term_return);

		object REPEAT57_tree=null;
		object UNTIL59_tree=null;
		RewriteRuleITokenStream stream_REPEAT=new RewriteRuleITokenStream(adaptor,"token REPEAT");
		RewriteRuleITokenStream stream_UNTIL=new RewriteRuleITokenStream(adaptor,"token UNTIL");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		RewriteRuleSubtreeStream stream_operList=new RewriteRuleSubtreeStream(adaptor,"rule operList");
		try { DebugEnterRule(GrammarFileName, "repeatUntil");
		DebugLocation(173, 79);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:173:12: ( REPEAT operList UNTIL term -> ^( REPEAT operList ^( UNTIL term ) ) )
			DebugEnterAlt(1);
			// MathLang.g:173:14: REPEAT operList UNTIL term
			{
			DebugLocation(173, 14);
			REPEAT57=(IToken)Match(input,REPEAT,Follow._REPEAT_in_repeatUntil1491); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_REPEAT.Add(REPEAT57);

			DebugLocation(173, 21);
			PushFollow(Follow._operList_in_repeatUntil1493);
			operList58=operList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_operList.Add(operList58.Tree);
			DebugLocation(173, 30);
			UNTIL59=(IToken)Match(input,UNTIL,Follow._UNTIL_in_repeatUntil1495); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_UNTIL.Add(UNTIL59);

			DebugLocation(173, 36);
			PushFollow(Follow._term_in_repeatUntil1497);
			term60=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_term.Add(term60.Tree);


			{
			// AST REWRITE
			// elements: term, operList, REPEAT, UNTIL
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 173:41: -> ^( REPEAT operList ^( UNTIL term ) )
			{
				DebugLocation(173, 44);
				// MathLang.g:173:44: ^( REPEAT operList ^( UNTIL term ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(173, 46);
				root_1 = (object)adaptor.BecomeRoot(stream_REPEAT.NextNode(), root_1);

				DebugLocation(173, 53);
				adaptor.AddChild(root_1, stream_operList.NextTree());
				DebugLocation(173, 62);
				// MathLang.g:173:62: ^( UNTIL term )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(173, 65);
				root_2 = (object)adaptor.BecomeRoot(stream_UNTIL.NextNode(), root_2);

				DebugLocation(173, 71);
				adaptor.AddChild(root_2, stream_term.NextTree());

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("repeatUntil", 19);
			LeaveRule("repeatUntil", 19);
			Leave_repeatUntil();
			if (state.backtracking > 0) { Memoize(input, 19, repeatUntil_StartIndex); }
		}
		DebugLocation(173, 79);
		} finally { DebugExitRule(GrammarFileName, "repeatUntil"); }
		return retval;

	}
	// $ANTLR end "repeatUntil"

	public class assignOrCall_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assignOrCall();
	partial void Leave_assignOrCall();

	// $ANTLR start "assignOrCall"
	// MathLang.g:177:1: assignOrCall : ( ( IDENT ASSIGN IDENT '(' params_ ')' -> ^( ASSIGN IDENT ^( CALL IDENT params_ ) ) ) | ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) ) );
	[GrammarRule("assignOrCall")]
	private MathLangParser.assignOrCall_return assignOrCall()
	{
		Enter_assignOrCall();
		EnterRule("assignOrCall", 20);
		TraceIn("assignOrCall", 20);
		MathLangParser.assignOrCall_return retval = new MathLangParser.assignOrCall_return();
		retval.Start = (IToken)input.LT(1);
		int assignOrCall_StartIndex = input.Index;
		object root_0 = null;

		IToken IDENT61=null;
		IToken ASSIGN62=null;
		IToken IDENT63=null;
		IToken char_literal64=null;
		IToken char_literal66=null;
		IToken IDENT67=null;
		IToken char_literal68=null;
		IToken char_literal70=null;
		MathLangParser.params__return params_65 = default(MathLangParser.params__return);
		MathLangParser.params__return params_69 = default(MathLangParser.params__return);

		object IDENT61_tree=null;
		object ASSIGN62_tree=null;
		object IDENT63_tree=null;
		object char_literal64_tree=null;
		object char_literal66_tree=null;
		object IDENT67_tree=null;
		object char_literal68_tree=null;
		object char_literal70_tree=null;
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_params_=new RewriteRuleSubtreeStream(adaptor,"rule params_");
		try { DebugEnterRule(GrammarFileName, "assignOrCall");
		DebugLocation(177, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:177:13: ( ( IDENT ASSIGN IDENT '(' params_ ')' -> ^( ASSIGN IDENT ^( CALL IDENT params_ ) ) ) | ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) ) )
			int alt13=2;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==IDENT))
			{
				int LA13_1 = input.LA(2);

				if ((LA13_1==ASSIGN))
				{
					alt13=1;
				}
				else if ((LA13_1==65))
				{
					alt13=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 13, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:178:2: ( IDENT ASSIGN IDENT '(' params_ ')' -> ^( ASSIGN IDENT ^( CALL IDENT params_ ) ) )
				{
				DebugLocation(178, 2);
				// MathLang.g:178:2: ( IDENT ASSIGN IDENT '(' params_ ')' -> ^( ASSIGN IDENT ^( CALL IDENT params_ ) ) )
				DebugEnterAlt(1);
				// MathLang.g:178:4: IDENT ASSIGN IDENT '(' params_ ')'
				{
				DebugLocation(178, 4);
				IDENT61=(IToken)Match(input,IDENT,Follow._IDENT_in_assignOrCall1527); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT61);

				DebugLocation(178, 10);
				ASSIGN62=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assignOrCall1529); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN62);

				DebugLocation(178, 17);
				IDENT63=(IToken)Match(input,IDENT,Follow._IDENT_in_assignOrCall1531); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT63);

				DebugLocation(178, 23);
				char_literal64=(IToken)Match(input,65,Follow._65_in_assignOrCall1533); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(char_literal64);

				DebugLocation(178, 27);
				PushFollow(Follow._params__in_assignOrCall1535);
				params_65=params_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_params_.Add(params_65.Tree);
				DebugLocation(178, 35);
				char_literal66=(IToken)Match(input,66,Follow._66_in_assignOrCall1537); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_66.Add(char_literal66);



				{
				// AST REWRITE
				// elements: ASSIGN, IDENT, params_, IDENT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 179:3: -> ^( ASSIGN IDENT ^( CALL IDENT params_ ) )
				{
					DebugLocation(179, 6);
					// MathLang.g:179:6: ^( ASSIGN IDENT ^( CALL IDENT params_ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(179, 9);
					root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

					DebugLocation(179, 16);
					adaptor.AddChild(root_1, stream_IDENT.NextNode());
					DebugLocation(179, 22);
					// MathLang.g:179:22: ^( CALL IDENT params_ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(179, 25);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_2);

					DebugLocation(179, 30);
					adaptor.AddChild(root_2, stream_IDENT.NextNode());
					DebugLocation(179, 36);
					adaptor.AddChild(root_2, stream_params_.NextTree());

					adaptor.AddChild(root_1, root_2);
					}

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:180:3: ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) )
				{
				DebugLocation(180, 3);
				// MathLang.g:180:3: ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) )
				DebugEnterAlt(1);
				// MathLang.g:180:5: IDENT '(' params_ ')'
				{
				DebugLocation(180, 5);
				IDENT67=(IToken)Match(input,IDENT,Follow._IDENT_in_assignOrCall1567); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT67);

				DebugLocation(180, 11);
				char_literal68=(IToken)Match(input,65,Follow._65_in_assignOrCall1569); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(char_literal68);

				DebugLocation(180, 15);
				PushFollow(Follow._params__in_assignOrCall1571);
				params_69=params_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_params_.Add(params_69.Tree);
				DebugLocation(180, 23);
				char_literal70=(IToken)Match(input,66,Follow._66_in_assignOrCall1573); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_66.Add(char_literal70);



				{
				// AST REWRITE
				// elements: IDENT, params_
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 181:3: -> ^( CALL IDENT params_ )
				{
					DebugLocation(181, 6);
					// MathLang.g:181:6: ^( CALL IDENT params_ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(181, 9);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_1);

					DebugLocation(181, 14);
					adaptor.AddChild(root_1, stream_IDENT.NextNode());
					DebugLocation(181, 20);
					adaptor.AddChild(root_1, stream_params_.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assignOrCall", 20);
			LeaveRule("assignOrCall", 20);
			Leave_assignOrCall();
			if (state.backtracking > 0) { Memoize(input, 20, assignOrCall_StartIndex); }
		}
		DebugLocation(182, 0);
		} finally { DebugExitRule(GrammarFileName, "assignOrCall"); }
		return retval;

	}
	// $ANTLR end "assignOrCall"

	public class simpleExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_simpleExpr();
	partial void Leave_simpleExpr();

	// $ANTLR start "simpleExpr"
	// MathLang.g:185:1: simpleExpr : ( WRITE term | WRITELN term | READ term | WRITELN term | IDENT ASSIGN term | arrayId ASSIGN term | ifThenElse | forDo | whileDo | repeatUntil | assignOrCall );
	[GrammarRule("simpleExpr")]
	private MathLangParser.simpleExpr_return simpleExpr()
	{
		Enter_simpleExpr();
		EnterRule("simpleExpr", 21);
		TraceIn("simpleExpr", 21);
		MathLangParser.simpleExpr_return retval = new MathLangParser.simpleExpr_return();
		retval.Start = (IToken)input.LT(1);
		int simpleExpr_StartIndex = input.Index;
		object root_0 = null;

		IToken WRITE71=null;
		IToken WRITELN73=null;
		IToken READ75=null;
		IToken WRITELN77=null;
		IToken IDENT79=null;
		IToken ASSIGN80=null;
		IToken ASSIGN83=null;
		MathLangParser.term_return term72 = default(MathLangParser.term_return);
		MathLangParser.term_return term74 = default(MathLangParser.term_return);
		MathLangParser.term_return term76 = default(MathLangParser.term_return);
		MathLangParser.term_return term78 = default(MathLangParser.term_return);
		MathLangParser.term_return term81 = default(MathLangParser.term_return);
		MathLangParser.arrayId_return arrayId82 = default(MathLangParser.arrayId_return);
		MathLangParser.term_return term84 = default(MathLangParser.term_return);
		MathLangParser.ifThenElse_return ifThenElse85 = default(MathLangParser.ifThenElse_return);
		MathLangParser.forDo_return forDo86 = default(MathLangParser.forDo_return);
		MathLangParser.whileDo_return whileDo87 = default(MathLangParser.whileDo_return);
		MathLangParser.repeatUntil_return repeatUntil88 = default(MathLangParser.repeatUntil_return);
		MathLangParser.assignOrCall_return assignOrCall89 = default(MathLangParser.assignOrCall_return);

		object WRITE71_tree=null;
		object WRITELN73_tree=null;
		object READ75_tree=null;
		object WRITELN77_tree=null;
		object IDENT79_tree=null;
		object ASSIGN80_tree=null;
		object ASSIGN83_tree=null;

		try { DebugEnterRule(GrammarFileName, "simpleExpr");
		DebugLocation(185, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:185:11: ( WRITE term | WRITELN term | READ term | WRITELN term | IDENT ASSIGN term | arrayId ASSIGN term | ifThenElse | forDo | whileDo | repeatUntil | assignOrCall )
			int alt14=11;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			try
			{
				alt14 = dfa14.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:186:3: WRITE term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(186, 8);
				WRITE71=(IToken)Match(input,WRITE,Follow._WRITE_in_simpleExpr1602); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WRITE71_tree = (object)adaptor.Create(WRITE71);
				root_0 = (object)adaptor.BecomeRoot(WRITE71_tree, root_0);
				}
				DebugLocation(186, 10);
				PushFollow(Follow._term_in_simpleExpr1605);
				term72=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term72.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:187:3: WRITELN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(187, 10);
				WRITELN73=(IToken)Match(input,WRITELN,Follow._WRITELN_in_simpleExpr1609); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WRITELN73_tree = (object)adaptor.Create(WRITELN73);
				root_0 = (object)adaptor.BecomeRoot(WRITELN73_tree, root_0);
				}
				DebugLocation(187, 12);
				PushFollow(Follow._term_in_simpleExpr1612);
				term74=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term74.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:188:3: READ term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(188, 7);
				READ75=(IToken)Match(input,READ,Follow._READ_in_simpleExpr1616); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				READ75_tree = (object)adaptor.Create(READ75);
				root_0 = (object)adaptor.BecomeRoot(READ75_tree, root_0);
				}
				DebugLocation(188, 9);
				PushFollow(Follow._term_in_simpleExpr1619);
				term76=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term76.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:189:3: WRITELN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(189, 10);
				WRITELN77=(IToken)Match(input,WRITELN,Follow._WRITELN_in_simpleExpr1624); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WRITELN77_tree = (object)adaptor.Create(WRITELN77);
				root_0 = (object)adaptor.BecomeRoot(WRITELN77_tree, root_0);
				}
				DebugLocation(189, 12);
				PushFollow(Follow._term_in_simpleExpr1627);
				term78=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term78.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:190:3: IDENT ASSIGN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(190, 3);
				IDENT79=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1631); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT79_tree = (object)adaptor.Create(IDENT79);
				adaptor.AddChild(root_0, IDENT79_tree);
				}
				DebugLocation(190, 15);
				ASSIGN80=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1633); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGN80_tree = (object)adaptor.Create(ASSIGN80);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN80_tree, root_0);
				}
				DebugLocation(190, 17);
				PushFollow(Follow._term_in_simpleExpr1636);
				term81=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term81.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:191:3: arrayId ASSIGN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(191, 3);
				PushFollow(Follow._arrayId_in_simpleExpr1640);
				arrayId82=arrayId();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayId82.Tree);
				DebugLocation(191, 17);
				ASSIGN83=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1642); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGN83_tree = (object)adaptor.Create(ASSIGN83);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN83_tree, root_0);
				}
				DebugLocation(191, 19);
				PushFollow(Follow._term_in_simpleExpr1645);
				term84=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term84.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:192:3: ifThenElse
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(192, 3);
				PushFollow(Follow._ifThenElse_in_simpleExpr1649);
				ifThenElse85=ifThenElse();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifThenElse85.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:193:3: forDo
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(193, 3);
				PushFollow(Follow._forDo_in_simpleExpr1653);
				forDo86=forDo();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forDo86.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// MathLang.g:194:3: whileDo
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(194, 3);
				PushFollow(Follow._whileDo_in_simpleExpr1657);
				whileDo87=whileDo();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileDo87.Tree);

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// MathLang.g:195:3: repeatUntil
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(195, 3);
				PushFollow(Follow._repeatUntil_in_simpleExpr1661);
				repeatUntil88=repeatUntil();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, repeatUntil88.Tree);

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// MathLang.g:196:3: assignOrCall
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(196, 3);
				PushFollow(Follow._assignOrCall_in_simpleExpr1665);
				assignOrCall89=assignOrCall();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignOrCall89.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("simpleExpr", 21);
			LeaveRule("simpleExpr", 21);
			Leave_simpleExpr();
			if (state.backtracking > 0) { Memoize(input, 21, simpleExpr_StartIndex); }
		}
		DebugLocation(198, 0);
		} finally { DebugExitRule(GrammarFileName, "simpleExpr"); }
		return retval;

	}
	// $ANTLR end "simpleExpr"

	public class groupExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_groupExpr();
	partial void Leave_groupExpr();

	// $ANTLR start "groupExpr"
	// MathLang.g:200:1: groupExpr : ( BEGIN exprList END ) -> ^( BLOCK exprList ) ;
	[GrammarRule("groupExpr")]
	private MathLangParser.groupExpr_return groupExpr()
	{
		Enter_groupExpr();
		EnterRule("groupExpr", 22);
		TraceIn("groupExpr", 22);
		MathLangParser.groupExpr_return retval = new MathLangParser.groupExpr_return();
		retval.Start = (IToken)input.LT(1);
		int groupExpr_StartIndex = input.Index;
		object root_0 = null;

		IToken BEGIN90=null;
		IToken END92=null;
		MathLangParser.exprList_return exprList91 = default(MathLangParser.exprList_return);

		object BEGIN90_tree=null;
		object END92_tree=null;
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "groupExpr");
		DebugLocation(200, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:200:10: ( ( BEGIN exprList END ) -> ^( BLOCK exprList ) )
			DebugEnterAlt(1);
			// MathLang.g:200:12: ( BEGIN exprList END )
			{
			DebugLocation(200, 12);
			// MathLang.g:200:12: ( BEGIN exprList END )
			DebugEnterAlt(1);
			// MathLang.g:200:14: BEGIN exprList END
			{
			DebugLocation(200, 14);
			BEGIN90=(IToken)Match(input,BEGIN,Follow._BEGIN_in_groupExpr1676); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN90);

			DebugLocation(200, 20);
			PushFollow(Follow._exprList_in_groupExpr1678);
			exprList91=exprList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_exprList.Add(exprList91.Tree);
			DebugLocation(200, 29);
			END92=(IToken)Match(input,END,Follow._END_in_groupExpr1680); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END92);


			}



			{
			// AST REWRITE
			// elements: exprList
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 200:35: -> ^( BLOCK exprList )
			{
				DebugLocation(200, 38);
				// MathLang.g:200:38: ^( BLOCK exprList )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(200, 41);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(200, 47);
				adaptor.AddChild(root_1, stream_exprList.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("groupExpr", 22);
			LeaveRule("groupExpr", 22);
			Leave_groupExpr();
			if (state.backtracking > 0) { Memoize(input, 22, groupExpr_StartIndex); }
		}
		DebugLocation(200, 57);
		} finally { DebugExitRule(GrammarFileName, "groupExpr"); }
		return retval;

	}
	// $ANTLR end "groupExpr"

	public class operList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_operList();
	partial void Leave_operList();

	// $ANTLR start "operList"
	// MathLang.g:202:1: operList : ( simpleExpr | groupExpr );
	[GrammarRule("operList")]
	private MathLangParser.operList_return operList()
	{
		Enter_operList();
		EnterRule("operList", 23);
		TraceIn("operList", 23);
		MathLangParser.operList_return retval = new MathLangParser.operList_return();
		retval.Start = (IToken)input.LT(1);
		int operList_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.simpleExpr_return simpleExpr93 = default(MathLangParser.simpleExpr_return);
		MathLangParser.groupExpr_return groupExpr94 = default(MathLangParser.groupExpr_return);


		try { DebugEnterRule(GrammarFileName, "operList");
		DebugLocation(202, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:202:9: ( simpleExpr | groupExpr )
			int alt15=2;
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if (((LA15_0>=WRITE && LA15_0<=READ)||LA15_0==IF||LA15_0==FOR||(LA15_0>=WHILE && LA15_0<=REPEAT)||LA15_0==IDENT))
			{
				alt15=1;
			}
			else if ((LA15_0==BEGIN))
			{
				alt15=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:203:3: simpleExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(203, 3);
				PushFollow(Follow._simpleExpr_in_operList1702);
				simpleExpr93=simpleExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpr93.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:204:3: groupExpr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(204, 3);
				PushFollow(Follow._groupExpr_in_operList1706);
				groupExpr94=groupExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr94.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("operList", 23);
			LeaveRule("operList", 23);
			Leave_operList();
			if (state.backtracking > 0) { Memoize(input, 23, operList_StartIndex); }
		}
		DebugLocation(205, 0);
		} finally { DebugExitRule(GrammarFileName, "operList"); }
		return retval;

	}
	// $ANTLR end "operList"

	public class exprList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// MathLang.g:207:1: exprList : ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )* ;
	[GrammarRule("exprList")]
	private MathLangParser.exprList_return exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 24);
		TraceIn("exprList", 24);
		MathLangParser.exprList_return retval = new MathLangParser.exprList_return();
		retval.Start = (IToken)input.LT(1);
		int exprList_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal96=null;
		IToken char_literal98=null;
		MathLangParser.simpleExpr_return simpleExpr95 = default(MathLangParser.simpleExpr_return);
		MathLangParser.groupExpr_return groupExpr97 = default(MathLangParser.groupExpr_return);

		object char_literal96_tree=null;
		object char_literal98_tree=null;

		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(207, 2);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:207:9: ( ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )* )
			DebugEnterAlt(1);
			// MathLang.g:207:11: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(207, 11);
			// MathLang.g:207:11: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )*
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=3;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if (((LA18_0>=WRITE && LA18_0<=READ)||LA18_0==IF||LA18_0==FOR||(LA18_0>=WHILE && LA18_0<=REPEAT)||LA18_0==IDENT))
				{
					alt18=1;
				}
				else if ((LA18_0==BEGIN))
				{
					alt18=2;
				}


				} finally { DebugExitDecision(18); }
				switch ( alt18 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:208:3: simpleExpr ( ';' )+
					{
					DebugLocation(208, 3);
					PushFollow(Follow._simpleExpr_in_exprList1718);
					simpleExpr95=simpleExpr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpr95.Tree);
					DebugLocation(208, 14);
					// MathLang.g:208:14: ( ';' )+
					int cnt16=0;
					try { DebugEnterSubRule(16);
					while (true)
					{
						int alt16=2;
						try { DebugEnterDecision(16, decisionCanBacktrack[16]);
						int LA16_0 = input.LA(1);

						if ((LA16_0==70))
						{
							alt16=1;
						}


						} finally { DebugExitDecision(16); }
						switch (alt16)
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:208:15: ';'
							{
							DebugLocation(208, 18);
							char_literal96=(IToken)Match(input,70,Follow._70_in_exprList1721); if (state.failed) return retval;

							}
							break;

						default:
							if (cnt16 >= 1)
								goto loop16;

							if (state.backtracking>0) {state.failed=true; return retval;}
							EarlyExitException eee16 = new EarlyExitException( 16, input );
							DebugRecognitionException(eee16);
							throw eee16;
						}
						cnt16++;
					}
					loop16:
						;

					} finally { DebugExitSubRule(16); }


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// MathLang.g:209:3: groupExpr ( ';' )*
					{
					DebugLocation(209, 3);
					PushFollow(Follow._groupExpr_in_exprList1728);
					groupExpr97=groupExpr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr97.Tree);
					DebugLocation(209, 14);
					// MathLang.g:209:14: ( ';' )*
					try { DebugEnterSubRule(17);
					while (true)
					{
						int alt17=2;
						try { DebugEnterDecision(17, decisionCanBacktrack[17]);
						int LA17_0 = input.LA(1);

						if ((LA17_0==70))
						{
							alt17=1;
						}


						} finally { DebugExitDecision(17); }
						switch ( alt17 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:209:15: ';'
							{
							DebugLocation(209, 18);
							char_literal98=(IToken)Match(input,70,Follow._70_in_exprList1732); if (state.failed) return retval;

							}
							break;

						default:
							goto loop17;
						}
					}

					loop17:
						;

					} finally { DebugExitSubRule(17); }


					}
					break;

				default:
					goto loop18;
				}
			}

			loop18:
				;

			} finally { DebugExitSubRule(18); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("exprList", 24);
			LeaveRule("exprList", 24);
			Leave_exprList();
			if (state.backtracking > 0) { Memoize(input, 24, exprList_StartIndex); }
		}
		DebugLocation(210, 2);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return retval;

	}
	// $ANTLR end "exprList"

	public class constSingle_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_constSingle();
	partial void Leave_constSingle();

	// $ANTLR start "constSingle"
	// MathLang.g:215:1: constSingle : IDENT ASSIGN term ;
	[GrammarRule("constSingle")]
	private MathLangParser.constSingle_return constSingle()
	{
		Enter_constSingle();
		EnterRule("constSingle", 25);
		TraceIn("constSingle", 25);
		MathLangParser.constSingle_return retval = new MathLangParser.constSingle_return();
		retval.Start = (IToken)input.LT(1);
		int constSingle_StartIndex = input.Index;
		object root_0 = null;

		IToken IDENT99=null;
		IToken ASSIGN100=null;
		MathLangParser.term_return term101 = default(MathLangParser.term_return);

		object IDENT99_tree=null;
		object ASSIGN100_tree=null;

		try { DebugEnterRule(GrammarFileName, "constSingle");
		DebugLocation(215, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:215:12: ( IDENT ASSIGN term )
			DebugEnterAlt(1);
			// MathLang.g:215:14: IDENT ASSIGN term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(215, 14);
			IDENT99=(IToken)Match(input,IDENT,Follow._IDENT_in_constSingle1749); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			IDENT99_tree = (object)adaptor.Create(IDENT99);
			adaptor.AddChild(root_0, IDENT99_tree);
			}
			DebugLocation(215, 26);
			ASSIGN100=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_constSingle1751); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN100_tree = (object)adaptor.Create(ASSIGN100);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN100_tree, root_0);
			}
			DebugLocation(215, 28);
			PushFollow(Follow._term_in_constSingle1754);
			term101=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term101.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("constSingle", 25);
			LeaveRule("constSingle", 25);
			Leave_constSingle();
			if (state.backtracking > 0) { Memoize(input, 25, constSingle_StartIndex); }
		}
		DebugLocation(215, 31);
		} finally { DebugExitRule(GrammarFileName, "constSingle"); }
		return retval;

	}
	// $ANTLR end "constSingle"

	public class constDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_constDecl();
	partial void Leave_constDecl();

	// $ANTLR start "constDecl"
	// MathLang.g:216:1: constDecl : CONST_DECL constSingle ( ';' constSingle )* ;
	[GrammarRule("constDecl")]
	private MathLangParser.constDecl_return constDecl()
	{
		Enter_constDecl();
		EnterRule("constDecl", 26);
		TraceIn("constDecl", 26);
		MathLangParser.constDecl_return retval = new MathLangParser.constDecl_return();
		retval.Start = (IToken)input.LT(1);
		int constDecl_StartIndex = input.Index;
		object root_0 = null;

		IToken CONST_DECL102=null;
		IToken char_literal104=null;
		MathLangParser.constSingle_return constSingle103 = default(MathLangParser.constSingle_return);
		MathLangParser.constSingle_return constSingle105 = default(MathLangParser.constSingle_return);

		object CONST_DECL102_tree=null;
		object char_literal104_tree=null;

		try { DebugEnterRule(GrammarFileName, "constDecl");
		DebugLocation(216, 57);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:216:10: ( CONST_DECL constSingle ( ';' constSingle )* )
			DebugEnterAlt(1);
			// MathLang.g:216:12: CONST_DECL constSingle ( ';' constSingle )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(216, 22);
			CONST_DECL102=(IToken)Match(input,CONST_DECL,Follow._CONST_DECL_in_constDecl1760); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			CONST_DECL102_tree = (object)adaptor.Create(CONST_DECL102);
			root_0 = (object)adaptor.BecomeRoot(CONST_DECL102_tree, root_0);
			}
			DebugLocation(216, 24);
			PushFollow(Follow._constSingle_in_constDecl1763);
			constSingle103=constSingle();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constSingle103.Tree);
			DebugLocation(216, 36);
			// MathLang.g:216:36: ( ';' constSingle )*
			try { DebugEnterSubRule(19);
			while (true)
			{
				int alt19=2;
				try { DebugEnterDecision(19, decisionCanBacktrack[19]);
				int LA19_0 = input.LA(1);

				if ((LA19_0==70))
				{
					int LA19_1 = input.LA(2);

					if ((EvaluatePredicate(synpred43_MathLang_fragment)))
					{
						alt19=1;
					}


				}


				} finally { DebugExitDecision(19); }
				switch ( alt19 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:216:38: ';' constSingle
					{
					DebugLocation(216, 41);
					char_literal104=(IToken)Match(input,70,Follow._70_in_constDecl1767); if (state.failed) return retval;
					DebugLocation(216, 43);
					PushFollow(Follow._constSingle_in_constDecl1770);
					constSingle105=constSingle();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constSingle105.Tree);

					}
					break;

				default:
					goto loop19;
				}
			}

			loop19:
				;

			} finally { DebugExitSubRule(19); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("constDecl", 26);
			LeaveRule("constDecl", 26);
			Leave_constDecl();
			if (state.backtracking > 0) { Memoize(input, 26, constDecl_StartIndex); }
		}
		DebugLocation(216, 57);
		} finally { DebugExitRule(GrammarFileName, "constDecl"); }
		return retval;

	}
	// $ANTLR end "constDecl"

	public class arraySize_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arraySize();
	partial void Leave_arraySize();

	// $ANTLR start "arraySize"
	// MathLang.g:218:1: arraySize : '[' v1= character '..' v2= character ']' -> ^( $v1 $v2) ;
	[GrammarRule("arraySize")]
	private MathLangParser.arraySize_return arraySize()
	{
		Enter_arraySize();
		EnterRule("arraySize", 27);
		TraceIn("arraySize", 27);
		MathLangParser.arraySize_return retval = new MathLangParser.arraySize_return();
		retval.Start = (IToken)input.LT(1);
		int arraySize_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal106=null;
		IToken string_literal107=null;
		IToken char_literal108=null;
		MathLangParser.character_return v1 = default(MathLangParser.character_return);
		MathLangParser.character_return v2 = default(MathLangParser.character_return);

		object char_literal106_tree=null;
		object string_literal107_tree=null;
		object char_literal108_tree=null;
		RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_71=new RewriteRuleITokenStream(adaptor,"token 71");
		RewriteRuleSubtreeStream stream_character=new RewriteRuleSubtreeStream(adaptor,"rule character");
		try { DebugEnterRule(GrammarFileName, "arraySize");
		DebugLocation(218, 63);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// MathLang.g:218:10: ( '[' v1= character '..' v2= character ']' -> ^( $v1 $v2) )
			DebugEnterAlt(1);
			// MathLang.g:218:12: '[' v1= character '..' v2= character ']'
			{
			DebugLocation(218, 12);
			char_literal106=(IToken)Match(input,67,Follow._67_in_arraySize1781); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_67.Add(char_literal106);

			DebugLocation(218, 18);
			PushFollow(Follow._character_in_arraySize1785);
			v1=character();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_character.Add(v1.Tree);
			DebugLocation(218, 29);
			string_literal107=(IToken)Match(input,71,Follow._71_in_arraySize1787); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_71.Add(string_literal107);

			DebugLocation(218, 36);
			PushFollow(Follow._character_in_arraySize1791);
			v2=character();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_character.Add(v2.Tree);
			DebugLocation(218, 47);
			char_literal108=(IToken)Match(input,68,Follow._68_in_arraySize1793); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_68.Add(char_literal108);



			{
			// AST REWRITE
			// elements: v2, v1
			// token labels: 
			// rule labels: v1, retval, v2
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_v1=new RewriteRuleSubtreeStream(adaptor,"rule v1",v1!=null?v1.Tree:null);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_v2=new RewriteRuleSubtreeStream(adaptor,"rule v2",v2!=null?v2.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 218:51: -> ^( $v1 $v2)
			{
				DebugLocation(218, 54);
				// MathLang.g:218:54: ^( $v1 $v2)
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(218, 56);
				root_1 = (object)adaptor.BecomeRoot(stream_v1.NextNode(), root_1);

				DebugLocation(218, 60);
				adaptor.AddChild(root_1, stream_v2.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arraySize", 27);
			LeaveRule("arraySize", 27);
			Leave_arraySize();
			if (state.backtracking > 0) { Memoize(input, 27, arraySize_StartIndex); }
		}
		DebugLocation(218, 63);
		} finally { DebugExitRule(GrammarFileName, "arraySize"); }
		return retval;

	}
	// $ANTLR end "arraySize"

	public class arrayType_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arrayType();
	partial void Leave_arrayType();

	// $ANTLR start "arrayType"
	// MathLang.g:219:1: arrayType : ARRAY arraySize OF t2= type -> ^( ARRAY $t2 arraySize ) ;
	[GrammarRule("arrayType")]
	private MathLangParser.arrayType_return arrayType()
	{
		Enter_arrayType();
		EnterRule("arrayType", 28);
		TraceIn("arrayType", 28);
		MathLangParser.arrayType_return retval = new MathLangParser.arrayType_return();
		retval.Start = (IToken)input.LT(1);
		int arrayType_StartIndex = input.Index;
		object root_0 = null;

		IToken ARRAY109=null;
		IToken OF111=null;
		MathLangParser.type_return t2 = default(MathLangParser.type_return);
		MathLangParser.arraySize_return arraySize110 = default(MathLangParser.arraySize_return);

		object ARRAY109_tree=null;
		object OF111_tree=null;
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleSubtreeStream stream_arraySize=new RewriteRuleSubtreeStream(adaptor,"rule arraySize");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "arrayType");
		DebugLocation(219, 67);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// MathLang.g:219:10: ( ARRAY arraySize OF t2= type -> ^( ARRAY $t2 arraySize ) )
			DebugEnterAlt(1);
			// MathLang.g:219:13: ARRAY arraySize OF t2= type
			{
			DebugLocation(219, 13);
			ARRAY109=(IToken)Match(input,ARRAY,Follow._ARRAY_in_arrayType1810); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY109);

			DebugLocation(219, 19);
			PushFollow(Follow._arraySize_in_arrayType1812);
			arraySize110=arraySize();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_arraySize.Add(arraySize110.Tree);
			DebugLocation(219, 29);
			OF111=(IToken)Match(input,OF,Follow._OF_in_arrayType1814); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_OF.Add(OF111);

			DebugLocation(219, 34);
			PushFollow(Follow._type_in_arrayType1818);
			t2=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(t2.Tree);


			{
			// AST REWRITE
			// elements: arraySize, t2, ARRAY
			// token labels: 
			// rule labels: t2, retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_t2=new RewriteRuleSubtreeStream(adaptor,"rule t2",t2!=null?t2.Tree:null);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 219:40: -> ^( ARRAY $t2 arraySize )
			{
				DebugLocation(219, 43);
				// MathLang.g:219:43: ^( ARRAY $t2 arraySize )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(219, 46);
				root_1 = (object)adaptor.BecomeRoot(stream_ARRAY.NextNode(), root_1);

				DebugLocation(219, 52);
				adaptor.AddChild(root_1, stream_t2.NextTree());
				DebugLocation(219, 56);
				adaptor.AddChild(root_1, stream_arraySize.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arrayType", 28);
			LeaveRule("arrayType", 28);
			Leave_arrayType();
			if (state.backtracking > 0) { Memoize(input, 28, arrayType_StartIndex); }
		}
		DebugLocation(219, 67);
		} finally { DebugExitRule(GrammarFileName, "arrayType"); }
		return retval;

	}
	// $ANTLR end "arrayType"

	public class type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// MathLang.g:220:1: type : ( CHAR | INTEGER | BOOLEAN );
	[GrammarRule("type")]
	private MathLangParser.type_return type()
	{
		Enter_type();
		EnterRule("type", 29);
		TraceIn("type", 29);
		MathLangParser.type_return retval = new MathLangParser.type_return();
		retval.Start = (IToken)input.LT(1);
		int type_StartIndex = input.Index;
		object root_0 = null;

		IToken set112=null;

		object set112_tree=null;

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(220, 31);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// MathLang.g:220:5: ( CHAR | INTEGER | BOOLEAN )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(220, 5);
			set112=(IToken)input.LT(1);
			if ((input.LA(1)>=CHAR && input.LA(1)<=BOOLEAN))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set112));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type", 29);
			LeaveRule("type", 29);
			Leave_type();
			if (state.backtracking > 0) { Memoize(input, 29, type_StartIndex); }
		}
		DebugLocation(220, 31);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return retval;

	}
	// $ANTLR end "type"

	public class varParam_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_varParam();
	partial void Leave_varParam();

	// $ANTLR start "varParam"
	// MathLang.g:221:1: varParam : IDENT ( ( ',' ) IDENT )* ;
	[GrammarRule("varParam")]
	private MathLangParser.varParam_return varParam()
	{
		Enter_varParam();
		EnterRule("varParam", 30);
		TraceIn("varParam", 30);
		MathLangParser.varParam_return retval = new MathLangParser.varParam_return();
		retval.Start = (IToken)input.LT(1);
		int varParam_StartIndex = input.Index;
		object root_0 = null;

		IToken IDENT113=null;
		IToken char_literal114=null;
		IToken IDENT115=null;

		object IDENT113_tree=null;
		object char_literal114_tree=null;
		object IDENT115_tree=null;

		try { DebugEnterRule(GrammarFileName, "varParam");
		DebugLocation(221, 34);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// MathLang.g:221:9: ( IDENT ( ( ',' ) IDENT )* )
			DebugEnterAlt(1);
			// MathLang.g:221:11: IDENT ( ( ',' ) IDENT )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(221, 11);
			IDENT113=(IToken)Match(input,IDENT,Follow._IDENT_in_varParam1853); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			IDENT113_tree = (object)adaptor.Create(IDENT113);
			adaptor.AddChild(root_0, IDENT113_tree);
			}
			DebugLocation(221, 17);
			// MathLang.g:221:17: ( ( ',' ) IDENT )*
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==69))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch ( alt20 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:221:19: ( ',' ) IDENT
					{
					DebugLocation(221, 19);
					// MathLang.g:221:19: ( ',' )
					DebugEnterAlt(1);
					// MathLang.g:221:20: ','
					{
					DebugLocation(221, 23);
					char_literal114=(IToken)Match(input,69,Follow._69_in_varParam1858); if (state.failed) return retval;

					}

					DebugLocation(221, 26);
					IDENT115=(IToken)Match(input,IDENT,Follow._IDENT_in_varParam1862); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					IDENT115_tree = (object)adaptor.Create(IDENT115);
					adaptor.AddChild(root_0, IDENT115_tree);
					}

					}
					break;

				default:
					goto loop20;
				}
			}

			loop20:
				;

			} finally { DebugExitSubRule(20); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("varParam", 30);
			LeaveRule("varParam", 30);
			Leave_varParam();
			if (state.backtracking > 0) { Memoize(input, 30, varParam_StartIndex); }
		}
		DebugLocation(221, 34);
		} finally { DebugExitRule(GrammarFileName, "varParam"); }
		return retval;

	}
	// $ANTLR end "varParam"

	public class varSingle_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_varSingle();
	partial void Leave_varSingle();

	// $ANTLR start "varSingle"
	// MathLang.g:222:1: varSingle : ( ( varParam ':' t1= type -> ^( $t1 varParam ) ) | ( varParam ':' ARRAY arraySize OF t2= type -> ^( ARRAY ^( varParam $t2 arraySize ) ) ) );
	[GrammarRule("varSingle")]
	private MathLangParser.varSingle_return varSingle()
	{
		Enter_varSingle();
		EnterRule("varSingle", 31);
		TraceIn("varSingle", 31);
		MathLangParser.varSingle_return retval = new MathLangParser.varSingle_return();
		retval.Start = (IToken)input.LT(1);
		int varSingle_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal117=null;
		IToken char_literal119=null;
		IToken ARRAY120=null;
		IToken OF122=null;
		MathLangParser.type_return t1 = default(MathLangParser.type_return);
		MathLangParser.type_return t2 = default(MathLangParser.type_return);
		MathLangParser.varParam_return varParam116 = default(MathLangParser.varParam_return);
		MathLangParser.varParam_return varParam118 = default(MathLangParser.varParam_return);
		MathLangParser.arraySize_return arraySize121 = default(MathLangParser.arraySize_return);

		object char_literal117_tree=null;
		object char_literal119_tree=null;
		object ARRAY120_tree=null;
		object OF122_tree=null;
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_72=new RewriteRuleITokenStream(adaptor,"token 72");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleSubtreeStream stream_varParam=new RewriteRuleSubtreeStream(adaptor,"rule varParam");
		RewriteRuleSubtreeStream stream_arraySize=new RewriteRuleSubtreeStream(adaptor,"rule arraySize");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "varSingle");
		DebugLocation(222, 85);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 31)) { return retval; }
			// MathLang.g:222:10: ( ( varParam ':' t1= type -> ^( $t1 varParam ) ) | ( varParam ':' ARRAY arraySize OF t2= type -> ^( ARRAY ^( varParam $t2 arraySize ) ) ) )
			int alt21=2;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			try
			{
				alt21 = dfa21.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:222:13: ( varParam ':' t1= type -> ^( $t1 varParam ) )
				{
				DebugLocation(222, 13);
				// MathLang.g:222:13: ( varParam ':' t1= type -> ^( $t1 varParam ) )
				DebugEnterAlt(1);
				// MathLang.g:222:14: varParam ':' t1= type
				{
				DebugLocation(222, 14);
				PushFollow(Follow._varParam_in_varSingle1874);
				varParam116=varParam();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varParam.Add(varParam116.Tree);
				DebugLocation(222, 23);
				char_literal117=(IToken)Match(input,72,Follow._72_in_varSingle1876); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_72.Add(char_literal117);

				DebugLocation(222, 29);
				PushFollow(Follow._type_in_varSingle1880);
				t1=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(t1.Tree);


				{
				// AST REWRITE
				// elements: varParam, t1
				// token labels: 
				// rule labels: retval, t1
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_t1=new RewriteRuleSubtreeStream(adaptor,"rule t1",t1!=null?t1.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 222:35: -> ^( $t1 varParam )
				{
					DebugLocation(222, 38);
					// MathLang.g:222:38: ^( $t1 varParam )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(222, 41);
					root_1 = (object)adaptor.BecomeRoot(stream_t1.NextNode(), root_1);

					DebugLocation(222, 45);
					adaptor.AddChild(root_1, stream_varParam.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:223:4: ( varParam ':' ARRAY arraySize OF t2= type -> ^( ARRAY ^( varParam $t2 arraySize ) ) )
				{
				DebugLocation(223, 4);
				// MathLang.g:223:4: ( varParam ':' ARRAY arraySize OF t2= type -> ^( ARRAY ^( varParam $t2 arraySize ) ) )
				DebugEnterAlt(1);
				// MathLang.g:223:5: varParam ':' ARRAY arraySize OF t2= type
				{
				DebugLocation(223, 5);
				PushFollow(Follow._varParam_in_varSingle1901);
				varParam118=varParam();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_varParam.Add(varParam118.Tree);
				DebugLocation(223, 14);
				char_literal119=(IToken)Match(input,72,Follow._72_in_varSingle1903); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_72.Add(char_literal119);

				DebugLocation(223, 18);
				ARRAY120=(IToken)Match(input,ARRAY,Follow._ARRAY_in_varSingle1905); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY120);

				DebugLocation(223, 24);
				PushFollow(Follow._arraySize_in_varSingle1907);
				arraySize121=arraySize();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_arraySize.Add(arraySize121.Tree);
				DebugLocation(223, 34);
				OF122=(IToken)Match(input,OF,Follow._OF_in_varSingle1909); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF122);

				DebugLocation(223, 39);
				PushFollow(Follow._type_in_varSingle1913);
				t2=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(t2.Tree);


				{
				// AST REWRITE
				// elements: varParam, arraySize, ARRAY, t2
				// token labels: 
				// rule labels: t2, retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_t2=new RewriteRuleSubtreeStream(adaptor,"rule t2",t2!=null?t2.Tree:null);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 223:45: -> ^( ARRAY ^( varParam $t2 arraySize ) )
				{
					DebugLocation(223, 48);
					// MathLang.g:223:48: ^( ARRAY ^( varParam $t2 arraySize ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(223, 50);
					root_1 = (object)adaptor.BecomeRoot(stream_ARRAY.NextNode(), root_1);

					DebugLocation(223, 56);
					// MathLang.g:223:56: ^( varParam $t2 arraySize )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(223, 58);
					root_2 = (object)adaptor.BecomeRoot(stream_varParam.NextNode(), root_2);

					DebugLocation(223, 68);
					adaptor.AddChild(root_2, stream_t2.NextTree());
					DebugLocation(223, 72);
					adaptor.AddChild(root_2, stream_arraySize.NextTree());

					adaptor.AddChild(root_1, root_2);
					}

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("varSingle", 31);
			LeaveRule("varSingle", 31);
			Leave_varSingle();
			if (state.backtracking > 0) { Memoize(input, 31, varSingle_StartIndex); }
		}
		DebugLocation(223, 85);
		} finally { DebugExitRule(GrammarFileName, "varSingle"); }
		return retval;

	}
	// $ANTLR end "varSingle"

	public class varAll_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_varAll();
	partial void Leave_varAll();

	// $ANTLR start "varAll"
	// MathLang.g:224:1: varAll : varSingle ( ';' varSingle )* ;
	[GrammarRule("varAll")]
	private MathLangParser.varAll_return varAll()
	{
		Enter_varAll();
		EnterRule("varAll", 32);
		TraceIn("varAll", 32);
		MathLangParser.varAll_return retval = new MathLangParser.varAll_return();
		retval.Start = (IToken)input.LT(1);
		int varAll_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal124=null;
		MathLangParser.varSingle_return varSingle123 = default(MathLangParser.varSingle_return);
		MathLangParser.varSingle_return varSingle125 = default(MathLangParser.varSingle_return);

		object char_literal124_tree=null;

		try { DebugEnterRule(GrammarFileName, "varAll");
		DebugLocation(224, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 32)) { return retval; }
			// MathLang.g:224:7: ( varSingle ( ';' varSingle )* )
			DebugEnterAlt(1);
			// MathLang.g:224:10: varSingle ( ';' varSingle )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(224, 10);
			PushFollow(Follow._varSingle_in_varAll1939);
			varSingle123=varSingle();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varSingle123.Tree);
			DebugLocation(224, 20);
			// MathLang.g:224:20: ( ';' varSingle )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==70))
				{
					int LA22_1 = input.LA(2);

					if ((LA22_1==IDENT))
					{
						int LA22_3 = input.LA(3);

						if ((LA22_3==69||LA22_3==72))
						{
							alt22=1;
						}


					}


				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:224:22: ';' varSingle
					{
					DebugLocation(224, 25);
					char_literal124=(IToken)Match(input,70,Follow._70_in_varAll1943); if (state.failed) return retval;
					DebugLocation(224, 27);
					PushFollow(Follow._varSingle_in_varAll1946);
					varSingle125=varSingle();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varSingle125.Tree);

					}
					break;

				default:
					goto loop22;
				}
			}

			loop22:
				;

			} finally { DebugExitSubRule(22); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("varAll", 32);
			LeaveRule("varAll", 32);
			Leave_varAll();
			if (state.backtracking > 0) { Memoize(input, 32, varAll_StartIndex); }
		}
		DebugLocation(224, 38);
		} finally { DebugExitRule(GrammarFileName, "varAll"); }
		return retval;

	}
	// $ANTLR end "varAll"

	public class varDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_varDecl();
	partial void Leave_varDecl();

	// $ANTLR start "varDecl"
	// MathLang.g:225:1: varDecl : VAR_DECL varAll ;
	[GrammarRule("varDecl")]
	private MathLangParser.varDecl_return varDecl()
	{
		Enter_varDecl();
		EnterRule("varDecl", 33);
		TraceIn("varDecl", 33);
		MathLangParser.varDecl_return retval = new MathLangParser.varDecl_return();
		retval.Start = (IToken)input.LT(1);
		int varDecl_StartIndex = input.Index;
		object root_0 = null;

		IToken VAR_DECL126=null;
		MathLangParser.varAll_return varAll127 = default(MathLangParser.varAll_return);

		object VAR_DECL126_tree=null;

		try { DebugEnterRule(GrammarFileName, "varDecl");
		DebugLocation(225, 26);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 33)) { return retval; }
			// MathLang.g:225:8: ( VAR_DECL varAll )
			DebugEnterAlt(1);
			// MathLang.g:225:10: VAR_DECL varAll
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(225, 18);
			VAR_DECL126=(IToken)Match(input,VAR_DECL,Follow._VAR_DECL_in_varDecl1955); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			VAR_DECL126_tree = (object)adaptor.Create(VAR_DECL126);
			root_0 = (object)adaptor.BecomeRoot(VAR_DECL126_tree, root_0);
			}
			DebugLocation(225, 20);
			PushFollow(Follow._varAll_in_varDecl1958);
			varAll127=varAll();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varAll127.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("varDecl", 33);
			LeaveRule("varDecl", 33);
			Leave_varDecl();
			if (state.backtracking > 0) { Memoize(input, 33, varDecl_StartIndex); }
		}
		DebugLocation(225, 26);
		} finally { DebugExitRule(GrammarFileName, "varDecl"); }
		return retval;

	}
	// $ANTLR end "varDecl"

	public class paramsDesc_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_paramsDesc();
	partial void Leave_paramsDesc();

	// $ANTLR start "paramsDesc"
	// MathLang.g:227:1: paramsDesc : varAll ;
	[GrammarRule("paramsDesc")]
	private MathLangParser.paramsDesc_return paramsDesc()
	{
		Enter_paramsDesc();
		EnterRule("paramsDesc", 34);
		TraceIn("paramsDesc", 34);
		MathLangParser.paramsDesc_return retval = new MathLangParser.paramsDesc_return();
		retval.Start = (IToken)input.LT(1);
		int paramsDesc_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.varAll_return varAll128 = default(MathLangParser.varAll_return);


		try { DebugEnterRule(GrammarFileName, "paramsDesc");
		DebugLocation(227, 19);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 34)) { return retval; }
			// MathLang.g:227:11: ( varAll )
			DebugEnterAlt(1);
			// MathLang.g:227:13: varAll
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(227, 13);
			PushFollow(Follow._varAll_in_paramsDesc1966);
			varAll128=varAll();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varAll128.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("paramsDesc", 34);
			LeaveRule("paramsDesc", 34);
			Leave_paramsDesc();
			if (state.backtracking > 0) { Memoize(input, 34, paramsDesc_StartIndex); }
		}
		DebugLocation(227, 19);
		} finally { DebugExitRule(GrammarFileName, "paramsDesc"); }
		return retval;

	}
	// $ANTLR end "paramsDesc"

	public class noParamsDesc_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_noParamsDesc();
	partial void Leave_noParamsDesc();

	// $ANTLR start "noParamsDesc"
	// MathLang.g:228:1: noParamsDesc : -> PARAMS ;
	[GrammarRule("noParamsDesc")]
	private MathLangParser.noParamsDesc_return noParamsDesc()
	{
		Enter_noParamsDesc();
		EnterRule("noParamsDesc", 35);
		TraceIn("noParamsDesc", 35);
		MathLangParser.noParamsDesc_return retval = new MathLangParser.noParamsDesc_return();
		retval.Start = (IToken)input.LT(1);
		int noParamsDesc_StartIndex = input.Index;
		object root_0 = null;

		try { DebugEnterRule(GrammarFileName, "noParamsDesc");
		DebugLocation(228, 24);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 35)) { return retval; }
			// MathLang.g:228:13: ( -> PARAMS )
			DebugEnterAlt(1);
			// MathLang.g:228:15: 
			{

			{
			// AST REWRITE
			// elements: 
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 228:15: -> PARAMS
			{
				DebugLocation(228, 18);
				adaptor.AddChild(root_0, (object)adaptor.Create(PARAMS, "PARAMS"));

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("noParamsDesc", 35);
			LeaveRule("noParamsDesc", 35);
			Leave_noParamsDesc();
			if (state.backtracking > 0) { Memoize(input, 35, noParamsDesc_StartIndex); }
		}
		DebugLocation(228, 24);
		} finally { DebugExitRule(GrammarFileName, "noParamsDesc"); }
		return retval;

	}
	// $ANTLR end "noParamsDesc"

	public class funcExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcExpr();
	partial void Leave_funcExpr();

	// $ANTLR start "funcExpr"
	// MathLang.g:230:1: funcExpr : ( ( simpleExpr ( ';' ) )* | groupExpr ( ';' ) );
	[GrammarRule("funcExpr")]
	private MathLangParser.funcExpr_return funcExpr()
	{
		Enter_funcExpr();
		EnterRule("funcExpr", 36);
		TraceIn("funcExpr", 36);
		MathLangParser.funcExpr_return retval = new MathLangParser.funcExpr_return();
		retval.Start = (IToken)input.LT(1);
		int funcExpr_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal130=null;
		IToken char_literal132=null;
		MathLangParser.simpleExpr_return simpleExpr129 = default(MathLangParser.simpleExpr_return);
		MathLangParser.groupExpr_return groupExpr131 = default(MathLangParser.groupExpr_return);

		object char_literal130_tree=null;
		object char_literal132_tree=null;

		try { DebugEnterRule(GrammarFileName, "funcExpr");
		DebugLocation(230, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 36)) { return retval; }
			// MathLang.g:230:9: ( ( simpleExpr ( ';' ) )* | groupExpr ( ';' ) )
			int alt24=2;
			try { DebugEnterDecision(24, decisionCanBacktrack[24]);
			int LA24_0 = input.LA(1);

			if ((LA24_0==EOF||(LA24_0>=WRITE && LA24_0<=READ)||LA24_0==IF||LA24_0==FOR||(LA24_0>=WHILE && LA24_0<=REPEAT)||LA24_0==IDENT||LA24_0==70))
			{
				alt24=1;
			}
			else if ((LA24_0==BEGIN))
			{
				alt24=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 24, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(24); }
			switch (alt24)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:231:1: ( simpleExpr ( ';' ) )*
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(231, 1);
				// MathLang.g:231:1: ( simpleExpr ( ';' ) )*
				try { DebugEnterSubRule(23);
				while (true)
				{
					int alt23=2;
					try { DebugEnterDecision(23, decisionCanBacktrack[23]);
					int LA23_0 = input.LA(1);

					if (((LA23_0>=WRITE && LA23_0<=READ)||LA23_0==IF||LA23_0==FOR||(LA23_0>=WHILE && LA23_0<=REPEAT)||LA23_0==IDENT))
					{
						alt23=1;
					}


					} finally { DebugExitDecision(23); }
					switch ( alt23 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:231:2: simpleExpr ( ';' )
						{
						DebugLocation(231, 2);
						PushFollow(Follow._simpleExpr_in_funcExpr1984);
						simpleExpr129=simpleExpr();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpr129.Tree);
						DebugLocation(231, 13);
						// MathLang.g:231:13: ( ';' )
						DebugEnterAlt(1);
						// MathLang.g:231:14: ';'
						{
						DebugLocation(231, 17);
						char_literal130=(IToken)Match(input,70,Follow._70_in_funcExpr1987); if (state.failed) return retval;

						}


						}
						break;

					default:
						goto loop23;
					}
				}

				loop23:
					;

				} finally { DebugExitSubRule(23); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:232:3: groupExpr ( ';' )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(232, 3);
				PushFollow(Follow._groupExpr_in_funcExpr1995);
				groupExpr131=groupExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr131.Tree);
				DebugLocation(232, 14);
				// MathLang.g:232:14: ( ';' )
				DebugEnterAlt(1);
				// MathLang.g:232:15: ';'
				{
				DebugLocation(232, 18);
				char_literal132=(IToken)Match(input,70,Follow._70_in_funcExpr1999); if (state.failed) return retval;

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funcExpr", 36);
			LeaveRule("funcExpr", 36);
			Leave_funcExpr();
			if (state.backtracking > 0) { Memoize(input, 36, funcExpr_StartIndex); }
		}
		DebugLocation(233, 0);
		} finally { DebugExitRule(GrammarFileName, "funcExpr"); }
		return retval;

	}
	// $ANTLR end "funcExpr"

	public class funcDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_funcDecl();
	partial void Leave_funcDecl();

	// $ANTLR start "funcDecl"
	// MathLang.g:235:1: funcDecl : FUNC_DECL IDENT ( '(' p1= paramsDesc | p2= noParamsDesc ')' ) ':' type ';' declList funcExpr -> ^( FUNC_DECL IDENT type ( $p1)? ( $p2)? declList funcExpr ) ;
	[GrammarRule("funcDecl")]
	private MathLangParser.funcDecl_return funcDecl()
	{
		Enter_funcDecl();
		EnterRule("funcDecl", 37);
		TraceIn("funcDecl", 37);
		MathLangParser.funcDecl_return retval = new MathLangParser.funcDecl_return();
		retval.Start = (IToken)input.LT(1);
		int funcDecl_StartIndex = input.Index;
		object root_0 = null;

		IToken FUNC_DECL133=null;
		IToken IDENT134=null;
		IToken char_literal135=null;
		IToken char_literal136=null;
		IToken char_literal137=null;
		IToken char_literal139=null;
		MathLangParser.paramsDesc_return p1 = default(MathLangParser.paramsDesc_return);
		MathLangParser.noParamsDesc_return p2 = default(MathLangParser.noParamsDesc_return);
		MathLangParser.type_return type138 = default(MathLangParser.type_return);
		MathLangParser.declList_return declList140 = default(MathLangParser.declList_return);
		MathLangParser.funcExpr_return funcExpr141 = default(MathLangParser.funcExpr_return);

		object FUNC_DECL133_tree=null;
		object IDENT134_tree=null;
		object char_literal135_tree=null;
		object char_literal136_tree=null;
		object char_literal137_tree=null;
		object char_literal139_tree=null;
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
		RewriteRuleITokenStream stream_72=new RewriteRuleITokenStream(adaptor,"token 72");
		RewriteRuleITokenStream stream_FUNC_DECL=new RewriteRuleITokenStream(adaptor,"token FUNC_DECL");
		RewriteRuleSubtreeStream stream_noParamsDesc=new RewriteRuleSubtreeStream(adaptor,"rule noParamsDesc");
		RewriteRuleSubtreeStream stream_funcExpr=new RewriteRuleSubtreeStream(adaptor,"rule funcExpr");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		RewriteRuleSubtreeStream stream_paramsDesc=new RewriteRuleSubtreeStream(adaptor,"rule paramsDesc");
		RewriteRuleSubtreeStream stream_declList=new RewriteRuleSubtreeStream(adaptor,"rule declList");
		try { DebugEnterRule(GrammarFileName, "funcDecl");
		DebugLocation(235, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 37)) { return retval; }
			// MathLang.g:235:9: ( FUNC_DECL IDENT ( '(' p1= paramsDesc | p2= noParamsDesc ')' ) ':' type ';' declList funcExpr -> ^( FUNC_DECL IDENT type ( $p1)? ( $p2)? declList funcExpr ) )
			DebugEnterAlt(1);
			// MathLang.g:236:2: FUNC_DECL IDENT ( '(' p1= paramsDesc | p2= noParamsDesc ')' ) ':' type ';' declList funcExpr
			{
			DebugLocation(236, 2);
			FUNC_DECL133=(IToken)Match(input,FUNC_DECL,Follow._FUNC_DECL_in_funcDecl2010); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNC_DECL.Add(FUNC_DECL133);

			DebugLocation(236, 12);
			IDENT134=(IToken)Match(input,IDENT,Follow._IDENT_in_funcDecl2012); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT134);

			DebugLocation(237, 2);
			// MathLang.g:237:2: ( '(' p1= paramsDesc | p2= noParamsDesc ')' )
			int alt25=2;
			try { DebugEnterSubRule(25);
			try { DebugEnterDecision(25, decisionCanBacktrack[25]);
			int LA25_0 = input.LA(1);

			if ((LA25_0==65))
			{
				alt25=1;
			}
			else if ((LA25_0==66))
			{
				alt25=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 25, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(25); }
			switch (alt25)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:238:3: '(' p1= paramsDesc
				{
				DebugLocation(238, 3);
				char_literal135=(IToken)Match(input,65,Follow._65_in_funcDecl2019); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(char_literal135);

				DebugLocation(238, 9);
				PushFollow(Follow._paramsDesc_in_funcDecl2023);
				p1=paramsDesc();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsDesc.Add(p1.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:238:23: p2= noParamsDesc ')'
				{
				DebugLocation(238, 25);
				PushFollow(Follow._noParamsDesc_in_funcDecl2029);
				p2=noParamsDesc();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_noParamsDesc.Add(p2.Tree);
				DebugLocation(238, 39);
				char_literal136=(IToken)Match(input,66,Follow._66_in_funcDecl2031); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_66.Add(char_literal136);


				}
				break;

			}
			} finally { DebugExitSubRule(25); }

			DebugLocation(240, 2);
			char_literal137=(IToken)Match(input,72,Follow._72_in_funcDecl2037); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_72.Add(char_literal137);

			DebugLocation(240, 6);
			PushFollow(Follow._type_in_funcDecl2039);
			type138=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type138.Tree);
			DebugLocation(240, 11);
			char_literal139=(IToken)Match(input,70,Follow._70_in_funcDecl2041); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_70.Add(char_literal139);

			DebugLocation(241, 2);
			PushFollow(Follow._declList_in_funcDecl2044);
			declList140=declList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declList.Add(declList140.Tree);
			DebugLocation(242, 2);
			PushFollow(Follow._funcExpr_in_funcDecl2047);
			funcExpr141=funcExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_funcExpr.Add(funcExpr141.Tree);


			{
			// AST REWRITE
			// elements: IDENT, type, funcExpr, p1, FUNC_DECL, declList, p2
			// token labels: 
			// rule labels: retval, p2, p1
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_p2=new RewriteRuleSubtreeStream(adaptor,"rule p2",p2!=null?p2.Tree:null);
			RewriteRuleSubtreeStream stream_p1=new RewriteRuleSubtreeStream(adaptor,"rule p1",p1!=null?p1.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 243:2: -> ^( FUNC_DECL IDENT type ( $p1)? ( $p2)? declList funcExpr )
			{
				DebugLocation(243, 5);
				// MathLang.g:243:5: ^( FUNC_DECL IDENT type ( $p1)? ( $p2)? declList funcExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(243, 8);
				root_1 = (object)adaptor.BecomeRoot(stream_FUNC_DECL.NextNode(), root_1);

				DebugLocation(243, 18);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(243, 24);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(243, 29);
				// MathLang.g:243:29: ( $p1)?
				if ( stream_p1.HasNext )
				{
					DebugLocation(243, 29);
					adaptor.AddChild(root_1, stream_p1.NextTree());

				}
				stream_p1.Reset();
				DebugLocation(243, 34);
				// MathLang.g:243:34: ( $p2)?
				if ( stream_p2.HasNext )
				{
					DebugLocation(243, 34);
					adaptor.AddChild(root_1, stream_p2.NextTree());

				}
				stream_p2.Reset();
				DebugLocation(243, 39);
				adaptor.AddChild(root_1, stream_declList.NextTree());
				DebugLocation(243, 48);
				adaptor.AddChild(root_1, stream_funcExpr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("funcDecl", 37);
			LeaveRule("funcDecl", 37);
			Leave_funcDecl();
			if (state.backtracking > 0) { Memoize(input, 37, funcDecl_StartIndex); }
		}
		DebugLocation(244, 0);
		} finally { DebugExitRule(GrammarFileName, "funcDecl"); }
		return retval;

	}
	// $ANTLR end "funcDecl"

	public class procDecl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_procDecl();
	partial void Leave_procDecl();

	// $ANTLR start "procDecl"
	// MathLang.g:246:1: procDecl : PROC_DECL IDENT ( '(' p1= paramsDesc | p2= noParamsDesc ')' ) ';' declList funcExpr -> ^( PROC_DECL IDENT VOID ( $p1)? ( $p2)? declList funcExpr ) ;
	[GrammarRule("procDecl")]
	private MathLangParser.procDecl_return procDecl()
	{
		Enter_procDecl();
		EnterRule("procDecl", 38);
		TraceIn("procDecl", 38);
		MathLangParser.procDecl_return retval = new MathLangParser.procDecl_return();
		retval.Start = (IToken)input.LT(1);
		int procDecl_StartIndex = input.Index;
		object root_0 = null;

		IToken PROC_DECL142=null;
		IToken IDENT143=null;
		IToken char_literal144=null;
		IToken char_literal145=null;
		IToken char_literal146=null;
		MathLangParser.paramsDesc_return p1 = default(MathLangParser.paramsDesc_return);
		MathLangParser.noParamsDesc_return p2 = default(MathLangParser.noParamsDesc_return);
		MathLangParser.declList_return declList147 = default(MathLangParser.declList_return);
		MathLangParser.funcExpr_return funcExpr148 = default(MathLangParser.funcExpr_return);

		object PROC_DECL142_tree=null;
		object IDENT143_tree=null;
		object char_literal144_tree=null;
		object char_literal145_tree=null;
		object char_literal146_tree=null;
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_PROC_DECL=new RewriteRuleITokenStream(adaptor,"token PROC_DECL");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
		RewriteRuleSubtreeStream stream_noParamsDesc=new RewriteRuleSubtreeStream(adaptor,"rule noParamsDesc");
		RewriteRuleSubtreeStream stream_funcExpr=new RewriteRuleSubtreeStream(adaptor,"rule funcExpr");
		RewriteRuleSubtreeStream stream_paramsDesc=new RewriteRuleSubtreeStream(adaptor,"rule paramsDesc");
		RewriteRuleSubtreeStream stream_declList=new RewriteRuleSubtreeStream(adaptor,"rule declList");
		try { DebugEnterRule(GrammarFileName, "procDecl");
		DebugLocation(246, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 38)) { return retval; }
			// MathLang.g:246:9: ( PROC_DECL IDENT ( '(' p1= paramsDesc | p2= noParamsDesc ')' ) ';' declList funcExpr -> ^( PROC_DECL IDENT VOID ( $p1)? ( $p2)? declList funcExpr ) )
			DebugEnterAlt(1);
			// MathLang.g:247:2: PROC_DECL IDENT ( '(' p1= paramsDesc | p2= noParamsDesc ')' ) ';' declList funcExpr
			{
			DebugLocation(247, 2);
			PROC_DECL142=(IToken)Match(input,PROC_DECL,Follow._PROC_DECL_in_procDecl2082); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROC_DECL.Add(PROC_DECL142);

			DebugLocation(247, 12);
			IDENT143=(IToken)Match(input,IDENT,Follow._IDENT_in_procDecl2084); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT143);

			DebugLocation(248, 2);
			// MathLang.g:248:2: ( '(' p1= paramsDesc | p2= noParamsDesc ')' )
			int alt26=2;
			try { DebugEnterSubRule(26);
			try { DebugEnterDecision(26, decisionCanBacktrack[26]);
			int LA26_0 = input.LA(1);

			if ((LA26_0==65))
			{
				alt26=1;
			}
			else if ((LA26_0==66))
			{
				alt26=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 26, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(26); }
			switch (alt26)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:249:3: '(' p1= paramsDesc
				{
				DebugLocation(249, 3);
				char_literal144=(IToken)Match(input,65,Follow._65_in_procDecl2091); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(char_literal144);

				DebugLocation(249, 9);
				PushFollow(Follow._paramsDesc_in_procDecl2095);
				p1=paramsDesc();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_paramsDesc.Add(p1.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:249:23: p2= noParamsDesc ')'
				{
				DebugLocation(249, 25);
				PushFollow(Follow._noParamsDesc_in_procDecl2101);
				p2=noParamsDesc();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_noParamsDesc.Add(p2.Tree);
				DebugLocation(249, 39);
				char_literal145=(IToken)Match(input,66,Follow._66_in_procDecl2103); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_66.Add(char_literal145);


				}
				break;

			}
			} finally { DebugExitSubRule(26); }

			DebugLocation(250, 3);
			char_literal146=(IToken)Match(input,70,Follow._70_in_procDecl2107); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_70.Add(char_literal146);

			DebugLocation(251, 2);
			PushFollow(Follow._declList_in_procDecl2110);
			declList147=declList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declList.Add(declList147.Tree);
			DebugLocation(252, 2);
			PushFollow(Follow._funcExpr_in_procDecl2113);
			funcExpr148=funcExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_funcExpr.Add(funcExpr148.Tree);


			{
			// AST REWRITE
			// elements: funcExpr, p2, PROC_DECL, p1, IDENT, declList
			// token labels: 
			// rule labels: retval, p2, p1
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_p2=new RewriteRuleSubtreeStream(adaptor,"rule p2",p2!=null?p2.Tree:null);
			RewriteRuleSubtreeStream stream_p1=new RewriteRuleSubtreeStream(adaptor,"rule p1",p1!=null?p1.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 253:2: -> ^( PROC_DECL IDENT VOID ( $p1)? ( $p2)? declList funcExpr )
			{
				DebugLocation(253, 5);
				// MathLang.g:253:5: ^( PROC_DECL IDENT VOID ( $p1)? ( $p2)? declList funcExpr )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(253, 8);
				root_1 = (object)adaptor.BecomeRoot(stream_PROC_DECL.NextNode(), root_1);

				DebugLocation(253, 18);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(253, 24);
				adaptor.AddChild(root_1, (object)adaptor.Create(VOID, "VOID"));
				DebugLocation(253, 29);
				// MathLang.g:253:29: ( $p1)?
				if ( stream_p1.HasNext )
				{
					DebugLocation(253, 29);
					adaptor.AddChild(root_1, stream_p1.NextTree());

				}
				stream_p1.Reset();
				DebugLocation(253, 34);
				// MathLang.g:253:34: ( $p2)?
				if ( stream_p2.HasNext )
				{
					DebugLocation(253, 34);
					adaptor.AddChild(root_1, stream_p2.NextTree());

				}
				stream_p2.Reset();
				DebugLocation(253, 39);
				adaptor.AddChild(root_1, stream_declList.NextTree());
				DebugLocation(253, 48);
				adaptor.AddChild(root_1, stream_funcExpr.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("procDecl", 38);
			LeaveRule("procDecl", 38);
			Leave_procDecl();
			if (state.backtracking > 0) { Memoize(input, 38, procDecl_StartIndex); }
		}
		DebugLocation(254, 0);
		} finally { DebugExitRule(GrammarFileName, "procDecl"); }
		return retval;

	}
	// $ANTLR end "procDecl"

	public class decl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_decl();
	partial void Leave_decl();

	// $ANTLR start "decl"
	// MathLang.g:256:1: decl : ( constDecl | varDecl | funcDecl | procDecl );
	[GrammarRule("decl")]
	private MathLangParser.decl_return decl()
	{
		Enter_decl();
		EnterRule("decl", 39);
		TraceIn("decl", 39);
		MathLangParser.decl_return retval = new MathLangParser.decl_return();
		retval.Start = (IToken)input.LT(1);
		int decl_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.constDecl_return constDecl149 = default(MathLangParser.constDecl_return);
		MathLangParser.varDecl_return varDecl150 = default(MathLangParser.varDecl_return);
		MathLangParser.funcDecl_return funcDecl151 = default(MathLangParser.funcDecl_return);
		MathLangParser.procDecl_return procDecl152 = default(MathLangParser.procDecl_return);


		try { DebugEnterRule(GrammarFileName, "decl");
		DebugLocation(256, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 39)) { return retval; }
			// MathLang.g:256:5: ( constDecl | varDecl | funcDecl | procDecl )
			int alt27=4;
			try { DebugEnterDecision(27, decisionCanBacktrack[27]);
			switch (input.LA(1))
			{
			case CONST_DECL:
				{
				alt27=1;
				}
				break;
			case VAR_DECL:
				{
				alt27=2;
				}
				break;
			case FUNC_DECL:
				{
				alt27=3;
				}
				break;
			case PROC_DECL:
				{
				alt27=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 27, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(27); }
			switch (alt27)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:257:3: constDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(257, 3);
				PushFollow(Follow._constDecl_in_decl2148);
				constDecl149=constDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constDecl149.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:258:3: varDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(258, 3);
				PushFollow(Follow._varDecl_in_decl2152);
				varDecl150=varDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDecl150.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:259:3: funcDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(259, 3);
				PushFollow(Follow._funcDecl_in_decl2156);
				funcDecl151=funcDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, funcDecl151.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:260:3: procDecl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(260, 3);
				PushFollow(Follow._procDecl_in_decl2160);
				procDecl152=procDecl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, procDecl152.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("decl", 39);
			LeaveRule("decl", 39);
			Leave_decl();
			if (state.backtracking > 0) { Memoize(input, 39, decl_StartIndex); }
		}
		DebugLocation(261, 0);
		} finally { DebugExitRule(GrammarFileName, "decl"); }
		return retval;

	}
	// $ANTLR end "decl"

	public class declList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_declList();
	partial void Leave_declList();

	// $ANTLR start "declList"
	// MathLang.g:263:1: declList : ( decl ( ';' ) )* ;
	[GrammarRule("declList")]
	private MathLangParser.declList_return declList()
	{
		Enter_declList();
		EnterRule("declList", 40);
		TraceIn("declList", 40);
		MathLangParser.declList_return retval = new MathLangParser.declList_return();
		retval.Start = (IToken)input.LT(1);
		int declList_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal154=null;
		MathLangParser.decl_return decl153 = default(MathLangParser.decl_return);

		object char_literal154_tree=null;

		try { DebugEnterRule(GrammarFileName, "declList");
		DebugLocation(263, 26);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 40)) { return retval; }
			// MathLang.g:263:9: ( ( decl ( ';' ) )* )
			DebugEnterAlt(1);
			// MathLang.g:263:11: ( decl ( ';' ) )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(263, 11);
			// MathLang.g:263:11: ( decl ( ';' ) )*
			try { DebugEnterSubRule(28);
			while (true)
			{
				int alt28=2;
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if (((LA28_0>=CONST_DECL && LA28_0<=PROC_DECL)))
				{
					alt28=1;
				}


				} finally { DebugExitDecision(28); }
				switch ( alt28 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:263:13: decl ( ';' )
					{
					DebugLocation(263, 13);
					PushFollow(Follow._decl_in_declList2170);
					decl153=decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decl153.Tree);
					DebugLocation(263, 18);
					// MathLang.g:263:18: ( ';' )
					DebugEnterAlt(1);
					// MathLang.g:263:19: ';'
					{
					DebugLocation(263, 22);
					char_literal154=(IToken)Match(input,70,Follow._70_in_declList2173); if (state.failed) return retval;

					}


					}
					break;

				default:
					goto loop28;
				}
			}

			loop28:
				;

			} finally { DebugExitSubRule(28); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("declList", 40);
			LeaveRule("declList", 40);
			Leave_declList();
			if (state.backtracking > 0) { Memoize(input, 40, declList_StartIndex); }
		}
		DebugLocation(263, 26);
		} finally { DebugExitRule(GrammarFileName, "declList"); }
		return retval;

	}
	// $ANTLR end "declList"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// MathLang.g:265:1: program : PROGRAM IDENT ';' declList BEGIN exprList END '.' -> ^( PROGRAM IDENT ^( DECL declList ) ^( BLOCK exprList ) ) ;
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 41);
		TraceIn("program", 41);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);
		int program_StartIndex = input.Index;
		object root_0 = null;

		IToken PROGRAM155=null;
		IToken IDENT156=null;
		IToken char_literal157=null;
		IToken BEGIN159=null;
		IToken END161=null;
		IToken char_literal162=null;
		MathLangParser.declList_return declList158 = default(MathLangParser.declList_return);
		MathLangParser.exprList_return exprList160 = default(MathLangParser.exprList_return);

		object PROGRAM155_tree=null;
		object IDENT156_tree=null;
		object char_literal157_tree=null;
		object BEGIN159_tree=null;
		object END161_tree=null;
		object char_literal162_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_PROGRAM=new RewriteRuleITokenStream(adaptor,"token PROGRAM");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_70=new RewriteRuleITokenStream(adaptor,"token 70");
		RewriteRuleITokenStream stream_73=new RewriteRuleITokenStream(adaptor,"token 73");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_declList=new RewriteRuleSubtreeStream(adaptor,"rule declList");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(265, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 41)) { return retval; }
			// MathLang.g:265:8: ( PROGRAM IDENT ';' declList BEGIN exprList END '.' -> ^( PROGRAM IDENT ^( DECL declList ) ^( BLOCK exprList ) ) )
			DebugEnterAlt(1);
			// MathLang.g:265:10: PROGRAM IDENT ';' declList BEGIN exprList END '.'
			{
			DebugLocation(265, 10);
			PROGRAM155=(IToken)Match(input,PROGRAM,Follow._PROGRAM_in_program2185); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROGRAM.Add(PROGRAM155);

			DebugLocation(265, 18);
			IDENT156=(IToken)Match(input,IDENT,Follow._IDENT_in_program2187); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT156);

			DebugLocation(265, 24);
			char_literal157=(IToken)Match(input,70,Follow._70_in_program2189); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_70.Add(char_literal157);

			DebugLocation(265, 28);
			PushFollow(Follow._declList_in_program2191);
			declList158=declList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_declList.Add(declList158.Tree);
			DebugLocation(265, 37);
			BEGIN159=(IToken)Match(input,BEGIN,Follow._BEGIN_in_program2193); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN159);

			DebugLocation(265, 43);
			PushFollow(Follow._exprList_in_program2195);
			exprList160=exprList();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_exprList.Add(exprList160.Tree);
			DebugLocation(265, 52);
			END161=(IToken)Match(input,END,Follow._END_in_program2197); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_END.Add(END161);

			DebugLocation(265, 55);
			char_literal162=(IToken)Match(input,73,Follow._73_in_program2198); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_73.Add(char_literal162);



			{
			// AST REWRITE
			// elements: exprList, declList, IDENT, PROGRAM
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 266:2: -> ^( PROGRAM IDENT ^( DECL declList ) ^( BLOCK exprList ) )
			{
				DebugLocation(266, 5);
				// MathLang.g:266:5: ^( PROGRAM IDENT ^( DECL declList ) ^( BLOCK exprList ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(266, 8);
				root_1 = (object)adaptor.BecomeRoot(stream_PROGRAM.NextNode(), root_1);

				DebugLocation(266, 16);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(266, 22);
				// MathLang.g:266:22: ^( DECL declList )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(266, 25);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(DECL, "DECL"), root_2);

				DebugLocation(266, 30);
				adaptor.AddChild(root_2, stream_declList.NextTree());

				adaptor.AddChild(root_1, root_2);
				}
				DebugLocation(266, 41);
				// MathLang.g:266:41: ^( BLOCK exprList )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(266, 44);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_2);

				DebugLocation(266, 50);
				adaptor.AddChild(root_2, stream_exprList.NextTree());

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 41);
			LeaveRule("program", 41);
			Leave_program();
			if (state.backtracking > 0) { Memoize(input, 41, program_StartIndex); }
		}
		DebugLocation(267, 0);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class result_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_result();
	partial void Leave_result();

	// $ANTLR start "result"
	// MathLang.g:269:1: result : program EOF ;
	[GrammarRule("result")]
	private MathLangParser.result_return result()
	{
		Enter_result();
		EnterRule("result", 42);
		TraceIn("result", 42);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);
		int result_StartIndex = input.Index;
		object root_0 = null;

		IToken EOF164=null;
		MathLangParser.program_return program163 = default(MathLangParser.program_return);

		object EOF164_tree=null;

		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(269, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 42)) { return retval; }
			// MathLang.g:269:7: ( program EOF )
			DebugEnterAlt(1);
			// MathLang.g:269:9: program EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(269, 9);
			PushFollow(Follow._program_in_result2234);
			program163=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program163.Tree);
			DebugLocation(269, 20);
			EOF164=(IToken)Match(input,EOF,Follow._EOF_in_result2236); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("result", 42);
			LeaveRule("result", 42);
			Leave_result();
			if (state.backtracking > 0) { Memoize(input, 42, result_StartIndex); }
		}
		DebugLocation(269, 20);
		} finally { DebugExitRule(GrammarFileName, "result"); }
		return retval;

	}
	// $ANTLR end "result"

	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// MathLang.g:271:8: public execute : result ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 43);
		TraceIn("execute", 43);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);
		int execute_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.result_return result165 = default(MathLangParser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(271, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 43)) { return retval; }
			// MathLang.g:271:15: ( result )
			DebugEnterAlt(1);
			// MathLang.g:272:3: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(272, 3);
			PushFollow(Follow._result_in_execute2248);
			result165=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result165.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 43);
			LeaveRule("execute", 43);
			Leave_execute();
			if (state.backtracking > 0) { Memoize(input, 43, execute_StartIndex); }
		}
		DebugLocation(273, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	partial void Enter_synpred26_MathLang_fragment();
	partial void Leave_synpred26_MathLang_fragment();

	// $ANTLR start synpred26_MathLang
	public void synpred26_MathLang_fragment()
	{
		Enter_synpred26_MathLang_fragment();
		EnterRule("synpred26_MathLang_fragment", 69);
		TraceIn("synpred26_MathLang_fragment", 69);
		try
		{
			// MathLang.g:161:31: ( elsePart )
			DebugEnterAlt(1);
			// MathLang.g:161:31: elsePart
			{
			DebugLocation(161, 31);
			PushFollow(Follow._elsePart_in_synpred26_MathLang1361);
			elsePart();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred26_MathLang_fragment", 69);
			LeaveRule("synpred26_MathLang_fragment", 69);
			Leave_synpred26_MathLang_fragment();
		}
	}
	// $ANTLR end synpred26_MathLang

	partial void Enter_synpred29_MathLang_fragment();
	partial void Leave_synpred29_MathLang_fragment();

	// $ANTLR start synpred29_MathLang
	public void synpred29_MathLang_fragment()
	{
		Enter_synpred29_MathLang_fragment();
		EnterRule("synpred29_MathLang_fragment", 72);
		TraceIn("synpred29_MathLang_fragment", 72);
		try
		{
			// MathLang.g:187:3: ( WRITELN term )
			DebugEnterAlt(1);
			// MathLang.g:187:3: WRITELN term
			{
			DebugLocation(187, 3);
			Match(input,WRITELN,Follow._WRITELN_in_synpred29_MathLang1609); if (state.failed) return;
			DebugLocation(187, 12);
			PushFollow(Follow._term_in_synpred29_MathLang1612);
			term();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred29_MathLang_fragment", 72);
			LeaveRule("synpred29_MathLang_fragment", 72);
			Leave_synpred29_MathLang_fragment();
		}
	}
	// $ANTLR end synpred29_MathLang

	partial void Enter_synpred31_MathLang_fragment();
	partial void Leave_synpred31_MathLang_fragment();

	// $ANTLR start synpred31_MathLang
	public void synpred31_MathLang_fragment()
	{
		Enter_synpred31_MathLang_fragment();
		EnterRule("synpred31_MathLang_fragment", 74);
		TraceIn("synpred31_MathLang_fragment", 74);
		try
		{
			// MathLang.g:189:3: ( WRITELN term )
			DebugEnterAlt(1);
			// MathLang.g:189:3: WRITELN term
			{
			DebugLocation(189, 3);
			Match(input,WRITELN,Follow._WRITELN_in_synpred31_MathLang1624); if (state.failed) return;
			DebugLocation(189, 12);
			PushFollow(Follow._term_in_synpred31_MathLang1627);
			term();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred31_MathLang_fragment", 74);
			LeaveRule("synpred31_MathLang_fragment", 74);
			Leave_synpred31_MathLang_fragment();
		}
	}
	// $ANTLR end synpred31_MathLang

	partial void Enter_synpred32_MathLang_fragment();
	partial void Leave_synpred32_MathLang_fragment();

	// $ANTLR start synpred32_MathLang
	public void synpred32_MathLang_fragment()
	{
		Enter_synpred32_MathLang_fragment();
		EnterRule("synpred32_MathLang_fragment", 75);
		TraceIn("synpred32_MathLang_fragment", 75);
		try
		{
			// MathLang.g:190:3: ( IDENT ASSIGN term )
			DebugEnterAlt(1);
			// MathLang.g:190:3: IDENT ASSIGN term
			{
			DebugLocation(190, 3);
			Match(input,IDENT,Follow._IDENT_in_synpred32_MathLang1631); if (state.failed) return;
			DebugLocation(190, 9);
			Match(input,ASSIGN,Follow._ASSIGN_in_synpred32_MathLang1633); if (state.failed) return;
			DebugLocation(190, 17);
			PushFollow(Follow._term_in_synpred32_MathLang1636);
			term();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred32_MathLang_fragment", 75);
			LeaveRule("synpred32_MathLang_fragment", 75);
			Leave_synpred32_MathLang_fragment();
		}
	}
	// $ANTLR end synpred32_MathLang

	partial void Enter_synpred33_MathLang_fragment();
	partial void Leave_synpred33_MathLang_fragment();

	// $ANTLR start synpred33_MathLang
	public void synpred33_MathLang_fragment()
	{
		Enter_synpred33_MathLang_fragment();
		EnterRule("synpred33_MathLang_fragment", 76);
		TraceIn("synpred33_MathLang_fragment", 76);
		try
		{
			// MathLang.g:191:3: ( arrayId ASSIGN term )
			DebugEnterAlt(1);
			// MathLang.g:191:3: arrayId ASSIGN term
			{
			DebugLocation(191, 3);
			PushFollow(Follow._arrayId_in_synpred33_MathLang1640);
			arrayId();
			PopFollow();
			if (state.failed) return;
			DebugLocation(191, 11);
			Match(input,ASSIGN,Follow._ASSIGN_in_synpred33_MathLang1642); if (state.failed) return;
			DebugLocation(191, 19);
			PushFollow(Follow._term_in_synpred33_MathLang1645);
			term();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred33_MathLang_fragment", 76);
			LeaveRule("synpred33_MathLang_fragment", 76);
			Leave_synpred33_MathLang_fragment();
		}
	}
	// $ANTLR end synpred33_MathLang

	partial void Enter_synpred43_MathLang_fragment();
	partial void Leave_synpred43_MathLang_fragment();

	// $ANTLR start synpred43_MathLang
	public void synpred43_MathLang_fragment()
	{
		Enter_synpred43_MathLang_fragment();
		EnterRule("synpred43_MathLang_fragment", 86);
		TraceIn("synpred43_MathLang_fragment", 86);
		try
		{
			// MathLang.g:216:38: ( ';' constSingle )
			DebugEnterAlt(1);
			// MathLang.g:216:38: ';' constSingle
			{
			DebugLocation(216, 38);
			Match(input,70,Follow._70_in_synpred43_MathLang1767); if (state.failed) return;
			DebugLocation(216, 43);
			PushFollow(Follow._constSingle_in_synpred43_MathLang1770);
			constSingle();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred43_MathLang_fragment", 86);
			LeaveRule("synpred43_MathLang_fragment", 86);
			Leave_synpred43_MathLang_fragment();
		}
	}
	// $ANTLR end synpred43_MathLang
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA14 dfa14;
	DFA21 dfa21;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa14 = new DFA14( this, SpecialStateTransition14 );
		dfa21 = new DFA21( this );
	}

	private class DFA14 : DFA
	{
		private const string DFA14_eotS =
			"\xE\xFFFF";
		private const string DFA14_eofS =
			"\xE\xFFFF";
		private const string DFA14_minS =
			"\x1\x11\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x9\xFFFF";
		private const string DFA14_maxS =
			"\x1\x35\x1\xFFFF\x1\x0\x1\xFFFF\x1\x0\x9\xFFFF";
		private const string DFA14_acceptS =
			"\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1\xFFFF\x1\x7\x1\x8\x1\x9\x1\xA\x1\x2"+
			"\x1\x4\x1\x5\x1\x6\x1\xB";
		private const string DFA14_specialS =
			"\x2\xFFFF\x1\x0\x1\xFFFF\x1\x1\x9\xFFFF}>";
		private static readonly string[] DFA14_transitionS =
			{
				"\x1\x1\x1\x2\x1\x3\x9\xFFFF\x1\x5\x3\xFFFF\x1\x6\x4\xFFFF\x1\x7\x1"+
				"\x8\xD\xFFFF\x1\x4",
				"",
				"\x1\xFFFF",
				"",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
		private static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
		private static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
		private static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
		private static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
		private static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
		private static readonly short[][] DFA14_transition;

		static DFA14()
		{
			int numStates = DFA14_transitionS.Length;
			DFA14_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA14_transition[i] = DFA.UnpackEncodedString(DFA14_transitionS[i]);
			}
		}

		public DFA14( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 14;
			this.eot = DFA14_eot;
			this.eof = DFA14_eof;
			this.min = DFA14_min;
			this.max = DFA14_max;
			this.accept = DFA14_accept;
			this.special = DFA14_special;
			this.transition = DFA14_transition;
		}

		public override string Description { get { return "185:1: simpleExpr : ( WRITE term | WRITELN term | READ term | WRITELN term | IDENT ASSIGN term | arrayId ASSIGN term | ifThenElse | forDo | whileDo | repeatUntil | assignOrCall );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition14(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA14_2 = input.LA(1);


				int index14_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred29_MathLang_fragment)) ) {s = 9;}

				else if ( (EvaluatePredicate(synpred31_MathLang_fragment)) ) {s = 10;}


				input.Seek(index14_2);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA14_4 = input.LA(1);


				int index14_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred32_MathLang_fragment)) ) {s = 11;}

				else if ( (EvaluatePredicate(synpred33_MathLang_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 13;}


				input.Seek(index14_4);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 14, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA21 : DFA
	{
		private const string DFA21_eotS =
			"\x7\xFFFF";
		private const string DFA21_eofS =
			"\x7\xFFFF";
		private const string DFA21_minS =
			"\x1\x35\x1\x45\x1\x35\x1\x8\x1\x45\x2\xFFFF";
		private const string DFA21_maxS =
			"\x1\x35\x1\x48\x1\x35\x1\xB\x1\x48\x2\xFFFF";
		private const string DFA21_acceptS =
			"\x5\xFFFF\x1\x2\x1\x1";
		private const string DFA21_specialS =
			"\x7\xFFFF}>";
		private static readonly string[] DFA21_transitionS =
			{
				"\x1\x1",
				"\x1\x2\x2\xFFFF\x1\x3",
				"\x1\x4",
				"\x3\x6\x1\x5",
				"\x1\x2\x2\xFFFF\x1\x3",
				"",
				""
			};

		private static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
		private static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
		private static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
		private static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
		private static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
		private static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
		private static readonly short[][] DFA21_transition;

		static DFA21()
		{
			int numStates = DFA21_transitionS.Length;
			DFA21_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA21_transition[i] = DFA.UnpackEncodedString(DFA21_transitionS[i]);
			}
		}

		public DFA21( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 21;
			this.eot = DFA21_eot;
			this.eof = DFA21_eof;
			this.min = DFA21_min;
			this.max = DFA21_max;
			this.accept = DFA21_accept;
			this.special = DFA21_special;
			this.transition = DFA21_transition;
		}

		public override string Description { get { return "222:1: varSingle : ( ( varParam ':' t1= type -> ^( $t1 varParam ) ) | ( varParam ':' ARRAY arraySize OF t2= type -> ^( ARRAY ^( varParam $t2 arraySize ) ) ) );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _set_in_bools0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _65_in_group1036 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_group1039 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_group1041 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group1046 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1050 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayId_in_group1054 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _bools_in_group1058 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_arrayId1067 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _67_in_arrayId1069 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_arrayId1070 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_arrayId1071 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_character1092 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_character1096 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayId_in_character1100 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NOT_in_not_logic1110 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _group_in_not_logic1116 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _not_logic_in_mult1125 = new BitSet(new ulong[]{0x300600000000002UL});
		public static readonly BitSet _set_in_mult1129 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _not_logic_in_mult1148 = new BitSet(new ulong[]{0x300600000000002UL});
		public static readonly BitSet _mult_in_add1160 = new BitSet(new ulong[]{0xC0000000000002UL});
		public static readonly BitSet _set_in_add1165 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _mult_in_add1176 = new BitSet(new ulong[]{0xC0000000000002UL});
		public static readonly BitSet _add_in_compare1188 = new BitSet(new ulong[]{0xFC00000000000002UL});
		public static readonly BitSet _set_in_compare1194 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _add_in_compare1221 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_and_logic1232 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _AND_in_and_logic1237 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _compare_in_and_logic1240 = new BitSet(new ulong[]{0x1000002UL});
		public static readonly BitSet _and_logic_in_or_logic1250 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _OR_in_or_logic1254 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _and_logic_in_or_logic1258 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _or_logic_in_term1270 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignOrCall_in_paramsad1278 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _character_in_paramsad1282 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _paramsad_in_params_1294 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _69_in_params_1299 = new BitSet(new ulong[]{0x30000000000000UL});
		public static readonly BitSet _paramsad_in_params_1301 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _THEN_in_thenPart1330 = new BitSet(new ulong[]{0x2000C2200E0020UL});
		public static readonly BitSet _operList_in_thenPart1333 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _70_in_elsePart1341 = new BitSet(new ulong[]{0x80000000UL});
		public static readonly BitSet _ELSE_in_elsePart1344 = new BitSet(new ulong[]{0x2000C2200E0020UL});
		public static readonly BitSet _operList_in_elsePart1347 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_ifThenElse1354 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_ifThenElse1357 = new BitSet(new ulong[]{0x40000000UL});
		public static readonly BitSet _thenPart_in_ifThenElse1359 = new BitSet(new ulong[]{0x2UL,0x40UL});
		public static readonly BitSet _elsePart_in_ifThenElse1361 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_forDo1371 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _IDENT_in_forDo1375 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _ASSIGN_in_forDo1377 = new BitSet(new ulong[]{0x30000000000000UL});
		public static readonly BitSet _character_in_forDo1381 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _TO_in_forDo1383 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_forDo1387 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _DO_in_forDo1389 = new BitSet(new ulong[]{0x2000C2200E0020UL});
		public static readonly BitSet _operList_in_forDo1391 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_whileDo1459 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_whileDo1461 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _DO_in_whileDo1463 = new BitSet(new ulong[]{0x2000C2200E0020UL});
		public static readonly BitSet _operList_in_whileDo1465 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REPEAT_in_repeatUntil1491 = new BitSet(new ulong[]{0x2000C2200E0020UL});
		public static readonly BitSet _operList_in_repeatUntil1493 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _UNTIL_in_repeatUntil1495 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_repeatUntil1497 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_assignOrCall1527 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _ASSIGN_in_assignOrCall1529 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _IDENT_in_assignOrCall1531 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_assignOrCall1533 = new BitSet(new ulong[]{0x30000000000000UL,0x4UL});
		public static readonly BitSet _params__in_assignOrCall1535 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_assignOrCall1537 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_assignOrCall1567 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_assignOrCall1569 = new BitSet(new ulong[]{0x30000000000000UL,0x4UL});
		public static readonly BitSet _params__in_assignOrCall1571 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_assignOrCall1573 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WRITE_in_simpleExpr1602 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_simpleExpr1605 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WRITELN_in_simpleExpr1609 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_simpleExpr1612 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _READ_in_simpleExpr1616 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_simpleExpr1619 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WRITELN_in_simpleExpr1624 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_simpleExpr1627 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1631 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1633 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_simpleExpr1636 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayId_in_simpleExpr1640 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1642 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_simpleExpr1645 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ifThenElse_in_simpleExpr1649 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _forDo_in_simpleExpr1653 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _whileDo_in_simpleExpr1657 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _repeatUntil_in_simpleExpr1661 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assignOrCall_in_simpleExpr1665 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BEGIN_in_groupExpr1676 = new BitSet(new ulong[]{0x2000C2200E0060UL});
		public static readonly BitSet _exprList_in_groupExpr1678 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _END_in_groupExpr1680 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simpleExpr_in_operList1702 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _groupExpr_in_operList1706 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simpleExpr_in_exprList1718 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_exprList1721 = new BitSet(new ulong[]{0x2000C2200E0022UL,0x40UL});
		public static readonly BitSet _groupExpr_in_exprList1728 = new BitSet(new ulong[]{0x2000C2200E0022UL,0x40UL});
		public static readonly BitSet _70_in_exprList1732 = new BitSet(new ulong[]{0x2000C2200E0022UL,0x40UL});
		public static readonly BitSet _IDENT_in_constSingle1749 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _ASSIGN_in_constSingle1751 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_constSingle1754 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CONST_DECL_in_constDecl1760 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _constSingle_in_constDecl1763 = new BitSet(new ulong[]{0x2UL,0x40UL});
		public static readonly BitSet _70_in_constDecl1767 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _constSingle_in_constDecl1770 = new BitSet(new ulong[]{0x2UL,0x40UL});
		public static readonly BitSet _67_in_arraySize1781 = new BitSet(new ulong[]{0x30000000000000UL});
		public static readonly BitSet _character_in_arraySize1785 = new BitSet(new ulong[]{0x0UL,0x80UL});
		public static readonly BitSet _71_in_arraySize1787 = new BitSet(new ulong[]{0x30000000000000UL});
		public static readonly BitSet _character_in_arraySize1791 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_arraySize1793 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ARRAY_in_arrayType1810 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _arraySize_in_arrayType1812 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _OF_in_arrayType1814 = new BitSet(new ulong[]{0x700UL});
		public static readonly BitSet _type_in_arrayType1818 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_type0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_varParam1853 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _69_in_varParam1858 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _IDENT_in_varParam1862 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _varParam_in_varSingle1874 = new BitSet(new ulong[]{0x0UL,0x100UL});
		public static readonly BitSet _72_in_varSingle1876 = new BitSet(new ulong[]{0x700UL});
		public static readonly BitSet _type_in_varSingle1880 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varParam_in_varSingle1901 = new BitSet(new ulong[]{0x0UL,0x100UL});
		public static readonly BitSet _72_in_varSingle1903 = new BitSet(new ulong[]{0x800UL});
		public static readonly BitSet _ARRAY_in_varSingle1905 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _arraySize_in_varSingle1907 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _OF_in_varSingle1909 = new BitSet(new ulong[]{0x700UL});
		public static readonly BitSet _type_in_varSingle1913 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varSingle_in_varAll1939 = new BitSet(new ulong[]{0x2UL,0x40UL});
		public static readonly BitSet _70_in_varAll1943 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _varSingle_in_varAll1946 = new BitSet(new ulong[]{0x2UL,0x40UL});
		public static readonly BitSet _VAR_DECL_in_varDecl1955 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _varAll_in_varDecl1958 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varAll_in_paramsDesc1966 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simpleExpr_in_funcExpr1984 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_funcExpr1987 = new BitSet(new ulong[]{0x2000C2200E0002UL});
		public static readonly BitSet _groupExpr_in_funcExpr1995 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_funcExpr1999 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FUNC_DECL_in_funcDecl2010 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _IDENT_in_funcDecl2012 = new BitSet(new ulong[]{0x0UL,0x6UL});
		public static readonly BitSet _65_in_funcDecl2019 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _paramsDesc_in_funcDecl2023 = new BitSet(new ulong[]{0x0UL,0x100UL});
		public static readonly BitSet _noParamsDesc_in_funcDecl2029 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_funcDecl2031 = new BitSet(new ulong[]{0x0UL,0x100UL});
		public static readonly BitSet _72_in_funcDecl2037 = new BitSet(new ulong[]{0x700UL});
		public static readonly BitSet _type_in_funcDecl2039 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_funcDecl2041 = new BitSet(new ulong[]{0x2000C2200FE020UL});
		public static readonly BitSet _declList_in_funcDecl2044 = new BitSet(new ulong[]{0x2000C2200E0020UL});
		public static readonly BitSet _funcExpr_in_funcDecl2047 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PROC_DECL_in_procDecl2082 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _IDENT_in_procDecl2084 = new BitSet(new ulong[]{0x0UL,0x6UL});
		public static readonly BitSet _65_in_procDecl2091 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _paramsDesc_in_procDecl2095 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _noParamsDesc_in_procDecl2101 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_procDecl2103 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_procDecl2107 = new BitSet(new ulong[]{0x2000C2200FE020UL});
		public static readonly BitSet _declList_in_procDecl2110 = new BitSet(new ulong[]{0x2000C2200E0020UL});
		public static readonly BitSet _funcExpr_in_procDecl2113 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _constDecl_in_decl2148 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _varDecl_in_decl2152 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _funcDecl_in_decl2156 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _procDecl_in_decl2160 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decl_in_declList2170 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_declList2173 = new BitSet(new ulong[]{0x1E002UL});
		public static readonly BitSet _PROGRAM_in_program2185 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _IDENT_in_program2187 = new BitSet(new ulong[]{0x0UL,0x40UL});
		public static readonly BitSet _70_in_program2189 = new BitSet(new ulong[]{0x1E020UL});
		public static readonly BitSet _declList_in_program2191 = new BitSet(new ulong[]{0x20UL});
		public static readonly BitSet _BEGIN_in_program2193 = new BitSet(new ulong[]{0x2000C2200E0060UL});
		public static readonly BitSet _exprList_in_program2195 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _END_in_program2197 = new BitSet(new ulong[]{0x0UL,0x200UL});
		public static readonly BitSet _73_in_program2198 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_result2234 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result2236 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute2248 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _elsePart_in_synpred26_MathLang1361 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WRITELN_in_synpred29_MathLang1609 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_synpred29_MathLang1612 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WRITELN_in_synpred31_MathLang1624 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_synpred31_MathLang1627 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_synpred32_MathLang1631 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _ASSIGN_in_synpred32_MathLang1633 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_synpred32_MathLang1636 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _arrayId_in_synpred33_MathLang1640 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _ASSIGN_in_synpred33_MathLang1642 = new BitSet(new ulong[]{0x31800004000000UL,0x2UL});
		public static readonly BitSet _term_in_synpred33_MathLang1645 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _70_in_synpred43_MathLang1767 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _constSingle_in_synpred43_MathLang1770 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
