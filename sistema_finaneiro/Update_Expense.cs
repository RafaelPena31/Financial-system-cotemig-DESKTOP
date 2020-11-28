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
                sql = string.Format("select * from Category where id = '{0}' and User_id = '{1}'", int.Parse(txtUpdateExpenseId.Text),
                UserClass.getUserId());
                dt = UserClass.DataList(sql);

                if (dt.Rows.Count > 0)
                {
                    cbxUpdateNameExpense.Text = dt.Rows[0]["name"].ToString();
                    dtpUpdateDateExpense.Text = dt.Rows[0]["data"].ToString();
                    txtUpdateExpenseValue.Text = dt.Rows[0]["value"].ToString();
                }
            }
        }
    }
}
