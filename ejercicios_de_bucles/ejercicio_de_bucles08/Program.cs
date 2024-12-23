using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_bucles08
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            {
                int suma = 0;
                int numero;

                Console.WriteLine("Ingrese números para calcular la sumatoria. Ingrese 0 para terminar.");

                do
                {
                    Console.Write("Ingrese un número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    suma += numero;

                } while (numero != 0);

                Console.WriteLine($"La sumatoria de los números ingresados es: {suma}");
            }
        }

    }
}

