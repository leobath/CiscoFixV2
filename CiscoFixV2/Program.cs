using System.Diagnostics;


class Program
{
    static void Main()
    {
        string powerShellCommand = "Get-NetAdapter -InterfaceDescription \"Cisco*\" | Set-NetIPInterface -InterfaceMetric 50";

        // Create a new ProcessStartInfo
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "powershell.exe",
            Verb = "runas",  // Run as administrator
            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{powerShellCommand}\"",
            UseShellExecute = true
        };

        try
        {
            Process process = new Process { StartInfo = psi };
            process.Start(); //
                             // process.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");          

        }
    }
}