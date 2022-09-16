using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffee
{
    public class Book
    {
        public string Title;
        public string author;
        public int pages;

        public Book()
        {

        }

        public Book(string aTitle,string aAuthor,int aPages)
        {
            Title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
