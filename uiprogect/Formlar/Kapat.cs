using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiprogect
{
    public partial class Kapat : Form
    {
        public  Elektrik_Abonelikleri E { get; set; }
        public Su_Abonelikleri S { get; set; }
        public Gaz_Abonelikleri G { get; set; }
        public Kapat(Elektrik_Abonelikleri elektrik,Su_Abonelikleri su,Gaz_Abonelikleri gaz)
        {
            InitializeComponent();
            E = elektrik;
            S = su;
            G = gaz;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Kapat_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void But_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (E != null)
                {
                    if (!btcheck.Checked)
                    {
                    throw new Exception("düğmeyi çekmeniz gerekiyor");

                    }
                    
                    E.AboneKapat(E);
                    MessageBox.Show("SN-Elektrik aboneliğiniz silindi uygulamadan çıkmak üzeresiniz");
                    Application.Exit();
                    
                }
                if (S != null)
                {
                    if (btcheck.Checked)
                    {
                        S.AboneKapat(S);
                        MessageBox.Show("SN-Su aboneliğiniz silindi uygulamadan çıkmak üzeresiniz");
                        Application.Exit();
                    }
                    
                        throw new Exception("düğmeyi çekmeniz gerekiyor");
                    
                }

                if (G != null)
                {
                    if (btcheck.Checked)
                    {
                        G.AboneKapat(G);
                        MessageBox.Show("SN-Gaz aboneliğiniz silindi uygulamadan çıkmak üzeresiniz");
                        Application.Exit();

                    }
                    
                        throw new Exception("düğmeyi çekmeniz gerekiyor");
                    
                }
               
            }
            catch (Exception x)
            {

                lblHata.Text=x.Message;
            }

        }
    }
}
