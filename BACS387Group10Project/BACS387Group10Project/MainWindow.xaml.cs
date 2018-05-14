using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Net;

namespace BACS387Group10Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CoolTabButton_Click(object sender, RoutedEventArgs e)
        {
            TabItem ti = Tabs1.SelectedItem as TabItem;
            MessageBox.Show("This is " + ti.Header + " tab");
        }

        private void Tabs1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        //Search tab function
        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Book searchBook = new Book();
            searchBook.isbn = ISBNInput.Text;
            BookFunctions searchFunction = new BookFunctions();
            searchBook = searchFunction.searchBook(searchBook);

            string searchBookString = (searchBook.isbn + "-" + searchBook.title + "-" + searchBook.author + "-" + searchBook.description + "-" + searchBook.stockNum);
            searchResult.Items.Add(searchBookString);

        }

        //all book function
        private void getBooks_Click(object sender, RoutedEventArgs e)
        {
            BookStorage storage = new BookStorage();
            string[,] showBooks = storage.allBooks();
            string comBookString = "";
            /*
             * MS for practice, you should try using a foreach loop
             * You will see foreach loops far more often in C# than you
             * see for loops
             */
            bookDisplay.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    comBookString = (comBookString + "  " + showBooks[i,j]);
                }
                bookDisplay.Items.Add(comBookString);
                comBookString = "";
            }
        }

        //add book function
        private void AddBookManually_Click(object sender, RoutedEventArgs e)
        {
            //Data into an object
            Book book = new Book();
            book.isbn = isbn.Text;
            book.title = title.Text;
            book.author = author.Text;
            book.description = description.Text;
            book.stockNum = inStock.Text;

            BookFunctions functions = new BookFunctions();
            book = functions.manualAddBook(book);
            if (book.check == false)
            {
                isbn.Text = "Error Adding Book";
                title.Text = "";
                author.Text = "";
                description.Text = "";
                inStock.Text = "";
            }
            else
            {
                isbn.Text = "Book Addition Successful";
                title.Text = "";
                author.Text = "";
                description.Text = "";
                inStock.Text = "";
            }
        }

        //Editing a books info by 
        private void updateBook_Click(object sender, RoutedEventArgs e)
        {
            Book editBook = new Book();
            editBook.isbn = isbn.Text;
            editBook.title = title.Text;
            editBook.author = author.Text;
            editBook.description = description.Text;
            editBook.stockNum = inStock.Text;

            BookFunctions editfunction = new BookFunctions();
            editBook = editfunction.editBook(editBook);

            if(editBook.check == false)
            {
                isbn.Text = "Error Editing Book Info";
                title.Text = "";
                author.Text = "";
                description.Text = "";
                inStock.Text = "";
            }
            else
            {
                isbn.Text = "Book Edited Sucessfully";
                title.Text = "";
                author.Text = "";
                description.Text = "";
                inStock.Text = "";
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            Book removeBook = new Book();
            removeBook.isbn = removeISBN.Text;

            BookFunctions removeFunction = new BookFunctions();
            removeBook = removeFunction.removeBook(removeBook);
            if(removeBook.check == false)
            {
                removeISBN.Text = "Error Removing Book";
            }
            else
            {
                removeISBN.Text = "Book Removed Successfully";
            }
        }

        private string key = "TE04HVT1";
        private void AddBookAPI_Click(object sender, RoutedEventArgs e)
        {
            Book APIBook = new Book();
            APIBook.isbn = isbnAPI.Text;
            string uri = string.Format(@"http://isbndb.com/api/v2/json/{0}/book/{1}", key, APIBook.isbn);

            WebClient client = new WebClient();
            string data = client.DownloadString(uri);

            BookFunctions access = new BookFunctions();
            APIBook = access.addBookAPI(APIBook , data);
        }
    }
}
