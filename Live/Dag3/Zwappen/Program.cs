
namespace Zwappen;

class Program
{
    static void Main()
    {
        Point<short> p1 = new Point<short> { X = 10, Y = 20 };
        Point<short> p2 = new Point<short> { X = 100, Y = 200 };
        Console.WriteLine($"a={p1}, b={p2}");
        Swap(ref p1, ref p2);
        Console.WriteLine($"a={p1}, b={p2}");

        //string sa = "100";
        //string sb = "200";

        //Swap<string>(ref sa, ref sb);
    
        double a = 10.1;
        double b = 20.2;

        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
    }

    //static void Swap(ref int a, ref int b)
    //{
    //    int tmp = a;
    //    a = b;
    //    b = tmp;
    //}
    //static void Swap(ref long a, ref long b)
    //{
    //    long tmp = a;
    //    a = b;
    //    b = tmp;
    //}
    //static void Swap(ref float a, ref float b)
    //{
    //    float tmp = a;
    //    a = b;
    //    b = tmp;
    //}
    static void Swap<T>(ref T a, ref T b) where T : new()
    {
        T tmp = a;
        a = b;
        b = tmp;

        T bla = new T();
    }

    //static T Add<T>(T x, T y)
    //{
    //    return x + y;
    //}
}
