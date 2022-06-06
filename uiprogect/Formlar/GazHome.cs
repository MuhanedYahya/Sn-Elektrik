using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uiprogect.UserControls;

namespace uiprogect
{
    public partial class Gaz : Form
    {
        public Gaz_Abonelikleri prop { get; set; }
        public Gaz(Gaz_Abonelikleri g)
        {
            InitializeComponent();
            prop = g;
        }

        private void fatura1_Load(object sender, EventArgs e)
        {

        }
        private void Abone_b_Click(object sender, EventArgs e)
        {
          
        }

        private void taleplerim_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            Talep a = new Talep(null, null, prop);
            a.Dock = DockStyle.Fill;
            panelGazHome.Controls.Clear();
            panelGazHome.Controls.Add(a);
        }

        private void odeme_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            Fatura a = new Fatura(null, null, prop);
            a.Dock = DockStyle.Fill;
            panelGazHome.Controls.Clear();
            panelGazHome.Controls.Add(a);
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Abone_b_Click_1(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = true;
            Abilgi a = new Abilgi(null, null, prop);
            a.Dock = DockStyle.Fill;
            panelGazHome.Controls.Clear();
            panelGazHome.Controls.Add(a);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abilgi1_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void aboneliklerim_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            sikayet a = new sikayet(null, null, prop);
            a.Dock = DockStyle.Fill;
            panelGazHome.Controls.Clear();
            panelGazHome.Controls.Add(a);
        }

        private void Gaz_Load(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = true;
            Abilgi a = new Abilgi(null, null, prop);
            a.Dock = DockStyle.Fill;
            panelGazHome.Controls.Clear();
            panelGazHome.Controls.Add(a);
            lblMusteri.Text = prop.Gaz_Abone_Numarasi1.ToString();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            WebBrowser a = new WebBrowser();
            a.Navigate("http://www.google.com");
            a.Dock = DockStyle.Fill;
            panelGazHome.Controls.Clear();
            panelGazHome.Controls.Add(a);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            btnguncelle.Visible = false;
            vazgec.Visible = true;
            Hesab_user g = new Hesab_user(null,null,prop);
            g.Dock = DockStyle.Fill;
            panelGazHome.Controls.Clear();
            panelGazHome.Controls.Add(g);
        }

        private void vazgec_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = true;
            Abilgi a = new Abilgi(null, null, prop);
            a.Dock = DockStyle.Fill;
            panelGazHome.Controls.Clear();
            panelGazHome.Controls.Add(a);
        }

        private void panelGazHome_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
