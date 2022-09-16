using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ruleta = 0, f = 0;
            string rule;
            var contadorCero = 0;
            var ContadorPar = 0;
            var acumuladorPar = 0;
            var Contadorimpar = 0;
            var acumularimpar = 0;

            Random ranNum = new Random();

            for (f = 0; f <= 6; f++)
            {
                Console.WriteLine("Los numeros de la ruleta son: {0}", ranNum.Next(0, 36)); f++;
                rule = Console.ReadLine();
                ruleta = int.Parse(rule);
                if (ruleta % 2 == 0)
                {
                    acumuladorPar += ruleta;
                    ContadorPar++;
                }
                else if (ruleta % 2 != 0)
                {
                    acumularimpar += ruleta;
                    Contadorimpar++;
                }
                else if (ruleta == 0)
                {
                    contadorCero = contadorCero + 1;
                }

            }while (f == 5)
            Console.WriteLine("La cantidad de (0) son: {0}", contadorCero);
            Console.WriteLine("El porcentaje de numeros pares es: {0}", (acumuladorPar / ContadorPar));
            Console.WriteLine("El porcentaje de numeros impares es: {0}", (acumularimpar / Contadorimpar));

            Console.ReadKey();
        }
    }
}
