// Kafe Sayfası
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Eray_Dogan_NTP
{
    public partial class Form1 : Form
    {
        // Listelerimizi Oluşturalım
        List<string> masa1Siparis = new List<string>();
        List<string> masa2Siparis = new List<string>();
        List<string> masa3Siparis = new List<string>();
        List<string> masa4Siparis = new List<string>();

        // Daha Sonra Masa kontrolü için bool değerler oluşturalım.
        bool masa1basildimi = false;
        bool masa2basildimi = false;
        bool masa3basildimi = false;

        bool masa1odemebas = false;
        bool masa2odemebas = false;
        bool masa3odemebas = false;

        // Masaların Hesapları
        int masa1hesap = 0;
        int masa2hesap = 0;
        int masa3hesap = 0;

        public Form1()
        {
            InitializeComponent();

            // "Sipariş Ver" GroupBox'ları nı en başta Görünmez Yapalım
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Masa1 Butonuna Tıklandığında Masa1 in "Sipariş Ver" GroupBox'ı aktif Olur. Diğerleri hala inaktif.
            groupBox4.Visible=false;
            groupBox3.Visible=false;
            groupBox1.Visible = true;
            masa1basildimi = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   // Masa2 Butonuna Tıklandığında Masa2 in "Sipariş Ver" GroupBox'ı aktif Olur. Diğerleri hala inaktif.
            groupBox4.Visible = false;
            groupBox1.Visible = false;
            masa1basildimi = false; // Doğru değişkeni güncellemek için "masa1basildimi"yi "masa2basildimi" ile değiştirin.
            groupBox3.Visible = true;
            masa2basildimi = true;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {   // Mas3 Butonuna Tıklandığında Masa3 in "Sipariş Ver" GroupBox'ı aktif Olur. Diğerleri hala inaktif.
            groupBox4.Visible = true;
            groupBox3.Visible = false;
            groupBox1.Visible = false;
            masa3basildimi = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            // Geri Tuşuna basıldığında "Sipariş Ver" Sekmesi Kapanır
            groupBox1.Visible = false;
            masa1basildimi = false;
            masa2basildimi = false;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Bu Blok CheckBox'ları kontrol eder ve seçilmiş olanları "masa1siparis" listesine ekler.
            if (masa1basildimi)
            {
                if (checkBox1.Checked) { masa1Siparis.Add(checkBox1.Text); masa1hesap += 20; }
                else { }
                if (checkBox2.Checked) { masa1Siparis.Add(checkBox2.Text); masa1hesap += 30; }
                else { }
                if (checkBox3.Checked) { masa1Siparis.Add(checkBox3.Text); masa1hesap += 45; }
                else { }
                if (checkBox4.Checked){ masa1Siparis.Add(checkBox4.Text); masa1hesap += 15;}
                else { }
                if (checkBox5.Checked) { masa1Siparis.Add(checkBox5.Text); masa1hesap += 50; }
                else { }
                if (checkBox6.Checked) { masa1Siparis.Add(checkBox6.Text); masa1hesap += 35; }
                else { }
                if (checkBox7.Checked) { masa1Siparis.Add(checkBox7.Text); masa1hesap += 20; }
                else { }

            }
            // Artık Masa1'de sipariş olduğu için masa artık dolu o yüzden masanın rengini kırmızı yapalım
            button1.BackColor = Color.Red;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Bu Blok CheckBox'ları kontrol eder ve seçilmiş olanları "masa2siparis" listesine ekler.
            if (masa2basildimi)
            {
                if (checkBox8.Checked) { masa2Siparis.Add(checkBox8.Text); masa2hesap += 20; }
                else { }
                if (checkBox9.Checked) { masa2Siparis.Add(checkBox9.Text); masa2hesap += 35; }
                else { }
                if (checkBox10.Checked) { masa2Siparis.Add(checkBox10.Text); masa2hesap += 50; }
                else { }
                if (checkBox11.Checked) { masa2Siparis.Add(checkBox11.Text); masa2hesap += 15; }
                else { }
                if (checkBox12.Checked) { masa2Siparis.Add(checkBox12.Text); masa2hesap += 45; }
                else { }
                if (checkBox13.Checked) { masa2Siparis.Add(checkBox13.Text); masa2hesap += 30; }
                else { }
                if (checkBox14.Checked) { masa2Siparis.Add(checkBox14.Text); masa2hesap += 20; }
            }
            // Artık Masa2'de sipariş olduğu için masa artık dolu o yüzden masanın rengini kırmızı yapalım
            button2.BackColor = Color.Red;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            // Bu Blok CheckBox'ları kontrol eder ve seçilmiş olanları "masa2siparis" listesine ekler.
            if (masa3basildimi)
            {
                if (checkBox15.Checked) { masa3Siparis.Add(checkBox15.Text); masa3hesap += 20; }
                else { }
                if (checkBox16.Checked) { masa3Siparis.Add(checkBox16.Text); masa3hesap += 35; }
                else { }
                if (checkBox17.Checked) { masa3Siparis.Add(checkBox17.Text); masa3hesap += 50; }
                else { }
                if (checkBox18.Checked) { masa3Siparis.Add(checkBox18.Text); masa3hesap += 15; }
                else { }
                if (checkBox19.Checked) { masa3Siparis.Add(checkBox19.Text); masa3hesap += 45; }
                else { }
                if (checkBox20.Checked) { masa3Siparis.Add(checkBox20.Text); masa3hesap += 30; }
                else { }
                if (checkBox21.Checked) { masa3Siparis.Add(checkBox21.Text); masa3hesap += 20; }
            }
            // Artık Masa3'de sipariş olduğu için masa artık dolu o yüzden masanın rengini kırmızı yapalım
            button3.BackColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Bu Blok "Hesabı Gör" GroupBox'ını ifade eder


            // Eğer iki radiobuttondan herhangi biri işaretlenmezse uyarı verir.
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                label7.Text = "*Lütfen bir Ödeme Yöntemi Seçin";
            }
            // Değilse..
            else
            {
                label7.Text = ""; // Uyarı mesajını siler

                // Masa1'in Faturası Görüntülenirken butona tıklanırsa
                if (masa1odemebas)
                {
                    button1.BackColor = Color.LimeGreen; // Masa rengi eskisine döner
                    label3.Text = 00.ToString(); // Text'i Sıfırla 
                    masa1Siparis.Clear(); // Masa1 Siparişi Sıfırlanır
                    listBox1.Items.Clear(); // ListBox temizlenir
                    masa1hesap = 0; // Hesap(Miktar) Sıfırlanır

                }
                // Masa2'nin Faturası Görüntülenirken butona tıklanırsa
                if (masa2odemebas)
                {
                    button2.BackColor = Color.LimeGreen; // Masa rengi eskisine döner
                    label3.Text = 00.ToString(); // Text'i Sıfırla
                    masa2Siparis.Clear(); // Masa1 Siparişi Sıfırlanır
                    listBox1.Items.Clear(); // ListBox temizlenir
                    masa2hesap = 0; // Hesap(Miktar) Sıfırlanır


                }
                // Masa3'ün Faturası Görüntülenirken butona tıklanırsa
                if (masa3odemebas)
                {
                    button3.BackColor = Color.LimeGreen; // Masa rengi eskisine döner
                    label3.Text = 00.ToString(); // Text'i Sıfırla
                    masa3Siparis.Clear(); // Masa1 Siparişi Sıfırlanır
                    listBox1.Items.Clear(); // ListBox temizlenir
                    masa3hesap = 0; // Hesap(Miktar) Sıfırlanır
                }
            }

            // RadioButton'lar Sıfırlanır
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Bu Buton Masa1'in Faturasının görüntülenmesini sağlar

            masa1odemebas = true; // Faturanın görüntülendiğini ifade eder
            listBox1.Items.Clear(); //ListBox'ı Temizler

            // "masa1siparis" listesini listBox1'e yazdırır
            foreach (string item in masa1Siparis)
            {
                listBox1.Items.Add(item);
            }

            label3.Text = masa1hesap.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Bu Buton Masa2'nin Faturasının görüntülenmesini sağlar

            masa2odemebas = true; // Faturanın görüntülendiğini ifade eder
            listBox1.Items.Clear(); //ListBox'ı Temizler

            // "masa2siparis" listesini listBox1'e yazdırır
            foreach (string item in masa2Siparis)
            {
                listBox1.Items.Add(item);
            }

            label3.Text = masa2hesap.ToString();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Bu Buton Masa2'nin Faturasının görüntülenmesini sağlar

            masa3odemebas = true; // Faturanın görüntülendiğini ifade eder
            listBox1.Items.Clear(); //ListBox'ı Temizler

            // "masa3siparis" listesini listBox1'e yazdırır
            foreach (string item in masa3Siparis)
            {
                listBox1.Items.Add(item);
            }

            label3.Text = masa3hesap.ToString();
        }

        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}