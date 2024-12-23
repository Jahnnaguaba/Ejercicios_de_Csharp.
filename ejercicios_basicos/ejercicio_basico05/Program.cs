using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_basico05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                

                Console.Write("Ingrese la cantidad del artículo: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el precio unitario del artículo: ");
                double precioUnitario = Convert.ToDouble(Console.ReadLine());

                
                double importe = cantidad * precioUnitario;

                
                double itbis = importe * 0.18;

               
                double descuento = importe * 0.10;

                
                double totalGeneral = importe - descuento + itbis;

                
                Console.WriteLine($"Importe: {importe:C2}");
                Console.WriteLine($"ITBIS (18%): {itbis:C2}");
                Console.WriteLine($"Descuento (10%): {descuento:C2}");
                Console.WriteLine($"Total General: {totalGeneral:C2}");

                Console.ReadLine();
            }
        }

    }
}

