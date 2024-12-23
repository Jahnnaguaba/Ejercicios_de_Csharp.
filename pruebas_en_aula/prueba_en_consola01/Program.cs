using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_en_consola01
{
    using System;

    class Teatro
    {
        static void Main()
        {
          
            char[,] asientos = new char[10, 10];

          
            for (int fila = 0; fila < 10; fila++)
                for (int asiento = 0; asiento < 10; asiento++)
                    asientos[fila, asiento] = 'L';

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Ver asientos\n2. Reservar asiento\n3. Salir");
                Console.Write("Elige una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                   
                    for (int fila = 0; fila < 10; fila++)
                    {
                        for (int asiento = 0; asiento < 10; asiento++)
                            Console.Write(asientos[fila, asiento] + " ");
                        Console.WriteLine();
                    }
                }
                else if (opcion == 2)
                {
                    
                    Console.Write("Fila (1-10): ");
                    int fila = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Asiento (1-10): ");
                    int asiento = int.Parse(Console.ReadLine()) - 1;

                    if (fila < 0 || fila >= 10 || asiento < 0 || asiento >= 10)
                        Console.WriteLine("Fila o asiento inválido.");
                    else if (asientos[fila, asiento] == 'X')
                        Console.WriteLine("Asiento ya ocupado.");
                    else
                    {
                        asientos[fila, asiento] = 'X';
                        Console.WriteLine("Asiento reservado.");
                    }
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("¡Gracias por usar el sistema!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                Console.WriteLine("Presiona una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

}
