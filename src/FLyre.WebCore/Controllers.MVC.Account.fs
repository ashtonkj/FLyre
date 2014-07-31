namespace FLyre.WebCore.Controllers

open System.Web.Mvc

type AccountController() = 
    inherit Controller()
    member this.Index() = this.PartialView()

