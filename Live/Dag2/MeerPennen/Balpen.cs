namespace MeerPennen;

internal class Balpen : Pen
{
    public override void Write(string text)
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Balpen schrijft met Lijndikte {Linewidth}: {text}");
        Console.ResetColor();
    }
}
