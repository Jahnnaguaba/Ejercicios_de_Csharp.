using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_array08
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números que desea sumar: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[cantidad];
            int suma = 0;

            
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

           
            if (suma >= 100)
            {
                Console.WriteLine($"La suma de los números es: {suma}, y es mayor o igual que 100.");
            }
            else
            {
                Console.WriteLine($"La suma de los números es: {suma}, y es menor que 100.");
            }

            Console.ReadLine();
        }
    }

}
