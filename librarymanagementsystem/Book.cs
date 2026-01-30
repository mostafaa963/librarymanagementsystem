using System;
using System.Collections.Generic;
using System.Text;

namespace librarymanagementsystem
{
    internal class Book
    {


        public string Titel { get; set; }
        public string Author { get; set; }
        // International Standard Book Number (13 digit)
        public string ISBN { get; set; }
        public bool Borrowing  { get; set; }
        public Book(string titel, string author, string ISBN)
        {
            Titel = titel;
            Author = author;
            this.ISBN = ISBN;
            Borrowing =false;
        }


    }

}
