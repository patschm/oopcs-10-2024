namespace MeerPennen;

internal class Program
{
    static void Main(string[] args)
    {

        Pen p1 = new Vulpen { Color = ConsoleColor.DarkBlue };
        for(int i = 0;i <= 5;i++)
        {
            p1.Write($"Hello {i}");
            Console.WriteLine($"Je kunt nog  keer schrijven");
        }

        // Dit noemen wij Generaliseren!!!
        // Vulpen is een pen (is-a relatie)
        Pen p2 = new Vulpen { Color= ConsoleColor.Green };
        //(p2 as Vulpen).Refill();
        //p2.Write("Green");
        DoWrite(p2);
        Pen p3 = new Balpen { Color= ConsoleColor.Red, Linewidth = 5 };
        // p3.Write("Rood");
        Pen p = p3;
        DoWrite(p3);

    }

    static void DoWrite(Pen p)
    {
        p.Write("Pen");
    }
    //static void DoWrite(Vulpen p)
    //{
    //    p.Write("Vulpen");
    //}
    //static void DoWrite(Balpen p)
    //{
    //    p.Write("Balpen");
    //}
}
