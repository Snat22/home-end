using System.Runtime.InteropServices;

namespace Task1;

public class Account
{
    int _id ;
    string _client;
    double _balance = 100.00;

    public void SetBalance(double add)
    {
        
        if (_balance < 0)
        {
            System.Console.WriteLine("Popolnite vash balance :");
        }
        _balance += add;
    }

    public string GetBalanceInfo()
    {
        return $"Your Balance : {_balance}";
    }

    public void SetAccountInfo(int id,string client)
    {
          _id = id;
        _client = client;
        
    }
    public string GetAccountInfo()
    {
          return $"Your ID: {_id}\n Mr.{_client} \n Balance :{_balance}";
       
    }

   
}
