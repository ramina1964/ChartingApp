module StylingAxes

open System
open FSharp.Plotly


// Construct x- and y-axes
let xMin = -Math.PI
let xMax = Math.PI
let steplength = 0.04
let xData = [xMin .. steplength .. xMax]
let xMinMax = (xMin, xMax)

// Given a floating point number, round it to one decimal place
let roundFunc number = sprintf "%.1f" number

let myXAxis () =
    Axis.LinearAxis.init (
        Title = "x",
        Showgrid = true,
        Showline = true,
        Mirror = StyleParam.Mirror.AllTicks,
        Range = StyleParam.Range.MinMax(xMinMax),
        Tickmode = StyleParam.TickMode.Array,
        Tickvals = ([xMin .. (0.5 * System.Math.PI) .. xMax] |> (List.map roundFunc)),
        Ticks = StyleParam.TickOptions.Inside
    )

let myYAxis (yMin, yMax) =
    Axis.LinearAxis.init (
        Title = "y",
        Showgrid = true,
        Showline = true,
        Mirror = StyleParam.Mirror.AllTicks,
        Range = StyleParam.Range.MinMax(yMin, yMax),
        Tickmode = StyleParam.TickMode.Auto,
        Ticks = StyleParam.TickOptions.Inside
    )
