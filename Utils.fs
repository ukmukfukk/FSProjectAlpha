module Utils

open System.IO

module Railway =
    let (>>=) result func = Result.bind func result
    let (>>>) result func = Result.map func result

let readAllText filename = 
    try
        File.ReadAllText filename |> Ok
    with e ->
        Error e.Message

let readLines filename = 
    try
        File.ReadLines filename |> Seq.toList |> Ok
    with e ->
        Error e.Message

let selectvaluefromkeyvaluelist search l valueifnotfound = 
    let filtered = List.filter (fun (item:'a*int) -> 
                    match item with 
                    | key, _ when key = search -> true
                    | _ -> false
                    ) l

    match filtered with
        | [] -> valueifnotfound
        | head::_ -> snd head

let evaluate solveFunction filename expected description =  
      printfn "Checking %s" description  
      match solveFunction filename with  
      | Ok value when value = expected -> "Success"  
      | Ok value -> sprintf "Value is %A, while expected is %A" value expected  
      | Error e -> "Failed with error" + e  
      |> printfn "%A\n"  

let runpuzzle solveFunction filename description =  
    printfn "Running %s" description  
    match solveFunction filename with  
    | Ok value -> printfn "Result is %A" value
    | Error e -> printfn "Failed with error %A" e 