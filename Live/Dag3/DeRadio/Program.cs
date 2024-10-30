namespace DeRadio;

internal class Program
{
    static void Main(string[] args)
    {
        var p = new Patrick();
        var r538 = new RadioStation();
        r538.Subscribers += OntvangstMethodes.ViaKabel;
        r538.Subscribers += OntvangstMethodes.ViaRooksignalen;
        r538.Subscribers += OntvangstMethodes.ViaEmail;
        r538.Subscribers += OntvangstMethodes.ViaEther;
        r538.Subscribers += OntvangstMethodes.ViaRooksignalen;
        r538.Subscribers += OntvangstMethodes.ViaEmail;
        r538.Subscribers += OntvangstMethodes.ViaRooksignalen;
        r538.Subscribers += OntvangstMethodes.ViaEmail;
        r538.Subscribers += p.ViaPostduif;
        r538.Subscribers += OntvangstMethodes.ViaEther;
        r538.Subscribers += OntvangstMethodes.ViaRooksignalen;
        r538.Subscribers += OntvangstMethodes.ViaEmail;

        r538.Broadcast();

        //r538.Subscribers("Hallo kojo's!");
    }
}
