using System;
namespace Archivos
{   
    class CAuto
    {
        private double costo;
        private string modelo;

        public double Costo { get { return costo; } set { costo = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }
        public void MuestraInformacion()
        {
            Console.WriteLine("u Automovil {0}", modelo);
            Console.WriteLine("Costo{0}", costo);
        }
    }
   
}
