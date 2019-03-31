: test  ' dup execute execute ;
: foo  cr .s ;

." test foo"
test foo

: 2-times  ' dup >r execute r> execute ;

cr cr ." 2-times foo"
2-times foo

: provide-swap  ['] swap ;

cr cr ." ['] test" cr
1 2 provide-swap execute .s
