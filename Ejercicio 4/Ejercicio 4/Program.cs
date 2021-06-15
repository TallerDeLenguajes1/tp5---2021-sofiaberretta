using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena, cadena2;

            Console.WriteLine("Ingrese una cadena de texto: ");
            cadena = Console.ReadLine();

            Console.WriteLine("\nLa longitud de la cadena es: " + cadena.Length);

            Console.Write("\nIngrese otra cadena: ");
            cadena2 = Console.ReadLine();
            Console.WriteLine("Las cadenas concatenadas son: " + cadena + " " + cadena2);

            Console.WriteLine("La subcadena extraida es: " + cadena2.Substring(4));

            
        }
    }
}
