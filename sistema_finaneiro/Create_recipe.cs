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
            sql = string.Format("insert into Registration values (null , '{0}', '{1}', '{2}, '{3}'')",
            Double.Parse(txtValueRecipe.Text), dtpDateRecipe.Value.ToShortDateString(), UserClass.getUserId(), cbxNameRecipe.SelectedValue);

            if (UserClass.UpdateData(sql) > 0)
            {
                MessageBox.Show("Receita criada com sucesso!", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Não foi possível criar a categoria. Entre em contato com o suporte.", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
        private void lblNameRecipe_Click(object sender, EventArgs e)
        {

        }

        private void frmRecipe_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = string.Format("Select * from Category where User_id ='{0}' and type = 'D'", UserClass.getUserId());
            dt = UserClass.DataList(sql);

            if (dt.Rows.Count > 0)
            {
                cbxNameRecipe.DataSource = dt;
                cbxNameRecipe.DisplayMember = "name";
                cbxNameRecipe.ValueMember = "id";
            }
        }

        private void btnRecipeReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
