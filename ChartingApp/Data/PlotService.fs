namespace Chart

open System.Collections.Generic
open System.IO
open System

module PlotService =

    let parseData (content : string) =        
        let data = content.Split('\t')
        data |> Array.mapi (fun idx el ->  idx, float el)

    type PlotDataLookupService =
        abstract GetData : string -> float array
    
    let buildPlotService (content : string array) =
        let header = (content |> Seq.head).Split('\t')
        let data = 
            content
            |> Array.skip 1
            |> Array.map parseData

        let datapoints =
            let dict = new Dictionary<string, ResizeArray<float>>()
            for name in header do
                dict.Add(name, ResizeArray<float>())
            for row in data do
                for ( idx, point) in row do
                    let list = dict.[header.[idx]]
                    list.Add point
            dict
        { new PlotDataLookupService with
            member _.GetData key = datapoints.[key.ToUpper()] |> Seq.toArray }
    

    let currentDir = Environment.CurrentDirectory
    let fileDir = DirectoryInfo(currentDir).Parent.Parent.Parent.FullName
    let path = Path.Combine(fileDir,"Data","PolarPoints.txt")
    let content = File.ReadAllLines(path)
    let plotservice = buildPlotService content


