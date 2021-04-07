module ScatterPlot

open FSharp.Plotly
open XPlot.Plotly
open ScatterPoints


//  A Scatter Plot

let traces =
    [ for trial in HobbsPearson ->
          Scatter(r = trial.Radial, t = trial.Angular, mode = "markers", marker = Marker(color = trial.Color)) ]

let layout =
    Layout(title = "Hobbs-Pearson Trials", showlegend = false, plot_bgcolor = "rgb(220, 220, 220)")

let scatterPlot =
    traces
    |> Chart.Plot
    |> Chart.WithLayout layout

// Spline Interpolation of Data Points
let x = [ 1. .. 1. .. 10. ]

let y = [ 2.; 1.5; 5.; 1.5; 3.; 2.5; 2.5; 1.5; 3.5; 1. ]

let splineLayout =
    Layout(
        title = "Spline Interpolation of Data Points",
        showlegend = false,
        plot_bgcolor = "rgb(220, 220, 220)")

let spline =
    Chart.Spline(x, y, Name = "spline")

//let splineInterpolation = "Spline Interpolation"

let splineWithMoreControl =
    Chart.Spline(x, y,
                Name = "spline",
                Smoothing = 0.4)

