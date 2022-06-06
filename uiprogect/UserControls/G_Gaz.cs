using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uiprogect.Formlar;

namespace uiprogect
{
    public partial class G_Gaz : UserControl
    {
        public G_Gaz()
        {
            InitializeComponent();
        }

        private void logIn_but_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(E_Abone.Text) && string.IsNullOrWhiteSpace(E_Sifre.Text))
                {
                    throw new Exception("Lütfen Abone ve şifrenizi giriniz");
                }
                if (string.IsNullOrWhiteSpace(E_Abone.Text) || E_Abone.Text.Contains(" "))
                {
                    throw new Exception("Abone veya şifre alanı yanlış girildi");
                }
                if (string.IsNullOrWhiteSpace(E_Sifre.Text) || E_Sifre.Text.Contains(" "))
                {
                    throw new Exception("Abone veya şifre alanı yanlış girildi");
                }

                Gaz_Abonelikleri a = new Gaz_Abonelikleri();
                Gaz_Abonelikleri temp = a.Giris(int.Parse(E_Abone.Text.ToString()), E_Sifre.Text);
                if (temp != null)
                {
                    Gaz s = new Gaz(temp);
                    s.ShowDialog();
                }
               
            }
            catch (Exception ex)
            {
                lblHata.Text = ex.Message;

            }
        }

        private void ElektrekAbone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
               Gaz_AboneOl temp = new Gaz_AboneOl();
                temp.ShowDialog();
            }
            catch (Exception)
            {

                throw new Exception("Hata oldu");
            }
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sifremi_unuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Gaz_Abonelikleri s = new Gaz_Abonelikleri();
                s.Abone_Tarihi1 = DateTime.Now.ToString();
                sifreYenile a = new sifreYenile(null, null, s);
                a.ShowDialog();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
