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

namespace LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataClasses1DataContext dtx = new DataClasses1DataContext();
            #region GetData

            //var result = from b in dtx.Books
            //             where b.Pages > 50
            //             select b;
            //var result = dtx
            //             .Books
            //             .Where(b => b.Pages > 50);


            //var result = from b in dtx.Books
            //             where b.Pages > 50
            //             select new
            //             {
            //               b.Id,
            //               b.Name,
            //               b.Pages
            //             };


            //var result = from b in dtx.Books
            //             where b.Pages > 50
            //             select new
            //             {
            //                 b.Id_Category,
            //                 b.Category.Name,
            //                 b.Pages
            //             };

            //var result = from a in dtx.Authors
            //             where a.Id == 1
            //             select a;


            //var result = from c in dtx.S_Cards
            //             group c by c.Id_Book into mygroup
            //             select new { mygroup.Key,mygroup.First().Book.Name,mygroup.First().Student };


            //var result = from c in dtx.S_Cards
            //             group c by c.Id_Book into mygroup
            //             select mygroup;
            //var mylist = new List<S_Card>();
            //foreach (var item in result)
            //{
            //    foreach (var i in item)
            //    {
            //        mylist.Add(i); 
            //    }
            //}
            //mydatagrid.ItemsSource = mylist;

            //var result = dtx.S_Cards
            //    .GroupBy(c => c.Id_Book)
            //    .Select(g => new { g.First().Book.Name, Count = g.Count() })
            //    .OrderByDescending(o=>o.Count)
            //    .Take(3);


            //var result = from book in dtx.Books
            //             where book.Id == (from s in dtx.S_Cards
            //                               orderby s.Id descending
            //                               select s.Id_Book)
            //             .First()
            //             select book;


            //var result = from b in dtx.Books
            //             join a in dtx.Authors on b.Id_Author
            //             equals a.Id
            //             select new { b.Name, a.FirstName };


            //mydatagrid.ItemsSource = result;

            #endregion


            #region InsertToDb

            //dtx.Books.InsertOnSubmit(new Book
            //{
            //    Id=1155,
            //    Name="My Super Book",
            //    Pages=10000,
            //    YearPress=2021,
            //    Id_Category=1,
            //    Id_Author=1,
            //    Id_Press=1,
            //    Id_Themes=1
            //});

            #endregion



            #region Update

            var book = dtx.Books.FirstOrDefault(b => b.Id == 1);
            book.Pages = 0;
            book.Id_Author = 4;
            book.Name = "Sehife Sayi Sifirlandi";
            dtx.SubmitChanges();

            #endregion



            #region Delete

            //var book = dtx.Books.FirstOrDefault(b => b.Id == 1155);
            //dtx.Books.DeleteOnSubmit(book);
            //dtx.SubmitChanges();
            #endregion


            var result = from b in dtx.Books
                         select b;
            mydatagrid.ItemsSource = result;
        }
    }
}
