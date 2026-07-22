namespace Banking;

public class SavingAccount : IAccount
{
    public SavingAccount(int AccountNumber, decimal amount)
    {
        this.AccountNumber=AccountNumber;
        this.currBalance=amount;

    }

    private int AccountNumber;
    private decimal currBalance;
    public void Credit(decimal amount)
    {
        currBalance=currBalance+amount+50;

    }
    public void Debit(decimal amount)
    {
        currBalance=currBalance-amount;
    }
    public decimal CheckAvailableBalance()
    {
        return currBalance;
        
    }
}
