using System;
using System.Collections;

namespace CallBackk
{
    public class CRefri
    {
        private ArrayList listaSinks = new ArrayList();

        private int kilosAlimentos = 0;
        private int grados = 0;
        public CRefri(int pKilos, int pGrados)
        {
            kilosAlimentos = pKilos;
            grados = pGrados;
        }
        // con este methodo adicionamos un sink
        public void AgregarSink(IEventosRefri pSink)
        {
            if (pSink != null)
                listaSinks.Add(pSink);
        }
        public void EliminarSink(IEventosRefri pSink)
        {
            if (listaSinks.Contains(pSink))
                listaSinks.Remove(pSink);
        }
        public int Kilos { get { return kilosAlimentos; } set { kilosAlimentos = value; } }
        public int Grados { get { return grados; } set { grados = value; } }

        public void Trabajar(int pConsumo)
        {
            //actualizamos los kilos del refri
            kilosAlimentos -= pConsumo;
            //subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos ,{1} grados", kilosAlimentos, grados);
            if(kilosAlimentos < 10)
            {
               // invocamos a los handlers de cada sink
               foreach(IEventosRefri handler in listaSinks)
                {
                    handler.EReservasBajas(kilosAlimentos);
                }
            }

            // condicion para el evento de descongelado
            if(grados >=0)
            {
                foreach(IEventosRefri handler in listaSinks)
                {
                    handler.EDescongelado(grados);
                }
            }

        }
    }
}
