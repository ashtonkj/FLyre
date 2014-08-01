namespace FLyre.WebCore.Hubs

open Microsoft.AspNet.SignalR
open EkonBenefits.FSharp.Dynamic

type ChatHub() =
    inherit Hub()

    member this.SendMessage(message: string) =
        this.Clients.All?messageReceived(message) |> ignore
