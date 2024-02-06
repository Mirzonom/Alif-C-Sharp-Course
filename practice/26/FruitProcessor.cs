using System;

public class FruitProcessor<T> : IFruitProcessor<T>, IContravariantFruitProcessor<T>
{
    private T _fruit;

    public FruitProcessor(T fruit)
    {
        _fruit = fruit;
    }

    public T Process()
    {
        Console.WriteLine($"Processing {_fruit.GetType().Name}");
        return _fruit;
    }

    public void DisplayInfo(T fruit)
    {
        Console.WriteLine($"Displaying info about {fruit.GetType().Name}");
    }
}
