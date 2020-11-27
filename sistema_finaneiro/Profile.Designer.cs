namespace sistema_finaneiro
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.lblHeaderBalance = new System.Windows.Forms.Label();
            this.lblValueBalance = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.btnChangeTelephone = new System.Windows.Forms.Button();
            this.btnChangeAdress = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnReturnProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderBalance
            // 
            this.lblHeaderBalance.AutoSize = true;
            this.lblHeaderBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHeaderBalance.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderBalance.ForeColor = System.Drawing.Color.White;
            this.lblHeaderBalance.Location = new System.Drawing.Point(365, 28);
            this.lblHeaderBalance.Name = "lblHeaderBalance";
            this.lblHeaderBalance.Size = new System.Drawing.Size(75, 28);
            this.lblHeaderBalance.TabIndex = 35;
            this.lblHeaderBalance.Text = "Saldo:";
            this.lblHeaderBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeaderBalance.Click += new System.EventHandler(this.lblHeaderBalance_Click);
            // 
            // lblValueBalance
            // 
            this.lblValueBalance.AutoSize = true;
            this.lblValueBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblValueBalance.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueBalance.ForeColor = System.Drawing.Color.White;
            this.lblValueBalance.Location = new System.Drawing.Point(351, 63);
            this.lblValueBalance.Name = "lblValueBalance";
            this.lblValueBalance.Size = new System.Drawing.Size(97, 28);
            this.lblValueBalance.TabIndex = 34;
            this.lblValueBalance.Text = "R$ 00,00";
            this.lblValueBalance.Click += new System.EventHandler(this.lblValueBalance_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 163);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewData
            // 
            this.btnViewData.AutoEllipsis = true;
            this.btnViewData.BackColor = System.Drawing.Color.White;
            this.btnViewData.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewData.Image = ((System.Drawing.Image)(resources.GetObject("btnViewData.Image")));
            this.btnViewData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewData.Location = new System.Drawing.Point(134, 235);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnViewData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnViewData.Size = new System.Drawing.Size(161, 149);
            this.btnViewData.TabIndex = 50;
            this.btnViewData.Text = "Visualizar dados";
            this.btnViewData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewData.UseVisualStyleBackColor = false;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // btnChangeName
            // 
            this.btnChangeName.AutoEllipsis = true;
            this.btnChangeName.BackColor = System.Drawing.Color.White;
            this.btnChangeName.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeName.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeName.Image")));
            this.btnChangeName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeName.Location = new System.Drawing.Point(320, 235);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnChangeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeName.Size = new System.Drawing.Size(161, 149);
            this.btnChangeName.TabIndex = 51;
            this.btnChangeName.Text = "Alterar nome";
            this.btnChangeName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeName.UseVisualStyleBackColor = false;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.AutoEllipsis = true;
            this.btnChangeEmail.BackColor = System.Drawing.Color.White;
            this.btnChangeEmail.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeEmail.Image")));
            this.btnChangeEmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeEmail.Location = new System.Drawing.Point(506, 235);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnChangeEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeEmail.Size = new System.Drawing.Size(161, 149);
            this.btnChangeEmail.TabIndex = 52;
            this.btnChangeEmail.Text = "Alterar Email";
            this.btnChangeEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeEmail.UseVisualStyleBackColor = false;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
            // 
            // btnChangeTelephone
            // 
            this.btnChangeTelephone.AutoEllipsis = true;
            this.btnChangeTelephone.BackColor = System.Drawing.Color.White;
            this.btnChangeTelephone.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTelephone.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeTelephone.Image")));
            this.btnChangeTelephone.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeTelephone.Location = new System.Drawing.Point(506, 409);
            this.btnChangeTelephone.Name = "btnChangeTelephone";
            this.btnChangeTelephone.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnChangeTelephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeTelephone.Size = new System.Drawing.Size(161, 149);
            this.btnChangeTelephone.TabIndex = 55;
            this.btnChangeTelephone.Text = "Alterar telefone";
            this.btnChangeTelephone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeTelephone.UseVisualStyleBackColor = false;
            this.btnChangeTelephone.Click += new System.EventHandler(this.btnChangeTelephone_Click);
            // 
            // btnChangeAdress
            // 
            this.btnChangeAdress.AutoEllipsis = true;
            this.btnChangeAdress.BackColor = System.Drawing.Color.White;
            this.btnChangeAdress.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAdress.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeAdress.Image")));
            this.btnChangeAdress.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeAdress.Location = new System.Drawing.Point(320, 409);
            this.btnChangeAdress.Name = "btnChangeAdress";
            this.btnChangeAdress.Padding = new System.Windows.Forms.Padding(7, 35, 7, 35);
            this.btnChangeAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeAdress.Size = new System.Drawing.Size(161, 149);
            this.btnChangeAdress.TabIndex = 54;
            this.btnChangeAdress.Text = "Alterar endereço";
            this.btnChangeAdress.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeAdress.UseVisualStyleBackColor = false;
            this.btnChangeAdress.Click += new System.EventHandler(this.btnChangeAdress_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoEllipsis = true;
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangePassword.Location = new System.Drawing.Point(134, 409);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnChangePassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangePassword.Size = new System.Drawing.Size(161, 149);
            this.btnChangePassword.TabIndex = 53;
            this.btnChangePassword.Text = "Alterar senha";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInstruction.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.Black;
            this.lblInstruction.Location = new System.Drawing.Point(294, 183);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(212, 28);
            this.lblInstruction.TabIndex = 56;
            this.lblInstruction.Text = "O que deseja fazer?";
            this.lblInstruction.Click += new System.EventHandler(this.lblInstruction_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.AutoEllipsis = true;
            this.btnDeleteAccount.BackColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAccount.Image")));
            this.btnDeleteAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteAccount.Location = new System.Drawing.Point(320, 588);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Padding = new System.Windows.Forms.Padding(9, 35, 9, 35);
            this.btnDeleteAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteAccount.Size = new System.Drawing.Size(161, 149);
            this.btnDeleteAccount.TabIndex = 57;
            this.btnDeleteAccount.Text = "Deletar conta";
            this.btnDeleteAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnReturnProfile
            // 
            this.btnReturnProfile.BackColor = System.Drawing.Color.White;
            this.btnReturnProfile.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnProfile.Image")));
            this.btnReturnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnProfile.Location = new System.Drawing.Point(12, 669);
            this.btnReturnProfile.Name = "btnReturnProfile";
            this.btnReturnProfile.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.btnReturnProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReturnProfile.Size = new System.Drawing.Size(119, 68);
            this.btnReturnProfile.TabIndex = 58;
            this.btnReturnProfile.Text = "Voltar";
            this.btnReturnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnProfile.UseVisualStyleBackColor = false;
            this.btnReturnProfile.Click += new System.EventHandler(this.btnReturnProfile_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.btnReturnProfile);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnChangeTelephone);
            this.Controls.Add(this.btnChangeAdress);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.lblHeaderBalance);
            this.Controls.Add(this.lblValueBalance);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderBalance;
        private System.Windows.Forms.Label lblValueBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Button btnChangeTelephone;
        private System.Windows.Forms.Button btnChangeAdress;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnReturnProfile;
    }
}