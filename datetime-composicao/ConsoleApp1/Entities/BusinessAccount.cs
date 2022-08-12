using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    sealed class BusinessAccount : Account
    {
        public double loanLimit { get; set; }
        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) :base(number, holder, balance)
        {
            this.loanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= loanLimit)
            {
                balance += amount;
            }
        }

        public override void Withdraw(double amount)
        {
            balance += amount + 5.0;
        }


    }
}
