module Utility


// A list of n floating point numbers between min and max, inclusively
let linspace (min, max, n) = 
    if n <= 2 then failwithf "n needs to be larger then 2"
    let inc = float (max - min) / (float n - 1.)
    Array.init n (fun i -> min + (inc * float i))

// Given a floating point number, round it to one decimal place. 
let roundedFunc number = sprintf "%.1f" number

