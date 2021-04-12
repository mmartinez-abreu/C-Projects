using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Orion : Form
    {
        public Orion()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //display stars
            lblAlnilam.Visible = true;
            //display stars
            lblAlnitak.Visible = true;
            //display stars
            lblBellatrix.Visible = true;
            //display stars
            lblBetel.Visible = true;
            //display stars
            lblMintaka.Visible = true;
            //display stars
            lblRigel.Visible = true;
            //display stars
            lblSaiph.Visible = true;
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            //display stars
            lblAlnilam.Visible = false;
            //display stars
            lblAlnitak.Visible = false;
            //display stars
            lblBellatrix.Visible = false;
            //display stars
            lblBetel.Visible = false;
            //display stars
            lblMintaka.Visible = false;
            //display stars
            lblRigel.Visible = false;
            //display stars
            lblSaiph.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //display stars
            lblAlnilam.Visible = false;
            //display stars
            lblAlnitak.Visible = false;
            //display stars
            lblBellatrix.Visible = false;
            //display stars
            lblBetel.Visible = false;
            //display stars
            lblMintaka.Visible = false;
            //display stars
            lblRigel.Visible = false;
            //display stars
            lblSaiph.Visible = false;
        }
    }
}
