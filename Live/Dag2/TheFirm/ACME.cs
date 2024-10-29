namespace TheFirm;

internal class ACME
{
    private List<IACMEContract> employees = new List<IACMEContract>();

    public void Hire(IACMEContract employee)
    {
        employees.Add(employee);
    }
    public void Start()
    {
        Console.WriteLine("De stoomfluit gaat");
        Console.Beep(1000, 400);
        foreach (var employee in employees)
        {
            employee.Werken();
        }
    }
}
