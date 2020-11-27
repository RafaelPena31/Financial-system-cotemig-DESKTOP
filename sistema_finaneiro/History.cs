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
            sql = "Select * from Registration";
            dtgListCategoryExpense.DataSource = UserClass.DataList(sql);
        }

        public void ListRecipe()
        {
            sql = "Select * from Registration";
            dtgListCategoryRecipe.DataSource = UserClass.DataList(sql);
        }

        private void History_Load(object sender, EventArgs e)
        {
            ListExpense();
            ListRecipe();
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
    }
}
