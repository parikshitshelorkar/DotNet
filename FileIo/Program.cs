using Emp;
using Fm;
using System.Text.Json;

class FileIO
{
    public static void Main(string[] args)
    {
         List<Employee> employees = new List<Employee>
        {
            new Employee(3223, "sumtry bhor", "com"),
            new Employee(3434, "Aditi", "english"),
            new Employee(3434, "Ash", "english"),
            new Employee(3434, "Dhaniya", "com")

        };
        string fileName  ="employee.json";

        FileManager fm = new FileManager();
        fm.Serialize(employees, "employee.json");

        List<Employee> e = fm.Deserialize(fileName);

        foreach (Employee employee in e)
        {
            Console.WriteLine("" + employee.EmployeeId + "" + employee.Name + "" + employee.Department);
        }
           
    }
}