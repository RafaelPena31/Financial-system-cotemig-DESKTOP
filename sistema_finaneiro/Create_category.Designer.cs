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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnChangeDataCategory = new System.Windows.Forms.Button();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTypeCategory
            // 
            this.cbxTypeCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypeCategory.FormattingEnabled = true;
            this.cbxTypeCategory.Location = new System.Drawing.Point(184, 78);
            this.cbxTypeCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxTypeCategory.Name = "cbxTypeCategory";
            this.cbxTypeCategory.Size = new System.Drawing.Size(420, 23);
            this.cbxTypeCategory.TabIndex = 29;
            this.cbxTypeCategory.SelectedIndexChanged += new System.EventHandler(this.cbxTypeCategory_SelectedIndexChanged);
            // 
            // lblTypeCategory
            // 
            this.lblTypeCategory.AutoSize = true;
            this.lblTypeCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCategory.Location = new System.Drawing.Point(184, 59);
            this.lblTypeCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeCategory.Name = "lblTypeCategory";
            this.lblTypeCategory.Size = new System.Drawing.Size(101, 15);
            this.lblTypeCategory.TabIndex = 28;
            this.lblTypeCategory.Text = "Tipos de categoria";
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoSize = true;
            this.lblNameCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCategory.Location = new System.Drawing.Point(184, 14);
            this.lblNameCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(104, 15);
            this.lblNameCategory.TabIndex = 27;
            this.lblNameCategory.Text = "Nome da categoria";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCategory.Location = new System.Drawing.Point(184, 33);
            this.txtNameCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(420, 22);
            this.txtNameCategory.TabIndex = 26;
            // 
            // cbxClassCategory
            // 
            this.cbxClassCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClassCategory.FormattingEnabled = true;
            this.cbxClassCategory.Items.AddRange(new object[] {
            "Alimentação",
            "Educação ",
            "Lazer ",
            "Trabalho ",
            "Transporte ",
            "Vestuário ",
            "Outros"});
            this.cbxClassCategory.Location = new System.Drawing.Point(184, 124);
            this.cbxClassCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxClassCategory.Name = "cbxClassCategory";
            this.cbxClassCategory.Size = new System.Drawing.Size(420, 23);
            this.cbxClassCategory.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Classe da categoria";
            // 
            // btnReturnCategory
            // 
            this.btnReturnCategory.BackColor = System.Drawing.Color.White;
            this.btnReturnCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnCategory.Image")));
            this.btnReturnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnCategory.Location = new System.Drawing.Point(184, 201);
            this.btnReturnCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturnCategory.Name = "btnReturnCategory";
            this.btnReturnCategory.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnReturnCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReturnCategory.Size = new System.Drawing.Size(98, 52);
            this.btnReturnCategory.TabIndex = 32;
            this.btnReturnCategory.Text = "Voltar";
            this.btnReturnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnCategory.UseVisualStyleBackColor = false;
            this.btnReturnCategory.Click += new System.EventHandler(this.btnReturnCategory_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.AutoEllipsis = true;
            this.btnCreateCategory.BackColor = System.Drawing.Color.White;
            this.btnCreateCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateCategory.Image")));
            this.btnCreateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateCategory.Location = new System.Drawing.Point(518, 201);
            this.btnCreateCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnCreateCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCreateCategory.Size = new System.Drawing.Size(89, 52);
            this.btnCreateCategory.TabIndex = 33;
            this.btnCreateCategory.Text = "Criar";
            this.btnCreateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // dtgListCategoryRecipe
            // 
            this.dtgListCategoryRecipe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListCategoryRecipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListCategoryRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListCategoryRecipe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListCategoryRecipe.Location = new System.Drawing.Point(11, 259);
            this.dtgListCategoryRecipe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgListCategoryRecipe.Name = "dtgListCategoryRecipe";
            this.dtgListCategoryRecipe.RowHeadersWidth = 51;
            this.dtgListCategoryRecipe.Size = new System.Drawing.Size(352, 148);
            this.dtgListCategoryRecipe.TabIndex = 34;
            // 
            // dtgListCategoryExpense
            // 
            this.dtgListCategoryExpense.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListCategoryExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListCategoryExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListCategoryExpense.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgListCategoryExpense.Location = new System.Drawing.Point(398, 259);
            this.dtgListCategoryExpense.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgListCategoryExpense.Name = "dtgListCategoryExpense";
            this.dtgListCategoryExpense.RowHeadersWidth = 51;
            this.dtgListCategoryExpense.Size = new System.Drawing.Size(352, 148);
            this.dtgListCategoryExpense.TabIndex = 35;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.AutoEllipsis = true;
            this.btnDeleteCategory.BackColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCategory.Location = new System.Drawing.Point(286, 201);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnDeleteCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteCategory.Size = new System.Drawing.Size(112, 52);
            this.btnDeleteCategory.TabIndex = 36;
            this.btnDeleteCategory.Text = "Deletar Dados";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnChangeDataCategory
            // 
            this.btnChangeDataCategory.AutoEllipsis = true;
            this.btnChangeDataCategory.BackColor = System.Drawing.Color.White;
            this.btnChangeDataCategory.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDataCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeDataCategory.Image")));
            this.btnChangeDataCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeDataCategory.Location = new System.Drawing.Point(402, 201);
            this.btnChangeDataCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChangeDataCategory.Name = "btnChangeDataCategory";
            this.btnChangeDataCategory.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnChangeDataCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeDataCategory.Size = new System.Drawing.Size(112, 52);
            this.btnChangeDataCategory.TabIndex = 37;
            this.btnChangeDataCategory.Text = "Alterar Dados";
            this.btnChangeDataCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeDataCategory.UseVisualStyleBackColor = false;
            this.btnChangeDataCategory.Click += new System.EventHandler(this.btnChangeDataCategory_Click);
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryId.Location = new System.Drawing.Point(184, 170);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(420, 22);
            this.txtCategoryId.TabIndex = 38;
            this.txtCategoryId.TextChanged += new System.EventHandler(this.txtCategoryId_TextChanged);
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(184, 151);
            this.lblCategoryId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(444, 15);
            this.lblCategoryId.TabIndex = 39;
            this.lblCategoryId.Text = "Id da categoria (Preencha este campo somente para alterar ou deletar uma categori" +
    "a)";
            // 
            // Create_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(772, 419);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.btnChangeDataCategory);
            this.Controls.Add(this.btnDeleteCategory);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Create_category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Create_category_Load);
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
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnChangeDataCategory;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
    }
}