namespace sistema_finaneiro
{
    partial class btnReturnRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnReturnRecipe));
            this.btnCreateRecipe = new System.Windows.Forms.Button();
            this.lblValueRecipe = new System.Windows.Forms.Label();
            this.cbxNameRecipe = new System.Windows.Forms.ComboBox();
            this.lblChooseDateRecipe = new System.Windows.Forms.Label();
            this.lblNameRecipe = new System.Windows.Forms.Label();
            this.dtpDateRecipe = new System.Windows.Forms.DateTimePicker();
            this.txtValueRecipe = new System.Windows.Forms.TextBox();
            this.btnRecipeReturn = new System.Windows.Forms.Button();
            this.lblHeaderRecipe = new System.Windows.Forms.Label();
            this.lblValueBalance = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateRecipe
            // 
            this.btnCreateRecipe.AutoEllipsis = true;
            this.btnCreateRecipe.BackColor = System.Drawing.Color.White;
            this.btnCreateRecipe.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateRecipe.Image")));
            this.btnCreateRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateRecipe.Location = new System.Drawing.Point(308, 459);
            this.btnCreateRecipe.Name = "btnCreateRecipe";
            this.btnCreateRecipe.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.btnCreateRecipe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCreateRecipe.Size = new System.Drawing.Size(119, 68);
            this.btnCreateRecipe.TabIndex = 41;
            this.btnCreateRecipe.Text = "Criar";
            this.btnCreateRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateRecipe.UseVisualStyleBackColor = false;
            this.btnCreateRecipe.Click += new System.EventHandler(this.btnCreateRecipe_Click);
            // 
            // lblValueRecipe
            // 
            this.lblValueRecipe.AutoSize = true;
            this.lblValueRecipe.Location = new System.Drawing.Point(158, 382);
            this.lblValueRecipe.Name = "lblValueRecipe";
            this.lblValueRecipe.Size = new System.Drawing.Size(81, 13);
            this.lblValueRecipe.TabIndex = 39;
            this.lblValueRecipe.Text = "Valor da receita";
            // 
            // cbxNameRecipe
            // 
            this.cbxNameRecipe.FormattingEnabled = true;
            this.cbxNameRecipe.Location = new System.Drawing.Point(158, 249);
            this.cbxNameRecipe.Name = "cbxNameRecipe";
            this.cbxNameRecipe.Size = new System.Drawing.Size(269, 21);
            this.cbxNameRecipe.TabIndex = 37;
            // 
            // lblChooseDateRecipe
            // 
            this.lblChooseDateRecipe.AutoSize = true;
            this.lblChooseDateRecipe.Location = new System.Drawing.Point(158, 301);
            this.lblChooseDateRecipe.Name = "lblChooseDateRecipe";
            this.lblChooseDateRecipe.Size = new System.Drawing.Size(78, 13);
            this.lblChooseDateRecipe.TabIndex = 36;
            this.lblChooseDateRecipe.Text = "Escolha a data";
            // 
            // lblNameRecipe
            // 
            this.lblNameRecipe.AutoSize = true;
            this.lblNameRecipe.Location = new System.Drawing.Point(158, 218);
            this.lblNameRecipe.Name = "lblNameRecipe";
            this.lblNameRecipe.Size = new System.Drawing.Size(85, 13);
            this.lblNameRecipe.TabIndex = 35;
            this.lblNameRecipe.Text = "Nome da receita";
            this.lblNameRecipe.Click += new System.EventHandler(this.lblNameRecipe_Click);
            // 
            // dtpDateRecipe
            // 
            this.dtpDateRecipe.Location = new System.Drawing.Point(158, 332);
            this.dtpDateRecipe.Name = "dtpDateRecipe";
            this.dtpDateRecipe.Size = new System.Drawing.Size(269, 20);
            this.dtpDateRecipe.TabIndex = 42;
            // 
            // txtValueRecipe
            // 
            this.txtValueRecipe.Location = new System.Drawing.Point(158, 414);
            this.txtValueRecipe.Name = "txtValueRecipe";
            this.txtValueRecipe.Size = new System.Drawing.Size(269, 20);
            this.txtValueRecipe.TabIndex = 43;
            // 
            // btnRecipeReturn
            // 
            this.btnRecipeReturn.BackColor = System.Drawing.Color.White;
            this.btnRecipeReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnRecipeReturn.Image")));
            this.btnRecipeReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecipeReturn.Location = new System.Drawing.Point(156, 459);
            this.btnRecipeReturn.Name = "btnRecipeReturn";
            this.btnRecipeReturn.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.btnRecipeReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRecipeReturn.Size = new System.Drawing.Size(119, 68);
            this.btnRecipeReturn.TabIndex = 44;
            this.btnRecipeReturn.Text = "Voltar";
            this.btnRecipeReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecipeReturn.UseVisualStyleBackColor = false;
            // 
            // lblHeaderRecipe
            // 
            this.lblHeaderRecipe.AutoSize = true;
            this.lblHeaderRecipe.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHeaderRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderRecipe.ForeColor = System.Drawing.Color.White;
            this.lblHeaderRecipe.Location = new System.Drawing.Point(246, 31);
            this.lblHeaderRecipe.Name = "lblHeaderRecipe";
            this.lblHeaderRecipe.Size = new System.Drawing.Size(99, 25);
            this.lblHeaderRecipe.TabIndex = 57;
            this.lblHeaderRecipe.Text = "Receita:";
            this.lblHeaderRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValueBalance
            // 
            this.lblValueBalance.AutoSize = true;
            this.lblValueBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblValueBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueBalance.ForeColor = System.Drawing.Color.White;
            this.lblValueBalance.Location = new System.Drawing.Point(242, 70);
            this.lblValueBalance.Name = "lblValueBalance";
            this.lblValueBalance.Size = new System.Drawing.Size(107, 25);
            this.lblValueBalance.TabIndex = 56;
            this.lblValueBalance.Text = "R$ 00,00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 152);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturnRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 622);
            this.Controls.Add(this.lblHeaderRecipe);
            this.Controls.Add(this.lblValueBalance);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRecipeReturn);
            this.Controls.Add(this.txtValueRecipe);
            this.Controls.Add(this.dtpDateRecipe);
            this.Controls.Add(this.btnCreateRecipe);
            this.Controls.Add(this.lblValueRecipe);
            this.Controls.Add(this.cbxNameRecipe);
            this.Controls.Add(this.lblChooseDateRecipe);
            this.Controls.Add(this.lblNameRecipe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "btnReturnRecipe";
            this.Text = "Create_recipe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRecipe;
        private System.Windows.Forms.Label lblValueRecipe;
        private System.Windows.Forms.ComboBox cbxNameRecipe;
        private System.Windows.Forms.Label lblChooseDateRecipe;
        private System.Windows.Forms.Label lblNameRecipe;
        private System.Windows.Forms.DateTimePicker dtpDateRecipe;
        private System.Windows.Forms.TextBox txtValueRecipe;
        private System.Windows.Forms.Button btnRecipeReturn;
        private System.Windows.Forms.Label lblHeaderRecipe;
        private System.Windows.Forms.Label lblValueBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}