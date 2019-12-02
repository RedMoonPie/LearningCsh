using System;

namespace Icomparablee
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CRectangulo[] rects = new CRectangulo[5];
            rects[0] = new CRectangulo(7, 5);
            rects[1] = new CRectangulo(6, 4);
            rects[2] = new CRectangulo(4, 3);
            rects[3] = new CRectangulo(7, 6);
            rects[4] = new CRectangulo(5, 7);
        
            foreach(CRectangulo r in rects )
                Console.WriteLine(r);
             
            Console.WriteLine("------");

            Array.Sort(rects);

            foreach (CRectangulo r in rects)
                Console.WriteLine(r);
                
                       
                
       }
        
    }
}
