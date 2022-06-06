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
    public partial class Elektrik : Form
    {
        public  Elektrik_Abonelikleri prop { get; set; }
        public Elektrik(Elektrik_Abonelikleri a)
        {
            InitializeComponent();
            prop = a;         
        }

        private void taleplerim_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            Talep a = new Talep(prop,null,null);
            a.Dock = DockStyle.Fill;
            panelElektrikHome.Controls.Clear();
            panelElektrikHome.Controls.Add(a);

        }

        private void odeme_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            Fatura a = new Fatura(prop,null,null);
            a.Dock = DockStyle.Fill;
            panelElektrikHome.Controls.Clear();
            panelElektrikHome.Controls.Add(a);
        }

        private void aboneliklerim_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            sikayet a = new sikayet(prop,null,null);
            a.Dock = DockStyle.Fill;
            panelElektrikHome.Controls.Clear();
            panelElektrikHome.Controls.Add(a);
        }

        private void Abone_b_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = true;
            Abilgi a = new Abilgi(prop, null, null);
            a.Dock = DockStyle.Fill;
            panelElektrikHome.Controls.Clear();
            panelElektrikHome.Controls.Add(a);
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void talep1_Load(object sender, EventArgs e)
        {
          
        }

        private void abilgi1_Load(object sender, EventArgs e)
        {
            
        }

        private void Dash_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMusteri_Click(object sender, EventArgs e)
        {
            
        }

        private void Par_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Elektrik_Load(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = true;
            Abilgi a = new Abilgi(prop,null,null);
            a.Dock = DockStyle.Fill;
            panelElektrikHome.Controls.Clear();
            panelElektrikHome.Controls.Add(a);
            lblMusteri.Text = prop.Elektrik_Abone_Numarasi1.ToString();
        }

        private void panelElektrikHome_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = false;
            WebBrowser a = new WebBrowser();
            a.Navigate("http://www.google.com");
            a.Dock = DockStyle.Fill;
            panelElektrikHome.Controls.Clear();
            panelElektrikHome.Controls.Add(a);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void vazgec_Click(object sender, EventArgs e)
        {
            vazgec.Visible = false;
            btnguncelle.Visible = true;
            Abilgi a = new Abilgi(prop, null, null);
            a.Dock = DockStyle.Fill;
            panelElektrikHome.Controls.Clear();
            panelElektrikHome.Controls.Add(a);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            btnguncelle.Visible = false;
            vazgec.Visible = true;
            Hesab_user g = new Hesab_user(prop,null,null);
            g.Dock = DockStyle.Fill;
            panelElektrikHome.Controls.Clear();
            panelElektrikHome.Controls.Add(g);
        }
    }
}
