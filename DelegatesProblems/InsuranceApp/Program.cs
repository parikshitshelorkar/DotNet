using Department;
using Managers;
using Services;

namespace Insurance;


public class Program
{
    public static void Main(string[] args)
    {
        PolicyManager policyManager = new PolicyManager();
        SalesDepartment salesDepartment = new SalesDepartment();
        NotificationService notificationService = new NotificationService();

        policyManager.PolicyPurchased+=salesDepartment.OnPolicyPurchased;
        policyManager.PolicyPurchased+=notificationService.WelcomeCustomer;

        UIManager uIManager = new UIManager(policyManager);
        uIManager.DisplayMenu();

    }
}