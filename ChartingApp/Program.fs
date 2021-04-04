// Learn more about F# at http://fsharp.org

open FSharp.Plotly
open Utility
open GetttingStarted
open SurfacePlotTemplate
open SurfacePlot
open ScatterPlot
open PolarPlot
open LinePlot3D

[<EntryPoint>]
let main argv =

    // Basic Two Dimensional plot
    //oscillatoryFunc.Show()
    //scatterPlot.Show()
    //spline |> Chart.Show
    //splineWithMoreControl |> Chart.Show

    //polarChart.Show()

    // 3D-Line Plots
    helix |> Chart.Show

    // Surface Plots from SurfacePlotTemplate and SurfacePlots 
    //random3dChart.Show()
    //rollerCoaster.Show()
    //hat.Show()
    //cone.Show()
    //paraboloid.Show()
    //hyperboloid.Show()



    0
