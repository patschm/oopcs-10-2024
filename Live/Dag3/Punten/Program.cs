
namespace Punten;

internal class Program
{
    static void Main(string[] args)
    {
       Point p1 = new Point { X = 10, Y=20 };

        Console.WriteLine(p1);
        DoeIets(p1);
        Console.WriteLine(p1);

        string s = "init";
        Console.WriteLine(s);
        DoeIets(s);
        Console.WriteLine(s);
    }

    private static void DoeIets(Point ppp)
    {
        ppp.X = 100;
        ppp.Y = 200;
    }

    private static void DoeIets(string ppp)
    {
        ppp = "Iets anders";
    }
}
