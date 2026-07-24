namespace Managers;

public class UIManager
{
    private readonly PolicyManager policyManager;

    public UIManager(PolicyManager policyManager)
    {
        this.policyManager = policyManager;
    }

    public void DisplayMenu()
    {
        bool running = true;
        while (running)
        {
         Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("      Insurance Management System");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Purchase Policy");
            Console.WriteLine("2. Pay Premium");
            Console.WriteLine("3. Register Claim");
            Console.WriteLine("4. Renew Policy");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Enter choice: ");

        if(!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please Enter a vlaid Number");
                continue;

            }
            running = HandleMenuChoice(choice);    
        }
        Console.WriteLine("Thank you for using insuance mangement System. ");
    }
    public bool HandleMenuChoice(int choice)
    {
        switch (choice)
        { case 1:
                Console.Write("Enter customer name: ");
                string customerName = Console.ReadLine();
                policyManager.PurchasePolicy(customerName.Trim());
                break;
            case 2:
                Console.Write("Enter policy number: ");
                string premiumPolicyNumber = Console.ReadLine();
                policyManager.PremiumPaid(premiumPolicyNumber.Trim());
                break;
            case 3:
                Console.Write("Enter policy number: ");
                string claimPolicyNumber = Console.ReadLine();
                policyManager.ClaimRegistered(claimPolicyNumber.Trim());
                break;
            case 4:
                Console.Write("Enter policy number: ");
                string renewalPolicyNumber = Console.ReadLine();
                policyManager.PolicyRenewed(renewalPolicyNumber.Trim());
                break;
            case 5:
                return false;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        return true;
    }
    
}