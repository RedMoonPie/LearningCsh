using System;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace SerializacionSOap
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) crear y serializar auto 2) leer auto");

            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                // creamos el objeto CAuto
                string modelo = "";
                double costo = 0;
                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                costo = Convert.ToDouble(Console.ReadLine());

                CAuto miAuto = new CAuto(modelo, costo);

                Console.WriteLine("Auto serializar");
                miAuto.MuestraInformacion();

                //empezamos la serializacion
                Console.WriteLine("-----serializamos-------");

                //seleccionamos e lformateador

                SoapFormatter formateador = new SoapFormatter();

                //se crea el stream
                //Autos.aut- se puede poner la ruta completa o solo asi 
                //FileMode.create- si no existe lo creamos si existe lo sobre escribimos
                //FileAcces.write - porque escribiremos informacion
                //FileShare.None - tengamos flexibilidad sobre el archivo y nada mas lo use  mientras lo usamos
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                //serializamos 
                //2 parametros (stream(como se coloca el archivo), objeto que deseamos serializar)
                formateador.Serialize(miStream, miAuto);
                //se ciera para 
                //cerramos el stream para evitar problemas 
                miStream.Close();
            }
            if (opcion == 2)
            {
                //Deserializamos el objeto
                Console.WriteLine("---Deserializamos---");

                //seleccionamos el formateador
                SoapFormatter formateador = new SoapFormatter();

                //creamos el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                //Deserializamos
                CAuto miAuto = (CAuto)formateador.Deserialize(miStream);

                //cerramos stream
                miStream.Close();

                //usamos el objeto
                Console.WriteLine("El auto deserializado es");
                miAuto.MuestraInformacion();

            
        
            }
        }
    }
}
