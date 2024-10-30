using Standaarden;

namespace Unifi;

public class Camera: IDetectable
{
    public void Activate()
    {
        StartOpname();
    }

    public void StartOpname()
    {
        Console.WriteLine("De camera begint het drama op te nemen");
    }
}
