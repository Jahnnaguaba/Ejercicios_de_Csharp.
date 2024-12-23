using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_clases_objetos05
{
    
internal class Program
        {
            static void Main(string[] args)
            {
               
                OperacionOperacion operacion = new OperacionOperacion();
                Sumar sumar = new Sumar();
                Restar restar = new Restar();
                Multiplicar multiplicar = new Multiplicar();

                
                Console.Write("Ingresa el primer número: ");
                operacion.Numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                operacion.Numero2 = Convert.ToDouble(Console.ReadLine());

                
                Console.WriteLine("\nElige una operación:");
                Console.WriteLine("1. Suma | 2. Resta | 3. Multiplicación | 4. División");
                int opcion = Convert.ToInt32(Console.ReadLine());

               
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Resultado de la suma: {sumar.RealizarOperacion(operacion.Numero1, operacion.Numero2)}");
                        break;

                    case 2:
                        Console.WriteLine($"Resultado de la resta: {restar.RealizarOperacion(operacion.Numero1, operacion.Numero2)}");
                        break;

                    case 3:
                        Console.WriteLine($"Resultado de la multiplicación: {multiplicar.RealizarOperacion(operacion.Numero1, operacion.Numero2)}");
                        break;

                    case 4:
                        if (operacion.Numero2 != 0)
                            Console.WriteLine($"Resultado de la división: {operacion.Dividir()}");
                        else
                            Console.WriteLine("Error: No se puede dividir por cero.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.ReadLine();
            }

           
            public class OperacionOperacion
            {
                public double Numero1 { get; set; }
                public double Numero2 { get; set; }

               
                public double Dividir()
                {
                    return Numero1 / Numero2;
                }
            }

           
            public class Sumar
            {
                public double RealizarOperacion(double num1, double num2)
                {
                    return num1 + num2;
                }
            }

            public class Restar
            {
                public double RealizarOperacion(double num1, double num2)
                {
                    return num1 - num2;
                }
            }

            public class Multiplicar
            {
                public double RealizarOperacion(double num1, double num2)
                {
                    return num1 * num2;
                }
            }
        }

    }

