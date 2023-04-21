module FSharpConsole.M1
    
    let f () =
        async {
            let v = Fantomas.Core.CodeFormatter.GetVersion() // breakpoint here, hit F7 (Step Into) once, continue with F8 (Step Over)
                                                             // this should bring you into CodeFormatter.fs from the Fantomas.Core package 
                                                             // continue with F8 (Step Over)
            return v // here we enter async.fs (from Microsoft.FSharp.Control), even though we used F8 to step over
        }
        
    let getV () =
        let v = f ()
        v |> Async.RunSynchronously
