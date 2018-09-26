namespace kalkulator
{
    partial class kalkulator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nilai1 = new System.Windows.Forms.TextBox();
            this.nilai2 = new System.Windows.Forms.TextBox();
            this.cmboperasi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lsthasil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operasi";
            // 
            // nilai1
            // 
            this.nilai1.Location = new System.Drawing.Point(114, 103);
            this.nilai1.Name = "nilai1";
            this.nilai1.Size = new System.Drawing.Size(100, 20);
            this.nilai1.TabIndex = 4;
            this.nilai1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nilai2
            // 
            this.nilai2.Location = new System.Drawing.Point(114, 150);
            this.nilai2.Name = "nilai2";
            this.nilai2.Size = new System.Drawing.Size(100, 20);
            this.nilai2.TabIndex = 5;
            this.nilai2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmboperasi
            // 
            this.cmboperasi.FormattingEnabled = true;
            this.cmboperasi.Items.AddRange(new object[] {
            "Tambah",
            "Kurang",
            "Kali",
            "Bagi"});
            this.cmboperasi.Location = new System.Drawing.Point(114, 200);
            this.cmboperasi.Name = "cmboperasi";
            this.cmboperasi.Size = new System.Drawing.Size(121, 21);
            this.cmboperasi.TabIndex = 7;
            this.cmboperasi.Text = "pilih operasi";
            this.cmboperasi.UseWaitCursor = true;
            this.cmboperasi.SelectedIndexChanged += new System.EventHandler(this.btnHitung_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHitung_click);
            // 
            // lsthasil
            // 
            this.lsthasil.Location = new System.Drawing.Point(114, 245);
            this.lsthasil.Name = "lsthasil";
            this.lsthasil.Size = new System.Drawing.Size(100, 20);
            this.lsthasil.TabIndex = 9;
            this.lsthasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "KALKULATOR";
            // 
            // kalkulator
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(350, 305);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsthasil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmboperasi);
            this.Controls.Add(this.nilai2);
            this.Controls.Add(this.nilai1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kalkulator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nilai1;
        private System.Windows.Forms.TextBox nilai2;
        private System.Windows.Forms.ComboBox cmboperasi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lsthasil;
        private System.Windows.Forms.Label label5;
    }
}

