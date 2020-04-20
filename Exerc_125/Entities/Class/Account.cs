using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_125.Entities.Class
{
    class Account
    {
        public int Number  { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double value)
        {
            Balance = (double) Balance - value;

        }

        public void Deposit(double value)
        {
            Balance = (double) Balance + value;
        }



    }
}
