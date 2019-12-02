using System;

namespace DelegadoRefri
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creamos el refri

            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            //adicionamos handlers referencia a delegado 
            miRefri.AdicionaMetodoReservas(new CRefri.DReservasBajas(InformeKilos));
            miRefri.AdicionaMetodoDescongelado(new CRefri.DDescongelado(InformeGrados));

            //refri trabaja

            while(miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1, 5));
            }
        }
        //al tener el mismo tipo que DReservasBajas se delega y Dreservasbajas ejecuta el codigo de informe kilos
        //en su lugar
        public static void InformeKilos(int pkilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--Reservas bajas de alimentos , estoy a nivel de main");
            Console.WriteLine("quedan {0} kilos",pkilos);

        }
        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--Grados , estoy a nivel de main");
            Console.WriteLine("quedan {0} grados", pGrados);
        }
    }
}
