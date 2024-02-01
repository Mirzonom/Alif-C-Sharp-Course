using System;

class Program
{
    static void Main(string[] args)
    {
        IAnimal bird = new Bird();
        IAnimal fish = new Fish();

        bird.Eat();
        bird.Sleep();

        fish.Eat();
        fish.Sleep();
    }
}
