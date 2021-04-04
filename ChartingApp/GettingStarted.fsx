// This is an example of interactive plotting from a script file.
//#r "nuget: Newtonsoft.JSON, 13.0.1"

// Path of XPlot.Plotly.dll relative to the solution file
#r "../ChartingApp/bin/Debug/net5.0/XPlot.Plotly.dll"

(*** condition: ipynb ***)
#if IPYNB
#r "nuget: Plotly.NET, {{fsdocs-package-version}}"
#r "nuget: Plotly.NET.Interactive, {{fsdocs-package-version}}"
#endif // IPYNB

open System
open XPlot.Plotly

let xData = [-20. .. 0.02 .. 20.]

let oscFunc x =
    System.Math.Sin(x) / x
let oscPoints = [for x in xData -> x, (oscFunc x)]

// A line chart
let oscillatoryFunc =
        oscPoints
        |> Chart.Line

oscillatoryFunc.Show()
