namespace Chart

module PolarPlot =

    open XPlot.Plotly
    open PlotService


    let lineTrace1 =
        Scatter(
            r = plotservice.GetData "r1",
            t = plotservice.GetData "t1",
            mode = "lines",
            name = "Figure8",
            marker = Marker(color = "none", line = Line(color = "peru"))
        )

    let lineTrace2 =
        Scatter(
            r = plotservice.GetData "r2",
            t = plotservice.GetData "t2",
            mode = "lines",
            name = "Cardioid",
            marker = Marker(color = "none", line = Line(color = "darkviolet"))
        )

    let lineTrace3 =
        Scatter(
            r = plotservice.GetData "r3",
            t = plotservice.GetData "t3",
            mode = "lines",
            name = "Hypercardioid",
            marker = Marker(color = "none", line = Line(color = "deepskyblue"))
        )

    let lineTrace4 =
        Scatter(
            r = plotservice.GetData "r4",
            t = plotservice.GetData "t4",
            mode = "lines",
            name = "Subcardioid",
            marker = Marker(color = "none", line = Line(color = "orangered"))
        )

    let lineTrace5 =
        Scatter(
           r = plotservice.GetData "r5",
           t = plotservice.GetData "t5",
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

