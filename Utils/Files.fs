module Utils.Files

open System.IO

let readAllText filename = 
    try
        File.ReadAllText filename |> Ok
    with e ->
        Error e.Message