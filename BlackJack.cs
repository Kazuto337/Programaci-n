using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, Total = 0;
            bool PrimeraV = true, Continuar = true;


            while (Total < 21 && Continuar == true)
            {

                if (PrimeraV == true )
                {
                    PrimeraV = false;
                    carta1 = aleatorio.Next(1, 12);
                    carta2 = aleatorio.Next(1, 12);
                    Total = Total + carta1 + carta2;
                    Console.WriteLine("Sus Cartas son... " + "Carta 1 = " + carta1 + " Carta 2 = " + carta2 + " el total es de " + Total);


                    if (Total == 21)
                    {
                        Console.WriteLine("Felicidades ¡BlackJack! :D");
                    }
                }
                else
                {
                    carta1 = aleatorio.Next(1, 12);
                    Total = Total + carta1;
                    Console.WriteLine("Sus Cartas son... " + "Carta nueva = " + carta1 + " el total es de " + Total);
                }
                if (Total > 21)
                {
                    Console.WriteLine("GameOver");
                }
                else
                {
                    Console.WriteLine("Su total actual es de " + Total);
                    Console.WriteLine("Desea continuar S/N");
                    if(Console.ReadLine().Equals("s"))
                    {
                        Continuar = true;
                    }
                    else
                    {
                        Continuar = false;
                    }
                    

                }

            }

        }
    }
}
