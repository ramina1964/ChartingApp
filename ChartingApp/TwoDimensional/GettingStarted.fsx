// This is an example of interactive plotting from a script file.
#r "nuget: Newtonsoft.JSON, 12.0.3"

// Loading packages FSharp.Plotly and XPlot.Plotly
#r "nuget: FSharp.Plotly, 1.2.2"
#r "nuget: XPlot.Plotly, 4.0.1"

open FSharp.Plotly
open XPlot.Plotly
open type System.Math


let xOscData = [-20. .. 0.02 .. 20.]
let oscPoints = [for x in xOscData -> x, (Sin x / x)]

// An oscillatory chart
let oscillatoryFunc =
        oscPoints
        |> Chart.Line

oscillatoryFunc.Show()

