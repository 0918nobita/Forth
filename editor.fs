: up  dup k-up = if s\" \e[1A" type then ;
: down  dup k-down = if s\" \e[1B" type then ;
: left  dup k-left = if s\" \e[1D" type then ;
: right  dup k-right = if s\" \e[1E" type then ;
: clear  s\" \ec" type ;

: editor  clear begin ekey up down left right , again ;
