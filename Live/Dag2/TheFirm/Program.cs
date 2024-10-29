namespace TheFirm;

internal class Program
{
    static void Main(string[] args)
    {
        Sebastiaan p1 = new Sebastiaan();
        Jacco p2 = new Jacco();
        Patrick p3 = new Patrick();
        Bokito p4 = new Bokito();

        ACME com = new ACME();
        com.Hire( p4);
        com.Hire(p3);
        com.Hire( p2);

        com.Start();
    }
}
