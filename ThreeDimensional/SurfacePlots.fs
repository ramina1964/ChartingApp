module SurfacePlot

open System
open XPlot.Plotly
open Utility

let size = 51
let xMax = 5.
let xMin = -xMax
let yMax = 5.
let yMin = -yMax
 
let xAxis = linspace(xMin, xMax, size)
let yAxis = linspace(yMin, yMax, size)

// Define some surface functions
let hatSur x y = Math.Sin(Math.Sqrt(x ** 2. + y ** 2.))
let ConeSur x y = Math.Sqrt(x ** 2. + y ** 2.)
let ParaboloidSur x y = x ** 2. + y ** 2.
let HyperboloidSur (x: float) (y: float) = x ** 2. - y ** 2.

// Apply zCoord Function to the surfaces above 
let zHat xValues yValues = zCoord hatSur xValues yValues
let zCone xValues yValues = zCoord ConeSur xValues yValues
let zParaboloid xValues yValues = zCoord ParaboloidSur xValues yValues
let zHyperboloid xValues yValues = zCoord HyperboloidSur xValues yValues

let layout =
    Layout(
        autosize = false,
        margin =
            Margin(
                l = 65.,
                r = 50.,
                b = 65.,
                t = 90.
            )
    )

let hat =
    Surface(z = (zHat xAxis yAxis))
    |> Chart.Plot
    |> Chart.WithLayout layout
    |> Chart.WithWidth 1500
    |> Chart.WithHeight 1200

let cone =
    Surface(z = (zCone xAxis yAxis))
    |> Chart.Plot
    |> Chart.WithLayout layout
    |> Chart.WithWidth 1500
    |> Chart.WithHeight 1200
    
let paraboloid =
    Surface(z = (zParaboloid xAxis yAxis))
    |> Chart.Plot
    |> Chart.WithLayout layout
    |> Chart.WithWidth 1500
    |> Chart.WithHeight 1200

let hyperboloid =
    Surface(z = zHyperboloid xAxis yAxis)
    |> Chart.Plot
    |> Chart.WithLayout layout
    |> Chart.WithWidth 1500
    |> Chart.WithHeight 1200
    