using System.Diagnostics;

var p = Process.Start(new ProcessStartInfo() { FileName = "wsl.exe", RedirectStandardInput = true});

var si = p.StandardInput;
si.NewLine = "\n";

String? line = null;
while ( (line = Console.ReadLine() ) != null )
{
    si.WriteLine(line);
}