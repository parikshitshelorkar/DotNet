namespace Emp;

public class Employee
{
    public int EmployeeId{get; set;}
    public string Name{get; set;}
    public string Department{get; set;}
    public Employee(){
        
    }

    public Employee(int id, string name, string dept)
    {
        EmployeeId=id;
        Name = name;
        Department = dept;

    }   

}