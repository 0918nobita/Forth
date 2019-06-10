: 2times  ( xt "<spaces>name" -- )
  CREATE ,
  DOES> @ TUCK EXECUTE SWAP EXECUTE
;

: plus3  ( n -- n )  3 + ;

' plus3 2times plus6 ( define plus6 )

' plus6 2times plus12 ( define plus12 )

3 plus12 . ( => 15 )

: mul2  ( n -- n )  2 * ;

' mul2 2times mul4 ( define mul4 )

' mul4 2times mul16 ( define mul16 )

2 mul16 . ( => 32 )
