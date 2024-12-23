using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_basico01
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

                
                int suma = numero1 + numero2;
                int resta = numero1 - numero2;
                int multiplicacion = numero1 * numero2;
                int division = (int)numero1 / numero2; 

               
                Console.WriteLine($"Suma: {suma}");
                Console.WriteLine($"Resta: {resta}");
                Console.WriteLine($"Multiplicación: {multiplicacion}");
                Console.WriteLine($"División: {division}");
            }
        }

    }
}

