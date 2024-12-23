using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_en_vivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, materia;
            double nota1, nota2, nota3, nota4, promedio;
            double completivo1, completivo2, completivo3, completivo4, completivoPromedio;
            double extraordinario1, extraordinario2, extraordinario3, extraordinario4, extraordinarioPromedio;


            Console.WriteLine("Introduce el nombre del estudiante: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Introduce la materia: ");
            materia = Console.ReadLine();


            Console.WriteLine("Introduce la primera nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la tercera nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la cuarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3 + nota4) / 4.0;
            Console.Clear();


            Console.WriteLine("Nombre del estudiante: " + nombre);
            Console.WriteLine("Materia: " + materia);
            Console.WriteLine("Calificación obtenida (Normal): " + promedio);


            if (promedio >= 70)
            {
                Console.WriteLine("Situación: Aprobó");
            }
            else
            {

                Console.WriteLine("Situación: Reprobó. Debe ir a completivo.");
                Console.WriteLine("Introduce las 4 notas del completivo:");


                Console.WriteLine("Introduce la primera nota del completivo: ");
                completivo1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce la segunda nota del completivo: ");
                completivo2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce la tercera nota del completivo: ");
                completivo3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce la cuarta nota del completivo: ");
                completivo4 = double.Parse(Console.ReadLine());


                completivoPromedio = (completivo1 + completivo2 + completivo3 + completivo4) / 4.0;
                Console.Clear();


                Console.WriteLine("Nombre del estudiante: " + nombre);
                Console.WriteLine("Materia: " + materia);
                Console.WriteLine("Calificación obtenida (Completivo): " + completivoPromedio);

                if (completivoPromedio >= 70)
                {
                    Console.WriteLine("Situación: Aprobó el completivo");
                }
                else
                {

                    Console.WriteLine("Situación: Reprobó el completivo. Debe ir a extraordinario.");
                    Console.WriteLine("Introduce las 4 notas del extraordinario:");


                    Console.WriteLine("Introduce la primera nota del extraordinario: ");
                    extraordinario1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce la segunda nota del extraordinario: ");
                    extraordinario2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce la tercera nota del extraordinario: ");
                    extraordinario3 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Introduce la cuarta nota del extraordinario: ");
                    extraordinario4 = double.Parse(Console.ReadLine());


                    extraordinarioPromedio = (extraordinario1 + extraordinario2 + extraordinario3 + extraordinario4) / 4.0;
                    Console.Clear();


                    Console.WriteLine("Nombre del estudiante: " + nombre);
                    Console.WriteLine("Materia: " + materia);
                    Console.WriteLine("Calificación obtenida (Extraordinario): " + extraordinarioPromedio);

                    if (extraordinarioPromedio >= 70)
                    {
                        Console.WriteLine("Situación: Aprobó el extraordinario");
                    }
                    else
                    {
                        Console.WriteLine("Situación: Reprobó el extraordinario");
                    }
                }
            }
        }
    }
}
     