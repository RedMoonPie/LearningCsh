using System;
using System.Collections;

namespace Medium
{
    public  class Cabs
    {
        protected ArrayList resultados = new ArrayList();

        public void MuestraResultados()
        {
            foreach(double j in resultados)
            {
                Console.WriteLine(j);
            }
        }

    }
}
