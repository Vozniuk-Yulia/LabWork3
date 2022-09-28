using System;
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(10000, "Yulia", "Xiomi");
            invoice.Article = "Phone";
            Console.WriteLine("Enter the price of 1 goods: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("1 - Calculate with VAT");
            Console.WriteLine("2 - Calculate without VAT");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("With VAT");
                    invoice.Show();
                    Console.Write(invoice.CalculateWithVAT(price));
                    break;
                case 2:
                    Console.WriteLine("Without VAT");
                    invoice.Show();
                    Console.Write(invoice.CalculateWithoutVAT(price));
                    break;
                default:
                    Console.WriteLine("Wrong");
                    break;
            }
        }
    }
}