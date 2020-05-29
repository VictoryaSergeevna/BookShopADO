using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;


namespace AdoExamBooks
{
    public partial class FormMain : Form
    {
        Book_ShopEntities bd = null;
        Books b = null;
        Users u = null;
        Authors a = null;
        Themes t = null;
        Sales s = null;
        int userId = 0;
        public FormMain(Users new_user, int userId)
        {
            InitializeComponent();
            this.u = new_user;
            this.userId = userId;
            textBoxLog.Text = u.Login.ToString();
            bd = new Book_ShopEntities();
            bd.Books.Load();
            dataGridViewAllBooks.DataSource = bd.Books.Local.ToBindingList();
            dataGridViewAllBooks.Columns["Themes"].Visible = false;
            dataGridViewAllBooks.Columns["Authors"].Visible = false;
            dataGridViewAllBooks.Columns["Publishers"].Visible = false;
            dataGridViewAllBooks.Columns["Discounts"].Visible = false;
            dataGridViewAllBooks.Columns["NextTome"].Visible = false;
            dataGridViewAllBooks.Columns["Reservations"].Visible = false;
            dataGridViewAllBooks.Columns["Sales"].Visible = false;
        }

        private void buttonSerch_Click(object sender, EventArgs e)
        {
            b = new Books();
            a = new Authors();
            t = new Themes();
            SearchForm f = new SearchForm(b, a, t);
            f.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            b = new Books();
            AddForm f = new AddForm(b);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Books tmp = bd.Books.Where(x => x.Id_Theme == b.Id_Theme && x.Id_Author == b.Id_Author && x.Id_Publisher == b.Id_Publisher
                  && x.NameBook == b.NameBook && x.Pages == b.Pages && x.Year == b.Year && x.ProductPrice == b.ProductPrice).FirstOrDefault();
                if (tmp == null)
                {
                    bd.Books.Add(b);
                    bd.SaveChanges();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = dataGridViewAllBooks.SelectedRows[0].Index;
            int Id = 0;
            bool converted = Int32.TryParse(dataGridViewAllBooks[0, index].Value.ToString(), out Id);
            if (converted == false)
                return;
            b = bd.Books.Find(Id);
            AddForm f = new AddForm(b);
            if (f.ShowDialog() == DialogResult.OK)
            {
                bd.SaveChanges();
                dataGridViewAllBooks.Update();
                dataGridViewAllBooks.Refresh();
                MessageBox.Show("Данные отредактированные!");
            }
            else
            {
                MessageBox.Show("Не удалось отредактировать данные!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (dataGridViewAllBooks.SelectedRows.Count == 1)
            {
                int index = dataGridViewAllBooks.SelectedRows[0].Index;
                int Id = 0;
                bool converted = Int32.TryParse(dataGridViewAllBooks[0, index].Value.ToString(), out Id);
                if (converted == false)
                    return;
                b = bd.Books.Find(Id);
                bd.Books.Remove(b);
                bd.SaveChanges();
                dataGridViewAllBooks.Update();
                dataGridViewAllBooks.Refresh();
                MessageBox.Show("Обьект удален!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить данные!");
            }

        
    }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
               

            if (dataGridViewAllBooks.SelectedRows.Count == 1)
            {
                int index = dataGridViewAllBooks.SelectedRows[0].Index;
                int Id = 0;
                if (Int32.TryParse(dataGridViewAllBooks[0, index].Value.ToString(), out Id))
                {
                    var deleteObj = from item in bd.Books where item.Id_Book == Id select item;
                    foreach (var item in deleteObj)
                    {
                        bd.Books.Remove(item);

                        Sales newSale = new Sales() { Id_Book = Id, Id_Buyer=this.userId, Quantity = 1, SalePrice = item.ProductPrice };
                        bd.Sales.Add(newSale);                      

                    }
                }
                else
                {
                    MessageBox.Show("Выберите одну книгу!");
                }
                dataGridViewAllBooks.DataSource = null;
                dataGridViewAllBooks.DataSource = bd.Books.Local.ToBindingList();
                dataGridViewAllBooks.Refresh();
                dataGridViewAllBooks.Update();
            }
        }

        private void buttonMostPopular_Click(object sender, EventArgs e)
        {
            b = new Books();
            a = new Authors();
            s = new Sales();
            t = new Themes();
            var query = bd.Sales.GroupBy(x => x.Id_Book).Select(s => new
            {
                id = s.Key,
                count = s.Count()
            }).OrderByDescending(s => s.count).ToList();
            var item = (from b in bd.Books
                        join s in bd.Sales on b.Id_Book equals s.Id_Book
                        group s by new { b.NameBook, s.Id_Book } into gr
                        select new
                        {
                            gr.Key.NameBook,
                            maxSales = gr.Sum(g => g.Quantity)
                        }).OrderByDescending(x => x.maxSales).Take(5).ToList();
            dataGridViewAllBooks.DataSource = null;
            dataGridViewAllBooks.DataSource = item;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

            var item = (from b in bd.Books
                        join s in bd.Sales on b.Id_Book equals s.Id_Book
                        join d in bd.Discounts on b.Id_Book equals d.Id_Book

                        select new
                        {
                            book = b.NameBook,
                           oldPrice=s.SalePrice,
                           newPrice = ((double)s.SalePrice-((double)s.SalePrice*d.DiscountPercent))                           
                            
                        }).ToList();
            dataGridViewAllBooks.DataSource = null;
            dataGridViewAllBooks.DataSource = item;
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            //bd.Configuration.LazyLoadingEnabled = true;
            //bd = new Book_ShopEntities1();
            //var selected = bd.InfoBook;
            //StringBuilder builder = new StringBuilder();
            //foreach (InfoBook book in selected)
            //{
            //    builder.AppendLine($"{book.NameBook} {book.Fullname_Author}");
            //}
            //dataGridViewAllBooks.DataSource = null;
            //dataGridViewAllBooks.DataSource = builder.ToString();

            bd = new Book_ShopEntities();
            var new_book = bd.InfoBook.OrderBy(x => x.NameBook).ToList();
            dataGridViewAllBooks.DataSource = null;
            dataGridViewAllBooks.DataSource = new_book;


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            bd = new Book_ShopEntities();
            bd.Books.Load();
            dataGridViewAllBooks.DataSource = bd.Books.Local.ToBindingList();
            dataGridViewAllBooks.DataSource = bd.Books.Local.ToBindingList();
            dataGridViewAllBooks.Columns["Themes"].Visible = false;
            dataGridViewAllBooks.Columns["Authors"].Visible = false;
            dataGridViewAllBooks.Columns["Publishers"].Visible = false;
            dataGridViewAllBooks.Columns["Discounts"].Visible = false;
            dataGridViewAllBooks.Columns["NextTome"].Visible = false;
            dataGridViewAllBooks.Columns["Reservations"].Visible = false;
            dataGridViewAllBooks.Columns["Sales"].Visible = false;
            dataGridViewAllBooks.Columns["Sales"].Visible = false;
            dataGridViewAllBooks.Columns["Sales"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bd = new Book_ShopEntities();
            var item = (from r in bd.Reservations
                      join b in bd.Buyers on r.Id_Buyer equals b.Id_Buyer
                      join bk in bd.Books on r.Id_Book equals bk.Id_Book
                      select new
                      {
                          LastNameBuyer = b.LastName,
                          FirstNameBuyer = b.FistName,
                          NameOfBook = bk.NameBook
                      }).ToList();
            dataGridViewAllBooks.DataSource = null;
            dataGridViewAllBooks.DataSource = item;          
        }
    }
}
