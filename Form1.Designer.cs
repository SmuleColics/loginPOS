using System;

namespace loginPOS
{
    partial class signinPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signinPOS));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.signinButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rbCashierSignin = new System.Windows.Forms.RadioButton();
            this.rbAdminSigin = new System.Windows.Forms.RadioButton();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCreatePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCreateUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point Of Sale System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.cbShowPassword);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.signinButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rbCashierSignin);
            this.panel1.Controls.Add(this.rbAdminSigin);
            this.panel1.Controls.Add(this.tbConfirmPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbCreatePassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbCreateUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(44, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 365);
            this.panel1.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginButton.Location = new System.Drawing.Point(202, 336);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(64, 25);
            this.loginButton.TabIndex = 16;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Already have an account?";
            // 
            // signinButton
            // 
            this.signinButton.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinButton.Location = new System.Drawing.Point(20, 293);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(255, 41);
            this.signinButton.TabIndex = 14;
            this.signinButton.Text = "Sign In";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
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
            // rbCashierSignin
            // 
            this.rbCashierSignin.AutoSize = true;
            this.rbCashierSignin.Checked = true;
            this.rbCashierSignin.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCashierSignin.Location = new System.Drawing.Point(193, 50);
            this.rbCashierSignin.Name = "rbCashierSignin";
            this.rbCashierSignin.Size = new System.Drawing.Size(69, 21);
            this.rbCashierSignin.TabIndex = 12;
            this.rbCashierSignin.TabStop = true;
            this.rbCashierSignin.Text = "Cashier";
            this.rbCashierSignin.UseVisualStyleBackColor = true;
            // 
            // rbAdminSigin
            // 
            this.rbAdminSigin.AutoSize = true;
            this.rbAdminSigin.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdminSigin.Location = new System.Drawing.Point(193, 33);
            this.rbAdminSigin.Name = "rbAdminSigin";
            this.rbAdminSigin.Size = new System.Drawing.Size(63, 21);
            this.rbAdminSigin.TabIndex = 11;
            this.rbAdminSigin.Text = "Admin";
            this.rbAdminSigin.UseVisualStyleBackColor = true;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(15, 231);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(260, 29);
            this.tbConfirmPassword.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Create an account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirm Password :";
            // 
            // tbCreatePassword
            // 
            this.tbCreatePassword.Location = new System.Drawing.Point(15, 170);
            this.tbCreatePassword.Name = "tbCreatePassword";
            this.tbCreatePassword.Size = new System.Drawing.Size(260, 29);
            this.tbCreatePassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Create Password :";
            // 
            // tbCreateUsername
            // 
            this.tbCreateUsername.Location = new System.Drawing.Point(15, 107);
            this.tbCreateUsername.Name = "tbCreateUsername";
            this.tbCreateUsername.Size = new System.Drawing.Size(260, 29);
            this.tbCreateUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Create Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sign In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(368, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.Location = new System.Drawing.Point(170, 262);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(108, 19);
            this.cbShowPassword.TabIndex = 17;
            this.cbShowPassword.Text = "Show password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // signinPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "signinPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.signinPOS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCreateUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCreatePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbCashierSignin;
        private System.Windows.Forms.RadioButton rbAdminSigin;
        private EventHandler btSignin_Click;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}

