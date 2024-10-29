namespace TheFirm;

internal class Werknemer: Person, IACMEContract
{
    public void Werken()
    {
        Werkt();
    }

    public virtual void Werkt()
    {
        Console.WriteLine("Default");
    }
}
