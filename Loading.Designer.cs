namespace Ceviri2
{
	partial class yukleniyor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yukleniyor));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuCircleProgressbar1
			// 
			this.bunifuCircleProgressbar1.animated = true;
			this.bunifuCircleProgressbar1.animationIterval = 1;
			this.bunifuCircleProgressbar1.animationSpeed = 1;
			this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
			this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
			this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
			this.bunifuCircleProgressbar1.LabelVisible = false;
			this.bunifuCircleProgressbar1.LineProgressThickness = 8;
			this.bunifuCircleProgressbar1.LineThickness = 5;
			this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(195, 0);
			this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.bunifuCircleProgressbar1.MaxValue = 100;
			this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
			this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
			this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(201, 201);
			this.bunifuCircleProgressbar1.TabIndex = 0;
			this.bunifuCircleProgressbar1.Value = 25;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
			this.label1.Location = new System.Drawing.Point(209, 226);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loading Please Wait";
			// 
			// yukleniyor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(592, 283);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bunifuCircleProgressbar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "yukleniyor";
			this.Text = "Loading";
			this.Load += new System.EventHandler(this.yukleniyor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
		private System.Windows.Forms.Label label1;
	}
}