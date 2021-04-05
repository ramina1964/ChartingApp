module SurfacePlotTemplate

// Include the following load instructions in a Script File
//#r "../../bin/XPlot.Plotly/netstandard2.0/XPlot.Plotly.dll"
//#r "../../packages/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"

open System
open XPlot.Plotly
open Utility


let z =
    let rnd = Random()
    [ for _ in 1 .. 25 ->
        [ for _ in 1 .. 25 ->
            rnd.Next(0, 400) ]]

let layout =
    Layout(
        autosize = false,
        margin =
            Margin(
                l = 65.,
                r = 50.,
                b = 65.,
                t = 90.))

let random3dChart =
    Surface(z = z)
    |> Chart.Plot
    |> Chart.WithId("3D Random-Walk")
    |> Chart.WithTitle("3D Random-Walk")
    |> Chart.WithLayout layout
    |> Chart.WithWidth 700
    |> Chart.WithHeight 500

//---------------------- Generate Linearly Spaced Vector ----------------------
let size = 100
let x = linspace(-5., 5., size)
let y = linspace(-5., 5., size)

let RollerCoasterSur x y = - (5. * x / (x**2. + y**2. + 1. ))

let zRollerCoaster = 
    Array.init size (fun i -> 
        Array.init size (fun j -> RollerCoasterSur x.[j] y.[i] ))

let rollerCoaster = 
    Surface(z = zRollerCoaster)
    |> Chart.Plot
    |> Chart.WithId("Roller Coaster")
    |> Chart.WithTitle("Roller Coaster")


