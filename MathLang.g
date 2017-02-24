grammar MathLang;

options {
  language=CSharp3;
  output=AST;
  backtrack=true;
  memoize=true;
}


tokens {
  UNKNOWN						;

  BEGIN			= 'begin'		;
  END			= 'end'			;
  PROGRAM		= 'program'		;

  CHAR			= 'char'		;
  INTEGER		= 'integer'		;
  BOOLEAN		= 'boolean'		;
  ARRAY			= 'array'		;
  OF			= 'of'			;

  CONST_DECL	= 'const'		;
  VAR_DECL		= 'var'			;
  FUNC_DECL		= 'function'	;
  PROC_DECL		= 'procedure'	;

  WRITE			= 'Write'		;
  WRITELN		= 'Writeln'		;
  READ			= 'Read'		;
  READLN		= 'Readln'		;

  EXPR_LIST						;
  BLOCK							;
  PROGRAM						;
  DECL							;

  AND			= 'and'			; 
  OR			= 'or'			; 
  NOT			= 'not'			;

  PARAMS						;
  CALL							;

  IF			= 'if'			;
  THEN			= 'then'		;
  ELSE			= 'else'		;
  IFTHEN						;

  FOR			= 'for'			;
  TO			= 'to'			;
  DOWNTO		= 'downto'		;
  DO			= 'do'			;
  FROM							;

  WHILE			= 'while'		;
  DO			= 'do'			;

  REPEAT		= 'repeat'		;
  UNTIL			= 'until'		;

  VOID			= 'void'		;

  INC			= 'Inc'			;
  DEC			= 'Dec'			;
  ABS			= 'Abs'			;

  DIV			= 'div'			;
  MOD			= 'mod'			;

  TRUE			= 'true'		;
  FALSE			= 'false'		;




}


@lexer::namespace { MathLang }
@parser::namespace { MathLang }


WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n')+ {
    $channel=Hidden;
  }
;

SL_COMMENT:
  '//' (options { greedy=false; }: .)* '\r'? '\n' {
    $channel=Hidden;
  }
;
ML_COMMENT:
  '/*' (options { greedy=false; }: .)* '*/' {
    $channel=Hidden;
  }
;



NUMBER: ('0'..'9')+ ('.' ('0'..'9') => '.'('0'..'9')+)?
;
IDENT:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;
bools : TRUE | FALSE
;
ADD:      '+'   ;
SUB:      '-'   ;
MUL:      '*'   ;
DIVIS:	  '/'   ;

GE:       '>='  ; 
LE:       '<='  ; 
NEQUALS:  '<>'  ; 
EQUALS:   '='   ; 
GT:       '>'   ; 
LT:       '<'   ;

ASSIGN:	  ':='  ;


group:
  '('! term ')'!
| NUMBER
| IDENT
| arrayId
| bools
;


arrayId: IDENT '['term']' ->  ^( IDENT term )  ;

character:
	NUMBER
|	IDENT
|	arrayId
;

not_logic:	( NOT^ )? group ;

mult:		not_logic	( ( MUL | DIVIS | MOD | DIV )^ not_logic )*  ;
add:		mult		( ( ADD | SUB )^ mult  )*  ;
compare:	add			( ( GE | LE | NEQUALS | EQUALS | GT | LT )^ add )? ;

and_logic:	compare		( AND^ compare )*	;
or_logic:	and_logic	( OR^  and_logic )*	;

term:		or_logic	;

paramsad: assignOrCall | character			;

params_:	( paramsad  ( ',' paramsad )* )?  ->  ^( PARAMS paramsad* )  ;


thenPart:	THEN^	operList		;
elsePart:	';'! ELSE^	operList	;
ifThenElse:	IF^ term thenPart elsePart? 
;

forDo: FOR main=IDENT ASSIGN from=character TO to=term DO operList 
			-> ^( FOR 
				^( FROM ^( ASSIGN $main $from ) ) 
				^( TO $to )
				^( DO operList )
);

whileDo: WHILE term DO operList -> ^( WHILE term ^( DO operList ) ) ;

repeatUntil: REPEAT operList UNTIL term -> ^(REPEAT operList ^( UNTIL term ) ) ;



assignOrCall:
	( IDENT ASSIGN IDENT '(' params_ ')'
		-> ^( ASSIGN IDENT ^( CALL IDENT params_ ) ) )
|	( IDENT '(' params_ ')'
		-> ^( CALL IDENT params_ ) ) 
;
	

simpleExpr:
  WRITE^ term
| WRITELN^ term
| READ^ term 
| WRITELN^ term
| IDENT ASSIGN^ term
| arrayId ASSIGN^ term
| ifThenElse
| forDo
| whileDo
| repeatUntil
| assignOrCall

;

groupExpr: ( BEGIN exprList END ) -> ^( BLOCK exprList ) ;

operList:
  simpleExpr
| groupExpr
;

exprList: (
  simpleExpr	(';'!)+
| groupExpr		(';'!)*	
)*;




constSingle: IDENT ASSIGN^ term;
constDecl:	CONST_DECL^ constSingle ( ';'! constSingle )* ;

arraySize: '[' v1=character '..' v2=character ']' -> ^($v1 $v2);
arrayType:  ARRAY arraySize OF t2=type -> ^( ARRAY $t2 arraySize ) ;
type:		CHAR | INTEGER | BOOLEAN;
varParam:	IDENT ( (','!) IDENT )* ;
varSingle:  (varParam ':' t1=type -> ^( $t1 varParam )) | 
			(varParam ':' ARRAY arraySize OF t2=type -> ^(ARRAY ^(varParam  $t2 arraySize) ) );
varAll:		varSingle ( ';'! varSingle )*;
varDecl:	VAR_DECL^ varAll ;

paramsDesc: varAll ;
noParamsDesc:	-> PARAMS ;

funcExpr:
(simpleExpr	(';'!))*
| groupExpr		(';'!)
;

funcDecl:
	FUNC_DECL IDENT
	(
		'(' p1=paramsDesc | p2=noParamsDesc ')'
	)
	':' type ';'
	declList
	funcExpr
	-> ^( FUNC_DECL IDENT type $p1? $p2? declList funcExpr )	
;

procDecl:
	PROC_DECL IDENT
	(
		'(' p1=paramsDesc | p2=noParamsDesc ')'
	)';'
	declList
	funcExpr
	-> ^( PROC_DECL IDENT VOID $p1? $p2? declList funcExpr )
;

decl:
  constDecl
| varDecl
| funcDecl
| procDecl
;

declList: ( decl (';'!) )*;

program: PROGRAM IDENT ';' declList BEGIN exprList END'.'
	-> ^( PROGRAM IDENT ^( DECL declList ) ^( BLOCK exprList ) ) 
;

result: program EOF!;

public execute:
  result
;