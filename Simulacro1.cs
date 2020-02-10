using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese su salario");
            double Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de contrato que posee:");
            Console.WriteLine("1) Presta Servicios");
            Console.WriteLine("2) Laboral");
            int Contrato = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el rango de riesgo de su empleo");
            int Riesgo = int.Parse(Console.ReadLine());

            //Salario Minimo
            double Minimo = 807.803;

            //Base de cotizacion
            double BC; 
            if (Salario * 0.4 < Minimo)
            {
                BC = Minimo;
            }
            else
            {
                BC = Salario * 0.4;
            }
            

            //Datos Dependiente(Laboral)
            if(Contrato == 2)
            {
                double Pensi= BC * 0.04;
                double EPS = BC * 0.04;
                double ARL = 0;
                double DeduT = Pensi + EPS + ARL;
                double Real = Salario - DeduT;
                double Anual = 12 * Real;

                Console.WriteLine("Su salario real es de " + Real +" "+" Y sus ingresos anuales son de " + Anual);
            }
            //Datos Independiente(Prestador de servicios)
            else
            {
                if (Riesgo == 1)
                {
                    double Pensi = BC * 0.04;
                    double EPS = BC * 0.04;
                    double ARL = BC * 0.0522;
                    double DeduT = Pensi + EPS + ARL;
                    double Real = Salario - DeduT;
                    double Anual = (12 * Real)+Salario;
                    Console.WriteLine("Su salario real es de " + Real + " " + " Y sus ingresos anuales son de " + Anual);
                }

            
                else if(Riesgo == 2)
                {
                    double Pensi = BC * 0.04;
                    double EPS = BC * 0.04;
                    double ARL = BC * 0.1044;
                    double DeduT = Pensi + EPS + ARL;
                    double Real = Salario - DeduT;
                    double Anual = 12 * Real;
                    Console.WriteLine("Su salario real es de " + Real + " " + " Y sus ingresos anuales son de " + Anual);
                }
                else if (Riesgo == 3)
                {
                    double Pensi = BC * 0.04;
                    double EPS = BC * 0.04;
                    double ARL = BC * 0.2436;
                    double DeduT = Pensi + EPS + ARL;
                    double Real = Salario - DeduT;
                    double Anual = 12 * Real;
                    Console.WriteLine("Su salario real es de " + Real + " " + " Y sus ingresos anuales son de " + Anual);
                }
                else if (Riesgo == 4)
                {
                    double Pensi = BC * 0.04;
                    double EPS = BC * 0.04;
                    double ARL = BC * 0.4350;
                    double DeduT = Pensi + EPS + ARL;
                    double Real = Salario - DeduT;
                    double Anual = 12 * Real;
                    Console.WriteLine("Su salario real es de " + Real + " " + " Y sus ingresos anuales son de " + Anual);
                }
                else
                {
                    double Pensi = BC * 0.04;
                    double EPS = BC * 0.6960;
                    double ARL = BC * 0.0522;
                    double DeduT = Pensi + EPS + ARL;
                    double Real = Salario - DeduT;
                    double Anual = 12 * Real;
                    Console.WriteLine("Su salario real es de " + Real + " " + " Y sus ingresos anuales son de " + Anual);
                }
            }      

        }
    }
}
