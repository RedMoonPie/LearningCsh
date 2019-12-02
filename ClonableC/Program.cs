using System;

namespace ClonableC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CAuto Auto1 = new CAuto("March", 170000);
            //aqui pensamos que hacemos clonado
              
            CAuto Auto2 = Auto1;

            Auto1.CalculaTenencia(0.10);
            Auto2.CalculaTenencia(0.10);
            //imprimimos
            Auto1.MuestraInformacion();
            Auto2.MuestraInformacion();

            Console.WriteLine("---------");

            //Clon
            CAuto Auto3 = (CAuto)Auto1.Clone();

            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();

            Console.WriteLine("---------------");

            Auto1.Costo = 2500000;

            Auto1.MuestraInformacion();
            Auto3.MuestraInformacion();

        }
    }
}
