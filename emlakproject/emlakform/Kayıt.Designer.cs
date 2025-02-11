namespace emlakform
{
    partial class Kayıt
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
            cbSemt = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textAlan = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textKatSayisi = new TextBox();
            cbEvTur = new ComboBox();
            button1 = new Button();
            cbSehir = new ComboBox();
            checkBoxSatilik = new CheckBox();
            checkBoxKiralık = new CheckBox();
            cbOdaSayisi = new ComboBox();
            label1 = new Label();
            textFiyat = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textKira = new TextBox();
            textDepozito = new TextBox();
            textYapimTarihi = new TextBox();
            SuspendLayout();
            // 
            // cbSemt
            // 
            cbSemt.FormattingEnabled = true;
            cbSemt.Location = new Point(152, 92);
            cbSemt.Name = "cbSemt";
            cbSemt.Size = new Size(151, 28);
            cbSemt.TabIndex = 1;
            cbSemt.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 43);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Şehir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 95);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 3;
            label3.Text = "Semt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 144);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 5;
            label4.Text = "Satış durumu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 208);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 6;
            label5.Text = "Net Alan (m2)";
            // 
            // textAlan
            // 
            textAlan.Location = new Point(152, 205);
            textAlan.Name = "textAlan";
            textAlan.Size = new Size(151, 27);
            textAlan.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 265);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 8;
            label6.Text = "Oda Sayısı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 313);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 9;
            label7.Text = "Kat Sayısı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 364);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 10;
            label8.Text = "Yapım Tarihi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 411);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 11;
            label9.Text = "Evin Türü";
            // 
            // textKatSayisi
            // 
            textKatSayisi.Location = new Point(152, 310);
            textKatSayisi.Name = "textKatSayisi";
            textKatSayisi.Size = new Size(151, 27);
            textKatSayisi.TabIndex = 13;
            // 
            // cbEvTur
            // 
            cbEvTur.FormattingEnabled = true;
            cbEvTur.Location = new Point(152, 408);
            cbEvTur.Name = "cbEvTur";
            cbEvTur.Size = new Size(151, 28);
            cbEvTur.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(561, 359);
            button1.Name = "button1";
            button1.Size = new Size(139, 52);
            button1.TabIndex = 16;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbSehir
            // 
            cbSehir.Location = new Point(152, 40);
            cbSehir.Name = "cbSehir";
            cbSehir.Size = new Size(151, 28);
            cbSehir.TabIndex = 17;
            cbSehir.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBoxSatilik
            // 
            checkBoxSatilik.AutoSize = true;
            checkBoxSatilik.Location = new Point(152, 143);
            checkBoxSatilik.Name = "checkBoxSatilik";
            checkBoxSatilik.Size = new Size(69, 24);
            checkBoxSatilik.TabIndex = 18;
            checkBoxSatilik.Text = "satılık";
            checkBoxSatilik.UseVisualStyleBackColor = true;
            checkBoxSatilik.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBoxKiralık
            // 
            checkBoxKiralık.AutoSize = true;
            checkBoxKiralık.Location = new Point(233, 143);
            checkBoxKiralık.Name = "checkBoxKiralık";
            checkBoxKiralık.Size = new Size(70, 24);
            checkBoxKiralık.TabIndex = 19;
            checkBoxKiralık.Text = "kiralık";
            checkBoxKiralık.UseVisualStyleBackColor = true;
            checkBoxKiralık.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // cbOdaSayisi
            // 
            cbOdaSayisi.FormattingEnabled = true;
            cbOdaSayisi.Location = new Point(152, 262);
            cbOdaSayisi.Name = "cbOdaSayisi";
            cbOdaSayisi.Size = new Size(151, 28);
            cbOdaSayisi.TabIndex = 20;
            cbOdaSayisi.SelectedIndexChanged += cbOdaSayisi_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 43);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 21;
            label1.Text = "Fiyat:";
            // 
            // textFiyat
            // 
            textFiyat.Location = new Point(561, 40);
            textFiyat.Name = "textFiyat";
            textFiyat.Size = new Size(125, 27);
            textFiyat.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(481, 226);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 23;
            label10.Text = "Depozito:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(481, 160);
            label11.Name = "label11";
            label11.Size = new Size(38, 20);
            label11.TabIndex = 24;
            label11.Text = "Kira:";
            label11.Click += label11_Click;
            // 
            // textKira
            // 
            textKira.Location = new Point(561, 153);
            textKira.Name = "textKira";
            textKira.Size = new Size(125, 27);
            textKira.TabIndex = 25;
            // 
            // textDepozito
            // 
            textDepozito.Location = new Point(561, 223);
            textDepozito.Name = "textDepozito";
            textDepozito.Size = new Size(125, 27);
            textDepozito.TabIndex = 26;
            // 
            // textYapimTarihi
            // 
            textYapimTarihi.Location = new Point(152, 361);
            textYapimTarihi.Name = "textYapimTarihi";
            textYapimTarihi.Size = new Size(151, 27);
            textYapimTarihi.TabIndex = 27;
            // 
            // Kayıt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textYapimTarihi);
            Controls.Add(textDepozito);
            Controls.Add(textKira);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textFiyat);
            Controls.Add(label1);
            Controls.Add(cbOdaSayisi);
            Controls.Add(checkBoxKiralık);
            Controls.Add(checkBoxSatilik);
            Controls.Add(button1);
            Controls.Add(cbEvTur);
            Controls.Add(textKatSayisi);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textAlan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbSemt);
            Controls.Add(cbSehir);
            Name = "Kayıt";
            Text = "Kayıt";
            Load += Kayıt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbSemt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textAlan;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textKatSayisi;
        private ComboBox cbEvTur;
        private Button button1;
        private ComboBox cbSehir;
        private CheckBox checkBoxSatilik;
        private CheckBox checkBoxKiralık;
        private ComboBox cbOdaSayisi;
        private Label label1;
        private TextBox textFiyat;
        private Label label10;
        private Label label11;
        private TextBox textKira;
        private TextBox textDepozito;
        private TextBox textYapimTarihi;
    }
}