(module
  (import "js" "mem" (memory 1))
  (func $add (param $lhs i32) (param $rhs i32)
    i32.const 0
    get_local $lhs
    get_local $rhs
    i32.add
    i32.store)
  (func $factorial (param $n i32) (result i32)
    get_local $n
    i32.const 0
    i32.le_s
    (if (result i32)
      (then i32.const 1)
      (else
        get_local $n
        get_local $n
        i32.const 1
        i32.sub
        call $factorial
        i32.mul)))
  (export "add" (func $add))
  (export "factorial" (func $factorial)))
