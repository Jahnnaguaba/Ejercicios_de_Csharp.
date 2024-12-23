using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_bucles03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int sumatoria = 0;

                Console.WriteLine("Ingrese números enteros. El programa terminará cuando la sumatoria sea mayor o igual a 100.");

                do
                {
                    Console.WriteLine("Ingrese un número:");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    sumatoria += numero;

                    Console.WriteLine($"Sumatoria actual: {sumatoria}");

                } while (sumatoria < 100);

                Console.WriteLine("La sumatoria es mayor o igual a 100. ¡Programa terminado!");
            }
        }

    }
}

