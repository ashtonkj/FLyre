namespace FLyre.WebCore.Controllers

open System.Web.Mvc

type ChatController() =
    inherit Controller()
    member this.Index() = this.PartialView()