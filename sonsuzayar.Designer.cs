namespace Ceviri2
{
	partial class sonsuzayar
	{
		/// <summary> 
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Bileşen Tasarımcısı üretimi kod

		/// <summary> 
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuSearchEngine1 = new Bunifu.Framework.UI.BunifuSearchEngine();
			this.SuspendLayout();
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Red;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(182, 73);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(45, 25);
			this.bunifuCustomLabel1.TabIndex = 0;
			this.bunifuCustomLabel1.Text = "Dil: ";
			// 
			// bunifuSearchEngine1
			// 
			this.bunifuSearchEngine1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuSearchEngine1.Location = new System.Drawing.Point(110, 182);
			this.bunifuSearchEngine1.Name = "bunifuSearchEngine1";
			this.bunifuSearchEngine1.Size = new System.Drawing.Size(309, 93);
			this.bunifuSearchEngine1.TabIndex = 1;
			// 
			// sonsuzayar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.Controls.Add(this.bunifuSearchEngine1);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Name = "sonsuzayar";
			this.Size = new System.Drawing.Size(755, 422);
			this.Load += new System.EventHandler(this.sonsuzayar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuSearchEngine bunifuSearchEngine1;
	}
}
