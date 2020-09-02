using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var rc = new Rectangle(2, 3);
            UseIt(rc);
            // Expected area of 20, got 20

            var sq = new Square(5);
            UseIt(sq);
            // Expected area of 50, got 100
        }

        public static void UseIt(Rectangle r)
        {
            //r.Height = 10;
            Console.WriteLine($"Expected area of {r.Height * r.Width}, got {r.Area}");
        }
    }
}
