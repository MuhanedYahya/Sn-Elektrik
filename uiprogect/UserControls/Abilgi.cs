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
    
    public partial class Abilgi : UserControl
    {

        public Elektrik_Abonelikleri E { get; set; }
        public Su_Abonelikleri S { get; set; }
        public Gaz_Abonelikleri G { get; set; }

        public Abilgi(Elektrik_Abonelikleri elektrik,Su_Abonelikleri su,Gaz_Abonelikleri gaz)
        {
            InitializeComponent();
            E = elektrik;
            S = su;
            G = gaz;
           
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void Abilgi_Load(object sender, EventArgs e)
        {

            try
            {
                if (E != null)
                {
                    lblMerhaba.Text="Merhaba "+ E.Isim; ;
                    lblAbone.Text = E.Elektrik_Abone_Numarasi1.ToString();
                    lblTc.Text = E.Tc_kimlik;
                    lblIsim.Text = E.Isim;
                    lblEmail.Text = E.Email;
                    lblAdres.Text = E.Adres;
                    lblTelefon.Text = E.Telefon;
                    lblTarih.Text = E.Abone_Tarihi1;
                }
                if (S != null)
                {
                    lblMerhaba.Text = "Merhaba " + S.Isim; ;
                    lblAbone.Text = S.Su_Abone_Numarasi1.ToString();
                    lblTc.Text = S.Tc_kimlik;
                    lblIsim.Text = S.Isim;
                    lblEmail.Text = S.Email;
                    lblAdres.Text = S.Adres;
                    lblTelefon.Text = S.Telefon;
                    lblTarih.Text = S.Abone_Tarihi1;
                }
                if (G != null)
                {
                    lblMerhaba.Text = "Merhaba " + G.Isim; ;
                    lblAbone.Text = G.Gaz_Abone_Numarasi1.ToString();
                    lblTc.Text = G.Tc_kimlik;
                    lblIsim.Text = G.Isim;
                    lblEmail.Text = G.Email;
                    lblAdres.Text = G.Adres;
                    lblTelefon.Text = G.Telefon;
                    lblTarih.Text = G.Abone_Tarihi1;
                }
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }

        }
    

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void isim_edit_Click(object sender, EventArgs e)
        {

        }

        private void But_Kaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAbone_Click(object sender, EventArgs e)
        {
            
        }

        private void lblIsim_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void But_Kaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (E != null)
                {
                    Kapat k = new Kapat(E, null, null);
                    k.Show();
                }
                if (S != null)
                {
                    Kapat k = new Kapat(null, S, null);
                    k.Show();
                }
                if (G != null)
                {
                    Kapat k = new Kapat(null, null, G);
                    k.Show();
                }
            }
            catch (Exception x)
            {

                throw new Exception(x.Message);
            }
        }

        private void eye_Click(object sender, EventArgs e)
        {
            try
            {
                if (E != null)
                {

                    lblSifre.Text = E.Sifre;


                }
                if (S != null)
                {

                    lblSifre.Text = S.Sifre;

                }
                if (G != null)
                {

                    lblSifre.Text = G.Sifre;

                }
            }
            catch (Exception x)
            {

                throw new Exception(x.Message);
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
