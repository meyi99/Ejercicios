using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivina_el_número
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int intentos = 0;
            int numero = random.Next(1, 100);
            int incognita;

            System.Console.WriteLine("Programa Adivina el número.");
            System.Console.WriteLine("El usuario deberá introducir un número entre el 0 y el 100.\ntendra 10 intentos.");
            System.Console.WriteLine("-----------------------------------------------------------\n");

            do
            {
                Console.Write("Introduce un número: ");
                incognita = int.Parse(Console.ReadLine());

                if (incognita < numero)
                {
                    Console.WriteLine("El número es mas grande");
                }
                else if (incognita > numero)
                {
                    Console.WriteLine("El número es mas pequeño");
                }
                else if (incognita == numero)
                {
                    Console.WriteLine("Has gandao!!");
                }
             
                intentos++;
                if (intentos == 10)
                {
                    Console.WriteLine("Has perdido!!");
                }

            } while (incognita != numero && intentos < 10);

            Console.WriteLine("Intentos: {0}", intentos);
        }
    }
}
