namespace DeTorenVanBabel;

internal class Program
{
    static void Main(string[] args)
    {
        //Etage.lift.RoepOp(100);

        Etage[] flat = new Etage[50];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { Verdieping = i };
        }

        flat[34].Call();

        foreach(Etage et in flat)
        {
            Etage.ToonLiftStatus();
        }
    }
}
