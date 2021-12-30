open System
open System.Threading
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful

[<EntryPoint>]
let main argv = 

    let cts = new CancellationTokenSource()
    let conf = { defaultConfig with 
                  cancellationToken = cts.Token
                  bindings = [HttpBinding.createSimple Protocol.HTTP "0.0.0.0" 5172]
               }

    let debugHere : WebPart =
          fun (x : HttpContext) ->
            async {
              
              return! OK "Hot reload like!" x
            }

    let app = GET >=> debugHere

    let _ , server = startWebServerAsync conf app

    Async.Start(server, cts.Token)
    
    Console.CancelKeyPress.Add(fun _ -> cts.Cancel())
    Async.AwaitEvent Console.CancelKeyPress |> Async.RunSynchronously |> ignore 
    0
