using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACS387Group10Project
{
    class MyBook
    {
        private APIBook theBook { get; set; }
        public MyBook(APIBook theBook)
        {
            this.theBook = theBook;
        }
        public string Isbn
        {
            get
            {
                return theBook.isbn10;
            }
            set
            {
                theBook.isbn10 = value;
            }
        }
        public string BookTitle
        {
            get
            {
                return theBook.title;
            }
            set
            {
                theBook.title = value;
            }
        }
        public string FirstAuthor
        {
            get { return theBook.author_name.First().name; }
            set { theBook.author_name.First().name = value; }
        }
    }
}
