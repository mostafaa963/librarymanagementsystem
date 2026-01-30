using System.Numerics;
using System.Reflection.Emit;

namespace librarymanagementsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Code of Library Mangement  simple System
             * I think if a task is document it is more valuable and more understandable
             * because the code of main is conflict my mind
             * if there any mistakes in the writting ,I apologize for that
            */
            // Adding books to the library
            Library library = new Library();
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
            library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

            // Searching and borrowing books
            Console.WriteLine("Searching and borrowing books...");
            library.BorrowBook("The Great Gatsby");
            library.BorrowBook("1984");
            library.BorrowBook("Harry Potter"); // This book is not in the library

            // Returning books
            Console.WriteLine("\nReturning books...");
            library.ReturnBook("The Great Gatsby");
            //library.BorrowBook("The Great Gatsby");
            library.ReturnBook("Harry Potter"); // This book is not borrowed
            Console.ReadLine();
        }
    }
}
