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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.imgBtnBack = new Guna.UI2.WinForms.Guna2ImageButton();
			this.imgBtnFoward = new Guna.UI2.WinForms.Guna2ImageButton();
			this.imgBtnReload = new Guna.UI2.WinForms.Guna2ImageButton();
			this.txtBar = new Guna.UI2.WinForms.Guna2TextBox();
			this.imgBtnAbout = new Guna.UI2.WinForms.Guna2ImageButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pContainer = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.toolTip.SetToolTip(this.imgBtnBack, "Go back one page");
			this.imgBtnBack.Click += new System.EventHandler(this.imgBtnBack_Click);
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
			this.toolTip.SetToolTip(this.imgBtnFoward, "Go forward one page");
			this.imgBtnFoward.Click += new System.EventHandler(this.imgBtnFoward_Click);
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
			this.toolTip.SetToolTip(this.imgBtnReload, "Reload current page");
			this.imgBtnReload.Click += new System.EventHandler(this.imgBtnReload_Click);
			// 
			// txtBar
			// 
			this.txtBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBar.BorderRadius = 5;
			this.txtBar.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBar.DefaultText = "";
			this.txtBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBar.DisabledState.Parent = this.txtBar;
			this.txtBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBar.FocusedState.Parent = this.txtBar;
			this.txtBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBar.HoverState.Parent = this.txtBar;
			this.txtBar.IconRightSize = new System.Drawing.Size(15, 15);
			this.txtBar.Location = new System.Drawing.Point(138, 10);
			this.txtBar.Name = "txtBar";
			this.txtBar.PasswordChar = '\0';
			this.txtBar.PlaceholderText = "Search with Google or enter URL";
			this.txtBar.SelectedText = "";
			this.txtBar.ShadowDecoration.Parent = this.txtBar;
			this.txtBar.Size = new System.Drawing.Size(592, 30);
			this.txtBar.TabIndex = 3;
			this.txtBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBar_KeyDown);
			// 
			// imgBtnAbout
			// 
			this.imgBtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.imgBtnAbout.BackColor = System.Drawing.Color.Transparent;
			this.imgBtnAbout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
			this.imgBtnAbout.CheckedState.Parent = this.imgBtnAbout;
			this.imgBtnAbout.HoverState.ImageSize = new System.Drawing.Size(26, 26);
			this.imgBtnAbout.HoverState.Parent = this.imgBtnAbout;
			this.imgBtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("imgBtnAbout.Image")));
			this.imgBtnAbout.ImageRotate = 0F;
			this.imgBtnAbout.ImageSize = new System.Drawing.Size(25, 25);
			this.imgBtnAbout.Location = new System.Drawing.Point(740, 10);
			this.imgBtnAbout.Name = "imgBtnAbout";
			this.imgBtnAbout.PressedState.ImageSize = new System.Drawing.Size(25, 25);
			this.imgBtnAbout.PressedState.Parent = this.imgBtnAbout;
			this.imgBtnAbout.Size = new System.Drawing.Size(30, 30);
			this.imgBtnAbout.TabIndex = 3;
			this.toolTip.SetToolTip(this.imgBtnAbout, "About BasicBrowse");
			this.imgBtnAbout.Click += new System.EventHandler(this.imgBtnAbout_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.imgBtnAbout);
			this.panel1.Controls.Add(this.txtBar);
			this.panel1.Controls.Add(this.imgBtnReload);
			this.panel1.Controls.Add(this.imgBtnFoward);
			this.panel1.Controls.Add(this.imgBtnBack);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 48);
			this.panel1.TabIndex = 0;
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "BasicBrowse";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private Guna.UI2.WinForms.Guna2ImageButton imgBtnBack;
		private Guna.UI2.WinForms.Guna2ImageButton imgBtnFoward;
		private Guna.UI2.WinForms.Guna2ImageButton imgBtnReload;
		private Guna.UI2.WinForms.Guna2TextBox txtBar;
		private Guna.UI2.WinForms.Guna2ImageButton imgBtnAbout;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pContainer;
	}
}

