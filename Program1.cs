using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos Conocidos
            Console.WriteLine("Ingrese el valor de Z");
            double Z = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de Y");
            double Y = double.Parse(Console.ReadLine());

            //Solución para hallar "t"
            double t = Math.Sqrt((Z * Z) + (Y * Y));


            //Solución para hallar "c" 
            double c = Math.Atan(Z / Y) * (180/Math.PI);

            //Solución para hallar "c"
            double a = (90 - c);

            //Resultados
            Console.WriteLine("Sus Resultados son" + " " + "t =" + t + " " + "c = " + c + " " + "a=" + a);
            
        }
    }
}
