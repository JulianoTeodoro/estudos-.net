using System;
using ConsoleApp1.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Alex", 0.0);

            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            Account acc1 = businessAccount;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            BusinessAccount acc4 = (BusinessAccount)acc2;

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!!");
            }
            else
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!!");
            }

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account obj in list)
            {
                sum += obj.balance;
            
            }
            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account obj in list)
            {
                Console.WriteLine("Name: " + obj.holder);
                Console.WriteLine("Account: " + obj.number);
               // obj.Withdraw(200.0);
                Console.WriteLine("Balance: " + obj.balance.ToString("F2", CultureInfo.InvariantCulture));

            }

            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Parse("2000-08-15 20:52:10");
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
        }
    }
}
