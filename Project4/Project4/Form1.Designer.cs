
namespace Project4
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumGen = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnGuessed = new System.Windows.Forms.Button();
            this.txtRandNum = new System.Windows.Forms.TextBox();
            this.lblRandNum = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.lblmid = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblGen = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.lblPlay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleName = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(360, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(525, 87);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Guess it Right!";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleName = "btnClear";
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(375, 629);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(239, 60);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-196, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleName = "btnExit";
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(643, 629);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(239, 60);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtNumGen);
            this.panel1.Controls.Add(this.txtCount);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.btnGuessed);
            this.panel1.Controls.Add(this.txtRandNum);
            this.panel1.Controls.Add(this.lblRandNum);
            this.panel1.Controls.Add(this.txtGuess);
            this.panel1.Controls.Add(this.lblGuessed);
            this.panel1.Controls.Add(this.lblmid);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(375, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 395);
            this.panel1.TabIndex = 4;
            // 
            // txtNumGen
            // 
            this.txtNumGen.BackColor = System.Drawing.Color.White;
            this.txtNumGen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumGen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumGen.ForeColor = System.Drawing.Color.Black;
            this.txtNumGen.Location = new System.Drawing.Point(62, 323);
            this.txtNumGen.Name = "txtNumGen";
            this.txtNumGen.ReadOnly = true;
            this.txtNumGen.Size = new System.Drawing.Size(383, 30);
            this.txtNumGen.TabIndex = 14;
            // 
            // txtCount
            // 
            this.txtCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(263, 195);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(100, 30);
            this.txtCount.TabIndex = 3;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(35, 195);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(204, 30);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "Number of Tries:";
            // 
            // btnGuessed
            // 
            this.btnGuessed.BackColor = System.Drawing.Color.Transparent;
            this.btnGuessed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuessed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessed.Location = new System.Drawing.Point(378, 128);
            this.btnGuessed.Name = "btnGuessed";
            this.btnGuessed.Size = new System.Drawing.Size(100, 43);
            this.btnGuessed.TabIndex = 2;
            this.btnGuessed.Text = "&Enter";
            this.btnGuessed.UseVisualStyleBackColor = false;
            this.btnGuessed.Click += new System.EventHandler(this.btnGuessed_Click);
            // 
            // txtRandNum
            // 
            this.txtRandNum.AccessibleName = "";
            this.txtRandNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRandNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRandNum.Location = new System.Drawing.Point(263, 256);
            this.txtRandNum.Name = "txtRandNum";
            this.txtRandNum.ReadOnly = true;
            this.txtRandNum.Size = new System.Drawing.Size(100, 30);
            this.txtRandNum.TabIndex = 13;
            // 
            // lblRandNum
            // 
            this.lblRandNum.AccessibleName = "";
            this.lblRandNum.AutoSize = true;
            this.lblRandNum.BackColor = System.Drawing.Color.Transparent;
            this.lblRandNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandNum.Location = new System.Drawing.Point(14, 256);
            this.lblRandNum.Name = "lblRandNum";
            this.lblRandNum.Size = new System.Drawing.Size(225, 30);
            this.lblRandNum.TabIndex = 11;
            this.lblRandNum.Text = "Random Number:";
            // 
            // txtGuess
            // 
            this.txtGuess.AccessibleName = "";
            this.txtGuess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGuess.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(263, 134);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 30);
            this.txtGuess.TabIndex = 1;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGuessed
            // 
            this.lblGuessed.AccessibleName = "lblGuessed";
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.BackColor = System.Drawing.Color.Transparent;
            this.lblGuessed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessed.Location = new System.Drawing.Point(20, 134);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(219, 30);
            this.lblGuessed.TabIndex = 10;
            this.lblGuessed.Text = "Enter Your Guess:";
            // 
            // lblmid
            // 
            this.lblmid.AutoSize = true;
            this.lblmid.BackColor = System.Drawing.Color.Transparent;
            this.lblmid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmid.Location = new System.Drawing.Point(29, 55);
            this.lblmid.Name = "lblmid";
            this.lblmid.Size = new System.Drawing.Size(449, 30);
            this.lblmid.TabIndex = 9;
            this.lblmid.Text = "Guess a number between 1 and 100.";
            // 
            // lblLeft
            // 
            this.lblLeft.AccessibleName = "lblLeft";
            this.lblLeft.AutoSize = true;
            this.lblLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeft.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.ForeColor = System.Drawing.Color.White;
            this.lblLeft.Location = new System.Drawing.Point(39, 185);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(222, 43);
            this.lblLeft.TabIndex = 0;
            this.lblLeft.Text = "Play to Win!";
            // 
            // btnClick
            // 
            this.btnClick.AccessibleName = "";
            this.btnClick.BackColor = System.Drawing.Color.Tomato;
            this.btnClick.FlatAppearance.BorderSize = 0;
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.ForeColor = System.Drawing.Color.White;
            this.btnClick.Location = new System.Drawing.Point(939, 376);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(239, 60);
            this.btnClick.TabIndex = 4;
            this.btnClick.Text = "Click &Here";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnGen);
            // 
            // lblGen
            // 
            this.lblGen.AccessibleName = "lblGen";
            this.lblGen.AutoSize = true;
            this.lblGen.BackColor = System.Drawing.Color.Transparent;
            this.lblGen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.ForeColor = System.Drawing.Color.White;
            this.lblGen.Location = new System.Drawing.Point(885, 330);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(341, 43);
            this.lblGen.TabIndex = 6;
            this.lblGen.Text = "Generate Number";
            // 
            // btnX
            // 
            this.btnX.AccessibleName = "btnX";
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1124, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(119, 105);
            this.btnX.TabIndex = 5;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblPlay
            // 
            this.lblPlay.AccessibleName = "lblPlay";
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlay.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Location = new System.Drawing.Point(41, 249);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(297, 192);
            this.lblPlay.TabIndex = 8;
            this.lblPlay.Text = "A random number will\r\nbe generated from 1\r\nto 100. Guess the \r\nrandom number and " +
    "\r\nyou win! Good Luck!\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Project4.Properties.Resources.theback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 783);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Guess it Right!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuessed;
        private System.Windows.Forms.Label lblmid;
        private System.Windows.Forms.TextBox txtRandNum;
        private System.Windows.Forms.Label lblRandNum;
        private System.Windows.Forms.Button btnGuessed;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtNumGen;
    }
}

