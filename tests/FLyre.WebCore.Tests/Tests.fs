module FLyre.WebCore.Tests

open NUnit.Framework
open FLyre.WebCore.Controllers
open System.Web.Mvc

let returnsViewResult (cf) =
    let res = cf()
    Assert.AreEqual(res.GetType(), typeof<ViewResult>)

let returnsPartialViewResult (cf) =
    let res = cf()
    Assert.AreEqual(res.GetType(), typeof<PartialViewResult>)

[<Test>]
let ``Home Controller Index Returns ViewResult`` () =
    returnsViewResult(fun _ -> (new HomeController()).Index())

[<Test>]
let ``Home Controller Home Returns Partial ViewResult``() =
    returnsPartialViewResult(fun _ -> (new HomeController()).Home())

[<Test>]
let ``Account Controller Index Returns Partial View Result``() =
    returnsPartialViewResult(fun _ -> (new AccountController()).Index())

[<Test>]
let ``Chat Controller Index Returns Partial View Result``() =
    returnsPartialViewResult(fun _ -> (new ChatController()).Index())