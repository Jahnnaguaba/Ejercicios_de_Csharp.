using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_bucles01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                
                int positivos = 0, negativos = 0, pares = 0, impares = 0;

                Console.WriteLine("¿Cuántos números desea ingresar?");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                int contador = 0;

              
                while (contador < cantidad)
                {
                    Console.WriteLine($"Ingrese el número {contador + 1}:");
                    int numero = Convert.ToInt32(Console.ReadLine());

                   
                    if (numero > 0)
                    {
                        positivos++;
                    }
                    else if (numero < 0)
                    {
                        negativos++;
                    }

                    
                    if (numero % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }

                  
                    contador++;
                }

               
                Console.WriteLine("\nResultados:");
                Console.WriteLine($"Cantidad de números positivos: {positivos}");
                Console.WriteLine($"Cantidad de números negativos: {negativos}");
                Console.WriteLine($"Cantidad de números pares: {pares}");
                Console.WriteLine($"Cantidad de números impares: {impares}");
            }
        }

    }
}

