namespace DeRadio;

delegate void OntvangstMethode(string bla);

internal class RadioStation
{
    //private OntvangstMethode _subs;
    //public event OntvangstMethode Subscribers
    //{
    //    add
    //    {
    //        _subs += value;
    //    }
    //    remove
    //    {
    //        _subs -= value;
    //    }
    //}

    public event OntvangstMethode Subscribers;

    public void Broadcast()
    {
        Console.WriteLine("Begin uitzending");
        Subscribers?.Invoke("Hallo Luisteraars");
    }
}
