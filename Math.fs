module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let counter = 0
  let rec Collatz_fun (x: uint64) counter =
    if x = 1UL then counter
    elif x % 2UL = 0UL then Collatz_fun (uint64 (x / 2UL)) (counter + 1)
    else Collatz_fun (uint64 (3UL * x + 1UL)) (counter + 1)
  Collatz_fun (uint64 n) counter
