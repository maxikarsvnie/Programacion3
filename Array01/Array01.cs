using System;

namespace Array01
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 01: Fundamentos de Arreglos.");

            int [] numeros = new int[3];

            numeros[0] = 5;
            numeros[1] = 10;
            numeros[2] = 15;

            Console.WriteLine("Elemento en la posición 0: " + numeros[0]);
            Console.WriteLine("Elemento en la posición 1: " + numeros[1]);
            Console.WriteLine("Elemento en la posición 2: " + numeros[2]);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 02.");

            double [] decimales = new double[3];

            decimales[0] = 5.5;
            decimales[1] = 10.5;
            decimales[2] = 15.5;

            Console.WriteLine("Elemento en la posición 0: " + decimales[0]);
            Console.WriteLine("Elemento en la posición 1: " + decimales[1]);
            Console.WriteLine("Elemento en la posición 2: " + decimales[2]);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 03.");

            string [] nombres = new string[5];

            nombres[0] = "Maxi";
            nombres[1] = "María";
            nombres[2] = "Pedro";
            nombres[3] = "Ana";
            nombres[4] = "Luis";
        
            Console.WriteLine("Elemento en la posición 0: " + nombres[0]);
            Console.WriteLine("Elemento en la posición 1: " + nombres[1]);
            Console.WriteLine("Elemento en la posición 2: " + nombres[2]);
            Console.WriteLine("Elemento en la posición 3: " + nombres[3]);
            Console.WriteLine("Elemento en la posición 4: " + nombres[4]);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 04.");

            bool [] booleanos = new bool[4];

            booleanos[0] = true;
            booleanos[1] = false;
            booleanos[2] = true;
            booleanos[3] = false;

            Console.WriteLine("Elemento en la posición 0: " + booleanos[0]);
            Console.WriteLine("Elemento en la posición 1: " + booleanos[1]);
            Console.WriteLine("Elemento en la posición 2: " + booleanos[2]);
            Console.WriteLine("Elemento en la posición 3: " + booleanos[3]);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 05.");
            
            char [] caracteres = new char[7];
            
            caracteres[0] = 'A';
            caracteres[1] = 'B';
            caracteres[2] = 'C';
            caracteres[3] = 'D';
            caracteres[4] = 'E';
            caracteres[5] = 'F';
            caracteres[6] = 'G';

            Console.WriteLine("Elemento en la posición 0: " + caracteres[0]);
            Console.WriteLine("Elemento en la posición 1: " + caracteres[1]);
            Console.WriteLine("Elemento en la posición 2: " + caracteres[2]);
            Console.WriteLine("Elemento en la posición 3: " + caracteres[3]);
            Console.WriteLine("Elemento en la posición 4: " + caracteres[4]);
            Console.WriteLine("Elemento en la posición 5: " + caracteres[5]);
            Console.WriteLine("Elemento en la posición 6: " + caracteres[6]);
        }
    }
}