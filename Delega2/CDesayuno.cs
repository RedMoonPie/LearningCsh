using System;
namespace Delega2
{
    public class CDesayuno
    {
        public static void ServirDesayuno(string pNombre)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Desayuno servido a {0} " , pNombre);
        }
    }
}
