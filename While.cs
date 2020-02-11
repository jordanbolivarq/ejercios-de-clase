using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double total = 0;
            Console.WriteLine("ingrese numero de datos: ");
            int n = int.Parse(Console.ReadLine());
            int contador = 0;
            int max = 0;
            int min = 0;
            string nombreMax = "";
            string nombreMin = "";


            while (contador < n)
            {
                Console.WriteLine("edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("nombre: ");
                string nombre = (Console.ReadLine());
                if (contador == 0)
                {
                    max = edad;
                    min = edad;
                }
                if (edad < min)
                {
                    min = edad;
                    nombreMin = nombre;
                }

                if (edad > max)
                {
                    max = edad;
                    nombreMax = nombre;
                }

                total += edad;
                contador++;
            }

            double promedio = total / n;
            Console.WriteLine("promedio: " + promedio);
            Console.WriteLine("maximo: " + max + " " + nombreMax);
            Console.WriteLine("minimo: " + min + " " + nombreMin);
        }

    }
}
