module CheckingPlotly

open System
open FSharp.Plotly
open FSharp.Plotly.Colors

// Point Plot
let xMin = -2. * Math.PI
let xMax = 2. * Math.PI
let steplength = 0.04
let xData = [ xMin .. steplength .. xMax ]
let yData = xData |> List.map Math.Cos
let cosPlot = Chart.Point(xData, yData)
let xMinMax = (xMin, xMax)

let cosPlotStyled =
    Chart.Point(
        xData,
        yData,
        MarkerSymbol = StyleParam.Symbol.Square,
        Color = (Table.Office.lightGreen |> toWebColor),
        TextFont = Font.init (StyleParam.FontFamily.Droid_Sans_Mono)
    )

// A more functional style
let sinChartStyled =
    Chart.Point(xData, yData)
    |> Chart.withMarkerStyle (Size = 3, Color = (Table.Office.red |> toWebColor), Symbol = StyleParam.Symbol.Diamond)
    |> Chart.withTitle ("sin(x)")
    |> Chart.withX_AxisStyle ("x", Showline = true, Showgrid = true, MinMax = xMinMax)
    |> Chart.withY_AxisStyle ("y", Showline = true, Showgrid = true)

// Constructing mirror axis
let myXAxis () =
    Axis.LinearAxis.init (
        Title = "x",
        Showgrid = true,
        Showline = true,
        Mirror = StyleParam.Mirror.All,
        Range = StyleParam.Range.MinMax(xMinMax),
        Tickmode = StyleParam.TickMode.Array,
        Tickvals = ([| xMin .. (0.5 * System.Math.PI) .. xMax |] |> Array.map (Math.Truncate)),
        Ticks = StyleParam.TickOptions.Inside
    )

let myYAxis () =
    Axis.LinearAxis.init (
        Title = "y",
        Showgrid = true,
        Showline = true,
        Mirror = StyleParam.Mirror.AllTicks,
        Range = StyleParam.Range.MinMax(-1., 1.),
        Tickmode = StyleParam.TickMode.Auto,
        Ticks = StyleParam.TickOptions.Inside
    )

let mirroredSinChart =
    Chart.Point(xData, yData)
    |> Chart.withMarkerStyle (
        Size = 3,
        Color = (Table.Office.darkGreen |> toWebColor),
        Symbol = StyleParam.Symbol.Square
    )
    |> Chart.withTitle ("sin(x)")
    |> Chart.withX_Axis (myXAxis ())
    |> Chart.withY_Axis (myYAxis ())
    |> Chart.withSize (750., 750.)
