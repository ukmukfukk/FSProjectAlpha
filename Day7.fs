module Day7

open Utils
open Utils.Railway

let private cancalculate2op (line:string) =
    let split = line.Split([| ':' |], System.StringSplitOptions.RemoveEmptyEntries)
    let result = int64 split.[0]

    let split2 = split.[1].Trim().Split([| ' ' |], System.StringSplitOptions.RemoveEmptyEntries)
    let ops = Array.map (fun value -> int64 value) split2 |> Array.toList

    let rec cancalculaterec ops (result: int64) =
        match ops with
        | head::[] when head = result -> result
        | h1::h2::tail ->
            match cancalculaterec (h1 * h2::tail) result, cancalculaterec (h1 + h2::tail) result with
            | (0L, 0L) -> 0
            | _, _ -> result
        | [] -> 0
        | _ -> 0
    
    cancalculaterec ops result

let private concat (a:int64, b:int64) =
    a.ToString() + b.ToString()
    |> int64

let private cancalculate3op (line:string) =
    let split = line.Split([| ':' |], System.StringSplitOptions.RemoveEmptyEntries)
    let result = int64 split.[0]

    let split2 = split.[1].Trim().Split([| ' ' |], System.StringSplitOptions.RemoveEmptyEntries)
    let ops = Array.map (fun value -> int64 value) split2 |> Array.toList

    let rec cancalculaterec ops (result: int64) =
        match ops with
        | head::[] when head = result -> result
        | h1::h2::tail ->
            match cancalculaterec (h1 * h2::tail) result,
            cancalculaterec (h1 + h2::tail) result ,
            cancalculaterec (concat (h1, h2)::tail) result with            
            | (0L, 0L, 0L) -> 0
            | _, _, _ -> result
        | [] -> 0
        | _ -> 0
    
    cancalculaterec ops result

let private countlines3op lines =
    lines
    |> List.map (fun line -> cancalculate3op line)
    |> List.sum

let private countlines2op lines =
    lines
    |> List.map (fun line -> cancalculate2op line)
    |> List.sum

let solve1 inputfilename = 
    inputfilename 
    |> readLines
    >>> countlines2op

let solve2 inputfilename = 
    inputfilename 
    |> readLines
    >>> countlines3op