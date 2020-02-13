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
            string continuarJuego = "s";
            while (continuarJuego == "s")
            {
                Random aleatorio = new Random();
                int dado1 = aleatorio.Next(1, 7);
                int dado2 = aleatorio.Next(1, 7);
                int total = dado1 + dado2;
                int contador = 0;
                int contador2 = 0;
                int contador3 = 0;
                string continuar = "";

                if (dado1 == dado2)
                    contador3++;
                if (dado1 + dado2 >= 6)
                    contador2++;

                Console.WriteLine("Supere 100 para ganar para ganar o obtenga 3 pares consecutivos");
                Console.WriteLine("S obtiene 1 en ambos dados pedera");


                Console.WriteLine("dado 1: " + dado1);
                Console.WriteLine("dado 2: " + dado2);
                Console.WriteLine("Total: " + total);


                if (dado1 == 1 && dado2 == 1)
                {
                    total = 0;
                    continuar = "f";
                }
                else
                {
                    Console.WriteLine("Dijite 's' para lanzar nuevamente o 'f' para finalizar partida");
                    continuar = Console.ReadLine();
                }

                while (continuar == "s" && total < 100)
                {
                    Console.WriteLine("");
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("dado 1: " + dado1);
                    Console.WriteLine("dado 2: " + dado2);
                    contador++;
                    Console.WriteLine("tiro numero " + (1 + contador));
                    total += (dado1 + dado2);
                    Console.WriteLine("Total: " + total);

                    if (dado1 == 1 && dado2 == 1)
                    {
                        total = 0;
                        continuar = "f";
                    }

                    if (dado1 + dado2 >= 6)
                        contador2++;

                    if (dado1 == dado2)
                        contador3++;

                    Console.WriteLine("Pares : " + contador3);

                    if (contador3 == 3)
                        total = 100;

                    if (total >= 100)
                        continuar = "f";

                    if (total <= 100 && total != 0 && contador3 != 3)
                    {
                        Console.WriteLine("Dijite 's' para lanzar nuevamente o 'f' para finalizar partida");
                        continuar = Console.ReadLine();
                    }
                }

                if (total >= 100)
                    Console.WriteLine("Ganó");
                else
                    Console.WriteLine("Perdió");

                Console.WriteLine("Lanzó " + (contador + 1) + " veces");
                Console.WriteLine("Obtuvo un " + ((100 / (contador + 1)) * contador2) + "% de tiros superiores a 6 puntos");

                Console.WriteLine("¿Desea jugar otra vez? (digite 's' para si o 'n' para no)");
                continuarJuego = Console.ReadLine();
            }
        }
    }
}
