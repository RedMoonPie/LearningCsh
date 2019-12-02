using System;
namespace Delegadosencillo
{
    public class CPastel
    {
        public CPastel()
        {
        }
        // Este metgodo actuara como delegado
        public static void MostrarPastel(string pAnuncio)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--El pastel llevara el mensaje de {0}",pAnuncio );
        }
    }
}
