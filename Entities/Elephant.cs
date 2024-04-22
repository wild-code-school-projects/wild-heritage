using ConsoleApp1.Abstract;

namespace ConsoleApp1.Entities;

internal class Elephant : Animal
{
    public override string Espece => "Elephant";

    public override void Eats()
    {
        base.Eats();

        Console.WriteLine("I love grass");
    }

    public override void Move()
    {
        base.Move();

        Console.WriteLine("boom boom");
    }
}
