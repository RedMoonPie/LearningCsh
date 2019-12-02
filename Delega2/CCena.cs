using System;
namespace Delega2
{
    public class CCena
    {
        public static void ServirCena(string pNombre)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("cena servido a {0} ", pNombre);
        }
    }
}
