using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Title
    {
        private string title;
        public string Heading
        { 
            get { return title; } 
        }
        public Title(string title)
        {
            this.title = title;
        }
       
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
