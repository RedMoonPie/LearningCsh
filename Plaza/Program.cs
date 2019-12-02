using System;

namespace Plaza
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CProducto tomate = new CProducto(100, 5, 15);
            CProducto pizza = new CProducto(5000, 100, 500);
            CProducto arepa = new CProducto(2000, 200, 1000);
            CProducto pizza2 = new CProducto(5000, 100, 500);

            CProducto p;

            p = tomate + arepa + pizza;
            Console.WriteLine(p);
            tomate ++;
            p = tomate + arepa + pizza;
            Console.WriteLine(p);
            if (pizza != arepa)
            {
                Console.WriteLine("Misma grasa al mismo precio :V");
            }
            if ( pizza > arepa)
            {
                Console.WriteLine("Pizza es menos saludable que arepa");
            }
            else
                Console.WriteLine("arepa es mas saludable que pizza");

        }
    }
}
