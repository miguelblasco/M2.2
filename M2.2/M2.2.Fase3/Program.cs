using System;
using System.Collections.Generic;


namespace Fase3 // vídeo n°66 dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> caracteres = new Dictionary<char, int>();

            //rellenar diccionario

            caracteres.Add('M', 1);
            caracteres.Add('i', 1);
            caracteres.Add('g', 1);
            caracteres.Add('u', 1);
            caracteres.Add('e', 1);
            caracteres.Add('l', 1);

            //recorrer diccionario

            foreach (KeyValuePair<char, int> letra in caracteres)
            {
                Console.WriteLine("letra: " + letra.Key + "   cantidad: " + letra.Value);

            }

        }
    }
}