using System;
namespace Icomparablee
{
    public class CRectangulo:IComparable
    {
        private double ancho;
        private double alto;
        private double area;
       
        public CRectangulo(double pAncho, double pAlto)
        {
            ancho = pAncho;
            alto = pAlto;
            CalculaArea();
        }
        private void CalculaArea()
        {
            area = ancho * alto;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}] = {2}",ancho,alto,area);
        }
        // sin public o acceso
        int IComparable.CompareTo(object obj)
        {
            //hacmeos type cast con el objeto con el cual nos vamos a comparar

            CRectangulo temp = (CRectangulo)obj;
            //reglas de comparacion con la complejidad que se requiera 

            //si somos mas grandes que el objeto regresamos 1

            if (area > temp.area)
                return 1;
            // si somos mas pequenos que el objeto regresamos -1
            if (area < temp.area)
                return -1;
            // si son iguales retorna 0 
            return 0;
        }


    }
}
