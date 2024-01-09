using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(1, 2);
            Complex z2 = new Complex(3, 4);

            Complex z3 = z1 + z2;
            Complex z4 = z1 - z2;
            Complex z5 = z1 * z2;

            Console.WriteLine("z1 = {0}", z1);
            Console.WriteLine("z2 = {0}", z2);
            Console.WriteLine("z3 = {0}", z3);
            Console.WriteLine("z4 = {0}", z4);
            Console.WriteLine("z5 = {0}", z5);
        }
    }
}
