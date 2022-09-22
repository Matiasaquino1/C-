using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{       

    internal class Program
    {
        static void Main(string[] args)
        {
            float cont = 0;
            float x = 0;
            string compras;
            Console.WriteLine("ingrese el total de la compra // 0 para salir");
            compras = Console.ReadLine();
            float importe = float.Parse(compras);
            while (importe != 0)
            {
                if (importe > 0)
                {

                    x += importe;
                    cont++;
                                    
                }
                Console.WriteLine("ingrese el total de la compra // 0 para salir");
                compras = Console.ReadLine();
                importe = float.Parse(compras);   
            }         
            if (x >= 1000)
            {
                Console.WriteLine("Cupon de 10%");
                float desc = importe;
                desc = importe * 10 / 100;
                Console.WriteLine("el descuento total: ");

            }

            

                

       
        }
    

     }
}







