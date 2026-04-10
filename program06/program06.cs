using System.Security.AccessControl;

namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
            //1.
            const string seccion = "Accsos VIP";
            const int EDAD_MINIMA = 21;

            Console.WriteLine(seccion);
            Console.WriteLine("chequeando edad mínima para el acceso...");
            Console.WriteLine("Restricción: Prohibido el acceso a menores de " + EDAD_MINIMA + " años.");
            
            const int EDAD_CLIENTE = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA;

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            //2.
            const int precioProducto = 100;
            const double descuento = 0.15;
            const int cantidadMinima = 3;
            const double precioConDescuento = precioProducto * (1 - descuento);

            Console.WriteLine("Ingrese la cantidad de productos que desea comprar:");
            int cantidadPrductos = int.Parse(Console.ReadLine());

            if (cantidadPrductos >= 3)
            {
                Console.WriteLine("\nCalculando precio con descuento...");
                Console.WriteLine("Precio original: $" + precioProducto);
                Console.WriteLine("Descuento: " + (descuento * 100) + "%");
                Console.WriteLine("Precio con descuento: $" + precioConDescuento);
                Console.WriteLine("Precio total con descuento: $" + precioConDescuento * cantidadPrductos);
            }
            else
            {
                Console.WriteLine("\nNo se aplica descuento.");
                Console.WriteLine("Recuerda que el descuento solo se aplica a compras de " + cantidadMinima + " o más productos.");
                Console.WriteLine("Precio total sin descuento: $" + precioProducto * cantidadPrductos);
            }
            
            //3.
            const string contraseñaCorrecta = "admin123";

            Console.WriteLine("Ingrese la contraseña para acceder al sistema:");
            string contraseñaIngresada = Console.ReadLine();
            
            if (contraseñaIngresada == contraseñaCorrecta)
            {
                Console.WriteLine("Acceso concedido. Bienvenido al sistema.");
            }
            else
            {
                Console.WriteLine("Acceso denegado. Contraseña incorrecta.");
            }
            //4.
            const double PI = 3.14159;
            
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = double.Parse(Console.ReadLine());

            double radioCuadrado = radio * radio;
            double formulaAreaCirculo = PI * radioCuadrado;

            Console.WriteLine("El área del círculo es: " + formulaAreaCirculo);
            
            //5.
            const string usuario = "admin";

            Console.WriteLine("Ingrese su usuario:");
            string usuarioIngresado = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña:");
            string passwordIngresada = Console.ReadLine();

            if (usuarioIngresado == usuario)
            {
                Console.WriteLine("Acceso de Admin concedido. Bienvenido al sistema.");
            }
            else
            {
                Console.WriteLine("Acceso de usuario concedido. Bienvenido al sistema.");
            }
    }
}