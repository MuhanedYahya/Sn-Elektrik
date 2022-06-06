using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiprogect.Formlar
{
    public partial class sifreYenile : Form
    {

        public Elektrik_Abonelikleri E { get; set; }
        public Su_Abonelikleri S { get; set; }
        public Gaz_Abonelikleri G { get; set; }
        public sifreYenile(Elektrik_Abonelikleri elektrik, Su_Abonelikleri su, Gaz_Abonelikleri gaz)
        {
            InitializeComponent();
            E = elektrik;
            S = su;
            G = gaz;
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sifreYenile_Load(object sender, EventArgs e)
        {
            if (E != null)
            {
                lblgiren.Text = "Elektrik Abone Numaranız :";
            }
            if (S != null)
            {
                lblgiren.Text = "Su Abone Numaranız :";

            }
            if (G != null)
            {
                lblgiren.Text = "Gaz Abone Numaranız :";

            }
        }

        private void resetle_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (E != null)
                {

                    if (string.IsNullOrWhiteSpace(tc.Text) || tc.Text.Contains(" ") || tc.Text.Length != 11)
                    {
                        throw new Exception("TC-kimlik bilgisi yanlış girildi");
                    }
                    if (string.IsNullOrWhiteSpace(sifre.Text) || sifre.Text.Contains(" "))
                    {
                        throw new Exception("şifre bilgisi yanlış girildi");
                    }
                    if (string.IsNullOrWhiteSpace(numara.Text) || numara.Text.Contains(" "))
                    {
                        throw new Exception("Abone Numarası bilgisi yanlış girildi");
                    }

                    if (E.ElektrikExists(tc.Text)==false)
                    {
                        throw new Exception("Abone Numarası bulunamadı");
                    }

                    E.SifreResetle(tc.Text, int.Parse(numara.Text.ToString()), sifre.Text);
                    MessageBox.Show("SN Şifreniz resetlendi.\nşirketimizdeki diğer aboneliklerinizde geçerli olacak");
                    this.Close();

                }

                if (S != null)
                {
                    if (string.IsNullOrWhiteSpace(tc.Text) || tc.Text.Contains(" ") || tc.Text.Length != 11)
                    {
                        throw new Exception("TC-kimlik bilgisi yanlış girildi");
                    }
                    if (string.IsNullOrWhiteSpace(sifre.Text) || sifre.Text.Contains(" "))
                    {
                        throw new Exception("şifre bilgisi yanlış girildi");
                    }
                    if (string.IsNullOrWhiteSpace(numara.Text) || numara.Text.Contains(" "))
                    {
                        throw new Exception("Abone Numarası bilgisi yanlış girildi");
                    }

                    if (S.SuExists(tc.Text) == false)
                    {
                        throw new Exception("Abone Numarası bulunamadı");
                    }

                    S.SifreResetle(tc.Text, int.Parse(numara.Text.ToString()), sifre.Text);
                    MessageBox.Show("SN Şifreniz resetlendi.\nşirketimizdeki diğer aboneliklerinizde geçerli olacak");
                    this.Close();

                }


                if (G != null)
                {
                    if (string.IsNullOrWhiteSpace(tc.Text) || tc.Text.Contains(" ") || tc.Text.Length != 11)
                    {
                        throw new Exception("TC-kimlik bilgisi yanlış girildi");
                    }
                    if (string.IsNullOrWhiteSpace(sifre.Text) || sifre.Text.Contains(" "))
                    {
                        throw new Exception("şifre bilgisi yanlış girildi");
                    }
                    if (string.IsNullOrWhiteSpace(numara.Text) || numara.Text.Contains(" "))
                    {
                        throw new Exception("Abone Numarası bilgisi yanlış girildi");
                    }
                 
                    G.SifreResetle(tc.Text, int.Parse(numara.Text.ToString()), sifre.Text);
                    MessageBox.Show("SN Şifreniz resetlendi.\nşirketimizdeki diğer aboneliklerinizde geçerli olacak");
                    this.Close();

                   
                }

            }
            catch (Exception x)
            {

                lblHata.Text = x.Message;
            }

        }
    }
    
}
