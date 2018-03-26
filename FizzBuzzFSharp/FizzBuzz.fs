namespace FizzBuzzFSharp

module FizzBuzzFSharp = 
    let divBy x d = x % d = 0
    let addFizz s = s + "Fizz"
    let addBuzz s = s + "Buzz"
    
    let fizzBuzz x = 
        match x with
        | x when divBy x 15 -> "" |> addFizz |> addBuzz
        | x when divBy x 5 -> "" |> addBuzz 
        | x when divBy x 3 ->  "" |> addFizz
        | x -> string x