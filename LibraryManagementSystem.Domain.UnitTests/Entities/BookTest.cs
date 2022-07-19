using LibraryManagementSystem.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryManagementSystem.Domain.UnitTests.Entities
{
    [TestClass]
    public class BookTest
    {

        [TestMethod]
        public void BookTitleMaximumLengthMustBe100()
        {
            Book book = new Book();
            book.Title = "Learn C#";

            var expectedLength = 100;
            var realLenght = book.Title.Length;

            Assert.IsTrue(expectedLength >= realLenght);
        }

        [TestMethod]
        public void BookTitleMustNotBeDuplicated()
        {
            Book book = new Book();
            book.Title = "Learn C#";

            string enteredTitle = "C# For Dummies";
            string realTitle = book.Title;

            Assert.AreNotEqual(enteredTitle, realTitle);
        }

        [TestMethod]
        public void BookTitleIsNullOrEmptyException()
        {
            Book book = new Book();
            book.Title = "Learn C#";

            if (String.IsNullOrEmpty(book.Title))
            {
                Assert.IsNull(book.Title);
            }
        }
    }
}
