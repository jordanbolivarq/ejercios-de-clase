using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese componente X1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese componente Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese componente X2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("ingrese componente Y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double m = (y2 - y1) / (x2 - x1);
            Console.WriteLine("pendiente = " + m);

            double b = y1 - (x1 * m);
            Console.WriteLine("intercepto = " + b);

            double d = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));
            Console.WriteLine("distancia = " + d);
        }
    }
}
