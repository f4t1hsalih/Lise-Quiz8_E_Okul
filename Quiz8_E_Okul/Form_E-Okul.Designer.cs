namespace Quiz8_E_Okul
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
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1s = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2s = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1p = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt2p = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtvsoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtvad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(243, 147);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(106, 49);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DersAdi:";
            // 
            // txt1s
            // 
            this.txt1s.Location = new System.Drawing.Point(86, 40);
            this.txt1s.Name = "txt1s";
            this.txt1s.Size = new System.Drawing.Size(100, 20);
            this.txt1s.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1.Sınav:";
            // 
            // txt2s
            // 
            this.txt2s.Location = new System.Drawing.Point(86, 66);
            this.txt2s.Name = "txt2s";
            this.txt2s.Size = new System.Drawing.Size(100, 20);
            this.txt2s.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2.Sınav:";
            // 
            // txt1p
            // 
            this.txt1p.Location = new System.Drawing.Point(86, 92);
            this.txt1p.Name = "txt1p";
            this.txt1p.Size = new System.Drawing.Size(100, 20);
            this.txt1p.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "1.Performans:";
            // 
            // txt2p
            // 
            this.txt2p.Location = new System.Drawing.Point(86, 118);
            this.txt2p.Name = "txt2p";
            this.txt2p.Size = new System.Drawing.Size(100, 20);
            this.txt2p.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "2.Performans:";
            // 
            // txtu
            // 
            this.txtu.Location = new System.Drawing.Point(86, 144);
            this.txtu.Name = "txtu";
            this.txtu.Size = new System.Drawing.Size(100, 20);
            this.txtu.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Uygulama";
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
            this.cmbders.Location = new System.Drawing.Point(86, 9);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(100, 21);
            this.cmbders.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Öğrenci Not Güncelleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(290, 66);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Öğrenci No:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(290, 40);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Öğrenci Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(290, 14);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Öğrenci Ad:";
            // 
            // txtvsoyad
            // 
            this.txtvsoyad.Location = new System.Drawing.Point(290, 118);
            this.txtvsoyad.Name = "txtvsoyad";
            this.txtvsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtvsoyad.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Veli Soyad:";
            // 
            // txtvad
            // 
            this.txtvad.Location = new System.Drawing.Point(290, 92);
            this.txtvad.Name = "txtvad";
            this.txtvad.Size = new System.Drawing.Size(100, 20);
            this.txtvad.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Veli Ad:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnkaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(404, 224);
            this.Controls.Add(this.txtvsoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtvad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbders);
            this.Controls.Add(this.txtu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt2p);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt1p);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt2s);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt1s);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-okul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt2s;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1p;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtvsoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtvad;
        private System.Windows.Forms.Label label11;
    }
}

