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
            Console.WriteLine("Nombre: " + usuario);
            Console.WriteLine("Edad: " + edad ); 
            Console.WriteLine("Estatura: " + estatura + " metros");


        Console.WriteLine("---Perfil de mascota ---");
            Console.Write("Ingresa el nombre de tu mascota: ");
            string nombreMascota = Console.ReadLine();

            Console.Write("Ingresa la edad de tu mascota: ");
            int edadMascota = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el tipo de mascota (ejemplo: perro, gato): ");
            string tipoMascota = Console.ReadLine();

            Console.Write("Ingresa la raza de tu mascota: ");
            string razaMascota = Console.ReadLine();

            Console.WriteLine("--- PERFIL DE MASCOTA CREADO ---");
            Console.WriteLine("Nombre de la mascota: " + nombreMascota);
            Console.WriteLine("Edad de la mascota: " + edadMascota + " años");
            Console.WriteLine("Tipo de mascota: " + tipoMascota);
            Console.WriteLine("Raza de la mascota: " + razaMascota);

        Console.WriteLine("Ingreso de paciente");

            Console.Write("Ingresa el nombre del paciente: ");
            string nombrePaciente = Console.ReadLine();

            Console.Write("Ingresa la edad del paciente: ");
            int edadPaciente = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el diagnóstico del paciente: ");
            string diagnosticoPaciente = Console.ReadLine();

            Console.WriteLine("--- PERFIL DE PACIENTE CREADO ---");
            Console.WriteLine("Nombre del paciente: " + nombrePaciente);
            Console.WriteLine("Edad del paciente: " + edadPaciente + " años");
            Console.WriteLine("Diagnóstico del paciente: " + diagnosticoPaciente);
        
        Console.WriteLine("Ingreso de producto");

            Console.Write("Ingresa el nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Ingresa el precio del producto: ");
            double precioProducto = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la cantidad en stock del producto: ");
            int stockProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("--- PERFIL DE PRODUCTO CREADO ---");
            Console.WriteLine("Nombre del producto: " + nombreProducto);
            Console.WriteLine("Precio del producto: $" + precioProducto);
            Console.WriteLine("Cantidad en stock: " + stockProducto + " unidades");
        
        Console.WriteLine("Ingreso de libro");

            Console.Write("Ingresa el título del libro: ");
            string tituloLibro = Console.ReadLine();

            Console.Write("Ingresa el autor del libro: ");
            string autorLibro = Console.ReadLine();

            Console.Write("Ingresa el año de publicación del libro: ");
            int añoPublicado = int.Parse(Console.ReadLine());

            Console.WriteLine("--- PERFIL DE LIBRO CREADO ---");
            Console.WriteLine("Título del libro: " + tituloLibro);
            Console.WriteLine("Autor del libro: " + autorLibro);
            Console.WriteLine("Año de publicación: " + añoPublicado);

        Console.WriteLine("presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}