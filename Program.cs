using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese el valor de C");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de Z");
            double Z = double.Parse(Console.ReadLine());

            //Conversion de Radianes a grados
            // Coversion de grados a radianes
            double cGrados = (Math.PI / 180) * c;

            //hallar la variable Y
            double Y = Z / ( Math.Tan(cGrados));
            
            //hallar la variable a
            double a = 90 - c;

            //hallar la variable t
            double t = Math.Sqrt((Y * Y) + (Z * Z));

            Console.WriteLine("Sus resultados son:" + " " + "a=" + a + " " + "Y=" + Y + " " + " t=" + t );
           
        }
    }
}
