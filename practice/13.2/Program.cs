using System;

class Program
{
    static void Main(string[] args)
    {
        Matrix2x2 matrix1 = new Matrix2x2(1, 2, 3, 4);
        Matrix2x2 matrix2 = new Matrix2x2(5, 6, 7, 8);

        Matrix2x2 sum = matrix1 + matrix2;
        Matrix2x2 product = matrix1 * matrix2;

        Console.WriteLine("Матрица 1:");
        Console.WriteLine(matrix1);

        Console.WriteLine("\nМатрица 2:");
        Console.WriteLine(matrix2);

        Console.WriteLine("\nСумма матриц:");
        Console.WriteLine(sum);
    }
}
