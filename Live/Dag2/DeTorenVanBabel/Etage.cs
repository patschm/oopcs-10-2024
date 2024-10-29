namespace DeTorenVanBabel;

internal class Etage
{
    // static betekent hier shared (een gedeeld field)
    private static Lift lift = new Lift();
    public int Verdieping { get; set; }

    public void ToonLiftStatus()
    {              
        Console.WriteLine($"De lift staat op de {lift.Status}e verdieping");
    }
    public  void Call()
    {
        // statics noemt men vaak ook wel eens class members
        // lift is hier een class member
        // Verdieping is hier een instance member.
        Etage.lift.RoepOp(this.Verdieping);
    }

    static Etage()
    {
        Console.WriteLine("Static");
    }
}
