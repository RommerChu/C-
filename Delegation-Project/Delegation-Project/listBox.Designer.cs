namespace Delegation_Project
{
    partial class Sports
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
            this.chkSoccer = new System.Windows.Forms.CheckBox();
            this.lblSports = new System.Windows.Forms.Label();
            this.chkFootball = new System.Windows.Forms.CheckBox();
            this.chkBasketball = new System.Windows.Forms.CheckBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.radioMississauga = new System.Windows.Forms.RadioButton();
            this.radioBrampton = new System.Windows.Forms.RadioButton();
            this.radioToronto = new System.Windows.Forms.RadioButton();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkSoccer
            // 
            this.chkSoccer.AutoSize = true;
            this.chkSoccer.Location = new System.Drawing.Point(174, 215);
            this.chkSoccer.Name = "chkSoccer";
            this.chkSoccer.Size = new System.Drawing.Size(141, 36);
            this.chkSoccer.TabIndex = 0;
            this.chkSoccer.Text = "Soccer";
            this.chkSoccer.UseVisualStyleBackColor = true;
            // 
            // lblSports
            // 
            this.lblSports.AutoSize = true;
            this.lblSports.Location = new System.Drawing.Point(168, 138);
            this.lblSports.Name = "lblSports";
            this.lblSports.Size = new System.Drawing.Size(97, 32);
            this.lblSports.TabIndex = 1;
            this.lblSports.Text = "Sports";
            // 
            // chkFootball
            // 
            this.chkFootball.AutoSize = true;
            this.chkFootball.Location = new System.Drawing.Point(174, 295);
            this.chkFootball.Name = "chkFootball";
            this.chkFootball.Size = new System.Drawing.Size(156, 36);
            this.chkFootball.TabIndex = 2;
            this.chkFootball.Text = "Football";
            this.chkFootball.UseVisualStyleBackColor = true;
            // 
            // chkBasketball
            // 
            this.chkBasketball.AutoSize = true;
            this.chkBasketball.Location = new System.Drawing.Point(174, 372);
            this.chkBasketball.Name = "chkBasketball";
            this.chkBasketball.Size = new System.Drawing.Size(186, 36);
            this.chkBasketball.TabIndex = 3;
            this.chkBasketball.Text = "Basketball";
            this.chkBasketball.UseVisualStyleBackColor = true;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(739, 138);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(124, 32);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // radioMississauga
            // 
            this.radioMississauga.AutoSize = true;
            this.radioMississauga.Location = new System.Drawing.Point(736, 214);
            this.radioMississauga.Name = "radioMississauga";
            this.radioMississauga.Size = new System.Drawing.Size(209, 36);
            this.radioMississauga.TabIndex = 5;
            this.radioMississauga.TabStop = true;
            this.radioMississauga.Text = "Mississauga";
            this.radioMississauga.UseVisualStyleBackColor = true;
            this.radioMississauga.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBrampton
            // 
            this.radioBrampton.AutoSize = true;
            this.radioBrampton.Location = new System.Drawing.Point(736, 294);
            this.radioBrampton.Name = "radioBrampton";
            this.radioBrampton.Size = new System.Drawing.Size(175, 36);
            this.radioBrampton.TabIndex = 6;
            this.radioBrampton.TabStop = true;
            this.radioBrampton.Text = "Brampton";
            this.radioBrampton.UseVisualStyleBackColor = true;
            // 
            // radioToronto
            // 
            this.radioToronto.AutoSize = true;
            this.radioToronto.Location = new System.Drawing.Point(736, 371);
            this.radioToronto.Name = "radioToronto";
            this.radioToronto.Size = new System.Drawing.Size(150, 36);
            this.radioToronto.TabIndex = 7;
            this.radioToronto.TabStop = true;
            this.radioToronto.Text = "Toronto";
            this.radioToronto.UseVisualStyleBackColor = true;
            // 
            // btnOK2
            // 
            this.btnOK2.Location = new System.Drawing.Point(754, 572);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(312, 88);
            this.btnOK2.TabIndex = 8;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = true;
            this.btnOK2.Click += new System.EventHandler(this.btnOK2_Click);
            // 
            // Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 814);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.radioToronto);
            this.Controls.Add(this.radioBrampton);
            this.Controls.Add(this.radioMississauga);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.chkBasketball);
            this.Controls.Add(this.chkFootball);
            this.Controls.Add(this.lblSports);
            this.Controls.Add(this.chkSoccer);
            this.Name = "Sports";
            this.Text = "Sports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSoccer;
        private System.Windows.Forms.Label lblSports;
        private System.Windows.Forms.CheckBox chkFootball;
        private System.Windows.Forms.CheckBox chkBasketball;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.RadioButton radioMississauga;
        private System.Windows.Forms.RadioButton radioBrampton;
        private System.Windows.Forms.RadioButton radioToronto;
        private System.Windows.Forms.Button btnOK2;
    }
}