module StylingAxes

open FSharp.Plotly
open Utility
open MathFunctions


let myXAxis () =
    Axis.LinearAxis.init (
        Title = "x-Axis",
        Showgrid = true,
        Showline = true,
        Mirror = StyleParam.Mirror.AllTicks,
        Range = StyleParam.Range.MinMax(xMinMax),
        Tickmode = StyleParam.TickMode.Array,
        Tickvals = ([xMin .. (0.5 * System.Math.PI) .. xMax] |> (List.map roundedFunc)),
        Ticks = StyleParam.TickOptions.Inside
    )

let myYAxis (yMin, yMax) =
    Axis.LinearAxis.init (
        Title = "y-Axis",
        Showgrid = true,
        Showline = true,
        Mirror = StyleParam.Mirror.AllTicks,
        Range = StyleParam.Range.MinMax(yMin, yMax),
        Tickmode = StyleParam.TickMode.Auto,
        Ticks = StyleParam.TickOptions.Inside
    )
