module CombinedPlot

open System
open XPlot.GoogleCharts
open FSharp.Plotly
open FSharp.Plotly.Colors
open XPlot.GoogleCharts.Html

open Utility
open StylingAxes
open CheckingPlotly

let yMin = sineData |> List.min
let yMax = sineData |> List.max

// Combining Charts in the same plot
let combinedSinCos =
    [ 
        Chart.Spline(xData, xData |> List.map sin, Name = "sin(x)")
        Chart.Spline(xData, xData |> List.map cos, Name = "cos(x)")
    ]
    |> Chart.Combine
    |> Chart.withTitle ("sin(x) and cos(x)")
    |> Chart.withX_Axis (myXAxis ())
    |> Chart.withY_Axis (myYAxis (yMin, yMax))
    |> Chart.withSize (750., 750.)

// Stacking Charts above each other
let stackedChart = 
    [
        Chart.Spline(xData, xData |> List.map sin)
        |> Chart.withTraceName(Name="sin(x)")
        |> Chart.withX_Axis(myXAxis ())
        |> Chart.withY_Axis(myYAxis (yMin, yMax))

        Chart.Spline(xData, xData|> List.map cos)
        |> Chart.withTraceName(Name="cos(x)")
        |> Chart.withX_Axis(myXAxis ())
        |> Chart.withY_Axis(myYAxis (yMin, yMax))
    ]
    |> Chart.Stack(1, 0.1)
