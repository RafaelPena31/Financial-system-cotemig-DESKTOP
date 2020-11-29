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

        public void CbxList()
        {
            DataTable cbxItemList = new DataTable();
            cbxItemList.Columns.Add("name", typeof(string));
            cbxItemList.Columns.Add("value", typeof(string));
            cbxItemList.Rows.Add("Masculino", "M");
            cbxItemList.Rows.Add("Feminino", "F");
            cbxItemList.Rows.Add("Outro", "O");

            cbxSex.DataSource = cbxItemList;
            cbxSex.DisplayMember = "name";
            cbxSex.ValueMember = "value";
        }
        private void User_register_Load(object sender, EventArgs e)
        {
            CbxList();
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
            if (txtName.Text != "" && cbxSex.Text != "" && txtEmail.Text != "" && txtAdress.Text != "" && mtxtPhone.Text != "" && textPassword.Text != "")
            {
                sql = string.Format("select id from User where email = '{0}'", txtEmail.Text);
                if (UserClass.DataList(sql).Rows.Count == 0)
                {
                    sql = string.Format("insert into user values(null, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", txtName.Text, cbxSex.SelectedValue.ToString(), txtEmail.Text, txtAdress.Text, mtxtPhone.Text,
                    textPassword.Text, 0, 0, 0);
                    if (UserClass.CreateUser(sql, txtEmail.Text, textPassword.Text))
                    {
                        this.Visible = false;
                        Transaction TransactionForm = new Transaction();
                        TransactionForm.ShowDialog();
                        this.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Já existe uma conta utilizando este e-mail, escolha outro.", "Criação de conta", MessageBoxButtons.OK);
                }
            } else
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Criação de conta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
