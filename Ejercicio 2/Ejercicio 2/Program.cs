using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resultado = 0;
            int operacion, condicion = 1;

            Console.WriteLine("## CALCULADORA BASICA ##");

            while (condicion == 1)
            {
                Console.WriteLine("\nIngrese la operacion a realizar:\n");
                Console.WriteLine(" 1. Suma \n 2.Resta \n 3.Multiplicacion \n 4.Division");
                operacion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nIngrese el primer numero: ");
                num1 = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nIngrese el segundo numero: ");
                num2 = Convert.ToSingle(Console.ReadLine());

                if (operacion == 1)
                {
                    resultado = num1 + num2;
                }
                else if (operacion == 2)
                {
                    resultado = num1 - num2;
                }
                else if (operacion == 3)
                {
                    resultado = num1 * num2;
                }
                else if (operacion == 4)
                {
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("#ERRROR");
                        resultado = 0;
                    }
                }

                Console.WriteLine("\nEl resultado de la operacion es: " + resultado);
                Console.WriteLine("\n\n¿Desea realizar otra operacion? \n 1 = Si \n 0 = No");
                condicion = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
