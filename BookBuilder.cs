using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns
{
    public class BookBuilder
    {

        private Book _book = new Book();

        public BookBuilder setTitle(string title) // the method to set this fields 
        {
            _book.Title = title;
            return this;  // method return self
        }

        public BookBuilder setAuthor(string author) 
        { 
        _book.Author = author;
            return this;
        }

        public BookBuilder setpages(int page)
        {
            _book.Pages = page;
            return this;
        }

        public Book Builder()
        {
            return _book;
        }
    }
}
