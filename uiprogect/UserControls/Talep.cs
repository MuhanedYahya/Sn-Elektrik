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
    public partial class Talep : UserControl
    {
        public Elektrik_Abonelikleri E { get; set; }
        public Su_Abonelikleri S { get; set; }
        public Gaz_Abonelikleri G { get; set; }
        public Talep(Elektrik_Abonelikleri elektrik, Su_Abonelikleri su, Gaz_Abonelikleri gaz)
        {
            InitializeComponent();
            E = elektrik;
            S = su;
            G = gaz;
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Talep_Load(object sender, EventArgs e)
        {
            try
            {
                if (E != null)
                {
                    dataGridView.DataSource = E.TumTalepler(E.Elektrik_Abone_Numarasi1);
                }
                if (S != null)
                {
                    dataGridView.DataSource = S.TumTalepler(S.Su_Abone_Numarasi1);
                }
                if (G != null)
                {
                    dataGridView.DataSource = G.TumTalepler(G.Gaz_Abone_Numarasi1);
                }
            }
            catch (Exception x)
            {

                throw new Exception(x.Message);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void But_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {

                if (E != null)
                {
                    if (string.IsNullOrEmpty(aciklama.Text))
                    {
                        throw new Exception("Lütfen açıklama ekleyin");
                    }
                    if (string.IsNullOrEmpty(Talep_turu.Text))
                    {
                        throw new Exception("Lütfen Talep Türünüzü seçin");
                    }

                    E.TalepEkle(Talep_turu.SelectedItem.ToString(), DateTime.Now,aciklama.Text,E.Elektrik_Abone_Numarasi1);
                    dataGridView.DataSource = E.TumTalepler(E.Elektrik_Abone_Numarasi1);
                    aciklama.Text = "";
                }
                if (S != null)
                {

                    if (string.IsNullOrEmpty(aciklama.Text))
                    {
                        throw new Exception("Lütfen açıklama ekleyin");
                    }
                    if (string.IsNullOrEmpty(Talep_turu.Text))
                    {
                        throw new Exception("Lütfen Talep Türünüzü seçin");
                    }

                    S.TalepEkle(Talep_turu.SelectedItem.ToString(), DateTime.Now, aciklama.Text,S.Su_Abone_Numarasi1);
                    dataGridView.DataSource = S.TumTalepler(S.Su_Abone_Numarasi1);
                    aciklama.Text = "";
                }
                if (G != null)
                {

                    if (string.IsNullOrEmpty(aciklama.Text))
                    {
                       throw new Exception("Lütfen açıklama ekleyin");
                    }
                    if (string.IsNullOrEmpty(Talep_turu.Text))
                    {
                        throw new Exception("Lütfen Talep Türünüzü seçin");
                    }

                    G.TalepEkle(Talep_turu.SelectedItem.ToString(), DateTime.Now, aciklama.Text,G.Gaz_Abone_Numarasi1);
                    dataGridView.DataSource = G.TumTalepler(G.Gaz_Abone_Numarasi1);
                    aciklama.Text = "";
                }
            }
            catch (Exception x)
            {

                hata.Text =x.Message;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
