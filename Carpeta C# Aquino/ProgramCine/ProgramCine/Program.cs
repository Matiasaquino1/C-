using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCine
{
    internal class Program
    {
        public static int TotalFunciones { get; private set; }
        public static int TotalDescuentos { get; private set; }

        static void Main(string[] args)
        {
            int espect = 0, fun = 0;
            int entr = 75, entrDesc = 50;
            int desc;
            



            do
            {
                Console.Write("Total de espectadores: ");
                espect = int.Parse(Console.ReadLine());
                if (espect >= 1) ++fun;
                {
                    Console.WriteLine("¿la funion es con descuento?: (1)SI /  (2)NO");

                }
                
                desc = int.Parse(Console.ReadLine());
                if (desc == 1)
                    entrDesc + espect;
                
            
                    

                



                    

            } while (espect != 0);

        }
    }
}
