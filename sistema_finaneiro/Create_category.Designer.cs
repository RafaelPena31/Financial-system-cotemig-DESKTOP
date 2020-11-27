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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnChangeDataCategory = new System.Windows.Forms.Button();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListCategoryExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTypeCategory
            // 
            this.cbxTypeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypeCategory.FormattingEnabled = true;
            this.cbxTypeCategory.Location = new System.Drawing.Point(277, 91);
            this.cbxTypeCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTypeCategory.Name = "cbxTypeCategory";
            this.cbxTypeCategory.Size = new System.Drawing.Size(494, 21);
            this.cbxTypeCategory.TabIndex = 29;
            this.cbxTypeCategory.SelectedIndexChanged += new System.EventHandler(this.cbxTypeCategory_SelectedIndexChanged);
            // 
            // lblTypeCategory
            // 
            this.lblTypeCategory.AutoSize = true;
            this.lblTypeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCategory.Location = new System.Drawing.Point(277, 74);
            this.lblTypeCategory.Name = "lblTypeCategory";
            this.lblTypeCategory.Size = new System.Drawing.Size(95, 13);
            this.lblTypeCategory.TabIndex = 28;
            this.lblTypeCategory.Text = "Tipos de categoria";
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.AutoSize = true;
            this.lblNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCategory.Location = new System.Drawing.Point(277, 18);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(97, 13);
            this.lblNameCategory.TabIndex = 27;
            this.lblNameCategory.Text = "Nome da categoria";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCategory.Location = new System.Drawing.Point(277, 37);
            this.txtNameCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(494, 20);
            this.txtNameCategory.TabIndex = 26;
            // 
            // cbxClassCategory
            // 
            this.cbxClassCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClassCategory.FormattingEnabled = true;
            this.cbxClassCategory.Items.AddRange(new object[] {
            "Alimentação",
            "Educação ",
            "Lazer ",
            "Trabalho ",
            "Transporte ",
            "Vestuário ",
            "Outros"});
            this.cbxClassCategory.Location = new System.Drawing.Point(277, 147);
            this.cbxClassCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxClassCategory.Name = "cbxClassCategory";
            this.cbxClassCategory.Size = new System.Drawing.Size(494, 21);
            this.cbxClassCategory.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Classe da categoria";
            // 
            // btnReturnCategory
            // 
            this.btnReturnCategory.BackColor = System.Drawing.Color.White;
            this.btnReturnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnCategory.Image")));
            this.btnReturnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnCategory.Location = new System.Drawing.Point(277, 239);
            this.btnReturnCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnCategory.Name = "btnReturnCategory";
            this.btnReturnCategory.Padding = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnReturnCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReturnCategory.Size = new System.Drawing.Size(119, 68);
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
            this.btnCreateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateCategory.Image")));
            this.btnCreateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateCategory.Location = new System.Drawing.Point(652, 239);
            this.btnCreateCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Padding = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnCreateCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCreateCategory.Size = new System.Drawing.Size(119, 68);
            this.btnCreateCategory.TabIndex = 33;
            this.btnCreateCategory.Text = "Criar";
            this.btnCreateCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCategory.UseVisualStyleBackColor = false;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // dtgListCategoryRecipe
            // 
            this.dtgListCategoryRecipe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListCategoryRecipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgListCategoryRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListCategoryRecipe.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgListCategoryRecipe.Location = new System.Drawing.Point(24, 325);
            this.dtgListCategoryRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgListCategoryRecipe.Name = "dtgListCategoryRecipe";
            this.dtgListCategoryRecipe.Size = new System.Drawing.Size(470, 194);
            this.dtgListCategoryRecipe.TabIndex = 34;
            // 
            // dtgListCategoryExpense
            // 
            this.dtgListCategoryExpense.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListCategoryExpense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgListCategoryExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListCategoryExpense.DefaultCellStyle = dataGridViewCellStyle20;
            this.dtgListCategoryExpense.Location = new System.Drawing.Point(536, 325);
            this.dtgListCategoryExpense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgListCategoryExpense.Name = "dtgListCategoryExpense";
            this.dtgListCategoryExpense.Size = new System.Drawing.Size(470, 194);
            this.dtgListCategoryExpense.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(402, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(119, 68);
            this.button1.TabIndex = 36;
            this.button1.Text = "Deletar Dados";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeDataCategory
            // 
            this.btnChangeDataCategory.AutoEllipsis = true;
            this.btnChangeDataCategory.BackColor = System.Drawing.Color.White;
            this.btnChangeDataCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDataCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeDataCategory.Image")));
            this.btnChangeDataCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeDataCategory.Location = new System.Drawing.Point(527, 239);
            this.btnChangeDataCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeDataCategory.Name = "btnChangeDataCategory";
            this.btnChangeDataCategory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeDataCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeDataCategory.Size = new System.Drawing.Size(119, 68);
            this.btnChangeDataCategory.TabIndex = 37;
            this.btnChangeDataCategory.Text = "Alterar Dados";
            this.btnChangeDataCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeDataCategory.UseVisualStyleBackColor = false;
            this.btnChangeDataCategory.Click += new System.EventHandler(this.btnChangeDataCategory_Click);
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(316, 202);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(416, 20);
            this.txtCategoryId.TabIndex = 38;
            this.txtCategoryId.TextChanged += new System.EventHandler(this.txtCategoryId_TextChanged);
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(319, 186);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(410, 13);
            this.lblCategoryId.TabIndex = 39;
            this.lblCategoryId.Text = "Id da categoria (Preencha este campo somente para alterar ou deletar uma categori" +
    "a)";
            // 
            // Create_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1029, 532);
            this.Controls.Add(this.lblCategoryId);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.btnChangeDataCategory);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChangeDataCategory;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
    }
}