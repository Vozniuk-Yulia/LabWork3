using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;
        public Title Title
        {
            get { return title; }
            set { title = value; }
        }
        public Author Author
        {
            get { return author; }
            set { author = value; }
        }
        public Content Content
        {
            get { return content; }
            set { content = value; }
        }
        public Book(Title title, Author author,Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
    }
}
