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
            sql = string.Format("insert into Registration values (null, '{0}','{1}','{2}')",
             txtValueExpense, cbxNameExpense, dtpDateExpense, UserClass.getUserId());
            UserClass.UpdateData(sql);
            MessageBox.Show("Despesa criada com sucesso!", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            sql = string.Format("Select * from Registration where id ='{0}'", UserClass.getUserId());
            dt = UserClass.DataList(sql);

            if (dt.Rows.Count > 0)
            {
                cbxNameExpense.Text = dt.Rows[0]["nama"].ToString();
                dtpDateExpense.Text = dt.Rows[0]["data"].ToString();
                txtValueExpense.Text = dt.Rows[0]["value"].ToString();
            }
        }

        private void btnExpenseReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
