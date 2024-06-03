namespace loginPOS
{
    partial class OrderingSystem
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
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEnterPrices = new System.Windows.Forms.TextBox();
            this.btnEnterPrices = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnterPayment = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.ItemHeight = 21;
            this.lbOrders.Location = new System.Drawing.Point(369, 103);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(173, 256);
            this.lbOrders.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Price :";
            // 
            // tbEnterPrices
            // 
            this.tbEnterPrices.Location = new System.Drawing.Point(34, 98);
            this.tbEnterPrices.Name = "tbEnterPrices";
            this.tbEnterPrices.Size = new System.Drawing.Size(137, 29);
            this.tbEnterPrices.TabIndex = 2;
            // 
            // btnEnterPrices
            // 
            this.btnEnterPrices.Location = new System.Drawing.Point(177, 98);
            this.btnEnterPrices.Name = "btnEnterPrices";
            this.btnEnterPrices.Size = new System.Drawing.Size(95, 30);
            this.btnEnterPrices.TabIndex = 3;
            this.btnEnterPrices.Text = "Enter Price";
            this.btnEnterPrices.UseVisualStyleBackColor = true;
            this.btnEnterPrices.Click += new System.EventHandler(this.btnEnterPrices_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ordering System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(79, 4);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(19, 21);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(79, 5);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(19, 21);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Location = new System.Drawing.Point(16, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 30);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Location = new System.Drawing.Point(16, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 30);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.btnEnterPayment);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(34, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 218);
            this.panel3.TabIndex = 15;
            // 
            // btnEnterPayment
            // 
            this.btnEnterPayment.Location = new System.Drawing.Point(62, 154);
            this.btnEnterPayment.Name = "btnEnterPayment";
            this.btnEnterPayment.Size = new System.Drawing.Size(176, 30);
            this.btnEnterPayment.TabIndex = 17;
            this.btnEnterPayment.Text = "Enter Payment";
            this.btnEnterPayment.UseVisualStyleBackColor = true;
            this.btnEnterPayment.Click += new System.EventHandler(this.btnEnterPayment_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(477, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(95, 30);
            this.logoutButton.TabIndex = 16;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // OrderingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 383);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnterPrices);
            this.Controls.Add(this.tbEnterPrices);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderingSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrderingSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEnterPrices;
        private System.Windows.Forms.Button btnEnterPrices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnterPayment;
        private System.Windows.Forms.Button logoutButton;
    }
}