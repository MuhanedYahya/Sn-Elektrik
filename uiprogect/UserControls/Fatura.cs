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
    public partial class Fatura : UserControl
    {
        public Elektrik_Abonelikleri E { get; set; }
        public Su_Abonelikleri S { get; set; }
        public Gaz_Abonelikleri G { get; set; }
        public Fatura(Elektrik_Abonelikleri elektrik, Su_Abonelikleri su, Gaz_Abonelikleri gaz)
        {
            InitializeComponent();
            E = elektrik;
            S = su;
            G = gaz;
        }

        private void Ode_Click(object sender, EventArgs e)
        {
           
        }

        private void Fatura_Load(object sender, EventArgs e)
        {
            try
            {
                if (E != null)
                {
                    DataGridView.DataSource = E.TumFaturalar(E.Elektrik_Abone_Numarasi1);
                }
                if (S != null)
                {
                    DataGridView.DataSource = S.TumFaturalar(S.Su_Abone_Numarasi1);
                }
                if (G != null)
                {
                    DataGridView.DataSource = G.TumFaturalar(G.Gaz_Abone_Numarasi1);
                }
            }
            catch (Exception x)
            {

                throw new Exception(x.Message);
            }
        }

        private void ode_Click_1(object sender, EventArgs e)
        {
            Odeme o = new Odeme();
            o.ShowDialog();
        }
    }
    
}
