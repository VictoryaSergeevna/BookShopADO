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
    public partial class AddForm : Form
    {
        Books book = null;
        public AddForm(Books book)
        {
            InitializeComponent();
            this.book = book;
            textBoxTheme.Text = book.Id_Theme.ToString();
            textBoxAuthor.Text = book.Id_Author.ToString();
            textBoxPublish.Text = book.Id_Publisher.ToString();
            textBoxName.Text = book.NameBook;
            textBoxPage.Text = book.Pages.ToString();
            textBoxYear.Text = book.Year.ToString();
            textBoxBPrice.Text = book.ProductPrice.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            book.Id_Theme = Int32.Parse(textBoxTheme.Text);
            book.Id_Author = Int32.Parse(textBoxAuthor.Text);
            book.Id_Publisher = Int32.Parse(textBoxPublish.Text);
            book.NameBook = textBoxName.Text;
            book.Pages = Int32.Parse(textBoxPage.Text);
            book.Year = Int32.Parse(textBoxYear.Text);
            book.ProductPrice = Decimal.Parse(textBoxBPrice.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
