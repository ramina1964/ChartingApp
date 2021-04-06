module MathFunctions

open System
open Utility


// Construct x-axis for 2D-plots 
let xMin = -Math.PI
let xMax = Math.PI
let inc = 0.04
let xData = [xMin .. inc .. xMax]
let xMinMax = (xMin, xMax)

// X-axis for oscillatory function
let xOscData = linspace2(-20., 20., 0.05)

// Construct y-axes of 2D-plots
let cosData = xData |> List.map Math.Cos
let sineData = xData |> List.map Math.Sin
let oscPoints xValues = [for x in xValues -> x, (Math.Sin(x) / x)]

// Construct x- and y-axes for 3D surface plots
let xMax3D = 5.
let xMin3D = -5.
let yMax3D = 5.
let yMin3D = -5.
let xAxis3D = linspace2(xMin3D, xMax3D, inc)
let yAxis3D = linspace2(yMin3D, yMax3D, inc)

// Given x-values, y-values and a function, return z-coordinates of the function
let zCoord func xValues yValues = 
    [ for x in xValues ->
        [ for y in yValues -> (func x y) ]]

// Some 3D surface functions
let HatSur x y = Math.Sin(Math.Sqrt(x ** 2. + y ** 2.))
let ConeSur x y = Math.Sqrt(x ** 2. + y ** 2.)
let ParaboloidSur x y = x ** 2. + y ** 2.
let HyperboloidSur (x: float) (y: float) = x ** 2. - y ** 2.

// Linearly spaced x-, and y-axes for RollerCoaster Function
let sizeRollerCoaster = 100
let incRollerCoaster = 0.1
let xRollerCoaster = linspace2(xMin3D, xMax3D, incRollerCoaster)
let yRollerCoaster = linspace2(-5., 5., incRollerCoaster)


// Apply zCoord Function to the surfaces above 
let zHat xValues yValues = zCoord HatSur xValues yValues
let zCone xValues yValues = zCoord ConeSur xValues yValues
let zParaboloid xValues yValues = zCoord ParaboloidSur xValues yValues
let zHyperboloid xValues yValues = zCoord HyperboloidSur xValues yValues
