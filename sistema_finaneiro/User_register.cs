using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_finaneiro
{
    public partial class User_register : Form
    {
        public User_register()
        {
            InitializeComponent();
        }

        User UserClass = new User();
        string sql;

        private void User_register_Load(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblTelephone_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSex_Click(object sender, EventArgs e)
        {

        }

        private void btn_userregister_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into user values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",txtName.Text,cbxSex.Text,txtEmail.Text,txtAdress.Text,mtxtPhone.Text,
                textPassword.Text, 0, 0, 0);
            if (UserClass.CreateUser(sql, txtEmail.Text, textPassword.Text))
            {
                this.Visible = false;
                Transaction TransactionForm = new Transaction();
                TransactionForm.ShowDialog();
                this.Visible = true;
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
