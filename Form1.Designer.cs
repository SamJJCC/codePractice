namespace codePractice
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTeam = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(62, 70);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(300, 274);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(415, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(415, 146);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(37, 13);
            this.lblTeam.TabIndex = 2;
            this.lblTeam.Text = "Team ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(420, 177);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(417, 208);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(47, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Average";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(417, 243);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Position";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(333, 382);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(215, 23);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Done";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(470, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(238, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbTeam
            // 
            this.tbTeam.Location = new System.Drawing.Point(470, 139);
            this.tbTeam.Name = "tbTeam";
            this.tbTeam.Size = new System.Drawing.Size(238, 20);
            this.tbTeam.TabIndex = 8;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(470, 170);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(238, 20);
            this.tbCity.TabIndex = 9;
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(470, 201);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(238, 20);
            this.tbAverage.TabIndex = 10;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(470, 236);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(238, 20);
            this.tbPosition.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbTeam);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "Form1";
            this.Text = "Baseball Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTeam;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.TextBox tbPosition;
    }
}

