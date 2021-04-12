using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global veriables
        string rock = "Rock";
        string paper = "Paper";
        string sciss = "Scissors";

        private void Form1_Load(object sender, EventArgs e)
        {
            pickRandomNumber();
            //dontshowRobot();
        }

        public void pickRandomNumber()
        {
            //local variable
            int num;

            //do not show the robots selection
            dontshowRobot();

            Random objRandom = new Random();
            //generate random number
            num = objRandom.Next(1, 4);

            //output for random number
            if (num == 1)
                txtRobot.Text = rock;
            else if (num == 2)
                txtRobot.Text = paper;
            else if (num == 3)
                txtRobot.Text = sciss;
            else
                txtRobot.Text = "";
            
        }

        public void dontshowRobot()
        {
            //do not show the robot selection
            txtRobot.Visible = false;
        }
        public void showRobot()
        {
            //show robot selection
            txtRobot.Visible = true;
        }
        //radio button selected
        private void rdoRock_CheckedChanged(object sender, EventArgs e)
        {
            rdoRockbtn();
        }

        public void rdoRockbtn()
        {
            if (rdoRock.Checked)
                txtUser.Text = rock;
            else
                txtUser.Text = "";
        }

        //radio paper selected
        private void rdoPaper_CheckedChanged(object sender, EventArgs e)
        {
            rdoPaperbtn();
        }

        public void rdoPaperbtn()
        {
            if (rdoPaper.Checked)
                txtUser.Text = paper;
            else
                txtUser.Text = "";
        }

        //radio scissors selected
        private void rdoSciss_CheckedChanged(object sender, EventArgs e)
        {
            rdoScissbtn();
        }

        public void rdoScissbtn()
        {
            if (rdoSciss.Checked)
                txtUser.Text = sciss;
            else
                txtUser.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            checkIfWin();
        }

        //check each result
        public void checkIfWin()
        {
            if (txtUser.Text == txtRobot.Text)
            {
                lblResult.Text = "It was a tie, try again!";
                showRobot();
            }
            else if (txtUser.Text == rock && txtRobot.Text == paper)
            {
                lblResult.Text = "Paper eats Rock, you lose.";
                showRobot();
            }
            else if (txtUser.Text == paper && txtRobot.Text == rock)
            {
                lblResult.Text = "Congratulations, Paper eats Rock, you win!";
                showRobot();
            }
            else if (txtUser.Text == sciss && txtRobot.Text == rock)
            {
                lblResult.Text = "Rock breaks Scissors, you lose.";
                showRobot();
            }
            else if (txtUser.Text == rock && txtRobot.Text == sciss)
            {
                lblResult.Text = "Congratulations, Rock breaks Scissors, you win!";
                showRobot();
            }

            else if (txtUser.Text == paper && txtRobot.Text == sciss)
            {
                lblResult.Text = "Scissors cuts Paper, you lose.";
                showRobot();
            }
            else if (txtUser.Text == sciss && txtRobot.Text == paper)
            {
                lblResult.Text = "Congratulations, Scissors cuts Paper, you win!";
                showRobot();
            }
            else
                lblResult.Text = "";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearbtn();
        }

        public void clearbtn()
        {
            //clear all fields
            txtUser.Text = "";
            txtRobot.Text = "";
            lblResult.Text = "";

            //pick random number
            pickRandomNumber();

            //set focus to rdo button selection
            txtUser.Select();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
