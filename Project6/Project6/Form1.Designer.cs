
namespace Project6
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
            this.lblPand = new System.Windows.Forms.Label();
            this.Listbx = new System.Windows.Forms.ListBox();
            this.gBx = new System.Windows.Forms.GroupBox();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoDesc = new System.Windows.Forms.RadioButton();
            this.rdoAsc = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btnClr = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.lblHist = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPand
            // 
            this.lblPand.AutoSize = true;
            this.lblPand.BackColor = System.Drawing.Color.Transparent;
            this.lblPand.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPand.ForeColor = System.Drawing.Color.Black;
            this.lblPand.Location = new System.Drawing.Point(60, 31);
            this.lblPand.Name = "lblPand";
            this.lblPand.Size = new System.Drawing.Size(569, 115);
            this.lblPand.TabIndex = 0;
            this.lblPand.Text = "Pandemics";
            // 
            // Listbx
            // 
            this.Listbx.BackColor = System.Drawing.SystemColors.Window;
            this.Listbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Listbx.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listbx.FormattingEnabled = true;
            this.Listbx.ItemHeight = 23;
            this.Listbx.Location = new System.Drawing.Point(633, 265);
            this.Listbx.Name = "Listbx";
            this.Listbx.Size = new System.Drawing.Size(287, 345);
            this.Listbx.TabIndex = 1;
            // 
            // gBx
            // 
            this.gBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gBx.Controls.Add(this.rdoName);
            this.gBx.Controls.Add(this.rdoDesc);
            this.gBx.Controls.Add(this.rdoAsc);
            this.gBx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBx.ForeColor = System.Drawing.Color.Black;
            this.gBx.Location = new System.Drawing.Point(80, 265);
            this.gBx.Name = "gBx";
            this.gBx.Size = new System.Drawing.Size(523, 345);
            this.gBx.TabIndex = 2;
            this.gBx.TabStop = false;
            this.gBx.Text = "Make a Selection:";
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.BackColor = System.Drawing.Color.Transparent;
            this.rdoName.Location = new System.Drawing.Point(25, 171);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(237, 34);
            this.rdoName.TabIndex = 2;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Search by &Name";
            this.rdoName.UseVisualStyleBackColor = false;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoName_CheckedChanged);
            // 
            // rdoDesc
            // 
            this.rdoDesc.AutoSize = true;
            this.rdoDesc.BackColor = System.Drawing.Color.Transparent;
            this.rdoDesc.Location = new System.Drawing.Point(25, 117);
            this.rdoDesc.Name = "rdoDesc";
            this.rdoDesc.Size = new System.Drawing.Size(479, 34);
            this.rdoDesc.TabIndex = 1;
            this.rdoDesc.TabStop = true;
            this.rdoDesc.Text = "Sort by Pandemic Name &Descending";
            this.rdoDesc.UseVisualStyleBackColor = false;
            this.rdoDesc.CheckedChanged += new System.EventHandler(this.rdoDesc_CheckedChanged);
            // 
            // rdoAsc
            // 
            this.rdoAsc.AutoSize = true;
            this.rdoAsc.BackColor = System.Drawing.Color.Transparent;
            this.rdoAsc.Location = new System.Drawing.Point(25, 62);
            this.rdoAsc.Name = "rdoAsc";
            this.rdoAsc.Size = new System.Drawing.Size(462, 34);
            this.rdoAsc.TabIndex = 0;
            this.rdoAsc.TabStop = true;
            this.rdoAsc.Text = "Sort by Pandemic Name &Ascending";
            this.rdoAsc.UseVisualStyleBackColor = false;
            this.rdoAsc.CheckedChanged += new System.EventHandler(this.rdoAsc_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(100, 675);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(183, 30);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "&Search Name:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.Transparent;
            this.lblRes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.ForeColor = System.Drawing.Color.Black;
            this.lblRes.Location = new System.Drawing.Point(193, 763);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(90, 30);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "&Result:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(309, 675);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 30);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtRes
            // 
            this.txtRes.BackColor = System.Drawing.Color.White;
            this.txtRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.Location = new System.Drawing.Point(309, 763);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(258, 30);
            this.txtRes.TabIndex = 6;
            // 
            // btnClr
            // 
            this.btnClr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClr.FlatAppearance.BorderSize = 0;
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.Color.Black;
            this.btnClr.Location = new System.Drawing.Point(499, 882);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(178, 45);
            this.btnClr.TabIndex = 7;
            this.btnClr.Text = "C&lear";
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEx
            // 
            this.btnEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEx.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEx.FlatAppearance.BorderSize = 0;
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.ForeColor = System.Drawing.Color.Black;
            this.btnEx.Location = new System.Drawing.Point(715, 882);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(178, 45);
            this.btnEx.TabIndex = 8;
            this.btnEx.Text = "E&xit";
            this.btnEx.UseVisualStyleBackColor = false;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // lblHist
            // 
            this.lblHist.AutoSize = true;
            this.lblHist.BackColor = System.Drawing.Color.Transparent;
            this.lblHist.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHist.Location = new System.Drawing.Point(69, 146);
            this.lblHist.Name = "lblHist";
            this.lblHist.Size = new System.Drawing.Size(568, 62);
            this.lblHist.TabIndex = 9;
            this.lblHist.Text = "that Changed History";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(141, 882);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "S&earch";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Project6.Properties.Resources.doctor_in_mask_gloves_and_protective_suit_pointing_left_and_looking;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1456, 961);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblHist);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gBx);
            this.Controls.Add(this.Listbx);
            this.Controls.Add(this.lblPand);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Pandemics that Changed History";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBx.ResumeLayout(false);
            this.gBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPand;
        private System.Windows.Forms.ListBox Listbx;
        private System.Windows.Forms.GroupBox gBx;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoDesc;
        private System.Windows.Forms.RadioButton rdoAsc;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Label lblHist;
        private System.Windows.Forms.Button btnSearch;
    }
}

