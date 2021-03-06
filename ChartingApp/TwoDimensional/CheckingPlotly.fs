module CheckingPlotly

open FSharp.Plotly.Colors
open FSharp.Plotly
open System
open MathFunctions
open Utility
open StylingPlot


// Do not use these options for Symbol, because the plot will vanish:
// Symbol = StyleParam.Symbol.Asterisk
// Symbol = StyleParam.Symbol.CrossThin
// Symbol = StyleParam.Symbol.Hash
// Symbol = StyleParam.Symbol.LineEW
// Symbol = StyleParam.Symbol.LineNS
// Symbol = StyleParam.Symbol.XThin
// Symbol = StyleParam.Symbol.YDown
// Symbol = StyleParam.Symbol.YLeft
// Symbol = StyleParam.Symbol.YRight
// Symbol = StyleParam.Symbol.YUp
let cosPlotStyled =
    Chart.Point(xData, cosData)
    |> Chart.withMarkerStyle (
        Size = 6,
        Color = (Table.Office.darkGreen |> toWebColor),
        Symbol = StyleParam.Symbol.Circle
    )
    |> Chart.withTitle ("cos(x)")
    |> Chart.withX_AxisStyle ("x", Showline = true, Showgrid = true, MinMax = xMinMax)
    |> Chart.withY_AxisStyle ("y", Showline = true, Showgrid = true)

// A more functional style
let sinePlotStyled =
    Chart.Point(xData, sineData)
    |> Chart.withMarkerStyle (Size = 3, Color = (Table.Office.red |> toWebColor), Symbol = StyleParam.Symbol.Diamond)
    |> Chart.withTitle ("sin(x)")
    |> Chart.withX_AxisStyle ("x", Showline = true, Showgrid = true, MinMax = xMinMax)
    |> Chart.withY_AxisStyle ("y", Showline = true, Showgrid = true)

let ySineMin = sineData |> List.min
let ySineMax = sineData |> List.max

let mirroredSinChart =
    Chart.Point(xData, sineData)
    |> Chart.withMarkerStyle (
        Size = 3,
        Color = (Table.Office.darkGreen |> toWebColor),
        Symbol = StyleParam.Symbol.Square
    )
    |> Chart.withTitle ("sin(x) with Mirror Axes")
    |> Chart.withX_Axis (MirroredXAxis(xMin, xMax))
    |> Chart.withY_Axis (MirroredYAxis(ySineMin, ySineMax))
    |> Chart.withSize (750., 750.)

// Sine and cosine functions. They have the same yMin and yMax.
let xOscExpMin = -3.16
let xOscExpMax = 2.5

let xOscExpData =
    linspace2 (xOscExpMin, xOscExpMax, 0.002264)

let yOscExpData =
    xOscExpData
    |> Array.map (fun x -> Math.Exp(-x) * Math.Sin(x))

let yOscExpMin = yOscExpData |> Array.min
let yOscExpMax = yOscExpData |> Array.max

let mirroredOscExpChart =
    Chart.Point(xOscExpData, yOscExpData)
    |> Chart.withMarkerStyle (
        Size = 3,
        Color = (Table.Office.darkGreen |> toWebColor),
        Symbol = StyleParam.Symbol.Square
    )
    |> Chart.withTitle ("y = exp(-x) * sin(x)")
    |> Chart.withX_Axis (MirroredXAxis(xOscExpMin, xOscExpMax))
    |> Chart.withY_Axis (MirroredYAxis(yOscExpMin, yOscExpMax))
    |> Chart.withSize (750., 750.)
