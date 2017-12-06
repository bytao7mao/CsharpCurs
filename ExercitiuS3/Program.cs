using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiuS3
{
    class Program
    {
        static void Main(string[] args)
        {

            var j = 0;


            Money myBalance = new Money();
            myBalance.Ammount = 20;
            myBalance.Currency = "EUR";
            BankAccount myAccount = new BankAccount();
            myAccount.PrintCurrentBalance();
            myAccount.Deposit(10);
            myAccount.PrintCurrentBalance();
            myAccount.Withdraw(100);
            myAccount.PrintCurrentBalance();
            myAccount.Withdraw(15.5M);
            myAccount.PrintCurrentBalance();


            //metoda implicita
            Money salariuA = new Money();
            salariuA.Ammount = 20;
            salariuA.Currency = "RON";

            //metoda explicita
            Money salariuB = new Money("YENI", 90);
            //multiplicare salariuB
            salariuB.MultiplyAmmount(5.25M);

            Console.WriteLine("Salariul A este: {0}, SAlariul B este: {1}" ,salariuA.GetAmmountWithCurrency(), salariuB.GetAmmountWithCurrency() );
            
            //Accesarea membrilor statici se face prin numele clasei.
            Console.ReadLine();
        }
    }
}
