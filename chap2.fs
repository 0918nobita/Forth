\ Postfix Practice Problems [Quiz 2-a]

\ 1: c(a + b)  -->  a b + c *

\ (a b c -- result)
: q2a1 rot rot + * ;

\ 2: (3a - b) / 4 + c  -->  3 a * b - 4 / c +

\ (a b c -- result)
: q2a2 rot 3 * rot - 4 / + ;

\ 3: 0.5ab / 100  --> a b * 200 /

\ (a b -- result)
: q2a3 * 200 / ;

\ 4: (n + 1) / n  -->  n 1 + n /

\ (n -- result)
: q2a4 dup 1 + swap / ;

\ 5: x(7x + 5)  -->  x 7 * 5 + x *

\ (x -- result)
: q2a5 dup 7 * 5 + * ;

\ 6: a b - b a + /  <--  (a - b) / (b + a)

\ (a b -- result)
: q2a6 2dup - swap rot + / ;

\ 7: a b 10 * /  <--  a / 10b

\ (a b -- result)
: q2a7 10 * / ;

\ Definition-style Practice Problems [Quiz 2-b]

\ 1. ab + c  (c b a -- result)
: q2b1 * + ;

\ 2. (a - 4b) / 6 + c  (c a b -- result)
: q2b2 4 * - 6 / + ;

\ 3. a / 8b  (a b -- result)
: q2b3 8 * / ;

\ 4. 0.5ab / 100  (a b -- result)
: q2b4 * 200 / ;

\ 5. a(2a + 3)  (a -- result)
: q2b5 dup 2 * 3 + * ;

\ 6. (a - b) / c  (a b c -- result)
: q2b6 rot rot - swap / ;

\ Stack Maniqulation and Math Definitions [Quiz 2-c]

\ 1. (a b c -- c b a)
\ : rev3 rot rot swap ;
: rev3 swap rot ;

\ 2. over の再実装
\ (a b -- a b a)
: over' swap dup rot swap ;

\ 3. (a b c -- c a b) 1 番目の要素を 3 番目に移動
: <rot rot rot ;

\ 6. (a b -- result)
: q2c6 over 9 * swap - * ;

\ Problems

( 
  1. What is the difference between DUP DUP and 2DUP ?

  dup dup  [a b -- a b b b]
  2dup  [a b -- a b a b]
)

\ 2. (1 2 3 4 -- 4 3 2 1)
: reverse swap 2swap swap ;

\ 3. (1 2 3 -- 1 2 3 1 2 3)
: 3dup dup 2over rot ;

\ 4. a^2 + ab + c  (c a b -- result)
: p2-4 swap dup rot + * + ;

\ 5.
: convicted-of 0 ;
: homicide 20 + ;
: arson 10 + ;
: bookmaking 2 + ;
: tax-evasion 5 + ;
: will-serve . ." YEARS " ;

\ 6.
: egg.cartons 12 /mod . ." cartons and " . ." leftovers " ;
