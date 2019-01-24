namespace Ceviri2
{
	partial class homepage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.textBox1.Location = new System.Drawing.Point(77, 89);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(299, 26);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "Çevrilecek Metin";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.textBox2.Location = new System.Drawing.Point(77, 261);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(299, 26);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "Çevrilen Metin";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bunifuImageButton3
			// 
			this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
			this.bunifuImageButton3.ImageActive = null;
			this.bunifuImageButton3.Location = new System.Drawing.Point(382, 89);
			this.bunifuImageButton3.Name = "bunifuImageButton3";
			this.bunifuImageButton3.Size = new System.Drawing.Size(27, 26);
			this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton3.TabIndex = 7;
			this.bunifuImageButton3.TabStop = false;
			this.bunifuImageButton3.Zoom = 10;
			this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click_1);
			// 
			// bunifuImageButton2
			// 
			this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
			this.bunifuImageButton2.ImageActive = null;
			this.bunifuImageButton2.Location = new System.Drawing.Point(382, 261);
			this.bunifuImageButton2.Name = "bunifuImageButton2";
			this.bunifuImageButton2.Size = new System.Drawing.Size(27, 26);
			this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton2.TabIndex = 8;
			this.bunifuImageButton2.TabStop = false;
			this.bunifuImageButton2.Zoom = 10;
			this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(427, 139);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(121, 89);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 9;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Türkçe",
            "İngilizce",
            "Arapça",
            "Rusça",
            "Fransızca",
            "Almanca",
            "Korece"});
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.comboBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(427, 112);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 10;
			// 
			// comboBox2
			// 
			this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.comboBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(427, 234);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 11;
			// 
			// bunifuImageButton4
			// 
			this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
			this.bunifuImageButton4.ImageActive = null;
			this.bunifuImageButton4.Location = new System.Drawing.Point(554, 139);
			this.bunifuImageButton4.Name = "bunifuImageButton4";
			this.bunifuImageButton4.Size = new System.Drawing.Size(31, 89);
			this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton4.TabIndex = 12;
			this.bunifuImageButton4.TabStop = false;
			this.bunifuImageButton4.Zoom = 10;
			this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
			// 
			// homepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.Controls.Add(this.bunifuImageButton4);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.bunifuImageButton1);
			this.Controls.Add(this.bunifuImageButton2);
			this.Controls.Add(this.bunifuImageButton3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "homepage";
			this.Size = new System.Drawing.Size(588, 422);
			this.Load += new System.EventHandler(this.homepage_Load);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox textBox2;
		public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
		public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
		public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		public System.Windows.Forms.ComboBox comboBox1;
		public System.Windows.Forms.ComboBox comboBox2;
		public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
	}
}
