namespace sistema_finaneiro
{
    partial class Create_expense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_expense));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeaderExpense = new System.Windows.Forms.Label();
            this.lblValueBalance = new System.Windows.Forms.Label();
            this.txtValueExpense = new System.Windows.Forms.TextBox();
            this.dtpDateExpense = new System.Windows.Forms.DateTimePicker();
            this.lblValueExpense = new System.Windows.Forms.Label();
            this.cbxNameExpense = new System.Windows.Forms.ComboBox();
            this.lblChooseDateExpense = new System.Windows.Forms.Label();
            this.lblNameExpense = new System.Windows.Forms.Label();
            this.btnExpenseReturn = new System.Windows.Forms.Button();
            this.btnCreateExpense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 152);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeaderExpense
            // 
            this.lblHeaderExpense.AutoSize = true;
            this.lblHeaderExpense.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHeaderExpense.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderExpense.ForeColor = System.Drawing.Color.White;
            this.lblHeaderExpense.Location = new System.Drawing.Point(158, 35);
            this.lblHeaderExpense.Name = "lblHeaderExpense";
            this.lblHeaderExpense.Size = new System.Drawing.Size(104, 28);
            this.lblHeaderExpense.TabIndex = 59;
            this.lblHeaderExpense.Text = "Despesa:";
            this.lblHeaderExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeaderExpense.Click += new System.EventHandler(this.lblHeaderExpense_Click);
            // 
            // lblValueBalance
            // 
            this.lblValueBalance.AutoSize = true;
            this.lblValueBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblValueBalance.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueBalance.ForeColor = System.Drawing.Color.White;
            this.lblValueBalance.Location = new System.Drawing.Point(160, 74);
            this.lblValueBalance.Name = "lblValueBalance";
            this.lblValueBalance.Size = new System.Drawing.Size(97, 28);
            this.lblValueBalance.TabIndex = 58;
            this.lblValueBalance.Text = "R$ 00,00";
            this.lblValueBalance.Click += new System.EventHandler(this.lblValueBalance_Click);
            // 
            // txtValueExpense
            // 
            this.txtValueExpense.Location = new System.Drawing.Point(79, 344);
            this.txtValueExpense.Name = "txtValueExpense";
            this.txtValueExpense.Size = new System.Drawing.Size(269, 20);
            this.txtValueExpense.TabIndex = 65;
            // 
            // dtpDateExpense
            // 
            this.dtpDateExpense.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateExpense.Location = new System.Drawing.Point(79, 286);
            this.dtpDateExpense.Name = "dtpDateExpense";
            this.dtpDateExpense.Size = new System.Drawing.Size(269, 22);
            this.dtpDateExpense.TabIndex = 64;
            this.dtpDateExpense.ValueChanged += new System.EventHandler(this.dtpDateExpense_ValueChanged);
            // 
            // lblValueExpense
            // 
            this.lblValueExpense.AutoSize = true;
            this.lblValueExpense.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueExpense.Location = new System.Drawing.Point(79, 322);
            this.lblValueExpense.Name = "lblValueExpense";
            this.lblValueExpense.Size = new System.Drawing.Size(87, 15);
            this.lblValueExpense.TabIndex = 63;
            this.lblValueExpense.Text = "Valor da receita";
            // 
            // cbxNameExpense
            // 
            this.cbxNameExpense.FormattingEnabled = true;
            this.cbxNameExpense.Location = new System.Drawing.Point(79, 229);
            this.cbxNameExpense.Name = "cbxNameExpense";
            this.cbxNameExpense.Size = new System.Drawing.Size(269, 21);
            this.cbxNameExpense.TabIndex = 62;
            this.cbxNameExpense.SelectedIndexChanged += new System.EventHandler(this.cbxNameExpense_SelectedIndexChanged);
            // 
            // lblChooseDateExpense
            // 
            this.lblChooseDateExpense.AutoSize = true;
            this.lblChooseDateExpense.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDateExpense.Location = new System.Drawing.Point(79, 265);
            this.lblChooseDateExpense.Name = "lblChooseDateExpense";
            this.lblChooseDateExpense.Size = new System.Drawing.Size(81, 15);
            this.lblChooseDateExpense.TabIndex = 61;
            this.lblChooseDateExpense.Text = "Escolha a data";
            // 
            // lblNameExpense
            // 
            this.lblNameExpense.AutoSize = true;
            this.lblNameExpense.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameExpense.Location = new System.Drawing.Point(79, 208);
            this.lblNameExpense.Name = "lblNameExpense";
            this.lblNameExpense.Size = new System.Drawing.Size(99, 15);
            this.lblNameExpense.TabIndex = 60;
            this.lblNameExpense.Text = "Nome da despesa";
            // 
            // btnExpenseReturn
            // 
            this.btnExpenseReturn.BackColor = System.Drawing.Color.White;
            this.btnExpenseReturn.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnExpenseReturn.Image")));
            this.btnExpenseReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpenseReturn.Location = new System.Drawing.Point(79, 423);
            this.btnExpenseReturn.Name = "btnExpenseReturn";
            this.btnExpenseReturn.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.btnExpenseReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExpenseReturn.Size = new System.Drawing.Size(119, 68);
            this.btnExpenseReturn.TabIndex = 67;
            this.btnExpenseReturn.Text = "Voltar";
            this.btnExpenseReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenseReturn.UseVisualStyleBackColor = false;
            this.btnExpenseReturn.Click += new System.EventHandler(this.btnExpenseReturn_Click);
            // 
            // btnCreateExpense
            // 
            this.btnCreateExpense.AutoEllipsis = true;
            this.btnCreateExpense.BackColor = System.Drawing.Color.White;
            this.btnCreateExpense.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExpense.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateExpense.Image")));
            this.btnCreateExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateExpense.Location = new System.Drawing.Point(229, 423);
            this.btnCreateExpense.Name = "btnCreateExpense";
            this.btnCreateExpense.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.btnCreateExpense.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCreateExpense.Size = new System.Drawing.Size(119, 68);
            this.btnCreateExpense.TabIndex = 66;
            this.btnCreateExpense.Text = "Criar";
            this.btnCreateExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateExpense.UseVisualStyleBackColor = false;
            this.btnCreateExpense.Click += new System.EventHandler(this.btnCreateExpense_Click);
            // 
            // Create_expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 524);
            this.Controls.Add(this.btnExpenseReturn);
            this.Controls.Add(this.btnCreateExpense);
            this.Controls.Add(this.txtValueExpense);
            this.Controls.Add(this.dtpDateExpense);
            this.Controls.Add(this.lblValueExpense);
            this.Controls.Add(this.cbxNameExpense);
            this.Controls.Add(this.lblChooseDateExpense);
            this.Controls.Add(this.lblNameExpense);
            this.Controls.Add(this.lblHeaderExpense);
            this.Controls.Add(this.lblValueBalance);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Create_expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesa";
            this.Load += new System.EventHandler(this.Create_expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeaderExpense;
        private System.Windows.Forms.Label lblValueBalance;
        private System.Windows.Forms.TextBox txtValueExpense;
        private System.Windows.Forms.DateTimePicker dtpDateExpense;
        private System.Windows.Forms.Label lblValueExpense;
        private System.Windows.Forms.ComboBox cbxNameExpense;
        private System.Windows.Forms.Label lblChooseDateExpense;
        private System.Windows.Forms.Label lblNameExpense;
        private System.Windows.Forms.Button btnExpenseReturn;
        private System.Windows.Forms.Button btnCreateExpense;
    }
}