using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoExamBooks
{
    public partial class SearchForm : Form
    {
        Book_ShopEntities bd = null;
        Books b = null;
        Authors a = null;
        Themes t = null;
        public SearchForm(Books b, Authors a, Themes t)
        {
            InitializeComponent();
            this.b = b;
            this.a = a;
            this.t = t;
            bd = new Book_ShopEntities();
            cmbBoxName.DataSource = null;
            cmbBoxAuthor.DataSource = null;
            cmbBoxTheme.DataSource = null;
            //cmbBoxName.DataSource = bd.Books.ToList();
            //cmbBoxName.DisplayMember = "NameBook";
            //cmbBoxName.ValueMember = "Id_Book";
            //cmbBoxAuthor.DataSource = bd.Books.ToList();
            //cmbBoxAuthor.DisplayMember = "LastName";
            //cmbBoxAuthor.ValueMember = "Id_Author";
            //cmbBoxTheme.DataSource = bd.Books.ToList();
            //cmbBoxTheme.DisplayMember = "NameGenre";
            //cmbBoxTheme.ValueMember = "Id_Theme";

        }

        private void buttonStartSerch_Click(object sender, EventArgs e)
        {
            SearchBooks();
            SearchAuthors();
            SearchTheme();       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmbBoxName.Enabled = true;
                cmbBoxAuthor.Enabled = false;
                cmbBoxTheme.Enabled = false;
                cmbBoxName.DataSource = bd.Books.ToList();
                cmbBoxName.DisplayMember = "NameBook";
                cmbBoxName.ValueMember = "Id_Book";
            }
        }

        private void SearchBooks()
        {
           
           
            if (cmbBoxName.SelectedIndex != -1)
            {
               
                int id = Convert.ToInt32(cmbBoxName.SelectedValue);
                var query = bd.Books.Local.Where(x => x.Id_Book == id).ToList();
                dataGridViewSerchResult.DataSource = null;
                dataGridViewSerchResult.DataSource = query;
                dataGridViewSerchResult.Columns["Themes"].Visible = false;
                dataGridViewSerchResult.Columns["Authors"].Visible = false;
                dataGridViewSerchResult.Columns["Publishers"].Visible = false;
                dataGridViewSerchResult.Columns["Publishers"].Visible = false;
                dataGridViewSerchResult.Columns["Discounts"].Visible = false;
                dataGridViewSerchResult.Columns["NextTome"].Visible = false;
                dataGridViewSerchResult.Columns["Reservations"].Visible = false;
                dataGridViewSerchResult.Columns["Sales"].Visible = false;
            }
            
        }
        private void SearchAuthors()
        {
           
           

            if (cmbBoxAuthor.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(cmbBoxAuthor.SelectedValue);
                var query = bd.Books.Where(x => x.Id_Author == id).ToList();
                dataGridViewSerchResult.DataSource = null;
                dataGridViewSerchResult.DataSource = query;
                dataGridViewSerchResult.Columns["Themes"].Visible = false;              
                dataGridViewSerchResult.Columns["Publishers"].Visible = false;
                dataGridViewSerchResult.Columns["Discounts"].Visible = false;
                dataGridViewSerchResult.Columns["NextTome"].Visible = false;
                dataGridViewSerchResult.Columns["Reservations"].Visible = false;
                dataGridViewSerchResult.Columns["Sales"].Visible = false;
            }
            
        }
        private void SearchTheme()
        { 
            
            if (cmbBoxTheme.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(cmbBoxTheme.SelectedValue);
                var query = bd.Books.Where(x => x.Id_Theme == id).ToList();
                dataGridViewSerchResult.DataSource = null;
                dataGridViewSerchResult.DataSource = query;
                dataGridViewSerchResult.Columns["Authors"].Visible = false;
                dataGridViewSerchResult.Columns["Publishers"].Visible = false;
                dataGridViewSerchResult.Columns["Discounts"].Visible = false;
                dataGridViewSerchResult.Columns["NextTome"].Visible = false;
                dataGridViewSerchResult.Columns["Reservations"].Visible = false;
                dataGridViewSerchResult.Columns["Sales"].Visible = false;
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                cmbBoxAuthor.Enabled = true;
                cmbBoxName.Enabled = false;                
                cmbBoxTheme.Enabled = false;
                cmbBoxAuthor.DataSource = bd.Authors.ToList();
                cmbBoxAuthor.DisplayMember = "LastName";
                cmbBoxAuthor.ValueMember = "Id_Author";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                cmbBoxTheme.Enabled = true;
                cmbBoxName.Enabled = false;
                cmbBoxAuthor.Enabled = false;
                cmbBoxTheme.DataSource = bd.Themes.ToList();
                cmbBoxTheme.DisplayMember = "NameGenre";
                cmbBoxTheme.ValueMember = "Id_Theme";             
            }
        }
    }
}
