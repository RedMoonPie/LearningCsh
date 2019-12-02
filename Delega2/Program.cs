using System;

namespace Delega2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CCasa c1 = new CCasa(2);

            ServirComida s1 = new ServirComida(CDesayuno.ServirDesayuno);
            ServirComida s2 = new ServirComida(CAlmuerzo.ServirAlmuerzo);
            ServirComida s3 = new ServirComida(CCena.ServirCena);

            Console.WriteLine(c1.Hora);
            while(c1.Hora > 0 && c1.Hora < 13 )
            {
                if (c1.Hora > 0 && c1.Hora < 4)
                {
                    c1.Adicionarpedido(s1);
                    c1.EnCasa(1);
                    c1.Eliminarpedido(s1);
                    Console.WriteLine("Hora---------{0}", c1.Hora);
                }

                if(c1.Hora > 3 && c1.Hora < 7)
                {
                    c1.Adicionarpedido(s2);
                    c1.EnCasa(1);
                    c1.Eliminarpedido(s2);
                    Console.WriteLine("Hora---------{0}", c1.Hora);

                }

            }
        }
    }
}
