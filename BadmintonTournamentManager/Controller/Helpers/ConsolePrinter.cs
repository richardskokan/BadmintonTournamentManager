using System.Runtime.InteropServices;

namespace BadmintonTournamentManager.Controller.Helpers
{
    public static class ConsolePrinter
    {
        public static void PrintToConsole(string text)
        {
            AllocConsole();


            Console.WriteLine(text);
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
