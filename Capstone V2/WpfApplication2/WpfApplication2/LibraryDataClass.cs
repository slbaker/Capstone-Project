using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{


    class LibraryDataClass
    {

        private int _bookID;
        private string _title;
        private string _author;
        //private string _subject;
        //private string _isbn;
        private string _publisher;
        private string _year;
        private string _copies;
        private string _details;


        //public proptries of Library Data Class
        public int BookID
        {
            get { return _bookID; }
            set { _bookID = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        //public string Subject
        //{
        //    get { return _subject; }
        //    set { _subject = value; }
        //}
        //public string Isbn
        //{
        //    get { return _isbn; }
        //    set { _isbn = value; }
        //}
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Copies
        {
            get { return _copies; }
            set { _copies = value; }
        }
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        //Public Constructor - with 7 paramaters
        // TO DO: set list to only the list of criteria that I'm going to display in my datagrid
        public LibraryDataClass(int bookID, string title, string author, string publisher,
            string year, string copies, string details)


        {
            _bookID = bookID;
            Title = title;
            Author = author;
            Publisher = publisher;
            Year = year;
            Copies = copies;
            Details = details;
        }


    }
}
