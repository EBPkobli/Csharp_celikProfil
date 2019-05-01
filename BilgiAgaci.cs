using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace �elik
{
    public struct ProfilDeger
    {
        public string Profil;
        public int ProfilA;
        public int[] ProfilS;
        public double[] ProfilAlan;
    }

    class BilgiAgaci
    {
        public void ProfilTablosu(ref ProfilDeger[] profil)
        {
            profil = new ProfilDeger[4];
            //Bilgi A�ac� Tablo 1.b�lge\\
            profil[0].Profil = "L";
            profil[0].ProfilA = 20;
            profil[0].ProfilS = new int[2] { 3, 4 };
            profil[0].ProfilAlan = new double[2] { 1.12, 1.45 };
            //Bilgi A�ac� Tablo 1.b�lge\\

            //Bilgi A�ac� Tablo 2.b�lge\\
            profil[1].Profil = "L";
            profil[1].ProfilA = 25;
            profil[1].ProfilS = new int[3] { 3, 4, 5 };
            profil[1].ProfilAlan = new double[3] { 1.42, 1.85, 2.26 };
            //Bilgi A�ac� Tablo 2.b�lge\\
        }

    }
}
