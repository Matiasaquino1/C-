using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Censo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  EdadM, EdadF;
            string Sexo;
            var Mayor80 = 0;
            var CantHom = 0;
            var CantMuj = 0;
            var EdadEscolar = 0;

            Console.WriteLine("coloque su sexo y edad");

            do
            {
                Console.WriteLine("¿Cual es su Sexo?: (M/F)");
                Sexo = Console.ReadLine();
                if (Sexo.Equals("F"))
                {
                    CantMuj = CantMuj + 1;
                    Console.WriteLine("¿Cual es tu edad?: ");
                    EdadF = int.Parse(Console.ReadLine());
                    if (EdadF >= 4 && EdadF <= 18)
                    {
                        EdadEscolar = EdadEscolar + 1;
                    }

                }
                else if (Sexo.Equals("M"))
                {
                    CantHom = CantHom + 1;
                    Console.WriteLine("¿Cual es tu edad?: ");
                    EdadM = int.Parse(Console.ReadLine());
                    if (EdadM >= 80)
                    {
                        Mayor80 = Mayor80 + 1;
                    }
                }


            } while (Sexo.Equals("F") || Sexo.Equals("M"));

                     
                if (CantHom > CantMuj)
                {
                Console.WriteLine("Es mayor la cantidad de Hombres");
                }
                else if (CantMuj > CantHom)
                {
                Console.WriteLine("Es mayor la cantidad de Mujeres");
                }
                else if (CantHom == CantMuj)
                {
                Console.WriteLine("La cantidad de hombres y mujeres son iguales");
                }
                if (Mayor80 > 0)
                Console.WriteLine("cantidad de hombres mayores de 80 años son {0}", Mayor80);
            if (EdadEscolar > 0)
                Console.WriteLine("cantidad de mujeres en el colegio son {0}", EdadEscolar);


            Console.ReadKey();


           
        }
    }
}
