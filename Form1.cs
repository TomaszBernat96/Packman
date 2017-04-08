using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace packman
{
    public partial class Form1 : Form
    {
        player x = new player();

        public Form1()
        {
            
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            deck f2 = new deck();
            this.Hide();
            f2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void powrot_do_menu_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void zwyciezca_Click(object sender, EventArgs e)
        {
          
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
