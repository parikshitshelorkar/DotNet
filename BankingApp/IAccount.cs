namespace Banking;

public interface   IAccount{
    // private AccountNumber;

     void Credit(decimal amount);
      void Debit(decimal amount);
    decimal CheckAvailableBalance();
 
}