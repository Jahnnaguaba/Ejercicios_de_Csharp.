using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_clases_objetos04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiantes[] estudiantes = new Estudiantes[5];

            
            for (int i = 0; i < estudiantes.Length; i++)
            {
                estudiantes[i] = new Estudiantes();

                Console.Write("Ingresa el nombre del estudiante: ");
                estudiantes[i].Nombre = Console.ReadLine();

                Console.Write("Ingresa la edad del estudiante: ");
                estudiantes[i].Edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa la carrera del estudiante: ");
                estudiantes[i].Carrera = Console.ReadLine();

                Console.Write("Ingresa la matricula del estudiante: ");
                estudiantes[i].Matricula = Console.ReadLine();

                Console.WriteLine();
            }

            
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"El nombre del estudiante es: {estudiantes[i].Nombre}");
                Console.WriteLine($"La edad del estudiante es: {estudiantes[i].Edad}");
                Console.WriteLine($"La carrera del estudiante es: {estudiantes[i].Carrera}");
                Console.WriteLine($"La matrícula del estudiante es: {estudiantes[i].Matricula}");
            }

          
            Console.ReadLine();
        }

        
        class Estudiantes
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Carrera { get; set; }
            public string Matricula { get; set; }
        }
    }

}
