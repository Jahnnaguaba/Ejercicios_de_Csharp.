using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_array07
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            string[] nombres = new string[cantidad];
            int[] calificaciones = new int[cantidad];

            
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
                nombres[i] = Console.ReadLine();

                Console.Write($"Ingrese la calificación de {nombres[i]}: ");
                calificaciones[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            MostrarEstudiantes(nombres, calificaciones);

            Console.ReadLine();
        }

       
        static void MostrarEstudiantes(string[] nombres, int[] calificaciones)
        {
            Console.WriteLine("\nLista de estudiantes y sus calificaciones:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Estudiante: {nombres[i]}, Calificación: {calificaciones[i]}");
            }
        }
    }

}
