module Tests

open FizzBuzzFSharp

open System
open Xunit

[<Fact>]
let InputOf1ShouldReturn1 () =
    let result = FizzBuzzFSharp.fizzBuzz(1)
    Assert.Equal("1", result)
    
