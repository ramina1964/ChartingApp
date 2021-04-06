open FSharp.Plotly
open Utility

// 2D-Charts
open GetttingStarted
open ScatterPlot
open CheckingPlotly
open PolarPlot
open CombinedPlot
open CheckingPlotly

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
    //cosPlotStyled |> Chart.Show
    //sinePlotStyled |> Chart.Show
    //mirroredSinChart |> Chart.Show
    //combinedSinCos |> Chart.Show
    //stackedSinCos |> Chart.Show
    //mirroredOscExpChart |> Chart.Show

    // Three-Dimensional Curve plot
    helix |> Chart.Show
    random3dChart.Show()
    
    // Three-Dimensional Surface and Mesh plot
    rollerCoaster.Show()
    hat.Show()
    cone.Show()
    paraboloid.Show()
    hyperboloid.Show()

    0
