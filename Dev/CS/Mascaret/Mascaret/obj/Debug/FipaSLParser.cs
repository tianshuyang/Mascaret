//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Utilisateur\Developpement\Mascaret\Dev\CS\Mascaret\Mascaret\BEHAVE\FipaSL.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Mascaret {

using System;
using System.Collections;
using System.Collections.Generic;

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class FipaSLParser : Parser {
	public const int
		T__4=1, T__3=2, T__2=3, T__1=4, T__0=5, DIGIT=6, ID=7, WS=8, LPAREN=9, 
		RPAREN=10, COLON=11;
	public static readonly string[] tokenNames = {
		"<INVALID>", "'done'", "'feasible'", "'action'", "'started'", "'.'", "DIGIT", 
		"ID", "WS", "'('", "')'", "':'"
	};
	public const int
		RULE_content = 0, RULE_contentexpression = 1, RULE_proposition = 2, RULE_wff = 3, 
		RULE_actionop = 4, RULE_actionexpression = 5, RULE_functionalterm = 6, 
		RULE_parameter = 7, RULE_parametername = 8, RULE_parametervalue = 9, RULE_term = 10, 
		RULE_constant = 11, RULE_numericalconstant = 12, RULE_agent = 13, RULE_functionsymbol = 14, 
		RULE_integer = 15, RULE_float = 16;
	public static readonly string[] ruleNames = {
		"content", "contentexpression", "proposition", "wff", "actionop", "actionexpression", 
		"functionalterm", "parameter", "parametername", "parametervalue", "term", 
		"constant", "numericalconstant", "agent", "functionsymbol", "integer", 
		"float"
	};

	public override string GrammarFileName { get { return "FipaSL.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }



	    public bool isAction = false;
	    public bool done = false;
	    public bool started = false;

	    public string value = "";

	    public string performer = "";
	    public string entityName = "";
	    public string actionName = "";
	    public string variable = "";

	    public List<string> paramValue = new List<string>();
	    public List<string> paramName = new List<string>();

	    

	public FipaSLParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ContentContext : ParserRuleContext {
		public ITerminalNode LPAREN() { return GetToken(FipaSLParser.LPAREN, 0); }
		public ITerminalNode RPAREN() { return GetToken(FipaSLParser.RPAREN, 0); }
		public ContentexpressionContext contentexpression() {
			return GetRuleContext<ContentexpressionContext>(0);
		}
		public ContentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_content; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterContent(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitContent(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitContent(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ContentContext content() {
		ContentContext _localctx = new ContentContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_content);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 34; Match(LPAREN);
			State = 35; contentexpression();
			State = 36; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ContentexpressionContext : ParserRuleContext {
		public ActionexpressionContext actionexpression() {
			return GetRuleContext<ActionexpressionContext>(0);
		}
		public PropositionContext proposition() {
			return GetRuleContext<PropositionContext>(0);
		}
		public ContentexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_contentexpression; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterContentexpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitContentexpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitContentexpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ContentexpressionContext contentexpression() {
		ContentexpressionContext _localctx = new ContentexpressionContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_contentexpression);
		try {
			State = 40;
			switch ( Interpreter.AdaptivePredict(_input,0,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 38; actionexpression();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 39; proposition();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PropositionContext : ParserRuleContext {
		public WffContext wff() {
			return GetRuleContext<WffContext>(0);
		}
		public PropositionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_proposition; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterProposition(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitProposition(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProposition(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PropositionContext proposition() {
		PropositionContext _localctx = new PropositionContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_proposition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42; wff();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WffContext : ParserRuleContext {
		public ActionexpressionContext actionexpression() {
			return GetRuleContext<ActionexpressionContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(FipaSLParser.LPAREN, 0); }
		public ActionopContext actionop() {
			return GetRuleContext<ActionopContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(FipaSLParser.RPAREN, 0); }
		public WffContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_wff; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterWff(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitWff(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWff(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public WffContext wff() {
		WffContext _localctx = new WffContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_wff);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 44; Match(LPAREN);
			State = 45; actionop();
			State = 46; actionexpression();
			State = 47; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ActionopContext : ParserRuleContext {
		public ActionopContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_actionop; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterActionop(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitActionop(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitActionop(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ActionopContext actionop() {
		ActionopContext _localctx = new ActionopContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_actionop);
		try {
			State = 54;
			switch (_input.La(1)) {
			case T__4:
				EnterOuterAlt(_localctx, 1);
				{
				State = 49; Match(T__4);
				done = true;
				}
				break;
			case T__3:
				EnterOuterAlt(_localctx, 2);
				{
				State = 51; Match(T__3);
				}
				break;
			case T__1:
				EnterOuterAlt(_localctx, 3);
				{
				State = 52; Match(T__1);
				started = true;
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ActionexpressionContext : ParserRuleContext {
		public AgentContext _agent;
		public ITerminalNode LPAREN() { return GetToken(FipaSLParser.LPAREN, 0); }
		public FunctionaltermContext functionalterm() {
			return GetRuleContext<FunctionaltermContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(FipaSLParser.RPAREN, 0); }
		public AgentContext agent() {
			return GetRuleContext<AgentContext>(0);
		}
		public ActionexpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_actionexpression; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterActionexpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitActionexpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitActionexpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ActionexpressionContext actionexpression() {
		ActionexpressionContext _localctx = new ActionexpressionContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_actionexpression);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 56; Match(LPAREN);
			State = 57; Match(T__2);
			isAction = true;
			State = 59; _localctx._agent = agent();
			performer = (_localctx._agent!=null?_input.GetText(_localctx._agent.start,_localctx._agent.stop):null);
			State = 61; functionalterm();
			State = 62; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionaltermContext : ParserRuleContext {
		public FunctionsymbolContext _functionsymbol;
		public ParameterContext[] parameter() {
			return GetRuleContexts<ParameterContext>();
		}
		public ITerminalNode LPAREN() { return GetToken(FipaSLParser.LPAREN, 0); }
		public ParameterContext parameter(int i) {
			return GetRuleContext<ParameterContext>(i);
		}
		public ITerminalNode RPAREN() { return GetToken(FipaSLParser.RPAREN, 0); }
		public FunctionsymbolContext functionsymbol() {
			return GetRuleContext<FunctionsymbolContext>(0);
		}
		public FunctionaltermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionalterm; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterFunctionalterm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitFunctionalterm(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunctionalterm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FunctionaltermContext functionalterm() {
		FunctionaltermContext _localctx = new FunctionaltermContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_functionalterm);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 64; Match(LPAREN);
			State = 65; _localctx._functionsymbol = functionsymbol();
			actionName = (_localctx._functionsymbol!=null?_input.GetText(_localctx._functionsymbol.start,_localctx._functionsymbol.stop):null);
			State = 70;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==COLON) {
				{
				{
				State = 67; parameter();
				}
				}
				State = 72;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			State = 73; Match(RPAREN);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParameterContext : ParserRuleContext {
		public ParameternameContext parametername() {
			return GetRuleContext<ParameternameContext>(0);
		}
		public ParametervalueContext parametervalue() {
			return GetRuleContext<ParametervalueContext>(0);
		}
		public ParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameter; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterParameter(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitParameter(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParameter(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParameterContext parameter() {
		ParameterContext _localctx = new ParameterContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_parameter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 75; parametername();
			State = 76; parametervalue();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParameternameContext : ParserRuleContext {
		public IToken _ID;
		public ITerminalNode ID() { return GetToken(FipaSLParser.ID, 0); }
		public ITerminalNode COLON() { return GetToken(FipaSLParser.COLON, 0); }
		public ParameternameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parametername; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterParametername(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitParametername(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParametername(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParameternameContext parametername() {
		ParameternameContext _localctx = new ParameternameContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_parametername);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 78; Match(COLON);
			State = 79; _localctx._ID = Match(ID);
			paramName.Add((_localctx._ID!=null?_localctx._ID.Text:null));
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParametervalueContext : ParserRuleContext {
		public TermContext _term;
		public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		public ParametervalueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parametervalue; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterParametervalue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitParametervalue(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParametervalue(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParametervalueContext parametervalue() {
		ParametervalueContext _localctx = new ParametervalueContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_parametervalue);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 82; _localctx._term = term();
			paramValue.Add((_localctx._term!=null?_input.GetText(_localctx._term.start,_localctx._term.stop):null));
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		public ConstantContext constant() {
			return GetRuleContext<ConstantContext>(0);
		}
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterTerm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitTerm(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTerm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		TermContext _localctx = new TermContext(_ctx, State);
		EnterRule(_localctx, 20, RULE_term);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 85; constant();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConstantContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(FipaSLParser.ID, 0); }
		public NumericalconstantContext numericalconstant() {
			return GetRuleContext<NumericalconstantContext>(0);
		}
		public ConstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constant; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterConstant(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitConstant(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConstant(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ConstantContext constant() {
		ConstantContext _localctx = new ConstantContext(_ctx, State);
		EnterRule(_localctx, 22, RULE_constant);
		try {
			State = 89;
			switch (_input.La(1)) {
			case DIGIT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 87; numericalconstant();
				}
				break;
			case ID:
				EnterOuterAlt(_localctx, 2);
				{
				State = 88; Match(ID);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NumericalconstantContext : ParserRuleContext {
		public FloatContext @float() {
			return GetRuleContext<FloatContext>(0);
		}
		public IntegerContext integer() {
			return GetRuleContext<IntegerContext>(0);
		}
		public NumericalconstantContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_numericalconstant; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterNumericalconstant(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitNumericalconstant(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumericalconstant(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NumericalconstantContext numericalconstant() {
		NumericalconstantContext _localctx = new NumericalconstantContext(_ctx, State);
		EnterRule(_localctx, 24, RULE_numericalconstant);
		try {
			State = 93;
			switch ( Interpreter.AdaptivePredict(_input,4,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 91; integer();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 92; @float();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AgentContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(FipaSLParser.ID, 0); }
		public AgentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_agent; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterAgent(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitAgent(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAgent(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AgentContext agent() {
		AgentContext _localctx = new AgentContext(_ctx, State);
		EnterRule(_localctx, 26, RULE_agent);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 95; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FunctionsymbolContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(FipaSLParser.ID, 0); }
		public FunctionsymbolContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_functionsymbol; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterFunctionsymbol(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitFunctionsymbol(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunctionsymbol(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FunctionsymbolContext functionsymbol() {
		FunctionsymbolContext _localctx = new FunctionsymbolContext(_ctx, State);
		EnterRule(_localctx, 28, RULE_functionsymbol);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 97; Match(ID);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IntegerContext : ParserRuleContext {
		public ITerminalNode DIGIT(int i) {
			return GetToken(FipaSLParser.DIGIT, i);
		}
		public ITerminalNode[] DIGIT() { return GetTokens(FipaSLParser.DIGIT); }
		public IntegerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_integer; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterInteger(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitInteger(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInteger(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IntegerContext integer() {
		IntegerContext _localctx = new IntegerContext(_ctx, State);
		EnterRule(_localctx, 30, RULE_integer);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 100;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 99; Match(DIGIT);
				}
				}
				State = 102;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( _la==DIGIT );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FloatContext : ParserRuleContext {
		public ITerminalNode DIGIT(int i) {
			return GetToken(FipaSLParser.DIGIT, i);
		}
		public ITerminalNode[] DIGIT() { return GetTokens(FipaSLParser.DIGIT); }
		public FloatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_float; } }
		public override void EnterRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.EnterFloat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IFipaSLListener typedListener = listener as IFipaSLListener;
			if (typedListener != null) typedListener.ExitFloat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFipaSLVisitor<TResult> typedVisitor = visitor as IFipaSLVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFloat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FloatContext @float() {
		FloatContext _localctx = new FloatContext(_ctx, State);
		EnterRule(_localctx, 32, RULE_float);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 105;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 104; Match(DIGIT);
				}
				}
				State = 107;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( _la==DIGIT );
			State = 109; Match(T__0);
			State = 111;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 110; Match(DIGIT);
				}
				}
				State = 113;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( _la==DIGIT );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\rv\x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4"+
		"\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4"+
		"\x11\t\x11\x4\x12\t\x12\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x5\x3+\n\x3"+
		"\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x5\x6\x39\n\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3"+
		"\b\x3\b\a\bG\n\b\f\b\xE\bJ\v\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n"+
		"\x3\n\x3\v\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x5\r\\\n\r\x3\xE\x3\xE\x5\xE"+
		"`\n\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x6\x11g\n\x11\r\x11\xE\x11h\x3"+
		"\x12\x6\x12l\n\x12\r\x12\xE\x12m\x3\x12\x3\x12\x6\x12r\n\x12\r\x12\xE"+
		"\x12s\x3\x12\x2\x2\x2\x13\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2"+
		"\x12\x2\x14\x2\x16\x2\x18\x2\x1A\x2\x1C\x2\x1E\x2 \x2\"\x2\x2\x2m\x2$"+
		"\x3\x2\x2\x2\x4*\x3\x2\x2\x2\x6,\x3\x2\x2\x2\b.\x3\x2\x2\x2\n\x38\x3\x2"+
		"\x2\x2\f:\x3\x2\x2\x2\xE\x42\x3\x2\x2\x2\x10M\x3\x2\x2\x2\x12P\x3\x2\x2"+
		"\x2\x14T\x3\x2\x2\x2\x16W\x3\x2\x2\x2\x18[\x3\x2\x2\x2\x1A_\x3\x2\x2\x2"+
		"\x1C\x61\x3\x2\x2\x2\x1E\x63\x3\x2\x2\x2 \x66\x3\x2\x2\x2\"k\x3\x2\x2"+
		"\x2$%\a\v\x2\x2%&\x5\x4\x3\x2&\'\a\f\x2\x2\'\x3\x3\x2\x2\x2(+\x5\f\a\x2"+
		")+\x5\x6\x4\x2*(\x3\x2\x2\x2*)\x3\x2\x2\x2+\x5\x3\x2\x2\x2,-\x5\b\x5\x2"+
		"-\a\x3\x2\x2\x2./\a\v\x2\x2/\x30\x5\n\x6\x2\x30\x31\x5\f\a\x2\x31\x32"+
		"\a\f\x2\x2\x32\t\x3\x2\x2\x2\x33\x34\a\x3\x2\x2\x34\x39\b\x6\x1\x2\x35"+
		"\x39\a\x4\x2\x2\x36\x37\a\x6\x2\x2\x37\x39\b\x6\x1\x2\x38\x33\x3\x2\x2"+
		"\x2\x38\x35\x3\x2\x2\x2\x38\x36\x3\x2\x2\x2\x39\v\x3\x2\x2\x2:;\a\v\x2"+
		"\x2;<\a\x5\x2\x2<=\b\a\x1\x2=>\x5\x1C\xF\x2>?\b\a\x1\x2?@\x5\xE\b\x2@"+
		"\x41\a\f\x2\x2\x41\r\x3\x2\x2\x2\x42\x43\a\v\x2\x2\x43\x44\x5\x1E\x10"+
		"\x2\x44H\b\b\x1\x2\x45G\x5\x10\t\x2\x46\x45\x3\x2\x2\x2GJ\x3\x2\x2\x2"+
		"H\x46\x3\x2\x2\x2HI\x3\x2\x2\x2IK\x3\x2\x2\x2JH\x3\x2\x2\x2KL\a\f\x2\x2"+
		"L\xF\x3\x2\x2\x2MN\x5\x12\n\x2NO\x5\x14\v\x2O\x11\x3\x2\x2\x2PQ\a\r\x2"+
		"\x2QR\a\t\x2\x2RS\b\n\x1\x2S\x13\x3\x2\x2\x2TU\x5\x16\f\x2UV\b\v\x1\x2"+
		"V\x15\x3\x2\x2\x2WX\x5\x18\r\x2X\x17\x3\x2\x2\x2Y\\\x5\x1A\xE\x2Z\\\a"+
		"\t\x2\x2[Y\x3\x2\x2\x2[Z\x3\x2\x2\x2\\\x19\x3\x2\x2\x2]`\x5 \x11\x2^`"+
		"\x5\"\x12\x2_]\x3\x2\x2\x2_^\x3\x2\x2\x2`\x1B\x3\x2\x2\x2\x61\x62\a\t"+
		"\x2\x2\x62\x1D\x3\x2\x2\x2\x63\x64\a\t\x2\x2\x64\x1F\x3\x2\x2\x2\x65g"+
		"\a\b\x2\x2\x66\x65\x3\x2\x2\x2gh\x3\x2\x2\x2h\x66\x3\x2\x2\x2hi\x3\x2"+
		"\x2\x2i!\x3\x2\x2\x2jl\a\b\x2\x2kj\x3\x2\x2\x2lm\x3\x2\x2\x2mk\x3\x2\x2"+
		"\x2mn\x3\x2\x2\x2no\x3\x2\x2\x2oq\a\a\x2\x2pr\a\b\x2\x2qp\x3\x2\x2\x2"+
		"rs\x3\x2\x2\x2sq\x3\x2\x2\x2st\x3\x2\x2\x2t#\x3\x2\x2\x2\n*\x38H[_hms";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Mascaret
