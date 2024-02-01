using System;

class Program
{
    static void Main(string[] args)
    {
        Bird bird = new Bird();
        Fish fish = new Fish();

        // Пример использования методов различных интерфейсов
        bird.Eat();
        bird.Fly();
        bird.MakeSound();

        fish.Eat();
        fish.Swim();
        fish.MakeSound();
    }
}
