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
			BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Çeviri));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.sideMenu = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.menulabel = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.menubutton = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.Header = new System.Windows.Forms.Panel();
			this.rightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.sonsuzÇeviriV20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yapımcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.programıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.yapimcilar1 = new Ceviri2.yapimcilar();
			this.homepage1 = new Ceviri2.homepage();
			this.sonsuzayar1 = new Ceviri2.sonsuzayar();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
			this.sideMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
			this.Header.SuspendLayout();
			this.rightClick.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// sideMenu
			// 
			this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.sideMenu.Controls.Add(this.pictureBox1);
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
			this.sideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.sideMenu_Paint);
			// 
			// pictureBox1
			// 
			this.panelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(173, 363);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(33, 22);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
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
			this.bunifuFlatButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
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
			// menubutton
			// 
			this.menubutton.BackColor = System.Drawing.Color.Transparent;
			this.panelAnimator.SetDecoration(this.menubutton, BunifuAnimatorNS.DecorationType.None);
			this.menubutton.Image = ((System.Drawing.Image)(resources.GetObject("menubutton.Image")));
			this.menubutton.ImageActive = null;
			this.menubutton.Location = new System.Drawing.Point(181, 6);
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
			this.bunifuFlatButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
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
			this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "    AnaSayfa";
			this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.DarkRed;
			this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
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
			this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Gold;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(209, 48);
			this.bunifuFlatButton1.TabIndex = 1;
			this.bunifuFlatButton1.Text = "    AnaSayfa";
			this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bunifuCustomLabel2.AutoSize = true;
			this.panelAnimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkRed;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 365);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(170, 20);
			this.bunifuCustomLabel2.TabIndex = 0;
			this.bunifuCustomLabel2.Text = "Dil: Türkçe (Varsayılan)";
			// 
			// Header
			// 
			this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
			this.Header.ContextMenuStrip = this.rightClick;
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
			// rightClick
			// 
			this.rightClick.BackColor = System.Drawing.Color.DodgerBlue;
			this.panelAnimator.SetDecoration(this.rightClick, BunifuAnimatorNS.DecorationType.None);
			this.rightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sonsuzÇeviriV20ToolStripMenuItem,
            this.yapımcılarToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.programıKapatToolStripMenuItem});
			this.rightClick.Name = "contextMenuStrip1";
			this.rightClick.ShowImageMargin = false;
			this.rightClick.Size = new System.Drawing.Size(145, 92);
			// 
			// sonsuzÇeviriV20ToolStripMenuItem
			// 
			this.sonsuzÇeviriV20ToolStripMenuItem.Name = "sonsuzÇeviriV20ToolStripMenuItem";
			this.sonsuzÇeviriV20ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.sonsuzÇeviriV20ToolStripMenuItem.Text = "Sonsuz Çeviri V2.1";
			this.sonsuzÇeviriV20ToolStripMenuItem.Click += new System.EventHandler(this.sonsuzÇeviriV20ToolStripMenuItem_Click);
			// 
			// yapımcılarToolStripMenuItem
			// 
			this.yapımcılarToolStripMenuItem.Name = "yapımcılarToolStripMenuItem";
			this.yapımcılarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.yapımcılarToolStripMenuItem.Text = "Yapımcılar";
			// 
			// ayarlarToolStripMenuItem
			// 
			this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
			this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.ayarlarToolStripMenuItem.Text = "Ayarlar";
			this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
			// 
			// programıKapatToolStripMenuItem
			// 
			this.programıKapatToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.DimGray;
			this.programıKapatToolStripMenuItem.Name = "programıKapatToolStripMenuItem";
			this.programıKapatToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.programıKapatToolStripMenuItem.Text = "Programı Kapat";
			this.programıKapatToolStripMenuItem.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
			// 
			// bunifuImageButton2
			// 
			this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
			this.panelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
			this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
			this.bunifuImageButton2.ImageActive = null;
			this.bunifuImageButton2.Location = new System.Drawing.Point(739, 3);
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
			this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
			this.bunifuImageButton4.ImageActive = null;
			this.bunifuImageButton4.Location = new System.Drawing.Point(7, 3);
			this.bunifuImageButton4.Name = "bunifuImageButton4";
			this.bunifuImageButton4.Size = new System.Drawing.Size(25, 25);
			this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton4.TabIndex = 3;
			this.bunifuImageButton4.TabStop = false;
			this.bunifuImageButton4.Zoom = 10;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.panelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(42, 9);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(150, 13);
			this.bunifuCustomLabel1.TabIndex = 2;
			this.bunifuCustomLabel1.Text = "Sonsuz Çeviri V2.1 | Başlangıç";
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
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.Header;
			this.bunifuDragControl1.Vertical = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.panel2.Controls.Add(this.yapimcilar1);
			this.panel2.Controls.Add(this.homepage1);
			this.panel2.Controls.Add(this.sonsuzayar1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.bunifuCustomLabel4);
			this.panel2.Controls.Add(this.bunifuCustomLabel3);
			this.panelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(212, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(588, 422);
			this.panel2.TabIndex = 2;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// yapimcilar1
			// 
			this.yapimcilar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.panelAnimator.SetDecoration(this.yapimcilar1, BunifuAnimatorNS.DecorationType.None);
			this.yapimcilar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yapimcilar1.Location = new System.Drawing.Point(0, 0);
			this.yapimcilar1.Name = "yapimcilar1";
			this.yapimcilar1.Size = new System.Drawing.Size(588, 422);
			this.yapimcilar1.TabIndex = 15;
			this.yapimcilar1.Visible = false;
			// 
			// homepage1
			// 
			this.homepage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.panelAnimator.SetDecoration(this.homepage1, BunifuAnimatorNS.DecorationType.None);
			this.homepage1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.homepage1.Location = new System.Drawing.Point(0, 0);
			this.homepage1.Name = "homepage1";
			this.homepage1.Size = new System.Drawing.Size(588, 422);
			this.homepage1.TabIndex = 14;
			this.homepage1.Visible = false;
			// 
			// sonsuzayar1
			// 
			this.panelAnimator.SetDecoration(this.sonsuzayar1, BunifuAnimatorNS.DecorationType.None);
			this.sonsuzayar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sonsuzayar1.Location = new System.Drawing.Point(0, 0);
			this.sonsuzayar1.Name = "sonsuzayar1";
			this.sonsuzayar1.Size = new System.Drawing.Size(588, 422);
			this.sonsuzayar1.TabIndex = 13;
			this.sonsuzayar1.Visible = false;
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
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuCustomLabel4.AutoSize = true;
			this.panelAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
			this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(175, 141);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(0, 25);
			this.bunifuCustomLabel4.TabIndex = 6;
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
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(77, 29);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(451, 39);
			this.bunifuCustomLabel3.TabIndex = 5;
			this.bunifuCustomLabel3.Text = "Sonsuz Çeviriye Hoşgeldiniz";
			// 
			// panelAnimator
			// 
			this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
			this.panelAnimator.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
			animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
			animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 0F;
			this.panelAnimator.DefaultAnimation = animation1;
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
			this.Text = "Sonsuz Çeviri";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.sideMenu.ResumeLayout(false);
			this.sideMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
			this.Header.ResumeLayout(false);
			this.Header.PerformLayout();
			this.rightClick.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
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
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
		private BunifuAnimatorNS.BunifuTransition panelAnimator;
		private Bunifu.Framework.UI.BunifuCustomLabel menulabel;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
		private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ContextMenuStrip rightClick;
		private System.Windows.Forms.ToolStripMenuItem sonsuzÇeviriV20ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yapımcılarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programıKapatToolStripMenuItem;
		private sonsuzayar sonsuzayar1;
		private homepage homepage1;
		private yapimcilar yapimcilar1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

