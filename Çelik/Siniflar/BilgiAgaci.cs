using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çelik
{
    public struct ProfilDeger
    {
        public string Profil;
        public int ProfilA;
        public int[] ProfilS;
        public double[] ProfilAlan;
        public double[] AtaletYC;
    }

    class BilgiAgaci
    {
        public static void ProfilTablosu(ref ProfilDeger[] profil)
        {
            #region PROFILGİRDİLERİ
            profil = new ProfilDeger[17];
            //Bilgi Ağacı Tablo 1.bölge\\
            profil[0].Profil = "L";
            profil[0].ProfilA = 20;
            profil[0].ProfilS = new int[2] { 3, 4 };
            profil[0].ProfilAlan = new double[2] { 1.12, 1.45 };
            //Bilgi Ağacı Tablo 1.bölge\\

            //Bilgi Ağacı Tablo 2.bölge\\
            profil[1].Profil = "L";
            profil[1].ProfilA = 25;
            profil[1].ProfilS = new int[3] { 3, 4, 5 };
            profil[1].ProfilAlan = new double[3] { 1.42, 1.85, 2.26 };
            //Bilgi Ağacı Tablo 2.bölge\\

            //Bilgi Ağacı Tablo 3.bölge\\
            profil[2].Profil = "L";
            profil[2].ProfilA = 30;
            profil[2].ProfilS = new int[3] { 3, 4, 5 };
            profil[2].ProfilAlan = new double[3] { 1.42, 1.85, 2.26 };
            //Bilgi Ağacı Tablo 3.bölge\\

            //Bilgi Ağacı Tablo 4.bölge\\
            profil[3].Profil = "L";
            profil[3].ProfilA = 35;
            profil[3].ProfilS = new int[4] { 3, 4, 5 ,6};
            profil[3].ProfilAlan = new double[4] { 2.04, 2.67, 3.28, 3.87 };
            //Bilgi Ağacı Tablo 4.bölge\\

            //Bilgi Ağacı Tablo 5.bölge\\
            profil[4].Profil = "L";
            profil[4].ProfilA = 40;
            profil[4].ProfilS = new int[4] { 3, 4, 5, 6 };
            profil[4].ProfilAlan = new double[4] { 2.35, 3.08, 3.79, 4.48 };
            //Bilgi Ağacı Tablo 5.bölge\\

            //Bilgi Ağacı Tablo 6.bölge\\
            profil[5].Profil = "L";
            profil[5].ProfilA = 45;
            profil[5].ProfilS = new int[4] { 4, 5, 6, 7 };
            profil[5].ProfilAlan = new double[4] { 3.49, 4.30, 5.09, 5.86 };
            //Bilgi Ağacı Tablo 6.bölge\\

            //Bilgi Ağacı Tablo 7.bölge\\
            profil[6].Profil = "L";
            profil[6].ProfilA = 50;
            profil[6].ProfilS = new int[6] { 4, 5, 6, 7, 8 ,9 };
            profil[6].ProfilAlan = new double[6] { 3.89, 4.80, 5.69, 6.56, 7.41, 8.24 };
            //Bilgi Ağacı Tablo 7.bölge\\

            //Bilgi Ağacı Tablo 8.bölge\\
            profil[7].Profil = "L";
            profil[7].ProfilA = 55;
            profil[7].ProfilS = new int[4] { 5, 6, 8, 10 };
            profil[7].ProfilAlan = new double[4] { 5.32, 6.31, 8.23, 10.1 };
            //Bilgi Ağacı Tablo 8.bölge\\

            //Bilgi Ağacı Tablo 9.bölge\\
            profil[8].Profil = "L";
            profil[8].ProfilA = 60;
            profil[8].ProfilS = new int[4] { 5, 6, 8, 10 };
            profil[8].ProfilAlan = new double[4] { 5.82, 6.91, 9.03, 11.1 };
            //Bilgi Ağacı Tablo 9.bölge\\

            //Bilgi Ağacı Tablo 10.bölge\\
            profil[9].Profil = "L";
            profil[9].ProfilA = 65;
            profil[9].ProfilS = new int[5] { 6, 7, 8, 9, 11 };
            profil[9].ProfilAlan = new double[5] { 7.53, 8.70, 9.85, 11, 13.2 };
            //Bilgi Ağacı Tablo 10.bölge\\

            //Bilgi Ağacı Tablo 11.bölge\\
            profil[10].Profil = "L";
            profil[10].ProfilA = 70;
            profil[10].ProfilS = new int[4] { 6, 7, 9, 11 };
            profil[10].ProfilAlan = new double[4] { 8.13, 9.4, 11.9, 14.3 };
            profil[10].AtaletYC = new double[4] {2.68,2.67,2.64,2.61 };
            //Bilgi Ağacı Tablo 11.bölge\\

            //Bilgi Ağacı Tablo 12.bölge\\
            profil[11].Profil = "L";
            profil[11].ProfilA = 75;
            profil[11].ProfilS = new int[5] { 6, 7, 8, 10,12 };
            profil[11].ProfilAlan = new double[5] { 8.75, 10.1, 11.5, 14.1, 16.7 };
            profil[11].AtaletYC = new double[5] { 2.87, 2.87, 2.85, 2.73,2.79 };
            //Bilgi Ağacı Tablo 12.bölge\\

            //Bilgi Ağacı Tablo 13.bölge\\
            profil[12].Profil = "L";
            profil[12].ProfilA = 80;
            profil[12].ProfilS = new int[5] {  7, 8, 10, 12, 14 };
            profil[12].ProfilAlan = new double[5] { 10.8, 12.3, 15.1, 17.9, 20.6 };
            profil[12].AtaletYC = new double[5] { 3.07, 3.06, 3.03, 3.0, 2.96 };
            //Bilgi Ağacı Tablo 13.bölge\\

            //Bilgi Ağacı Tablo 14.bölge\\
            profil[13].Profil = "L";
            profil[13].ProfilA = 90;
            profil[13].ProfilS = new int[5] {  8, 9, 11, 13, 16 };
            profil[13].ProfilAlan = new double[5] { 13.9, 15.5, 18.7, 21.8, 26.4 };
            profil[13].AtaletYC = new double[5] { 3.45, 3.45, 3.41, 3.39, 3.34 };
            //Bilgi Ağacı Tablo 14.bölge\\

            //Bilgi Ağacı Tablo 15.bölge\\
            profil[14].Profil = "L";
            profil[14].ProfilA = 100;
            profil[14].ProfilS = new int[6] { 8, 10, 12, 14, 16, 20 };
            profil[14].ProfilAlan = new double[6] { 15.5, 19.2, 22.7, 26.2, 29.6, 36.2 };
            profil[14].AtaletYC = new double[6] { 3.85, 3.82, 3.80, 3.77, 3.74,3.67 };
            //Bilgi Ağacı Tablo 15.bölge\\

            //Bilgi Ağacı Tablo 16.bölge\\
            profil[15].Profil = "L";
            profil[15].ProfilA = 110;
            profil[15].ProfilS = new int[3] {  10, 12, 14 };
            profil[15].ProfilAlan = new double[3] { 21.2, 25.1, 29 };
            //Bilgi Ağacı Tablo 16.bölge\\

            //Bilgi Ağacı Tablo 17.bölge\\
            profil[16].Profil = "L";
            profil[16].ProfilA = 120;
            profil[16].ProfilS = new int[4] { 11, 12, 13, 15  };
            profil[16].ProfilAlan = new double[4] { 25.4, 27.5, 29.7, 33.9};
            //Bilgi Ağacı Tablo 17.bölge\\

            #endregion
        }

    }
}
