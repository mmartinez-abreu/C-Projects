using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear all fields after clear button clicked
            rdoAsc.Checked = false;
            rdoDesc.Checked = false;
            txtRes.Clear();
            txtSearch.Clear();
            rdoName.Checked = false;
            Listbx.Visible = false;
        }

        //class variables 
        const int SIZE = 16;
        string[] panName = new string[SIZE];
        string[] panYear = new string[SIZE];

        StreamReader inYears;


        private void Form1_Load(object sender, EventArgs e)
        {
            //show header at the top of the list box
            Listbx.Items.Add("Pandemic Name \t Year");

            //create variables
            //string[] pName = new string[SIZE];
            //string[] year = new string[SIZE];

            //read the contents of the file into the string array
            //readFile(pName, year);
            //populateListBox(pName, year);
            //sortAscending(pName, year);
            //sortDescending(pName, year);


  
        }

        //read the contents of the file
        private void readFile(string[] pName, string[] year)
        {
            //open file
            inYears = File.OpenText("PandemicsOverTime.txt");

            int index = 0;

            //loop through to read pandemic name file
            while (index < pName.Length && !inYears.EndOfStream)
            {
                pName[index] = inYears.ReadLine().Trim(' ');
                year[index] = inYears.ReadLine().Trim(' ');

                index++;

            }
            inYears.Close();
        }

        //populate the list box
        private void populateListBox(string[] pName, string[] year)
        {
            //clear the contents of the list
            Listbx.Items.Clear();
            Listbx.Items.AddRange(new object[] { "Pandemic Name", "" });
            for (int i = 0; i < pName.Length; i++)
            {
                Listbx.Items.AddRange(new object[] { pName[i] });
            }
            Listbx.Items.AddRange(new object[] { "Year", "" });
            for (int i = 0; i < year.Length; i++)
            {
                Listbx.Items.AddRange(new object[] { year[i] });
            }

        }

        //radio ascending button
        private void sortAscending(string[] pName, string[] year)
        {
            //sort the name and year in ascending order
            Array.Sort(pName, year);

        }

        //radio descending button
        private void sortDescending(string[] pName, string[] year)
        {
            //sort name in descending order
            sortAscending(pName, year);
            Array.Reverse(pName);
            Array.Reverse(year);
   
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void rdoName_CheckedChanged(object sender, EventArgs e)
        {
            rdoName.Enabled = true;
            Listbx.Items.Clear();
        }

        private void rdoDesc_CheckedChanged(object sender, EventArgs e)
        {
            sortDescending(panName, panYear);
            populateListBox(panName, panYear);
            rdoName.Enabled = false;

        }

        private void rdoAsc_CheckedChanged(object sender, EventArgs e)
        {
            sortAscending(panName, panYear);
            populateListBox(panName, panYear);
            rdoName.Enabled = false;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sortAscending(panName, panYear);
            int result = Array.BinarySearch(panName, panYear.Text, StringComparer.OrdinalIgnoreCase);
            if (result >= 0 && result <= panYear.Length)
                txtRes.Text = panYear[result];
            else
                txtRes.Text = "";
        }
    }
}
