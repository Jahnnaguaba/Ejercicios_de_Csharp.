using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_en_vivo_de_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] dolares = new int[1];

            
            Console.Write("Introduce la cantidad de dólares: ");
            dolares[0] = Convert.ToInt32(Console.ReadLine());

           
            double dop = ConvertirADOP(dolares);

            
            Console.WriteLine($"La cantidad en pesos dominicanos es de: {dop:C2}");
            Console.ReadLine();
        }

        
        static double ConvertirADOP(int[] dolares)
        {
            const double tasaCambio = 60.43; 
            return dolares[0] * tasaCambio;
        }
    }

}
