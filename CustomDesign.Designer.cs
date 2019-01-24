namespace Ceviri2
{
	partial class CustomDesign
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDesign));
			this.upMenu = new System.Windows.Forms.Button();
			this.sideMenu = new System.Windows.Forms.Button();
			this.centerMenu = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.SuspendLayout();
			// 
			// upMenu
			// 
			this.upMenu.Location = new System.Drawing.Point(32, 53);
			this.upMenu.Name = "upMenu";
			this.upMenu.Size = new System.Drawing.Size(528, 33);
			this.upMenu.TabIndex = 0;
			this.upMenu.UseVisualStyleBackColor = true;
			this.upMenu.Click += new System.EventHandler(this.upMenu_Click);
			// 
			// sideMenu
			// 
			this.sideMenu.Location = new System.Drawing.Point(32, 83);
			this.sideMenu.Name = "sideMenu";
			this.sideMenu.Size = new System.Drawing.Size(85, 269);
			this.sideMenu.TabIndex = 1;
			this.sideMenu.UseVisualStyleBackColor = true;
			this.sideMenu.Click += new System.EventHandler(this.sideMenu_Click);
			// 
			// centerMenu
			// 
			this.centerMenu.Location = new System.Drawing.Point(116, 83);
			this.centerMenu.Name = "centerMenu";
			this.centerMenu.Size = new System.Drawing.Size(444, 269);
			this.centerMenu.TabIndex = 2;
			this.centerMenu.UseVisualStyleBackColor = true;
			this.centerMenu.Click += new System.EventHandler(this.centerMenu_Click);
			this.centerMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.centerMenu_Paint);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button1.Location = new System.Drawing.Point(72, 382);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(175, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(32, 17);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(85, 17);
			this.radioButton1.TabIndex = 6;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Renk seçme";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(32, 358);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(137, 17);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Arkaplana resim ekleme";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(35, 358);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(528, 299);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(549, 358);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(36, 37);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 9;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(216, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Metinler";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(35, 92);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Buton";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// CustomDesign
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bunifuImageButton1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.centerMenu);
			this.Controls.Add(this.sideMenu);
			this.Controls.Add(this.upMenu);
			this.Name = "CustomDesign";
			this.Size = new System.Drawing.Size(588, 422);
			this.Load += new System.EventHandler(this.CustomDesign_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button upMenu;
		private System.Windows.Forms.Button sideMenu;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		public System.Windows.Forms.Button centerMenu;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
	}
}
