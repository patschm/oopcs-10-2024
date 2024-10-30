using Standaarden;

namespace Yunex;

public class DetectieLus
{
    private List<IDetectable> _devices = new List<IDetectable>();

    public void Connect(IDetectable detectable)
    {
        _devices.Add(detectable);
    }
    public void Detecteer()
    {
        Console.WriteLine("De detectielus detecteert iets");
        foreach (IDetectable device in _devices)
        {
            device.Activate();
        }
    }
}
