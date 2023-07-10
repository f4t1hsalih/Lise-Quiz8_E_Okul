namespace Quiz8_E_Okul
{
    partial class FormNotDegistirme
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
            this.txtno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1s = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt2s = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt1p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt2p = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(93, 12);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Öğrenci No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Öğrenci Ders:";
            // 
            // cmbders
            // 
            this.cmbders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Items.AddRange(new object[] {
            "Matematik",
            "Türkçe",
            "İngilizce",
            "Beden",
            "Fizik",
            "Kimya",
            "Tarih",
            "Müzik",
            "Bilişim"});
            this.cmbders.Location = new System.Drawing.Point(93, 38);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(100, 21);
            this.cmbders.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "1.Sınav:";
            // 
            // txt1s
            // 
            this.txt1s.Location = new System.Drawing.Point(93, 114);
            this.txt1s.Name = "txt1s";
            this.txt1s.Size = new System.Drawing.Size(100, 20);
            this.txt1s.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "2.Sınav:";
            // 
            // txt2s
            // 
            this.txt2s.Location = new System.Drawing.Point(93, 140);
            this.txt2s.Name = "txt2s";
            this.txt2s.Size = new System.Drawing.Size(100, 20);
            this.txt2s.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "1.Performans:";
            // 
            // txt1p
            // 
            this.txt1p.Location = new System.Drawing.Point(93, 166);
            this.txt1p.Name = "txt1p";
            this.txt1p.Size = new System.Drawing.Size(100, 20);
            this.txt1p.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "2.Performans:";
            // 
            // txt2p
            // 
            this.txt2p.Location = new System.Drawing.Point(93, 192);
            this.txt2p.Name = "txt2p";
            this.txt2p.Size = new System.Drawing.Size(100, 20);
            this.txt2p.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Uygulama";
            // 
            // txtu
            // 
            this.txtu.Location = new System.Drawing.Point(93, 218);
            this.txtu.Name = "txtu";
            this.txtu.Size = new System.Drawing.Size(100, 20);
            this.txtu.TabIndex = 23;
            // 
            // FormNotDegistirme
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(221, 261);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt2p);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt1p);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt2s);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt1s);
            this.Controls.Add(this.cmbders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtno);
            this.MaximizeBox = false;
            this.Name = "FormNotDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Değiştirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2s;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt2p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtu;
    }
}