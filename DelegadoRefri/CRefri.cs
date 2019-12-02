using System;
namespace DelegadoRefri
{
    public class CRefri
    {
        //delegados a manera de ejemplo publicos dentro de clase no se deben tener publicos  
        public delegate void DReservasBajas(int pKilos);
        public delegate void DDescongelado(int pGrados);

        private int kilosAlimentos = 0;
        private int grados = 0;

        //variasbles que se usaran para invocar
        private DReservasBajas delReservas;
        private DDescongelado delDEscongelado;

        public CRefri(int pKilos, int pGrados)
        {
            //Coloca los valores iniciales del refri

            kilosAlimentos = pKilos;
            grados = pGrados;
        }
        //permiten referenciar las variables 

        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas = pMetodo;
        }
        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDEscongelado = pMetodo;
        }
        //propiedades

        public int Kilos { get { return kilosAlimentos; } }
        public int Grados { get { return grados; } }

        public void Trabajar(int pConsumo)
        {
            kilosAlimentos -= pConsumo;

            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--kilos{0},{1} grados",kilosAlimentos,grados);

            //hay que verificar si se cumple la condicion para invocar los handlers del evento

            //esta es la condicion del evento para kilos
            if(kilosAlimentos < 10)
            {
                //invocamos metodos
                delReservas(kilosAlimentos);
            }
            //condicion evento temperatura
            if (grados > 0)
             {
                delDEscongelado(grados);

            }
             



        }
    }
}
