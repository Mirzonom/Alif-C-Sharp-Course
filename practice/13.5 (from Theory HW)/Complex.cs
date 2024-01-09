using System;

namespace ComplexNumbers
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex z1, Complex z2)
        {
            return new Complex(z1.Real + z2.Real, z1.Imaginary + z2.Imaginary);
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex(z1.Real - z2.Real, z1.Imaginary - z2.Imaginary);
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return new Complex(
                z1.Real * z2.Real - z1.Imaginary * z2.Imaginary,
                z1.Real * z2.Imaginary + z1.Imaginary * z2.Real
            );
        }
        public override string ToString()
        {
            return $"({Real}, {Imaginary}i)";
        }
    }
}
