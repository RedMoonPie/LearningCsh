using System;
namespace Delega2
{
    public class CAlmuerzo
    {
        public static void ServirAlmuerzo(string pNombre)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Almuerzo servido a {0} ", pNombre);
        }
    }
}
