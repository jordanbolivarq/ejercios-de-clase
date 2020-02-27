using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ingrese en numero de datos");
            int n = int.Parse(Console.ReadLine()), posicionMayor = 0, posicionMenor = 0;
            double mayor = 0, menor = 200;
            while (n < 2)
            {
                Console.WriteLine("no es posible calcular con esa cantidad de datos, intente nuevamente");
                n = int.Parse(Console.ReadLine());
            }

            string[] nombres = new string[n];
            double[] edades = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\ningrese " + (i + 1) + "° nombre");
                string nombre = (Console.ReadLine());
                nombres[i] = nombre;
                Console.WriteLine("ingrese " + (i + 1) + "° edad");
                double edad = double.Parse(Console.ReadLine());
                edades[i] = edad;
                if (edad < menor)
                {
                    menor = edad;
                    posicionMenor = i;
                }
                if (edad > mayor)
                {
                    mayor = edad;
                    posicionMayor = i;
                }
            }
            Console.WriteLine("\nel mayor es " + (nombres[posicionMayor]) + " con " + mayor);
            Console.WriteLine("\nel menor es " + (nombres[posicionMenor]) + " con " + menor);
        }
    }
}
