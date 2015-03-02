using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class BooksClass
    {
        private List<Book> book = new List<Book>();

        //this is where the code is that allows you to add another book to the collection because of: set { book.Add(value); }
        public Book this[int index]
        {
            get { return book[index]; }
            set { book.Add(value); }
        }

        public List<Book> BookList
        {
            get { return book; }
        }


    }
}
