using HR.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HR.Services
{
    public class HROperationService
    {
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            Console.WriteLine("Current Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Waiting for 2 seconds..");
            // await Task.Delay(2000);
            await JustAnotherAsync();

            Console.WriteLine("Current Thread ID: " + Thread.CurrentThread.ManagedThreadId);


            return new List<Employee>
            {
                new Employee { Id=101, Name="Amit", Department="IT", Salary=50000 },
                new Employee { Id=102, Name="Neha", Department="HR", Salary=40000 },
                new Employee { Id=103, Name="Ravi", Department="Finance", Salary=60000 }
            };
        }

        public async Task<double> CalculateBounusAsync(Employee emp)
        {
            Console.WriteLine("Current Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Waiting for 1 seconds..");

            // await Task.Delay(1000);
            Console.WriteLine("Current Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            return emp.Salary * 0.10;

        }

        public async Task SaveEmployeeAsync(Employee emp)
        {
            Console.WriteLine("Current Thread ID: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Waiting for 3 seconds..");

            // await Task.Delay(3000);
            await JustAnotherAsync();
            Console.WriteLine($"Employee saved asynchronously: {emp.Name}");
            Console.WriteLine("Current Thread ID: " + Thread.CurrentThread.ManagedThreadId);

        }

        public async Task JustAnotherAsync()
        {
            Console.WriteLine("This method is called with await...");
        }
    }
}