namespace NeptuneCalculator
{
    partial class frmTotalInterest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalInterest));
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPaymentAmt = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIntCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.GhostWhite;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Location = new System.Drawing.Point(369, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Go &Back";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtPaymentAmt
            // 
            this.txtPaymentAmt.Location = new System.Drawing.Point(341, 84);
            this.txtPaymentAmt.Name = "txtPaymentAmt";
            this.txtPaymentAmt.Size = new System.Drawing.Size(89, 20);
            this.txtPaymentAmt.TabIndex = 1;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(341, 154);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(89, 20);
            this.txtPrincipal.TabIndex = 3;
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalInterest.Location = new System.Drawing.Point(341, 189);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.ReadOnly = true;
            this.txtTotalInterest.Size = new System.Drawing.Size(89, 20);
            this.txtTotalInterest.TabIndex = 4;
            this.txtTotalInterest.TabStop = false;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(341, 119);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(89, 20);
            this.txtLength.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Payment Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnIntCalc
            // 
            this.btnIntCalc.BackColor = System.Drawing.Color.GhostWhite;
            this.btnIntCalc.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntCalc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIntCalc.Location = new System.Drawing.Point(196, 246);
            this.btnIntCalc.Name = "btnIntCalc";
            this.btnIntCalc.Size = new System.Drawing.Size(109, 33);
            this.btnIntCalc.TabIndex = 5;
            this.btnIntCalc.Text = "&Calculate";
            this.btnIntCalc.UseVisualStyleBackColor = false;
            this.btnIntCalc.Click += new System.EventHandler(this.btnIntCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Length of Loan (Months):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mortgage Principal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(171, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Interest:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(192, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Interest Paid Calculation";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmTotalInterest
            // 
            this.AcceptButton = this.btnIntCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(609, 319);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIntCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtTotalInterest);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.txtPaymentAmt);
            this.Controls.Add(this.btnExit);
            this.Name = "frmTotalInterest";
            this.Text = "Total Interest Calculator ";
            this.Load += new System.EventHandler(this.frmTotalInterest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPaymentAmt;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIntCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}