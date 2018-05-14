using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACS387Group10Project
{
    class Book
    {
        //Object that stores book information
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string stockNum { get; set; }
        public bool check { get; set; }

        //Supplement function to set the bool in the book information to see if the ISBN is valid
        public bool checkISBN(Book book)
        {
            if(book.isbn.Length == 10)
            {
                int sum = 0;
                for (int i = 0; i < 9; i++)
                    sum += (10 - i) * Int32.Parse(isbn[i].ToString());
                int rem = sum % 11;
                int digit = 11 - rem;
                if (digit == 10)
                    book.check = false;
                else
                    book.check = true;
                return book.check;
            }
            else if(book.isbn.Length == 13)
            {
                int sum = 0;
                for (int i = 0; i < 12; i++)
                    sum += (i % 2 == 0) ? 1 : 3 * Int32.Parse(isbn[i].ToString());
                int rem = sum % 10;
                int digit = 10 - rem;
                if (digit == 10)
                    book.check = false;
                else
                    book.check = true;
                return book.check;
            }
            else
            {
                book.check = false;
                return book.check;
            }
        }
    }
}
