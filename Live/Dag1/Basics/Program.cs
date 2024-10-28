namespace Basics;

class Program
{
    static void Main(string[] args)
    {
        // Typenaam variabelenaam;
        int age = 10;
        Console.WriteLine(age);
        int leeftijd = (age + 20) * 3;

        //age = age + 1;
        //age += 1;
        //++age;
        Console.WriteLine(++age);

        bool ba = false;
        bool bb = true;

        bool bres = ba || bb;

        bool bres2 = ba & bb;
        int ia = 1;
        int ib = 2;

        int ires = ia | ib;
        Console.WriteLine(ires);

        bres = ba && Ok();
        Console.WriteLine(bres);

        char? test = null;
        int x = test ?? 42;

        string? s = null;

        //if (s != null)
            Console.WriteLine(s!.Length);
    }

    static bool Ok()
    {
        Console.WriteLine("In ok");
        return false;
    }
}
