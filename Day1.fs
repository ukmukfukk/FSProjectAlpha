module Day1

open Utils
open Utils.Railway

let verticallists (lines:string list) =
    try
        let column1, column2 = 
            lines             
            |> List.toArray
            |> Array.map (fun line -> 
                let parts = line.Split([| ' ' |], System.StringSplitOptions.RemoveEmptyEntries)
                int parts.[0], int parts.[1])
            |> Array.unzip
        Ok (List.ofArray column1, List.ofArray column2)
    with e ->
        Error e.Message

let private sortlists (l1:int list, l2:int list) =
    List.sort l1, List.sort l2
    
let private difflist (l1:int list, l2:int list) =
    let rec diffrec sum t1 t2 =
        match t1 with
        | [] -> sum
        | head::tail -> diffrec ((head-List.head t2 |> abs)+sum) tail (List.tail t2)
    diffrec 0 l1 l2

let private countleftinright (l1:int list, l2:int list) =
    let l2count = List.countBy (fun x -> x) l2   
    let rec countrec sum t1 t2 =
        match t1 with
        | [] -> sum
        | head::tail -> countrec (head * (selectvaluefromkeyvaluelist head t2 0) + sum) tail t2
    countrec 0 l1 l2count

let solve1 inputfilename = 
    inputfilename |> readLines >>= verticallists >>> sortlists >>> difflist

let solve2 inputfilename = 
    inputfilename |> readLines >>= verticallists >>> countleftinright



