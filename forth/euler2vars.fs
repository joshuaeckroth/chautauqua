( Author: Lars Brinkhoff - https://github.com/larsbrinkhoff )

variable sum
: even? dup 1 and 0= ; ( bitwise AND with last bit of number and 1 )
: ?sum even? if dup sum +! then ;
: end? dup 4000000 > ;
: fib begin tuck + ?sum end? until 2drop ;
: answer 0 sum ! 1 1 fib sum ? ;

( load in gforth: s" euler2vars.fs" included )

( run with: answer )

