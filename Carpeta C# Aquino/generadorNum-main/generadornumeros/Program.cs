using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generadornumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero '1' para generar los numeros aleatorios hasta sumar 500 o mas");
            var opcion = Console.ReadLine();
            if (opcion.Equals("1"))
            {
                var sumacumulada = 0;
                int NumGenerado = 0;
                var contadorde0 = 0;
                var contadorde10y100 = 0;
                var acumulador150 = 0;
                var contador150 = 0;
                Random random1 = new Random();

                do
                {
                    NumGenerado = random1.Next(0, 200);
                    sumacumulada += NumGenerado;
                    if (NumGenerado == 0)
                    {
                        contadorde0 = contadorde0 + 1;
                    }
                    if (NumGenerado >= 10 && NumGenerado <= 100)
                    {
                        contadorde10y100 += NumGenerado;
                    }
                    if (NumGenerado < 150)
                    {
                        acumulador150 += NumGenerado;
                        contador150 = contador150 + 1;
                    }
                } while (sumacumulada <= 500);

                Console.WriteLine("La cantidad de (0) son: {0}", contadorde0);
                Console.WriteLine("La suma de numeros entre 10 y 100 son {0}", contadorde10y100);
                Console.WriteLine("El promedio de los N° menores de 150 es: {0}", (acumulador150 / contador150));

                Console.ReadKey();


            }


        }
    }
}
