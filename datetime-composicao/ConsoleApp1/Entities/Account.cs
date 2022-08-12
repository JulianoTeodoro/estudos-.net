using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    abstract class Account : IAccount
    {
        public int number { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            if (balance > amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Saque negado!");
            }
        }

        public virtual void Deposit(double amount)
        {
            balance += amount;
        }
    }
}
