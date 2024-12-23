using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_clases_objetos03
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Articulo1();
                Articulo2();
            }

            static void Articulo1()
            {
                Articulos articulo1 = new Articulos();

                Console.Write("Ingresa el nombre del articulo: ");
                articulo1.Nombre = Console.ReadLine();

                Console.Write("Ingresa el precio del articulo: ");
                articulo1.Precio = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa la categoria del articulo: ");
                articulo1.Categoria = Console.ReadLine();

                Console.Write($"El nombre del articulo es: {articulo1.Nombre}, el precio del articulo es: {articulo1.Precio} y la categoria del articulo es:" +
                    $" {articulo1.Categoria}");
                Console.ReadLine();
                Console.WriteLine("");
            }

            static void Articulo2()
            {
                Articulos articulo2 = new Articulos();

                Console.Write("Ingresa el nombre del segundo articulo: ");
                articulo2.Nombre = Console.ReadLine();

                Console.Write("Ingresa el precio del segundo articulo: ");
                articulo2.Precio = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa la categoria del segundo articulo: ");
                articulo2.Categoria = Console.ReadLine();

                Console.Write($"El nombre del articulo es: {articulo2.Nombre}, el precio del articulo es: {articulo2.Precio}$ y la categoria del articulo es:" +
                    $" {articulo2.Categoria}");
                Console.ReadLine();
            }

            public class Articulos
            {
                public string Nombre { get; set; }

                public int Precio { get; set; }

                public string Categoria { get; set; }
            }
        }
    }

