using System.Security.Cryptography.X509Certificates;

namespace Programa_00;

class Program
{
    public class Alumno
    {
        public string nombre;
        public int nota1;
        public int nota2;

        public string Nombre 
        { 
            get { return nombre; }
            set { nombre = value; }
        }
        public int Nota1 
        { 
            get { return nota1; }
            set { nota1 = value; }
        }
        public int Nota2 
        { 
            get { return nota2; }
            set { nota2 = value; }
        }
        public Alumno(string nombre, int nota1, int nota2)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public double calcularPromedio()
        {
            return (nota1 + nota2) /2.0;
        }

        public bool estaAprobado()
        {
            if (calcularPromedio() >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void mostrarEstado()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Su promedio es: " + calcularPromedio());
            if (estaAprobado() == true)
            {
                Console.WriteLine("Usted esta Aprobado");
            }
            else
            {
                Console.WriteLine("Usted esta Desaprobado");
            }
        }
            
        
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del alumno: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la primera nota: ");
        int nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota: ");
        int nota2 = int.Parse(Console.ReadLine());

        Alumno alumno1 = new Alumno(nombre, nota1, nota2);
        
        alumno1.mostrarEstado();

    }
}