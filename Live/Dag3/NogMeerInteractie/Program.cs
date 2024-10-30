namespace NogMeerInteractie;

internal class Program
{
    static void Main(string[] args)
    {
        var p = new Patrick();
        var j = new Jacco();

        j.Execute(p.DoeIets);
        //p.DoeIets();

    }
}
