using System;
namespace ClonableC
{
    public class CAuto:IAutomovil, ICloneable
    {

        private double costo;
        private  double tenencia;
        private string modelo;

        public CAuto(string pModelo, double pCosto)
            {
                costo = pCosto;
                modelo = pModelo;

            }
            
        public double Costo
        {
            set { costo = value; }
            get { return costo; }
        }
        public double Tenencia
        {
            set { tenencia = value; }
            get { return tenencia; }
        }
        //metsodos interfaz

        public void CalculaTenencia(double pImpuesto)
            {
                tenencia = 5000.0 + costo * pImpuesto;
            }
        public void MuestraInformacion()
            {
                Console.WriteLine("Tu Automovil {0}", modelo);
                Console.WriteLine("Costo {0}. con una tenencia de {1}", costo, tenencia);
                Console.WriteLine("TOtal {0}", costo + tenencia);
                Console.WriteLine("-----------");
            }
        //methods Icloneable
        public object Clone()
        { 
            CAuto temp = new CAuto(modelo, costo);
            temp.Tenencia = tenencia;

            return temp;
        }
    }
    }

