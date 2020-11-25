namespace sistema_finaneiro
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.lblHistoryRecipe = new System.Windows.Forms.Label();
            this.dtgListCategoryRecipe = new System.Windows.Forms.DataGridView();
            this.dtgListCategoryExpense = new System.Windows.Forms.DataGridView();
            this.lblHistoryExpense = new System.Windows.Forms.Label();
            this.btnReturnHistory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeaderBalance = new System.Windows.Forms.Label();
            this.lblValueBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHistoryRecipe
            // 
            this.lblHistoryRecipe.AutoSize = true;
            this.lblHistoryRecipe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryRecipe.ForeColor = System.Drawing.Color.Black;
            this.lblHistoryRecipe.Location = new System.Drawing.Point(366, 175);
            this.lblHistoryRecipe.Name = "lblHistoryRecipe";
            this.lblHistoryRecipe.Size = new System.Drawing.Size(111, 25);
            this.lblHistoryRecipe.TabIndex = 33;
            this.lblHistoryRecipe.Text = "Receitas:";
            this.lblHistoryRecipe.Click += new System.EventHandler(this.lblHeaderBalance_Click);
            // 
            // dtgListCategoryRecipe
            // 
            this.dtgListCategoryRecipe.BackgroundColor = System.Drawing.Color.White;
            this.dtgListCategoryRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListCategoryRecipe.Location = new System.Drawing.Point(78, 245);
            this.dtgListCategoryRecipe.Name = "dtgListCategoryRecipe";
            this.dtgListCategoryRecipe.Size = new System.Drawing.Size(686, 168);
            this.dtgListCategoryRecipe.TabIndex = 35;
            // 
            // dtgListCategoryExpense
            // 
            this.dtgListCategoryExpense.BackgroundColor = System.Drawing.Color.White;
            this.dtgListCategoryExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListCategoryExpense.Location = new System.Drawing.Point(78, 504);
            this.dtgListCategoryExpense.Name = "dtgListCategoryExpense";
            this.dtgListCategoryExpense.Size = new System.Drawing.Size(686, 168);
            this.dtgListCategoryExpense.TabIndex = 37;
            // 
            // lblHistoryExpense
            // 
            this.lblHistoryExpense.AutoSize = true;
            this.lblHistoryExpense.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryExpense.ForeColor = System.Drawing.Color.Black;
            this.lblHistoryExpense.Location = new System.Drawing.Point(361, 435);
            this.lblHistoryExpense.Name = "lblHistoryExpense";
            this.lblHistoryExpense.Size = new System.Drawing.Size(123, 25);
            this.lblHistoryExpense.TabIndex = 36;
            this.lblHistoryExpense.Text = "Despesas:";
            // 
            // btnReturnHistory
            // 
            this.btnReturnHistory.BackColor = System.Drawing.Color.White;
            this.btnReturnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnHistory.Image")));
            this.btnReturnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnHistory.Location = new System.Drawing.Point(75, 687);
            this.btnReturnHistory.Name = "btnReturnHistory";
            this.btnReturnHistory.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.btnReturnHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReturnHistory.Size = new System.Drawing.Size(119, 59);
            this.btnReturnHistory.TabIndex = 38;
            this.btnReturnHistory.Text = "Voltar";
            this.btnReturnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnHistory.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 163);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeaderBalance
            // 
            this.lblHeaderBalance.AutoSize = true;
            this.lblHeaderBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHeaderBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderBalance.ForeColor = System.Drawing.Color.White;
            this.lblHeaderBalance.Location = new System.Drawing.Point(378, 34);
            this.lblHeaderBalance.Name = "lblHeaderBalance";
            this.lblHeaderBalance.Size = new System.Drawing.Size(79, 25);
            this.lblHeaderBalance.TabIndex = 41;
            this.lblHeaderBalance.Text = "Saldo:";
            this.lblHeaderBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValueBalance
            // 
            this.lblValueBalance.AutoSize = true;
            this.lblValueBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblValueBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueBalance.ForeColor = System.Drawing.Color.White;
            this.lblValueBalance.Location = new System.Drawing.Point(364, 69);
            this.lblValueBalance.Name = "lblValueBalance";
            this.lblValueBalance.Size = new System.Drawing.Size(107, 25);
            this.lblValueBalance.TabIndex = 40;
            this.lblValueBalance.Text = "R$ 00,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(368, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "R$ 00,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(369, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "R$ 00,00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(845, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeaderBalance);
            this.Controls.Add(this.lblValueBalance);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturnHistory);
            this.Controls.Add(this.dtgListCategoryExpense);
            this.Controls.Add(this.lblHistoryExpense);
            this.Controls.Add(this.dtgListCategoryRecipe);
            this.Controls.Add(this.lblHistoryRecipe);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistoryRecipe;
        private System.Windows.Forms.DataGridView dtgListCategoryRecipe;
        private System.Windows.Forms.DataGridView dtgListCategoryExpense;
        private System.Windows.Forms.Label lblHistoryExpense;
        private System.Windows.Forms.Button btnReturnHistory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeaderBalance;
        private System.Windows.Forms.Label lblValueBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}