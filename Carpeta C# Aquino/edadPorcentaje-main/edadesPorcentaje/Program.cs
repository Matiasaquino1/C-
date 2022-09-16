using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edadesPorcentaje
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int  f, edad;
            string edades;
            var menor18 = 0;
            var mayor18 = 0;
            var acumuladorMas18 = 0;
            var acumuladorMenos18 = 0;

            for (f = 1; f <= 10; f++)
            {
                Console.Write("Ingrese la edad: ");
                edades = Console.ReadLine();
                edad = int.Parse(edades);
                if (edad >= 1 && edad <= 18)
                {
                    acumuladorMenos18 += edad; 
                    menor18 = menor18 + 1;
                }
                else if (edad >= 18)
                {
                    acumuladorMas18 += edad;
                    mayor18 = mayor18 + 1;
                }
                else
                {
                    Console.WriteLine("Ponga algun valor valido");
                }
            }
            Console.Write("Cantidad de menores: {0%]");
            Console.WriteLine(acumuladorMenos18/menor18);
            Console.Write("Cantidad de mayores: {0%}");
            Console.Write(acumuladorMas18/mayor18);
            Console.ReadKey();
            

            
        }
    }
}
