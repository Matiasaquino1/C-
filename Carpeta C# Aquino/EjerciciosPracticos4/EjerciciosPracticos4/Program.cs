using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intervalo();
            //empleado();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
            //Ejercicio8();
        }
        static private void intervalo()
        {
            float[] numero = new float[3];
            float mayor = 0, menor = 0;
            int i, flag = 0, noingreso = 0;

            for (i = 0; i < 3; i++)
            {
                Console.Write("{0}º número:", i + 1);
                numero[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayor = numero[i];
                    menor = numero[i];
                    flag = 1;
                }
                else
                {
                    if (numero[i] > mayor)
                        mayor = numero[i];
                    if (numero[i] < menor)
                        menor = numero[i];
                }
            }

            for (i = 0; i < 3; i++)
            {
                if (numero[i] != mayor && numero[i] != menor)
                {
                    Console.Write("El número {0} esta entre el {1} y el {2}", numero[i], menor, mayor);
                    noingreso = 1;
                }
            }
            if (noingreso == 0)
                Console.Write("Error.Hay numeros repetidos");

            Console.Read();
        }
        static private void empleado()
        {

            string nombre = "";
            var antiguedad = 0;
            int CantHoras = 0;
            int Valor = 0;
            int cobro = 0;
            int cobro2 = 0;
            int total = 0;
            int porcentaje = 0;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Valor hora del empleado: ");
                Valor = int.Parse(Console.ReadLine());
                if (Valor >= 1)
                {
                    Console.WriteLine("Ingresar Nombre: ");
                    nombre = Console.ReadLine();
                    if (!nombre.Equals(""))
                    {
                        Console.WriteLine("Ingresar antiguedad: ");
                        antiguedad = int.Parse(Console.ReadLine());
                        if (antiguedad >= 1)
                        {
                            Console.WriteLine("Ingresar cantidad de horas: ");
                            CantHoras = int.Parse(Console.ReadLine());
                            if (CantHoras >= 1)
                            {
                                cobro = Valor * CantHoras;
                                cobro2 = antiguedad * 30;
                                total = cobro + cobro2;
                                porcentaje = total * 13 / 100;

                            }
                        }
                    }
                }

            }
            Console.WriteLine("EL nombre es {0}, la antiguedad es {1}, el valor de hora es {2}", nombre, antiguedad, Valor);
            Console.WriteLine("El total a cobrar en bruto es {0}, el total de descuentos es 13%, y el valor neto a cobrar es: {1}", cobro, porcentaje);
            Console.ReadKey();
        }
        static void Ejercicio3()
        {
            int num1 = 0;
            int num2 = 0;
            int contador = 0;
            int pares = 0;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            while (num1 < num2)
            {
                num1++;
                Console.WriteLine("Numeros naturales: " + num1);
                contador++;
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("Numeros pares: " + num1);
                    pares++;
                }
            } while (num1 > num2)
            {
                num2++;
                Console.WriteLine("Numeros naturales: " + num2);
                contador++;
                if (num2 % 2 == 0)
                {
                    Console.WriteLine("Numeros pares: " + num2);
                    pares++;
                }
            }
            Console.ReadKey();
        }

        static void Ejercicio4()
        {
            int NumLegajo1 = 0;
            int NumLegajo2 = 0;
            int NumLegajo3 = 0;
            int NumLegajo4 = 0;
            int NumLegajo5 = 0;
            int NumLegajo6 = 0;
            int NumLegajo7 = 0;
            int NumLegajo8 = 0;
            int NumLegajo9 = 0;
            int NumLegajo10 = 0;
            int sueldo1 = 0;
            int sueldo2 = 0;
            int sueldo3 = 0;
            int sueldo4 = 0;
            int sueldo5 = 0;
            int sueldo6 = 0;
            int sueldo7 = 0;
            int sueldo8 = 0;
            int sueldo9 = 0;
            int sueldo10 = 0;
            var sexo1 = 0;
            var sexo2 = 0;
            var sexo3 = 0;
            var sexo4 = 0;
            var sexo5 = 0;
            var sexo6 = 0;
            var sexo7 = 0;
            var sexo8 = 0;
            var sexo9 = 0;
            var sexo10 = 0;
            int ContFem = 0;
            var ContMas = 0;
            var Con500Muj = 0;
            var Con400Mas = 0;

            for (int i = 0; i < 9; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("1° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo1 = int.Parse(Console.ReadLine());
                    if (NumLegajo1 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo1 = int.Parse(Console.ReadLine());
                        if (sueldo1 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo1 = int.Parse(Console.ReadLine());
                            if (sexo1 == 1)
                            {
                                ContFem++;
                                sueldo1 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo1 -= 400;
                                Con400Mas++;

                            }
                        }
                    }
                }
                if (i == 1)
                {
                    Console.WriteLine("2° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo2 = int.Parse(Console.ReadLine());
                    if (NumLegajo2 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo2 = int.Parse(Console.ReadLine());
                        if (sueldo2 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo1 = int.Parse(Console.ReadLine());
                            if (sexo2 == 1)
                            {
                                ContFem++;
                                sueldo2 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo2 -= 400;
                                Con400Mas++;

                            }
                        }
                    }

                }
                if (i == 2)
                {
                    Console.WriteLine("3° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo3 = int.Parse(Console.ReadLine());
                    if (NumLegajo3 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo3 = int.Parse(Console.ReadLine());
                        if (sueldo3 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo3 = int.Parse(Console.ReadLine());
                            if (sexo3 == 1)
                            {
                                ContFem++;
                                sueldo3 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo3 -= 400;
                                Con400Mas++;

                            }
                        }
                    }
                }
                if (i == 3)
                {
                    Console.WriteLine("4° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo4 = int.Parse(Console.ReadLine());
                    if (NumLegajo4 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo4 = int.Parse(Console.ReadLine());
                        if (sueldo4 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo4 = int.Parse(Console.ReadLine());
                            if (sexo4 == 1)
                            {
                                ContFem++;
                                sueldo4 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo4 -= 400;
                                Con400Mas++;

                            }
                        }
                    }
                }
                if (i == 4)
                {
                    Console.WriteLine("5° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo5 = int.Parse(Console.ReadLine());
                    if (NumLegajo5 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo5 = int.Parse(Console.ReadLine());
                        if (sueldo5 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo5 = int.Parse(Console.ReadLine());
                            if (sexo5 == 1)
                            {
                                ContFem++;
                                sueldo5 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo5 -= 400;
                                Con400Mas++;

                            }
                        }
                    }
                }
                if (i == 5)
                {
                    Console.WriteLine("6° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo6 = int.Parse(Console.ReadLine());
                    if (NumLegajo6 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo6 = int.Parse(Console.ReadLine());
                        if (sueldo6 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo6 = int.Parse(Console.ReadLine());
                            if (sexo6 == 1)
                            {
                                ContFem++;
                                sueldo6 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo6 -= 400;
                                Con400Mas++;

                            }
                        }
                    }
                }
                if (i == 6)
                {
                    Console.WriteLine("7° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo7 = int.Parse(Console.ReadLine());
                    if (NumLegajo7 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo7 = int.Parse(Console.ReadLine());
                        if (sueldo7 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo7 = int.Parse(Console.ReadLine());
                            if (sexo7 == 1)
                            {
                                ContFem++;
                                sueldo7 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo7 -= 400;
                                Con400Mas++;

                            }
                        }
                    }
                }
                if (i == 7)
                {
                    Console.WriteLine("8° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo8 = int.Parse(Console.ReadLine());
                    if (NumLegajo8 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo8 = int.Parse(Console.ReadLine());
                        if (sueldo8 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo8 = int.Parse(Console.ReadLine());
                            if (sexo8 == 1)
                            {
                                ContFem++;
                                sueldo8 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo8 -= 400;
                                Con400Mas++;

                            }
                        }
                    }

                }

                if (i == 8)
                {
                    Console.WriteLine("9° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo9 = int.Parse(Console.ReadLine());
                    if (NumLegajo9 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo1 = int.Parse(Console.ReadLine());
                        if (sueldo9 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo9 = int.Parse(Console.ReadLine());
                            if (sexo9 == 1)
                            {
                                ContFem++;
                                sueldo9 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo9 -= 400;
                                Con400Mas++;

                            }
                        }
                    }
                }
                if (i == 9)
                {
                    Console.WriteLine("10° empleado");
                    Console.WriteLine("Numero de legajo: ");
                    NumLegajo10 = int.Parse(Console.ReadLine());
                    if (NumLegajo10 >= 1)
                    {
                        Console.WriteLine("Sueldo: ");
                        sueldo10 = int.Parse(Console.ReadLine());
                        if (sueldo10 >= 0)
                        {
                            Console.WriteLine("1.Femenino 2.Masculino");
                            sexo10 = int.Parse(Console.ReadLine());
                            if (sexo10 == 1)
                            {
                                ContFem++;
                                sueldo10 += 500;
                                Con500Muj++;
                            }
                            else
                            {
                                ContMas++;
                                sueldo10 -= 400;
                                Con400Mas++;

                            }
                        }
                    }
                }

            }
            Console.WriteLine("La cantidad de hombres con sueldo -400:{0} ", Con400Mas);
            Console.WriteLine("La cantidad de mujeres con sueldo +500:{0} ", Con500Muj);
            Console.ReadKey();
        }
        static void Ejercicio5()
        {
            int band = 0, i = 0, mayordia = 0, menordia = 0, x = 30;
            int[] dia = new int[x];
            float menor = 0, mayor = 0, promedio = 0, contadoragua = 0;
            float[] agua = new float[x];

            do
            {
                Console.WriteLine("ingrese el dia: ");
                dia[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de agua caida: ");
                agua[i] = float.Parse(Console.ReadLine());

                if (band == 0)
                {
                    mayordia = dia[i];
                    menordia = dia[i];
                    mayor = agua[i];
                    menor = agua[i];
                    band = 1;
                }
                else
                {
                    if (agua[i] > mayor)
                    {
                        mayordia = dia[i];
                        mayor = agua[i];
                    }
                    if (agua[i] < menor)
                    {
                        menordia = dia[i];
                        menor = agua[i];
                    }

                }
                contadoragua += agua[i];
            } while (i > x);
            promedio = contadoragua / i;
            if (menor == mayor)
            {
                Console.WriteLine("en este mes el agua caida fue igual todos los dias {0}", menor);
            }
            else
            {
                Console.WriteLine("La mayor cantidad de agua caida fue de {0} milimetros", mayor);
                Console.WriteLine("La menor cantidad de agua caida fue de {0} milimetros", menor);
                
            }
            Console.WriteLine("El promedio de agua caida en {0} dias es de {1}", x, promedio);
            Console.ReadKey();

   
            
        }
        static void Ejercicio6()
        {
            int[] primer = new int[5];
            int mayor = 0, menor = 0, band = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Introduzca el numero: ", i+1);
                primer[i] = int.Parse(Console.ReadLine());
                if (band == 0)
                {
                    mayor = primer[i];
                    menor = primer[i];
                    band = 1;
                }
                else
                {
                    if (primer[i] > mayor)
                        mayor = primer[i];
                    if (primer[i] < menor)
                        menor = primer[i];
                }

            }
            if (mayor == menor)
                Console.WriteLine("Los numeros son todos iguales");
            else
                Console.WriteLine("el menor de los 5 numeros es el {0} y el mayor es el {1}", menor, mayor);
            Console.ReadKey();
                
        }
        static void Ejercicio7()
        {
            int num = 0;
            int cuadrado = 0;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("ingrese el numero: ");
                num = int.Parse(Console.ReadLine());
                if (num >= 1)
                {
                    cuadrado = num * num;
                }
                else
                {
                    Console.WriteLine("ERROR. Volver a ingresar");
                    num = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("El cuadrado de {0} es {1}", num, cuadrado);
            Console.ReadKey();
        }
        static void Ejercicio8()
        {
            int PesosArg = 0, Dolares = 132 , Euros = 134;
            var cambio = 0;
            var cambioDol = 0;
            var cambioEur = 0;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Posee 1.Dolares o 2.Euros para pasar a PesosArg");
                cambio = int.Parse(Console.ReadLine());
                if (cambio == 1)
                {
                    Console.WriteLine("Usted eligio Dolares");
                    Console.WriteLine("Cantidad de dolares a convertir: ");
                    PesosArg = int.Parse(Console.ReadLine());
                    if (PesosArg >= 1)
                    {
                        cambioDol = PesosArg * Dolares;
                    }

                }
                else
                {
                    Console.WriteLine("Usted eligio Euros");
                    Console.WriteLine("Cantidad de Euros a convertir: ");
                    PesosArg = int.Parse(Console.ReadLine());
                    if (PesosArg >= 1)
                    {
                        cambioEur = PesosArg * Euros;
                    }
                                                        
                }
            }
            Console.WriteLine("Cantidad de dolares {0} convertido a pesos {1}", PesosArg, cambioDol);
            Console.WriteLine("Cantidad de euros {0} convertido a pesos {1}", PesosArg, cambioEur);
            Console.ReadKey();
        }
        
    }           
}
        

    

