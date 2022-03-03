#load "YahooFinance.fsx"

open YahooFinance

let twnk = YahooFinance.PriceHistory("TWNK")

twnk
|> List.take 3 // PriceObs list

#r "nuget:Plotly.NET ,2.0.0-preview.17"

open Plotly.NET

twnk
|> List.map (fun day -> day.Date, day.AdjustedClose)
|> Chart.Line
|> GenericChart.toChartHTML

(***include-it-raw***)

(***include-it***)