namespace Programa02;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("--- BLOQUE 1: NÚMEROS ENTEROS ---");

        int entero = 28;

        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Para números sin decimales, como edad o cantidad.");
        Console.WriteLine("   Valor guardado: " + entero);

        Console.WriteLine("--- BLOQUE 2: NÚMEROS DECIMALES ---");
        
        double numdecimal = 3.14;
        
        Console.WriteLine("2. TIPO DECIMAL (double):");
        Console.WriteLine("   Para números con decimales, como precios o medidas.");
        Console.WriteLine("   Valor guardado: " + numdecimal);

        Console.WriteLine("--- BLOQUE 3: CADENAS DE TEXTO ---");
        
        string texto = "¡Hola, mundo!";
        
        Console.WriteLine("3. TIPO CADENA (string):");
        Console.WriteLine("   Para texto, como nombres o descripciones.");
        Console.WriteLine("   Valor guardado: " + texto);

        Console.WriteLine("--- BLOQUE 4: BOOLEANOS ---");
        
        bool booleano = true;
        
        Console.WriteLine("4. TIPO BOOLEANO (bool):");
        Console.WriteLine("   Para valores lógicos, como verdadero o falso.");
        Console.WriteLine("   Valor guardado: " + booleano);

        Console.WriteLine("--- BLOQUE 5: CARACTERES ---");
        
        char caracter = 'A';
        
        Console.WriteLine("5. TIPO CARACTER (char):");
        Console.WriteLine("   Para un solo carácter, como letras o símbolos.");
        Console.WriteLine("   Valor guardado: " + caracter);
    }
}