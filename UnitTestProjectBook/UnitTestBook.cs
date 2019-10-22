using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryBook;
using System;

namespace UnitTestProjectBook
{
    [TestClass]
    public class UnitTestBook
    {
        [TestMethod]
        public void TestMethodAuthor()
        {
            //Act
            var book = new Book()
            { Author = "Jeff", Title = "TS",PageNumber=900,ISBN13="abcdefghij123" };

            //Arrange
            var actualAuthor = book.Author;

            //Assert
            Assert.AreEqual("Jeff", actualAuthor);
        }

        [ExpectedException(typeof(ArgumentException))]
        [DataTestMethod]
        [DataRow("A")]
        [DataRow("")]
        [DataRow(null)]
        public void TestMethodTitleArgumentException(string title)
        {
            //Act
            var book = new Book()
            { Author = "test", Title = title, PageNumber = 900, ISBN13 = "abcdefghij123" };

            //Arrange
            
            //Assert
            //If no argument exception is thrown the test must fail
            Assert.Fail();
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataTestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(1001)]
        public void TestMethodPageArgumentException(int pagenumber)
        {
            //Act
            var book = new Book()
            { Author = "test", Title = "TS", PageNumber = pagenumber , ISBN13 = "abcdefghij123" };

            //Arrange

            //Assert
            //If no argument exception is thrown the test must fail
            Assert.Fail();
        }

        [ExpectedException(typeof(ArgumentException))]
        [DataTestMethod]
        [DataRow("123456789012")]
        [DataRow("12345678901234")]
        [DataRow("")]
        public void TestMethodISBNArgumentException(string isbn)
        {
            //Act
            var book = new Book()
            { Author = "test", Title = "TS", PageNumber = 999, ISBN13 = isbn };

            //Arrange

            //Assert
            //If no argument exception is thrown the test must fail
            Assert.Fail();
        }

    }
}
