module MyLibrary

open Serilog
open Serilog.Sinks.RollingFile

let logger = LoggerConfiguration().WriteTo.RollingFile("Logs/log-{Date}.txt").CreateLogger();

type MyLibrary() = 
    member this.X = 
        logger.Information("calling MyLibrary.X")
        "F#"
