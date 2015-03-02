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

namespace WpfApplication2
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

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
      
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<LibraryDataClass> patronLibraryDataGridList = new List<LibraryDataClass>();
            // TO DO: 
            //Take what is in the text block and compare it to each books, title, author, subject or ISBN 
            // reminder ||  = OR
                     //{  
                //Search for matches in Title, Author, Subject, and ISBN
                //case "ALL":
                //    foreach (Books b in BookCollection.BookList)
                //    {
                //        if ((b.Title.ToUpper().Contains(searchTextBox.Text.ToUpper()) || b.Subject.ToUpper().Contains(searchTextBox.Text.ToUpper()) || b.ISBN.ToString().Contains(searchTextBox.Text))
                //            && b.NumberOfCopies > 0)
                //        {
                //            foreach (var a in peopleCollection.PeopleList)
                //            {
                //                if (b.AuthorID == a.PersonID)
                //                {
                //                    DataCollection result = new DataCollection(b, a);
                //                    dc.Add(result);
                //                }
                //            }
                //        }
                //    }
                //    foreach (People p in peopleCollection.PeopleList)
                //    {
                //        if (p is Authors)
                //        {
                //            if (p.FirstName.ToUpper().Contains(searchTextBox.Text.ToUpper()) || p.LastName.ToUpper().Contains(searchTextBox.Text.ToUpper()))
                //            {
                //                foreach (var b in bookCollection.BookList)
                //                {
                //                    if (b.AuthorID == p.PersonID && b.NumberOfCopies > 0)
                //                    {
                //                        DataCollection result = new DataCollection(b, p);
                //                        bool duplicate = false;
                //                        foreach(var d in dc)
                //                        {
                //                            if (b.BookID == d.ID)
                //                                duplicate = true;
                //                        }
                //                        if (!duplicate)
                //                        {
                //                            dc.Add(result);
                //                        }
                //                    }
                //                }
                //            }
                //        }
                //    }
                //    break;

                //Search for matches in the Title only
                //case "TITLE":
                //    foreach (Books b in BookCollection.BookList)
                //    {
                //        if (b.Title.ToUpper().Contains(searchTextBox.Text.ToUpper()) && b.NumberOfCopies > 0)
                //        {
                //            foreach(var a in peopleCollection.PeopleList)
                //            {
                //                if (b.AuthorID == a.PersonID)
                //                {
                //                    DataCollection result = new DataCollection(b, a);
                //                    dc.Add(result);
                //                }
                //            }
                //        }
                //    }
                //    break;
                   
                //Search for matches in the Author's first and last name only
                //case "AUTHOR":
                //    foreach (People p in peopleCollection.PeopleList)
                //    {
                //        if (p is Authors)
                //        {
                //            if (p.FirstName.ToUpper().Contains(searchTextBox.Text.ToUpper()) || p.LastName.ToUpper().Contains(searchTextBox.Text.ToUpper()))
                //            {
                //                foreach(var b in bookCollection.BookList)
                //                {
                //                    if (b.AuthorID == p.PersonID && b.NumberOfCopies > 0)
                //                    {
                //                        DataCollection result = new DataCollection(b, p);
                //                        dc.Add(result);
                //                    }
                //                }
                //            }
                //        }
                //    }
                //    break;

                //Search for matches in the ISBN only
                //case "ISBN":
                //    foreach (Books b in BookCollection.BookList)
                //    {
                //        if (b.ISBN.ToString().Contains(searchTextBox.Text) && b.NumberOfCopies > 0)
                //        {
                //            foreach (var a in peopleCollection.PeopleList)
                //            {
                //                if (b.AuthorID == a.PersonID)
                //                {
                //                    DataCollection result = new DataCollection(b, a);
                //                    dc.Add(result);
                //                }
                //            }
                //        }
                //    }
                //    break;

                //Search for matches in the Subject only
                //case "SUBJECT":
                //    foreach (Books b in BookCollection.BookList)
                //    {
                //        if (b.Subject.ToUpper().Contains(searchTextBox.Text.ToUpper()) && b.NumberOfCopies > 0)
                //        {
                //            foreach (var a in peopleCollection.PeopleList)
                //            {
                //                if (b.AuthorID == a.PersonID)
                //                {
                //                    DataCollection result = new DataCollection(b, a);
                //                    dc.Add(result);
                //                }
                //            }
                //        }
                //    }
                //    break;

                ////If none of the above terms were selected from the Search In drop down menu, throw an error
                //default:
                //    //TODO: Once error handling class is created, throw an exception here
                //    break;
            //}
            ////Fill grid with search results
            //searchResultsGrid.ItemsSource = dc;


            ////


            PatronDataGrid.ItemsSource = patronLibraryDataGridList;

            //TODO: TEST STUFF DELETE LATER - this is what we need to verify first, then, we can add the above code to call in the data
            //This was to test that the database could connect and show info into the datagrid
            //DataClass dc = new DataClass();
            //dc.InitializeCollections();
            //PatronDataGrid.ItemsSource = dc.booksClass.BookList;
        }
            
      
    }
}
