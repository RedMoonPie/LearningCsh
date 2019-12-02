using System;
using System.Collections;

namespace Medium
{
    public class CSuma:IOperacion
    {
        private double r = 0;
        public CSuma()
        {
        }
        // metosdos implementados
        public  void Calcular(double a , double b)
        {
            r = a + b;
        }
        public  void Mostrar()
        {
            Console.WriteLine("EL resultado de la suma es {0}", r);
            resultados.Add(r);

        }
        // metosdos propios de la clase

    }
}
