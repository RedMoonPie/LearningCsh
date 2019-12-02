using System;

namespace CallBackk
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CRefri refri = new CRefri(50,-20);
            Random rd = new Random();

            CRefriSink sink1 = new CRefriSink();
            CTiendaSink sink2 = new CTiendaSink();

            refri.AgregarSink(sink1);
            refri.AgregarSink(sink2);

            while (refri.Kilos > 0 && sink1.Paro == false)
            {
                refri.Trabajar(rd.Next(1, 5));
            }

        }
    }
}
