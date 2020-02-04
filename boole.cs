using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            int a = 17;
            int b = 46;
            int blanco = 28;
            int nulo = 67;
            int poblacionTotal = 1071;
            double porcentajePoblacionMayor = 26;

            double poblacionMayor = poblacionTotal * (porcentajePoblacionMayor / 100);
            double abstencion = poblacionMayor - a + b + blanco + nulo;

            bool A = (nulo < 0.3 * (a + b));
            bool B = (blanco < a + b);
            bool C = (a + b + blanco + nulo > abstencion);

            Console.WriteLine("votos a : " + a);
            Console.WriteLine("votos b : " + b);
            Console.WriteLine("votos blanco : " + blanco);
            Console.WriteLine("votos nulo : " + nulo);
            Console.WriteLine("poblacion total : " + poblacionTotal);
            Console.WriteLine("porcentaje poblacion mayor : " + porcentajePoblacionMayor);
            Console.WriteLine("poblacion mayor : " + poblacionMayor);
            //Console.WriteLine("A : " + A);
            //Console.WriteLine("B : " + B);
            //Console.WriteLine("C : " + C);


            if ((A || B) && C)
            {
                Console.WriteLine("las elecciones han sido exitosas");
                if (a > b)
                {
                    Console.WriteLine("partido a gano las elecciones");
                }
                else
                {
                    Console.WriteLine("partido b gano las elecciones");
                }
            }
            else 
            {
                Console.WriteLine("se deben repetir las elecciones");
            }
        }
    }
}
