using ConsoleApp1.Abstract;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = {
                new Human(),
                new Elephant(),
                new Monkey()
            };

            foreach (var animal in animals)
            {
                animal.Eats();
                animal.Move();
                Console.WriteLine("-------------------------------");
            }

        }
    }
}
