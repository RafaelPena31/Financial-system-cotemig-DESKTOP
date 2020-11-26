namespace sistema_finaneiro
{
    partial class User_register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_register));
            this.btnUserRegister = new System.Windows.Forms.Button();
            this.btnReturnRegister = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnUserRegister
            // 
            this.btnUserRegister.AutoEllipsis = true;
            this.btnUserRegister.BackColor = System.Drawing.Color.White;
            this.btnUserRegister.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnUserRegister.Image")));
            this.btnUserRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserRegister.Location = new System.Drawing.Point(478, 233);
            this.btnUserRegister.Name = "btnUserRegister";
            this.btnUserRegister.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnUserRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUserRegister.Size = new System.Drawing.Size(119, 68);
            this.btnUserRegister.TabIndex = 22;
            this.btnUserRegister.Text = "Cadastrar";
            this.btnUserRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRegister.UseVisualStyleBackColor = false;
            this.btnUserRegister.Click += new System.EventHandler(this.btn_userregister_Click);
            // 
            // btnReturnRegister
            // 
            this.btnReturnRegister.BackColor = System.Drawing.Color.White;
            this.btnReturnRegister.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnRegister.Image")));
            this.btnReturnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnRegister.Location = new System.Drawing.Point(19, 233);
            this.btnReturnRegister.Name = "btnReturnRegister";
            this.btnReturnRegister.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.btnReturnRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReturnRegister.Size = new System.Drawing.Size(119, 68);
            this.btnReturnRegister.TabIndex = 21;
            this.btnReturnRegister.Text = "Voltar";
            this.btnReturnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnRegister.UseVisualStyleBackColor = false;
            this.btnReturnRegister.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(19, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(39, 15);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Senha";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(19, 169);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(269, 22);
            this.textPassword.TabIndex = 19;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(19, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 15);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(19, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 22);
            this.txtName.TabIndex = 17;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(19, 100);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(32, 15);
            this.lblSex.TabIndex = 24;
            this.lblSex.Text = "Sexo";
            this.lblSex.Click += new System.EventHandler(this.lblSex_Click);
            // 
            // cbxSex
            // 
            this.cbxSex.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cbxSex.Location = new System.Drawing.Point(19, 117);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(269, 23);
            this.cbxSex.TabIndex = 25;
            this.cbxSex.SelectedIndexChanged += new System.EventHandler(this.cbxSex_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(328, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 22);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(328, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(328, 152);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(55, 15);
            this.lblAdress.TabIndex = 29;
            this.lblAdress.Text = "Endereço";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(328, 169);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(269, 22);
            this.txtAdress.TabIndex = 28;
            this.txtAdress.TextChanged += new System.EventHandler(this.txtAdress_TextChanged);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(328, 100);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(52, 15);
            this.lblTelephone.TabIndex = 31;
            this.lblTelephone.Text = "Telefone";
            this.lblTelephone.Click += new System.EventHandler(this.lblTelephone_Click);
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPhone.Location = new System.Drawing.Point(328, 117);
            this.mtxtPhone.Mask = "(99) 00000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(269, 22);
            this.mtxtPhone.TabIndex = 32;
            this.mtxtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtPhone_MaskInputRejected);
            // 
            // User_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(618, 332);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.btnUserRegister);
            this.Controls.Add(this.btnReturnRegister);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "User_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.User_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserRegister;
        private System.Windows.Forms.Button btnReturnRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
    }
}