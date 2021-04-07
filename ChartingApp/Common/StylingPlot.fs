module StylingPlot

open FSharp.Plotly
open XPlot.Plotly


// Mirrored x-axis
let AxisX (xMin, xMax) =
    Axis.LinearAxis.init (
        Title = "x-Axis",
        Showgrid = true,
        Showline = true,
        Mirror = StyleParam.Mirror.AllTicks,
        Range = StyleParam.Range.MinMax(xMin, xMax),
        Tickmode = StyleParam.TickMode.Array,
        Ticks = StyleParam.TickOptions.Inside
    )

let AxisY (yMin, yMax) =
    Axis.LinearAxis.init (
        Title = "y-Axis",
        Showgrid = true,
        Showline = true,
        Mirror = StyleParam.Mirror.AllTicks,
        Range = StyleParam.Range.MinMax(yMin, yMax),
        Tickmode = StyleParam.TickMode.Auto,
        Ticks = StyleParam.TickOptions.Inside
    )

let layout plotTitle =
    Layout(
        autosize = false,
        margin = Margin(l = 65., r = 50., b = 65., t = 90.),
        title = plotTitle)
