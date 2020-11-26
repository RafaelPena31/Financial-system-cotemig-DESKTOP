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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Create_category CategpryForm = new Create_category();
            CategpryForm.ShowDialog();
            this.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile ProfileForm = new Profile();
            ProfileForm.ShowDialog();
            this.Visible = true;
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRecipe RecipeForm = new frmRecipe();
            RecipeForm.ShowDialog();
            this.Visible = true;
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Create_expense ExpenseForm = new Create_expense();
            ExpenseForm.ShowDialog();
            this.Visible = true;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            History HistoryForm = new History();
            HistoryForm.ShowDialog();
            this.Visible = true;
        }
    }
}
