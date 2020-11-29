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
            this.lblValueRecipeHistory = new System.Windows.Forms.Label();
            this.lblValueExpenseHistory = new System.Windows.Forms.Label();
            this.btnChangeRecipeHistory = new System.Windows.Forms.Button();
            this.btnDeleteRecipeHistory = new System.Windows.Forms.Button();
            this.btnChangeExpenseHistory = new System.Windows.Forms.Button();
            this.btnDeleteExpenseHistory = new System.Windows.Forms.Button();
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
            this.lblHistoryRecipe.Location = new System.Drawing.Point(397, 172);
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
            this.dtgListCategoryRecipe.Location = new System.Drawing.Point(65, 243);
            this.dtgListCategoryRecipe.Name = "dtgListCategoryRecipe";
            this.dtgListCategoryRecipe.RowHeadersWidth = 51;
            this.dtgListCategoryRecipe.Size = new System.Drawing.Size(686, 168);
            this.dtgListCategoryRecipe.TabIndex = 35;
            this.dtgListCategoryRecipe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListCategoryRecipe_CellContentClick);
            // 
            // dtgListCategoryExpense
            // 
            this.dtgListCategoryExpense.BackgroundColor = System.Drawing.Color.White;
            this.dtgListCategoryExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListCategoryExpense.Location = new System.Drawing.Point(78, 504);
            this.dtgListCategoryExpense.Name = "dtgListCategoryExpense";
            this.dtgListCategoryExpense.RowHeadersWidth = 51;
            this.dtgListCategoryExpense.Size = new System.Drawing.Size(673, 168);
            this.dtgListCategoryExpense.TabIndex = 37;
            // 
            // lblHistoryExpense
            // 
            this.lblHistoryExpense.AutoSize = true;
            this.lblHistoryExpense.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistoryExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryExpense.ForeColor = System.Drawing.Color.Black;
            this.lblHistoryExpense.Location = new System.Drawing.Point(392, 429);
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
            this.btnReturnHistory.Click += new System.EventHandler(this.btnReturnHistory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 163);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeaderBalance
            // 
            this.lblHeaderBalance.AutoSize = true;
            this.lblHeaderBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHeaderBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderBalance.ForeColor = System.Drawing.Color.White;
            this.lblHeaderBalance.Location = new System.Drawing.Point(412, 34);
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
            this.lblValueBalance.Location = new System.Drawing.Point(401, 69);
            this.lblValueBalance.Name = "lblValueBalance";
            this.lblValueBalance.Size = new System.Drawing.Size(107, 25);
            this.lblValueBalance.TabIndex = 40;
            this.lblValueBalance.Text = "R$ 00,00";
            // 
            // lblValueRecipeHistory
            // 
            this.lblValueRecipeHistory.AutoSize = true;
            this.lblValueRecipeHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblValueRecipeHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueRecipeHistory.ForeColor = System.Drawing.Color.Black;
            this.lblValueRecipeHistory.Location = new System.Drawing.Point(401, 201);
            this.lblValueRecipeHistory.Name = "lblValueRecipeHistory";
            this.lblValueRecipeHistory.Size = new System.Drawing.Size(107, 25);
            this.lblValueRecipeHistory.TabIndex = 42;
            this.lblValueRecipeHistory.Text = "R$ 00,00";
            // 
            // lblValueExpenseHistory
            // 
            this.lblValueExpenseHistory.AutoSize = true;
            this.lblValueExpenseHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblValueExpenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueExpenseHistory.ForeColor = System.Drawing.Color.Black;
            this.lblValueExpenseHistory.Location = new System.Drawing.Point(401, 457);
            this.lblValueExpenseHistory.Name = "lblValueExpenseHistory";
            this.lblValueExpenseHistory.Size = new System.Drawing.Size(107, 25);
            this.lblValueExpenseHistory.TabIndex = 43;
            this.lblValueExpenseHistory.Text = "R$ 00,00";
            this.lblValueExpenseHistory.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnChangeRecipeHistory
            // 
            this.btnChangeRecipeHistory.AutoEllipsis = true;
            this.btnChangeRecipeHistory.BackColor = System.Drawing.Color.White;
            this.btnChangeRecipeHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRecipeHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeRecipeHistory.Image")));
            this.btnChangeRecipeHistory.Location = new System.Drawing.Point(757, 243);
            this.btnChangeRecipeHistory.Name = "btnChangeRecipeHistory";
            this.btnChangeRecipeHistory.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnChangeRecipeHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeRecipeHistory.Size = new System.Drawing.Size(76, 73);
            this.btnChangeRecipeHistory.TabIndex = 51;
            this.btnChangeRecipeHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeRecipeHistory.UseVisualStyleBackColor = false;
            this.btnChangeRecipeHistory.Click += new System.EventHandler(this.btnChangeRecipeHistory_Click);
            // 
            // btnDeleteRecipeHistory
            // 
            this.btnDeleteRecipeHistory.AutoEllipsis = true;
            this.btnDeleteRecipeHistory.BackColor = System.Drawing.Color.White;
            this.btnDeleteRecipeHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecipeHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRecipeHistory.Image")));
            this.btnDeleteRecipeHistory.Location = new System.Drawing.Point(757, 338);
            this.btnDeleteRecipeHistory.Name = "btnDeleteRecipeHistory";
            this.btnDeleteRecipeHistory.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnDeleteRecipeHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteRecipeHistory.Size = new System.Drawing.Size(76, 73);
            this.btnDeleteRecipeHistory.TabIndex = 52;
            this.btnDeleteRecipeHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteRecipeHistory.UseVisualStyleBackColor = false;
            this.btnDeleteRecipeHistory.Click += new System.EventHandler(this.btnDeleteRecipeHistory_Click);
            // 
            // btnChangeExpenseHistory
            // 
            this.btnChangeExpenseHistory.AutoEllipsis = true;
            this.btnChangeExpenseHistory.BackColor = System.Drawing.Color.White;
            this.btnChangeExpenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeExpenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeExpenseHistory.Image")));
            this.btnChangeExpenseHistory.Location = new System.Drawing.Point(757, 504);
            this.btnChangeExpenseHistory.Name = "btnChangeExpenseHistory";
            this.btnChangeExpenseHistory.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnChangeExpenseHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeExpenseHistory.Size = new System.Drawing.Size(76, 73);
            this.btnChangeExpenseHistory.TabIndex = 53;
            this.btnChangeExpenseHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeExpenseHistory.UseVisualStyleBackColor = false;
            this.btnChangeExpenseHistory.Click += new System.EventHandler(this.btnChangeExpenseHistory_Click);
            // 
            // btnDeleteExpenseHistory
            // 
            this.btnDeleteExpenseHistory.AutoEllipsis = true;
            this.btnDeleteExpenseHistory.BackColor = System.Drawing.Color.White;
            this.btnDeleteExpenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteExpenseHistory.Image")));
            this.btnDeleteExpenseHistory.Location = new System.Drawing.Point(757, 599);
            this.btnDeleteExpenseHistory.Name = "btnDeleteExpenseHistory";
            this.btnDeleteExpenseHistory.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnDeleteExpenseHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteExpenseHistory.Size = new System.Drawing.Size(76, 73);
            this.btnDeleteExpenseHistory.TabIndex = 54;
            this.btnDeleteExpenseHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteExpenseHistory.UseVisualStyleBackColor = false;
            this.btnDeleteExpenseHistory.Click += new System.EventHandler(this.btnDeleteExpenseHistory_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 749);
            this.Controls.Add(this.btnDeleteExpenseHistory);
            this.Controls.Add(this.btnChangeExpenseHistory);
            this.Controls.Add(this.btnDeleteRecipeHistory);
            this.Controls.Add(this.btnChangeRecipeHistory);
            this.Controls.Add(this.lblValueExpenseHistory);
            this.Controls.Add(this.lblValueRecipeHistory);
            this.Controls.Add(this.lblHeaderBalance);
            this.Controls.Add(this.lblValueBalance);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturnHistory);
            this.Controls.Add(this.dtgListCategoryExpense);
            this.Controls.Add(this.lblHistoryExpense);
            this.Controls.Add(this.dtgListCategoryRecipe);
            this.Controls.Add(this.lblHistoryRecipe);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
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
        private System.Windows.Forms.Label lblValueRecipeHistory;
        private System.Windows.Forms.Label lblValueExpenseHistory;
        private System.Windows.Forms.Button btnChangeRecipeHistory;
        private System.Windows.Forms.Button btnDeleteRecipeHistory;
        private System.Windows.Forms.Button btnChangeExpenseHistory;
        private System.Windows.Forms.Button btnDeleteExpenseHistory;
    }
}