using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        //counter variable
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        private void btnGen(object sender, EventArgs e)
        {
            //generate random number

            int num;

            Random objRandom = new Random();

            num = objRandom.Next(1, 101);

            txtRandNum.Text = "       " + num.ToString();
            txtRandNum.Visible = false;
            lblRandNum.Visible = false;
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuess.Clear();
            txtRandNum.Clear();
            txtNumGen.Clear();
            txtCount.Clear();

        }

        private void btnGuessed_Click(object sender, EventArgs e)
        {
            counter++;
            txtCount.Text = counter.ToString();
            try
            {
                //input for the guessed number
                int guess = int.Parse(txtGuess.Text);
                int num = int.Parse(txtRandNum.Text);
                //int counter = int.Parse(txtCount.Text);
                //txtRandNum.Text = " " + counter.ToString();

                if (guess == num)
                    txtNumGen.Text = "Congratulations, You Win!";
                else if (guess < num)
                    txtNumGen.Text = "You guessed too low. Try again.";
                else if (guess > num)
                    txtNumGen.Text = "You guessed too high. Try again.";
            }
            catch
            {
                MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set focus to guess box
            txtGuess.Focus();

        }
    }
}