using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BookDomain;

namespace BookDomainTest
{
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
            b.YearPublished = 1;

            Assert.IsNotNull(b.Title);
            Assert.AreEqual("Fred Flintstone", b.Title);
        }
    }
}
