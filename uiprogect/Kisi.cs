using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uiprogect
{
     public abstract class Kisi
    {
        private string tc_kimlik;
        private string isim;        
        private string adres;
        private string telefon;
        private string email;
        private string sifre;

        public string Tc_kimlik { get => tc_kimlik; set => tc_kimlik = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string Sifre { get => sifre; set => sifre = value; }

       


    }
}
