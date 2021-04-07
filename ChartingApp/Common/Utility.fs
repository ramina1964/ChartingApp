module Utility


// Given min, max and an int no > 2, return an array of floating point numbers of size noOfPts
// between min and max, inclusively.
let linspace (min, max, n) = 
    if max <= min then failwithf "Following condition must be satisfied: max > min"
    if n <= 2 then failwithf "Following condition must be satisfied: n > 2"
    let inc = float (max - min) / (float n - 1.)
    Array.init n (fun i -> min + (inc * float i))

// Given int = [min, max] and an increment inc, return an array of floating point numbers in the given interval,
// where all distances between elements are equal to inc. = 
let linspace2 (min, max, inc) = 
    if max <= min then failwithf "Following condition must be satisfied: max > min"
    if inc <= 0. then failwithf "Following condition must be satisfied: inc > 0.0"
    let n = int ((max - min) / inc + 1.)
    Array.init n (fun i -> min + inc * float (i))

// Given a floating point number, round it to one decimal place. 
let roundFunc number = sprintf "%.1f" number
