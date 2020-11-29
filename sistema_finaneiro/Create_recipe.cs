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
            if  (cbxNameRecipe.Text != "" && dtpDateRecipe.Text != "" && txtValueRecipe.Text != "")
            {
                sql = string.Format("insert into Registration values (null , '{0}', '{1}', '{2}', '{3}')",
                txtValueRecipe.Text.Replace(',', '.'), dtpDateRecipe.Value.ToString("yyyy-MM-dd"), UserClass.getUserId(),
                Convert.ToInt32(cbxNameRecipe.SelectedValue.ToString()));

                if (UserClass.UpdateData(sql) > 0)
                    {
                        sql = string.Format("update User set recipe = recipe + '{0}', balance = balance + '{1}' where id = '{2}'", txtValueRecipe.Text.Replace(',', '.'),
                    txtValueRecipe.Text.Replace(',', '.'), UserClass.getUserId());
                        if  (UserClass.UpdateData(sql) > 0)
                        {
                            MessageBox.Show("Receita criada com sucesso!", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível adicionar a receita. Entre em contato com o suporte.", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                else
                    {
                        MessageBox.Show("Não foi possível adicionar a receita. Entre em contato com o suporte.", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

      
        private void lblNameRecipe_Click(object sender, EventArgs e)
        {

        }

        private void frmRecipe_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = string.Format("Select * from Category where User_id ='{0}' and type = 'R'", UserClass.getUserId());
            dt = UserClass.DataList(sql);

            if (dt.Rows.Count > 0)
            {
                cbxNameRecipe.DataSource = dt;
                cbxNameRecipe.DisplayMember = "name";
                cbxNameRecipe.ValueMember = "id";
            }

            sql = string.Format("select * from User where id = '{0}'", UserClass.getUserId());
            dt = UserClass.DataList(sql);
            lblValueBalance.Text = "R$ " + dt.Rows[0]["recipe"].ToString();
        }

        private void btnRecipeReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
