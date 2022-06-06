using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiprogect
{
    public partial class Hesab_user : UserControl
    {
        public Elektrik_Abonelikleri E { get; set; }
        public Su_Abonelikleri S { get; set; }
        public Gaz_Abonelikleri G { get; set; }
        public Hesab_user(Elektrik_Abonelikleri elektrik, Su_Abonelikleri su, Gaz_Abonelikleri gaz)
        {
            InitializeComponent();
            E = elektrik;
            S = su;
            G = gaz;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void But_Kaydet_Click(object sender, EventArgs e)
        {

        }

        private void Hesab_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Hesab_user_Load(object sender, EventArgs e)
        {
            try
            {
                if (E != null)
                {
                    lblAbone.Text = E.Elektrik_Abone_Numarasi1.ToString();
                    lblTc.Text = E.Tc_kimlik;
                    lblIsim.Text = E.Isim;
                    lblEmail.Text = E.Email;
                    lblAdres.Text = E.Adres;
                    lblTelefon.Text = E.Telefon;
                    lblTarih.Text = E.Abone_Tarihi1;
                    lblSifre.Text = E.Sifre;
                }
                if (S != null)
                {
                    lblAbone.Text = S.Su_Abone_Numarasi1.ToString();
                    lblTc.Text = S.Tc_kimlik;
                    lblIsim.Text = S.Isim;
                    lblEmail.Text = S.Email;
                    lblAdres.Text = S.Adres;
                    lblTelefon.Text = S.Telefon;
                    lblTarih.Text = S.Abone_Tarihi1;
                    lblSifre.Text = S.Sifre;
                }
                if (G != null)
                {
                    lblAbone.Text = G.Gaz_Abone_Numarasi1.ToString();
                    lblTc.Text = G.Tc_kimlik;
                    lblIsim.Text = G.Isim;
                    lblEmail.Text = G.Email;
                    lblAdres.Text = G.Adres;
                    lblTelefon.Text = G.Telefon;
                    lblTarih.Text = G.Abone_Tarihi1;
                    lblSifre.Text = G.Sifre;
                }
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }

        private void tamamla_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblIsim.Text))
                {
                    throw new Exception("Isim alanı boş bırakılamaz");
                }
                if (string.IsNullOrWhiteSpace(lblEmail.Text))
                {
                    throw new Exception("Email alanı boş bırakılamaz");
                }
                if (string.IsNullOrWhiteSpace(lblTelefon.Text) || lblTelefon.Text.Contains(" ") || lblTelefon.Text.Length != 10)
                {
                    throw new Exception("Telefon alanı boş yada boşluklu bırakılamaz");
                }
                if (string.IsNullOrWhiteSpace(lblSifre.Text) || lblSifre.Text.Contains(" "))
                {
                    throw new Exception("şifre alanı boş yada boşluklu bırakılamaz");
                }
                if (string.IsNullOrWhiteSpace(lblAdres.Text))
                {
                    throw new Exception("Adres alanı boş bırakılamaz");
                }

                if (E != null)
                {     
                    if (E.Isim == lblIsim.Text && E.Email == lblEmail.Text && E.Adres == lblAdres.Text &&
                        E.Telefon == lblTelefon.Text && E.Sifre == lblSifre.Text)
                    {
                        throw new Exception("Herhangi bir değişiklik yapmadınız");
                    }

                     E.Isim= lblIsim.Text;
                     E.Email= lblEmail.Text;
                     E.Adres= lblAdres.Text;
                     E.Telefon= lblTelefon.Text;
                     E.Sifre= lblSifre.Text;

                    E.Guncelle(E);
                    lblHata.Text = "Kaydetme işlemi başarılı oldu";
                }
                if (S != null)
                {
                    if (S.Isim == lblIsim.Text && S.Email == lblEmail.Text && S.Adres == lblAdres.Text &&
                        S.Telefon == lblTelefon.Text && S.Sifre == lblSifre.Text)
                    {
                        throw new Exception("Herhangi bir değişiklik yapmadınız");
                    }

                    S.Isim = lblIsim.Text;
                    S.Email = lblEmail.Text;
                    S.Adres = lblAdres.Text;
                    S.Telefon = lblTelefon.Text;
                    S.Sifre = lblSifre.Text;
                    S.Guncelle(S);
                    lblHata.Text = "Kaydetme işlemi başarılı oldu";
                }
                if (G != null)
                {
                    if (G.Isim == lblIsim.Text && G.Email == lblEmail.Text && G.Adres == lblAdres.Text &&
                        G.Telefon == lblTelefon.Text && G.Sifre == lblSifre.Text)
                    {
                        throw new Exception("Herhangi bir değişiklik yapmadınız");
                    }

                    G.Isim = lblIsim.Text;
                    G.Email = lblEmail.Text;
                    G.Adres = lblAdres.Text;
                    G.Telefon = lblTelefon.Text;
                    G.Sifre = lblSifre.Text;
                    G.Guncelle(G);
                    lblHata.Text = "Kaydetme işlemi başarılı oldu";
                }
            }
            catch (Exception x)
            {
                lblHata.Text = x.Message;
            }
        }
    }
}
