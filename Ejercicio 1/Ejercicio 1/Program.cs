using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, numInvertido=0;
            Console.WriteLine("## Invirtiendo un numero ##");
            Console.WriteLine("\n Ingrese el numero a invertir:");
            numero = Convert.ToInt32(Console.ReadLine());
            if(numero > 0)
            {
                while(numero >= 10)
                {
                    numInvertido = (numInvertido * 10) + (numero % 10);
                    numero /= 10;
                }

                numInvertido = (numInvertido * 10) + numero;
                Console.WriteLine("\nEl numero invertido es " + numInvertido);
            }
            else
            {
                Console.WriteLine("\nNo se puede realizar la inversion");
            }

            Console.ReadKey();
        }
    }
}
