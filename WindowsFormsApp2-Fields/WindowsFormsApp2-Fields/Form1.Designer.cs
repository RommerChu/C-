namespace WindowsFormsApp2_Fields
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
            this.txtFirstNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJobBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboProvBox = new System.Windows.Forms.ComboBox();
            this.lstSkills = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstNameBox
            // 
            this.txtFirstNameBox.Location = new System.Drawing.Point(431, 119);
            this.txtFirstNameBox.Name = "txtFirstNameBox";
            this.txtFirstNameBox.Size = new System.Drawing.Size(405, 38);
            this.txtFirstNameBox.TabIndex = 1;
            this.txtFirstNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtLastNameBox
            // 
            this.txtLastNameBox.Location = new System.Drawing.Point(431, 185);
            this.txtLastNameBox.Name = "txtLastNameBox";
            this.txtLastNameBox.Size = new System.Drawing.Size(408, 38);
            this.txtLastNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txtAddressBox
            // 
            this.txtAddressBox.Location = new System.Drawing.Point(431, 253);
            this.txtAddressBox.Name = "txtAddressBox";
            this.txtAddressBox.Size = new System.Drawing.Size(408, 38);
            this.txtAddressBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job";
            // 
            // txtJobBox
            // 
            this.txtJobBox.Location = new System.Drawing.Point(431, 315);
            this.txtJobBox.Name = "txtJobBox";
            this.txtJobBox.Size = new System.Drawing.Size(408, 38);
            this.txtJobBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prov";
            // 
            // comboProvBox
            // 
            this.comboProvBox.FormattingEnabled = true;
            this.comboProvBox.Items.AddRange(new object[] {
            "Ontario",
            "America",
            "Saudi",
            "Uk",
            "Russia"});
            this.comboProvBox.Location = new System.Drawing.Point(431, 381);
            this.comboProvBox.Name = "comboProvBox";
            this.comboProvBox.Size = new System.Drawing.Size(408, 39);
            this.comboProvBox.TabIndex = 9;
            // 
            // lstSkills
            // 
            this.lstSkills.FormattingEnabled = true;
            this.lstSkills.ItemHeight = 31;
            this.lstSkills.Location = new System.Drawing.Point(135, 522);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(238, 283);
            this.lstSkills.TabIndex = 10;
            this.lstSkills.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSkills_MouseClick);
            this.lstSkills.SelectedIndexChanged += new System.EventHandler(this.lstSkills_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(431, 550);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(169, 61);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(431, 650);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 61);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(431, 744);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 61);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSkills
            // 
            this.txtSkills.Location = new System.Drawing.Point(431, 460);
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.Size = new System.Drawing.Size(408, 38);
            this.txtSkills.TabIndex = 14;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(300, 463);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(83, 32);
            this.lblSkills.TabIndex = 15;
            this.lblSkills.Text = "Skills";
            this.lblSkills.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 1009);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.txtSkills);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstSkills);
            this.Controls.Add(this.comboProvBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJobBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddressBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstNameBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJobBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboProvBox;
        private System.Windows.Forms.ListBox lstSkills;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSkills;
        private System.Windows.Forms.Label lblSkills;
    }
}

