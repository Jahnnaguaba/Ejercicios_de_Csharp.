using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_bucles07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ingrese el número para calcular su tabla de multiplicar:");
                int numero = Convert.ToInt32(Console.ReadLine());

                int i = 1; 

                Console.WriteLine($"Tabla de multiplicar del {numero}:");

               
                do
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                    i++;
                } while (i <= 12);
        }

    }
}
}
