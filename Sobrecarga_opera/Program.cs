using System;

namespace Sobrecarga_opera
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CImaginario im1 = new CImaginario(1, 2);
            CImaginario im2 = new CImaginario(3, 4);
            CImaginario imr;
            imr = im1 + im2;

            Console.WriteLine("{0} + {1} = {2}", im1, im2, imr);
        }
    }
}
