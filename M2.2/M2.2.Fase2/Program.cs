using System;
using System.Collections.Generic;


namespace Fase2 //video n° 63
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> caracteres = new List<char>(); // declarar una lista
            caracteres.Add('M');
            caracteres.Add('1');
            caracteres.Add('g');
            caracteres.Add('u');
            caracteres.Add('e');
            caracteres.Add('l');

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(caracteres[i]);
            }


          char letra;
          bool esVocal;
          bool esNumero;

      

            for (int i = 0; i < 6; i++)

            {
                letra = caracteres[i];

                esVocal = ((letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u'));
                esNumero = (letra >= '0') && (letra <= '9');

                if (esNumero) Console.WriteLine($"{caracteres[i]} Los nombres de personas no contienen número");

                else if (esVocal)
                     Console.WriteLine($"{caracteres[i]} es vocal");
                else Console.WriteLine($"{caracteres[i]} es conosonante");
            }

            
    }

    }
}
