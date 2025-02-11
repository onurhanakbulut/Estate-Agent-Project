using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlakform
{
    public partial class Listeleme2 : Form
    {


        public string receivedsecilenSehir;
        public string receivedsecilenSemt;


        public Listeleme2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        public void ReceiveData(string secilenSehir, string secilenSemt)
        {

            receivedsecilenSehir = secilenSehir;
            receivedsecilenSemt = secilenSemt;


        }

        private void Listeleme2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            string dosyaYolu = "C:\\Users\\ohabulut\\source\\repos\\emlakproject\\emlakform\\kiralık.txt";




            FileStream fs = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string dosyaoku = sr.ReadLine();

            while (dosyaoku != null)
            {
                string[] kiralikEvler = dosyaoku.Split('-');
                if (kiralikEvler.Length >= 10)
                {
                    if (kiralikEvler[0] == receivedsecilenSehir && kiralikEvler[1] == receivedsecilenSemt /*&& satilikEvler[8] == receivedDeger calısmıyo bura*/)
                    {
                        dataGridView1.Rows.Add(
                       kiralikEvler[0].Trim(),
                       kiralikEvler[1].Trim(),
                       kiralikEvler[2].Trim(),
                       kiralikEvler[3].Trim(),
                       kiralikEvler[4].Trim(),
                       kiralikEvler[5].Trim(),
                       kiralikEvler[6].Trim(),
                       kiralikEvler[7].Trim(),
                       kiralikEvler[8].Trim(),
                       kiralikEvler[9].Trim());
                    }
                }


                dosyaoku = sr.ReadLine();

            }
        }
    }
}
