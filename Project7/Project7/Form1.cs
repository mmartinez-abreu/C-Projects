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

namespace Project7
{
    public partial class InputFileInfo : Form
    {
        //class variables
        StreamReader inputFile;
        const int SIZE = 167;
        string[] ifile = new string[SIZE];

        public InputFileInfo()
        {
            InitializeComponent();
        }

        private void InputFileInfo_Load_1(object sender, EventArgs e)
        {
            txtResult.Enabled = false;
            txtSearch.Enabled = false;
            txtBoxFile.Visible = false;
            try
            {
                string file = "NoManIsAnIsland.txt";
                readFile(file, ifile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //read the input file
        private void readFile(string file, string[] ifile)
        {
            inputFile = File.OpenText(file);

            int index = 0;
            while (index < ifile.Length && !inputFile.EndOfStream)
            {
                ifile[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSFile_Click(object sender, EventArgs e)
        {
            populateListBox();
            this.Focus();

        }

        private void populateListBox()
        {
            txtResult.Enabled = true;
            txtSearch.Enabled = true;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                //convert the file into a string value
                string filePath = FileDialog.FileName;
                inputFile = File.OpenText(FileDialog.FileName);

                //display file name 
                txtFile.Text = FileDialog.FileName;

                //read all text from selected file
                txtBoxFile.Text = File.ReadAllText(filePath);

                //count number of wors in file
                int numWord = 0;
                int numspace = 0;
                int numpunc = 0;
                int numchar = 0;
                string allWords = txtBoxFile.Text;
                string allspace = " ";
                string allpunc = txtBoxFile.Text;
                string allchar = txtBoxFile.Text;
                string[] wordsArray = allWords.Split(' ');
                string[] spaceArray = allspace.Split(' ');
                string[] puncArray = allpunc.Split(',', '.', ';', '?', '!');
                string[] charArray = allchar.Split('a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k'
                    , 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ',', '.', ';', '?', '!');

                //loop through the file for words
                foreach (string word in wordsArray)
                {
                    if (!listbx.Items.Contains(word))
                    {
                        numWord++;
                    }
                }

                //loop through to find spaces
                foreach(string isWhiteSpace in spaceArray)
                {
                    if (!listbx.Items.Contains(isWhiteSpace))
                    {
                        numspace++;
                    }
                }

                //loop through to find punctuation
                foreach(string isPunc in puncArray)
                {
                    if(!listbx.Items.Contains(isPunc))
                    {
                        numpunc++;
                    }
                }

                //loop through to find characters
                foreach(string isChar in charArray)
                {
                    if(!listbx.Items.Contains(isChar))
                    {
                        numchar++;
                    }
                }
                //display the number of words in list box
                listbx.Items.Add("File Information" + FileDialog.FileName);
                listbx.Items.Add(" ");
                listbx.Items.Add(" ");
                listbx.Items.Add("Statistics:");
                listbx.Items.Add(" ");
                listbx.Items.Add(" ");
                listbx.Items.AddRange(new object[] { "Words:                            " + numWord });
                listbx.Items.Add("Spaces:                           " + numspace);
                listbx.Items.Add("Punctuation:                  " + numpunc);
                listbx.Items.Add("Characters(no spaces):  " + numchar);
            }
            else
            {
                MessageBox.Show("Operation canceled");
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtResult.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            substring();

        }

        private void substring()
        {
            int numFound = 0;

            string subString = txtSearch.Text;
            string[] subArray = subString.Split(' ');

            for (int i = 0; i < subString.Length; i++)
            {
                //loop through the file for words
                foreach (string word in subArray)
                {
                    if (txtBoxFile.Text.Contains(word))
                    {
                        numFound++;
                    }
                }
                //return numFound;
                txtResult.Text = numFound.ToString();

            }


        }

        /*private int findLetter(string file)
        {
            int numLet = 0;
            int index = 0;

            while (index < ifile.Length && !inputFile.EndOfStream)
            {
                foreach (char ch in filePath)
                {
                    if (char.IsLetter(ch))
                    {
                        numLet++;
                    }

                }
                return numLet;
            }

        }*/

        /*private int findWords(string file, string[] ifile)
        {
            int numWord = 0;
            Boolean wordBegin = false;
            //string str;

            for (int i = 0; i < ifile.Length; i++)
            {
                if(i == 0 && !char.IsWhiteSpace(file[i]))
                {
                    wordBegin = true;
                }
                else if(i > 0 && char.IsWhiteSpace(file[i - 1]))
                {
                    wordBegin = true;
                }
                else
                {
                    wordBegin = false;
                }

                if(wordBegin && (char.IsLetterOrDigit(file[i]) || char.IsPunctuation(file[i])))
                {
                    numWord++;
                }
            }
            return numWord;

        }*/
    }
}
