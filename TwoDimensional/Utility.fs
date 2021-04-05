module Utility


// A list of n floating point numbers between min and max, inclusively
let linspace (min, max, n) = 
    if n <= 2 then failwithf "n needs to be larger then 2"
    let inc = float (max - min) / (float n - 1.)
    Array.init n (fun i -> min + (inc * float i))

// Given x-values, y-values and a function, return z-coordinates of the function
let zCoord func xValues yValues = 
    [ for x in xValues ->
        [ for y in yValues -> (func x y) ]]
