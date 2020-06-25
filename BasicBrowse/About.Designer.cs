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
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTitle
			// 
			this.txtTitle.AutoSize = true;
			this.txtTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 36F);
			this.txtTitle.ForeColor = System.Drawing.Color.AliceBlue;
			this.txtTitle.Location = new System.Drawing.Point(287, 57);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(289, 61);
			this.txtTitle.TabIndex = 0;
			this.txtTitle.Text = "BasicBrowse";
			// 
			// imgLogo
			// 
			this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
			this.imgLogo.Location = new System.Drawing.Point(53, 67);
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.Size = new System.Drawing.Size(211, 210);
			this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgLogo.TabIndex = 2;
			this.imgLogo.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// txtVersion
			// 
			this.txtVersion.AutoSize = true;
			this.txtVersion.BackColor = System.Drawing.Color.Transparent;
			this.txtVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtVersion.ForeColor = System.Drawing.Color.AliceBlue;
			this.txtVersion.Location = new System.Drawing.Point(297, 179);
			this.txtVersion.Name = "txtVersion";
			this.txtVersion.Size = new System.Drawing.Size(132, 21);
			this.txtVersion.TabIndex = 4;
			this.txtVersion.Text = "0.5 (Beta Release)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.ForeColor = System.Drawing.Color.AliceBlue;
			this.label2.Location = new System.Drawing.Point(297, 212);
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
			this.label3.Location = new System.Drawing.Point(297, 247);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "Powered by .NET Framework";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.ForeColor = System.Drawing.Color.AliceBlue;
			this.label4.Location = new System.Drawing.Point(297, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(224, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Chromium based web browser";
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(634, 361);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtVersion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.imgLogo);
			this.Controls.Add(this.txtTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About BasicBrowse";
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
	}
}