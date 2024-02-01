public class Fish : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Рыба кушает");
    }

    public void Move()
    {
        Console.WriteLine("Рыба (поведение)");
    }

    public void MakeSound()
    {
        Console.WriteLine("Рыба издаёт звук");
    }
}
