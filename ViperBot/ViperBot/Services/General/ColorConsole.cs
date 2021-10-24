using System;

namespace ViperBot.Services.General
{
    class ColorConsole
    {
        public static void ColorWrite(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("VIPER");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("] " + message + "\n");
        }
    }
}
