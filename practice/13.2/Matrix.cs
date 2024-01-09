using System;

public class Matrix2x2
{
    public int[,] Values { get; private set; }

    public Matrix2x2(int a, int b, int c, int d)
    {
        Values = new int[2, 2] { { a, b }, { c, d } };
    }

    public static Matrix2x2 operator +(Matrix2x2 matrix1, Matrix2x2 matrix2)
    {
        int[,] result = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = matrix1.Values[i, j] + matrix2.Values[i, j];
            }
        }

        return new Matrix2x2(result[0, 0], result[0, 1], result[1, 0], result[1, 1]);
    }

    public static Matrix2x2 operator *(Matrix2x2 matrix1, Matrix2x2 matrix2)
    {
        int[,] result = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = matrix1.Values[i, 0] * matrix2.Values[0, j] + matrix1.Values[i, 1] * matrix2.Values[1, j];
            }
        }

        return new Matrix2x2(result[0, 0], result[0, 1], result[1, 0], result[1, 1]);
    }

    public override string ToString()
    {
        return $"{Values[0, 0]} {Values[0, 1]}\n{Values[1, 0]} {Values[1, 1]}";
    }
}
