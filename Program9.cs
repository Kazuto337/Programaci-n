using System;

namespace Programa9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int Dado1 = 0, Total = 0, Turnos = 0;
            bool PrimeraV = true, Continuar = true;

            while (Total < 100 && Continuar == true)
            {
                if (PrimeraV == true)
                {
                    Turnos++;
                    PrimeraV = false;
                    Dado1 = aleatorio.Next(1, 13);
                    Total = Total + Dado1;

                    Console.WriteLine("Tu dado fue de " + Dado1 + " Y tu puntuacion fue de " + Total);
                }
                else
                {
                    Turnos++;
                    Dado1 = aleatorio.Next(1, 13);
                    Total = Total + Dado1;
                    Console.WriteLine("Tu nuevo dado fue de " + Dado1 + " Y tu puntuacion actual es de " + Total);
                   
                    if (Dado1 == 10 && Turnos > 3)
                    {
                        if (Dado1 == 12)
                        {
                            Console.WriteLine("Ganaste :D sacaste un 12 despues de un 10 ");
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                if(Total >= 100)
                {
                    Console.WriteLine("Felicidades Ganaste, tu puntuacion final fue de " + Total);
                }
                Console.WriteLine("Desea Continuar S/N");
                if (Console.ReadLine().Equals("s"))
                {
                    Continuar = true;
                }
                else
                {
                    Continuar = false;
                    break;
                }

            }
        }
    }
}
