using System;

namespace uppgift4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skiv in ett tal ");
            double x = double.Parse(Console.ReadLine()); // i inmatningingen måste du använd "," och inte "." när du skriver decimaltal//
            Console.WriteLine("skriv ett till tal");
            double Y = double.Parse(Console.ReadLine());
            double summa = x + Y;
            double product = x * Y;
            Console.WriteLine("summan av dina tal är: " + summa);
            Console.WriteLine("produkten av dina tal är: " + product);
        }
    }
}