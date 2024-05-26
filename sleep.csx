#r "System.Runtime"

using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("PowrProf.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

    static void Main(string[] args)
    {
        try
        {
            bool hibernate = false;
            bool forceCritical = true;
            bool disableWakeEvent = false;
            
            if (SetSuspendState(hibernate, forceCritical, disableWakeEvent))
            {
                Console.WriteLine("The system is going to sleep.");
            }
            else
            {
                Console.WriteLine("Failed to put the system to sleep.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

Program.Main(null);
