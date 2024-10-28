namespace Arrays;

internal class Program
{
    static void Main(string[] args)
    {
        //int[] nummers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] nummers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] nummers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] nummers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        //nummers[0] = 1;
        //nummers[1] = 2; 

        Console.WriteLine(nummers[5]);

        string[] regels = new string[] { "h", "ha", "hal", "hall", "hallo" };

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine(matrix[1, 1]);

        int[][] jagged = new int[2][];
        jagged[0] = [1, 2, 3];
        jagged[1] = [4, 5, 6, 7, 8, 9];

        List<int> list = new List<int>(100);
        list.Add(1);

        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        int tm = stack.Pop();
        Console.WriteLine($"De stack popt {tm}");

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        tm = queue.Dequeue();
        Console.WriteLine($"De queue dequeue {tm}");

        Dictionary<string, int> dic = new Dictionary<string, int>();
        dic.Add("een", 1);
        dic.Add("twee", 2);
        dic["een"] = 5;
        foreach(KeyValuePair<string, int> pair in dic)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        for (int i = 0; i < regels.Length; i++)
        {
            string tmp = regels[i];
            Console.WriteLine(tmp);
        }

        foreach (string tmp in regels)
        {
            Console.WriteLine(tmp);
        }
        foreach(int tmp in list)
        {
            Console.WriteLine(tmp);
        }
    }
}
