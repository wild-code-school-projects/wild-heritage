using ConsoleApp1.Abstract;

namespace ConsoleApp1.Entities;

internal class Human : Animal
{
    public override string Espece => "Human";

    public override void Move()
    {
        base.Move();

        Console.WriteLine("While walking I can see Eve.");
    }

    public override void Eats()
    {
        base.Eats();

        Console.WriteLine("I likes Mangoes");
    }

}
