namespace FLyre.WebCore.Controllers

open System.Web.Mvc

type HomeController() = 
    inherit Controller()
    member this.Index() = this.View()
