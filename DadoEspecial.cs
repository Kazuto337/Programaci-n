using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int Dado1 = 0, DadoESPCL = 0, Vidas = 3 , ContadorESPCL = 2, Total = 0 , Conteo6s = 0 , RestarVida = 0;
            bool PrimeraV = true , NuevaVida = false , Continuar = true;
            while(Total < 100 && Continuar == true)
            {
                if (PrimeraV)
                {
                    Dado1 = /*6*/ /*1*/ aleatorio.Next(1 , 7);
                    Total = Total + Dado1;
                    PrimeraV = false;
                    Console.WriteLine("Tu dado fue de " + Dado1 + " En total tienes " + Total + " Puntos.");
                }
                else
                {
                    Dado1 = /*6*/ /*1*/ aleatorio.Next(1, 7);
                    Total = Total + Dado1;
                    Console.WriteLine("Tu nuevo dado fue de " + Dado1 + " En total tienes " + Total + " Puntos.");
                }
                if (ContadorESPCL > 0)
                {
                    Console.WriteLine("Tienes " + ContadorESPCL + " Oportunidades de usar el dado especial ¿Desead usarlo?... S/N");
                    if (Console.ReadLine().Equals("s"))
                    {
                        DadoESPCL = aleatorio.Next(1, 13);
                        Total = Total + DadoESPCL;
                        ContadorESPCL--;
                        Console.WriteLine("Te quedan " + ContadorESPCL + " Dado espcecial");
                        Console.WriteLine("Tu nuevo dado fue de " + DadoESPCL + " En total tienes " + Total + " Puntos.");
                    }
                }
                if (Dado1 == 1 || DadoESPCL == 1)
                {
                    RestarVida++;
                    if (RestarVida %2 == 0)
                    {
                        Vidas--;
                        Total -= 10;
                        Console.WriteLine("Sacaste un 1 :c te quedan " + Vidas + " Vidas y pierdes 10 puntos.");
                        Console.WriteLine("Tu puntaje es de " + Total + " Puntos");
                    }
                }
                if(Dado1 == 6)
                {
                    Conteo6s++;
                    if (Conteo6s % 2 == 0)
                    {
                        NuevaVida = true;
                        if (NuevaVida && Vidas < 3)
                        {
                            Vidas++;
                        }
                    }
                }
                else if(Dado1 != 6)
                {
                    Conteo6s = 0;
                }
                
                if (Vidas == 0)
                {
                    Console.WriteLine("GameOver.... Gracias por jugar");
                    break;
                }                
                Console.WriteLine("¿Desea continuar? S/N");
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
