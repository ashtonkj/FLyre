namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FLyre")>]
[<assembly: AssemblyProductAttribute("FLyre")>]
[<assembly: AssemblyDescriptionAttribute("A chat prototype")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
