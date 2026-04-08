namespace Programa03;

class Program
{
    static void Main(string[] args)
    {

            double pesoyerba = 1.75;
            Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            Console.WriteLine("   Valor guardado: " + pesoyerba + " kilos");

            decimal precioProducto = 539.99m;
            Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
            Console.WriteLine("   Valor guardado: $" + precioProducto);

            double temperatura = 36.6;
            Console.WriteLine("\n4. TIPO DECIMAL PARA MEDICIÓN (double):");
            Console.WriteLine("   Valor guardado: " + temperatura + " grados Celsius");

            decimal salario = 2500.00m;
            Console.WriteLine("\n5. TIPO DECIMAL PARA SALARIOS (decimal):");
            Console.WriteLine("   Valor guardado: $" + salario);

            double distancia = 42.195;
            Console.WriteLine("\n6. TIPO DECIMAL PARA DISTANCIAS (double):");
            Console.WriteLine("   Valor guardado: " + distancia + " kilómetros");
    }
}