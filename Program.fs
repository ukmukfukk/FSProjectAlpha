// For more information see https://aka.ms/fsharp-console-apps

let result = Day1.solve1 "Samples/input11.txt"

match result with
| Ok value -> printfn "Result is %A" value
| Error e -> printfn "Failed with error %A" e