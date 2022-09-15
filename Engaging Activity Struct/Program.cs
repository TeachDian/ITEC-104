struct Employee
{
    public string firstName;
    public string lastName;
    public int age;
    public string completedTraining;
}
class Program{
    public static void Main(string[] args)
    {
        Console.Title = "Stuct";
        Employee employee1;
        employee1.firstName = "Juan";
        employee1.lastName = "Dela Cruz";
        employee1.age = 25;
        employee1.completedTraining = "Yes";

        Console.WriteLine("Name: "+employee1.firstName);
        Console.WriteLine("Last Name: "+employee1.lastName);
        Console.WriteLine("Age: "+employee1.age);
        Console.WriteLine("Completed Training: "+employee1.completedTraining);
        Console.Read();

    }
}