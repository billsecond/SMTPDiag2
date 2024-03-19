using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SMTPDiag2.Helpers
{
    public class BrowserOpener
    {
        public static void OpenUrl(string url)
        {
            try
            {
                // Windows
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                // Linux
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                // MacOS
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
            }
            catch (Exception ex)
            {
                // Handle errors (if any)
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

}
