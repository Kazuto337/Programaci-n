using System;

namespace Programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso del sueldo
            Console.WriteLine("Ingrese el valor de su sueldo para asignarle su taifa");
            double s = double.Parse(Console.ReadLine());

            //asignacion de la tarifa
            if (s <= (877803 * 2))
            {
                Console.WriteLine("Su tarifa a pagar sera la Tarifa A");

            }
            else if ( s>= (877803 * 2) && s <= (877803 * 5))
            {
                Console.WriteLine("Su tarifa a pagar sera la Tarifa B");
            }
            else
            {
                Console.WriteLine("Su tarifa a pagar sera la Tarifa C");
            }

        }
    }
}
