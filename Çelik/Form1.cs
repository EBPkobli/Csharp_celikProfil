using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Çelik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1 frm1 { get; set; }
        public ProfilDeger SecilenProfil { get; set; }
        public ProfilDeger[] Profiller;
        public int _Pyer { get; set; }
        public double pYuku { get; set; }
        public double profilAlan { get; set; }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                double CatiOrtusu = Convert.ToDouble(textBox1.Text);
                double Asik = Convert.ToDouble(textBox2.Text);
                double Makasoa = Convert.ToDouble(textBox4.Text);
                double KarYuku = Convert.ToDouble(textBox12.Text);

                double gYuk = CatiOrtusu + Asik + Makasoa + KarYuku;

                double eMesafe = Convert.ToDouble(textBox15.Text);
                double Aciklik = Convert.ToDouble(textBox16.Text);

                double Alan = eMesafe * Aciklik;

                double toplamYuk = Alan * (gYuk / 1000);

                double yayiliYuk = toplamYuk / Aciklik;

                double yukseklik = Convert.ToDouble(textBox14.Text);

                pYuku = (yayiliYuk * Math.Pow(Aciklik, 2)) / (16 * yukseklik);

                double emniyetGerilmesi = 1.44;
                profilAlan = pYuku / emniyetGerilmesi;

                Profiller = new ProfilDeger[17];
                BilgiAgaci.ProfilTablosu(ref Profiller);

                int tabloYeri = 0;
                SecilenProfil =Islem.uygunProfil(profilAlan, Profiller, ref tabloYeri);

               // MessageBox.Show("Seçilen Profil \n" + SecilenProfil.Profil+SecilenProfil.ProfilA.ToString()+"x"+SecilenProfil.ProfilS[tabloYeri].ToString()+"\nAlanı = "+SecilenProfil.ProfilAlan[tabloYeri].ToString()+"cm²");

                textBox17.Text = SecilenProfil.Profil;
                textBox18.Text = SecilenProfil.ProfilA.ToString();
                textBox19.Text = SecilenProfil.ProfilS[tabloYeri].ToString();
                textBox20.Text = SecilenProfil.ProfilAlan[tabloYeri].ToString();
                label37.Text = SecilenProfil.Profil + " " + SecilenProfil.ProfilA.ToString() +"x" + SecilenProfil.ProfilS[tabloYeri].ToString() + " ( " + SecilenProfil.ProfilAlan[tabloYeri].ToString() + "cm² " + ")";
                _Pyer = tabloYeri;
            }
            catch { }




        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox17.Text != "")
            {
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.frm1 = frm1;
                frm2.Profiller = Profiller;
                frm2.SecilenProfil = SecilenProfil;
                frm2._Pyer = _Pyer;
                frm2.profilAlan = profilAlan;
                frm2.pYuku = pYuku;

                frm2.ShowDialog();
            }
            else {
                MessageBox.Show("Profil seçilmedi","Uyarı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm1 = this;
        }


    }
}
