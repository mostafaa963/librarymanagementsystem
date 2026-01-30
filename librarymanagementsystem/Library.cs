using System;
using System.Collections.Generic;
using System.Text;

namespace librarymanagementsystem
{
    internal class Library
    {
        List<Book> Books=new List<Book>();
        public Library()
        {
            
        }
        public void PrintBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"Title: {book.Titel}, Author: {book.Author}, ISBN: {book.ISBN}, Borrowed: {book.Borrowing}");
            }
        }   
        public Book? seacheBook(string titel)
        {
            foreach (var book in Books)
            {
                if (book.Titel == titel)
                {
                    return book;
                }
            }

            return null;
        }
        public Book? BorrowBook(string Titel)
        {
            Book Borrowing = seacheBook(Titel);
            if (Borrowing != null)
            {
                if (Borrowing.Borrowing == false)
                {
                    Borrowing.Borrowing = true;
                    Console.WriteLine($"Borrowing: {Borrowing.Titel} by {Borrowing.Author}");
                    return Borrowing;
                }
                else
                {
                    Console.WriteLine("is Already Borrowing...");
                    return Borrowing;
                }

            }
            else
            {
                Console.WriteLine($"tThis book is not in the library");
            }
            return null;
        }
        public bool ReturnBook(string title)
        {
            Book Returning = seacheBook(title);
            if (Returning != null)
            {
                if (Returning.Borrowing == false)
                {
                    Console.WriteLine("this Book is not Borrowing...");
                    return false;
                }
                else
                {
                    Console.WriteLine($"Return Book: {Returning.Titel} by {Returning.Author}");
                    Returning.Borrowing = false;
                    return true;
                }
            }
            else {
                Console.WriteLine($"this Book is not in my Library");
            }
                return false;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}
