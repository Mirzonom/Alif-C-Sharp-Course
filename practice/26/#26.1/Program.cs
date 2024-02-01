using System;

class Program
{
    static void Main()
    {
        // Пример использования контравариации
        DrawShape(new Circle());
        DrawShape(new Rectangle());
    }

    // Метод, использующий контравариацию для рисования фигур
    static void DrawShape(Shape shape)
    {
        shape.Draw();
    }
}
