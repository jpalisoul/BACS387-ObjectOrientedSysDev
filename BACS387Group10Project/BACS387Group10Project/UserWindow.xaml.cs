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
using System.Windows.Shapes;

namespace BACS387Group10Project
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        //DO NOT REMOVE THIS
        private void Tabs1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void getBooks_Click(object sender, RoutedEventArgs e)
        {
            BookStorage storage = new BookStorage();
            string[,] showBooks = storage.allBooks();
            string comBookString = "";
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    comBookString = (comBookString + "  " + showBooks[i, j]);
                }
                bookDisplay.Items.Add(comBookString);
                comBookString = "";
            }
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Book searchBook = new Book();
            searchBook.isbn = ISBNInput.Text;
            BookFunctions searchFunction = new BookFunctions();
            searchBook = searchFunction.searchBook(searchBook);

            string searchBookString = (searchBook.isbn + "-" + searchBook.title + "-" + searchBook.author + "-" + searchBook.description + "-" + searchBook.stockNum);
            searchResult.Items.Add(searchBookString);
        }
    }
}
