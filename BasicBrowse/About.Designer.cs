namespace BasicBrowse
{
	partial class About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.txtTitle = new System.Windows.Forms.Label();
			this.imgLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtVersion = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTitle
			// 
			this.txtTitle.AutoSize = true;
			this.txtTitle.BackColor = System.Drawing.Color.Transparent;
			this.txtTitle.Font = new System.Drawing.Font("Metropolis", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTitle.ForeColor = System.Drawing.Color.AliceBlue;
			this.txtTitle.Location = new System.Drawing.Point(270, 59);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(141, 48);
			this.txtTitle.TabIndex = 0;
			this.txtTitle.Text = "Basic";
			this.txtTitle.Click += new System.EventHandler(this.txtTitle_Click);
			// 
			// imgLogo
			// 
			this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
			this.imgLogo.Location = new System.Drawing.Point(35, 47);
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.Size = new System.Drawing.Size(211, 228);
			this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgLogo.TabIndex = 2;
			this.imgLogo.TabStop = false;
			this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// txtVersion
			// 
			this.txtVersion.AutoSize = true;
			this.txtVersion.BackColor = System.Drawing.Color.Transparent;
			this.txtVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtVersion.ForeColor = System.Drawing.Color.AliceBlue;
			this.txtVersion.Location = new System.Drawing.Point(276, 162);
			this.txtVersion.Name = "txtVersion";
			this.txtVersion.Size = new System.Drawing.Size(144, 21);
			this.txtVersion.TabIndex = 4;
			this.txtVersion.Text = "0.5.2 (Beta Release)";
			this.txtVersion.Click += new System.EventHandler(this.txtVersion_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.ForeColor = System.Drawing.Color.AliceBlue;
			this.label2.Location = new System.Drawing.Point(276, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(187, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Created by Raymond Hsu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label3.ForeColor = System.Drawing.Color.AliceBlue;
			this.label3.Location = new System.Drawing.Point(276, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "Powered by .NET Framework";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
			this.label4.ForeColor = System.Drawing.Color.AliceBlue;
			this.label4.Location = new System.Drawing.Point(275, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(294, 30);
			this.label4.TabIndex = 7;
			this.label4.Text = "Chromium based web browser";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Metropolis Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.AliceBlue;
			this.label5.Location = new System.Drawing.Point(398, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(188, 48);
			this.label5.TabIndex = 8;
			this.label5.Text = "Browse";
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(634, 341);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtVersion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.imgLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " About BasicBrowse";
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtTitle;
		private System.Windows.Forms.PictureBox imgLogo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label txtVersion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}