using System;

namespace tareaLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[20];
            int[] edad = new int[20];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona " + (i + 1) + ":");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");
                edad[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                if (edad [i] > 20)
                {
                    Console.WriteLine((i+1) + ". " + nombre[i] + " puede pasar.");
                }
                else
                {
                    Console.WriteLine((i+1) + ". " + nombre[i] + " a la casa.");
                }
            }
        }  
    }
}
