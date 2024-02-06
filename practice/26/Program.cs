using System;

class Program
{
    static void Main()
    {
        Apple apple = new Apple { Name = "Red Apple", IsRed = true };
        Banana banana = new Banana { Name = "Ripe Banana", IsRipe = true };

        IFruitProcessor<Fruit> fruitProcessor = new FruitProcessor<Apple>(apple);
        Fruit processedFruit = fruitProcessor.Process();
        Console.WriteLine($"Processed fruit: {processedFruit.Name}");

        IContravariantFruitProcessor<Apple> contravariantProcessor = new FruitProcessor<Fruit>(banana);
        contravariantProcessor.DisplayInfo(new Apple { Name = "Green Apple", IsRed = false });
    }
}
