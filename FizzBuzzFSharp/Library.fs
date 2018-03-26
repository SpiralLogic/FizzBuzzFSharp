namespace FizzBuzzFSharp

module FizzBuzzFSharp = 

    let isModOfThree x = x % 3 = 0
    let isModOfFive x = x % 5 = 0
    let isModOfFifteen x = x % 15 = 0
    let addFizz s = s + "Fizz"
    let addBuzz s = s + "Buzz"
    
    let fizzBuzz x = 
        match x with
        | x when isModOfFifteen x -> addBuzz (addFizz "")
        | x when isModOfThree x -> addFizz "" 
        | x when isModOfFive x -> addBuzz ""
        | x -> string x
