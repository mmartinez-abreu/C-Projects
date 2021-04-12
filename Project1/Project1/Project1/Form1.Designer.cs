
namespace Project1
{
    partial class Orion
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
            this.picOrion = new System.Windows.Forms.PictureBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.lblBetel = new System.Windows.Forms.Label();
            this.lblAlnitak = new System.Windows.Forms.Label();
            this.lblSaiph = new System.Windows.Forms.Label();
            this.lblAlnilam = new System.Windows.Forms.Label();
            this.lblMintaka = new System.Windows.Forms.Label();
            this.lblRigel = new System.Windows.Forms.Label();
            this.lblBellatrix = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOrion)).BeginInit();
            this.SuspendLayout();
            // 
            // picOrion
            // 
            this.picOrion.Image = global::Project1.Properties.Resources.Orion;
            this.picOrion.InitialImage = null;
            this.picOrion.Location = new System.Drawing.Point(273, 102);
            this.picOrion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picOrion.Name = "picOrion";
            this.picOrion.Size = new System.Drawing.Size(654, 505);
            this.picOrion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrion.TabIndex = 0;
            this.picOrion.TabStop = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDisplay.Location = new System.Drawing.Point(444, 615);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(144, 68);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHide.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(597, 615);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(144, 68);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(334, 18);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(541, 78);
            this.title.TabIndex = 3;
            this.title.Text = "Orion Constellation";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBetel
            // 
            this.lblBetel.AutoSize = true;
            this.lblBetel.BackColor = System.Drawing.Color.Ivory;
            this.lblBetel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetel.Location = new System.Drawing.Point(440, 177);
            this.lblBetel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetel.Name = "lblBetel";
            this.lblBetel.Size = new System.Drawing.Size(103, 22);
            this.lblBetel.TabIndex = 11;
            this.lblBetel.Text = "Betelgeuse";
            this.lblBetel.Visible = false;
            this.lblBetel.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblAlnitak
            // 
            this.lblAlnitak.AutoSize = true;
            this.lblAlnitak.BackColor = System.Drawing.Color.Ivory;
            this.lblAlnitak.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlnitak.Location = new System.Drawing.Point(490, 368);
            this.lblAlnitak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlnitak.Name = "lblAlnitak";
            this.lblAlnitak.Size = new System.Drawing.Size(71, 22);
            this.lblAlnitak.TabIndex = 12;
            this.lblAlnitak.Text = "Alnitak";
            this.lblAlnitak.Visible = false;
            this.lblAlnitak.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblSaiph
            // 
            this.lblSaiph.AutoSize = true;
            this.lblSaiph.BackColor = System.Drawing.Color.Ivory;
            this.lblSaiph.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaiph.Location = new System.Drawing.Point(423, 525);
            this.lblSaiph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaiph.Name = "lblSaiph";
            this.lblSaiph.Size = new System.Drawing.Size(57, 22);
            this.lblSaiph.TabIndex = 13;
            this.lblSaiph.Text = "Saiph";
            this.lblSaiph.Visible = false;
            this.lblSaiph.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblAlnilam
            // 
            this.lblAlnilam.AutoSize = true;
            this.lblAlnilam.BackColor = System.Drawing.Color.Ivory;
            this.lblAlnilam.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlnilam.Location = new System.Drawing.Point(572, 352);
            this.lblAlnilam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlnilam.Name = "lblAlnilam";
            this.lblAlnilam.Size = new System.Drawing.Size(75, 22);
            this.lblAlnilam.TabIndex = 14;
            this.lblAlnilam.Text = "Alnilam";
            this.lblAlnilam.Visible = false;
            this.lblAlnilam.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblMintaka
            // 
            this.lblMintaka.AutoSize = true;
            this.lblMintaka.BackColor = System.Drawing.Color.Ivory;
            this.lblMintaka.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMintaka.Location = new System.Drawing.Point(646, 337);
            this.lblMintaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMintaka.Name = "lblMintaka";
            this.lblMintaka.Size = new System.Drawing.Size(80, 22);
            this.lblMintaka.TabIndex = 15;
            this.lblMintaka.Text = "Mintaka";
            this.lblMintaka.Visible = false;
            this.lblMintaka.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblRigel
            // 
            this.lblRigel.AutoSize = true;
            this.lblRigel.BackColor = System.Drawing.Color.Ivory;
            this.lblRigel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRigel.Location = new System.Drawing.Point(741, 489);
            this.lblRigel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRigel.Name = "lblRigel";
            this.lblRigel.Size = new System.Drawing.Size(52, 22);
            this.lblRigel.TabIndex = 16;
            this.lblRigel.Text = "Rigel";
            this.lblRigel.Visible = false;
            this.lblRigel.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lblBellatrix
            // 
            this.lblBellatrix.AutoSize = true;
            this.lblBellatrix.BackColor = System.Drawing.Color.Ivory;
            this.lblBellatrix.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBellatrix.Location = new System.Drawing.Point(741, 205);
            this.lblBellatrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBellatrix.Name = "lblBellatrix";
            this.lblBellatrix.Size = new System.Drawing.Size(80, 22);
            this.lblBellatrix.TabIndex = 17;
            this.lblBellatrix.Text = "Bellatrix";
            this.lblBellatrix.Visible = false;
            this.lblBellatrix.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(597, 692);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 68);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(444, 692);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 68);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Orion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::Project1.Properties.Resources.resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1176, 850);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblBellatrix);
            this.Controls.Add(this.lblRigel);
            this.Controls.Add(this.lblMintaka);
            this.Controls.Add(this.lblAlnilam);
            this.Controls.Add(this.lblSaiph);
            this.Controls.Add(this.lblAlnitak);
            this.Controls.Add(this.lblBetel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.picOrion);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Orion";
            this.Text = "Orion";
            ((System.ComponentModel.ISupportInitialize)(this.picOrion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOrion;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblBetel;
        private System.Windows.Forms.Label lblAlnitak;
        private System.Windows.Forms.Label lblSaiph;
        private System.Windows.Forms.Label lblAlnilam;
        private System.Windows.Forms.Label lblMintaka;
        private System.Windows.Forms.Label lblRigel;
        private System.Windows.Forms.Label lblBellatrix;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

