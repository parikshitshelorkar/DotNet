namespace Bank;

public class Transaction : IOrderDetails, ICustomerDetails
{
    // Implementation specific to order details
    void IOrderDetails.ShowDetails()
    {
        Console.WriteLine("Showing Order Details: Transaction #12345, Product: Savings Account Subscription");
    }

    // Implementation specific to customer details
    void ICustomerDetails.ShowDetails()
    {
        Console.WriteLine("Showing Customer Details: Customer Name: Ravi Tambade, Account: 987654321");
    }

}