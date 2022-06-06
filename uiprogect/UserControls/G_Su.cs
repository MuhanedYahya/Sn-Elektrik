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
    public partial class G_Su : UserControl
    {
        public G_Su()
        {
            InitializeComponent();
        }

        private void logIn_but_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(S_Abone.Text) && string.IsNullOrWhiteSpace(S_Sifre.Text))
                {
                    throw new Exception("Lütfen Abone ve şifrenizi giriniz");
                }
                if (string.IsNullOrWhiteSpace(S_Abone.Text) || S_Abone.Text.Contains(" "))
                {
                    throw new Exception("Abone veya şifre alanı yanlış girildi");
                }
                if (string.IsNullOrWhiteSpace(S_Sifre.Text) || S_Sifre.Text.Contains(" "))
                {
                    throw new Exception("Abone veya şifre alanı yanlış girildi");
                }

                Su_Abonelikleri a = new Su_Abonelikleri();
                Su_Abonelikleri temp = a.Giris(int.Parse(S_Abone.Text.ToString()), S_Sifre.Text);
                if (temp != null)
                {
                    Su s = new Su(temp);
                    s.ShowDialog();
                }
             
            }
            catch (Exception ex)
            {
                lblHata.Text = ex.Message;

            }
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void ElektrekAbone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Su_AboneOl s = new Su_AboneOl();
            s.ShowDialog();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sifremi_unuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Su_Abonelikleri s = new Su_Abonelikleri();
                s.Abone_Tarihi1 = DateTime.Now.ToString();
                sifreYenile a = new sifreYenile(null, s, null);
                a.ShowDialog();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
