namespace loginPOS
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.ListBox();
            this.lbChange = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbOrderNo = new System.Windows.Forms.ListBox();
            this.lbQuantity = new System.Windows.Forms.ListBox();
            this.lbAmount = new System.Windows.Forms.ListBox();
            this.lbVAT = new System.Windows.Forms.ListBox();
            this.lbTotalDiscount = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 435);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(54, 139);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administrator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transaction History";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(50, 397);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(95, 30);
            this.logoutButton.TabIndex = 17;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Order No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "VAT :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total Discount :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Quantity :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(726, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Total :";
            // 
            // lbTotal
            // 
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.FormattingEnabled = true;
            this.lbTotal.ItemHeight = 21;
            this.lbTotal.Location = new System.Drawing.Point(698, 111);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotal.Size = new System.Drawing.Size(96, 296);
            this.lbTotal.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(805, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Payment :";
            // 
            // lbPayment
            // 
            this.lbPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPayment.FormattingEnabled = true;
            this.lbPayment.ItemHeight = 21;
            this.lbPayment.Location = new System.Drawing.Point(793, 111);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPayment.Size = new System.Drawing.Size(96, 296);
            this.lbPayment.TabIndex = 31;
            // 
            // lbChange
            // 
            this.lbChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChange.FormattingEnabled = true;
            this.lbChange.ItemHeight = 21;
            this.lbChange.Location = new System.Drawing.Point(887, 111);
            this.lbChange.Name = "lbChange";
            this.lbChange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbChange.Size = new System.Drawing.Size(96, 296);
            this.lbChange.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(904, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "Change :";
            // 
            // lbOrderNo
            // 
            this.lbOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOrderNo.FormattingEnabled = true;
            this.lbOrderNo.ItemHeight = 21;
            this.lbOrderNo.Location = new System.Drawing.Point(223, 111);
            this.lbOrderNo.Name = "lbOrderNo";
            this.lbOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbOrderNo.Size = new System.Drawing.Size(96, 296);
            this.lbOrderNo.TabIndex = 34;
            // 
            // lbQuantity
            // 
            this.lbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQuantity.FormattingEnabled = true;
            this.lbQuantity.ItemHeight = 21;
            this.lbQuantity.Location = new System.Drawing.Point(318, 111);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbQuantity.Size = new System.Drawing.Size(96, 296);
            this.lbQuantity.TabIndex = 35;
            // 
            // lbAmount
            // 
            this.lbAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAmount.FormattingEnabled = true;
            this.lbAmount.ItemHeight = 21;
            this.lbAmount.Location = new System.Drawing.Point(413, 111);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbAmount.Size = new System.Drawing.Size(96, 296);
            this.lbAmount.TabIndex = 36;
            // 
            // lbVAT
            // 
            this.lbVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbVAT.FormattingEnabled = true;
            this.lbVAT.ItemHeight = 21;
            this.lbVAT.Location = new System.Drawing.Point(508, 111);
            this.lbVAT.Name = "lbVAT";
            this.lbVAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbVAT.Size = new System.Drawing.Size(96, 296);
            this.lbVAT.TabIndex = 37;
            // 
            // lbTotalDiscount
            // 
            this.lbTotalDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotalDiscount.FormattingEnabled = true;
            this.lbTotalDiscount.ItemHeight = 21;
            this.lbTotalDiscount.Location = new System.Drawing.Point(603, 111);
            this.lbTotalDiscount.Name = "lbTotalDiscount";
            this.lbTotalDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotalDiscount.Size = new System.Drawing.Size(96, 296);
            this.lbTotalDiscount.TabIndex = 38;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 435);
            this.Controls.Add(this.lbTotalDiscount);
            this.Controls.Add(this.lbVAT);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbOrderNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.lbPayment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbPayment;
        private System.Windows.Forms.ListBox lbChange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbOrderNo;
        private System.Windows.Forms.ListBox lbQuantity;
        private System.Windows.Forms.ListBox lbAmount;
        private System.Windows.Forms.ListBox lbVAT;
        private System.Windows.Forms.ListBox lbTotalDiscount;
    }
}