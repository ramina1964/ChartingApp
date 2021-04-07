module SurfacePlot

open XPlot.Plotly
open MathFunctions
open StylingPlot


let hat =
    Surface(z = (zHat xAxis3D yAxis3D))
    |> Chart.Plot
    |> Chart.WithId("Mexican Hat")
    |> Chart.WithLayout (layout hatTitle)
    |> Chart.WithWidth 1000
    |> Chart.WithHeight 1000

let cone =
    Surface(z = (zCone xAxis3D yAxis3D))
    |> Chart.Plot
    |> Chart.WithId("Cone")
    |> Chart.WithLayout (layout ConeTitle)
    |> Chart.WithWidth 1000
    |> Chart.WithHeight 1000
    
let paraboloid =
    Surface(z = (zParaboloid xAxis3D yAxis3D))
    |> Chart.Plot
    |> Chart.WithId("Paraboloid")
    |> Chart.WithLayout (layout ParaboloidTitle)
    |> Chart.WithWidth 1000
    |> Chart.WithHeight 1000

let hyperboloid =
    Surface(z = zHyperboloid xAxis3D yAxis3D)
    |> Chart.Plot
    |> Chart.WithId("Hyperboloid")
    |> Chart.WithLayout (layout HyperboloidTitle)
    |> Chart.WithWidth 1000
    |> Chart.WithHeight 1000
