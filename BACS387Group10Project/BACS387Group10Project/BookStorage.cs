using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACS387Group10Project
{
    class BookStorage
    {
        /*
        * MS Instead of returning a String[] here, you could look at using
        * a List<Book>. Passing around a bunch of strings isn't very OO
        */ 
        public string[,] allBooks()
        {
            string[,] booksArray = new String[101, 5];
            int i = 0;
            /*
             * MS You can also add the text file to the project and using the 
             * properties, set it to "copy always". Then you can use just the 
             * filename here instead of using a relative path.
             */
            foreach (string line in File.ReadAllLines("..//..//books.txt"))
            {
                string[] parts = line.Split('-');
                //ISBN 
                booksArray[i, 0] = parts[0];
                //Title
                booksArray[i, 1] = parts[1];
                //Author 
                booksArray[i, 2] = parts[2];
                //Description 
                booksArray[i, 3] = parts[3];
                //number of books instock
                booksArray[i, 4] = parts[4];
                i++;
            }
            return booksArray;
        }

        //Writing a new book to the text file - Take in a string(must be correctly formatted prior to this)
        public void writeBook(string book)
        {
            StreamWriter sw = new StreamWriter("..//..//books.txt", true);
            sw.WriteLine(book);
            sw.Close();
        }

        //Writing the revised book list to the text file
        public void writeAllBooks(string[,] allBooks)
        {
            StreamWriter sw = new StreamWriter("..//..//books.txt", false);
            for (int i = 0; i < 100; i++)
            {
                string writeString = (allBooks[i, 0] + "-" + allBooks[i, 1] + "-" + allBooks[i, 2] + "-" + allBooks[i, 3] + "-" + allBooks[i, 4]);
                if(writeString != "----")
                {
                    sw.WriteLine(writeString);
                }
            }
            sw.Close();
        }
    }
}
