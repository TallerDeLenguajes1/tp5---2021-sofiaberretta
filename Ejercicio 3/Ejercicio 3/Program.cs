using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3;

            Console.WriteLine("## CALCULADORA ##");

            Console.WriteLine("\nIngrese un numero: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nEl valor absoluto de " + num1 + " es: " + Math.Abs(num1));
            Console.WriteLine("\nEl cuadrado de " + num1 + " es: " + Math.Pow(num1,2));
            Console.WriteLine("\nLa raiz cuadrada de " + num1 + " es: " + Math.Sqrt(num1));
            Console.WriteLine("\nEl seno de " + num1 + " es: " + Math.Sin(num1));
            Console.WriteLine("\nEl coseno de " + num1 + " es: " + Math.Cos(num1));
            Console.WriteLine("\nLa parte entera de " + num1 + " es: " + Math.Round(num1));

            Console.WriteLine("\n\nIngrese el primer numero: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nIngrese el segundo numero: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nEl maximo entre ambos numeros es: " + Math.Max(num2,num3));
            Console.WriteLine("\nEl minimo entre ambos numeros es: " + Math.Min(num2, num3));

        }
    }
}
