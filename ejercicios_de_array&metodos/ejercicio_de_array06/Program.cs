using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_array06
{
   
            internal class Program
        {
            static void Main(string[] args)
            {
                
                int[,] inventario = {
            { 20, 15, 30 }, 
            { 10, 25, 5 }, 
            { 40, 20, 10 }  
        };

                string[] dispositivos = { "Televisores", "Laptops", "Teléfonos" };

                for (int almacen = 0; almacen < inventario.GetLength(1); almacen++)
                {
                    int total = 0;
                    int mayorCantidad = int.MinValue;
                    int menorCantidad = int.MaxValue;
                    string dispositivoMayor = "";
                    string dispositivoMenor = "";

                   
                    for (int dispositivo = 0; dispositivo < inventario.GetLength(0); dispositivo++)
                    {
                        int cantidad = inventario[dispositivo, almacen];
                        total += cantidad;

                        if (cantidad > mayorCantidad)
                        {
                            mayorCantidad = cantidad;
                            dispositivoMayor = dispositivos[dispositivo];
                        }

                        if (cantidad < menorCantidad)
                        {
                            menorCantidad = cantidad;
                            dispositivoMenor = dispositivos[dispositivo];
                        }
                    }

                    
                    Console.WriteLine($"Almacén {almacen + 1}:");
                    Console.WriteLine($"- Total de dispositivos: {total}");
                    Console.WriteLine($"- Mayor cantidad: {dispositivoMayor} ({mayorCantidad})");
                    Console.WriteLine($"- Menor cantidad: {dispositivoMenor} ({menorCantidad})");
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }

    }

