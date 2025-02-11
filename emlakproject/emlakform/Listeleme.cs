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
    public partial class Listeleme : Form
    {

        public string receivedsecilenSehir;
        public string receivedsecilenSemt;
        

        public Listeleme()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

          public void ReceiveData(string secilenSehir, string secilenSemt)
          {

              receivedsecilenSehir = secilenSehir;
              receivedsecilenSemt=secilenSemt;
              

          }  

        private void Listeleme_Load(object sender, EventArgs e)
        {

            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosyaYolu = "C:\\Users\\ohabulut\\source\\repos\\emlakproject\\emlakform\\satilik.txt";


            

                FileStream fs = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string dosyaoku = sr.ReadLine();

                while (dosyaoku != null)
                {
                    string[] satilikEvler = dosyaoku.Split('-');
                    if (satilikEvler.Length >= 9)
                    {
                        if (satilikEvler[0] == receivedsecilenSehir && satilikEvler[1] == receivedsecilenSemt /*&& satilikEvler[8] == receivedDeger calısmıyo bura*/)
                        {
                            dataGridView1.Rows.Add(
                           satilikEvler[0].Trim(),
                           satilikEvler[1].Trim(),
                           satilikEvler[2].Trim(),
                           satilikEvler[3].Trim(),
                           satilikEvler[4].Trim(),
                           satilikEvler[5].Trim(),
                           satilikEvler[6].Trim(),
                           satilikEvler[7].Trim(),
                           satilikEvler[8].Trim());
                        }
                    }
                    

                    dosyaoku = sr.ReadLine();

                }
            }
            
            
        }
    }
    

