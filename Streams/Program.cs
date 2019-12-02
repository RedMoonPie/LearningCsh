using System;
using System.IO;
namespace Streams
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long cantidad = 0;
            long n = 0;
            int valor = 0;

            FileStream fs = new FileStream("datos.txt", FileMode.Open, FileAccess.Read, FileShare.None);

            //obtenemos la cantidad

            cantidad = fs.Length;
            Console.WriteLine("El archivo mide {0}", cantidad);

            //Leemos by por byte 

            for (n = 0; n < cantidad; n++)
            {
                // ponemos la posicion
                fs.Seek(n, SeekOrigin.Begin);
                
                valor = fs.ReadByte();

                Console.Write("  {0}  ", (char)valor);
            }
            fs.Seek(5, SeekOrigin.Begin);

            valor = fs.ReadByte();
            Console.Write("Este es el solo"+(char)valor);

            fs.Close();
        }
    }
}
