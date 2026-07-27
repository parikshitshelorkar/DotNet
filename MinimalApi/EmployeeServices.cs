namespace services;
using System.Collections.Generic;
using emp;

class EmployeeServices
{
    public static List<Employee> GetAllEmployees(List<Employee> employees )
    {
    
        return employees;
    }
    // GET employee by id
    public static Employee GetEmployeesById(List<Employee> employees, int id)
    {
        foreach (Employee employee in employees)
        {
            if (employee.Id == id)
            {
                return employee;
            }
        }

        return null;
    }
    // POST employee
    public static void AddEmployee(List<Employee>employees)
    {
        employees.Add(new Employee { Id = 1, Name = "parikshit", Age = 21, Department = "computer", Salary = 180000, Experience = 1 });
        employees.Add(new Employee { Id = 2, Name = "parikshit", Age = 21, Department = "computer", Salary = 180000, Experience = 1 });
        employees.Add(new Employee { Id = 3, Name = "parikshit", Age = 21, Department = "computer", Salary = 180000, Experience = 1 });
        employees.Add(new Employee { Id = 3, Name = "parikshit", Age = 21, Department = "computer", Salary = 180000, Experience = 1 });
        employees.Add(new Employee { Id = 4, Name = "parikshit", Age = 21, Department = "computer", Salary = 180000, Experience = 1 });
    }

}