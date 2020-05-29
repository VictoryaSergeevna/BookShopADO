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
namespace AdoExamBooks
{
    public partial class UserForm : Form
    {
        Book_ShopEntities bd = null;
        Users u = null;
        int userId = 0;
        public UserForm()
        {
            InitializeComponent();
            bd = new Book_ShopEntities();
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var user = bd.Users.SingleOrDefault(u => u.Login == textBoxLogin.Text && u.Password == textBoxPassword.Text);
            
            if (user != null)
            {
                userId = user.Id_User;
                MessageBox.Show("Вход успешно выполнен!");
                FormMain f = new FormMain(user, userId);

                if (f.ShowDialog() == DialogResult.OK)
                {

                }
              
            }
            else MessageBox.Show("Вход не выполнен!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
