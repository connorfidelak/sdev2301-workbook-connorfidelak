using System;
using System.Collections.Generic;
using System.Text;

namespace OopPractice.Tests
{
    public class BookTests
    {
        [Fact]

        public void Constructor_ValidValues_SetsProperties()
        {
            var book = new Book("The Bible");

            Assert.Equal("The Bible", book.Title);
        }

        [Fact]

        public void Constructor_BlankTitle_ThrowsArgumentException()
        {
            var book = new Book("")
        }
    }
}
