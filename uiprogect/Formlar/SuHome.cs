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
    public partial class Su : Form
    {
        public Su_Abonelikleri prop { get; set; }
        public Su(Su_Abonelikleri s)
        {
            InitializeComponent();
            prop = s;
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Par_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abilgi1_Load(object sender, EventArgs e)
        {
           
        }

     

        private void Abone_b_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = true;
            Abilgi a = new Abilgi(null, prop, null);
            a.Dock = DockStyle.Fill;
            panelSuHome.Controls.Clear();
            panelSuHome.Controls.Add(a);
            
        }

        private void taleplerim_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            Talep a = new Talep(null,prop,null);
            a.Dock = DockStyle.Fill;
            panelSuHome.Controls.Clear();
            panelSuHome.Controls.Add(a);
        }

        private void odeme_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            Fatura a = new Fatura(null,prop,null);
            a.Dock = DockStyle.Fill;
            panelSuHome.Controls.Clear();
            panelSuHome.Controls.Add(a);
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fatura1_Load(object sender, EventArgs e)
        {
            
        }

        private void aboneliklerim_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            sikayet a = new sikayet(null, prop, null);
            a.Dock = DockStyle.Fill;
            panelSuHome.Controls.Clear();
            panelSuHome.Controls.Add(a);
        }

        private void Su_Load(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = true;
                Abilgi a = new Abilgi(null, prop, null);
                a.Dock = DockStyle.Fill;
                panelSuHome.Controls.Clear();
                panelSuHome.Controls.Add(a);
                lblMusteri.Text = prop.Su_Abone_Numarasi1.ToString();
          
        }

        private void panelSuHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            WebBrowser a = new WebBrowser();
            a.Navigate("http://www.google.com");
            a.Dock = DockStyle.Fill;
            panelSuHome.Controls.Clear();
            panelSuHome.Controls.Add(a);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            btnguncelle.Visible = false;
            vazgec.Visible = true;
            Hesab_user g = new Hesab_user(null,prop,null);
            g.Dock = DockStyle.Fill;
            panelSuHome.Controls.Clear();
            panelSuHome.Controls.Add(g);

        }

        private void vazgec_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = true;
            Abilgi a = new Abilgi(null, prop, null);
            a.Dock = DockStyle.Fill;
            panelSuHome.Controls.Clear();
            panelSuHome.Controls.Add(a);
        }
    }
}
