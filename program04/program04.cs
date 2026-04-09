namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            string mensaje = "¡Tarea de programación!";
            Console.WriteLine("TIPO TEXTO (string):");  
            Console.WriteLine("   Valor guardado: " + mensaje);


            string nombre = "Maxi Karsvnie";
            Console.WriteLine("TIPO TEXTO (string):");
            Console.WriteLine("   Valor guardado: " + nombre);

            char inicialNombre = 'M';
            Console.WriteLine("TIPO CARÁCTER (char):");
            Console.WriteLine(" Inicial de mi nombre: '" + inicialNombre + "'");

            string personaje = "Superman!";
            Console.WriteLine("TIPO TEXTO (string):");
            Console.WriteLine("   Valor guardado: " + personaje);

            char simbolo = '@';
            Console.WriteLine("TIPO CARÁCTER (char):");
            Console.WriteLine("   Valor guardado: '" + simbolo + "'");
    }
}