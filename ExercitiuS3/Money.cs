using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiuS3
{
    public class Money
    {
        //2 prop publ auto-implementate
        public decimal Ammount { get; set; }
        public string Currency { get; set; }


        //constructorul cu acelasi nume cu al clasei IMPLICIT
        public Money()
        {
            this.Ammount = 0;
            this.Currency = "EUR";
        }
        //constructorul cu acelasi nume cu al clasei EXPLICIT
        public Money(string currency, decimal ammount)
        {
            this.Currency = currency;
            this.Ammount = ammount;
        }
        //returnare suma si currencyul
        public string GetAmmountWithCurrency()
        {
            return Ammount + "  " + Currency;
        }
        //multiplicare ammount
        public void MultiplyAmmount(decimal n)
        {
            Ammount = Ammount * n;
        }
        //deconstructor
        ~Money()
        {
            Console.WriteLine("ERROR 404");
        }

        


    }
}
