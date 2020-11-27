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
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        User UserClass = new User();
        string sql;

        private void btnCreateRecipe_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into Registration values (null , '{0}', '{1}', '{2}')",
            cbxNameRecipe, dtpDateRecipe, txtValueRecipe, UserClass.getUserId());
            UserClass.UpdateData(sql);
            MessageBox.Show("Receita criada com sucesso!", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        private void lblNameRecipe_Click(object sender, EventArgs e)
        {

        }

        private void frmRecipe_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from Registration where id = '{0}'", UserClass.getUserId());
            dt = UserClass.DataList(sql);

            if (dt.Rows.Count > 0)
            {
                cbxNameRecipe.Text = dt.Rows[0]["name"].ToString();
                dtpDateRecipe.Text = dt.Rows[0]["date"].ToString();
                txtValueRecipe.Text = dt.Rows[0]["value"].ToString();
            }
        }

        private void btnRecipeReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
