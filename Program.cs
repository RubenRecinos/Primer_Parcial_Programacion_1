using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programaschidos
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Primer Inciso//

            Console.WriteLine("Calculo De Un Numero Factorial Positivo\n");
            int num;
            do
            {
                Console.Write("Ingrese Un Numero Positivo:");
                num = int.Parse(Console.ReadLine());
                verificar(num);
            } while (num < 0);
            factorial(num);
            Console.ReadKey();
        }
        static void verificar(int n)
        {
            if (n < 0)
            {
                Console.Write("No Existe El Factorial De Un Numero Negativo\n");
            }
        }
        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);

            //Segundo inciso//

            Console.WriteLine("\nCalculo De Numeros Enteros Positivos Menores O Iguales Que N Que Sean Divisibles Entre 3.");
            Console.WriteLine("\nIngresa Un Numero Positivo:");
            int num = int.Parse(Console.ReadLine());
            int num1 = 1;

            while (num1 <= num)
            {
                if (num1 % 3 == 0)

                {
                    Console.WriteLine(num1);
                }

                num1++;

            }

            //Tercer inciso//

            Console.WriteLine("\nCalculo De Numeros Enteros Positivos Menores O Iguales Que N Que Sean Divisibles Entre 5.");
            Console.WriteLine("\nIngresa Un Numero Positivo:");
            int num3 = int.Parse(Console.ReadLine());
            for (int num4 = 1; num4 <= num3; num4++)
            {
                if (num4 % 5 == 0)
                {

                    Console.WriteLine(num4);

                }

            }

            //Cuarto Inciso//

            Console.WriteLine("\nSecuencia De Numeros Enteros Positivos Que Comienzan En 1 Y Se Incrementan En 2 Hasta Que Se Alcance Un Valor Mayor Que N.\n");
            int num5;
            num5 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num5; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("Valor De La Variable Factorial Para Que No Se Le Olvide\n");
            Console.WriteLine(fact);

            Console.ReadKey();
        }

    }
}
