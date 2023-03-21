using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BankaOtomasyon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //SQL bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRHAN;Initial Catalog=DbBanka;Integrated Security=True");

        //Globalde kullanmak 
        public string hesap;

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
               
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
          this.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            //SQL deki bilgilerin güncellenmesi
            SqlCommand komut = new SqlCommand("Update TBLKISILER set Ad=@p1,Soyad=@p2,TC=@p3,Telefon=@p4,SIFRE=@p5,RESİM=@p6 where hesapno=@p7", baglanti);

            //Bilgilerin eksik girilmemesi için kontrol
            if (txtad.Text != "" && txtsoyad.Text != "" && txtsıfre.Text != "" && msktc.Text != "" && msktelefon.Text != "" &&pictureBox1.ImageLocation != "")
            {
                //parametlerin değerlere eklenmesi
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", msktc.Text);
                komut.Parameters.AddWithValue("@p4", msktelefon.Text);                
                komut.Parameters.AddWithValue("@p5", txtsıfre.Text);
                komut.Parameters.AddWithValue("@p6", pictureBox1.ImageLocation);
                komut.Parameters.AddWithValue("@p7", hesap);


                komut.ExecuteNonQuery();

                MessageBox.Show("Müşteri Bilgileri Değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            baglanti.Close();

            
        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            //Resmin sql'e kaydedilmesi
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {            
            this.Close();

        }
    }
}
