CREATE str 1 CELLS ALLOT
CHAR a str !
CHAR b str 1 + !
CHAR c str 2 + !
str 3 TYPE  ( => abc )

: def  ( -- c-addr u )  S" def" ;
def str SWAP MOVE
str 3 TYPE  ( => def )

: concat  {  c-addr1 u1 c-addr2 u2 -- c-addr3 u3 }
  c-addr2 c-addr1 u1 u2 + DUP >R  ( S: c-addr2 c-addr1 u3 ) ( R: u3 )
  HERE SWAP ALLOT DUP >R  ( S: c-addr2 c-addr1 c-addr3 ) ( R: u3 c-addr3 )
  u1 MOVE R@ u1 +         ( S: c-addr2 [c-addr3 + u1] )
  u2 MOVE R> R>           ( S: c-addr3 u3 ) ( R: )
;

: ghi  ( -- c-addr u )  S" gh" S" i" concat ;
ghi TYPE ( => ghi )
