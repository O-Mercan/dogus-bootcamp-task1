namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOdemeTipi = new System.Windows.Forms.Label();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOdemeTipi
            // 
            this.lblOdemeTipi.AutoSize = true;
            this.lblOdemeTipi.Location = new System.Drawing.Point(12, 15);
            this.lblOdemeTipi.Name = "lblOdemeTipi";
            this.lblOdemeTipi.Size = new System.Drawing.Size(70, 15);
            this.lblOdemeTipi.TabIndex = 0;
            this.lblOdemeTipi.Text = "Ödeme Tipi:";
            // 
            // cmbOdemeTipi
            // 
            this.cmbOdemeTipi.FormattingEnabled = true;
            this.cmbOdemeTipi.Location = new System.Drawing.Point(88, 12);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(121, 23);
            this.cmbOdemeTipi.TabIndex = 1;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(12, 44);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 15);
            this.lblTutar.TabIndex = 2;
            this.lblTutar.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(88, 41);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(121, 23);
            this.txtTutar.TabIndex = 3;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(88, 70);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(121, 23);
            this.btnOdemeYap.TabIndex = 4;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(12, 100);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(42, 15);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 131);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.cmbOdemeTipi);
            this.Controls.Add(this.lblOdemeTipi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdemeTipi;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label lblSonuc;
    }
}
