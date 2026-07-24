namespace Managers;
using Delegates;

public class PolicyManager
{
    public event InsuranceAction? PolicyPurchased;
    public event InsuranceAction? PremiumPay;
    public event InsuranceAction? ClaimRegister;
    public event InsuranceAction? PolicyRenew;

    public void PurchasePolicy(string customerName)
    {
        string message = $"Policy purchased for {customerName}.";
        Console.WriteLine("Policy purchase completed.");
        PolicyPurchased?.Invoke(message);
    }

    public void PremiumPaid(string policyNumber)
    {
        string message = $"Premium payment received for policy {policyNumber}.";
        Console.WriteLine("Premium payment completed.");
        PremiumPay?.Invoke(message);
    }

    public void ClaimRegistered(string policyNumber)
    {
        string message = $"Claim registered for policy {policyNumber}.";
        Console.WriteLine("Claim registration completed.");
        ClaimRegister?.Invoke(message);
    }

    public void PolicyRenewed(string policyNumber)
    {
        string message = $"Policy {policyNumber} renewed successfully.";
        Console.WriteLine("Policy renewal completed.");
        PolicyRenew?.Invoke(message);
    }
}

