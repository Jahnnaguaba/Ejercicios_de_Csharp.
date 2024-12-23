using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_en_consola02
{
   
            internal class Program
        {
            static void Main(string[] args)
            {
                int totalEstudiantes = 2;

                for (int i = 1; i <= totalEstudiantes; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"Registro del estudiante {i}");
                    RegistrarEstudiante(i);
                }
            }

            static void RegistrarEstudiante(int numeroEstudiante)
            {
                Estudiante estudiante = new Estudiante();
                estudiante.Asignaturas = new List<Asignatura>();

                Console.Write("Nombre del estudiante: ");
                estudiante.Nombre = Console.ReadLine();

                Console.Write("Edad del estudiante: ");
                estudiante.Edad = int.Parse(Console.ReadLine());

                int totalAsignaturas = 3;
                for (int i = 1; i <= totalAsignaturas; i++)
                {
                    Asignatura asignatura = new Asignatura();

                    Console.Write($"Nombre de la asignatura {i}: ");
                    asignatura.Nombre = Console.ReadLine();

                    Console.Write($"Calificación de {asignatura.Nombre}: ");
                    asignatura.Calificacion = double.Parse(Console.ReadLine());

                    estudiante.Asignaturas.Add(asignatura);
                }

                MostrarRegistro(estudiante, numeroEstudiante);
            }

            static void MostrarRegistro(Estudiante estudiante, int numeroEstudiante)
            {
                Console.WriteLine($"\nRegistro del estudiante {numeroEstudiante}:");
                Console.WriteLine($"Nombre: {estudiante.Nombre}");
                Console.WriteLine($"Edad: {estudiante.Edad}");
                Console.WriteLine("Asignaturas y calificaciones:");

                double sumaCalificaciones = 0;
                foreach (var asignatura in estudiante.Asignaturas)
                {
                    Console.WriteLine($"- {asignatura.Nombre}: {asignatura.Calificacion:F2}");
                    sumaCalificaciones += asignatura.Calificacion;
                }

                double promedio = sumaCalificaciones / estudiante.Asignaturas.Count;
                Console.WriteLine($"Promedio general: {promedio:F2}");
                Console.WriteLine("Presiona una tecla para continuar...");
                Console.ReadKey();
            }
        }

        public class Estudiante
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public List<Asignatura> Asignaturas { get; set; }
        }

        public class Asignatura
        {
            public string Nombre { get; set; }
            public double Calificacion { get; set; }
        }

    }

