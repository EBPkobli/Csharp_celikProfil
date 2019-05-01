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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form1 frm1 { get; set; }
        public ProfilDeger SecilenProfil { get; set; }
        public ProfilDeger[] Profiller;
        public int _Pyer { get; set; }
        public double profilAlan { get; set; }
        public double pYuku { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox17.Text = SecilenProfil.Profil;
            textBox18.Text = SecilenProfil.ProfilA.ToString();
            textBox19.Text = SecilenProfil.ProfilS[_Pyer].ToString();
            textBox20.Text = SecilenProfil.ProfilAlan[_Pyer].ToString();
            try
            {
                textBox1.Text = SecilenProfil.AtaletYC[_Pyer].ToString();
            }
            catch { }
            label6.Text=SecilenProfil.ProfilA.ToString();
            label7.Text=SecilenProfil.ProfilA.ToString();
            label8.Text = SecilenProfil.ProfilS[_Pyer].ToString();
        }
      

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox1.Text)).ToString("0.##");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = (Convert.ToDouble(textBox4.Text) * pYuku / profilAlan).ToString("0.##");
            if (Convert.ToDouble(textBox5.Text) < 1.44)
            {
                textBox5.BackColor = Color.LightBlue;
                MessageBox.Show("Profil uygun", "Burkulma Tahkik");
            }
            else {
                textBox5.BackColor = Color.Red;
                MessageBox.Show("Profil uygun değil!", "Burkulma Tahkik");
            }
        }
    }
}
