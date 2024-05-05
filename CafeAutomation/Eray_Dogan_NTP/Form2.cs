// Giriş Sayfası
using System;
using System.Windows.Forms;

namespace Eray_Dogan_NTP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 kafe = new Form1(); // Form'u çağırmak için bir form nesnesi oluşturalım

            // Eğer Koşul sağlanırsa "kafe" sayfasını açar
            if (textBox1.Text == "admin" && textBox2.Text == "1234") {
                
                kafe.Show();
            }
            // Eğer Koşul sağlanırsa "kafe" sayfasını açar
            else if (textBox1.Text == "misafir" && textBox2.Text == "1111")
            {
                kafe.Show();
            }
            // Eğer Koşullar Sağlanmazsa Hata mesajı Gösterir
            else
            {
                 MessageBox.Show("Kullanıcı Adı veya Şifre hatalı, lütfen tekrar deneyin","Hata",
                     MessageBoxButtons.OK,MessageBoxIcon.Error);        
            }
        }
    }
}