using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de su sueldo para asignarle la tarifa correspondiente");
            double s = double.Parse(Console.ReadLine());

            if (s <= 877803)
            {
                Console.WriteLine("La tarifa designada fue la Tarifa A");
            }
            else if(s >= (877803 * 2) && s<= (877803 * 4))
            {
                Console.WriteLine("La tarifa designada fue la Tarifa B");
            }
            else
            {
                Console.WriteLine("La Tarifa designada fue la Tarifa C");
            }
        }
    }
}
