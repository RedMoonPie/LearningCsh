using System;
namespace Medium
{
    public class CDiv:IOperacion
    {
        double r = 0.0;
        public  void Calcular(double a, double b)
        {
            r = a - b;
        }
        public  void Mostrar()
        {
            Console.WriteLine("EL resultado de la resta es {0}", r);
        }

    }
}
