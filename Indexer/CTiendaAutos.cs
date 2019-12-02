using System;
namespace Indexer
{
    public class CTiendaAutos
    {
        private CAuto[] disponibles;
        public CTiendaAutos()
        {
            disponibles = new CAuto[4];

            disponibles[0] = new CAuto("soul", 220000.50);
            disponibles[1] = new CAuto("sedan", 2312132.70);
            disponibles[2] = new CAuto("Logan", 339339.80);
            disponibles[3] = new CAuto("Masserati", 9999292.30);
        }
        // aqui creamos el indexer
        //el this es para usar directamente 
        public CAuto this[int indice]
        {
            //usamos un get pata obtener el elemento ense indice
            get { return disponibles[indice]; }
            //usamos set para colocar un elemento en ese indice 
            set { disponibles[indice] = value; }
        }
    }
}
