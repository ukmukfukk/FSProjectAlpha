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