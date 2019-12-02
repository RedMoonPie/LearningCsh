using System;
namespace Medium
{
    public class CResta: IOperacion
    {
        double r = 0.0;
        public CResta()
        {
        }
        public  void Calcular(double a, double b)
        {
           r =  a - b;
        }
        public  void Mostrar()
        {
        }

    }
}
