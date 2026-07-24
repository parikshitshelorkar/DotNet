namespace Departments;
using Managers;
using Delegates;

public class SalesDepartment
{
    //PolicyManager policyManager=new PolicyManager();
    public void OnPolicyPurchased(string message)
    {
        Console.WriteLine("[Sales Department]");
        Console.WriteLine("New policy sold.");
        //policyManager.PolicyPurchased?.Invoke("Policy Purchased called");

    }
}