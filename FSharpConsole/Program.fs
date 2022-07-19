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
    //let num1 = 40
    //let num2 = 50
    //let result = num1 + num2
    //printfn $"'num1' is {result}"

    //if_else
    //let num1 =40

    //if num1 = 20 then
    //    printfn $"num1 equal 40"
    //elif num1 = 50 then
    //    printfn $"num1 equal 50"
    //else
    //    printfn $"num1 equal 40"

    //for to loop
    //for i = 1 to 10 do
    //   printf "%d " i
    //printfn ""

    let mutable num1 = 10
    for i = 1 to 10 do
        printf "%d " num1
        num1 <- num1 + 10        

    0 // return an integer exit code
