using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyon
{
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
        }
        //timer için başlangıç değeri
        int start = 0;
        private void load_Load(object sender, EventArgs e)
        {
            //timer başlangıcı
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            
            //ProgressBarın değerle başlaması
            gecisbar.Value=start;

            if (gecisbar.Value==50)
            {
                gecisbar.Value = 0;
                timer1.Stop();
                AnaSayfa fr = new AnaSayfa();
                fr.Show();
                this.Hide();
                
            }

        }

        private void gecisbar_Click(object sender, EventArgs e)
        {

        }
    }
}
