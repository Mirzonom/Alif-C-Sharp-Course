// Производный класс для круга
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public void EnlargeRadius()
    {
        Console.WriteLine("Enlarging the circle's radius");
    }
}
