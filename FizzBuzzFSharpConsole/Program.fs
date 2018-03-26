// Learn more about F# at http://fsharp.org
open FizzBuzzFSharp
open System

[<EntryPoint>]
let main argv =
    [0..100] |> Seq.iter(fun (x) -> FizzBuzzFSharp.fizzBuzz x |> printfn "%s")
    0
        
