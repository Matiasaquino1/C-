using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrimoNum();
            MantenimientoPc();
            Matematica();
        }

        static void PrimoNum()
        {
            int numero = 0;
            bool result;

            Program ob = new Program();

            Console.Write("Introduce un número: ");
            numero = int.Parse(Console.ReadLine());

            result = ob.esPrimo(numero);

            Console.WriteLine();
            Console.WriteLine("El {0} {1}", numero, (result ? "es primo" : "no es primo"));
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }


        private bool esPrimo(int numero)
        {
            int divisor = 2;
            int resto = 0;
            while (divisor < numero)
            {
                resto = numero % divisor;
                if (resto == 0)
                {
                    return false;
                }
                divisor = divisor + 1;
            }
            return true;
        }

        static void MantenimientoPc()
        {

            var TiempoHW = 0;
            var acumuladorHW = 0;
            var TiempoSW = 0;
            var acumuladorSW = 0;
            string Salir;
            int ID = 0;
            var causa = 0;
            var ProblemaHW = 0;
            var ProblemaSW = 0;

            Console.WriteLine("introduce los datos o (S) para salir");

            do
            {
                Console.Write("¿Desea salir?: (S/NO)");
                Salir = Console.ReadLine();
                if (Salir.Equals("NO"))
                {

                    Console.WriteLine("Numero de identificacion de pc: ");
                    ID = int.Parse(Console.ReadLine());
                    if (ID >= 0)
                    {
                        Console.WriteLine("1- problema de hw, 2- problema de sw");
                        causa = int.Parse(Console.ReadLine());
                        if (causa == 1)
                        {
                            Console.WriteLine("Tiempo de reparacion estimado: ");
                            TiempoHW = int.Parse(Console.ReadLine());
                            if (TiempoHW >= 0)
                            {
                                TiempoHW += acumuladorHW;
                                ProblemaHW = ProblemaHW + 1;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Tiempo de reparacion estimado: ");
                            TiempoSW = int.Parse(Console.ReadLine());
                            if (TiempoSW >= 0)
                            {
                                TiempoSW += acumuladorSW;
                                ProblemaSW = ProblemaSW + 1;

                            }

                        }
                    }





                }
            } while (Salir.Equals("S"));
            Console.WriteLine("promedio de tiempo de reparacion de hw: {0}", (ProblemaHW / TiempoHW));
            Console.WriteLine("Promedio de tiempo de reparacion de sw: {0}", (ProblemaSW / TiempoSW));
            Console.WriteLine("Tiempo utilizado para resolver los problemas: {0}", (TiempoHW + TiempoSW));

            Console.ReadKey();

        }



        static void Matematica()
        {
            int asistencia, Notas, Comision;
            var PromedioGeneral = 0;
            var asistencia1 = 0;
            var asistencia2 = 0;
            var asistencia3 = 0;
            var asistencia4 = 0;
            var asistencia5 = 0;
            var Notas1 = 0;
            var Notas2 = 0;
            var Notas3 = 0;
            var Notas4 = 0;
            var Notas5 = 0;

            Console.WriteLine("(1) 1° comision (2) 2° comision");
            Console.WriteLine("(3) 3° comision (4) 4° comision");
            Console.WriteLine("(5) 5° comision (6) 6° Salir");

            do
            {
                Console.WriteLine("Ingrese a que comision pertence para poder agregar nota: ");
                Comision = int.Parse(Console.ReadLine());
                if (Comision == 1)
                {
                    Console.WriteLine("Ingrese total de asistencia: ");
                    asistencia1 = int.Parse(Console.ReadLine());
                    if (asistencia1 >= 1)
                    {
                        Console.WriteLine("Ingrese la nota del alumno: ");
                        Notas1 = int.Parse(Console.ReadLine());
                        if (Notas1 >= 1)
                        {
                            

                        }
                    }
                }

            }

              



        }
    }
}  


    




        
        
    


