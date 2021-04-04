
open FSharp.Plotly
open Utility
open GetttingStarted
open ScatterPlot
open PolarPlot
open LinePlot3D
open SurfacePlotTemplate
open SurfacePlot

[<EntryPoint>]
let main argv =

    // Two-Dimensional plot
    //oscillatoryFunc.Show()
    //scatterPlot.Show()
    //spline |> Chart.Show
    //splineWithMoreControl |> Chart.Show
    //polarChart.Show()

    // 3D-Dimensional Curve plot
    helix |> Chart.Show
    //random3dChart.Show()
    
    // 3D-Dimensional Surface and Mesh plot
    //rollerCoaster.Show()
    //hat.Show()
    //cone.Show()
    //paraboloid.Show()
    //hyperboloid.Show()

    0
