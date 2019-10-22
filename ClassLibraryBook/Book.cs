using System;

namespace ClassLibraryBook
{
    /// <summary>
    /// model class for a book
    /// </summary>
    public class Book
    {
        private string title;

        /// <summary>
        /// Title of the book, Title must have an length of minimum two characters
        /// </summary>
        public string Title
        {
            get { return title; }
            set {
                if (String.IsNullOrEmpty(value) || value.Length < 2  )
                    throw new ArgumentException("Length of title is should be minimum two characters");
                title = value;
            }
        }

        /// <summary>
        /// Author of the book
        /// </summary>
        public string Author { get; set; }

        private int pageNumber;

        /// <summary>
        /// Number of pages in the book
        /// </summary>
        public int PageNumber
        {
            get { return pageNumber; }
            set {
                if (value <= 10 || value > 1000)
                    throw new ArgumentOutOfRangeException("Pagenumber should be between 10 and 1000");
                pageNumber = value;
            }
        }

        private string isbn13;

        /// <summary>
        /// ISBN, must be excatly 13 characters long
        /// </summary>
        public string ISBN13
        {
            get { return isbn13; }
            set {
                if (value.Length != 13)
                    throw new ArgumentException("ISBN should be exactly 13 characters");
                isbn13 = value; }
        }



    }
}
