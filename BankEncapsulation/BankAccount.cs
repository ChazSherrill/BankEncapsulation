using System;
namespace BankEncapsulation
{
    public class BankAccount
   {
        private double _balance;
            
        public BankAccount(double initialDeposit)
        {
            _balance = initialDeposit;
        }

        public void deposit(double moneyIn)
        {
            _balance += moneyIn;
        }

        public double getBalance()
        {
            return _balance;
        }

        public void Withdraw(double moneyOut)
        {
            _balance -= moneyOut;
            Console.WriteLine(_balance);
        }
        
    }
}

