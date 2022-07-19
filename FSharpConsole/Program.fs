// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    //printfn "Hello World from F#!"

    //let num1 = 40
    //printfn $"'num1' is {num1}"

    let mutable num1 = 40
    num1 <- 50

    printfn $"'num1' is {num1}"

    0 // return an integer exit code
