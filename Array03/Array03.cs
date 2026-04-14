using System;

namespace Array03
{
    class Ejercicio03
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Ejercicio 01: Uso de .Length y bucle For.");

            int [] numeros = { 5, 10, 15 };
            int cantidadNumeros = numeros.Length;

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine("Numero en la posicion " + i + ": " + numeros[i]);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 02.");

            String [] nombres = { "Maxi", "María", "Pedro", "Ana", "Luis" };
            int cantidadNombres = nombres.Length;

            for (int i = 0; i < cantidadNombres; i++)
            {
                Console.WriteLine("Nombre en la posicion " + i + ": " + nombres[i]);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 03.");

            char [] caracteres = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            int cantidadCaracteres = caracteres.Length;

            for (int i = 0; i < cantidadCaracteres; i++)
            {
                Console.WriteLine("Caracter en la posicion " + i + ": " + caracteres[i]);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 04.");

            bool [] booleanos = { true, false, true, false };
            int cantidadBooleanos = booleanos.Length;

            for (int i = 0; i < cantidadBooleanos; i++)
            {
                Console.WriteLine("Booleano en la posicion " + i + ": " + booleanos[i]);
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejercicio 05.");

            double []  noEnteros = { 5.5, 10.5, 15.5 };
            int cantidadNoEnteros = noEnteros.Length;

            for (int i = 0; i < cantidadNoEnteros; i++)
            {
                Console.WriteLine("Numero decimal en la posicion " + i + ": " + noEnteros[i]);
            }
        }
    }

}