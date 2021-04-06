module CombinedPlot

open FSharp.Plotly
open MathFunctions
open StylingAxes


let yMinSin = sineData |> List.min
let yMaxSin = sineData |> List.max

// Combining Charts in the same plot
let combinedSinCos =
    [ 
        Chart.Spline(xData, xData |> List.map sin, Name = "sin(x)")
        Chart.Spline(xData, xData |> List.map cos, Name = "cos(x)")
    ]
    |> Chart.Combine
    |> Chart.withTitle ("sin(x) and cos(x)")
    |> Chart.withX_Axis (myXAxis xMin)
    |> Chart.withY_Axis (myYAxis (yMinSin, yMaxSin))
    |> Chart.withSize (750., 750.)

// Stacking Charts above each other
let stackedSinCos = 
    [
        Chart.Spline(xData, xData |> List.map sin)
        |> Chart.withTraceName(Name="sin(x)")
        |> Chart.withX_Axis(myXAxis xMin)
        |> Chart.withY_Axis(myYAxis (yMinSin, yMaxSin))

        Chart.Spline(xData, xData|> List.map cos)
        |> Chart.withTraceName(Name="cos(x)")
        |> Chart.withX_Axis(myXAxis xMin)
        |> Chart.withY_Axis(myYAxis (yMinSin, yMaxSin))
    ]
    |> Chart.Stack(1, 0.20)
