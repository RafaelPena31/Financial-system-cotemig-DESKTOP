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
    public partial class User_login : Form
    {
        public User_login()
        {
            InitializeComponent();
        }

        User UserClass = new User();
        string sql;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && textPassword.Text != "")
            {
                if (UserClass.Authenticator(txtEmail.Text, textPassword.Text))
                {
                    this.Visible = false;
                    Transaction TransactionForm = new Transaction();
                    TransactionForm.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("E-mail ou senha incorretos", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            User_register user_RegisterForm = new User_register();
            user_RegisterForm.ShowDialog();
            this.Visible = true;
        }
    }
}
