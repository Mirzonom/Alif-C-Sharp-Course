namespace HomeWork
{
    public partial class Person
    {
        public void Run()
        {
            Console.WriteLine("I am Runing");
        }
        public partial void Eat();

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person inom = new Person();
            inom.Run();
            inom.Eat();

            Console.ReadKey();
        }
    }
}
