namespace Ceviri2
{
	partial class Çeviri
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

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Çeviri));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.sideMenu = new System.Windows.Forms.Panel();
			this.menulabel = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.Header = new System.Windows.Forms.Panel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.menubutton = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.sonsuzÇeviriV20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yapımcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.programıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
			this.sonsuzayar1 = new Ceviri2.sonsuzayar();
			this.sideMenu.SuspendLayout();
			this.Header.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// sideMenu
			// 
			this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.sideMenu.Controls.Add(this.bunifuFlatButton3);
			this.sideMenu.Controls.Add(this.menulabel);
			this.sideMenu.Controls.Add(this.menubutton);
			this.sideMenu.Controls.Add(this.bunifuFlatButton2);
			this.sideMenu.Controls.Add(this.bunifuFlatButton1);
			this.sideMenu.Controls.Add(this.bunifuCustomLabel2);
			this.panelAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
			this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.sideMenu.Location = new System.Drawing.Point(0, 28);
			this.sideMenu.Name = "sideMenu";
			this.sideMenu.Size = new System.Drawing.Size(212, 422);
			this.sideMenu.TabIndex = 0;
			// 
			// menulabel
			// 
			this.menulabel.AutoSize = true;
			this.panelAnimator.SetDecoration(this.menulabel, BunifuAnimatorNS.DecorationType.None);
			this.menulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.menulabel.ForeColor = System.Drawing.Color.Red;
			this.menulabel.Location = new System.Drawing.Point(64, 6);
			this.menulabel.Name = "menulabel";
			this.menulabel.Size = new System.Drawing.Size(66, 25);
			this.menulabel.TabIndex = 4;
			this.menulabel.Text = "Menü";
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.panelAnimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkRed;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 393);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(170, 20);
			this.bunifuCustomLabel2.TabIndex = 0;
			this.bunifuCustomLabel2.Text = "Dil: Türkçe (Varsayılan)";
			// 
			// Header
			// 
			this.Header.BackColor = System.Drawing.Color.DimGray;
			this.Header.ContextMenuStrip = this.contextMenuStrip1;
			this.Header.Controls.Add(this.bunifuImageButton6);
			this.Header.Controls.Add(this.bunifuImageButton2);
			this.Header.Controls.Add(this.bunifuImageButton4);
			this.Header.Controls.Add(this.bunifuCustomLabel1);
			this.Header.Controls.Add(this.bunifuImageButton1);
			this.panelAnimator.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
			this.Header.Dock = System.Windows.Forms.DockStyle.Top;
			this.Header.Location = new System.Drawing.Point(0, 0);
			this.Header.MaximumSize = new System.Drawing.Size(800, 28);
			this.Header.MinimumSize = new System.Drawing.Size(800, 28);
			this.Header.Name = "Header";
			this.Header.Size = new System.Drawing.Size(800, 28);
			this.Header.TabIndex = 1;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.panelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 9);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(150, 13);
			this.bunifuCustomLabel1.TabIndex = 2;
			this.bunifuCustomLabel1.Text = "Sonsuz Çeviri V2.0 | Başlangıç";
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.Header;
			this.bunifuDragControl1.Vertical = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.panel2.Controls.Add(this.sonsuzayar1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.bunifuImageButton5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.bunifuCustomLabel4);
			this.panel2.Controls.Add(this.bunifuCustomLabel3);
			this.panel2.Controls.Add(this.comboBox2);
			this.panel2.Controls.Add(this.comboBox1);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.bunifuImageButton3);
			this.panelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(212, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(588, 422);
			this.panel2.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.panelAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.ForestGreen;
			this.label5.Location = new System.Drawing.Point(635, 398);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "Designed by Umut";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.panelAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.ForestGreen;
			this.label4.Location = new System.Drawing.Point(468, 396);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "Designed by Umut";
			this.label4.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.panelAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(142, 216);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(434, 39);
			this.label3.TabIndex = 9;
			this.label3.Text = "Designed by Umut Özercan";
			this.label3.Visible = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.panelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(104, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(507, 31);
			this.label2.TabIndex = 8;
			this.label2.Text = "Coding by Mustafa Öncel & Umut Özercan";
			this.label2.Visible = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.panelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(130, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(453, 39);
			this.label1.TabIndex = 7;
			this.label1.Text = "Developed by Umut Özercan";
			this.label1.Visible = false;
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuCustomLabel4.AutoSize = true;
			this.panelAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(240, 160);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(226, 50);
			this.bunifuCustomLabel4.TabIndex = 6;
			this.bunifuCustomLabel4.Text = "Developer by Bombacan\r\nSonsuz Çeviri V2.0";
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuCustomLabel3.AutoSize = true;
			this.panelAnimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Red;
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(151, 58);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(451, 39);
			this.bunifuCustomLabel3.TabIndex = 5;
			this.bunifuCustomLabel3.Text = "Sonsuz Çeviriye Hoşgeldiniz";
			// 
			// comboBox2
			// 
			this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.panelAnimator.SetDecoration(this.comboBox2, BunifuAnimatorNS.DecorationType.None);
			this.comboBox2.ForeColor = System.Drawing.Color.ForestGreen;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce",
            "Arapça",
            "Rusça",
            "Fransızca",
            "Almanca",
            "Korece"});
			this.comboBox2.Location = new System.Drawing.Point(440, 216);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(101, 21);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.panelAnimator.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
			this.comboBox1.ForeColor = System.Drawing.Color.ForestGreen;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce",
            "Arapça",
            "Rusça",
            "Fransızca",
            "Almanca",
            "Korece"});
			this.comboBox1.Location = new System.Drawing.Point(440, 105);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(101, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.panelAnimator.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox2.ForeColor = System.Drawing.Color.DarkCyan;
			this.textBox2.Location = new System.Drawing.Point(49, 252);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(312, 26);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "Çevirilen Metin";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.panelAnimator.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox1.ForeColor = System.Drawing.Color.DarkCyan;
			this.textBox1.Location = new System.Drawing.Point(49, 71);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(312, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Çevrilecek Metin...";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.Visible = false;
			// 
			// panelAnimator
			// 
			this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
			this.panelAnimator.Cursor = null;
			animation8.AnimateOnlyDifferences = true;
			animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
			animation8.LeafCoeff = 0F;
			animation8.MaxTime = 1F;
			animation8.MinTime = 0F;
			animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
			animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
			animation8.MosaicSize = 0;
			animation8.Padding = new System.Windows.Forms.Padding(0);
			animation8.RotateCoeff = 0F;
			animation8.RotateLimit = 0F;
			animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
			animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
			animation8.TimeCoeff = 0F;
			animation8.TransparencyCoeff = 0F;
			this.panelAnimator.DefaultAnimation = animation8;
			// 
			// bunifuImageButton5
			// 
			this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
			this.panelAnimator.SetDecoration(this.bunifuImageButton5, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
			this.bunifuImageButton5.ImageActive = null;
			this.bunifuImageButton5.Location = new System.Drawing.Point(544, 132);
			this.bunifuImageButton5.Name = "bunifuImageButton5";
			this.bunifuImageButton5.Size = new System.Drawing.Size(39, 78);
			this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton5.TabIndex = 10;
			this.bunifuImageButton5.TabStop = false;
			this.bunifuImageButton5.Visible = false;
			this.bunifuImageButton5.Zoom = 10;
			this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
			// 
			// bunifuImageButton3
			// 
			this.bunifuImageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
			this.panelAnimator.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
			this.bunifuImageButton3.ImageActive = null;
			this.bunifuImageButton3.Location = new System.Drawing.Point(440, 132);
			this.bunifuImageButton3.Name = "bunifuImageButton3";
			this.bunifuImageButton3.Size = new System.Drawing.Size(101, 78);
			this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton3.TabIndex = 0;
			this.bunifuImageButton3.TabStop = false;
			this.bunifuImageButton3.Visible = false;
			this.bunifuImageButton3.Zoom = 10;
			this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
			// 
			// bunifuFlatButton3
			// 
			this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton3.BorderRadius = 0;
			this.bunifuFlatButton3.ButtonText = "    Ayarlar";
			this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelAnimator.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
			this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
			this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
			this.bunifuFlatButton3.Iconimage_right = null;
			this.bunifuFlatButton3.Iconimage_right_Selected = null;
			this.bunifuFlatButton3.Iconimage_Selected = null;
			this.bunifuFlatButton3.IconMarginLeft = 0;
			this.bunifuFlatButton3.IconMarginRight = 0;
			this.bunifuFlatButton3.IconRightVisible = true;
			this.bunifuFlatButton3.IconRightZoom = 0D;
			this.bunifuFlatButton3.IconVisible = true;
			this.bunifuFlatButton3.IconZoom = 40D;
			this.bunifuFlatButton3.IsTab = false;
			this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 171);
			this.bunifuFlatButton3.Name = "bunifuFlatButton3";
			this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Red;
			this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.LimeGreen;
			this.bunifuFlatButton3.selected = false;
			this.bunifuFlatButton3.Size = new System.Drawing.Size(206, 48);
			this.bunifuFlatButton3.TabIndex = 5;
			this.bunifuFlatButton3.Text = "    Ayarlar";
			this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
			// 
			// menubutton
			// 
			this.menubutton.BackColor = System.Drawing.Color.Transparent;
			this.panelAnimator.SetDecoration(this.menubutton, BunifuAnimatorNS.DecorationType.None);
			this.menubutton.Image = ((System.Drawing.Image)(resources.GetObject("menubutton.Image")));
			this.menubutton.ImageActive = null;
			this.menubutton.Location = new System.Drawing.Point(10, 6);
			this.menubutton.Name = "menubutton";
			this.menubutton.Size = new System.Drawing.Size(25, 25);
			this.menubutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.menubutton.TabIndex = 3;
			this.menubutton.TabStop = false;
			this.menubutton.Zoom = 10;
			this.menubutton.Click += new System.EventHandler(this.bunifuImageButton2_Click);
			// 
			// bunifuFlatButton2
			// 
			this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 0;
			this.bunifuFlatButton2.ButtonText = "    Yapımcılar";
			this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelAnimator.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
			this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
			this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 0;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = true;
			this.bunifuFlatButton2.IconRightZoom = 0D;
			this.bunifuFlatButton2.IconVisible = true;
			this.bunifuFlatButton2.IconZoom = 40D;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 127);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Red;
			this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.LimeGreen;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(206, 48);
			this.bunifuFlatButton2.TabIndex = 2;
			this.bunifuFlatButton2.Text = "    Yapımcılar";
			this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
			// 
			// bunifuFlatButton1
			// 
			this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "    AnaSayfa";
			this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
			this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
			this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0D;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 40D;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 78);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkRed;
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.LimeGreen;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(209, 48);
			this.bunifuFlatButton1.TabIndex = 1;
			this.bunifuFlatButton1.Text = "    AnaSayfa";
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
			// 
			// bunifuImageButton2
			// 
			this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
			this.panelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
			this.bunifuImageButton2.ImageActive = null;
			this.bunifuImageButton2.Location = new System.Drawing.Point(711, 3);
			this.bunifuImageButton2.Name = "bunifuImageButton2";
			this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
			this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton2.TabIndex = 5;
			this.bunifuImageButton2.TabStop = false;
			this.bunifuImageButton2.Zoom = 10;
			this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
			// 
			// bunifuImageButton4
			// 
			this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
			this.panelAnimator.SetDecoration(this.bunifuImageButton4, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton4.Image = global::Ceviri2.Properties.Resources.Dictionary;
			this.bunifuImageButton4.ImageActive = null;
			this.bunifuImageButton4.Location = new System.Drawing.Point(7, 3);
			this.bunifuImageButton4.Name = "bunifuImageButton4";
			this.bunifuImageButton4.Size = new System.Drawing.Size(25, 25);
			this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton4.TabIndex = 3;
			this.bunifuImageButton4.TabStop = false;
			this.bunifuImageButton4.Zoom = 10;
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.panelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(770, 3);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 0;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.BackColor = System.Drawing.Color.DimGray;
			this.panelAnimator.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sonsuzÇeviriV20ToolStripMenuItem,
            this.yapımcılarToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.programıKapatToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.ShowImageMargin = false;
			this.contextMenuStrip1.Size = new System.Drawing.Size(145, 92);
			// 
			// sonsuzÇeviriV20ToolStripMenuItem
			// 
			this.sonsuzÇeviriV20ToolStripMenuItem.Name = "sonsuzÇeviriV20ToolStripMenuItem";
			this.sonsuzÇeviriV20ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.sonsuzÇeviriV20ToolStripMenuItem.Text = "Sonsuz Çeviri V2.0";
			// 
			// yapımcılarToolStripMenuItem
			// 
			this.yapımcılarToolStripMenuItem.Name = "yapımcılarToolStripMenuItem";
			this.yapımcılarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.yapımcılarToolStripMenuItem.Text = "Yapımcılar";
			// 
			// ayarlarToolStripMenuItem
			// 
			this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
			this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.ayarlarToolStripMenuItem.Text = "Ayarlar";
			// 
			// programıKapatToolStripMenuItem
			// 
			this.programıKapatToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.DimGray;
			this.programıKapatToolStripMenuItem.Name = "programıKapatToolStripMenuItem";
			this.programıKapatToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.programıKapatToolStripMenuItem.Text = "Programı Kapat";
			this.programıKapatToolStripMenuItem.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
			// 
			// bunifuImageButton6
			// 
			this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
			this.panelAnimator.SetDecoration(this.bunifuImageButton6, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
			this.bunifuImageButton6.ImageActive = null;
			this.bunifuImageButton6.Location = new System.Drawing.Point(742, 3);
			this.bunifuImageButton6.Name = "bunifuImageButton6";
			this.bunifuImageButton6.Size = new System.Drawing.Size(25, 25);
			this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton6.TabIndex = 14;
			this.bunifuImageButton6.TabStop = false;
			this.bunifuImageButton6.Zoom = 10;
			this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
			// 
			// sonsuzayar1
			// 
			this.sonsuzayar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.panelAnimator.SetDecoration(this.sonsuzayar1, BunifuAnimatorNS.DecorationType.None);
			this.sonsuzayar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sonsuzayar1.Location = new System.Drawing.Point(0, 0);
			this.sonsuzayar1.Name = "sonsuzayar1";
			this.sonsuzayar1.Size = new System.Drawing.Size(588, 422);
			this.sonsuzayar1.TabIndex = 13;
			// 
			// Çeviri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.sideMenu);
			this.Controls.Add(this.Header);
			this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "Çeviri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ",,,,,,,";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.sideMenu.ResumeLayout(false);
			this.sideMenu.PerformLayout();
			this.Header.ResumeLayout(false);
			this.Header.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel sideMenu;
		private System.Windows.Forms.Panel Header;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.Framework.UI.BunifuImageButton menubutton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private BunifuAnimatorNS.BunifuTransition panelAnimator;
		private Bunifu.Framework.UI.BunifuCustomLabel menulabel;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem sonsuzÇeviriV20ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yapımcılarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programıKapatToolStripMenuItem;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
		private sonsuzayar sonsuzayar1;
	}
}

