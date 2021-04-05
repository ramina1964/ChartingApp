module SurfacePlotTemplate

// Include the following load instructions in a Script File
//#r "../../bin/XPlot.Plotly/netstandard2.0/XPlot.Plotly.dll"
//#r "../../packages/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"

(*** condition: ipynb ***)
#if IPYNB
#i "nuget:https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet5/nuget/v3/index.json"
#i "nuget:https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-tools/nuget/v3/index.json"
#r "nuget: XPlot.Plotly"
#r "nuget: XPlot.Plotly.Interactive"
#endif // IPYNB

(**
Plotly 3D Surface Plots
[![Binder](https://mybinder.org/badge_logo.svg)]
    (https://mybinder.org/v2/gh/fslaborg/XPlot/gh-pages?filepath=plotly-3d-surface-plots.ipynb)
Topographical 3D Surface Plot
-----------------------------
*)
open System
open XPlot.Plotly
open Utility

let z =
    let rnd = Random()
    [ for _ in 1 .. 25 ->
        [ for _ in 1 .. 25 ->
            rnd.Next(0, 400) ]]

let layout =
    Layout(
        autosize = false,
        margin =
            Margin(
                l = 65.,
                r = 50.,
                b = 65.,
                t = 90.))

let random3dChart =
    Surface(z = z)
    |> Chart.Plot
    |> Chart.WithLayout layout
    |> Chart.WithWidth 700
    |> Chart.WithHeight 500
(*** condition: ipynb ***)
#if IPYNB
chart
#endif // IPYNB

//---------------------- Generate Linearly Spaced Vector ----------------------
let size = 100
let x = linspace(-5., 5., size)
let y = linspace(-5., 5., size)

let RollerCoasterSur x y = - (5. * x / (x**2. + y**2. + 1. ))

let zRollerCoaster = 
    Array.init size (fun i -> 
        Array.init size (fun j -> RollerCoasterSur x.[j] y.[i] ))

let rollerCoaster = 
    Surface(z = zRollerCoaster)
    |> Chart.Plot

