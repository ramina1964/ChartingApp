module CombinedPlot

open FSharp.Plotly
open MathFunctions
open StylingPlot


let yMinSinAndCos = sineData |> List.min
let yMaxSinAndCos = sineData |> List.max

// Combining Charts in the same plot
let combinedSinCos =
    [ 
        Chart.Spline(xData, xData |> List.map sin, Name = "sin(x)")
        Chart.Spline(xData, xData |> List.map cos, Name = "cos(x)")
    ]
    |> Chart.Combine
    |> Chart.withTitle ("f(x) = sin(x) and g(x) = cos(x)")
    |> Chart.withX_Axis (AxisX (xMin, xMax))
    |> Chart.withY_Axis (AxisY (yMinSinAndCos, yMaxSinAndCos))
    |> Chart.withSize (750., 750.)

// Stacking Charts above each other
let stackedSinCos = 
    [
        Chart.Spline(xData, xData |> List.map sin)
        |> Chart.withTraceName(Name="f(x) = sin(x)")
        |> Chart.withX_Axis(AxisX (xMin, xMax))
        |> Chart.withY_Axis(AxisY (yMinSinAndCos, yMaxSinAndCos))

        Chart.Spline(xData, xData|> List.map cos)
        |> Chart.withTraceName(Name="g(x) = cos(x)")
        |> Chart.withX_Axis(AxisX (xMin, xMax))
        |> Chart.withY_Axis(AxisY (yMinSinAndCos, yMaxSinAndCos))
    ]
    |> Chart.Stack(1, 0.20)
