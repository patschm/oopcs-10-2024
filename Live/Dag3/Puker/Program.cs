using System.Diagnostics;
using System.Text;

namespace Puker;

internal class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        Stopwatch sw1 = new Stopwatch();
        sw1.Start();
        for (x = 0; x < 100_000_000; x++)
        {
            DoeIets<object>(x);
        }
        sw1.Stop();
        Console.WriteLine(sw1.Elapsed);
       

        string s = "";
        StringBuilder sb = new StringBuilder(1000000);

        Stopwatch sw = new Stopwatch();
        sw.Start();
        for(int i = 0; i< 100_000;i++)
        {
            //s += i;
            sb.Append(i);
        }
        sw.Stop();
        Console.WriteLine(sw.Elapsed);
    }

    private static void DoeIets<T>(T xx) 
    {
        T c = xx;
        //Console.WriteLine(xx);
    }
}
