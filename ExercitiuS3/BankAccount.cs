using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiuS3
{
    public class BankAccount
    {
        //o prop publica auto implementata
        public Money Balance { get; set; }

        public BankAccount()
        {
            
        }

        public BankAccount(Money balance)
        {
            this.Balance = balance;
        }
        public BankAccount(string currency, decimal ammount)
        {
            this.Balance = new Money(currency, ammount);
        }

        public bool HasPositive()
        {
            if (this.Balance.Ammount > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        private bool HasEnough(decimal sum)
        {
            if (this.Balance.Ammount >= sum)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void Deposit(decimal totalAmmount)
        {
            this.Balance.Ammount += totalAmmount;
        }

        public void Withdraw(decimal sumDraw)
        {
            if (this.HasEnough(sumDraw))
            {
                this.Balance.Ammount -= sumDraw;
            }
            else {
                Console.WriteLine("No Money");
            }
            
        }

        public void PrintCurrentBalance()
        {
            Console.WriteLine("In acest moment in cont aveti:" + this.Balance.Ammount + " de tipul: " + this.Balance.Currency);
        }


















    }

    
}
