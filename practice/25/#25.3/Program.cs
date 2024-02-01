using System;

class Program
{
    static void Main(string[] args)
    {
        IAnimal bird = new Bird();
        IAnimal fish = new Fish();

        PerformAnimalActions(bird);
        PerformAnimalActions(fish);
    }

    static void PerformAnimalActions(IAnimal animal)
    {
        animal.Eat();
        animal.Move();
        animal.MakeSound();
    }
}
