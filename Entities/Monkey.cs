using ConsoleApp1.Abstract;

namespace ConsoleApp1.Entities;

internal class Monkey : Animal
{
    public override string Espece => "Monkey";

    public override int Foots => 2;


    public override void Eats()
    {
        base.Eats();

        Console.WriteLine("I likes Banana");
    }

    public override void Move()
    {
        base.Move();

        Console.WriteLine("Jumping on trees");
    }
}
