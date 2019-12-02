using System;

namespace Medium
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int opcion = 0;
            double a = 0;
            double b = 0;

            Console.WriteLine("Escriba los dos numeros a operar");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            IOperacion operacion = new CSuma();
            while (true)
            {
                Console.WriteLine("Master Calculator, Select an option: \n " +
                    "1.suma\n2.resta\n3.Mult\n4.Div");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        operacion = new CSuma();
                        break;
                    case 2:
                        operacion = new CResta();
                        break;
                    case 3:
                        operacion = new CMulti();
                        break;
                    case 4:
                        operacion = new CDiv();
                        break;
                    default:
                        Console.WriteLine("Comando no asignado");
                        opcion = -1;
                        break;

                }
                if (opcion != -1)
                {
                    operacion.Calcular(a, b);
                    operacion.Mostrar();

                    CSuma s = new CSuma();
                    s.MuestraResultados();

                   
                }

            }

        }
    }
}
