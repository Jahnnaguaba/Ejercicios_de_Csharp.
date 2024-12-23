using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_clases_objetos02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistrarAnimal(new Perro());
            RegistrarAnimal(new Gato());
        }

        static void RegistrarAnimal(Animal animal)
        {
            Console.Write("Introduce el nombre del animal: ");
            animal.nombre = Console.ReadLine();

            Console.Write("Introduce la edad del animal: ");
            animal.edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la raza del animal: ");
            animal.raza = Console.ReadLine();

            Console.WriteLine($"El nombre del animal es: {animal.nombre}, la edad es: {animal.edad}, la raza es: {animal.raza}");
            animal.MakeSound();
        }
    }

    public class Animal
    {
        public string nombre;
        public int edad;
        public string raza;

        public virtual void MakeSound() { }
    }

    public class Perro : Animal
    {
        public override void MakeSound() => Console.WriteLine("Wuaf!");
    }

    public class Gato : Animal
    {
        public override void MakeSound() => Console.WriteLine("Miau!");
    }

}
