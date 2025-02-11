using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using emlakclasslib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace emlakform
{
    public partial class Sorgu : Form



    {

        private Dictionary<string, List<string>> sehirSemtleri = new Dictionary<string, List<string>>();


        public Sorgu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        /*private void CheckBoxKontrol()
        {
            // Eğer ikisi de seçilmemişse, "Aktif" checkbox'ını otomatik olarak işaretleyin
            if (!checkBoxAktif.Checked && !checkBoxPasif.Checked)
            {
                checkBoxAktif.Checked = true; // Varsayılan olarak Aktif seçiliyor
            }
        }*/





        private void Sorgu_Load(object sender, EventArgs e)
        {
            

            

           // checkBox1.Checked = true;
           // checkBoxAktif.Checked = true;


            string semt_konumu = "C:\\Users\\ohabulut\\source\\repos\\emlakproject\\emlakform\\semt.txt";

            FileStream fs = new FileStream(semt_konumu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string dosyaoku = sr.ReadLine();


            while (dosyaoku != null)
            {
                string[] sehirSecme = dosyaoku.Split('-');
                string sehir = sehirSecme[0].Trim();
                string semt = sehirSecme[1].Trim();

                if (sehirSemtleri.ContainsKey(sehir))
                {
                    sehirSemtleri[sehir].Add(semt);
                }
                else
                {

                    sehirSemtleri[sehir] = new List<string> { semt };
                }

                dosyaoku = sr.ReadLine();


            }

            foreach (string sehir in sehirSemtleri.Keys)
            {
                cbSehir.Items.Add(sehir);
            }
        }

        private void cbSemt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSemt.Items.Clear();

            string secilenSehir = cbSehir.SelectedItem.ToString();

            if (sehirSemtleri.ContainsKey(secilenSehir))
            {
                cbSemt.Items.AddRange(sehirSemtleri[secilenSehir].ToArray());
                cbSemt.SelectedIndex = 0;
            }
        }

        /*private void checkBoxAktif_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBoxKontrol();
        }

       /* private void checkBoxPasif_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBoxKontrol();
        }*/

        private void checkBoxSatilik_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBoxKiralik_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string secilenSehir = cbSehir.SelectedItem.ToString();
            string secilenSemt = cbSemt.SelectedItem.ToString();

            /*  string deger="0";
              if (checkBoxAktif.Checked)
              {
                  deger = "true";
              } else if (checkBoxPasif.Checked)
              {
                  deger = "false";
              }*/
            //secilenSehir, secilenSemt, deger lsiteleme formuna göderilecek.

            if (checkBox1.Checked)
            {
                Listeleme listeleme = new Listeleme();
                listeleme.ReceiveData(secilenSehir, secilenSemt);
                listeleme.Visible = true;
                this.Visible = false;
            } else
            {
                Listeleme2 listeleme2 = new Listeleme2();
                listeleme2.ReceiveData(secilenSehir, secilenSemt);
                listeleme2.Visible = true;
                this.Visible=false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }
    }
}
