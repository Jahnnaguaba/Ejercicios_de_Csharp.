using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_bucles09
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            {
                Console.WriteLine("Ingrese el número de filas para el patrón triangular:");
                int filas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Patrón triangular:");

                int filaActual = 1;

                
                while (filaActual <= filas)
                {
                    int asteriscos = 1;

                    
                    while (asteriscos <= filaActual)
                    {
                        Console.Write("*");
                        asteriscos++;
                    }

                    Console.WriteLine(); 
                    filaActual++;
                }
            }
        }

    }
}

