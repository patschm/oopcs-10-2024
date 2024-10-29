using System.Diagnostics;

namespace MeerPennen;

internal abstract class Pen
{
    private int lineWidth = 15;
    public int Linewidth
    {
        get
        {
            return lineWidth;
        }
        set
        {
            if (value >= 0 && value < 100)
            {
                lineWidth = value;
            }
            else
            {
                Debug.WriteLine($"Waarde {value} ongeldig voor property {nameof(Linewidth)}");
            }
        }
    }
    public ConsoleColor Color { get; set; } = ConsoleColor.DarkCyan;

    // Met virtual geef ik aan dat dit gedrag polymorf _KAN_ zijn
    // Polymorf-ready.
    // Een afgeleide class kan optioneel een override doen.
    //public virtual void Write(string text)
    //{
    //    Console.ForegroundColor = Color;
    //    Console.WriteLine($"Lijndikte {Linewidth}: {text}");
    //    Console.ResetColor();
    //}

    // Ik wil nu dat een afgeleide class een override doet. (MOETEN)
    public abstract void Write(string text);
}