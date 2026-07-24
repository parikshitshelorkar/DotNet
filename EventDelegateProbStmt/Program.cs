using Departments;
using Managers;
using Services;

namespace Insuarance;

public class Program
{
    public static void Main(string[] args)
    {
        PolicyManager policyManager=new PolicyManager();
        SalesDepartment salesDepartment=new SalesDepartment();
        NotificationService notificationService=new NotificationService();

        policyManager.PolicyPurchased+=salesDepartment.OnPolicyPurchased;
        policyManager.PolicyPurchased+=notificationService.WelComeCustomer;

        UIManager uIManager=new UIManager(policyManager);
        uIManager.DisplayMenu();
    }

    
    
}