module CheckingPlotly

open FSharp.Plotly.Colors
open FSharp.Plotly
open StylingAxes
open MathFunctions


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
    |> Chart.withMarkerStyle (
        Size = 3,
        Color = (Table.Office.red |> toWebColor),
        Symbol = StyleParam.Symbol.Diamond
    )
    |> Chart.withTitle ("sin(x)")
    |> Chart.withX_AxisStyle ("x", Showline = true, Showgrid = true, MinMax = xMinMax)
    |> Chart.withY_AxisStyle ("y", Showline = true, Showgrid = true)

// Sine function with mirrored axes
let yMin = sineData |> List.min
let yMax = sineData |> List.max
let mirroredSinChart =
    Chart.Point(xData, sineData)
    |> Chart.withMarkerStyle (
        Size = 3,
        Color = (Table.Office.darkGreen |> toWebColor),
        Symbol = StyleParam.Symbol.Square
    )
    |> Chart.withTitle ("sin(x) with Mirror Axes")
    |> Chart.withX_Axis (myXAxis ())
    |> Chart.withY_Axis (myYAxis (yMin, yMax))
    |> Chart.withSize (750., 750.)
