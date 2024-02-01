public class Bird : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Птица кушает");
    }

    public void Move()
    {
        Console.WriteLine("Птица (поведение)");
    }

    public void MakeSound()
    {
        Console.WriteLine("Птица издаёт звук");
    }
}
