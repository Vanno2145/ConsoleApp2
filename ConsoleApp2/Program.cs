using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    public class Book : IComparable<Book>, IComparer<Book>, ICloneable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Book() { }  

        public Book(string title, string author, int year, double price)
        {
            Title = title;
            Author = author;
            Year = year;
            Price = price;
        }

        public int CompareTo(Book other)
        {
            return string.Compare(this.Title, other.Title);
        }
  
        public int Compare(Book x, Book y)
        {
            return x.Price.CompareTo(y.Price);
        }

        public object Clone()
        {
            return new Book(this.Title, this.Author, this.Year, this.Price);
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Year: {Year}, Price: {Price}";
        }
    }

    public class Library : IEnumerable
    {
        private Book[] books;

        public Library(Book[] booksArray)
        {
            books = booksArray;
        }


        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
    static void Main(string[] args)
    {
        
    }    
}


