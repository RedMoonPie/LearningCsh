using System;

namespace IEnumerable_Enumerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CTIendaAutos tienda = new CTIendaAutos();

            foreach(CAuto miAuto in tienda)
            {
                miAuto.CalcularTenencia(0.05);
                miAuto.MuestraInformacion();
            }
        }
    }
}
