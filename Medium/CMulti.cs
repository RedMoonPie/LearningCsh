using System;
namespace Medium
{
    public class CMulti: IOperacion
    {
        double r = 0.0;
        
        public  void Calcular(double a, double b)
        {
            r = a * b;
        }
        public  void Mostrar()
        {
            Console.WriteLine("EL resultado de la Mult es {0}", r);

        }

    }
}
