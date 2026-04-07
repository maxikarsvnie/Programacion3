namespace Program01;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- Crea tu usuario ---");

            Console.Write("Por favor, ingresa tu usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine()); 

            Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
            double estatura = double.Parse(Console.ReadLine());

            Console.WriteLine("--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad ); 
            Console.WriteLine("Estatura: " + estatura + " metros");
    }
}