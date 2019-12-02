using System;
namespace SerializacionXml
{
    //con esto indicamos que la clase que estamos definiendo acontinuacion es una clase serializable
    // si queremos clases serializables debemos ponerlos 
    [Serializable]
    public class CAuto
    {
        private double costo;
        private string modelo;

        public double Costo { get { return costo; } set { costo = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public CAuto()
        {
            costo = 100000;
            modelo = "volvo";

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
