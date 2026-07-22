namespace Bank;

class Program
{
    static void Main()
    {
        Transaction txn = new Transaction();

        // Accessing Order Details
        IOrderDetails order = txn;
        order.ShowDetails(); 
        // Output: Showing Order Details: Transaction #12345, Product: Savings Account Subscription

        // Accessing Customer Details
        ICustomerDetails customer = txn;
        customer.ShowDetails();
        // Output: Showing Customer Details: Customer Name: Ravi Tambade, Account: 987654321

        
        
        // Otherwise you can call this methods in interface by casting:
       ((IOrderDetails)txn).ShowDetails();
       ((ICustomerDetails)txn).ShowDetails();
    }
}