module CheckingPlotly

open System
open FSharp.Plotly
open XPlot.Plotly
open Microsoft.Data.Analysis

//let data = DataFrame.LoadCsv("./bank.csv", separator = ';')

let xData = [ 0. .. 0.01 .. 2. * Math.PI]
let yData = xData |> List.map System.Math.Cos
let cosPlot = Chart.Line xData, yData
