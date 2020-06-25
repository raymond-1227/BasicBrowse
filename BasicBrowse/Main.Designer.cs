namespace BasicBrowse
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtUrl = new Guna.UI2.WinForms.Guna2TextBox();
			this.imgBtnReload = new Guna.UI2.WinForms.Guna2ImageButton();
			this.imgBtnFoward = new Guna.UI2.WinForms.Guna2ImageButton();
			this.imgBtnBack = new Guna.UI2.WinForms.Guna2ImageButton();
			this.pContainer = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.txtUrl);
			this.panel1.Controls.Add(this.imgBtnReload);
			this.panel1.Controls.Add(this.imgBtnFoward);
			this.panel1.Controls.Add(this.imgBtnBack);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 48);
			this.panel1.TabIndex = 0;
			// 
			// txtUrl
			// 
			this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUrl.BorderRadius = 5;
			this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUrl.DefaultText = "";
			this.txtUrl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUrl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUrl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUrl.DisabledState.Parent = this.txtUrl;
			this.txtUrl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUrl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUrl.FocusedState.Parent = this.txtUrl;
			this.txtUrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUrl.HoverState.Parent = this.txtUrl;
			this.txtUrl.IconRightSize = new System.Drawing.Size(15, 15);
			this.txtUrl.Location = new System.Drawing.Point(142, 10);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.PasswordChar = '\0';
			this.txtUrl.PlaceholderText = "Enter URL";
			this.txtUrl.SelectedText = "";
			this.txtUrl.ShadowDecoration.Parent = this.txtUrl;
			this.txtUrl.Size = new System.Drawing.Size(619, 30);
			this.txtUrl.TabIndex = 3;
			this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
			// 
			// imgBtnReload
			// 
			this.imgBtnReload.BackColor = System.Drawing.Color.Transparent;
			this.imgBtnReload.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.imgBtnReload.CheckedState.Parent = this.imgBtnReload;
			this.imgBtnReload.HoverState.ImageSize = new System.Drawing.Size(26, 26);
			this.imgBtnReload.HoverState.Parent = this.imgBtnReload;
			this.imgBtnReload.Image = ((System.Drawing.Image)(resources.GetObject("imgBtnReload.Image")));
			this.imgBtnReload.ImageRotate = 0F;
			this.imgBtnReload.ImageSize = new System.Drawing.Size(25, 25);
			this.imgBtnReload.Location = new System.Drawing.Point(92, 10);
			this.imgBtnReload.Name = "imgBtnReload";
			this.imgBtnReload.PressedState.ImageSize = new System.Drawing.Size(25, 25);
			this.imgBtnReload.PressedState.Parent = this.imgBtnReload;
			this.imgBtnReload.Size = new System.Drawing.Size(30, 30);
			this.imgBtnReload.TabIndex = 2;
			this.imgBtnReload.Click += new System.EventHandler(this.imgBtnReload_Click);
			// 
			// imgBtnFoward
			// 
			this.imgBtnFoward.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.imgBtnFoward.CheckedState.Parent = this.imgBtnFoward;
			this.imgBtnFoward.HoverState.ImageSize = new System.Drawing.Size(26, 26);
			this.imgBtnFoward.HoverState.Parent = this.imgBtnFoward;
			this.imgBtnFoward.Image = ((System.Drawing.Image)(resources.GetObject("imgBtnFoward.Image")));
			this.imgBtnFoward.ImageRotate = 0F;
			this.imgBtnFoward.ImageSize = new System.Drawing.Size(25, 25);
			this.imgBtnFoward.Location = new System.Drawing.Point(52, 10);
			this.imgBtnFoward.Name = "imgBtnFoward";
			this.imgBtnFoward.PressedState.ImageSize = new System.Drawing.Size(25, 25);
			this.imgBtnFoward.PressedState.Parent = this.imgBtnFoward;
			this.imgBtnFoward.Size = new System.Drawing.Size(30, 30);
			this.imgBtnFoward.TabIndex = 1;
			this.imgBtnFoward.Click += new System.EventHandler(this.imgBtnFoward_Click);
			// 
			// imgBtnBack
			// 
			this.imgBtnBack.AccessibleName = "";
			this.imgBtnBack.BackColor = System.Drawing.Color.Transparent;
			this.imgBtnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.imgBtnBack.CheckedState.Parent = this.imgBtnBack;
			this.imgBtnBack.HoverState.ImageSize = new System.Drawing.Size(26, 26);
			this.imgBtnBack.HoverState.Parent = this.imgBtnBack;
			this.imgBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("imgBtnBack.Image")));
			this.imgBtnBack.ImageRotate = 0F;
			this.imgBtnBack.ImageSize = new System.Drawing.Size(25, 25);
			this.imgBtnBack.Location = new System.Drawing.Point(14, 10);
			this.imgBtnBack.Name = "imgBtnBack";
			this.imgBtnBack.PressedState.ImageSize = new System.Drawing.Size(25, 25);
			this.imgBtnBack.PressedState.Parent = this.imgBtnBack;
			this.imgBtnBack.Size = new System.Drawing.Size(30, 30);
			this.imgBtnBack.TabIndex = 0;
			this.imgBtnBack.Click += new System.EventHandler(this.imgBtnBack_Click);
			// 
			// pContainer
			// 
			this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pContainer.Location = new System.Drawing.Point(0, 46);
			this.pContainer.Name = "pContainer";
			this.pContainer.Size = new System.Drawing.Size(784, 514);
			this.pContainer.TabIndex = 1;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.pContainer);
			this.Controls.Add(this.panel1);
			this.Name = "Main";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2ImageButton imgBtnBack;
		private Guna.UI2.WinForms.Guna2TextBox txtUrl;
		private Guna.UI2.WinForms.Guna2ImageButton imgBtnReload;
		private Guna.UI2.WinForms.Guna2ImageButton imgBtnFoward;
		private System.Windows.Forms.Panel pContainer;
	}
}

