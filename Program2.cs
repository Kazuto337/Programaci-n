using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de t");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de a");
            double a = double.Parse(Console.ReadLine());

            //Hallar el valor de "c"
            double c = 90 - a;

            // Coversion de grados a radianes
            double cGrados = (Math.PI / 180) * c; 

            //Hallar el valor de Y
            double Y = t * Math.Cos(cGrados);

            //Hallar el valor Z
            double Z = Math.Sqrt((t * t) - (Y * Y));

            //Solución
            Console.WriteLine("Tus resultados son:" + " " + "c =" + c + " " + " Z =" + Z + " " + "Y =" + Y);

        }
    }
}
