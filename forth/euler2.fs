: even? 2 mod 0 = ;
: nextfib 2dup + ;
: origevenfibsum 0 1 1 ( last sum fib1 fib2 ) 3 roll begin ( sum fib1 fib2 last ) rot rot nextfib ( sum last fib1 fib2 fib3 ) rot drop ( sum last fib2 fib3 ) 3 roll over ( last fib2 fib3 sum fib3 ) dup even? if + else drop then ( last fib2 fib3 sum ) rot rot 3 roll ( sum fib2 fib3 last ) 2dup > until ( sum fib2 fib3 last ) drop drop drop ;

: addifeven ( a b -- c ) dup even? if + else drop then ;
: prepareadd ( sum last fib1 fib2 fib3 -- last fib2 fib3 sum fib3 ) rot drop 3 roll over ;
: addifeven2 prepareadd addifeven ;
: swap0and4 ( a b c d -- d b c a ) rot rot 3 roll ;
: establishfibsum ( last -- sum fib1 fib2 last ) 0 1 1 3 roll ;
: cleanupfibsum ( sum fib2 fib3 last -- sum ) drop drop drop ;
: stop? ( last fib2 fib3 sum -- sum fib2 fib3 last stop? ) swap0and4 2dup > ;
: nextfib2 ( fib1 fib2 last -- last fib1 fib2 fib3 ) rot rot nextfib ;
: evenfibsum establishfibsum begin nextfib2 addifeven2 stop? until cleanupfibsum ;

( load in gforth: s" euler2.fs" included )

( run with: clearstack 4000000 evenfibsum .s )

