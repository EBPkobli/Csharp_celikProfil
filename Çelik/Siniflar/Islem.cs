using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çelik
{
    class Islem
    {
        public static ProfilDeger uygunProfil(double profilAlan,ProfilDeger[] Profiller,ref int kj)
        {
            int ki= 0;
            bool DonguKir = false;
            for (int i = 0; i < Profiller.Length; i++)
            {
                for (int j = 0; j < Profiller[i].ProfilAlan.Length; j++)
                {
                    if (Profiller[i].ProfilAlan[j] >= profilAlan)
                    {
                        ki = i;
                        kj = j;
                        DonguKir = true;
                        break;
                    }
                }
                if (DonguKir) break;
            }
            return Profiller[ki];
        }
        private void BurkulmaTahkik()
        { 
        
        }
    }
}
