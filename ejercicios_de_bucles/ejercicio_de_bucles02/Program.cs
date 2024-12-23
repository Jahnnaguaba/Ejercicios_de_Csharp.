using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_bucles02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
              
                string contraseñaCorrecta = "12345";
                string contraseñaIngresada;
                int intentos = 0;
                const int maxIntentos = 3;

                do
                {
                    
                    Console.WriteLine("Ingrese la contraseña:");
                    contraseñaIngresada = Console.ReadLine();
                    intentos++;

                   
                    if (contraseñaIngresada == contraseñaCorrecta)
                    {
                        Console.WriteLine("Contraseña correcta. ¡Acceso permitido!");
                        return; 
                    }
                    else
                    {
                        Console.WriteLine($"Contraseña incorrecta. Intento {intentos} de {maxIntentos}.");
                    }

                } while (intentos < maxIntentos);

                
                Console.WriteLine("Ha agotado el número máximo de intentos. Programa terminado.");
            }
        }

    }
}

