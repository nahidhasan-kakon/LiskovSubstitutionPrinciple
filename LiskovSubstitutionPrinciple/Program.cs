
class Program
{
    static void Main(string[] args)
    {
        Bird sparrow= new Sparrow();
        sparrow.Fly();

        Bird penguin = new Penguin();
        penguin.Fly();
    }
}

public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Bird fly");
    }
}

public class Sparrow : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Sparrow fly");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Penguin fly");
    }
}