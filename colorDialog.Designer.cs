﻿namespace Ceviri2
{
	partial class colorDialog
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
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.button7 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.DarkBlue;
			this.button6.ForeColor = System.Drawing.Color.Red;
			this.button6.Location = new System.Drawing.Point(307, 87);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(19, 19);
			this.button6.TabIndex = 29;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Yellow;
			this.button5.ForeColor = System.Drawing.Color.Red;
			this.button5.Location = new System.Drawing.Point(266, 87);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(19, 19);
			this.button5.TabIndex = 28;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LimeGreen;
			this.button4.ForeColor = System.Drawing.Color.Red;
			this.button4.Location = new System.Drawing.Point(228, 87);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(19, 19);
			this.button4.TabIndex = 27;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Green;
			this.button3.ForeColor = System.Drawing.Color.Red;
			this.button3.Location = new System.Drawing.Point(188, 87);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(19, 19);
			this.button3.TabIndex = 26;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Blue;
			this.button2.ForeColor = System.Drawing.Color.Blue;
			this.button2.Location = new System.Drawing.Point(150, 87);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(19, 19);
			this.button2.TabIndex = 25;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.ForeColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(112, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(19, 19);
			this.button1.TabIndex = 24;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bunifuMetroTextbox1
			// 
			this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
			this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.bunifuMetroTextbox1.BorderThickness = 3;
			this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuMetroTextbox1.isPassword = false;
			this.bunifuMetroTextbox1.Location = new System.Drawing.Point(112, 13);
			this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
			this.bunifuMetroTextbox1.Size = new System.Drawing.Size(214, 44);
			this.bunifuMetroTextbox1.TabIndex = 23;
			this.bunifuMetroTextbox1.Text = "Html Code";
			this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.bunifuMetroTextbox1.Click += new System.EventHandler(this.bunifuMetroTextbox1_Click);
			// 
			// button7
			// 
			this.button7.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button7.Location = new System.Drawing.Point(385, 13);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 44);
			this.button7.TabIndex = 31;
			this.button7.Text = "OK";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 32;
			this.label1.Text = "label1";
			// 
			// colorDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 124);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bunifuMetroTextbox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "colorDialog";
			this.Text = "centerMenu";
			this.Load += new System.EventHandler(this.centerMenu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label1;
	}
}