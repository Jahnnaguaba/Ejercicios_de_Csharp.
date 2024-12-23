using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_en_vivo_de_array03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] numeros = new int[2];

            
            Console.Write("Ingrese el primer valor: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());

           
            int resultado = Mul(numeros);

            
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
            Console.ReadLine();
        }

       
        static int Mul(int[] nums)
        {
            return nums[0] * nums[1];
        }
    }

}
