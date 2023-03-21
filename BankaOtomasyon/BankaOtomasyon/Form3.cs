using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SQL işlemleri için gerekli
using System.Data.SqlClient;
//File işlemleri için gerekli
using System.IO;
using System.Windows.Forms;

namespace BankaOtomasyon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //SQL Database bağlantısı oluşturma
        SqlConnection baglanti=new SqlConnection(@"Data Source=EMIRHAN;Initial Catalog=DbBanka;Integrated Security=True");

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            decimal bakiye = 250;

            //SQL bağlantısı açma
            baglanti.Open();

            //SQL Kişi kayıt komutları
            SqlCommand komut = new SqlCommand("insert into TBLKISILER (Ad,Soyad,TC,Telefon,HesapNo,SIFRE,RESİM) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",baglanti);

            //Bilgileri Eksiksiz Girme
            if (txtad.Text!=""&&txtsoyad.Text!=""&&txtsıfre.Text!=""&&msktc.Text!=""&&msktelefon.Text!=""&&mskhesapno.Text!=""&&pictureBox1.ImageLocation!="")
            {
                //SQL parametreleri gönderme
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", msktc.Text);
                komut.Parameters.AddWithValue("@p4", msktelefon.Text);
                komut.Parameters.AddWithValue("@p5", mskhesapno.Text);
                komut.Parameters.AddWithValue("@p6", txtsıfre.Text);
                komut.Parameters.AddWithValue("@p7", pictureBox1.ImageLocation);

                //Katalog işlemleri için kullanılır(update/delete/insert vs.)
                komut.ExecuteNonQuery();

                MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Kaydedilen kişiye bakiye ataması yapma
            SqlCommand komut2 = new SqlCommand("insert into TBLHESAP (HesapNo,BAKIYE) values (@t1,@t2)", baglanti);

            komut2.Parameters.AddWithValue("@t1", mskhesapno.Text);           
            komut2.Parameters.AddWithValue("@t2", bakiye);           

            komut2.ExecuteNonQuery();

            //SQL bağlantı sonlandırma
            baglanti.Close();

            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
        

        private void btnhesapno_Click(object sender, EventArgs e)
        {
            //Hesap No'nun rastgele verilmesi
            Random rastgele = new Random();
            int sayi=rastgele.Next(100000,1000000);
            mskhesapno.Text = sayi.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            //Yüklenen resimin SQL e kayıt edilmesi
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}
