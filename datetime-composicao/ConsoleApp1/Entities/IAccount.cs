using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
      interface IAccount
    {
        public int number { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }

        public void Withdraw(double amount);
        public void Deposit(double amount);

    }
}
