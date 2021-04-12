//Miguel Martinez
//COP2551.0M1
//Planet Facts
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetFacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //radio Mercury
        private void rdoMercury_CheckedChanged(object sender, EventArgs e)
        {
            //rdoMercury.Focus();

            //display moons
            if (chkMoon.Checked)
                lblMoons.Text = "Mercury has no moons";
            else
                lblMoons.Text = "";

            //display distance
            if (chkDistance.Checked)
                lblDistance.Text = "Mercury is 29.538 million mi away";
            else
                lblDistance.Text = "";

            //display time
            if (chkTime.Checked)
                lblTime.Text = "40 days";
            else
                lblTime.Text = "";

            //display day
            if (chkDay.Checked)
                lblDay.Text = "One day takes 58 earth days";
            else
                lblDay.Text = "";

            //display year
            if (chkYear.Checked)
                lblYear.Text = "One year is 88 earth days";
            else
                lblYear.Text = "";

            //display image
            if (chkImage.Checked)
                picPlanet.Image = Properties.Resources.mercury1;
            else
                picPlanet.Image = Properties.Resources.cosmic_art_science_fiction_wallpaper;

        }

        //radio Venus
        private void rdoVenus_CheckedChanged(object sender, EventArgs e)
        {
            //display moons
            if (chkMoon.Checked)
                lblMoons.Text = "Venus has no moons";
            else
                lblMoons.Text = "";

            //display ditance
            if (chkDistance.Checked)
                lblDistance.Text = "Venus is 154.22 million mi away";
            else
                lblDistance.Text = "";

            //display time
            if (chkTime.Checked)
                lblTime.Text = "225 days";
            else
                lblTime.Text = "";

            //display day
            if (chkDay.Checked)
                lblDay.Text = "One day takes 116 earth days";
            else
                lblDay.Text = "";

            //display year
            if (chkYear.Checked)
                lblYear.Text = "One year is 225 earth days";
            else
                lblYear.Text = "";

            //display image
            if (chkImage.Checked)
                picPlanet.Image = Properties.Resources.venus1;
            else
                picPlanet.Image = Properties.Resources.cosmic_art_science_fiction_wallpaper;
        }

        // radio earth 
        private void rdoEarth_CheckedChanged(object sender, EventArgs e)
        {
            //display moons
            if (chkMoon.Checked)
                lblMoons.Text = "Earth has one moons";
            else
                lblMoons.Text = "";

            //display ditance
            if (chkDistance.Checked)
                lblDistance.Text = "Earth is 91.633 million mi away";
            else
                lblDistance.Text = "";

            //display time
            if (chkTime.Checked)
                lblTime.Text = "365 days";
            else
                lblTime.Text = "";

            //display day
            if (chkDay.Checked)
                lblDay.Text = "24 hours";
            else
                lblDay.Text = "";

            //display year
            if (chkYear.Checked)
                lblYear.Text = "365 days";
            else
                lblYear.Text = "";

            //display image
            if (chkImage.Checked)
                picPlanet.Image = Properties.Resources.earth2;
            else
                picPlanet.Image = Properties.Resources.cosmic_art_science_fiction_wallpaper;
        }

        //radio mars
        private void rdoMars_CheckedChanged(object sender, EventArgs e)
        {
            //display moons
            if (chkMoon.Checked)
                lblMoons.Text = "Mars has two moons";
            else
                lblMoons.Text = "";

            //display ditance
            if (chkDistance.Checked)
                lblDistance.Text = "Mars is 114.11 million mi away";
            else
                lblDistance.Text = "";

            //display time
            if (chkTime.Checked)
                lblTime.Text = "687 days";
            else
                lblTime.Text = "";

            //display day
            if (chkDay.Checked)
                lblDay.Text = "1 day 37 minutes";
            else
                lblDay.Text = "";

            //display year
            if (chkYear.Checked)
                lblYear.Text = "687 days";
            else
                lblYear.Text = "";

            //display image
            if (chkImage.Checked)
                picPlanet.Image = Properties.Resources.mars1;
            else
                picPlanet.Image = Properties.Resources.cosmic_art_science_fiction_wallpaper;
        }

        //radio jupiter
        private void rdoJupiter_CheckedChanged(object sender, EventArgs e)
        {
            //display moons
            if (chkMoon.Checked)
                lblMoons.Text = "Jupiter has 79 moons";
            else
                lblMoons.Text = "";

            //display ditance
            if (chkDistance.Checked)
                lblDistance.Text = "Jupiter is 564.19 million mi away";
            else
                lblDistance.Text = "";

            //display time
            if (chkTime.Checked)
                lblTime.Text = "12 years";
            else
                lblTime.Text = "";

            //display day
            if (chkDay.Checked)
                lblDay.Text = "9 hours 56 min";
            else
                lblDay.Text = "";

            //display year
            if (chkYear.Checked)
                lblYear.Text = "12 years";
            else
                lblYear.Text = "";

            //display image
            if (chkImage.Checked)
                picPlanet.Image = Properties.Resources.jupiter1;
            else
                picPlanet.Image = Properties.Resources.cosmic_art_science_fiction_wallpaper;
        }

        //radio saturn
        private void rdoSaturn_CheckedChanged(object sender, EventArgs e)
        {
            //display moons
            if (chkMoon.Checked)
                lblMoons.Text = "Saturn has 82 moons";
            else
                lblMoons.Text = "";

            //display ditance
            if (chkDistance.Checked)
                lblDistance.Text = "Saturn is 1.0164 billion mi away";
            else
                lblDistance.Text = "";

            //display time
            if (chkTime.Checked)
                lblTime.Text = "29 years";
            else
                lblTime.Text = "";

            //display day
            if (chkDay.Checked)
                lblDay.Text = "10 hours 42 min";
            else
                lblDay.Text = "";

            //display year
            if (chkYear.Checked)
                lblYear.Text = "29 years";
            else
                lblYear.Text = "";

            //display image
            if (chkImage.Checked)
                picPlanet.Image = Properties.Resources.saturn1;
            else
                picPlanet.Image = Properties.Resources.cosmic_art_science_fiction_wallpaper;
        }

        //radio uranus
        private void rdoUranus_CheckedChanged(object sender, EventArgs e)
        {
            //display moons
            if (chkMoon.Checked)
                lblMoons.Text = "Uranus has 27 moons";
            else
                lblMoons.Text = "";

            //display ditance
            if (chkDistance.Checked)
                lblDistance.Text = "Uranus is 1.8484 billion mi away";
            else
                lblDistance.Text = "";

            //display time
            if (chkTime.Checked)
                lblTime.Text = "84 years";
            else
                lblTime.Text = "";

            //display day
            if (chkDay.Checked)
                lblDay.Text = "17 hours 14 min";
            else
                lblDay.Text = "";

            //display year
            if (chkYear.Checked)
                lblYear.Text = "84 years";
            else
                lblYear.Text = "";

            //display image
            if (chkImage.Checked)
                picPlanet.Image = Properties.Resources.uranus1;
            else
                picPlanet.Image = Properties.Resources.cosmic_art_science_fiction_wallpaper;
        }

        //radio neptune
        private void rdoNeptune_CheckedChanged(object sender, EventArgs e)
        {
            //display moons
            if (chkMoon.Checked)
                lblMoons.Text = "Neptune has 14 moons";
            else
                lblMoons.Text = "";

            //display ditance
            if (chkDistance.Checked)
                lblDistance.Text = "Neptune is 2.8566 billion mi away";
            else
                lblDistance.Text = "";

            //display time
            if (chkTime.Checked)
                lblTime.Text = "165 years";
            else
                lblTime.Text = "";

            //display day
            if (chkDay.Checked)
                lblDay.Text = "16 hours 6 min";
            else
                lblDay.Text = "";

            //display year
            if (chkYear.Checked)
                lblYear.Text = "165 years";
            else
                lblYear.Text = "";

            //display image
            if (chkImage.Checked)
                picPlanet.Image = Properties.Resources.neptune1;
            else
                picPlanet.Image = Properties.Resources.cosmic_art_science_fiction_wallpaper;
        }

        //Mercury Check Moon
        private void chkMoon_CheckedChanged(object sender, EventArgs e)
        {
            //which radio button has been selected
            if (chkMoon.Checked)
            {
                if (rdoMercury.Checked)
                    lblMoons.Text = "Mercury has no moons";
                else if (rdoMars.Checked)
                    lblMoons.Text = "Mars has two moons";
                else if (rdoJupiter.Checked)
                    lblMoons.Text = "Jupiter has 79 moons";
                else if (rdoSaturn.Checked)
                    lblMoons.Text = "Saturn has 82 moons";
                else if (rdoEarth.Checked)
                    lblMoons.Text = "Earth has one moon";
                else if (rdoUranus.Checked)
                    lblMoons.Text = "Uranus has 27 moons";
                else if (rdoNeptune.Checked)
                    lblMoons.Text = "Neptune has 14 moons";
                else if (rdoVenus.Checked)
                    lblMoons.Text = "Venus has no moons";

            }
            else lblMoons.Text = "";
        }

        //Check Distance
        private void chkDistance_CheckedChanged(object sender, EventArgs e)
        {
            //which radio button has been selected
            if (chkDistance.Checked)
            {
                if (rdoMercury.Checked)
                    lblDistance.Text = "Mercury is 29.555 million mi away";
                else if (rdoMars.Checked)
                    lblDistance.Text = "Mars is 114.11 million mi away";
                else if (rdoJupiter.Checked)
                    lblDistance.Text = "Jupiter is 564.19 million mi away";
                else if (rdoSaturn.Checked)
                    lblDistance.Text = "Saturn is 1.0164 billion mi away";
                else if (rdoEarth.Checked)
                    lblDistance.Text = "Earth is 91.633 million mi away";
                else if (rdoUranus.Checked)
                    lblDistance.Text = "Uranus is 1.8484 billion mi away";
                else if (rdoNeptune.Checked)
                    lblDistance.Text = "Neptune is 2.8566 billion mi away";
                else if (rdoVenus.Checked)
                    lblDistance.Text = "Venus is 154.22 million mi away";

            }
            else lblDistance.Text = "";

        }

        //Check Time
        private void chkTime_CheckedChanged(object sender, EventArgs e)
        {
            //which radio button has been selected
            if (chkTime.Checked)
            {
                if (rdoMercury.Checked)
                    lblTime.Text = "40 days";
                else if (rdoMars.Checked)
                    lblTime.Text = "687 days";
                else if (rdoJupiter.Checked)
                    lblTime.Text = "12 years";
                else if (rdoSaturn.Checked)
                    lblTime.Text = "29 years";
                else if (rdoEarth.Checked)
                    lblTime.Text = "365 days";
                else if (rdoUranus.Checked)
                    lblTime.Text = "84 years";
                else if (rdoNeptune.Checked)
                    lblTime.Text = "165 years";
                else if (rdoVenus.Checked)
                    lblTime.Text = "225 days";

            }
            else lblTime.Text = "";

        }

        //Check Day
        private void chkDay_CheckedChanged(object sender, EventArgs e)
        {
            //which radio button has been selected
            if (chkDay.Checked)
            {
                if (rdoMercury.Checked)
                    lblDay.Text = "One day takes 58 earth days";
                else if (rdoMars.Checked)
                    lblDay.Text = "1 day 37 minutes";
                else if (rdoJupiter.Checked)
                    lblDay.Text = "9 hours 56 min";
                else if (rdoSaturn.Checked)
                    lblDay.Text = "10 hours 42 min";
                else if (rdoEarth.Checked)
                    lblDay.Text = "24 hours";
                else if (rdoUranus.Checked)
                    lblDay.Text = "17 hours 14 min";
                else if (rdoNeptune.Checked)
                    lblDay.Text = "16 hours 6 min";
                else if (rdoVenus.Checked)
                    lblDay.Text = "One day takes 116 earth days";

            }
            else lblDay.Text = "";

        }

        //Check Year
        private void chkYear_CheckedChanged(object sender, EventArgs e)
        {
            //which radio button has been selected
            if (chkYear.Checked)
            {
                if (rdoMercury.Checked)
                    lblYear.Text = "One year is 88 earth days";
                else if (rdoMars.Checked)
                    lblYear.Text = "687 days";
                else if (rdoJupiter.Checked)
                    lblYear.Text = "12 years";
                else if (rdoSaturn.Checked)
                    lblYear.Text = "29 years";
                else if (rdoEarth.Checked)
                    lblYear.Text = "365 days";
                else if (rdoUranus.Checked)
                    lblYear.Text = "84 years";
                else if (rdoNeptune.Checked)
                    lblYear.Text = "165 years";
                else if (rdoVenus.Checked)
                    lblYear.Text = "One year is 225 earth days";
               
            }
            else lblYear.Text = "";

        }

        //Check Image
        private void chkImage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImage.Checked)
            {
                if (rdoMercury.Checked)
                    picPlanet.Image = Properties.Resources.mercury1;
                else if (rdoMars.Checked)
                    picPlanet.Image = Properties.Resources.mars1;
                else if (rdoJupiter.Checked)
                    picPlanet.Image = Properties.Resources.jupiter1;
                else if (rdoSaturn.Checked)
                    picPlanet.Image = Properties.Resources.saturn1;
                else if (rdoEarth.Checked)
                    picPlanet.Image = Properties.Resources.earth2;
                else if (rdoUranus.Checked)
                    picPlanet.Image = Properties.Resources.uranus1;
                else if (rdoNeptune.Checked)
                    picPlanet.Image = Properties.Resources.neptune1;
                else if (rdoVenus.Checked)
                    picPlanet.Image = Properties.Resources.venus1;
            }
            else picPlanet.Image = Properties.Resources.cosmic_art_science_fiction_wallpaper;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
       
            //display chk
            chkDay.Checked= false;
            chkTime.Checked = false;
            chkYear.Checked = false;
            chkMoon.Checked = false;
            chkImage.Checked = false;
            chkDistance.Checked = false;

            //display rdo check
            //rdoMercury.Checked = true;
            rdoMercury.Focus();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCros_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoCheckedLoad(object sender, EventArgs e)
        {
            //rdoMercury.Checked = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

        }
    }
}
