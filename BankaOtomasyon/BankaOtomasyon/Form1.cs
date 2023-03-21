using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankaOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SQL Database Bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRHAN;Initial Catalog=DbBanka;Integrated Security=True");
             

        private void btngırıs_Click(object sender, EventArgs e)
        {
            //SQL Bağlantısını açma
            baglanti.Open();

            //SQL komutlarını yazmak için kullanılır
            SqlCommand komut = new SqlCommand("Select * From TBLKISILER WHERE hesapno=@p1 and SIFRE=@p2",baglanti);

            //SQL komutalarına değer atamak için kullanılır
            komut.Parameters.AddWithValue("@p1", mskhesapno.Text);
            komut.Parameters.AddWithValue("@p2", txtsıfre.Text);

            //SQL okuması yapılmak için kullanılır
            SqlDataReader dr = komut.ExecuteReader();

            //okunacak satıra göre bool(true/false) değer döndürür
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.hesap = mskhesapno.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Giriş Yapmadınız veya Hatalı Kullanıcı Bilgisi Girdiniz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            baglanti.Close();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            frm.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {            
            AnaSayfa frm = new AnaSayfa();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
