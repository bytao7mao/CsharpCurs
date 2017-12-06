using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Money
    {

        public class Moneyy
        {
            //2 prop publ auto-implementate
            public decimal Ammount { get; set; }
            public string Currency { get; set; }


            //constructorul cu acelasi nume cu al clasei IMPLICIT
            public Moneyy()
            {
                this.Ammount = 0;
                this.Currency = "EUR";
            }
            //constructorul cu acelasi nume cu al clasei EXPLICIT
            public Moneyy(string currency, decimal ammount)
            {
                this.Currency = currency;
                this.Ammount = ammount;
            }
            //returnare suma si currencyul
            public string GetAmmountWithCurrency()
            {
                return Ammount + "  " + Currency;
            }
        }
        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public bool IsNew { get; set; }

            public Category()
            {
                this.Id = 0;
                this.Name = "xyz";
                this.Image = "img";
                this.IsNew = true;
            }

            public Category(int id, string name, string image, bool isnew)
            {
                this.Id = id;
                this.Name = name;
                this.Image = image;
                this.IsNew = isnew;
            }
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public int CategoryId { get; set; }
            public Moneyy Price { get; set; }
            public float WeightInKg { get; set; }


            public Product(int id, string name, string image, int categoryid, Moneyy price, float weightInKg)
            {
                this.Id = id;
                this.Name = name;
                this.Image = image;
                this.CategoryId = categoryid;
                this.Price = price;
                this.WeightInKg = weightInKg;
            }

        }
        public static class Config
        {
            public static string CategoriesFolder { get; set; }
            public static string ProductsFolder { get; set; }
            public static string DatabaseFolder { get; set; }


            class ScopeConfig
            {
                static string CategoriesFolder = "categories";
                static string ProductsFolder = "products";
                static string DatabaseFolder = "database";
            }
        }
    }


}

