module PolarPlot

open XPlot.Plotly
open PolarPoints


let lineTrace1 =
    Scatter(
        r = r1,
        t = t1,
        mode = "lines",
        name = "Figure8",
        marker = Marker(color = "none", line = Line(color = "peru"))
    )

let lineTrace2 =
    Scatter(
        r = r2,
        t = t2,
        mode = "lines",
        name = "Cardioid",
        marker = Marker(color = "none", line = Line(color = "darkviolet"))
    )

let lineTrace3 =
    Scatter(
        r = r3,
        t = t3,
        mode = "lines",
        name = "Hypercardioid",
        marker = Marker(color = "none", line = Line(color = "deepskyblue"))
    )

let lineTrace4 =
    Scatter(
        r = r4,
        t = t4,
        mode = "lines",
        name = "Subcardioid",
        marker = Marker(color = "none", line = Line(color = "orangered"))
    )

let lineTrace5 =
    Scatter(
        r = r5,
        t = t5,
        mode = "lines",
        name = "Supercardioid",
        marker = Marker(color = "none", line = Line(color = "green"))
    )

let layout =
    Layout(
        title = "Mic Patterns",
        font = Font(family = "Arial, sans-serif", size = 12., color = "#000"),
        showlegend = true,
        width = 500.,
        height = 400.,
        margin = Margin(l = 65., r = 50., b = 65., t = 90.),
        paper_bgcolor = "rgb(220, 220, 220)",
        plot_bgcolor = "rgb(255, 255, 255)",
        orientation = -90.
    )

let polarChart =
    [ lineTrace1
      lineTrace2
      lineTrace3
      lineTrace4
      lineTrace5 ]
    |> Chart.Plot
    |> Chart.WithLayout layout
    |> Chart.WithWidth 1400
    |> Chart.WithHeight 1000
