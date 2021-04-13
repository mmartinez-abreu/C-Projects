
namespace Project7
{
    partial class InputFileInfo
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSFile = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitlesec = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxFile = new System.Windows.Forms.TextBox();
            this.lblSpec2 = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.listbx = new System.Windows.Forms.ListBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(116, 32);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(504, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Input File Information";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(505, 366);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(300, 286);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(369, 30);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSFile
            // 
            this.btnSFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.btnSFile.FlatAppearance.BorderSize = 0;
            this.btnSFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSFile.ForeColor = System.Drawing.Color.White;
            this.btnSFile.Location = new System.Drawing.Point(505, 196);
            this.btnSFile.Name = "btnSFile";
            this.btnSFile.Size = new System.Drawing.Size(164, 47);
            this.btnSFile.TabIndex = 4;
            this.btnSFile.Text = "Select &File";
            this.btnSFile.UseVisualStyleBackColor = false;
            this.btnSFile.Click += new System.EventHandler(this.btnSFile_Click);
            // 
            // txtFile
            // 
            this.txtFile.BackColor = System.Drawing.Color.White;
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(300, 116);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(369, 30);
            this.txtFile.TabIndex = 5;
            this.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.BackColor = System.Drawing.Color.Transparent;
            this.lblFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.ForeColor = System.Drawing.Color.Cyan;
            this.lblFile.Location = new System.Drawing.Point(121, 119);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(173, 30);
            this.lblFile.TabIndex = 6;
            this.lblFile.Text = "File Selected:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Cyan;
            this.lblSearch.Location = new System.Drawing.Point(80, 286);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(214, 30);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search Substring:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Cyan;
            this.lblResult.Location = new System.Drawing.Point(283, 462);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(90, 30);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(379, 458);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(290, 30);
            this.txtResult.TabIndex = 9;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(126, 865);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 47);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(619, 865);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 47);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lblTitlesec);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 160);
            this.panel1.TabIndex = 12;
            // 
            // lblTitlesec
            // 
            this.lblTitlesec.AutoSize = true;
            this.lblTitlesec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlesec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(203)))));
            this.lblTitlesec.Location = new System.Drawing.Point(453, 90);
            this.lblTitlesec.Name = "lblTitlesec";
            this.lblTitlesec.Size = new System.Drawing.Size(160, 30);
            this.lblTitlesec.TabIndex = 2;
            this.lblTitlesec.Text = "File Statistics";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 646);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.txtBoxFile);
            this.panel3.Controls.Add(this.lblFile);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSFile);
            this.panel3.Controls.Add(this.txtResult);
            this.panel3.Controls.Add(this.txtFile);
            this.panel3.Controls.Add(this.lblResult);
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 688);
            this.panel3.TabIndex = 13;
            // 
            // txtBoxFile
            // 
            this.txtBoxFile.Location = new System.Drawing.Point(727, 124);
            this.txtBoxFile.Multiline = true;
            this.txtBoxFile.Name = "txtBoxFile";
            this.txtBoxFile.Size = new System.Drawing.Size(132, 346);
            this.txtBoxFile.TabIndex = 16;
            // 
            // lblSpec2
            // 
            this.lblSpec2.AutoSize = true;
            this.lblSpec2.BackColor = System.Drawing.Color.Transparent;
            this.lblSpec2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpec2.Location = new System.Drawing.Point(944, 106);
            this.lblSpec2.Name = "lblSpec2";
            this.lblSpec2.Size = new System.Drawing.Size(340, 90);
            this.lblSpec2.TabIndex = 14;
            this.lblSpec2.Text = "This program will determine\r\n the length of a word. Not \r\ncounting punctuation. ";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.BackColor = System.Drawing.Color.Transparent;
            this.lblSpec.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpec.Location = new System.Drawing.Point(942, 51);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(222, 39);
            this.lblSpec.TabIndex = 15;
            this.lblSpec.Text = "Specification";
            // 
            // listbx
            // 
            this.listbx.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbx.FormattingEnabled = true;
            this.listbx.ItemHeight = 23;
            this.listbx.Location = new System.Drawing.Point(949, 223);
            this.listbx.Name = "listbx";
            this.listbx.Size = new System.Drawing.Size(348, 487);
            this.listbx.TabIndex = 1;
            // 
            // InputFileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project7.Properties.Resources._67271;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 949);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblSpec2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listbx);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InputFileInfo";
            this.Text = "File Statistics";
            this.Load += new System.EventHandler(this.InputFileInfo_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitlesec;
        private System.Windows.Forms.Label lblSpec2;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.ListBox listbx;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.TextBox txtBoxFile;
    }
}

