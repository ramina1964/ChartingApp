module SurfacePlot

open XPlot.Plotly
open MathFunctions

 
let layout =
    Layout(
        autosize = false,
        margin = Margin(l = 65., r = 50., b = 65., t = 90.)
    )

let hat =
    Surface(z = (zHat xAxis3D yAxis3D))
    |> Chart.Plot
    |> Chart.WithId("Mexican Hat")
    |> Chart.WithTitle("Mexican Hat")
    |> Chart.WithLayout layout
    |> Chart.WithWidth 1500
    |> Chart.WithHeight 1200

let cone =
    Surface(z = (zCone xAxis3D yAxis3D))
    |> Chart.Plot
    |> Chart.WithId("Cone")
    |> Chart.WithTitle("Cone")
    |> Chart.WithLayout layout
    |> Chart.WithWidth 1500
    |> Chart.WithHeight 1200
    
let paraboloid =
    Surface(z = (zParaboloid xAxis3D yAxis3D))
    |> Chart.Plot
    |> Chart.WithId("Paraboloid")
    |> Chart.WithTitle("Paraboloid")
    |> Chart.WithLayout layout
    |> Chart.WithWidth 1500
    |> Chart.WithHeight 1200

let hyperboloid =
    Surface(z = zHyperboloid xAxis3D yAxis3D)
    |> Chart.Plot
    |> Chart.WithId("Hyperboloid")
    |> Chart.WithTitle("Hyperboloid")
    |> Chart.WithLayout layout
    |> Chart.WithWidth 1500
    |> Chart.WithHeight 1200
    