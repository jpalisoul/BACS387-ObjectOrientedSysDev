using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACS387Group10Project
{
    class BookFunctions
    {
        //Manual Addition of a book to the system
        public Book manualAddBook(Book book)
        {
            book.check = book.checkISBN(book);
            if(book.check == true)
            {
                string bookToAdd = (book.isbn + "-" + book.title + "-" + book.author + "-" + book.description + "-" + book.stockNum);
                BookStorage addBook = new BookStorage();
                addBook.writeBook(bookToAdd);
            }
            return book;
        }
        public Book addBookAPI(Book book , string data)
        { 
            JObject rawbook = JObject.Parse(data);
            List<JToken> tokens = rawbook["data"].Children().ToList();
            JToken firstToken = tokens.First();
            APIBook mybook = firstToken.ToObject<APIBook>();
            book.title = mybook.title;
            if(mybook.author_name != null)
            {
                if (mybook.author_name.First() != null)
                {
                    book.author = mybook.author_name.First().name;
                }
            }
            book.description = mybook.summary;
            book.stockNum = "1";
            string bookToAdd = (book.isbn + "-" + book.title + "-" + book.author + "-" + book.description + "-" + book.stockNum);
            BookStorage addBook = new BookStorage();
            addBook.writeBook(bookToAdd);
            book.check = true;
            return book;

        }

        //Removing a Book from the Book List
        public Book removeBook(Book removeBook)
        {
            BookStorage books = new BookStorage();
            string[,] listBooks = books.allBooks();
            removeBook.check = false;
            int index = 0;
            while (removeBook.check == false && index < 100)
            {
                if (removeBook.isbn == listBooks[index, 0])
                {
                    removeBook.check = true;
                }
                else
                {
                    index += 1;
                }
            }
            for (int i = index; i < 99; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    listBooks[i, j] = listBooks[i + 1, j];
                }
            }
            books.writeAllBooks(listBooks);
            return removeBook;
        }

        //Searching for a book in the system
        public Book searchBook(Book searchBook)
        {
            BookStorage books = new BookStorage();
            string[,] listBooks = books.allBooks();
            searchBook.check = false;
            int counter = 0;
            while(searchBook.check == false && counter < 100)
            {
                if (searchBook.isbn == listBooks[counter, 0])
                {
                    searchBook.title = listBooks[counter, 1];
                    searchBook.author = listBooks[counter, 2];
                    searchBook.description = listBooks[counter, 3];
                    searchBook.stockNum = listBooks[counter, 4];
                    //Breaking the loop here after gathing above information
                    searchBook.check = true;
                }
                counter += 1;
            }
            if(searchBook.check == false)
            {
                searchBook.isbn = "BOOK IS NOT IN SYSTEM";
            }
            return searchBook;
        }

        public Book editBook(Book editBook)
        {
            BookStorage books = new BookStorage();
            string[,] listBooks = books.allBooks();
            editBook.check = false;
            int counter = 0;
            while (editBook.check == false && counter < 100)
            {
                if (editBook.isbn == listBooks[counter, 0])
                {
                    listBooks[counter, 1] = editBook.title;
                    listBooks[counter, 2] = editBook.author;
                    listBooks[counter, 3] = editBook.description;
                    listBooks[counter, 4] = editBook.stockNum;
                    editBook.check = true;
                }
                counter += 1;
            }
            if(editBook.check == true)
            {
                books.writeAllBooks(listBooks);
            }
            else if(editBook.check == false)
            {
                editBook.isbn = "BOOK IS NOT IN SYSTEM";
            }
            return editBook;
        }
    }
}
