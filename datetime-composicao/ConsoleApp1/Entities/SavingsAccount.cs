using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        
        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            balance += balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
        }
    }
}
