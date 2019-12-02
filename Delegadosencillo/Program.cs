using System;

namespace Delegadosencillo
{
    //definimos el delegado con las caracteristias que nos interesa
    public delegate void MiDelegado(string m);
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creamos un objeto del delegado y lo referenciamos a un metgto
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);

            //Ahora por medio de l delegado hacemos uso del metgoto
            delegado("hola a todos");

            //hacemos que apunte a otro metodo 
            delegado = new MiDelegado(CPastel.MostrarPastel);
            //ahora invocamos el otro metodo
            delegado("Feliz cumpleanos");
        }
    }
}
