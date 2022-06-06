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
    public partial class G_elektrik : UserControl
    {
        public G_elektrik()
        {
            InitializeComponent();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

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

                Elektrik_Abonelikleri a = new Elektrik_Abonelikleri();
                Elektrik_Abonelikleri temp =a.Giris(int.Parse(E_Abone.Text.ToString()), E_Sifre.Text);
               
                if (temp!=null)
                {
                    Elektrik s = new Elektrik(temp);
                    s.ShowDialog();
                }
               

            }
            catch (Exception ex)
            {
                lblHata.Text=ex.Message;
            }
        }

        private void ElektrekAbone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                AboneOL temp = new AboneOL();
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

        private void sifremi_unuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                Elektrik_Abonelikleri s = new Elektrik_Abonelikleri();
                s.Abone_Tarihi1 = DateTime.Now.ToString();
                if (s!=null)
                {
                    sifreYenile a = new sifreYenile(s, null, null);
                    a.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
    }
}
