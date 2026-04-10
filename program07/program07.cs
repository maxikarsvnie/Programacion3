using System.Data;

namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        //1.
        Console.WriteLine("Ingrese conversor de Temperatura");

        Console.WriteLine("Ingrese la temperatura en Celsius:");
        double temperaturaCelsius = double.Parse(Console.ReadLine());
        
        double temperaturaFahrenheit = (temperaturaCelsius * 1.8) + 32;
        
        Console.WriteLine("La temperatura en Fahrenheit es: " + temperaturaFahrenheit);
     
        //2.
        const double aportes = 0.19;

        Console.WriteLine("Ingrese el salario bruto:");
        double salarioBruto = double.Parse(Console.ReadLine());

        double descuento = salarioBruto * aportes;
        double salarioNeto = salarioBruto - descuento;
        Console.WriteLine("El salario neto es: " + salarioNeto);
    
        //3.
        const int meses = 12;
        const int dias = 365;

        Console.WriteLine("Ingrese su edad:");
        int edad = int.Parse(Console.ReadLine());

        int cantidadMeses = edad * meses;
        int cantidadDias = edad * dias;

        Console.WriteLine("Su edad en meses es: " + cantidadMeses);
        Console.WriteLine("Su edad en días es: " + cantidadDias);

        //4.
        const int rendimientoLitros = 35;

        Console.WriteLine("Ingrese la capidad del tanque: ");
        int capacidadTanque = int.Parse(Console.ReadLine());

        int distanciaMaxima = capacidadTanque * rendimientoLitros;

        Console.WriteLine("La distancia máxima que se puede recorrer es: " + distanciaMaxima);

        //5.

        const int precioDolar = 1385;

        Console.WriteLine("Convertidor de Pesos a Dólares");
        Console.WriteLine("Ingrese la cantidad de pesos a convertir (Sin centavos):");
        int cantidadPesos = int.Parse(Console.ReadLine());

        int cantidadDolares = cantidadPesos / precioDolar;

        Console.WriteLine("La cantidad de dólares que se pueden comprar es: " + cantidadDolares);
    }
}