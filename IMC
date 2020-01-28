using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.Write("ingrese su estatura: ");
            double estatura = double.Parse(Console.ReadLine());
            Console.Write("ingrese su peso: ");
            double peso = double.Parse(Console.ReadLine());

            double imc = (peso / (Math.Pow(estatura, 2)));

            Console.WriteLine("su IMC es: " + imc);

            if (imc < 18.5) 
            {
                Console.WriteLine("Por lo que usted tiene un peso inferior al normal");
            }
            else if (18.5 <= imc && imc <= 24.9)
            {
                Console.WriteLine("Por lo que usted tiene un peso normal");
            }
            else if (24.9 < imc && imc <= 29.9)
            {
                Console.WriteLine("Por lo que usted tiene un peso superior normal");
            }
            else 
            {
                Console.WriteLine("Por lo que usted tiene obesidad");
            }
        }
    }
}
