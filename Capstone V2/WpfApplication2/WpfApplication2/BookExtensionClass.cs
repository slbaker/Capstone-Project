using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{

    public partial class Book
    {
        //This is aparamater that I can call from anywhere now to count the number of books available
        //by using the number of copies minus the number of books checked out.
        public int Availability
        {
            get
            { 
                DataClass dc = new DataClass();
                int count = 0;

                foreach (var co in dc.checkoutlogClass.CheckOutLog)
                {
                    if (co.BookID == this.BookID)
                    {
                        count++;
                    }
                }

                return this.NumberOfCopies - count;
            }

        }



        public Book (int bookID, string isbn, string title, int authorID, int numPages, string subject, string description, string publisher,
            int yearPublished, string language, int copiesAvailable)
        {
            this._BookID = bookID;
            this._ISBN = isbn;
            this._Title = title;
            this._AuthorID = authorID;
            this._NumPages = numPages;
            this._Subject = subject;
            this._Description = description;
            this._Publisher = publisher;
            this._YearPublished = yearPublished;
            this._Language = language;
            this._NumberOfCopies = copiesAvailable;
        }

        public Book(Book book)
        {
            this._BookID = book._BookID;
            this._ISBN = book._ISBN;
            this._Title = book._Title;
            this._AuthorID = book._AuthorID;
            this._NumPages = book._NumPages;
            this._Subject = book._Subject;
            this._Description = book._Description;
            this._Publisher = book._Publisher;
            this._YearPublished = book._YearPublished;
            this._Language = book._Language;
            this._NumberOfCopies = book._NumberOfCopies;
        }
    }
}
