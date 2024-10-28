namespace ObjectenFabriek;

internal class Program
{
    static void Main(string[] args)
    {
        // Big Bang
        Pen p = new Pen();
        // p.color = ConsoleColor.DarkBlue;
        // p.lineWidth = -4;
        //p.SetLinewidth(-5);
        p.Linewidth = 16;
        p.Write("Hallo");

        Pen p2 = new Pen(7, ConsoleColor.DarkGreen);
        p2.Write("Wereld");

        // Initialisatie via Property initializers
        Pen p3 = new Pen { 
            Linewidth = 30, 
            Color = ConsoleColor.DarkRed 
        };
        p3.Write("Hello World");

        // Big Crunch
    }
}

class Pen
{
    // Fields.
    // Hierin sla je de eigenschappen op.
    private int lineWidth = 15;
    //private ConsoleColor color = ConsoleColor.Black;


    //public void SetLinewidth(int getal)
    //{
    //    if (getal >= 0 && getal < 100)
    //    {
    //        lineWidth = getal;
    //    }
    //}
    //public int GetLinewidth()
    //{
    //    return lineWidth;
    //}

    // Properties
    // Cosmetisch jasje voor de bovenstaande access functies
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
        }
    }

    // Auto-generating propertie
    // Brengt zijn eigen private field mee.
    public ConsoleColor Color { get; set; } = ConsoleColor.DarkCyan;

    // Het gedrag leg je vast in functies/procedures.
    // In deze context Methods
    public void Write(string text)
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Lijndikte {Linewidth}: {text}");
        Console.ResetColor();
    }

    // Constructor
    // Bedoeld om fields van een initiele waarde te voorzien.
    public Pen() : this(10, ConsoleColor.Black)
    {
        Console.WriteLine("Constructor");
        //lineWidth = 10;
        //color = ConsoleColor.Black;
    }
    public Pen(int lineWidth, ConsoleColor color)
    {
        Linewidth = lineWidth;
        this.Color = color;
    }
}

