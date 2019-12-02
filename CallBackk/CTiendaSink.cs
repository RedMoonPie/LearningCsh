using System;
namespace CallBackk
{
    public class CTiendaSink:IEventosRefri
    {
        public CTiendaSink()
        {
        } 
        public void EReservasBajas(int pkilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--Le enviaremos sus viveres");
            Console.WriteLine("--> seran {0} kilos", pkilos);
        }
        public void EDescongelado(int pGrados)
        {
            //nothing, no se recomienda tener metdos vacios 
        }
    }
}
