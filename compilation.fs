: test  ( -- u )
  [ 1 2 + . CR ]
  42
  [ .s CR ]
;

test .s CR CR

' SWAP . CR

: test2 ( -- )
  SWAP [ .s ]
;
