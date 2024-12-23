using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_basico02
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            {
                Console.WriteLine("Introduce el primer número:");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce el segundo número:");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce el tercer número:");
                int numero3 = Convert.ToInt32(Console.ReadLine());

               
                int suma = numero1 + numero2 + numero3;
                int resta = numero1 - numero2 - numero3;
                int multiplicacion = numero1 * numero2 * numero3;
                float division = (float)numero1 / numero2 / numero3; 

              
                Console.WriteLine($"Suma: {suma}");
                Console.WriteLine($"Resta: {resta}");
                Console.WriteLine($"Multiplicación: {multiplicacion}");
                Console.WriteLine($"División: {division}");
            }
        }

    }
}

