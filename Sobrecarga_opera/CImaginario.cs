using System;
namespace Sobrecarga_opera
{
    public class CImaginario
    {
        private double entero;
        private double imaginario;

        public CImaginario(double pEntero, double pImaginario)
        {
            entero = pEntero;
            imaginario = pImaginario;
        }
        //propiedades 
        public double Entero { get { return entero; } set { entero = value; } }
        public double Imaginario { get { return imaginario; } set { imaginario = value; } }

        //para mostrar el numero imaginario
        public override string ToString()
        {
            if (imaginario < 0)
                return string.Format("<{0}  {1}i>", entero, imaginario);
            else
                return string.Format("<{0} + {1}i>", entero, imaginario);
        }   
        // sobrecarga de los operadores binarios
        // a = i1 + i2
        //CImaginario tipo de retorno /- operator -/ tipo operador + - / operandos (op izquierdo o1, op derecho o2)
        public static CImaginario operator + (CImaginario i1, CImaginario i2)
        {
            //resultado entero
            double re = 0;
            //resultado imaginario
            double ri = 0;
            
            re = i1.Entero + i2.Entero;
            ri = i1.Imaginario + i2.Imaginario;

            CImaginario temp = new CImaginario(re, ri);
            return temp;

        }

    }
}