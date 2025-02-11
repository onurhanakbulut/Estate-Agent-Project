using Microsoft.VisualBasic.ApplicationServices;

namespace emlakform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\ohabulut\\source\\repos\\emlakproject\\emlakform\\users.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();


            string usernameInput = textBox1.Text;
            string passwordInput = textBox2.Text;

            string[] idpass = yazi.Split('-');

            if (idpass[0] == usernameInput && idpass[1] == passwordInput)
            {
                label3.Text = "giriþ baþarýlý";
                Form2 form2 = new Form2();
                form2.Visible = true;
                this.Visible = false;
            }
            else
            {
                label3.Text = "giriþ baþarýsýz";
            }

            sr.Close();
            fs.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
