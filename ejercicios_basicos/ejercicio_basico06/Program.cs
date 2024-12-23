using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_basico06
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
               
                Console.Write("Ingrese el sueldo del empleado: ");
                double sueldo = Convert.ToDouble(Console.ReadLine());

               
                double aumento = sueldo * 0.10;

               
                double nuevoSueldo = sueldo + aumento;

                
                Console.WriteLine($"Sueldo anterior: {sueldo:C2}");
                Console.WriteLine($"Aumento aplicado: {aumento:C2}");
                Console.WriteLine($"Nuevo sueldo: {nuevoSueldo:C2}");

                Console.ReadLine();
            }
        }

    }
}

