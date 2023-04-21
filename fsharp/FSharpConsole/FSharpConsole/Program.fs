module Program =

    [<EntryPoint>]
    let main _ =
        let v = FSharpConsole.M1.getV ()
        printfn $"v = {v}"
        0
