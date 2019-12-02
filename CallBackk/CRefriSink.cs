using System;
namespace CallBackk
{
    public class CRefriSink: IEventosRefri
    {
        private bool paro = false;
        public bool Paro { get { return paro; } }
        //esta es la clase sink
        //aqui colocamos los handlers de los eventos definidos en la interfaz
        public void EReservasBajas(int pKilos)
        {
            //aqui se coloca toddo el codigo necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--REservas bajas de alimentos");
            Console.WriteLine("Quedan {0} kilos", pKilos);
        }
        public void EDescongelado(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--Descongelando");
            if (pGrados > 0)
                paro = true;
        }
    }
}
