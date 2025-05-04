#load "Utils.fs"
#load "Day1.fs"
open Day1

let expected1_1 = 11
let day1result1 = Day1.solve1 "Samples\Sample1.txt"

printfn "Checking Day1 puzzle 1"
match day1result1 with
| Ok value when value = expected1_1 -> "Success"
| Ok value -> sprintf "Value is %A, while expected is %A" value expected1_1
| Error e -> "Failed" + e
|> printfn "%A\n"