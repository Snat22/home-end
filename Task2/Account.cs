namespace Task2;

public class Account
{
    double _balance;
    public Account(double bal)
    {
        _balance = bal;
    }
    public void Increment(double cash)
    { 
      _balance -= cash;
    }

    public void Decrement(double ca)
    {
        
      _balance += ca;
    }

    public void ToString()
    {
        System.Console.WriteLine($"Account balance: {_balance}");
    }
}
