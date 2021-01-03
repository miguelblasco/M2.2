using System;
using System.Collections.Generic;


namespace Fase4  //vídeo n°63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre: \n");

            List<char> name = new List<char>(); // declarar una lista
            name.Add('M');
            name.Add('i');
            name.Add('g');
            name.Add('u');
            name.Add('e');
            name.Add('l');

            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Apellido: \n");


            List<char> surname = new List<char>(); // declarar una lista
            surname.Add('B');
            surname.Add('l');
            surname.Add('a');
            surname.Add('s');
            surname.Add('c');
            surname.Add('o');

            for (int i = 0; i < surname.Count; i++)
            {
                Console.WriteLine(surname[i]);
            }

            // lista fullname

            Console.WriteLine("\n");
            Console.WriteLine("Nombre completo: \n");

            List<char> fullName = new List<char>(); // declarar una lista


            foreach (char i in name)  //guardamos datos de name en fullname
            {
                fullName.Add(i);

            }

            
            fullName.Add(' '); // guardamos espacio en blanco en fullname


            foreach (char i in surname) // guardamos datos de surname en fullname
            {
                fullName.Add(i);
                

            }

            

            for (int i = 0; i < fullName.Count; i++) //sacamos por pantalla los datos de fullname
            {
                Console.WriteLine(fullName[i]);
            }


        }
    }
}
