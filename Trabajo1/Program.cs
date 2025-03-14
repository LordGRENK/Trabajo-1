using System;

namespace Trabajo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double SalarioBruto, IngresoNeto, DeduccionesTotales, IngresoTotal;
            double AFILIACION, IR, INSS, Empresa, Antiguedad;
            int i = 0;
            bool entradaValida = false;

            while (i< 3)
            {
                Console.WriteLine("Bienvenido, por favor digite su SALARIO BÁSICO:");
                string input = Console.ReadLine();

                if (double.TryParse(input, out SalarioBruto) && SalarioBruto > 0)
                {
                    Antiguedad = SalarioBruto * 0.15;
                    IngresoTotal = SalarioBruto + Antiguedad;
                    AFILIACION = SalarioBruto * 0.01;
                    INSS = IngresoTotal * 0.07;
                    IR = IngresoTotal * 0.156;
                    Empresa = IngresoTotal * 0.225;
                    DeduccionesTotales = AFILIACION + INSS + IR;
                    IngresoNeto = IngresoTotal - DeduccionesTotales;

                    Console.WriteLine("\n=== Detalle de su salario ===");
                    Console.WriteLine($"Salario Bruto: {SalarioBruto:F2}");
                    Console.WriteLine($"Antigüedad (15% del Salario Bruto): {Antiguedad:F2}");
                    Console.WriteLine($"Ingreso Total (Bruto + Antigüedad): {IngresoTotal:F2}");
                    Console.WriteLine($"Afiliación Sindicato (1% del Bruto): {AFILIACION:F2}");
                    Console.WriteLine($"INSS (7% del Ingreso Total): {INSS:F2}");
                    Console.WriteLine($"IR (15.6% del Ingreso Total): {IR:F2}");
                    Console.WriteLine($"Deducción Empresa (INSS Patronal 22.5% del Ingreso Total): {Empresa:F2}");
                    Console.WriteLine($"Deducciones Totales: {DeduccionesTotales:F2}");
                    Console.WriteLine($"Ingreso Neto: {IngresoNeto:F2}");
                    entradaValida = true;
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR: Ingrese un número válido y positivo.");
                    i++;
                }
            }

            if (!entradaValida)
            {
                Console.WriteLine("Límite de intentos alcanzado. Por favor, intente más tarde.");
            }
        }
        }
    }

