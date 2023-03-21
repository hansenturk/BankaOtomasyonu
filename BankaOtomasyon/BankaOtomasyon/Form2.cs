using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql sorguları için
using System.Data.SqlClient;

namespace BankaOtomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //SQL bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRHAN;Initial Catalog=DbBanka;Integrated Security=True");

        //Globalde kullanım
        public string hesap;

        void bakiye()
        {
            //SQL başlatması
            baglanti.Open();

            //Hesap NO'suna göre bakiye yi getirme
            SqlCommand komut = new SqlCommand("select BAKIYE from TBLHESAP where hesapno=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);

            //SQL okuma işlemi
            SqlDataReader dr=komut.ExecuteReader();

            while (dr.Read())
            {
                lblbakiye.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)        
        {
            //başka bir classı tanımlama
            bakiye();

            //DataGrid de bilgileri doldurmak için kullanılıyor
            this.tBLHAREKETTableAdapter.Fill(this.dbBankaDataSet.TBLHAREKET);

            baglanti.Open();

            //globalde hesap no ya erişim için kullanılır
            lblhesapno.Text = hesap;

            //Girilen HesapNo ya göre SQL den bilgileri getirme
            SqlCommand komut=new SqlCommand("Select * From TBLKISILER where hesapno=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);

            //database de ki komutları okuma işlemi için kullanılır
            SqlDataReader dr=komut.ExecuteReader();

            //okunan bilgileri gerekli lablelara aktarma yapar
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1] + " " + dr[2];
                lbltc.Text = dr[3].ToString();
                lbltelefon.Text = dr[4].ToString();
                pictureBox2.ImageLocation = dr[7].ToString();
            }

            //HesapNo'nun yaptığı işlemlere göre Datagride ekleme
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value == lblhesapno)
                {

                    SqlCommand com = new SqlCommand("select * from tblhareket where GONDEREN=@p1", baglanti);
                    com.Parameters.AddWithValue("@p1", lblhesapno);
                    com.ExecuteNonQuery();
                    dataGridView1.DataSource = com;
                }
            }
            baglanti.Close();
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            
            //Gönderme yapılan hesabın bakiye artışı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@p2", mskhesapno.Text);
            komut.ExecuteNonQuery();

            //Gönderim yapan hesabın bakiye azalışı
            SqlCommand komut2 = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE-@k1 where HESAPNO=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(txttutar.Text));
            komut2.Parameters.AddWithValue("@k2", hesap);
            komut2.ExecuteNonQuery();

            //Yapılan işlemlerin hareket tablosu
            SqlCommand komut3 = new SqlCommand("insert into TBLHAREKET (GONDEREN, ALICI, TUTAR) values(@t1,@t2,@t3)", baglanti);
            komut3.Parameters.AddWithValue("@t1", lblhesapno.Text);
            komut3.Parameters.AddWithValue("@t2", mskhesapno.Text);
            komut3.Parameters.AddWithValue("@t3", decimal.Parse(txttutar.Text));
            komut3.ExecuteNonQuery();

            MessageBox.Show("İşleminiz Gerçekleştirilmiştir.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            baglanti.Close();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //SQL bağlantısı
            SqlConnection baglanti = new SqlConnection(@"Data Source=EMIRHAN;Initial Catalog=DbBanka;Integrated Security=True");           

            //SQL de bulunan bilgileri Çekmek için kullanılır
            SqlDataAdapter da = new SqlDataAdapter("select TBLHAREKET.ID ,(P.AD + ' ' + P.SOYAD) as ALICI,(VP.AD + ' ' + VP.SOYAD) as GONDEREN=@p1,TUTAR from TBLHAREKET inner join TBLKISILER as P " +
              "on TBLHAREKET.ALICI = P.HESAPNO inner join TBLKISILER as VP on TBLHAREKET.GONDEREN=@p1 = VP.HESAPNO where GONDEREN='", baglanti);

            //Datagrid içinde excel tarzı yapı oluşturmak için kullanılan metot
            DataTable dt = new DataTable();

            //SQL den çekilen bilgileri datatable içine doldurma
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

      
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {           
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Form4 fr=new Form4();
            fr.hesap = lblhesapno.Text;
            fr.ShowDialog();
            
        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        void kisisil()
        {
            baglanti.Open();

            //Hesap NO'suna göre SQL de kayıtlı bilgilerini silme
            SqlCommand komut = new SqlCommand("delete from TBLKISILER where hesapno=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);

            komut.ExecuteNonQuery();
                        
            baglanti.Close();
        }
        void hareketsil()
        {
            baglanti.Open();

            //Hesap NO'suna göre Hareket tablosundaki verilerini silme
            SqlCommand komut = new SqlCommand("delete from TBLHAREKET where GONDEREN=@p1 or ALICI=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);

            komut.ExecuteNonQuery();          

            baglanti.Close();
        }
        void hesapsil()
        {
            baglanti.Open();

            //Hesap NO'suna göre hesap tablosundaki verilerini silme
            SqlCommand komut = new SqlCommand("delete from TBLHESAP where HESAPNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);

            komut.ExecuteNonQuery();

            MessageBox.Show("Silme İşlemi Başarılı.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);


            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dışarda tanımlanan classların tek bir yerde toplanması
            kisisil();
            hesapsil();   
            hareketsil();


            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }
    }
}
