using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BookDomain;

namespace BookDomainTest
{
    public class MockBookRepo : IBookRepository
    {
        //Key value pair - int is linked to the value Book
        public Dictionary<int, Book> Books = new Dictionary<int, Book>();

        public MockBookRepo()
        {
            Books.Add(1, new Book() { ID = 1, YearPublished = 1400, Title = "A", AuthorID = 1, ISBN = "1", Subject = "Foo" });
            Books.Add(2, new Book() { ID = 2, YearPublished = 1400, Title = "B", AuthorID = 1, ISBN = "2", Subject = "Bar" });
        }

        public System.Collections.Generic.List<Book> GetBooks()
        {
            //creating a List of Books called ret
            List<Book> ret = new List<Book>();
            foreach (var b in Books.Values)
                ret.Add(b);
            return ret;

        }

        public Book GetBookByID(int ID)
        {
            
            if (Books.ContainsKey(ID))
            {
                Book value = Books [ID];
                return value;
            }
            return null;
        }

        public System.Collections.Generic.List<Book> GetBooksByAuthor(string authorName)
        {
            return new System.Collections.Generic.List<Book>();
        }

        public bool AddBook(Book book)
        {
            return false;
        }

        public bool UpdateBook(Book book)
        {
            return false;
        }

        public bool DeleteBook(Book book)
        {
            return false;
        }
    }

    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void SimpleBookTest()
        {
            Book b = new Book();
            b.ID = 1234567890;
            b.Title = "Fred Flintstone";
            b.Subject = "Bedrock in photos";
            b.AuthorID = 1;
            b.YearPublished = 1979;

            Assert.IsNotNull(b.Title);
            Assert.AreEqual("Fred Flintstone", b.Title);
        }

        [TestMethod]
        public void FredCannotPublishPriorTo1400()
        {
            Book b = new Book();
            try
            {
                b.YearPublished = 1;
                Assert.Fail("Fred should not be able to publish prior to 1400");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void FredCannotPublishAfterToday()
        {
            Book b = new Book();
            try
            {
                b.YearPublished = 3001;
                Assert.Fail("Fred should not be able to publish after today");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void CanGetBooksFromRepo()
        {
            MockBookRepo mockRepo = new MockBookRepo();

            List<Book> books = mockRepo.GetBooks();
            Assert.IsNotNull(books);
            Assert.IsTrue(books.Count > 0);
        }
    }
}
