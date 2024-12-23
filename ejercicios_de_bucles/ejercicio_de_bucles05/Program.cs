using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_bucles05
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            {
                int suma = 0;
                int cantidad = 100;

               
                for (int i = 1; i <= cantidad; i++)
                {
                    suma += i;
                }

                
                double promedio = (double)suma / cantidad;

               
                Console.WriteLine($"El promedio de los primeros 100 números naturales es: {promedio}");
            }
        }

    }
}

