﻿using System;

namespace SystemInfo
{
    class Program
    {
        private static readonly string System = "Informacje o systemie:"
            +"\nWersja sytemu: " + Environment.OSVersion
            +(Environment.Is64BitOperatingSystem ? ", 64 bitowy":"")
            +"\nWersja Microsoft .NET Framework: " + Environment.Version
            +"\nNazwa komputera: " + Environment.MachineName
            +"\nKatalog systemowy: " + Environment.SystemDirectory
            +"\nKatalog roboczy aplikacji: " + Environment.CurrentDirectory;

        //Informacje o bieżącym użytkowniku
        private static string user = "Informacje o bieżącym użytkowniku:"
            +"\nNazwa użytkownika: " + Environment.UserName
            +"\nKatalogi specjalne użytkownika:"
            +"\nkatalog 'Moje dokumnety' = " + Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            +"\nkatalog ''Pulpit' = " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            +"\nkatalog 'Moje obrazy' = " + Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            +"\nkatalog menu start = " + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)
            +"\nkatalog 'Programy' = " + Environment.GetFolderPath(Environment.SpecialFolder.Programs)
            +"\nkatalog 'Autostart' = " + Environment.GetFolderPath(Environment.SpecialFolder.Startup)
            +"\nkatalog domowy użytkownika = " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        static void Main(string[] args)
        {
            Console.WriteLine("SystemInfo\n---------\n");
            Console.WriteLine(System + "\n");
            Console.WriteLine(user + "\n");
        }

        
    }
}
