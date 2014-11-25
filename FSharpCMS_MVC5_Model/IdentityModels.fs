namespace FSharpCMS_MVC5.Models

open System
open System.Data
open Microsoft.AspNet.Identity.EntityFramework

type ApplicationUser() =
    inherit IdentityUser()

type ApplicationDbContext() =
    inherit IdentityDbContext<ApplicationUser>()
    // TODO: see if this is proper or not
    member x.ApplicationDbContext() =
        new IdentityDbContext<ApplicationUser>("DefaultConnection")



(*
// Actual class to be dependent on
type Class1() = 
    member this.X = "F#"

// Interface Injection for Class1
type UseClass1 =
    abstract setUseClass1 : Class1 -> bool
*)
