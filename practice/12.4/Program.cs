namespace HomeWork
{
    static class Math
    {
        public static int Add(int number1,int number2)
        {
            return number1 + number2;
        }
        public static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public static int Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(Add(1,2));
                Console.WriteLine(Subtract(3,4));
                Console.WriteLine(Multiply(5,6));
                Console.WriteLine(Divide(7,8));
            }
        }
    }
}
