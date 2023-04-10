using System;
using System.Globalization;
using Exercicio.Entities.Exceptions;

namespace Exercicio.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double Withdrawlimit { get; private set; }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            Withdrawlimit = withdrawLimit;
        }
         
        public void deposit(double quantity)
        {
            Balance += quantity;
        }

        public void Withdraw(double quantity)
        {    
            if(quantity > Withdrawlimit)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }
            if (quantity > Balance || Balance <= 0)
            {
                throw new DomainException("Not enough balance.");
            }
            Balance -= quantity;
        }

        public override string ToString()
        {
            return $"New balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
