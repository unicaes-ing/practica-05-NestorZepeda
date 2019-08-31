using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica5
{
    class Program
    {
        

        
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la practica");
            Console.WriteLine("1-)practica 1");
            Console.WriteLine("2-)practica 2");
            Console.WriteLine("3-)practica 3");
            Console.WriteLine("4-)practica 4");
            Console.WriteLine("5-)practica 5");
            Console.WriteLine("6-)practica 6");
            Console.WriteLine();
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {

                case 1:
                    DateTime fecha = DateTime.Today;
                    int dias;
                    dias = diasfindeanio(fecha);
                    Console.WriteLine("Dias para que el año termine: " + dias);
                    break;
                case 2:
                    int numero = 0;
                    Console.WriteLine("Coloque un numero");
                    numero = Convert.ToInt32(Console.ReadLine());
                    ejercicio_2(numero);
                    break;
                case 3:
                    int num = 0;
                    Console.WriteLine("Inserta el numero:");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine(ejercicio_3(num));
                    break;
                case 4:
                    string tel1, tel2, tel3, tel4;
                    tel1 = string.Format("{0:(###) ####-####}", 5037271 - 0000);
                    tel2 = string.Format("{0:(###) ####-####}", 5037271 - 0000);
                    tel3 = string.Format("{0:(###) ####-####}", 5037271 - 0000);
                    tel4 = string.Format("{0:(###) ####-####}", 5037271 - 0000);
                    Console.WriteLine("Coloque el primer telefono ");
                    tel1 = Console.ReadLine();
                    Console.WriteLine("Coloque el segundo telefono ");
                    tel2 =Console.ReadLine();
                    Console.WriteLine("Coloque el tercer telefono ");
                    tel3 = Console.ReadLine();
                    Console.WriteLine("Coloque el cuarto telefono ");
                    tel4 = Console.ReadLine();
                    Console.WriteLine("El numero ganador es: " + ejercicio_4(tel1, tel2, tel3, tel4));
                    break;
                case 5:
                    decimal porcentaje, precio;
                    Console.WriteLine("precio de la compra");
                    precio =Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Coloque el porcentaje de descuento");
                    porcentaje =Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Total a pagar: {0} ", ejercicio_5(precio, porcentaje));
                    break;
                case 6:
                    double suma = 0;

                    Console.WriteLine("Cuantos alumnos seran?");
                    int alumnos = Convert.ToInt32(Console.ReadLine());
                    double[] Notas = new double[alumnos];
                    for (int i = 0; i < Notas.Length; i++)
                    {
                        Console.WriteLine("Coloque la nota del alumno " + (i + 1));
                        double nota = Convert.ToDouble(Console.ReadLine());
                        Notas[i] = nota;
                        suma = suma + Notas[i];
                    }
                    Console.WriteLine("El promedio es: " + ejercicio_6(Notas));
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            


            
        }
       // ejercicio 1
        static int diasfindeanio(DateTime fecha)
        {
            DateTime finanio = new DateTime(2019, 12, 31);
            TimeSpan dias = finanio - fecha;
            int diasfindeanio;
            return diasfindeanio = dias.Days;

        }

       

        //ejercicio 2
        static int ejercicio_2(int numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                if (numero > 0)
                {
                    Console.WriteLine("El numero es positivo");
                }
                else
                {
                    if (numero == 0)
                    {
                        Console.WriteLine("El numero es cero");
                    }
                }
            }

            return numero;
        }

   
        //ejercicio 3 
      
        static int ejercicio_3(int nu)
        {
            int resultado = 1;
            for (int i = nu; i > 0; i--)
            {
                Console.WriteLine(nu + "*" + i + "=" + nu * i + "    ");
                resultado *= i;
            }
            return resultado;
        }
       

      //ejercicio 4
        static string ejercicio_4(string tel1, string tel2,string tel3, string tel4)
        {
           
            string ganador = "";
            int aleatorio;
            Random ale = new Random();
            aleatorio = ale.Next(1, 4);

            if (aleatorio == 1)
            {
                ganador = tel1;
            }
            else
            {
                if (aleatorio == 2)
                {
                    ganador = tel2;
                }
                else
                {
                    if (aleatorio == 3)
                    {
                        ganador = tel3;
                    }
                    else
                    {
                        if (aleatorio == 4)
                        {
                            ganador = tel4;
                        }
                    }
                }

            }

            return ganador;
        }
      

        //ejercicio 5
        static decimal ejercicio_5(decimal precio, decimal porcentaje = 0.01m)
        {
           decimal descuento = 0.00m, totalPagar = 0.00m;
            descuento = precio * porcentaje;
            totalPagar = precio - descuento;
            return totalPagar;
        }
      
        //ejercicio 6
       
        static double ejercicio_6(double[] notas)
        {

            double promedio ;
           double suma = 0;
            

            for (int i = 0; i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }
            promedio = suma / notas.Length;

            return promedio;
        }
     
    }
}
