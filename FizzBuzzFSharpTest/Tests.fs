module Tests

open FizzBuzzFSharp

open System
open Xunit

[<Fact>]
let InputOf1ShouldReturn1 () =
    let result = FizzBuzzFSharp.fizzBuzz(1)
    Assert.Equal("1", result)
    
[<Fact>]
let InputOf2ShouldReturn2 () =
    let result = FizzBuzzFSharp.fizzBuzz(2)
    Assert.Equal("2", result)
    
[<Fact>]
let InputOf3ShouldReturnFizz () =
    let result = FizzBuzzFSharp.fizzBuzz(3)
    Assert.Equal("Fizz", result)
    
[<Fact>]
let InputOf5ShouldReturnBuzz () =
    let result = FizzBuzzFSharp.fizzBuzz(5)
    Assert.Equal("Buzz", result)
        
[<Fact>]
let InputOf15ShouldReturnFizzBuzz () =
    let result = FizzBuzzFSharp.fizzBuzz(15)
    Assert.Equal("FizzBuzz", result)