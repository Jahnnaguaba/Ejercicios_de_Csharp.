using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_basico03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                
                int suma = 0;
                int numero;

               
                Console.WriteLine("Introduce 5 números:");
                numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;

                numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;

                numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;

                numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;

                numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;

                
                Double promedio = (Double)suma / 5;

                // Mostrar el resultado
                Console.WriteLine($"El promedio es: {promedio}");
            }
        }

    }
}

