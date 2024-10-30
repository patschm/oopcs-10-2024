using Standaarden;

namespace Gelro;

public class Hek : IDetectable
{
    public void Activate()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Het hek gaat open");
    }
}
