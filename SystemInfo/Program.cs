using System;

namespace SystemInfo
{
    class Program
    {
        private static string system = "Informacje o systemie:"
            +"\nWersja sytemu: " + Environment.OSVersion
            +(Environment.Is64BitOperatingSystem ? ", 64 bitowy":"")
            +"\nWersja Microsoft .NET Framework: " + Environment.Version
            +"\nNazwa komputera: " + Environment.MachineName
            +"\nKatalog systemowy: " + Environment.SystemDirectory
            +"\nKatalog roboczy aplikacji: " + Environment.CurrentDirectory;

        static void Main(string[] args)
        {
            Console.WriteLine("SystemInfo\n---------\n");
            Console.WriteLine(system + "\n");
        }

        
    }
}
