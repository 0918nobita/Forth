(module
  (import "console" "log" (func $log (param i32)))
  (func (export "logIt")
    i32.const 21
    i32.const 2
    i32.mul
    call $log))
