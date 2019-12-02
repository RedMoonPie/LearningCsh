using System;

namespace Parametros_Nombrados_Opcionales
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            void MostraNombrados(int pA, int pB, int pC)
            {

                Console.WriteLine("1) {0} ; 2) {1} ; 3) {2};", pA, pB, pC);


            }
            void MostraOpcionales(int pA = 1, int pB =20 , int pC =40)
            {
                Console.WriteLine("1) {0} ; 2) {1} ; 3) {2};", pA, pB, pC);

            }


            // Parametros normales
            MostraNombrados(1,2,3);
            // Parametros Nombrados 
            MostraNombrados(pA:1,pC:5,pB:2);
            // Parametros Opcionales
            MostraOpcionales(5);

        }
    }
}
