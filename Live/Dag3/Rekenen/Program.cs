namespace Rekenen;

internal class Program
{
    static void Main(string[] args)
    {
        var simon = new SimonVanDeMeer();
        var willem = new WillemKlein();

        //willem.Bereken(simon.Add, 5,8);
        //willem.Bereken(simon.Subtract, 5,8);

        Berekening func = simon.Add;
        func += simon.Add;
        func += simon.Subtract;
        func += simon.Add;
        func -= simon.Subtract;

        foreach (var arg in func.GetInvocationList())
        {
            Console.WriteLine(arg.Method.Name);
        }

        int result = func(1, 2);

        Console.WriteLine(result);


    }
}
