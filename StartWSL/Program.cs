using System.Diagnostics;

var p = Process.Start("wsl.exe");
Process.Start("wsl.exe", "-- ps aux");
p.WaitForExit();