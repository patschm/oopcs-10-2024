namespace Rekenen;

delegate int Berekening(int x, int y);

internal class WillemKlein
{
    public void Bereken(Berekening cal, int a, int b)
    {
        Console.WriteLine("Willem Klein gaat nu rekenen");
        int result = cal(a, b);

        Console.WriteLine($"Willem Klein kraait: Het antwoord is {result}");
    }
}
