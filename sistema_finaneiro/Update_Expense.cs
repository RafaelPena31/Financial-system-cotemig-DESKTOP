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
    public partial class Update_Expense : Form
    {
        public Update_Expense()
        {
            InitializeComponent();
        }

        User UserClass = new User();
        string sql;
        string lastValue;

        private void btnUptadeExpenseReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUpdateExpenseId_Click(object sender, EventArgs e)
        {

        }

        private void txtUpdateExpenseId_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtUpdateExpenseId.Text != "")
            {
                sql = string.Format("select Category.name, Registration.data, Registration.value from Registration join Category on Category_id = Category.id where Registration.User_id = '{0}' and Registration.id = '{1}'", 
                    UserClass.getUserId(), int.Parse(txtUpdateExpenseId.Text));
                dt = UserClass.DataList(sql);

                if (dt.Rows.Count > 0)
                {
                    cbxUpdateNameExpense.Text = dt.Rows[0]["name"].ToString();
                    dtpUpdateDateExpense.Text = dt.Rows[0]["data"].ToString();
                    txtUpdateExpenseValue.Text = dt.Rows[0]["value"].ToString();
                    lastValue = dt.Rows[0]["value"].ToString();
                }
            }
        }

        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {
            if (txtUpdateExpenseValue.Text != "" && dtpUpdateDateExpense.Text != "" && txtUpdateExpenseId.Text != "")
            {
                sql = string.Format("update Registration set Category_id = '{0}', value = '{1}', data = '{2}' where id = '{3}'", Convert.ToInt32(cbxUpdateNameExpense.SelectedValue.ToString()),
                txtUpdateExpenseValue.Text.Replace(',', '.'), dtpUpdateDateExpense.Value.ToString("yyyy-MM-dd"), int.Parse(txtUpdateExpenseId.Text));
                if (UserClass.UpdateData(sql) > 0)
                {
                    sql = string.Format("update User set expense = expense + ('{0}' - '{1}'), balance = balance - ('{2}' - '{3}') where id = '{4}'", txtUpdateExpenseValue.Text.Replace(',', '.'), 
                        lastValue.Replace(',', '.'), txtUpdateExpenseValue.Text.Replace(',', '.'), lastValue.Replace(',', '.'), UserClass.getUserId());
                    if (UserClass.UpdateData(sql) > 0)
                    {
                        MessageBox.Show("Dados atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("seus dados não puderam ser atualizados. Entre em contato com o suporte.", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("seus dados não puderam ser atualizados. Entre em contato com o suporte.", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if(txtUpdateExpenseId.Text != "")
            { 
            DialogResult result = MessageBox.Show("Você tem certeza que gostaria de excluir este dado de sua conta? A ação será irreversível!", "Deletar", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    sql = string.Format("delete from Registration where id = '{0}'", int.Parse(txtUpdateExpenseId.Text));
                    if (UserClass.UpdateData(sql) > 0)
                    {
                        sql = string.Format("update User set expense = expense - '{0}', balance = balance + '{1}' where id = '{2}'", lastValue.Replace(',', '.'), 
                            lastValue.Replace(',', '.'), UserClass.getUserId());
                        if (UserClass.UpdateData(sql) > 0)
                        {
                            MessageBox.Show("Dados excluidos com sucesso", "Deletado", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Seus dados não poderam ser excluidos com sucesso. Entre em contato com o suporte.", "Deletado", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seus dados não poderam ser excluidos com sucesso. Entre em contato com o suporte.", "Deletado", MessageBoxButtons.OK);
                    }
                } 
            } else
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Update_Expense_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = string.Format("Select * from Category where User_id ='{0}' and type = 'D'", UserClass.getUserId());
            dt = UserClass.DataList(sql);

            if (dt.Rows.Count > 0)
            {
                cbxUpdateNameExpense.DataSource = dt;
                cbxUpdateNameExpense.DisplayMember = "name";
                cbxUpdateNameExpense.ValueMember = "id";
            }
        }

        private void cbxUpdateNameExpense_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
