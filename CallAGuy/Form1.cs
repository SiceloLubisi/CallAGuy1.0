using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallAGuy
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            lblDisplayPetrol.Text = "0";
            lblRands.Text = "0";
        }

        private void previousOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblDisplayPetrol.Text = trackBar1.Value.ToString();

            if (trackBar1.Value == 1)
            {
                lblRands.Text = "14.43";
            }
            else
            {
                lblRands.Text = "28.86"; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 10; 
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Call A Guy Diesel App. This app was designed to blah blah");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions on how to use the app");
        }

        //Logout Click Event
        private void logoutoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show(); 
        }
    }
}
