using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_clases_objetos06
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Boleto boleto = new Boleto();

            
            Console.WriteLine("Generador de boletos de transporte:");
            Console.Write("Ingresa el destino: ");
            string destino = Console.ReadLine();

            Console.Write("Ingresa la distancia en kilómetros: ");
            double distancia = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Selecciona el tipo de transporte:");
            Console.WriteLine("1. Autobús (terrestre)");
            Console.WriteLine("2. Tren (terrestre)");
            Console.WriteLine("3. Avión (aéreo)");
            Console.Write("Tu elección: ");
            int tipo = Convert.ToInt32(Console.ReadLine());

            
            boleto.CalcularDetalles(tipo, distancia);

            Console.WriteLine("\n--- Detalles del Boleto ---");
            Console.WriteLine($"Destino: {destino}");
            Console.WriteLine($"Distancia: {distancia} km");
            Console.WriteLine($"Tipo de transporte: {boleto.TipoTransporte}");
            Console.WriteLine($"Tiempo estimado: {boleto.Tiempo:F2} horas");
            Console.WriteLine($"Costo del boleto: ${boleto.Costo:F2}");
            Console.ReadLine();
        }
    }

  
    public class Boleto
    {
        public string TipoTransporte { get; private set; }
        public double Costo { get; private set; }
        public double Tiempo { get; private set; }

       
        public void CalcularDetalles(int tipo, double distancia)
        {
            switch (tipo)
            {
                case 1:
                    TipoTransporte = "Autobús";
                    Costo = distancia * 0.5; 
                    Tiempo = distancia / 50; 
                    break;

                case 2:
                    TipoTransporte = "Tren";
                    Costo = distancia * 0.7; 
                    Tiempo = distancia / 80; 
                    break;

                case 3:
                    TipoTransporte = "Avión";
                    Costo = distancia * 1.2; 
                    Tiempo = distancia / 600; 
                    break;

                default:
                    throw new Exception("Tipo de transporte inválido.");
            }
        }
    }

}
