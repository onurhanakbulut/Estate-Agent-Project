using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using emlakclasslib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;




namespace emlakform
{
    public partial class Kayıt : Form
    {

        private Dictionary<string, List<string>> sehirSemtleri = new Dictionary<string, List<string>>();

        public Kayıt()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void Kayıt_Load(object sender, EventArgs e)
        {
            //  dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //  dateTimePicker1.CustomFormat = "yyyy";

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

            string[] odaSayisi = { "1+0", "1+1", "2+1", "3+1", "3+2", "4+1" };
            cbOdaSayisi.Items.AddRange(odaSayisi);


            label1.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            textFiyat.Visible = false;
            textDepozito.Visible = false;
            textKira.Visible = false;

            cbEvTur.DataSource = Enum.GetValues(typeof(Ev.Turu));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbSemt.Items.Clear();

            string secilenSehir = cbSehir.SelectedItem.ToString();

            if (sehirSemtleri.ContainsKey(secilenSehir))
            {
                cbSemt.Items.AddRange(sehirSemtleri[secilenSehir].ToArray());
                cbSemt.SelectedIndex = 0;
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSatilik.Checked)
            {
                checkBoxKiralık.Checked = false;
                label11.Visible = false;
                label10.Visible = false;
                textKira.Visible = false;
                textDepozito.Visible = false;
                label1.Visible = true;
                textFiyat.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKiralık.Checked)
            {
                checkBoxSatilik.Checked = false;
                label1.Visible = false;
                textFiyat.Visible = false;
                textDepozito.Visible = true;
                textKira.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxSatilik.Checked)
            {
                SatilikEv satilikEv = new SatilikEv
                    (
                    cbOdaSayisi.Text,
                    int.Parse(textKatSayisi.Text),
                    cbSehir.Text,
                    cbSemt.Text,
                    int.Parse(textAlan.Text),
                    int.Parse(textYapimTarihi.Text),
                    cbEvTur.Items.IndexOf(cbEvTur.SelectedItem),
                    true,
                    1,
                    int.Parse(textFiyat.Text)
                    );
                Ev.evler.Add(satilikEv);
                string dosyaYolu = "C:\\Users\\ohabulut\\source\\repos\\emlakproject\\emlakform\\satilik.txt";

                if (!File.Exists(dosyaYolu))
                {
                    File.Create(dosyaYolu);
                }


                int binaYasi = DateTime.Now.Year - satilikEv.yapimTarihi;

                FileStream fs = new FileStream(dosyaYolu, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(
                satilikEv.sehir + "-" +
                satilikEv.semt + "-" +
                satilikEv.katNumarasi + "-" +
                satilikEv.odaSayisi + "-" +
                satilikEv.alan + "-" +
                binaYasi + "-" +
                satilikEv.turSayisi + "-" +
                satilikEv.fiyat + "-" +
                satilikEv.aktif
            );//yapimtarihini aldık eğer bunu günümüz dtsini inte çevirirsek sonuç olarak binayaşı çıkar

                sw.Close();
                fs.Close();

                MessageBox.Show("Satılık ev eklendi");

            }
            else
            {
                KiralikEv kiralikEv = new KiralikEv(
                     cbOdaSayisi.Text,
                    int.Parse(textKatSayisi.Text),
                    cbSehir.Text,
                    cbSemt.Text,
                    int.Parse(textAlan.Text),
                    int.Parse(textYapimTarihi.Text),
                    cbEvTur.Items.IndexOf(cbEvTur.SelectedItem),
                    true,
                    1,
                    int.Parse(textDepozito.Text),
                    int.Parse(textKira.Text)
                    );
                Ev.evler.Add(kiralikEv);
                string dosyaYolu = "C:\\Users\\ohabulut\\source\\repos\\emlakproject\\emlakform\\kiralık.txt";
                if (!File.Exists(dosyaYolu))
                {
                    File.Create(dosyaYolu);
                }

                int binaYasi = DateTime.Now.Year - kiralikEv.yapimTarihi;

                FileStream fs = new FileStream(dosyaYolu, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(
                kiralikEv.sehir + "-" +
                kiralikEv.semt + "-" +
                kiralikEv.katNumarasi + "-" +
                kiralikEv.odaSayisi + "-" +
                kiralikEv.alan + "-" +
                binaYasi + "-" +
                kiralikEv.turSayisi + "-" +
                kiralikEv.kira + "-" +
                kiralikEv.depozito + "-" +
                kiralikEv.aktif
           );
                sw.Close();
                fs.Close();

                MessageBox.Show("Kiralık ev eklendi");

            }


            /* cbSehir.SelectedIndex = -1;
             cbSemt.SelectedIndex = -1;
             cbOdaSayisi.SelectedIndex = -1;
             cbEvTur.SelectedIndex = -1;
             textAlan.Text = "";
             textKatSayisi.Text = "";
             textYapimTarihi.Text = "";
             textFiyat.Text = "";
             textKira.Text = "";
             textDepozito.Text = "";
             checkBoxSatilik.Checked = false;
             checkBoxKiralık.Checked = false;*/


            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbOdaSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
