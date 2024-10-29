namespace TheFirm;

// Bokito IMPLEMENTEERT (DUS NIET ERFT) de interface IACMEContract
internal class Bokito : IACMEContract, IBlijdorpContract
{
    // Expliciete impementatie
    void IBlijdorpContract.Werken()
    {
        Werkt();
    }

    public void Werken()
    {
        Werkt();
    }

    public void Werkt()
    {
        Console.WriteLine("Bokito ramt dames in elkaar");
    }
}
