using System;
namespace Delega2
{
    public delegate void ServirComida(string pNombre);
    public class CCasa
    {
        private int hora = 0;
        private ServirComida serve;
        public CCasa(int pHora) {
            hora = pHora;
        }

        public void Adicionarpedido(ServirComida pMetodo)
        {
            serve += pMetodo;
        }
        public void Eliminarpedido(ServirComida pMetodo)
        {
            serve -= pMetodo;
        }

        public int Hora { get { return hora; } set { hora = value; } }

        public void EnCasa(int minutos)
        {

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("--la hora es {0}",hora);
            if (hora > 0 && hora < 4)
            {
                Console.WriteLine("Hora---------{0}", hora);
                serve("juan");
            }
            if (hora > 3 && hora < 7)
            {
                Console.WriteLine("Hora---------{0}", hora);
                serve("Marco");

            }
            hora = hora + minutos;

        }

    }
}
