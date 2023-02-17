using System;
namespace Uppgift1
{
    class Program
    {
        static int AREA(int b, int h)
        {
            int area = b * h;
            return area;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\nSkriv in en bredd och en höjd");

            Console.Write("\nBredd: "); int bredd = int.Parse(Console.ReadLine());
            Console.Write("Höjd: "); int höjd = int.Parse(Console.ReadLine());

            int area = AREA(bredd, höjd);

            Console.WriteLine($"\nArean blir då {area} a.e");
        }
    }
}