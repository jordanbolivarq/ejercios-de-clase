using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int numero1 = aleatorio.Next(1, 5);
            int numero2 = aleatorio.Next(1, 5);
            int suma = numero1 + numero2;

            Console.WriteLine("Ingrese el resutado de la suma: ");
            Console.WriteLine(numero1 + "+" + numero2);
            int respuesta = int.Parse(Console.ReadLine());
            int intentos = 3;

            while (respuesta != suma && intentos > 1)
            {
                numero1 = aleatorio.Next(1, 5);
                numero2 = aleatorio.Next(1, 5);
                suma = numero1 + numero2;
                Console.WriteLine("Error, intente nuevamente");
                Console.WriteLine("\nIngrese el resutado de la suma: ");
                Console.WriteLine(numero1 + "+" + numero2);
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta != suma)
                intentos--;
            }

            //Console.WriteLine("\n" + intentos);
            if (intentos > 1)
                Console.WriteLine("\nPuede continuar");
            else
                Console.WriteLine("\nNo puede continuar");
        }
    }
}
