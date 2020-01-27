using System;

namespace Programa_4
{
    class Program4
    {
        static void Main(string[] args)
        {
            //Ingreso de datos Ejercicio 1 
            Console.WriteLine("Ingrese los valores de ... b , z , y:");
            double b = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //El valor de "a" en grados
            double a = Math.Atan( y / z);
            double aGrados = (a * (180 / Math.PI));

            //Llamaremos K al resultado de a+b 
            double K = aGrados + b;

            //Covertimos K a radianes
            double Krad = K * Math.PI / 180;

            //Hallamos el valor de W
            double W1 =  z / (Math.Cos(Krad));

            //Hallamos el valor de X
            double x1 = Math.Sqrt((W1 * W1) - (z * z)) - y ;

            //Resultados Ejercicio 1
            Console.WriteLine("Solución Ejercicio 1: x =" + x1);

            //Ingreso de datos Ejercicio 2
            Console.WriteLine("Ingrese los valores de ... d , b , y:");
            double D2 = double.Parse(Console.ReadLine());
            double B2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            //Valor de a en el ejercicio 2
            double a2 = 90-D2-B2;

            //Convertir el valor de "a" a radianes
            double Arad = a2 * (Math.PI / 180);

            //Hallamos el valor de z en el ejercicio 2
            double z2 =  Y2 / Math.Tan(Arad);

            //Resultado Ejercicio 2
            Console.WriteLine("Solución Ejercicio 2: Z =" + z2);

            //Ingreso de datos Ejercicio 3
            Console.WriteLine("Ingrese los valores de ... w , d , x");
            double W3 = double.Parse(Console.ReadLine());
            double d3 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());

            //Convertimos el angulo d3 a radianes
            double Drad = d3 * (Math.PI / 180);

            //hallamos el valor de Z en el ejercicio 3
            double z3 = Math.Sin(Drad) * W3;

            //Hallamos el valor del angulo a+b y lo expresamos como K en el ejercicio 3
            double K3 = 90- d3;

            //Convertimos K3 a radianes
            double K3rad = K3 * (Math.PI / 180);

            //Hallamos el valor de Y en el ejercicio 3
            double Y3 = (Math.Tan(K3rad) * z3) - x3;

            //Solución Ejercicio 3
            Console.WriteLine("Solución Ejercicio 3: Y =" + Y3);

            //Ingreso de datos Ejercicio 4
            Console.WriteLine("Ingrese los valores de ... w , t , c");
            double w4 = double.Parse(Console.ReadLine());
            double t4 = double.Parse(Console.ReadLine());
            double c4 = double.Parse(Console.ReadLine());

            //Hallamos el valor de Y en el ejercicio 4
            double Y4 = Math.Cos(c4 * (Math.PI / 180)) * t4 ;

            //Hallamos el valor de Z en el ejercicio 4
            double Z4 = Math.Sin(c4 * (Math.PI / 180)) * t4;

            //Hallamos el valor de X en el ejercicio 4
            double X4 = Math.Sqrt((w4 * w4) - (Z4 * Z4)) - Y4;

            Console.WriteLine("Solución Ejercicio 4: X=" +  X4) ;
        }
    }
}
