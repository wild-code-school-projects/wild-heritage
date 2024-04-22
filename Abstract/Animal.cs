namespace ConsoleApp1.Abstract;

internal abstract class Animal
{
    public abstract string Espece { get; }

    public abstract int Foots { get; }

    public virtual void Move()
    {
        Console.WriteLine($"{Espece} is moving.");
    }

    public virtual void Eats()
    {
        Console.WriteLine($"{Espece} is eating.");
    }
}
