using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            Console.Write("ingrese su salario: ");
            Double salario = double.Parse(Console.ReadLine());
            Console.Write("ingrese 1 si es dependiente o 2 si es independiente: ");
            int depOInt = int.Parse(Console.ReadLine()); 
            Double smmlv = 877803;
            

            double baseCotizacion = (salario * 0.4);

            if (baseCotizacion < smmlv)
            {
                baseCotizacion = smmlv;
            }

            if (depOInt == 1)
            {
                double eps = baseCotizacion * 0.04;
                //Console.WriteLine(eps);
                double pension = baseCotizacion * 0.04;
                //Console.WriteLine(pension);
                double salarioReal = salario - eps - pension;
                Console.WriteLine("su salario mensual real es: " + salarioReal);
                double salarioAnual = (salarioReal * 12) + salario;
                Console.WriteLine("su salario anual es: " + salarioAnual);
            }

            if (depOInt == 2)
            {
                Console.WriteLine("ingrese su clase de riesgo (numero de 1 a 5): ");
                int tipoDeRiesgo = int.Parse(Console.ReadLine());
                double eps = baseCotizacion * 0.125;
                //Console.WriteLine(eps);
                double pension = baseCotizacion * 0.16;
                //Console.WriteLine(pension);
                double riesgo = 0;
                if (tipoDeRiesgo == 1)
                {
                    riesgo = 0.00522 * baseCotizacion;
                }
                else if (tipoDeRiesgo == 2)
                {
                    riesgo = 0.01044 * baseCotizacion;
                }
                else if (tipoDeRiesgo == 3)
                {
                    riesgo = 0.02436 * baseCotizacion;
                }
                else if (tipoDeRiesgo == 4)
                {
                    riesgo = 0.04350 * baseCotizacion;
                }
                else if (tipoDeRiesgo == 5)
                {
                    riesgo = 0.06960 * baseCotizacion;
                }
                double salarioReal = salario - eps - pension - riesgo;
                Console.WriteLine("su salario mensual real es: " + salarioReal);
                Console.WriteLine("su salario anual es: " + salarioReal * 12);
            }

        }
    }
}
