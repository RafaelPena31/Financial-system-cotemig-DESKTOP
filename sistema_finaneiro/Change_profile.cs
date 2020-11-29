﻿using System;
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
    public partial class Change_profile : Form
    {
        public Change_profile()
        {
            InitializeComponent();
        }

        User UserClass = new User();
        string sql;

        public void CbxList()
        {
            DataTable cbxItemList = new DataTable();
            cbxItemList.Columns.Add("name", typeof(string));
            cbxItemList.Columns.Add("value", typeof(string));
            cbxItemList.Rows.Add("Masculino", "M");
            cbxItemList.Rows.Add("Feminino", "F");
            cbxItemList.Rows.Add("Outro", "O");

            cbxSexUpdateProfile.DataSource = cbxItemList;
            cbxSexUpdateProfile.DisplayMember = "name";
            cbxSexUpdateProfile.ValueMember = "value";
        }

        private void btnUserChange_Click(object sender, EventArgs e)
        {
            if (txtUpdateNameProfile.Text != "" && txtEmailUpdateProfile.Text != "" && cbxSexUpdateProfile.Text != "" && txtTelephoneUpdateProfile.Text != "" && txtAdressUpdateProfile.Text != "" && textPasswordUpdateProfile.Text != "")
            {
                sql = string.Format("update User set name = '{0}', email = '{1}', genre = '{2}', phone = '{3}', address = '{4}', password = '{5}' where id = '{6}'", txtUpdateNameProfile.Text,
                txtEmailUpdateProfile.Text, cbxSexUpdateProfile.SelectedValue.ToString(), txtTelephoneUpdateProfile.Text, txtAdressUpdateProfile.Text, textPasswordUpdateProfile.Text, UserClass.getUserId());
                UserClass.UpdateData(sql);
                MessageBox.Show("Dados atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Perfil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Change_profile_Load(object sender, EventArgs e)
        {
            CbxList();
            DataTable dt = new DataTable();
            sql = string.Format("select * from User where id = '{0}'", UserClass.getUserId());
            dt = UserClass.DataList(sql);

            if(dt.Rows.Count > 0)
            {
                txtUpdateNameProfile.Text = dt.Rows[0]["name"].ToString();
                txtEmailUpdateProfile.Text = dt.Rows[0]["email"].ToString();
                cbxSexUpdateProfile.SelectedValue = dt.Rows[0]["genre"].ToString();
                txtTelephoneUpdateProfile.Text = dt.Rows[0]["phone"].ToString();
                txtAdressUpdateProfile.Text = dt.Rows[0]["address"].ToString();
                textPasswordUpdateProfile.Text = dt.Rows[0]["password"].ToString();
            } else
            {
                MessageBox.Show(UserClass.getUserId().ToString());
            }
        }

        private void btnReturnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
