using System;
namespace Delegadosencillo
{
    public class CRadio
    {
        public CRadio()
        {
        }
        public static void MetodoRadio(string pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--CLase radio");
            Console.WriteLine("tu mensaje{0}", pMensaje); 
        }
    }
}
