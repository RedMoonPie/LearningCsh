using System;
using System.IO;

namespace Archivos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) Crear archivo, 2) Leer archivo");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if(opcion == 1)
            {
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el modelo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                CAuto miAuto = new CAuto(modelo, costo);

                //otras variables

                int numero = 5;
                bool acceso = false;
                byte conteo = 120;
                //creamos stream

                FileStream fs = new FileStream("MiArchivo.arc", FileMode.Create, FileAccess.Write, FileShare.None);

                //creamos el escritor
                BinaryWriter writer = new BinaryWriter(fs);

                //Se escriben los atribuos del objeto 
                writer.Write(miAuto.Modelo);
                writer.Write(miAuto.Costo);

                //escribimos las variables

                writer.Write(numero);
                writer.Write(acceso);
                writer.Write(conteo);
                //cerramos el stream 

                fs.Close(); 


            }
            if(opcion == 2)
            {
                Stream fs = new FileStream("Miarchivo.arc", FileMode.Open, FileAccess.Read, FileShare.None);

                BinaryReader reader = new BinaryReader(fs);
                string modelo = reader.ReadString();
                double costo = reader.ReadDouble();
                CAuto miAuto = new CAuto(modelo, costo);

                fs.Close();
            } 





        }
    }
}
