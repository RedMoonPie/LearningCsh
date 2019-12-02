using System;
using System.Text.RegularExpressions;

namespace Expresiones_regular
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Metodo 1 

            // BUsqueda de expresion en un texto
            string texto = "La casa del casamentero pacasa";
            string exp = "casa";

            MatchCollection encontrado = Regex.Matches(texto, exp);

            foreach(Match e in encontrado)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("----------------------");

            //Metodo 2

            //Busqueda de una palabra especifica (ojo si esta al final)
            texto = "El estudiante es un casanova en la escuela";
            exp = " casa ";

            Regex expReg = new Regex(exp);

            encontrado = expReg.Matches(texto);

            foreach (Match e in encontrado)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("----------------------");




            //uso de . significa cualquier caracter
            //cabal campeon academico

            texto = "Saludos al ams cabal";
            exp = " ca.";
            // imprime cab
            MatchesExp(texto, exp);


            //Uso de clases de caracteres, se usa [] para contener los carateres
            //Nicio, Necio, Naco

            texto = "Hola Naco";
            exp = "N[iea]c";
            // Puede ser Nic o Nec 
            MatchesExp(texto, exp);

        }
        public static void MatchesExp(string pTexto, string pExp)
        {
            MatchCollection encontrado = Regex.Matches(pTexto, pExp);

            foreach(Match e in encontrado)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("-------------------");
        }
    }
}
