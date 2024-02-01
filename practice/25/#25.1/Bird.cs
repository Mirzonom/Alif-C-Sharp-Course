public class Bird : IAnimal, IFlyable, IMakeSound
{
    public void Eat()
    {
        Console.WriteLine("Птица кушают");
    }

    public void Sleep()
    {
        Console.WriteLine("Птица спит");
    }

    public void Fly()
    {
        Console.WriteLine("Птица летит");
    }

    public void MakeSound()
    {
        Console.WriteLine("Птица издаёт звук");
    }
}
