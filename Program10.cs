using System;

namespace Tarea_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0 , vidas = 3 , turnos = 0, dobles = 0;
            bool Continuar = true, UsoDado2 = true;

            while (total < 100 && Continuar)
            {
                if (UsoDado2)
                {
                    turnos++;
                    dado1 = aleatorio.Next(1, 7);
                    total = total + dado1;

                    Console.WriteLine("Tu dado fue de " + dado1 + " Tu puntuacion actual es de " + total);

                    if (turnos == 3) UsoDado2 = false;
                }
                else
                {
                    turnos++;
                    vidas--;
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    total = total + dado1 + dado2;
                    Console.WriteLine("Tu dado 1 fue de " + dado1 + " y tu dado 2 fue de " + dado2 + " Tu puntuacion actual es de " + total + " Te quedan " + vidas + " vidas" );                   
                }
                if (dado1 == dado2)
                {
                    dobles++;
                    if (vidas < 3 && dobles > 0)
                    {
                        vidas = vidas + 2;
                        Console.WriteLine("¡Pares! Ganas una vida");
                    }
                }
                else { dobles = 0; }
                if (vidas == 0)
                {
                    Continuar = false;
                    Console.WriteLine("No te quedan vidas para continuar GAME OVER :C");
                    break;
                    
                }
                else if (total >= 100)
                {
                    Continuar = false;
                    Console.WriteLine("¡Felicidades ganaste :D!");
                    break;
                }
                Console.WriteLine("¿Deseas Continuar?   S/N");
                if (Console.ReadLine().Equals("s")) Continuar = true;
                else
                {
                    Continuar = false;
                    Console.WriteLine("GAME OVER gracias por jugar ");
                    break;
                }             
            }

        }
    }
}
