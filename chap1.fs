\ Large Letter-F

: star  42 emit ;
: stars  0 do star loop ;
: margin  cr 30 spaces ;
: blip  margin star ;
: bar  margin 5 stars ;
: f  bar blip bar blip blip cr ;

\ Problems

( 1 )
: gift ." BOOKENDS" ;
: giver ." STEPHANIE" ;
: thanks cr ." DEAR " giver ." ," cr 4 spaces ." THANKS FOR THE " gift ." ." ;

( 2 )
: ten.less -10 + ;

( 
  3: After entering the words in Prob. 1,
  enter a new definition for GIVER to print someone else's name,
  then execute THANKS again. Can you explain why THANKS still prints
  out the first giver's name ?

  辞書は、ワードの再定義が行われても既存のワードの参照が保持される仕様になっているため 
)
