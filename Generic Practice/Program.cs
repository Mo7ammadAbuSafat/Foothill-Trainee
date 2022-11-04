using Generic_Practice;

class RunTime
{
    public static void Main(string[] args)
    {
        Employee m1 = new(12, "ahmad");
        Employee m2 = new(1, "murad");
        Repo<Employee> rm = new();
        rm.Add(m1);
        rm.Add(m2);
        rm.Save();
        Console.WriteLine();
        Organization o1 = new(13, "mohammad");
        Organization o2 = new(3, "obada");
        Repo<Organization> ro = new();
        ro.Add(o1);
        ro.Add(o2);
        ro.Save();
    }
}