using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperatorioPrimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vacunas();
            //Estacionamiento();
            //Estacionamiento1();
            //censo();
            //Ejercicio4();
        }
        static void Vacunas()
        {
            int Stock = 1000;
            int vacunas, Desc;
            int contador = 0;
            int cantVac = 0;
            Console.WriteLine("Primer Punto de vacunas, Si desea salir apretar el 0.");
            do
            {
                Console.WriteLine("¿Cuantas vacunas desea entregar: ");
                vacunas = int.Parse(Console.ReadLine());
                cantVac = vacunas;
                if (vacunas >= 1)
                {
                    contador++;
                    Desc = Stock - vacunas;

                }
                if (Desc >= 200)
                {
                    Console.WriteLine();
                    Console.WriteLine("¡¡¡CUIDADO STOCK BAJO DE 200 UNIDADES!!!");
                    

                }



            } while (vacunas != 0);
            Console.WriteLine("La Cantidad de vacunas que quedaron en stock son {0}", Desc);
            Console.ReadKey();
        
        }
        static void Estacionamiento()
        {
            int llegada = 0, salida = 0, total = 0, monto = 0;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Ingresar la hora de entrada: ");
                llegada = int.Parse(Console.ReadLine());
                if (llegada == 1)
                {
                    monto = 75;

                }
                if (llegada >= 1)
                Console.WriteLine("Ingresar hora de salida: ");
                salida = int.Parse(Console.ReadLine());
                if (llegada < salida)
                {
                    total = salida - llegada;
                    monto = 50 + 75 * (total - 1);

                }
            }
            Console.WriteLine("La cantidad de horas son {0} y para pagar es {1}", total, monto);
            Console.ReadKey();
        }
        static void Estacionamiento1()
        {
            int pago, tiempo;
            Console.Write("Ingresa el valor de tiempo en horas: ");
            tiempo = int.Parse(Console.ReadLine());
            pago = 0;
            if (tiempo == 1)
                pago = 50;
            if (tiempo > 1)
                pago = 50 + 75 * (tiempo - 1);
            Console.WriteLine("Valor de pago: " + pago);
            Console.ReadKey();
        }
        static void censo()
        {
            int EdadM, EdadF;
            string Sexo;
            var Mayor75 = 0;
            var CantHom = 0;
            var CantMuj = 0;
            var MenoresMuj = 0;

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
                    if (EdadF >= 0 && EdadF <= 18)
                    {
                        MenoresMuj = MenoresMuj + 1;
                    }

                }
                else if (Sexo.Equals("M"))
                {
                    CantHom = CantHom + 1;
                    Console.WriteLine("¿Cual es tu edad?: ");
                    EdadM = int.Parse(Console.ReadLine());
                    if (EdadM >= 75)
                    {
                        Mayor75 = Mayor75 + 1;
                    }
                }


            } while (!Sexo.Equals("F") || !Sexo.Equals("M"));

            if (CantHom > CantMuj)
            {
                Console.WriteLine("Es menor la cantidad de Mujeres");
            }
            else if (CantMuj > CantHom)
            {
                Console.WriteLine("Es Menor la cantidad de Hombres");
            }
            else if (CantHom == CantMuj)
            {
                Console.WriteLine("La cantidad de hombres y mujeres son iguales");
            }

            if (Mayor75 > 0)
                Console.WriteLine("cantidad de hombres mayores de 75 años son {0}", Mayor75);
            if (MenoresMuj >= 0)
                Console.WriteLine("cantidad de mujeres en el colegio son {0}", MenoresMuj);


            Console.ReadKey();
        }
        static void Ejercicio4()
        {
            int numero, valor;

            Console.WriteLine("Por favor ingrese el numero: ");
            numero = int.Parse(Console.ReadLine());
            valor = numero;

            while (valor > 1)
            {
                if (valor % 2 == 0)
                {
                    valor = (valor / 2);
                    Console.WriteLine(valor + " ");
                }
                else
                {
                    valor = (valor * 3) + 1;
                    Console.WriteLine(valor + " ");
                }
            }
            Console.WriteLine("EL numero" + numero + "tiene como seguido de numero" + valor);
            Console.ReadKey();
        }

    }
}
