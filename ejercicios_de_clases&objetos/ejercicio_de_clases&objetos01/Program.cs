using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_clases_objetos01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispositivo dispositivo = new Dispositivo();
            Console.Write("escriba el tipo de dispositivo: ");
            dispositivo.tipo = Console.ReadLine();

            Console.Write("escriba el color del dispositivo: ");
            dispositivo.color = Console.ReadLine();

            Console.Write("escriba la marca del dispositivo: ");
            dispositivo.marca = Console.ReadLine();

            dispositivo.tirarfotos();
            dispositivo.hacerllamadas();
        }

        internal class Dispositivo
        {
            public string tipo { get; set; }
            public string color { get; set; }
            public string marca { get; set; }

            public void tirarfotos()
            {
                Console.WriteLine("este dispositivo puede tomar fotos.");

            }
            public void hacerllamadas()

            {
                Console.WriteLine("este dispositivo puede hacer llamadas");
            }
        }
    }
}
