using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiprogect.UserControls
{
    public partial class sikayet : UserControl
    {
        public Elektrik_Abonelikleri E { get; set; }
        public Su_Abonelikleri S { get; set; }
        public Gaz_Abonelikleri G { get; set; }
        public sikayet(Elektrik_Abonelikleri elektrik, Su_Abonelikleri su, Gaz_Abonelikleri gaz)
        {
            InitializeComponent();
            E = elektrik;
            S = su;
            G = gaz;
        }

        private void sikayet_Load(object sender, EventArgs e)
        {

        }

        private void Bildir_but_Click(object sender, EventArgs e)
        {
            try
            {
                if (E != null)
                {
                   
                    if (string.IsNullOrWhiteSpace(aciklama.Text))
                    {
                        throw new Exception("Lütfen açıklama ekleyiniz");
                    }

                    E.SikayetEkle(E.Tc_kimlik, aciklama.Text);
                    lblHata.Text = "Şikayetiniz gönderildi";
                    aciklama.Text = "";

                }
                if (S != null)
                {
                    if (string.IsNullOrWhiteSpace(aciklama.Text))
                    {
                        throw new Exception("Lütfen açıklama ekleyiniz");
                    }
                    S.SikayetEkle(S.Tc_kimlik, aciklama.Text);
                    lblHata.Text = "Şikayetiniz gönderildi";
                    aciklama.Text = "";
                }
                if (G != null)
                {
                    if (string.IsNullOrWhiteSpace(aciklama.Text))
                    {
                        throw new Exception("Lütfen açıklama ekleyiniz");
                    }
                    G.SikayetEkle(G.Tc_kimlik, aciklama.Text);
                    lblHata.Text = "Şikayetiniz gönderildi";
                    aciklama.Text = "";
                }
            }
            catch (Exception x)
            {

                lblHata.Text = x.Message;
            }
        }
    }
}
