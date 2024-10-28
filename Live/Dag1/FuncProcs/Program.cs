namespace FuncProcs;

internal class Program
{
    static void Main(string[] args)
    {
        int getal = GetNumber();
        getal = Add(3, 4, 5);
        ShowNumber(getal);
        getal = Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        Console.WriteLine(getal);
        getal = Add(3, d:1000);
        ShowNumber(getal);

        float nr = Add(3.4F, 4.2F);
        ShowNumber(nr);

        int nummer;// = 100;
        //Console.WriteLine(nummer);
        //int nr = nummer;
        //DoeIets(ref nummer);
        DoeIets2(out nummer);
        Console.WriteLine(nummer);


        DoeIets2(out int xx);
        Console.WriteLine(xx);

    }

    static void DoeIets2(out int nr)
    {
        nr = 10001;
        Console.WriteLine(nr);
    }

    static void DoeIets(ref int nr)
    {
        nr = 1000;
        Console.WriteLine(nr);
    }

    // Procedure
    static void ShowNumber(int arg)
    {
        Console.WriteLine(arg);
    }
    // Overload
    static void ShowNumber(float arg)
    {
        Console.WriteLine(arg);
    }
    // Function
    static int GetNumber()
    {
        return 422;
    }
    static int Add(int a, int b)
    {
        return a + b;
    }
    //static int Add(int a, int b, int c)
    //{
    //    return a + b + c;
    //}
    static int Add(int a, int b = 1, int c = 10, int d = 100)
    {
        return a + b + c + d;
    }
    static int Add(params int[] args)
    {
        return args.Sum();
    }
    static float Add(float a, float b)
    {
        return a + b;
    }
}
