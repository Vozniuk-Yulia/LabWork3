using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Invoice
    {
        public const double VAT = 0.2;
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;
        public string Article
        {
            get { return article; }
            set { article = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public int CalculateWithVAT(int value)
        {
            quantity = account / value;
            return (int)((value + (value * VAT)) * quantity);
            
        }
        public int CalculateWithoutVAT(int value)
        {
            quantity = account / value;
            return value*quantity;
        }
        public void Show()
        {
            Console.WriteLine($"Customer: {customer} \nAccount: {account}\nProvider: {provider} \nArticle:{article} \nSum: ");
        }
    }
}
