using System.Threading.Channels;

namespace EvolutieTheorieDerDelegates;

delegate int Math(int a, int b);

internal class Program
{
    static void Main(string[] args)
    {
        // 2002. Framework 1.0/1.1
        Math m1 = new Math(Add);
        int res = m1(1, 2);

        // 2005. Framework 2.0
        Math m2 = Add;
        res = m2(2,3);

        int c = 100;

        Math m3 = delegate (int a, int b)
        {
            return a + b + c;
        };
        res = m3(3,4);

        // 2008. Framework 3.0/3.5
        Math m4 = (int a, int b) =>
        {
            return a + b;
        };
        res = m4(4, 5);

        Math m5 = (a, b) => a + b;
        res = m5(5, 6);

        // 1) Procedures
        Action<string> a1 = (s) => Console.WriteLine(s);
        a1("Hallo");

        // 2) Functions
        Func<int, int, int> m6 = Add;
        res = m6(6,7);

        Func<int, int, int> m7 = (x,y) => x+y;
        res = m7(7,8);

        res = InlineAdd(8, 9);

        Console.WriteLine(res);

        int InlineAdd(int a, int b)
        {
            return a + b + c;
        }
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
