using System;

namespace Indexer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = 0;

            //Creamos la Tienda 
            CTiendaAutos miTienda = new CTiendaAutos();
            //obtenemos un auto

            CAuto miAuto = miTienda[1];
            miAuto.MuestraInformacion();

            //colacamos un auto 
            CAuto otroAuto = new CAuto("volvo", 85000);
            miTienda[1] = otroAuto;

            //imprimimos la tienda

            for (n = 0; n < 4; n++)
                miTienda[n].MuestraInformacion();
        }
    }
}
