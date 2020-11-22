namespace sistema_finaneiro
{
    partial class Create_category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_category));
            this.cbxTypeCategory = new System.Windows.Forms.ComboBox();
            this.lblTypeCategory = new System.Windows.Forms.Label();
            this.lblNameCategory = new System.Windows.Forms.Label();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.cbxClassCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturnCategory = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.dtgListCategoryRecipe = new System.Windows.Forms.DataGridView();
            this.dtgListCategoryExpense = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTypeCategory
            // 
            this.cbxTypeCategory.FormattingEnabled = true;
            this.cbxTypeCategory.Location = new System.Drawing.Point(277, 148);
            this.cbxTypeCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTypeCategory.Name = "cbxTypeCategory";
            this.cbxTypeCategory.Size = new System.Drawing.Size(470, 23);
            this.cbxTypeCategory.TabIndex = 29;
            // 
            // lblTypeCategory
            // 
            this.lblTypeCategory.AutoSize = true;
            this.lblTypeCategory.Location = new System.Drawing.Point(277, 116);
            this.lblTypeCategory.Name = "lblTypeCategory";
            this.lblTypeCategory.Size = new System.Drawing.Size(101, 15);
            this.lblTypeCategory.TabIndex = 28;
            this.lblTypeCategory.Text = "Tipos de categoria";
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoSize = true;
            this.lblNameCategory.Location = new System.Drawing.Point(277, 30);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(104, 15);
            this.lblNameCategory.TabIndex = 27;
            this.lblNameCategory.Text = "Nome da categoria";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(277, 64);
            this.txtNameCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(470, 22);
            this.txtNameCategory.TabIndex = 26;
            // 
            // cbxClassCategory
            // 
            this.cbxClassCategory.FormattingEnabled = true;
            this.cbxClassCategory.Location = new System.Drawing.Point(277, 234);
            this.cbxClassCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxClassCategory.Name = "cbxClassCategory";
            this.cbxClassCategory.Size = new System.Drawing.Size(470, 23);
            this.cbxClassCategory.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Classe da categoria";
            // 
            // btnReturnCategory
            // 
            this.btnReturnCategory.BackColor = System.Drawing.Color.White;
            this.btnReturnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnCategory.Image")));
            this.btnReturnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnCategory.Location = new System.Drawing.Point(277, 281);
            this.btnReturnCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnCategory.Name = "btnReturnCategory";
            this.btnReturnCategory.Padding = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnReturnCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReturnCategory.Size = new System.Drawing.Size(119, 68);
            this.btnReturnCategory.TabIndex = 32;
            this.btnReturnCategory.Text = "Voltar";
            this.btnReturnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnCategory.UseVisualStyleBackColor = false;
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.AutoEllipsis = true;
            this.btnCreateCategory.BackColor = System.Drawing.Color.White;
            this.btnCreateCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateCategory.Image")));
            this.btnCreateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateCategory.Location = new System.Drawing.Point(628, 281);
            this.btnCreateCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Padding = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnCreateCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCreateCategory.Size = new System.Drawing.Size(119, 68);
            this.btnCreateCategory.TabIndex = 33;
            this.btnCreateCategory.Text = "Criar";
            this.btnCreateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            // 
            // dtgListCategoryRecipe
            // 
            this.dtgListCategoryRecipe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgListCategoryRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListCategoryRecipe.Location = new System.Drawing.Point(24, 386);
            this.dtgListCategoryRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgListCategoryRecipe.Name = "dtgListCategoryRecipe";
            this.dtgListCategoryRecipe.Size = new System.Drawing.Size(470, 194);
            this.dtgListCategoryRecipe.TabIndex = 34;
            // 
            // dtgListCategoryExpense
            // 
            this.dtgListCategoryExpense.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgListCategoryExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListCategoryExpense.Location = new System.Drawing.Point(536, 386);
            this.dtgListCategoryExpense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgListCategoryExpense.Name = "dtgListCategoryExpense";
            this.dtgListCategoryExpense.Size = new System.Drawing.Size(470, 194);
            this.dtgListCategoryExpense.TabIndex = 35;
            // 
            // Create_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1029, 624);
            this.Controls.Add(this.dtgListCategoryExpense);
            this.Controls.Add(this.dtgListCategoryRecipe);
            this.Controls.Add(this.btnCreateCategory);
            this.Controls.Add(this.btnReturnCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxClassCategory);
            this.Controls.Add(this.cbxTypeCategory);
            this.Controls.Add(this.lblTypeCategory);
            this.Controls.Add(this.lblNameCategory);
            this.Controls.Add(this.txtNameCategory);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Create_category";
            this.Text = "Create_category";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTypeCategory;
        private System.Windows.Forms.Label lblTypeCategory;
        private System.Windows.Forms.Label lblNameCategory;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.ComboBox cbxClassCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturnCategory;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.DataGridView dtgListCategoryRecipe;
        private System.Windows.Forms.DataGridView dtgListCategoryExpense;
    }
}