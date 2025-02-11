namespace emlakform
{
    partial class Sorgu
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
            cbSehir = new ComboBox();
            cbSemt = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnListele = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // cbSehir
            // 
            cbSehir.FormattingEnabled = true;
            cbSehir.Location = new Point(143, 76);
            cbSehir.Name = "cbSehir";
            cbSehir.Size = new Size(151, 28);
            cbSehir.TabIndex = 0;
            cbSehir.SelectedIndexChanged += cbSehir_SelectedIndexChanged;
            // 
            // cbSemt
            // 
            cbSemt.FormattingEnabled = true;
            cbSemt.Location = new Point(143, 134);
            cbSemt.Name = "cbSemt";
            cbSemt.Size = new Size(151, 28);
            cbSemt.TabIndex = 1;
            cbSemt.SelectedIndexChanged += cbSemt_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 79);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 2;
            label1.Text = "Şehir:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 137);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Semt:";
            // 
            // btnListele
            // 
            btnListele.Location = new Point(258, 375);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(152, 61);
            btnListele.TabIndex = 8;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(237, 200);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(72, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Kiralık";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(110, 200);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Satılık";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Sorgu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 463);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(btnListele);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSemt);
            Controls.Add(cbSehir);
            Name = "Sorgu";
            Text = "Sorgu";
            Load += Sorgu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSehir;
        private ComboBox cbSemt;
        private Label label1;
        private Label label2;
        private Button btnListele;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}