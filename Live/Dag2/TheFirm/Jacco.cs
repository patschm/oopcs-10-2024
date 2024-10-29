namespace TheFirm;

internal class Jacco : Werknemer
{
    public override void Werkt()
    {
        Afrekenen();
    }
    public void Afrekenen()
    {
        Console.WriteLine("Jacco regelt de financien");
    }
}
