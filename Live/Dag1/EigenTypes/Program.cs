namespace EigenTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dag = 3;
            WeekDay day = WeekDay.Saturday;
            Console.WriteLine(day);

            Console.WriteLine((WeekDay)dag);

            //WeekDay dagx = (WeekDay)Enum.Parse(typeof(WeekDay), "Sunday");

        }
    }

    enum WeekDay : ulong
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday =64
    }

}
