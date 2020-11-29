using System;
using System.Globalization;
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
    public partial class Create_expense : Form
    {
        public Create_expense()
        {
            InitializeComponent();
        }

        User UserClass = new User();
        string sql;

        private void btnCreateExpense_Click(object sender, EventArgs e)
        {
            if (cbxNameExpense.Text != "" && dtpDateExpense.Text != "" && txtValueExpense.Text != "")
            {
                sql = string.Format("insert into Registration values (null , '{0}', '{1}', '{2}', '{3}')",
                txtValueExpense.Text.Replace(',', '.'), dtpDateExpense.Value.ToString("yyyy-MM-dd"), UserClass.getUserId(),
                Convert.ToInt32(cbxNameExpense.SelectedValue.ToString()));

                if (UserClass.UpdateData(sql) > 0)
                {
                    sql = string.Format("update User set expense = expense + '{0}', balance = balance - '{1}' where id = '{2}'", txtValueExpense.Text.Replace(',', '.'),
                    txtValueExpense.Text.Replace(',', '.'), UserClass.getUserId());
                    if (UserClass.UpdateData(sql) > 0)
                    {
                        MessageBox.Show("Receita criada com sucesso!", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível adicionar a despesa. Entre em contato com o suporte.", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível adicionar a despesa. Entre em contato com o suporte.", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblHeaderExpense_Click(object sender, EventArgs e)
        {

        }

        private void cbxNameExpense_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateExpense_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblValueBalance_Click(object sender, EventArgs e)
        {

        }

        private void Create_expense_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = string.Format("Select * from Category where User_id ='{0}' and type = 'D'", UserClass.getUserId());
            dt = UserClass.DataList(sql);

            if (dt.Rows.Count > 0)
            {
                cbxNameExpense.DataSource = dt;
                cbxNameExpense.DisplayMember = "name";
                cbxNameExpense.ValueMember = "id";
            }

            sql = string.Format("select * from User where id = '{0}'", UserClass.getUserId());
            dt = UserClass.DataList(sql);
            lblValueBalance.Text = "R$ " + dt.Rows[0]["expense"].ToString();
        }

        private void btnExpenseReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValueExpense_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
