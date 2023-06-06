// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let p = new Microsoft.Data.SqlClient.SqlParameter("@p1", new System.DateOnly(1977,1,1))

printfn $"{p.DbType}"
printfn $"{p.SqlDbType}"