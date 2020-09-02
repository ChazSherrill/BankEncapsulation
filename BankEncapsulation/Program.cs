using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var CLSAccount = new BankAccount(10);

            CLSAccount.deposit(2273.32);

            Console.WriteLine(CLSAccount.getBalance());

            CLSAccount.Withdraw(200);
        }
    }
}
