using System.Reflection.Metadata;

namespace Programa05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 4: VALORES LÓGICOS (SÍ / NO) ---");

            // Booleano (bool) - Solo true o false
            bool Materiaaprobada = true;
            Console.WriteLine(" ¿La materia está aprobada? (Espero que si): " + Materiaaprobada);

            bool EsMayorDeEdad = false;
            Console.WriteLine(" ¿Es mayor de edad?: " + EsMayorDeEdad);

            bool TieneLicenciaDeConducir = true;
            Console.WriteLine(" ¿Tiene licencia de conducir?: " + TieneLicenciaDeConducir);

            bool EsEstudiante = true;
            Console.WriteLine(" ¿Es estudiante?: " + EsEstudiante);

            bool LeGustaProgramar = true;
            Console.WriteLine(" ¿Le gusta programar?: " + LeGustaProgramar);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}