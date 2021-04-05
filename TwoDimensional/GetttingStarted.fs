module GetttingStarted

open XPlot.Plotly
open Utility


let xData = linspace(-20., 20., 801)
let points = [ for x in xData -> (x, x * x) ]

let oscFunc x =
    System.Math.Sin(x) / x
let oscPoints = [for x in xData -> x, (oscFunc x)]

// A Line Chart
let layout =
  Layout(title = "A Demping Oscillatory Function",
         showlegend = false,
         plot_bgcolor = "rgb(220, 220, 220")

let oscillatoryFunc =
        oscPoints
        |> Chart.Line
        |> Chart.WithWidth 900
        |> Chart.WithHeight 500
        |> Chart.WithLayout layout
        |> Chart.WithXTitle "x"
        |> Chart.WithYTitle "y"
