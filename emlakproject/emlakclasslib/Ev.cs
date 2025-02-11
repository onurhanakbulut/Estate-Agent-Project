using emlakclasslib;
using System.Xml;

namespace emlakclasslib
{
    public class Ev
    {

        public static List<Ev> evler = new List<Ev>(1000);
        private void LogKatNo(int deger, bool isNegative)
        {

            string logYaz;
            if (isNegative)
            {
                logYaz = $"Negatif Kat Sayısı Denemesi: {deger} - Tarih: {DateTime.Now}\n";
            }
            else
            {
                logYaz = $"Pozitif Kat Sayısı Atandı: {deger} - Tarih: {DateTime.Now}\n";
            }

            string logDosyasi = "C:\\Users\\ohabulut\\source\\repos\\emlakproject\\emlakclasslib\\log.txt";


            File.AppendAllText(logDosyasi, logYaz);
        }

        private void LogAlan(double deger, bool isNegative)
        {

            string logYaz;
            if (isNegative)
            {
                logYaz = $"Negatif Alan Denemesi: {deger} - Tarih: {DateTime.Now}\n";
            }
            else
            {
                logYaz = $"Pozitif Alan Atandı: {deger} - Tarih: {DateTime.Now}\n";
            }

            string logDosyasi = "C:\\Users\\ohabulut\\source\\repos\\emlakproject\\emlakclasslib\\log.txt";


            File.AppendAllText(logDosyasi, logYaz);
        }

        

        //OdaSayisi, KatNumarasi, Semti, Alani, YapimTarihi, Turu, Aktif, EmlakNumarasi

        public string odaSayisi { get; set; }
        public int katNumarasi { get; set; }
        public string sehir { get; set; }
        public string semt { get; set; }
        public double alan { get; set; }
        
        public int yapimTarihi { get; set; }
        
        public int turSayisi { get; set; }
        public bool aktif { get; set; }
        public int emlakNumarasi { get; set; }

        

        public enum Turu
        {
            Daire, Bahçeli, Dubleks, Müstakil
        }



        public Ev(
            string odaSayisi = "yok",
            int katNumarasi = 0,
            string sehir = "belirtilmemiş",
            string semt = "belirtilmemiş",
            double alan = 0,
            int yapimTarihi = 0,
            int turSayisi = 0,
            bool aktif = true,
            int emlakNumarasi = 1
            
            

            )
        {

            this.odaSayisi = odaSayisi;
            if (katNumarasi > 0)
            {
                this.katNumarasi = katNumarasi;

                LogKatNo(katNumarasi, isNegative: false); // Pozitif loglama işlemi
            }
            else
            {
                this.katNumarasi = 0;
                LogKatNo(katNumarasi, isNegative: true); // Negatif loglama işlemi
            }
            this.sehir = sehir;
            this.semt = semt;
            if (alan > 0)
            {
                this.alan = alan;
                LogAlan(alan, isNegative: false); // Pozitif loglama işlemi
            }
            else
            {
                this.alan = 0;
                LogAlan(alan, isNegative: true); // Negatif loglama işlemi
            }

            

            this.turSayisi = turSayisi;
            this.aktif = aktif;
            this.emlakNumarasi = emlakNumarasi;
            this.yapimTarihi=yapimTarihi;



            /* int gunumuz = DateTime.Now.Year;
            int binaYasi = gunumuz - yapimTarihi;*/


           

        }


        virtual public string EvBilgileri()
        {
            return string.Format(
                "Emlak Numarası: {0}\nŞehir: {1}\nSemt: {2}\nOda Sayısı: {3}\nKat Numarası: {4}\nAlan: {5} m²\nyapimTarihi: {6}\nTür Sayısı: {7}\nAktif: {8}",

                emlakNumarasi,
                sehir,
                semt,
                odaSayisi,
                katNumarasi,
                alan,
                yapimTarihi,
                turSayisi,
                aktif ? "Evet" : "Hayır"
            );
        }




    }

    ///
    public class KiralikEv : Ev
    {
        public decimal depozito { get; set; }
        public decimal kira { get; set; }

        public KiralikEv(string odaSayisi, int katNumarasi, string sehir, string semt,
            double alan, int yapimTarihi, int turSayisi, bool aktif, int emlakNumarasi, decimal depozito = 0, decimal kira = 0) : base(odaSayisi, katNumarasi, sehir, semt, alan, yapimTarihi, turSayisi, aktif, emlakNumarasi)
        {
            if (kira > 0)
            {
                this.kira = kira;
            }
            else
            {
                this.kira = 0;
            }

            if (depozito > 0)
            {
                this.depozito = depozito;
            }
            else
            {
                this.depozito = 0;
            }
        }

        public override string EvBilgileri()
        {
            return base.EvBilgileri() + string.Format("\nKira: {0}\nDepozito: {1}", kira, depozito);        //override ettik virtual evbilgilerini
        }


    }
    public class SatilikEv : Ev
    {
        public decimal fiyat { get; set; }

        public SatilikEv(string odaSayisi, int katNumarasi, string sehir, string semt,
        double alan, int yapimTarihi, int turSayisi, bool aktif, int emlakNumarasi,  decimal fiyat = 0) : base(odaSayisi, katNumarasi, sehir, semt, alan, yapimTarihi, turSayisi, aktif, emlakNumarasi)
        {
            if (fiyat > 0)
            {
                this.fiyat = fiyat;
            }
            else
            {
                this.fiyat = 0;
            }


           

        }


        public override string EvBilgileri()
        {
            return base.EvBilgileri() + string.Format("\nFiyat: {0}", fiyat);
        }




    }
}
