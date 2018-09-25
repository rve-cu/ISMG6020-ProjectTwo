namespace NeptuneCalculator
{
    partial class frmYTDCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYTDCalc));
            this.btnCalcYTD = new System.Windows.Forms.Button();
            this.btnExitYTD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYTDPmt = new System.Windows.Forms.TextBox();
            this.txtYTDIntRate = new System.Windows.Forms.TextBox();
            this.txtYTDNoPmts = new System.Windows.Forms.TextBox();
            this.txtYTDTotlPd = new System.Windows.Forms.TextBox();
            this.txtYTDTotlIntPd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYTDTotlPrinPd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcYTD
            // 
            this.btnCalcYTD.Location = new System.Drawing.Point(150, 230);
            this.btnCalcYTD.Name = "btnCalcYTD";
            this.btnCalcYTD.Size = new System.Drawing.Size(117, 34);
            this.btnCalcYTD.TabIndex = 4;
            this.btnCalcYTD.Text = "&Calculate";
            this.btnCalcYTD.UseVisualStyleBackColor = true;
            this.btnCalcYTD.Click += new System.EventHandler(this.btnCalcARM_Click);
            // 
            // btnExitYTD
            // 
            this.btnExitYTD.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitYTD.Location = new System.Drawing.Point(367, 230);
            this.btnExitYTD.Name = "btnExitYTD";
            this.btnExitYTD.Size = new System.Drawing.Size(123, 34);
            this.btnExitYTD.TabIndex = 5;
            this.btnExitYTD.Text = "Go &Back";
            this.btnExitYTD.UseVisualStyleBackColor = true;
            this.btnExitYTD.Click += new System.EventHandler(this.btnExitARMCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Monthly Payment:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interest Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Payments:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(314, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Amount Paid:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(314, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Interest Paid:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtYTDPmt
            // 
            this.txtYTDPmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDPmt.Location = new System.Drawing.Point(193, 102);
            this.txtYTDPmt.Name = "txtYTDPmt";
            this.txtYTDPmt.Size = new System.Drawing.Size(100, 21);
            this.txtYTDPmt.TabIndex = 1;
            this.txtYTDPmt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtYTDIntRate
            // 
            this.txtYTDIntRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDIntRate.Location = new System.Drawing.Point(193, 135);
            this.txtYTDIntRate.Name = "txtYTDIntRate";
            this.txtYTDIntRate.Size = new System.Drawing.Size(100, 21);
            this.txtYTDIntRate.TabIndex = 2;
            // 
            // txtYTDNoPmts
            // 
            this.txtYTDNoPmts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDNoPmts.Location = new System.Drawing.Point(193, 169);
            this.txtYTDNoPmts.Name = "txtYTDNoPmts";
            this.txtYTDNoPmts.Size = new System.Drawing.Size(100, 21);
            this.txtYTDNoPmts.TabIndex = 3;
            // 
            // txtYTDTotlPd
            // 
            this.txtYTDTotlPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDTotlPd.Location = new System.Drawing.Point(473, 102);
            this.txtYTDTotlPd.Name = "txtYTDTotlPd";
            this.txtYTDTotlPd.ReadOnly = true;
            this.txtYTDTotlPd.Size = new System.Drawing.Size(100, 21);
            this.txtYTDTotlPd.TabIndex = 10;
            this.txtYTDTotlPd.TabStop = false;
            this.txtYTDTotlPd.TextChanged += new System.EventHandler(this.txtYTDTotlPd_TextChanged);
            // 
            // txtYTDTotlIntPd
            // 
            this.txtYTDTotlIntPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDTotlIntPd.Location = new System.Drawing.Point(473, 135);
            this.txtYTDTotlIntPd.Name = "txtYTDTotlIntPd";
            this.txtYTDTotlIntPd.ReadOnly = true;
            this.txtYTDTotlIntPd.Size = new System.Drawing.Size(100, 21);
            this.txtYTDTotlIntPd.TabIndex = 11;
            this.txtYTDTotlIntPd.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(314, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Principal Paid:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtYTDTotlPrinPd
            // 
            this.txtYTDTotlPrinPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYTDTotlPrinPd.Location = new System.Drawing.Point(473, 169);
            this.txtYTDTotlPrinPd.Name = "txtYTDTotlPrinPd";
            this.txtYTDTotlPrinPd.ReadOnly = true;
            this.txtYTDTotlPrinPd.Size = new System.Drawing.Size(100, 21);
            this.txtYTDTotlPrinPd.TabIndex = 0;
            this.txtYTDTotlPrinPd.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(156, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Year-To-Date Analysis Calculation";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Completed by: Allie Newell";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmYTDCalc
            // 
            this.AcceptButton = this.btnCalcYTD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExitYTD;
            this.ClientSize = new System.Drawing.Size(613, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYTDTotlPrinPd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYTDTotlIntPd);
            this.Controls.Add(this.txtYTDTotlPd);
            this.Controls.Add(this.txtYTDNoPmts);
            this.Controls.Add(this.txtYTDIntRate);
            this.Controls.Add(this.txtYTDPmt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExitYTD);
            this.Controls.Add(this.btnCalcYTD);
            this.Name = "frmYTDCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Year-To-Date Payment Calculator";
            this.Load += new System.EventHandler(this.frmARMCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcYTD;
        private System.Windows.Forms.Button btnExitYTD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYTDPmt;
        private System.Windows.Forms.TextBox txtYTDIntRate;
        private System.Windows.Forms.TextBox txtYTDNoPmts;
        private System.Windows.Forms.TextBox txtYTDTotlPd;
        private System.Windows.Forms.TextBox txtYTDTotlIntPd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYTDTotlPrinPd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}