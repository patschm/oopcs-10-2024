using System.Diagnostics;

namespace MeerPennen;

// Vulpen erft van Pen
// Keep it DRY
internal class Vulpen : Pen
{
    private int nrOfWrites = 5;
    
    public int WritesLeft
    {
        get
        {
            return nrOfWrites;
        }
    }
    public void Refill()
    {
        nrOfWrites = 5;
    }
    // Met override _ACTIVEER_ ik polymorfisme
    public override void Write(string text)
    {
        if (--nrOfWrites >= 0)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Vulpen schrijft met Lijndikte {Linewidth}: {text}");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Je vulpen is leeg");
        }
    }
}
