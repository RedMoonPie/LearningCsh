using System;
using System.Collections;
namespace IEnumerable_Enumerator2
{
    public class CContenedora:IEnumerable
    {
        private int[] valores = new int[10];
        public CContenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n * n;
        }
        //Implementamos el GetEnumerator necesario por IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            //Instanciamos el enumerador y lo regresamos
            return (new ContenedorEnum(valores));
        }
    }
    //enumerador - contador 
    public class ContenedorEnum : IEnumerator
    { // el enumerator depende de la estructura 
        public int[] arreglo;
        public int posicion =-1;
        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }
        //se avanza elemento por elemento 
        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
                return true;
            else
                return false;

        }
        public void Reset()
        {
            //valor de inicio 
            posicion = -1;
        }
        //retorna el actual como objeto, es necesario typecast en ocasiones, se usa excepciones
        //para tener seguridad de fuera de array etc 
        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }
    }
}
