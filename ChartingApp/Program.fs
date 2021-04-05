
open FSharp.Plotly
open Utility

// 2D-Charts
open GetttingStarted
open ScatterPlot
open PolarPlot
open MultiplePlots

// 3D-Charts
open LinePlot3D
open SurfacePlotTemplate
open SurfacePlot

[<EntryPoint>]
let main argv =

    // Two-Dimensional Plot
    //oscillatoryFunc.Show()
    //scatterPlot.Show()
    //spline |> Chart.Show
    //splineWithMoreControl |> Chart.Show
    //polarChart.Show()
    combinedChart |> Chart.Show

    // Three-Dimensional Curve plot
    //helix |> Chart.Show
    //random3dChart.Show()
    
    // Three-Dimensional Surface and Mesh plot
    //rollerCoaster.Show()
    //hat.Show()
    //cone.Show()
    //paraboloid.Show()
    //hyperboloid.Show()

    0
