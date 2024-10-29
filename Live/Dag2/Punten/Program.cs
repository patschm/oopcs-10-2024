namespace Punten;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X=10, Y=20 };
        p1.Display();
        Point p2 = new Point { X = 100, Y = 200 };
        p2.Display();

        //Point p3 = new Point();
        Point pres = Point.Add(p1, p2);
        pres.Display();

        Point pres2 = p1 + p2;
        pres2.Display();

        Console.WriteLine(p1 != p2);
    }
}
