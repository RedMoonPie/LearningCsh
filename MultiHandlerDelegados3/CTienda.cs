using System;
namespace MultiHandlerDelegados3
{
    public class CTienda
    {
       public static void MandaViveres(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vmamos a mandar sus viveres, estoy en tienda");
            Console.WriteLine("Seran {0} kilos", pKilos);
        }
    }
}
