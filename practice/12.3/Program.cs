namespace HomeWork
{
    sealed class Person
    {
        public void Run()
        {
            Console.WriteLine("I am Runing");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new();
            person.Run();
        }
    }
}
