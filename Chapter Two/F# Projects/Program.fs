// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv = 
    let add a b = a + b
    let ac = add "a" "b"
    printfn "%s" ac
    0 // return an integer exit code
