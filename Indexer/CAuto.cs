using System;
namespace Indexer
{
    public class CAuto
    {
        double costo;
        string modelo;

        public CAuto(string pModelo, double pCosto)
        {
            //Inicializamos daots
            costo = pCosto;
            modelo = pModelo;
        }
        public void MuestraInformacion()
        {
            //mostamos la informacion necesaria 
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("-----------");
        }
    }
}
