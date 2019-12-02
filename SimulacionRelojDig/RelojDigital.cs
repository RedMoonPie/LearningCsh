using System;
using System.Timers;
using System.IO;
namespace SimulacionRelojDig
{
    public class RelojDigital
    {
        private static Timer aTimer;
        private static int hora ;
        private static int minuto;
        private static int segundo;
        private static int oriRow;
        private static int oriCol;

        public RelojDigital(int pHora = 0 , int pMinuto = 0, int pSegundo = 0)
        {
            
            hora = pHora;
            minuto = pMinuto;
            segundo = pSegundo;
            oriRow = Console.CursorTop;
            oriCol = Console.CursorLeft;
        }
        public static void work()
        {
            aTimer = new Timer(1000);

            aTimer.Elapsed += Onsecond;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            Console.ReadLine();

        }
         static void Onsecond(object source,ElapsedEventArgs e)
        {
            segundo += 1;
            // con ori row y oriCol encontramos la posicion actual y de esta manera imprimimos en el mismo sitio
            if (segundo > 60)
            {
                minuto += 1;
                segundo = 0;
                if(minuto > 60)
                {
                    hora += 1;
                    minuto = 0;
                    if(hora > 24)
                    {
                        hora = 0;
                    }
                }
            }






            Console.SetCursorPosition(oriCol,oriRow);
            Console.WriteLine("Hora {0} ; Minuto {1} ; Segundo {2}",hora,minuto,segundo);


            
        }
    }
}
