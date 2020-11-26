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

        private void btnReturnCategory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
