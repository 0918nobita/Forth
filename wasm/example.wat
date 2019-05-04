(module
  (import "js" "mem" (memory 1))
  (func $add (param $lhs i32) (param $rhs i32)
    i32.const 0
    get_local $lhs
    get_local $rhs
    i32.add
    i32.store)
  (export "add" (func $add)))
