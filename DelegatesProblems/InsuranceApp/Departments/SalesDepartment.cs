namespace Department;
using Managers;
using Delegates;

public class SalesDepartment
{
    public void OnPolicyPurchased(string message)
    {
        Console.WriteLine("[Sales Department]");
        Console.WriteLine("New policy sold.");
        
    }
}