// Learn more about F# at http://fsharp.org

open System
open Utility
open GetttingStarted
open SurfacePlotTemplate
open SurfacePlots
open ScatterPlot
open PolarPlot

[<EntryPoint>]
let main argv =

    // Basic Two Dimensional plot
    oscillatoryFunc.Show()
    scatterPlot.Show()
    polarChart.Show()

    // Surface Plots from SurfacePlotTemplate and SurfacePlots 
    //random3dChart.Show()
    //rollerCoaster.Show()
    //hat.Show()
    //cone.Show()
    //paraboloid.Show()
    //hyperboloid.Show()

    0
