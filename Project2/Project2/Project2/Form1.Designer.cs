
namespace Project2
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCircle = new System.Windows.Forms.Label();
            this.lblTrapezoid = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblCircumference = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtCircumference = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblTrapArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtTrapArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.btnTrapez = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Location = new System.Drawing.Point(424, 347);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClear.Location = new System.Drawing.Point(314, 347);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project2.Properties.Resources.uranus;
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 266);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Project2.Properties.Resources.triangleSize;
            this.pictureBox2.Location = new System.Drawing.Point(272, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 266);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblCircle
            // 
            this.lblCircle.AutoSize = true;
            this.lblCircle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCircle.Location = new System.Drawing.Point(95, 21);
            this.lblCircle.Name = "lblCircle";
            this.lblCircle.Size = new System.Drawing.Size(91, 38);
            this.lblCircle.TabIndex = 4;
            this.lblCircle.Text = "Circle";
            // 
            // lblTrapezoid
            // 
            this.lblTrapezoid.AutoSize = true;
            this.lblTrapezoid.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrapezoid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTrapezoid.Location = new System.Drawing.Point(327, 21);
            this.lblTrapezoid.Name = "lblTrapezoid";
            this.lblTrapezoid.Size = new System.Drawing.Size(146, 38);
            this.lblTrapezoid.TabIndex = 5;
            this.lblTrapezoid.Text = "Trapezoid";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.BackColor = System.Drawing.Color.LightBlue;
            this.lblRadius.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(36, 114);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(150, 16);
            this.lblRadius.TabIndex = 6;
            this.lblRadius.Text = "Enter the &radius in cm:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.LightBlue;
            this.lblArea.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(95, 201);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(89, 16);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "&Area in cm =";
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.BackColor = System.Drawing.Color.LightBlue;
            this.lblDiameter.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(66, 223);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(118, 16);
            this.lblDiameter.TabIndex = 8;
            this.lblDiameter.Text = "&Diameter in cm =";
            // 
            // lblCircumference
            // 
            this.lblCircumference.AutoSize = true;
            this.lblCircumference.BackColor = System.Drawing.Color.LightBlue;
            this.lblCircumference.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCircumference.Location = new System.Drawing.Point(32, 248);
            this.lblCircumference.Name = "lblCircumference";
            this.lblCircumference.Size = new System.Drawing.Size(152, 16);
            this.lblCircumference.TabIndex = 9;
            this.lblCircumference.Text = "C&ircumference in cm =";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightGray;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(35, 157);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 25);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate &Circle Size";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(188, 113);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(50, 20);
            this.txtRadius.TabIndex = 11;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(188, 200);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(50, 20);
            this.txtArea.TabIndex = 12;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(188, 222);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.ReadOnly = true;
            this.txtDiameter.Size = new System.Drawing.Size(50, 20);
            this.txtDiameter.TabIndex = 13;
            // 
            // txtCircumference
            // 
            this.txtCircumference.Location = new System.Drawing.Point(188, 247);
            this.txtCircumference.Name = "txtCircumference";
            this.txtCircumference.ReadOnly = true;
            this.txtCircumference.Size = new System.Drawing.Size(50, 20);
            this.txtCircumference.TabIndex = 14;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.LightBlue;
            this.lblA.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(317, 88);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(126, 16);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "Enter &side A in cm:";
            this.lblA.Click += new System.EventHandler(this.lblA_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.LightBlue;
            this.lblB.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(318, 115);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(124, 16);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "Enter side &B in cm:";
            this.lblB.Click += new System.EventHandler(this.lblB_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.LightBlue;
            this.lblHeight.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(291, 141);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(151, 16);
            this.lblHeight.TabIndex = 17;
            this.lblHeight.Text = "Enter the &height in cm:";
            this.lblHeight.Click += new System.EventHandler(this.lblHeight_Click);
            // 
            // lblTrapArea
            // 
            this.lblTrapArea.AutoSize = true;
            this.lblTrapArea.BackColor = System.Drawing.Color.LightBlue;
            this.lblTrapArea.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrapArea.Location = new System.Drawing.Point(353, 227);
            this.lblTrapArea.Name = "lblTrapArea";
            this.lblTrapArea.Size = new System.Drawing.Size(89, 16);
            this.lblTrapArea.TabIndex = 18;
            this.lblTrapArea.Text = "Ar&ea in cm =";
            this.lblTrapArea.Click += new System.EventHandler(this.lblTrapArea_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.BackColor = System.Drawing.Color.LightBlue;
            this.lblPerimeter.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(323, 249);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(120, 16);
            this.lblPerimeter.TabIndex = 19;
            this.lblPerimeter.Text = "&Perimeter in cm =";
            this.lblPerimeter.Click += new System.EventHandler(this.lblPerimeter_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(449, 87);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(44, 20);
            this.txtA.TabIndex = 20;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(449, 113);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(44, 20);
            this.txtB.TabIndex = 21;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(449, 140);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(44, 20);
            this.txtHeight.TabIndex = 22;
            // 
            // txtTrapArea
            // 
            this.txtTrapArea.Location = new System.Drawing.Point(449, 226);
            this.txtTrapArea.Name = "txtTrapArea";
            this.txtTrapArea.ReadOnly = true;
            this.txtTrapArea.Size = new System.Drawing.Size(44, 20);
            this.txtTrapArea.TabIndex = 23;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(449, 248);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(44, 20);
            this.txtPerimeter.TabIndex = 24;
            // 
            // btnTrapez
            // 
            this.btnTrapez.BackColor = System.Drawing.Color.LightGray;
            this.btnTrapez.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrapez.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrapez.Location = new System.Drawing.Point(314, 173);
            this.btnTrapez.Name = "btnTrapez";
            this.btnTrapez.Size = new System.Drawing.Size(164, 25);
            this.btnTrapez.TabIndex = 25;
            this.btnTrapez.Text = "Calculate &Trapezoid Size";
            this.btnTrapez.UseVisualStyleBackColor = false;
            this.btnTrapez.Click += new System.EventHandler(this.btnTrapez_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(540, 392);
            this.Controls.Add(this.btnTrapez);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtTrapArea);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblTrapArea);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtCircumference);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCircumference);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblTrapezoid);
            this.Controls.Add(this.lblCircle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCircle;
        private System.Windows.Forms.Label lblTrapezoid;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblCircumference;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtCircumference;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblTrapArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtTrapArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Button btnTrapez;
    }
}

