using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.WriteLine("Introduce la cantidad de artículos:");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce el precio por artículo:");
                double precio = double.Parse(Console.ReadLine());

              
                double importeTotal = cantidad * precio;

                
                Console.WriteLine($"El importe total es: {importeTotal}");
            }
        }

    }
}

