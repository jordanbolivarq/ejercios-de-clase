using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.Write("ingrese a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminante = ((Math.Pow(b, 2)) - (4 * a * c));

            if (discriminante < 0)
            {
                Console.WriteLine("Sin solucion ");
            }
            else if (discriminante == 0)
            {
                double solucion = ((b * (-1)) / (2 * a));
                Console.WriteLine("una solucion: " + solucion);
            }
            else
            {
                double solucion1 = (((b * (-1)) + Math.Sqrt(discriminante)) / (2 * a));
                double solucion2 = (((b * (-1)) - Math.Sqrt(discriminante)) / (2 * a));
                Console.WriteLine("2 soluciones: ");
                Console.WriteLine(solucion1);
                Console.WriteLine(solucion2);
            }
        }
    }
}
