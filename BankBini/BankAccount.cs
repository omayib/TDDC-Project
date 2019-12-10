using System;
using System.Collections.Generic;
using System.Text;

namespace BankBini
{
    public class BankAccount
    {
        private string name;
        private double balance;
        public const string DebitAmountExceedBalanceMessage = "Saldo tidak mencukupi";

        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public string getName()
        {
            return this.name;
        }
        public double getBalance()
        {
            return this.balance;
        }
        public void addBalance(double nominal)
        {
            this.balance += nominal;
        }
        public void withDraw(double nominal)
        {
            if (this.balance < nominal)
            {
                throw new ArgumentException(DebitAmountExceedBalanceMessage);
            }
            else
            {
                this.balance -= nominal;
            }
        }
    }
}
