public class Fish : IAnimal, ISwimmable, IMakeSound
{
    public void Eat()
    {
        Console.WriteLine("Рыба кушает");
    }

    public void Sleep()
    {
        Console.WriteLine("Рыба спит");
    }

    public void Swim()
    {
        Console.WriteLine("Рыба плавает");
    }

    public void MakeSound()
    {
        Console.WriteLine("Рыба издаёт звук");
    }
}
