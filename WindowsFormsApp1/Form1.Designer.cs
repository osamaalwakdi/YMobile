namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.LbcustomerName = new System.Windows.Forms.Label();
            this.lbLastBalancee = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(709, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الموبايل";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Location = new System.Drawing.Point(505, 45);
            this.txtMobileNo.Multiline = true;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(198, 39);
            this.txtMobileNo.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(369, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LbcustomerName
            // 
            this.LbcustomerName.BackColor = System.Drawing.Color.White;
            this.LbcustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbcustomerName.Location = new System.Drawing.Point(26, 45);
            this.LbcustomerName.Name = "LbcustomerName";
            this.LbcustomerName.Size = new System.Drawing.Size(209, 39);
            this.LbcustomerName.TabIndex = 4;
            // 
            // lbLastBalancee
            // 
            this.lbLastBalancee.BackColor = System.Drawing.Color.White;
            this.lbLastBalancee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLastBalancee.Location = new System.Drawing.Point(26, 143);
            this.lbLastBalancee.Name = "lbLastBalancee";
            this.lbLastBalancee.Size = new System.Drawing.Size(209, 41);
            this.lbLastBalancee.TabIndex = 4;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnPay.Location = new System.Drawing.Point(369, 145);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(117, 39);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "تسديد";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Location = new System.Drawing.Point(505, 145);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(198, 39);
            this.txtBalance.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "مبلغ السداد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(853, 242);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLastBalancee);
            this.Controls.Add(this.LbcustomerName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label LbcustomerName;
        private System.Windows.Forms.Label lbLastBalancee;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label2;
    }
}

