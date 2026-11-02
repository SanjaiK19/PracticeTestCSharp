using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeTest
{
    class BankAccount
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
        }
        public void Deposit(double amount)
        {
            if(amount <= 0)
            {
                balance += amount;
                Console.WriteLine("Deposit sucessful");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
        public void Withdraw(double amount)
        {
            if ((amount <= 0)) 
            {
                Console.WriteLine("Invalid amount");
            }
            else if(amount > balance)
                Console.WriteLine("insufficient balance");
            else
            {
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal successful");
                }
            }
        }
    }
    public class BankAccountBoundaries
    {
        public static void Main()
        {
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            account1.Deposit(10000);
            account1.Withdraw(5000);

            account2.Deposit(20000);

            Console.WriteLine("Account 1: "+account1.Balance);
            Console.WriteLine("Account 2:"+account2.Balance);

            //account1.balance = 500; // Error : private field

        }
    }
}
