// Производный класс для прямоугольника
public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }

    public void Rotate()
    {
        Console.WriteLine("Rotating the rectangle");
    }
}
