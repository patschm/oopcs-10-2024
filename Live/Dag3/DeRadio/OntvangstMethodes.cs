namespace DeRadio;

internal class OntvangstMethodes
{
    public static void ViaEmail(string txt)
    {
        Console.WriteLine($"Via Email ontvangen: {txt}");
    }
    public static void ViaKabel(string txt)
    {
        Console.WriteLine($"Via Kabel ontvangen: {txt}");
    }
    public static void ViaRooksignalen(string txt)
    {
        Console.WriteLine($"Via Rooksignalen ontvangen: {txt}");
    }
    public static void ViaEther(string txt)
    {
        Console.WriteLine($"Via Ether ontvangen: {txt}");
    }
}
