using System;

namespace Laboration_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new();
            Console.WriteLine(r.ToString());
            Console.WriteLine();

            Circle c = new();
            Console.WriteLine(c.ToString());
            Console.WriteLine();

            Triangle t = new();
            Console.WriteLine(t.ToString());
            Console.WriteLine();
        }
    }
}
