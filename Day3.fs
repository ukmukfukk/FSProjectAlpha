module Day3

open Utils
open Utils.Railway

let private extractsignanddiff n1 n2 =
    sign (n2 - n1), abs (n2 - n1)

let private islinesafe line =
    let rec islinesaferec line linesign =
        match line with
        | _::[] -> true
        | head1::head2::tail ->
            let s, diff = extractsignanddiff head1 head2
            match s, diff with
            | newlinesign, (1 | 2 | 3) when linesign = newlinesign -> islinesaferec (head2::tail) linesign
            | _, _ -> false
        | [] -> false

    let s, diff = extractsignanddiff (List.head line) (List.head (List.tail line))
    match s, diff with
    | (1 | -1), (1 | 2 | 3)  -> islinesaferec (List.tail line) s
    | _, _ -> false

let private countsafelines lines =
    List.fold (fun acc line ->
        match islinesafe line with
        | true -> acc + 1
        | false -> acc) 0 lines

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
    >>> countsafelines



