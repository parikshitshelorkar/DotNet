namespace Banking;

public class Bank
{
    
       public static void Main(String[] args)
       {
        IAccount refInterface = new BankAccount(122345, 500);

        //refInterface=new SavingAccount(65444, 1500);
        refInterface.CheckAvailableBalance();
        refInterface.Credit(50000);

        
    }
}
 