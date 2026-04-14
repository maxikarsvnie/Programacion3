using System;

namespace Array02
{
    class Ejercicio02
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Ejercicio 01: Inicialización directa y Foreach.");

            int [] numeros = { 5, 10, 15 };

            Console.WriteLine("Lista de números:");
            foreach (int numero in numeros)
            {
                Console.WriteLine (numero);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 02.");

            String [] nombres = { "Maxi", "María", "Pedro", "Ana", "Luis" };

            Console.WriteLine("Lista de nombres:");
            foreach (string nombre in nombres)
            {
                Console.WriteLine (nombre);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 03.");

            char [] caracteres = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

            Console.WriteLine("Lista de caracteres.");
            foreach (char caracter in caracteres)
            {
                Console.WriteLine (caracter);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 04.");

            bool [] booleanos = { true, false, true, false };

            Console.WriteLine("Lista de booleanos:");
            foreach (bool booleano in booleanos)
            {
                Console.WriteLine (booleano);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 05.");

            double []  noEnteros = { 5.5, 10.5, 15.5 };

            Console.WriteLine("Lista de decimales:");
            foreach (double noEntero in noEnteros)
            {
                Console.WriteLine (noEntero);
            }
            
        }
    }

}