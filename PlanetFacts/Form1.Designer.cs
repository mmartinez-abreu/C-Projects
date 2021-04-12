
namespace PlanetFacts
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxPlanet = new System.Windows.Forms.GroupBox();
            this.rdoNeptune = new System.Windows.Forms.RadioButton();
            this.rdoUranus = new System.Windows.Forms.RadioButton();
            this.rdoSaturn = new System.Windows.Forms.RadioButton();
            this.rdoJupiter = new System.Windows.Forms.RadioButton();
            this.rdoMars = new System.Windows.Forms.RadioButton();
            this.rdoEarth = new System.Windows.Forms.RadioButton();
            this.rdoVenus = new System.Windows.Forms.RadioButton();
            this.rdoMercury = new System.Windows.Forms.RadioButton();
            this.gbxFacts = new System.Windows.Forms.GroupBox();
            this.chkImage = new System.Windows.Forms.CheckBox();
            this.chkYear = new System.Windows.Forms.CheckBox();
            this.chkDay = new System.Windows.Forms.CheckBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.chkDistance = new System.Windows.Forms.CheckBox();
            this.chkMoon = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCros = new System.Windows.Forms.Button();
            this.lblMoons = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.picPlanet = new System.Windows.Forms.PictureBox();
            this.gbxPlanet.SuspendLayout();
            this.gbxFacts.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fun Planet Facts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(238, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select a planet and the information you want to see!";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Location = new System.Drawing.Point(319, 477);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 47);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Location = new System.Drawing.Point(453, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 47);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // gbxPlanet
            // 
            this.gbxPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbxPlanet.Controls.Add(this.rdoNeptune);
            this.gbxPlanet.Controls.Add(this.rdoUranus);
            this.gbxPlanet.Controls.Add(this.rdoSaturn);
            this.gbxPlanet.Controls.Add(this.rdoJupiter);
            this.gbxPlanet.Controls.Add(this.rdoMars);
            this.gbxPlanet.Controls.Add(this.rdoEarth);
            this.gbxPlanet.Controls.Add(this.rdoVenus);
            this.gbxPlanet.Controls.Add(this.rdoMercury);
            this.gbxPlanet.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPlanet.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxPlanet.Location = new System.Drawing.Point(30, 161);
            this.gbxPlanet.Name = "gbxPlanet";
            this.gbxPlanet.Size = new System.Drawing.Size(266, 336);
            this.gbxPlanet.TabIndex = 7;
            this.gbxPlanet.TabStop = false;
            this.gbxPlanet.Text = "Planet";
            // 
            // rdoNeptune
            // 
            this.rdoNeptune.AutoSize = true;
            this.rdoNeptune.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNeptune.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoNeptune.Location = new System.Drawing.Point(13, 278);
            this.rdoNeptune.Name = "rdoNeptune";
            this.rdoNeptune.Size = new System.Drawing.Size(95, 24);
            this.rdoNeptune.TabIndex = 7;
            this.rdoNeptune.TabStop = true;
            this.rdoNeptune.Text = "&Neptune";
            this.rdoNeptune.UseVisualStyleBackColor = true;
            this.rdoNeptune.CheckedChanged += new System.EventHandler(this.rdoNeptune_CheckedChanged);
            // 
            // rdoUranus
            // 
            this.rdoUranus.AutoSize = true;
            this.rdoUranus.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUranus.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoUranus.Location = new System.Drawing.Point(13, 243);
            this.rdoUranus.Name = "rdoUranus";
            this.rdoUranus.Size = new System.Drawing.Size(82, 24);
            this.rdoUranus.TabIndex = 6;
            this.rdoUranus.TabStop = true;
            this.rdoUranus.Text = "&Uranus";
            this.rdoUranus.UseVisualStyleBackColor = true;
            this.rdoUranus.CheckedChanged += new System.EventHandler(this.rdoUranus_CheckedChanged);
            // 
            // rdoSaturn
            // 
            this.rdoSaturn.AutoSize = true;
            this.rdoSaturn.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSaturn.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoSaturn.Location = new System.Drawing.Point(13, 209);
            this.rdoSaturn.Name = "rdoSaturn";
            this.rdoSaturn.Size = new System.Drawing.Size(78, 24);
            this.rdoSaturn.TabIndex = 5;
            this.rdoSaturn.TabStop = true;
            this.rdoSaturn.Text = "&Saturn";
            this.rdoSaturn.UseVisualStyleBackColor = true;
            this.rdoSaturn.CheckedChanged += new System.EventHandler(this.rdoSaturn_CheckedChanged);
            // 
            // rdoJupiter
            // 
            this.rdoJupiter.AutoSize = true;
            this.rdoJupiter.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoJupiter.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoJupiter.Location = new System.Drawing.Point(13, 174);
            this.rdoJupiter.Name = "rdoJupiter";
            this.rdoJupiter.Size = new System.Drawing.Size(80, 24);
            this.rdoJupiter.TabIndex = 4;
            this.rdoJupiter.TabStop = true;
            this.rdoJupiter.Text = "&Jupiter";
            this.rdoJupiter.UseVisualStyleBackColor = true;
            this.rdoJupiter.CheckedChanged += new System.EventHandler(this.rdoJupiter_CheckedChanged);
            // 
            // rdoMars
            // 
            this.rdoMars.AutoSize = true;
            this.rdoMars.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMars.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoMars.Location = new System.Drawing.Point(13, 140);
            this.rdoMars.Name = "rdoMars";
            this.rdoMars.Size = new System.Drawing.Size(65, 24);
            this.rdoMars.TabIndex = 3;
            this.rdoMars.TabStop = true;
            this.rdoMars.Text = "M&ars";
            this.rdoMars.UseVisualStyleBackColor = true;
            this.rdoMars.CheckedChanged += new System.EventHandler(this.rdoMars_CheckedChanged);
            // 
            // rdoEarth
            // 
            this.rdoEarth.AutoSize = true;
            this.rdoEarth.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEarth.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoEarth.Location = new System.Drawing.Point(13, 105);
            this.rdoEarth.Name = "rdoEarth";
            this.rdoEarth.Size = new System.Drawing.Size(68, 24);
            this.rdoEarth.TabIndex = 2;
            this.rdoEarth.TabStop = true;
            this.rdoEarth.Text = "&Earth";
            this.rdoEarth.UseVisualStyleBackColor = true;
            this.rdoEarth.CheckedChanged += new System.EventHandler(this.rdoEarth_CheckedChanged);
            // 
            // rdoVenus
            // 
            this.rdoVenus.AutoSize = true;
            this.rdoVenus.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVenus.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoVenus.Location = new System.Drawing.Point(13, 70);
            this.rdoVenus.Name = "rdoVenus";
            this.rdoVenus.Size = new System.Drawing.Size(75, 24);
            this.rdoVenus.TabIndex = 1;
            this.rdoVenus.TabStop = true;
            this.rdoVenus.Text = "&Venus";
            this.rdoVenus.UseVisualStyleBackColor = true;
            this.rdoVenus.CheckedChanged += new System.EventHandler(this.rdoVenus_CheckedChanged);
            // 
            // rdoMercury
            // 
            this.rdoMercury.AutoSize = true;
            this.rdoMercury.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMercury.ForeColor = System.Drawing.Color.Gainsboro;
            this.rdoMercury.Location = new System.Drawing.Point(13, 36);
            this.rdoMercury.Name = "rdoMercury";
            this.rdoMercury.Size = new System.Drawing.Size(91, 24);
            this.rdoMercury.TabIndex = 0;
            this.rdoMercury.TabStop = true;
            this.rdoMercury.Text = "&Mercury";
            this.rdoMercury.UseVisualStyleBackColor = true;
            this.rdoMercury.CheckedChanged += new System.EventHandler(this.rdoMercury_CheckedChanged);
            // 
            // gbxFacts
            // 
            this.gbxFacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbxFacts.Controls.Add(this.chkImage);
            this.gbxFacts.Controls.Add(this.chkYear);
            this.gbxFacts.Controls.Add(this.chkDay);
            this.gbxFacts.Controls.Add(this.chkTime);
            this.gbxFacts.Controls.Add(this.chkDistance);
            this.gbxFacts.Controls.Add(this.chkMoon);
            this.gbxFacts.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFacts.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxFacts.Location = new System.Drawing.Point(606, 161);
            this.gbxFacts.Name = "gbxFacts";
            this.gbxFacts.Size = new System.Drawing.Size(266, 336);
            this.gbxFacts.TabIndex = 0;
            this.gbxFacts.TabStop = false;
            this.gbxFacts.Text = "Facts";
            // 
            // chkImage
            // 
            this.chkImage.AutoSize = true;
            this.chkImage.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImage.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkImage.Location = new System.Drawing.Point(23, 269);
            this.chkImage.Name = "chkImage";
            this.chkImage.Size = new System.Drawing.Size(77, 24);
            this.chkImage.TabIndex = 13;
            this.chkImage.Text = "&Image";
            this.chkImage.UseVisualStyleBackColor = true;
            this.chkImage.CheckedChanged += new System.EventHandler(this.chkImage_CheckedChanged);
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYear.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkYear.Location = new System.Drawing.Point(23, 225);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(178, 24);
            this.chkYear.TabIndex = 12;
            this.chkYear.Text = "Length of one &year";
            this.chkYear.UseVisualStyleBackColor = true;
            this.chkYear.CheckedChanged += new System.EventHandler(this.chkYear_CheckedChanged);
            // 
            // chkDay
            // 
            this.chkDay.AutoSize = true;
            this.chkDay.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDay.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkDay.Location = new System.Drawing.Point(23, 181);
            this.chkDay.Name = "chkDay";
            this.chkDay.Size = new System.Drawing.Size(171, 24);
            this.chkDay.TabIndex = 11;
            this.chkDay.Text = "&Length of one day";
            this.chkDay.UseVisualStyleBackColor = true;
            this.chkDay.CheckedChanged += new System.EventHandler(this.chkDay_CheckedChanged);
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkTime.Location = new System.Drawing.Point(23, 136);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(122, 24);
            this.chkTime.TabIndex = 10;
            this.chkTime.Text = "&Travel Time";
            this.chkTime.UseVisualStyleBackColor = true;
            this.chkTime.CheckedChanged += new System.EventHandler(this.chkTime_CheckedChanged);
            // 
            // chkDistance
            // 
            this.chkDistance.AutoSize = true;
            this.chkDistance.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDistance.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkDistance.Location = new System.Drawing.Point(23, 92);
            this.chkDistance.Name = "chkDistance";
            this.chkDistance.Size = new System.Drawing.Size(203, 24);
            this.chkDistance.TabIndex = 9;
            this.chkDistance.Text = "&Distance from the sun";
            this.chkDistance.UseVisualStyleBackColor = true;
            this.chkDistance.CheckedChanged += new System.EventHandler(this.chkDistance_CheckedChanged);
            // 
            // chkMoon
            // 
            this.chkMoon.AutoSize = true;
            this.chkMoon.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMoon.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkMoon.Location = new System.Drawing.Point(23, 48);
            this.chkMoon.Name = "chkMoon";
            this.chkMoon.Size = new System.Drawing.Size(80, 24);
            this.chkMoon.TabIndex = 8;
            this.chkMoon.Text = "M&oons";
            this.chkMoon.UseVisualStyleBackColor = true;
            this.chkMoon.CheckedChanged += new System.EventHandler(this.chkMoon_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnCros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 115);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCros
            // 
            this.btnCros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCros.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCros.FlatAppearance.BorderSize = 0;
            this.btnCros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCros.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCros.Location = new System.Drawing.Point(810, 0);
            this.btnCros.Name = "btnCros";
            this.btnCros.Size = new System.Drawing.Size(90, 115);
            this.btnCros.TabIndex = 16;
            this.btnCros.Text = "X";
            this.btnCros.UseVisualStyleBackColor = false;
            this.btnCros.Click += new System.EventHandler(this.btnCros_Click);
            // 
            // lblMoons
            // 
            this.lblMoons.AutoSize = true;
            this.lblMoons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblMoons.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoons.Location = new System.Drawing.Point(316, 350);
            this.lblMoons.Name = "lblMoons";
            this.lblMoons.Size = new System.Drawing.Size(0, 16);
            this.lblMoons.TabIndex = 10;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblDistance.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(316, 372);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(0, 16);
            this.lblDistance.TabIndex = 11;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblTime.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(316, 394);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 16);
            this.lblTime.TabIndex = 12;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblDay.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(316, 416);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(0, 16);
            this.lblDay.TabIndex = 13;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblYear.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(316, 438);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 16);
            this.lblYear.TabIndex = 14;
            // 
            // picPlanet
            // 
            this.picPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picPlanet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlanet.Location = new System.Drawing.Point(300, 161);
            this.picPlanet.Name = "picPlanet";
            this.picPlanet.Size = new System.Drawing.Size(300, 184);
            this.picPlanet.TabIndex = 2;
            this.picPlanet.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BackgroundImage = global::PlanetFacts.Properties.Resources.cosmic_art_science_fiction_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.lblMoons);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxFacts);
            this.Controls.Add(this.gbxPlanet);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picPlanet);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "Form1";
            this.Text = "Planet Facts";
            this.gbxPlanet.ResumeLayout(false);
            this.gbxPlanet.PerformLayout();
            this.gbxFacts.ResumeLayout(false);
            this.gbxFacts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPlanet;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxPlanet;
        private System.Windows.Forms.RadioButton rdoNeptune;
        private System.Windows.Forms.RadioButton rdoUranus;
        private System.Windows.Forms.RadioButton rdoSaturn;
        private System.Windows.Forms.RadioButton rdoJupiter;
        private System.Windows.Forms.RadioButton rdoMars;
        private System.Windows.Forms.RadioButton rdoEarth;
        private System.Windows.Forms.RadioButton rdoVenus;
        private System.Windows.Forms.RadioButton rdoMercury;
        private System.Windows.Forms.GroupBox gbxFacts;
        private System.Windows.Forms.CheckBox chkImage;
        private System.Windows.Forms.CheckBox chkYear;
        private System.Windows.Forms.CheckBox chkDay;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.CheckBox chkDistance;
        private System.Windows.Forms.CheckBox chkMoon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCros;
        private System.Windows.Forms.Label lblMoons;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblYear;
    }
}

