using System;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the title of the book: ");
            string titleOfBook=Console.ReadLine();
            Console.WriteLine("Enter the author of the book: ");
            string authorOfBook=Console.ReadLine();
            Console.WriteLine("Enter the content of the book: ");
            string contentOfBook=Console.ReadLine();
            Book book = new Book(new Title(titleOfBook), new Author(authorOfBook), new Content(contentOfBook));
            Console.WriteLine("The title of the book: ");
            book.Title.Show();
            Console.WriteLine("The author of the book: ");
            book.Author.Show();
            Console.WriteLine("The content of the book: ");
            book.Content.Show();
        }
    }
}