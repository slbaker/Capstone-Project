using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{

    //This is where the database gets called into the program. 
    class DataClass
    {
        //Instanciating a new Book class and initializing a new collection 
        public BooksClass booksClass = new BooksClass();
        public CheckoutlogClass checkoutlogClass = new CheckoutlogClass();


        public void InitializeCollections()
        {

           //DataClasses1DataContext db = new DataClasses1DataContext(@"C:LibraryInformation2");
           //DataClasses1DataContext db = new DataClasses1DataContext (@"C:\Users\shannon\Documents\Visual Studio 2013\Projects\WpfApplication2\WpfApplication2\DataClasses1.dbml");
           //BooksClass booksClass = new BooksClass();
            var db = new DataClasses1DataContext();

            // SQL to query Book in db.Books called datasourcebook
            var queryBook = from datasourcebook in db.Books select datasourcebook;
            // SQL to query the checkoutlog in db. CheckOUtLogs called datasaourceCheckOutLog
            // way to make it look less important || var queryBook = from b in db.Books select b;
            var queryCheckoutlog = from datasourceCheckOutLog in db.CheckOutLogs select datasourceCheckOutLog;
            // the reason we can use "datasource..." is it's a name just used in this SQL call and it's not used elsewhere
            

            foreach (var book in queryBook)
            {
                Book bkBook = new Book(book);
                booksClass[0] = bkBook;

            }

           //CheckoutlogClass checkoutlogClass = new CheckoutlogClass();
           
            foreach (var checkoutlog in queryCheckoutlog)

           {
               CheckOutLog colCheckOutLog = new CheckOutLog(checkoutlog);
               checkoutlogClass[0] = colCheckOutLog;
           }

           PeopleClass peopleClass = new PeopleClass();

            //Jessica's code

            //Initialize People collection
            //var librarianObjects = from l in db.Librarians select l;
            //foreach (Librarian l in librarianObjects)
            //{
            //    var personObject = from p in db.Peoples where p.PersonID == l.ID select p;
            //    foreach (People person in personObject)
            //    {
            //        Librarian lib = new Librarian(person, l.Phone, l.UserID, l.Password);
            //        peopleClass[0] = lib;
            //    }
            //}
            //var authorObjects = from a in db.Authors select a;
            //foreach (Author a in authorObjects)
            //{
            //    var personObject = from p in db.Peoples where p.PersonID == a.ID select p;
            //    foreach (People person in personObject)
            //    {
            //        Author auth = new Author(person, a.Bio);
            //        peopleClass[0] = auth;
            //    }
            //}
            //var cardholderObjects = from c in db.Cardholders select c;
            //foreach (Cardholder c in cardholderObjects)
            //{
            //    var personObject = from p in db.Peoples where p.PersonID == c.ID select p;
            //    foreach (People person in personObject)
            //    {
            //        Cardholder ch = new Cardholder(person, c.Phone, c.LibraryCardID);
            //        peopleClass[0] = ch;
            //    }
            //}

            
        }


    }
}