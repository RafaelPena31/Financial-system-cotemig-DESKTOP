namespace sistema_finaneiro
{
    partial class Update_Recipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Recipe));
            this.btnUptadeRecipeReturn = new System.Windows.Forms.Button();
            this.txtUpdateValueRecipe = new System.Windows.Forms.TextBox();
            this.dtpUpdateDateRecipe = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateRecipe = new System.Windows.Forms.Button();
            this.lblUpdateValueRecipe = new System.Windows.Forms.Label();
            this.cbxUpdateNameRecipe = new System.Windows.Forms.ComboBox();
            this.lblUpdateChooseDateRecipe = new System.Windows.Forms.Label();
            this.lblUpdateNameRecipe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUptadeRecipeReturn
            // 
            this.btnUptadeRecipeReturn.BackColor = System.Drawing.Color.White;
            this.btnUptadeRecipeReturn.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUptadeRecipeReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnUptadeRecipeReturn.Image")));
            this.btnUptadeRecipeReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUptadeRecipeReturn.Location = new System.Drawing.Point(44, 279);
            this.btnUptadeRecipeReturn.Name = "btnUptadeRecipeReturn";
            this.btnUptadeRecipeReturn.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.btnUptadeRecipeReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUptadeRecipeReturn.Size = new System.Drawing.Size(119, 68);
            this.btnUptadeRecipeReturn.TabIndex = 52;
            this.btnUptadeRecipeReturn.Text = "Voltar";
            this.btnUptadeRecipeReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUptadeRecipeReturn.UseVisualStyleBackColor = false;
            // 
            // txtUpdateValueRecipe
            // 
            this.txtUpdateValueRecipe.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateValueRecipe.Location = new System.Drawing.Point(44, 174);
            this.txtUpdateValueRecipe.Name = "txtUpdateValueRecipe";
            this.txtUpdateValueRecipe.Size = new System.Drawing.Size(269, 22);
            this.txtUpdateValueRecipe.TabIndex = 51;
            this.txtUpdateValueRecipe.TextChanged += new System.EventHandler(this.txtValueRecipe_TextChanged);
            // 
            // dtpUpdateDateRecipe
            // 
            this.dtpUpdateDateRecipe.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUpdateDateRecipe.Location = new System.Drawing.Point(44, 117);
            this.dtpUpdateDateRecipe.Name = "dtpUpdateDateRecipe";
            this.dtpUpdateDateRecipe.Size = new System.Drawing.Size(269, 22);
            this.dtpUpdateDateRecipe.TabIndex = 50;
            this.dtpUpdateDateRecipe.ValueChanged += new System.EventHandler(this.dtpDateRecipe_ValueChanged);
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.AutoEllipsis = true;
            this.btnUpdateRecipe.BackColor = System.Drawing.Color.White;
            this.btnUpdateRecipe.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRecipe.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateRecipe.Image")));
            this.btnUpdateRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateRecipe.Location = new System.Drawing.Point(194, 279);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.btnUpdateRecipe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdateRecipe.Size = new System.Drawing.Size(119, 68);
            this.btnUpdateRecipe.TabIndex = 49;
            this.btnUpdateRecipe.Text = "Alterar";
            this.btnUpdateRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRecipe.UseVisualStyleBackColor = false;
            // 
            // lblUpdateValueRecipe
            // 
            this.lblUpdateValueRecipe.AutoSize = true;
            this.lblUpdateValueRecipe.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateValueRecipe.Location = new System.Drawing.Point(44, 152);
            this.lblUpdateValueRecipe.Name = "lblUpdateValueRecipe";
            this.lblUpdateValueRecipe.Size = new System.Drawing.Size(87, 15);
            this.lblUpdateValueRecipe.TabIndex = 48;
            this.lblUpdateValueRecipe.Text = "Valor da receita";
            // 
            // cbxUpdateNameRecipe
            // 
            this.cbxUpdateNameRecipe.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUpdateNameRecipe.FormattingEnabled = true;
            this.cbxUpdateNameRecipe.Location = new System.Drawing.Point(44, 59);
            this.cbxUpdateNameRecipe.Name = "cbxUpdateNameRecipe";
            this.cbxUpdateNameRecipe.Size = new System.Drawing.Size(269, 23);
            this.cbxUpdateNameRecipe.TabIndex = 47;
            this.cbxUpdateNameRecipe.SelectedIndexChanged += new System.EventHandler(this.cbxNameRecipe_SelectedIndexChanged);
            // 
            // lblUpdateChooseDateRecipe
            // 
            this.lblUpdateChooseDateRecipe.AutoSize = true;
            this.lblUpdateChooseDateRecipe.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateChooseDateRecipe.Location = new System.Drawing.Point(44, 96);
            this.lblUpdateChooseDateRecipe.Name = "lblUpdateChooseDateRecipe";
            this.lblUpdateChooseDateRecipe.Size = new System.Drawing.Size(81, 15);
            this.lblUpdateChooseDateRecipe.TabIndex = 46;
            this.lblUpdateChooseDateRecipe.Text = "Escolha a data";
            // 
            // lblUpdateNameRecipe
            // 
            this.lblUpdateNameRecipe.AutoSize = true;
            this.lblUpdateNameRecipe.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateNameRecipe.Location = new System.Drawing.Point(44, 38);
            this.lblUpdateNameRecipe.Name = "lblUpdateNameRecipe";
            this.lblUpdateNameRecipe.Size = new System.Drawing.Size(91, 15);
            this.lblUpdateNameRecipe.TabIndex = 45;
            this.lblUpdateNameRecipe.Text = "Nome da receita";
            // 
            // Update_Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 396);
            this.Controls.Add(this.btnUptadeRecipeReturn);
            this.Controls.Add(this.txtUpdateValueRecipe);
            this.Controls.Add(this.dtpUpdateDateRecipe);
            this.Controls.Add(this.btnUpdateRecipe);
            this.Controls.Add(this.lblUpdateValueRecipe);
            this.Controls.Add(this.cbxUpdateNameRecipe);
            this.Controls.Add(this.lblUpdateChooseDateRecipe);
            this.Controls.Add(this.lblUpdateNameRecipe);
            this.Name = "Update_Recipe";
            this.Text = "Editar Receita";
            this.Load += new System.EventHandler(this.Update_Recipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUptadeRecipeReturn;
        private System.Windows.Forms.TextBox txtUpdateValueRecipe;
        private System.Windows.Forms.DateTimePicker dtpUpdateDateRecipe;
        private System.Windows.Forms.Button btnUpdateRecipe;
        private System.Windows.Forms.Label lblUpdateValueRecipe;
        private System.Windows.Forms.ComboBox cbxUpdateNameRecipe;
        private System.Windows.Forms.Label lblUpdateChooseDateRecipe;
        private System.Windows.Forms.Label lblUpdateNameRecipe;
    }
}