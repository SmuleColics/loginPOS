namespace loginPOS
{
    partial class loginPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signinButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rbCashierLogin = new System.Windows.Forms.RadioButton();
            this.rbAdminLogin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEnterPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEnterUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.cbShowPassword);
            this.panel1.Controls.Add(this.signinButton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rbCashierLogin);
            this.panel1.Controls.Add(this.rbAdminLogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbEnterPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbEnterUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(42, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 307);
            this.panel1.TabIndex = 3;
            // 
            // signinButton
            // 
            this.signinButton.FlatAppearance.BorderSize = 0;
            this.signinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signinButton.Location = new System.Drawing.Point(195, 272);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(64, 25);
            this.signinButton.TabIndex = 18;
            this.signinButton.Text = "Sign In";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Doesn\'t have an account?";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(14, 233);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(261, 41);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Account type :";
            // 
            // rbCashierLogin
            // 
            this.rbCashierLogin.AutoSize = true;
            this.rbCashierLogin.Checked = true;
            this.rbCashierLogin.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCashierLogin.Location = new System.Drawing.Point(193, 50);
            this.rbCashierLogin.Name = "rbCashierLogin";
            this.rbCashierLogin.Size = new System.Drawing.Size(69, 21);
            this.rbCashierLogin.TabIndex = 12;
            this.rbCashierLogin.TabStop = true;
            this.rbCashierLogin.Text = "Cashier";
            this.rbCashierLogin.UseVisualStyleBackColor = true;
            // 
            // rbAdminLogin
            // 
            this.rbAdminLogin.AutoSize = true;
            this.rbAdminLogin.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdminLogin.Location = new System.Drawing.Point(193, 33);
            this.rbAdminLogin.Name = "rbAdminLogin";
            this.rbAdminLogin.Size = new System.Drawing.Size(63, 21);
            this.rbAdminLogin.TabIndex = 11;
            this.rbAdminLogin.Text = "Admin";
            this.rbAdminLogin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter your account";
            // 
            // tbEnterPassword
            // 
            this.tbEnterPassword.Location = new System.Drawing.Point(15, 170);
            this.tbEnterPassword.Name = "tbEnterPassword";
            this.tbEnterPassword.Size = new System.Drawing.Size(260, 29);
            this.tbEnterPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Password :";
            // 
            // tbEnterUsername
            // 
            this.tbEnterUsername.Location = new System.Drawing.Point(15, 107);
            this.tbEnterUsername.Name = "tbEnterUsername";
            this.tbEnterUsername.Size = new System.Drawing.Size(260, 29);
            this.tbEnterUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Point Of Sale System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.Location = new System.Drawing.Point(167, 201);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(108, 19);
            this.cbShowPassword.TabIndex = 19;
            this.cbShowPassword.Text = "Show password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // loginPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "loginPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.loginPOS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbCashierLogin;
        private System.Windows.Forms.RadioButton rbAdminLogin;
        private System.Windows.Forms.TextBox tbEnterPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEnterUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}