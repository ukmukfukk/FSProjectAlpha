// For more information see https://aka.ms/fsharp-console-apps

let expected1 = 25

let result = Day1.Solver.solve1 "./input11.txt"


//let testresult result =
match result with
| Ok value when value = expected1 -> "Success"
| Ok _ -> "Failed"
| Error _ -> "Failed" // Handle the Error case explicitly
|> printfn "%A"