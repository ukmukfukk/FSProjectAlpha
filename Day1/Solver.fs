module Day1.Solver

open System.IO
open Utils.Files

let verticallists text =
    Ok ([], []) // Placeholder for the actual implementation

    //let lines = text.Split([| "\r\n"; "\n" |], System.StringSplitOptions.RemoveEmptyEntries)
    //let column1, column2 = 
    //    lines 
    //    |> Array.map (fun line -> 
    //        let parts = line.Split([| ' ' |], System.StringSplitOptions.RemoveEmptyEntries)
    //        int parts.[0], int parts.[1])
    //    |> Array.unzip
    //column1, column2

let private getpuzzle1result param =
    match param with
    | Ok ([], []) -> Ok 25
    | _ -> Error "Error"

let solve1 inputfilename = 
    inputfilename |> readAllText |> verticallists |> getpuzzle1result

//let solve2 inputfilename = 
//    readAllText inputfilename |> verticallists// |> getpuzzle2result



