using System;

namespace SimulacroSwich
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese su salario");
            double Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de contrato que posee:");
            Console.WriteLine("1) Laboral");
            Console.WriteLine("2) Presta Servicios");
            int Contrato = int.Parse(Console.ReadLine());            

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
            switch (Contrato)
            {
                case 1:
                    double Pensi = BC * 0.04;
                    double EPS = BC * 0.04;
                    double ARL = 0;
                    double DeduT = Pensi + EPS + ARL;
                    double Real = Salario - DeduT;
                    double Anual = 12 * Real;

                    Console.WriteLine("Su salario real es de " + Real + " " + " Y sus ingresos anuales son de " + Anual);
                break;
                default:
                    Console.WriteLine("Escriba el rango de riesgo de su empleo");
                    int Riesgo = int.Parse(Console.ReadLine());
                    switch (Riesgo)
                    {
                        case 1:
                            double Pensi1 = BC * 0.04;
                            double EPS1 = BC * 0.04;
                            double ARL1 = BC * 0.0522;
                            double DeduT1 = Pensi1 + EPS1 + ARL1;
                            double Real1 = Salario - DeduT1;
                            double Anual1 = (12 * Real1) + Salario;
                            Console.WriteLine("Su salario real es de " + Real1 + " " + " Y sus ingresos anuales son de " + Anual1);
                        break;

                        case 2:
                            double Pensi2 = BC * 0.04;
                            double EPS2 = BC * 0.04;
                            double ARL2 = BC * 0.1044;
                            double DeduT2 = Pensi2 + EPS2 + ARL2;
                            double Real2 = Salario - DeduT2;
                            double Anual2 = 12 * Real2;
                            Console.WriteLine("Su salario real es de " + Real2 + " " + " Y sus ingresos anuales son de " + Anual2);
                        break;

                        case 3:
                            double Pensi3 = BC * 0.04;
                            double EPS3 = BC * 0.04;
                            double ARL3 = BC * 0.2436;
                            double DeduT3 = Pensi3 + EPS3 + ARL3;
                            double Real3 = Salario - DeduT3;
                            double Anual3 = 12 * Real3;
                            Console.WriteLine("Su salario real es de " + Real3 + " " + " Y sus ingresos anuales son de " + Anual3);
                        break;
                                                        
                        case 4:
                            double Pensi4 = BC * 0.04;
                            double EPS4 = BC * 0.04;
                            double ARL4 = BC * 0.4350;
                            double DeduT4 = Pensi4 + EPS4 + ARL4;
                            double Real4 = Salario - DeduT4;
                            double Anual4 = 12 * Real4;
                            Console.WriteLine("Su salario real es de " + Real4 + " " + " Y sus ingresos anuales son de " + Anual4);
                        break;

                        default:
                            double Pensi5 = BC * 0.04;
                            double EPS5 = BC * 0.6960;
                            double ARL5 = BC * 0.0522;
                            double DeduT5 = Pensi5 + EPS5 + ARL5;
                            double Real5 = Salario - DeduT5;
                            double Anual5 = 12 * Real5;
                            Console.WriteLine("Su salario real es de " + Real5 + " " + " Y sus ingresos anuales son de " + Anual5);
                       break;
                      
                    }
                break;
                


            }
        }
    }
}
