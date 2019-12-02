using System;

namespace IEnumerable_Enumerator2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CContenedora datos = new CContenedora();
            foreach(int valor in datos)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
