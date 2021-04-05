module MultiplePlots

open XPlot.GoogleCharts
open XPlot.Plotly
open FSharp.Plotly


let x = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
let y = [2.; 1.5; 5.; 1.5; 3.; 2.5; 2.5; 1.5; 3.5; 1.]

let combinedChart = 
    [
        Chart.Line(x, y, Name="Fst")
        Chart.Line(y, x, Name="Snd")
    ]
    |> Chart.Combine

// Chart subplot grids
//simple 3x3 subplot grid
//let grid = 
//    Chart.Grid(
//        [
//            [Chart.Line(x, y); Chart.Line(x, y); Chart.Line(x, y)]
//            [Chart.Point(x, y); Chart.Point(x, y); Chart.Point(x, y)]
//            [Chart.Spline(x, y); Chart.Spline(x, y); Chart.Spline(x, y)]
//        ]
//    )

//let singleStack =
//    [
//        Chart.Point(x,y) 
//        |> Chart.withY_AxisStyle("This title must")

//        Chart.Line(x,y) 
//        |> Chart.withY_AxisStyle("be set on the",Zeroline=false)
        
//        Chart.Spline(x,y) 
//        |> Chart.withY_AxisStyle("respective subplots",Zeroline=false)
//    ]
//    |> Chart.SingleStack
//    //move xAxis to bottom and increase spacing between plots by using the withLayoutGridStyle function
//    |> Chart.withLayoutGridStyle(XSide=StyleParam.LayoutGridXSide.Bottom,YGap= 0.1)
//    |> Chart.withTitle("Hi i am the new SingleStackChart")
//    |> Chart.withX_AxisStyle("im the shared xAxis")