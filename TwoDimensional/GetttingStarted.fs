module GetttingStarted

open XPlot.Plotly
open MathFunctions


// A Line Chart
let layout =
      Layout(title = "A Demping Oscillatory Function",
             showlegend = false,
             plot_bgcolor = "rgb(220, 220, 220")

let oscillatoryFunc =
        (oscPoints xOscData)
        |> Chart.Line
        |> Chart.WithWidth 900
        |> Chart.WithHeight 500
        |> Chart.WithLayout layout
        |> Chart.WithXTitle "x"
        |> Chart.WithYTitle "y"
