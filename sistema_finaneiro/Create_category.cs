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
    public partial class Create_category : Form
    {
        public Create_category()
        {
            InitializeComponent();
        }

        User UserClass = new User();
        string sql;

        private void btnReturnCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_category_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            sql = string.Format("select * from User where id = '{0}'", UserClass.getUserId());
            dt = UserClass.DataList(sql);

            if(dt.Rows.Count > 0)
            {
                txtNameCategory.Text = dt.Rows[0]["name"].ToString();
                cbxTypeCategory.Text = dt.Rows[0]["type"].ToString();
                cbxClassCategory.Text = dt.Rows[0]["class"].ToString();
            }
        }

         private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into Category values (null , '{0}', '{1}', '{2}')", 
            txtNameCategory, cbxTypeCategory, cbxClassCategory.Text, UserClass.getUserId());
            UserClass.UpdateData(sql);
            MessageBox.Show("Categoria criada com sucesso!", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
         }


    }
}
