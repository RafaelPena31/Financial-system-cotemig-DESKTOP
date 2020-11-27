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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        User UserClass = new User();
        string sql;

        private void btnViewData_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Change_profile ChangeProfileForm = new Change_profile();
            ChangeProfileForm.ShowDialog();
            this.Visible = true;
        }

        private void lblHeaderBalance_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void lblValueBalance_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Change_profile ChangeProfileForm = new Change_profile();
            ChangeProfileForm.ShowDialog();
            this.Visible = true;
        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Change_profile ChangeProfileForm = new Change_profile();
            ChangeProfileForm.ShowDialog();
            this.Visible = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Change_profile ChangeProfileForm = new Change_profile();
            ChangeProfileForm.ShowDialog();
            this.Visible = true;
        }

        private void btnChangeAdress_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Change_profile ChangeProfileForm = new Change_profile();
            ChangeProfileForm.ShowDialog();
            this.Visible = true;
        }

        private void btnChangeTelephone_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Change_profile ChangeProfileForm = new Change_profile();
            ChangeProfileForm.ShowDialog();
            this.Visible = true;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você tem certeza que gostaria de excluir sua conta? A ação será irreversível!", "Deletar", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                sql = string.Format("delete from User where id = '{0}'", UserClass.getUserId());
                UserClass.UpdateData(sql);
                MessageBox.Show("Dados excluidos com sucesso", "Deletado", MessageBoxButtons.OK);
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
