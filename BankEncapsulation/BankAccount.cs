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

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                Balance = value;
            }
        }

        public void deposit(double moneyIn)
        {
            _balance += moneyIn;
        }

        public double getBalance()
        {
            return Balance;
        }

        public void Withdraw(double moneyOut)
        {
            _balance -= moneyOut;
            Console.WriteLine(Balance);
        }
        
    }
}

