// Learn more about F# at http://fsharp.org

open System
open MyLibrary

[<EntryPoint>]
let main argv =

    let lib = MyLibrary()
    lib.X |> printfn "%A"
    0 // return an integer exit code
