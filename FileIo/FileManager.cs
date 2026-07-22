using Emp;
using System.IO;
using System.Text.Json;
namespace Fm;

class FileManager
{
    public void Serialize(List<Employee> employees, string fileName)
    {
        var options = new JsonSerializerOptions { IncludeFields = true };
        string jsonString = JsonSerializer.Serialize(employees, options);
        File.WriteAllText(fileName, jsonString);
    }
     public List<Employee> Deserialize(string fileName)
    {
        string jsonString =  File.ReadAllText(fileName);
        List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(jsonString);

    

        return employees;


    }
}