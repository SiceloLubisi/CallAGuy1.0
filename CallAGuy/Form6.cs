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
    public partial class frmHelpInformation : Form
    {
        public frmHelpInformation()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lblHelpInfo.Text = "This is the help information"; 
        }

        private void btnHelpBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrder form = new frmOrder();
            form.ShowDialog();
        }
    }
}
