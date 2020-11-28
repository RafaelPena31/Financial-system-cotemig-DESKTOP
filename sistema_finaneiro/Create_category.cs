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

        public void List(char type)
        {
            sql = string.Format("select * from Category where User_id = '{0}' and type = '{1}'", UserClass.getUserId(), type);
            switch (type)
            {
                case 'D':
                    dtgListCategoryExpense.DataSource = UserClass.DataList(sql);
                    break;
                case 'R':
                    dtgListCategoryRecipe.DataSource = UserClass.DataList(sql);
                    break;
            }

        }

        public void CbxList()
        {
            DataTable typeItemList = new DataTable();
            typeItemList.Columns.Add("name", typeof(string));
            typeItemList.Columns.Add("value", typeof(char));
            typeItemList.Rows.Add("Despesa", 'D');
            typeItemList.Rows.Add("Receita", 'R');

            cbxTypeCategory.DataSource = typeItemList;
            cbxTypeCategory.DisplayMember = "name";
            cbxTypeCategory.ValueMember = "value";

            DataTable classItemList = new DataTable();
            classItemList.Columns.Add("name", typeof(string));
            classItemList.Columns.Add("value", typeof(string));
            classItemList.Rows.Add("Alimentação", "Alimentação");
            classItemList.Rows.Add("Educação", "Educação");
            classItemList.Rows.Add("Lazer", "Lazer");
            classItemList.Rows.Add("Trabalho", "Trabalho");
            classItemList.Rows.Add("Transporte", "Transporte");
            classItemList.Rows.Add("Vestuário", "Vestuário");
            classItemList.Rows.Add("Outros", "Outros");

            cbxClassCategory.DataSource = classItemList;
            cbxClassCategory.DisplayMember = "name";
            cbxClassCategory.ValueMember = "value";
        }

        private void btnReturnCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_category_Load(object sender, EventArgs e)
        {
            List('D');
            List('R');
            CbxList();
        }

         private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into Category values (null , '{0}', '{1}', '{2}', '{3}')", 
            txtNameCategory.Text, cbxTypeCategory.SelectedValue, cbxClassCategory.Text, UserClass.getUserId());
            if (UserClass.UpdateData(sql) > 0)
            {
                MessageBox.Show("Categoria criada com sucesso!", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Não foi possível criar a categoria. Entre em contato com o suporte.", "Criação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnChangeDataCategory_Click(object sender, EventArgs e)
        {
            sql = string.Format("update Category set name = '{0}', type = '{1}', class = '{2}' where id = '{3}' and User_id = '{4}'", txtNameCategory.Text,
            cbxTypeCategory.SelectedValue.ToString(), cbxClassCategory.Text, int.Parse(txtCategoryId.Text), UserClass.getUserId());
            UserClass.UpdateData(sql);
            MessageBox.Show("Dados atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from Category where id = '{0}' and User_id = '{1}'", int.Parse(txtCategoryId.Text), UserClass.getUserId());
            UserClass.UpdateData(sql);
            MessageBox.Show("Categoria deletada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbxTypeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if(txtCategoryId.Text != "")
            {
                sql = string.Format("select * from Category where id = '{0}' and User_id = '{1}'", int.Parse(txtCategoryId.Text),
                UserClass.getUserId());
                dt = UserClass.DataList(sql);

                if (dt.Rows.Count > 0)
                {
                    txtNameCategory.Text = dt.Rows[0]["name"].ToString();
                    cbxClassCategory.Text = dt.Rows[0]["class"].ToString();
                    cbxTypeCategory.SelectedValue = dt.Rows[0]["type"].ToString();
                }
            }
        }
    }
}
