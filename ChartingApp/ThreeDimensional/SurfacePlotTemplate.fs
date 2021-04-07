module SurfacePlotTemplate

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

let rollerCoaster = 
    Surface(z = zRollerCoaster)
    |> Chart.Plot
    |> Chart.WithId("Roller Coaster")
    |> Chart.WithLayout (layout RollerCoasterTitle)
    |> Chart.WithWidth 580
    |> Chart.WithHeight 580


