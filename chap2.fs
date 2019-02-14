\ Postfix Practice Problems Quiz 2-a

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
