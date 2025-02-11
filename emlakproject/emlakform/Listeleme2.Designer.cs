namespace emlakform
{
    partial class Listeleme2
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
            label1 = new Label();
            button1 = new Button();
            btnAP = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            sehir = new DataGridViewTextBoxColumn();
            semt = new DataGridViewTextBoxColumn();
            kat = new DataGridViewTextBoxColumn();
            odaSayisi = new DataGridViewTextBoxColumn();
            alan = new DataGridViewTextBoxColumn();
            yas = new DataGridViewTextBoxColumn();
            turu = new DataGridViewTextBoxColumn();
            fiyat = new DataGridViewTextBoxColumn();
            depozito = new DataGridViewTextBoxColumn();
            aktifpasif = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(898, 431);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 11;
            label1.Text = "0-daire ";
            // 
            // button1
            // 
            button1.Location = new Point(306, 469);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "çalıştır";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAP
            // 
            btnAP.Location = new Point(1186, 453);
            btnAP.Name = "btnAP";
            btnAP.Size = new Size(132, 61);
            btnAP.TabIndex = 9;
            btnAP.Text = "Aktif/Pasif";
            btnAP.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(600, 453);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(132, 61);
            btnDuzenle.TabIndex = 8;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(15, 453);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 61);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { sehir, semt, kat, odaSayisi, alan, yas, turu, fiyat, depozito, aktifpasif });
            dataGridView1.Location = new Point(15, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1303, 287);
            dataGridView1.TabIndex = 6;
            // 
            // sehir
            // 
            sehir.HeaderText = "Şehir";
            sehir.MinimumWidth = 6;
            sehir.Name = "sehir";
            sehir.Width = 125;
            // 
            // semt
            // 
            semt.HeaderText = "Semt";
            semt.MinimumWidth = 6;
            semt.Name = "semt";
            semt.Width = 125;
            // 
            // kat
            // 
            kat.HeaderText = "Kat";
            kat.MinimumWidth = 6;
            kat.Name = "kat";
            kat.Width = 125;
            // 
            // odaSayisi
            // 
            odaSayisi.HeaderText = "Oda Sayısı";
            odaSayisi.MinimumWidth = 6;
            odaSayisi.Name = "odaSayisi";
            odaSayisi.Width = 125;
            // 
            // alan
            // 
            alan.HeaderText = "Alan";
            alan.MinimumWidth = 6;
            alan.Name = "alan";
            alan.Width = 125;
            // 
            // yas
            // 
            yas.HeaderText = "Yaş";
            yas.MinimumWidth = 6;
            yas.Name = "yas";
            yas.Width = 125;
            // 
            // turu
            // 
            turu.HeaderText = "Türü";
            turu.MinimumWidth = 6;
            turu.Name = "turu";
            turu.Width = 125;
            // 
            // fiyat
            // 
            fiyat.HeaderText = "Kira";
            fiyat.MinimumWidth = 6;
            fiyat.Name = "fiyat";
            fiyat.Width = 125;
            // 
            // depozito
            // 
            depozito.HeaderText = "Depozito";
            depozito.MinimumWidth = 6;
            depozito.Name = "depozito";
            depozito.Width = 125;
            // 
            // aktifpasif
            // 
            aktifpasif.HeaderText = "Aktif";
            aktifpasif.MinimumWidth = 6;
            aktifpasif.Name = "aktifpasif";
            aktifpasif.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(898, 453);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 12;
            label2.Text = "1-bahçeli";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(898, 473);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 13;
            label3.Text = "2-dubleks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(898, 493);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 14;
            label4.Text = "3-müstakil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 29);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 15;
            label5.Text = "KİRALIK EVLER";
            // 
            // Listeleme2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 543);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnAP);
            Controls.Add(btnDuzenle);
            Controls.Add(btnSil);
            Controls.Add(dataGridView1);
            Name = "Listeleme2";
            Text = "Listeleme2";
            Load += Listeleme2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnAP;
        private Button btnDuzenle;
        private Button btnSil;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn sehir;
        private DataGridViewTextBoxColumn semt;
        private DataGridViewTextBoxColumn kat;
        private DataGridViewTextBoxColumn odaSayisi;
        private DataGridViewTextBoxColumn alan;
        private DataGridViewTextBoxColumn yas;
        private DataGridViewTextBoxColumn turu;
        private DataGridViewTextBoxColumn fiyat;
        private DataGridViewTextBoxColumn depozito;
        private DataGridViewTextBoxColumn aktifpasif;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}