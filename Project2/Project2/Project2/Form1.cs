using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //calculate the circle size
            double radius = double.Parse(txtRadius.Text);


            double area = Math.PI * Math.Pow(radius, 2);
            double diameter = 2 * radius;
            double cir = 2 * Math.PI * radius;

            txtArea.Text = "" + Math.Round(area,1);
            txtDiameter.Text = "" + Math.Round(diameter, 1);
            txtCircumference.Text = "" + Math.Round(cir,1);
           
        }

        private void btnTrapez_Click(object sender, EventArgs e)
        {
            //calculate the Trapezoid size
            double trapSizeA = double.Parse(txtA.Text);
            double trapSizeB = double.Parse(txtB.Text);
            double trapHeight = double.Parse(txtHeight.Text);

            double areaTrap = ((trapSizeA + trapSizeB) / 2 * trapHeight);
            double trapPeri = (trapSizeA + trapSizeB) * 2;

            txtTrapArea.Text = "" + Math.Round(areaTrap, 1);
            txtPerimeter.Text = "" + Math.Round(trapPeri, 1);


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCircumference.Visible = false;
            txtArea.Visible = false;
            txtDiameter.Visible = false;
            txtRadius.Visible = false;
            txtTrapArea.Visible = false;
            txtPerimeter.Visible = false;
            txtA.Visible = false;
            txtB.Visible = false;
            txtHeight.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPerimeter_Click(object sender, EventArgs e)
        {

        }

        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void lblTrapArea_Click(object sender, EventArgs e)
        {

        }

        private void lblB_Click(object sender, EventArgs e)
        {

        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
