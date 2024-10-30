namespace NogMeerInteractie;

delegate void Iets();
delegate void OokIets(int bla);

internal class Jacco
{
    public void Execute(OokIets fun)
    {
        Console.WriteLine("Jacco voert nu uit:");

        fun(5);
    }
    public void Execute(Iets fun)
    {
        Console.WriteLine("Jacco voert nu uit:");

        fun();
    }
}
