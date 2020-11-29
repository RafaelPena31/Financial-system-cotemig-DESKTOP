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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        User UserClass = new User();
        string sql;

        public void ListExpense()
        {
            sql = string.Format("select Registration.id, Category.name, Category.type, Registration.value, Registration.data, " +
                "Category.class from Registration join Category on Category_id = Category.id and Registration.User_id = '{0}' " +
                "where Category.type = 'D' ", UserClass.getUserId());
            dtgListCategoryExpense.DataSource = UserClass.DataList(sql);
        }

        public void ListRecipe()
        {
            sql = string.Format("select Registration.id, Category.name, Category.type, Registration.value, Registration.data, " +
                "Category.class from Registration join Category on Category_id = Category.id and Registration.User_id = '{0}' " +
                "where Category.type = 'R' ", UserClass.getUserId());
            dtgListCategoryRecipe.DataSource = UserClass.DataList(sql);
        }

        private void History_Load(object sender, EventArgs e)
        {
            ListExpense();
            ListRecipe();
            sql = string.Format("select * from User where id = '{0}'", UserClass.getUserId());
            DataTable dt = UserClass.DataList(sql);
            lblValueBalance.Text = "R$ " + dt.Rows[0]["balance"].ToString();
            lblValueExpenseHistory.Text = "R$ " + dt.Rows[0]["expense"].ToString();
            lblValueRecipeHistory.Text = "R$ " + dt.Rows[0]["recipe"].ToString();
        }

        private void lblHeaderBalance_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnHistory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgListCategoryRecipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChangeRecipeHistory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Update_Recipe UpdateRecipeForm = new Update_Recipe();
            UpdateRecipeForm.ShowDialog();
            this.Close();
            this.Visible = true;
        }

        private void btnDeleteRecipeHistory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Update_Recipe UpdateRecipeForm = new Update_Recipe();
            UpdateRecipeForm.ShowDialog();
            this.Close();
            this.Visible = true;
        }

        private void btnChangeExpenseHistory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Update_Expense UpdateExpenseForm = new Update_Expense();
            UpdateExpenseForm.ShowDialog();
            this.Close();
            this.Visible = true;
        }

        private void btnDeleteExpenseHistory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Update_Expense UpdateExpenseForm = new Update_Expense();
            UpdateExpenseForm.ShowDialog();
            this.Close();
            this.Visible = true;
        }
    }
}
