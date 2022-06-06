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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            G_elektrik g = new G_elektrik();
            g.Dock = DockStyle.Fill;
            LoginPanel.Controls.Clear();
            LoginPanel.Controls.Add(g);

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            G_elektrik g = new G_elektrik();
            g.Dock = DockStyle.Fill;
            LoginPanel.Controls.Clear();
            LoginPanel.Controls.Add(g);

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            G_Su g = new G_Su();
            g.Dock = DockStyle.Fill;
            LoginPanel.Controls.Clear();
            LoginPanel.Controls.Add(g);
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            G_Gaz g = new G_Gaz();
            g.Dock = DockStyle.Fill;
            LoginPanel.Controls.Clear();
            LoginPanel.Controls.Add(g);
        }

        private void g_elektrik1_Load(object sender, EventArgs e)
        {
           
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
