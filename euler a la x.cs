using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            double x = 3, resultado = 0;
            for (int i = 0; i < 1000; i++)
            {
                double anterior = resultado;
                resultado += (Math.Pow(x, i)) / (Factorial(i)); 
                Console.WriteLine("resultado = " + resultado + ", intento = " + (i+1));
                if (resultado == anterior) break;
            }
        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
    }
}
