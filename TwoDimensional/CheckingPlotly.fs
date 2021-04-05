module CheckingPlotly

open System
open FSharp.Plotly.Colors
open FSharp.Plotly
open StylingAxes


let cosData = xData |> List.map Math.Cos
let cosPlotStyled =
    Chart.Point(xData, cosData)
    |> Chart.withMarkerStyle (
        Size = 3,
        Color = (Table.Office.darkYellow |> toWebColor),
        Symbol = StyleParam.Symbol.Asterisk
    )
    |> Chart.withTitle ("cos(x)")
    |> Chart.withX_AxisStyle ("x", Showline = true, Showgrid = true, MinMax = xMinMax)
    |> Chart.withY_AxisStyle ("y", Showline = true, Showgrid = true)

 // A more functional style
let sineData = xData |> List.map Math.Sin
let sinePlotStyled =
    Chart.Point(xData, sineData)
    |> Chart.withMarkerStyle (
        Size = 3,
        Color = (Table.Office.red |> toWebColor),
        Symbol = StyleParam.Symbol.Diamond
    )
    |> Chart.withTitle ("sin(x)")
    |> Chart.withX_AxisStyle ("x", Showline = true, Showgrid = true, MinMax = xMinMax)
    |> Chart.withY_AxisStyle ("y", Showline = true, Showgrid = true)

// Sine function with mirrored axes
let mirroredSinChart =
    Chart.Point(xData, sineData)
    |> Chart.withMarkerStyle (
        Size = 3,
        Color = (Table.Office.darkGreen |> toWebColor),
        Symbol = StyleParam.Symbol.Square
    )
    |> Chart.withTitle ("sin(x) with Mirror Axes")
    |> Chart.withX_Axis (myXAxis ())
    |> Chart.withY_Axis (myYAxis ())
    |> Chart.withSize (750., 750.)
