using System;

namespace MultiHandlerDelegados3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creamos el refri

            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            //variables para el multicasting necesitamos la instancia para poder adicionar o eliminar
            DReservasBajas kilos1 = new DReservasBajas(InformeKilos);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);

            DDescongelado desc1 = new DDescongelado(InformeGrados);

            //adiciona handlers
            miRefri.AdicionaMetodoReservas(kilos1);
            miRefri.AdicionaMetodoReservas(kilos2);

            miRefri.AdicionaMetodoDEscongelado(desc1);

            //refri trabaja

            while(miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1, 5));
            }
            //eliminamos un handler
            miRefri.EliminaMetodoReservas(kilos2);

            miRefri.Kilos = 50;
            miRefri.Grados = -15;

            while (miRefri.Kilos > 0)
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
