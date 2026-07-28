using HR.Models;
using HR.Services;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("HR System Started..\n");
        HROperationService service = new HROperationService();
        Console.WriteLine("The Current Thread Id: "+Thread.CurrentThread.ManagedThreadId);
        var employees = await service.GetEmployeesAsync();
        Console.WriteLine("The Current Thread Id: "+Thread.CurrentThread.ManagedThreadId);

        Console.WriteLine("Employees Loaded: ");
        employees.ForEach(e => Console.WriteLine(e));

        Console.WriteLine("The Current Thread Id: "+Thread.CurrentThread.ManagedThreadId);

        Console.WriteLine("\nCalculating bonus Asynchronously..");
        double bonus = await service.CalculateBounusAsync(employees[0]);
        Console.WriteLine($"Bonus for {employees[0].Name}: {bonus}");
        Console.WriteLine("The Current Thread Id: "+Thread.CurrentThread.ManagedThreadId);

        await service.SaveEmployeeAsync(employees[0]);
        Console.WriteLine("The Current Thread Id: "+Thread.CurrentThread.ManagedThreadId);

        Console.WriteLine("\nHR System Completed..!");
    }
}