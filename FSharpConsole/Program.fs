// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    //printfn "Hello World from F#!"

    //variable and show value
    //let num1 = 40
    //printfn $"'num1' is {num1}"

    //change value
    //let mutable num1 = 40
    //num1 <- 50

    //num1 <- 50

    //printfn $"'num1' is {num1}"

    //operator
    let num1 = 40
    let num2 = 50
    let result = num1 + num2
    printfn $"'num1' is {result}"

    0 // return an integer exit code
