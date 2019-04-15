: print-keycode  ( -- )
  BEGIN KEY DUP . 32 = UNTIL
;

print-keycode
