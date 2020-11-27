namespace sistema_finaneiro
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.lblValueBalance = new System.Windows.Forms.Label();
            this.lblHeaderBalance = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1061, 163);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.Image = ((System.Drawing.Image)(resources.GetObject("btnExpense.Image")));
            this.btnExpense.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExpense.Location = new System.Drawing.Point(651, 125);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Padding = new System.Windows.Forms.Padding(7, 35, 7, 35);
            this.btnExpense.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExpense.Size = new System.Drawing.Size(161, 149);
            this.btnExpense.TabIndex = 29;
            this.btnExpense.Text = "Criar Despesa";
            this.btnExpense.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnRecipe
            // 
            this.btnRecipe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipe.Image = ((System.Drawing.Image)(resources.GetObject("btnRecipe.Image")));
            this.btnRecipe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecipe.Location = new System.Drawing.Point(447, 125);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnRecipe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRecipe.Size = new System.Drawing.Size(161, 149);
            this.btnRecipe.TabIndex = 28;
            this.btnRecipe.Text = "Criar Receita";
            this.btnRecipe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecipe.UseVisualStyleBackColor = false;
            this.btnRecipe.Click += new System.EventHandler(this.btnRecipe_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategory.Location = new System.Drawing.Point(243, 125);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(3, 35, 3, 35);
            this.btnCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCategory.Size = new System.Drawing.Size(161, 149);
            this.btnCategory.TabIndex = 27;
            this.btnCategory.Text = "Criar Categoria";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lblValueBalance
            // 
            this.lblValueBalance.AutoSize = true;
            this.lblValueBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblValueBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueBalance.ForeColor = System.Drawing.Color.White;
            this.lblValueBalance.Location = new System.Drawing.Point(480, 64);
            this.lblValueBalance.Name = "lblValueBalance";
            this.lblValueBalance.Size = new System.Drawing.Size(107, 25);
            this.lblValueBalance.TabIndex = 31;
            this.lblValueBalance.Text = "R$ 00,00";
            this.lblValueBalance.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblHeaderBalance
            // 
            this.lblHeaderBalance.AutoSize = true;
            this.lblHeaderBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHeaderBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderBalance.ForeColor = System.Drawing.Color.White;
            this.lblHeaderBalance.Location = new System.Drawing.Point(490, 29);
            this.lblHeaderBalance.Name = "lblHeaderBalance";
            this.lblHeaderBalance.Size = new System.Drawing.Size(86, 25);
            this.lblHeaderBalance.TabIndex = 32;
            this.lblHeaderBalance.Text = "Saldo: ";
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHistory.Location = new System.Drawing.Point(855, 125);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHistory.Size = new System.Drawing.Size(161, 149);
            this.btnHistory.TabIndex = 34;
            this.btnHistory.Text = "Histórico";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfile.Location = new System.Drawing.Point(39, 125);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnProfile.Size = new System.Drawing.Size(161, 149);
            this.btnProfile.TabIndex = 33;
            this.btnProfile.Text = "Perfil";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1059, 367);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblHeaderBalance);
            this.Controls.Add(this.lblValueBalance);
            this.Controls.Add(this.btnExpense);
            this.Controls.Add(this.btnRecipe);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transações";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label lblValueBalance;
        private System.Windows.Forms.Label lblHeaderBalance;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnProfile;
    }
}