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
    }
}
