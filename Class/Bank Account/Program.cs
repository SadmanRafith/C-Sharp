using System;

class BankAccount
{
    //Attributes
    public string AccountNumber;
    public string AccountHolder;
    public double Balance;

    //Parameterized Constructor
    public BankAccount(string accountNumber, string accountholder, double balance)
    {
        this.AccountNumber = accountNumber;
        this.AccountHolder = accountholder;
        this.Balance = balance;
    }

    //Method to deposit money
    public void Deposit(double amount) 
    { 
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"${amount} deposited Successfully");
        }
        else
        {
            Console.WriteLine("Invalid Deposit Amount.");
        }
    }

    //Method to Withdraw money
    public void withdraw(double amount)
    {
        if (amount > 0 && amount<= Balance) 
        {
            Balance -= amount;
            Console.WriteLine($"${amount} withdrawn successfully ");
        }
        
        else if (amount < 0)
        {
            Console.WriteLine("Invalid Withdrawal Amount. Amount must be greater than zero");
        }

        else
        {
            Console.WriteLine("Not Enough Balance");
        }
    }

    //Method to Show Current Balance
    public void ShowBalance()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Current Balance: ${Balance}");

    }
}

namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("123456678","Rafith", 50000);
            b1.ShowBalance();
            Console.WriteLine();

            b1.Deposit(10000);
            b1.withdraw(1000);
            Console.WriteLine();
            b1.ShowBalance();

        }
    }
}
