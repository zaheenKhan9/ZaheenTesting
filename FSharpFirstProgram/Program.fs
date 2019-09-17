// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let sayHello() = 
 printfn "Hello"

[<EntryPoint>]
let main argv = 
    sayHello()
    System.Console.ReadKey() |> ignore

    0 // return an integer exit code
