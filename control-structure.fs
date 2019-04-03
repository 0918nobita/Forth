: foo  ( u -- )
  CASE
    1 OF ." one" ENDOF
    2 OF ." two" ENDOF
    ." others"
  ENDCASE
  CR
;

1 foo
2 foo
3 foo
