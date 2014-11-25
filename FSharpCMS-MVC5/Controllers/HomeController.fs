namespace FSharpCMS_MVC5.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Mvc.Ajax
open System.Web.Security
open FSharpCMS_MVC5.Models

type HomeController() =
    inherit Controller()
    member this.Index () = this.View()
    [<Authorize>]
    member this.Text () = 
        this.Content("Hello")

