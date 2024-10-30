using Standaarden;

namespace DoomsdayPreppers;

public class Valkuil: IDetectable
{
    public void Activate()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("De valkuil opent en scherpen spiezen worden zichtbaar");
    }
}
