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
            { 
                string continuarJuego = "s";
                while (continuarJuego == "s")
                {
                    Random aleatorio = new Random();
                    int dado1 = 0;
                    int dadosE = 2;
                    int total = dado1;

                    string continuar = "";
                    string dadoEspecial = "";
                    int vidas = 3;
                    int vidasPor1 = 2;
                    int contador = 0;
                    int contador2 = 0;
                    int puntosMenos = 10;

                    Console.WriteLine("obtenga 100 o mas para ganar.");
                    Console.WriteLine("Ustede tiene " + vidas + " vidas, perdera una cada " + vidasPor1 + " veces que obtenga 1 al lazar el dado, ademas le restara" + puntosMenos + "puntos. Si se queda sin vidas pierde.");
                    Console.WriteLine("Si obtiene dos 6 consecutivos recupera 1 vida (no acumulara mas de 3), si obtine par (ambos dados con igual valor) obtendra otra vida.");
                    Console.WriteLine("Cuenta con 2 dados especiales (dado de 12 caras) que puede elegir cuando lanzar.");

                    Console.WriteLine("Dijite 's' para lanzar o 'f' para finalizar partida");
                    continuar = Console.ReadLine();

                    while (continuar == "s" && total < 100 && vidas > 0)
                    {
                        if (dadosE > 0)
                        {
                            Console.WriteLine("Dijite 's' para lanzar el dado especial o 'n' para lanzar el normal");
                            dadoEspecial = Console.ReadLine();
                        }
                        else
                            dadoEspecial = "n";

                        if (dadoEspecial == "s")
                        {
                            dado1 = aleatorio.Next(1, 13);
                            dadosE -= 1;
                        }
                        else
                            dado1 = aleatorio.Next(1, 7);

                        Console.WriteLine("dado: " + dado1);

                        if (dado1 == 1)
                            contador2++;

                        if (contador2 == 2 && vidas > 0)
                        {
                            total -= 10;
                            vidas--;
                            contador2 = 0;
                        }

                        total += dado1;
                        Console.WriteLine("Total: " + total);

                        if (dado1 == 6)
                            contador++;
                        else
                            contador = 0;

                        if (contador == 2 && vidas < 3)
                            vidas++;

                        Console.WriteLine("Vidas: " + vidas);

                        if (total < 100 && vidas > 0)
                        {
                            Console.WriteLine("Dijite 's' para lanzar nuevamente o 'f' para finalizar partida");
                            continuar = Console.ReadLine();
                        }
                        else if (vidas <= 0 && total < 100)
                            Console.WriteLine("Perdió");
                    }

                    Console.WriteLine(" ");

                    Console.WriteLine("¿Desea jugar otra vez? (digite 's' para si o 'n' para no)");
                    continuarJuego = Console.ReadLine();
                }
            }
        }
    }
}
