using System;
namespace SeriallizacionBinaria
{
    //con esto indicamos que la clase que estamos definiendo acontinuacion es una clase serializable
    // si queremos clases serializables debemos ponerlos 
    [Serializable]
    class CAuto
    {
        private double costo;
        private string modelo;

        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;

        }
        public void MuestraInformacion()
        {
            // Mostramos la informacion necesaria 
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("-----------");
        }
    }
}
