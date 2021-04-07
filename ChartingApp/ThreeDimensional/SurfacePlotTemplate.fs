module SurfacePlotTemplate

// Include the following load instructions in a Script File
//#r "../../bin/XPlot.Plotly/netstandard2.0/XPlot.Plotly.dll"
//#r "../../packages/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"

open System
open XPlot.Plotly
open MathFunctions
open StylingPlot


let z =
    let rnd = Random()
    [ for _ in 1 .. 25 ->
        [ for _ in 1 .. 25 ->
            rnd.Next(0, 400) ]]

let random3dChart =
    Surface(z = z)
    |> Chart.Plot
    |> Chart.WithId("3D Random Chart")
    |> Chart.WithLayout (layout "3D Random Chart")
    |> Chart.WithWidth 700
    |> Chart.WithHeight 500

let RollerCoasterSur x y = - (5. * x / (x**2. + y**2. + 1. ))
let zRollerCoaster = 
    Array.init sizeRollerCoaster (fun i -> 
        Array.init sizeRollerCoaster (fun j -> RollerCoasterSur xRollerCoaster.[j] yRollerCoaster.[i] ))

let rollerCoaster = 
    Surface(z = zRollerCoaster)
    |> Chart.Plot
    |> Chart.WithId("Roller Coaster")
    |> Chart.WithLayout (layout RollerCoasterTitle)
    |> Chart.WithWidth 580
    |> Chart.WithHeight 580


