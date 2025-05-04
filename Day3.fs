module Day3

open Utils
open Utils.Railway

let private extractsignanddiff n1 n2 =
    sign (n2 - n1), abs (n2 - n1)

let private islinesafe line =
    let rec islinesaferec line linesign =
        match line with
        | _::[] -> 1
        | head1::head2::tail ->
            let s, diff = extractsignanddiff head1 head2
            match s, diff with
            | newlinesign, (1 | 2 | 3) when linesign = newlinesign -> islinesaferec (head2::tail) linesign
            | _, _ -> 0
        | [] -> 0

    let s, diff = extractsignanddiff (List.head line) (List.head (List.tail line))
    match s, diff with
    | (1 | -1), (1 | 2 | 3)  -> islinesaferec (List.tail line) s
    | _, _ -> 0

let private countsafelines lines =
    lines
    |> List.fold (fun acc line -> acc + islinesafe line) 0

let private checklinewithdampener line =
    let rec checklinewithdampenerrec line skip =
        let copy =
            line
            |> List.mapi (fun i x -> if i = skip then None else Some(x))
            |> List.choose id

        match islinesafe copy, skip with
        | 1, _ -> 1
        | 0, toskip when toskip < List.length line -> checklinewithdampenerrec line (toskip + 1)
        | _, _ -> 0

    checklinewithdampenerrec line 0

let private countsafelineswithdampener lines =
    lines
    |> List.fold (fun acc line ->
    let safe = islinesafe line
    match safe with
    | 1 -> acc + 1
    | 0 -> acc + checklinewithdampener line
    | _ -> acc) 0 

let private linestolists lines =
    lines
    |> List.map (fun (line:string) ->
        line.Split([| ' ' |], System.StringSplitOptions.RemoveEmptyEntries)
        |> Array.map (fun (value:string) -> int value)
        |> Array.toList)       

let solve1 inputfilename = 
    inputfilename
    |> readLines
    >>> linestolists
    >>> countsafelines

let solve2 inputfilename = 
    inputfilename
    |> readLines 
    >>> linestolists
    >>> countsafelineswithdampener