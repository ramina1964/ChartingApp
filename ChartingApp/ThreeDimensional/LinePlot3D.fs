module LinePlot3D

open FSharp.Plotly
open System


let c = [0. .. 0.25 .. 15.]

let x, y, z =
    c
    |> List.map
        (fun i ->
            let i' = float i
            let r = 10. * Math.Cos(i' / 10.)
            (r * Math.Cos i', r * Math.Sin i', i'))
    |> List.unzip3

let helix =
    Chart.Scatter3d(x, y, z, StyleParam.Mode.Lines_Markers)
    |> Chart.withTitle("Helix")
    |> Chart.withX_AxisStyle ("x-axis", Showgrid = true)
    |> Chart.withY_AxisStyle ("y-axis", Showline = true)
    |> Chart.withZ_AxisStyle ("z-axis", Showline = true)
    |> Chart.withSize (800., 800.)


