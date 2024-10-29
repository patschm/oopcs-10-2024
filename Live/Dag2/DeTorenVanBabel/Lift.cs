namespace DeTorenVanBabel;

internal class Lift
{
    private int huidigeVerdieping = 0;

    public int Status
    {
        get { return huidigeVerdieping; }
    }

    public void RoepOp(int verdieping)
    {
        Console.WriteLine($"De lift zoemt naar de {verdieping}e verdieping");
        huidigeVerdieping = verdieping;
    }
}