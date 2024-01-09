using System;

public static class ArrayExtension
{
    public static double Average(this int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }
}

class Program
{
    static void Main()
    {
        int[] numbersInt = { 5,7,9,12,34,56,78 };
        double findingAverageInt = numbersInt.Average();

        double[] numbersDouble = { 15.4, 12.3, 92.1, 12.2, 54.9 };
        double findingAverageDouble = numbersDouble.Average();

        Console.WriteLine($"Среднее значение целых чисел: {findingAverageInt}");
        Console.WriteLine($"Среднее значение двоек: {findingAverageDouble}");
    }
}
