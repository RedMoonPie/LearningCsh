using System;
namespace IEnumerable_Enumerator
{
    public class CAuto:IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;
        public CAuto(string pModelo,double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;

        }
        //metsodos interfaz

        public void CalcularTenencia(double pImpuesto)
        {
            tenencia = 5000.0 + costo * pImpuesto;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}. con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("TOtal {0}", costo+tenencia);
            Console.WriteLine("-----------");
        }
    }
}
