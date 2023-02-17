using System;
namespace Uppgift1
{
    class Program
    {
        static double CelsiusToFarenheit()
        {
            Console.Clear();

            Console.WriteLine("\nVilken grad vill du omvandla från C till F?");
            Console.Write("\nSkriv här: "); double input = double.Parse(Console.ReadLine());

            double F = 32 + input * 1.8;

            return F;
        }
        static double FarenhaitToCelsius()
        {
            Console.Clear();

            Console.WriteLine("\nVilken grad vill du omvandla från F till C?");
            Console.Write("\nSkriv här: "); double input = double.Parse(Console.ReadLine());

            double C = (input - 32) / 1.8;

            return C;

        }
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("\n1. Omvandla från Celsius tll Farenheit");
            Console.WriteLine("2. Omvandla från Farenheit tll Celsius");

            Console.Write("\nVilken omvandling vill du göra? Välj 1 eller 2: "); int val = int.Parse(Console.ReadLine());

            double Svar = 0;

            switch (val)
            {
                case 1:
                    Svar = CelsiusToFarenheit();
                    Console.WriteLine($"\nI Farenheit blir det {Svar} grader");
                    break;
                case 2:
                    Svar = FarenhaitToCelsius();
                    Console.WriteLine($"\nI Celsius blir det {Svar} grader");
                    break;
                default:
                    break;
            }
        }
    }
}