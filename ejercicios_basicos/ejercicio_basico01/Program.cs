using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_basico01
{
    internal class Program
    {
       
            static void Main()
            {
                Console.WriteLine("Introduce el pago por hora:");
                float pagoPorHora = float.Parse(Console.ReadLine());

                Console.WriteLine("Introduce las horas trabajadas:");
                float horasTrabajadas = float.Parse(Console.ReadLine());

               
                float sueldoBruto = pagoPorHora * horasTrabajadas;

               
                float descuentoAFP = sueldoBruto * 0.0287f;
                float descuentoSFS = sueldoBruto * 0.0304f;
                float totalDescuentos = descuentoAFP + descuentoSFS;

                
                float sueldoNeto = sueldoBruto - totalDescuentos;

                Console.WriteLine($"Sueldo bruto: {sueldoBruto}");
                Console.WriteLine($"Descuento AFP: {descuentoAFP}");
                Console.WriteLine($"Descuento SFS: {descuentoSFS}");
                Console.WriteLine($"Sueldo neto: {sueldoNeto}");
            }
        }

    }


