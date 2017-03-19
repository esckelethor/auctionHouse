namespace auctionHouse
{
    partial class AuctionHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuctionHouse));
            this.pnlTree = new System.Windows.Forms.Panel();
            this.pnlBuyList = new System.Windows.Forms.Panel();
            this.pnlItemsToBuy = new System.Windows.Forms.Panel();
            this.lblBuyList = new System.Windows.Forms.Label();
            this.treeAH = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLblTitle = new System.Windows.Forms.ToolStripLabel();
            this.btnGradeCrude = new System.Windows.Forms.ToolStripButton();
            this.btnGradeBasic = new System.Windows.Forms.ToolStripButton();
            this.btnGradeGrand = new System.Windows.Forms.ToolStripButton();
            this.btnGradeRare = new System.Windows.Forms.ToolStripButton();
            this.btnGradeArcane = new System.Windows.Forms.ToolStripButton();
            this.btnGradeHeroic = new System.Windows.Forms.ToolStripButton();
            this.btnGradeUnique = new System.Windows.Forms.ToolStripButton();
            this.btnGradeCelestial = new System.Windows.Forms.ToolStripButton();
            this.btnGradeDivine = new System.Windows.Forms.ToolStripButton();
            this.btnGradeEpic = new System.Windows.Forms.ToolStripButton();
            this.btnGradeLegendary = new System.Windows.Forms.ToolStripButton();
            this.btnGradeMythic = new System.Windows.Forms.ToolStripButton();
            this.pnlListItems = new System.Windows.Forms.Panel();
            this.pnlBuscador = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaxLevel = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.txtMinLevel = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlBuy = new System.Windows.Forms.Panel();
            this.lblMyCoins = new System.Windows.Forms.Label();
            this.lblTextMyCoins = new listaPersonalizada.lblPrecio();
            this.lblPrecio = new listaPersonalizada.lblPrecio();
            this.btnBuy = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.pnlTree.SuspendLayout();
            this.pnlBuyList.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.pnlBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.pnlBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTree
            // 
            resources.ApplyResources(this.pnlTree, "pnlTree");
            this.pnlTree.BackColor = System.Drawing.Color.OldLace;
            this.pnlTree.Controls.Add(this.pnlBuyList);
            this.pnlTree.Controls.Add(this.treeAH);
            this.pnlTree.Name = "pnlTree";
            // 
            // pnlBuyList
            // 
            this.pnlBuyList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBuyList.Controls.Add(this.pnlItemsToBuy);
            this.pnlBuyList.Controls.Add(this.lblBuyList);
            resources.ApplyResources(this.pnlBuyList, "pnlBuyList");
            this.pnlBuyList.Name = "pnlBuyList";
            // 
            // pnlItemsToBuy
            // 
            this.pnlItemsToBuy.AllowDrop = true;
            resources.ApplyResources(this.pnlItemsToBuy, "pnlItemsToBuy");
            this.pnlItemsToBuy.Name = "pnlItemsToBuy";
            this.pnlItemsToBuy.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlItemsToBuy_DragDrop);
            this.pnlItemsToBuy.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlItemsToBuy_DragEnter);
            // 
            // lblBuyList
            // 
            this.lblBuyList.BackColor = System.Drawing.Color.BurlyWood;
            this.lblBuyList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblBuyList, "lblBuyList");
            this.lblBuyList.Name = "lblBuyList";
            // 
            // treeAH
            // 
            this.treeAH.BackColor = System.Drawing.Color.OldLace;
            resources.ApplyResources(this.treeAH, "treeAH");
            this.treeAH.ImageList = this.imageList;
            this.treeAH.Name = "treeAH";
            this.treeAH.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeAH.Nodes"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeAH.Nodes1"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeAH.Nodes2"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeAH.Nodes3")))});
            this.treeAH.ShowLines = false;
            this.treeAH.ShowPlusMinus = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "blank.png");
            this.imageList.Images.SetKeyName(1, "gilda star.png");
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.OldLace;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUndo,
            this.btnRedo,
            this.toolStripSeparator,
            this.toolStripLblTitle,
            this.btnGradeCrude,
            this.btnGradeBasic,
            this.btnGradeGrand,
            this.btnGradeRare,
            this.btnGradeArcane,
            this.btnGradeHeroic,
            this.btnGradeUnique,
            this.btnGradeCelestial,
            this.btnGradeDivine,
            this.btnGradeEpic,
            this.btnGradeLegendary,
            this.btnGradeMythic});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Name = "toolStrip";
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = global::auctionHouse.drawable.undoOff;
            resources.ApplyResources(this.btnUndo, "btnUndo");
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = global::auctionHouse.drawable.redoOff;
            resources.ApplyResources(this.btnRedo, "btnRedo");
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // toolStripLblTitle
            // 
            resources.ApplyResources(this.toolStripLblTitle, "toolStripLblTitle");
            this.toolStripLblTitle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLblTitle.Name = "toolStripLblTitle";
            // 
            // btnGradeCrude
            // 
            this.btnGradeCrude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeCrude.Image = global::auctionHouse.drawableGrade.crudeOff;
            resources.ApplyResources(this.btnGradeCrude, "btnGradeCrude");
            this.btnGradeCrude.Name = "btnGradeCrude";
            this.btnGradeCrude.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeBasic
            // 
            this.btnGradeBasic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeBasic.Image = global::auctionHouse.drawableGrade.basicOff;
            resources.ApplyResources(this.btnGradeBasic, "btnGradeBasic");
            this.btnGradeBasic.Name = "btnGradeBasic";
            this.btnGradeBasic.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeGrand
            // 
            this.btnGradeGrand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeGrand.Image = global::auctionHouse.drawableGrade.grandOff;
            resources.ApplyResources(this.btnGradeGrand, "btnGradeGrand");
            this.btnGradeGrand.Name = "btnGradeGrand";
            this.btnGradeGrand.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeRare
            // 
            this.btnGradeRare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeRare.Image = global::auctionHouse.drawableGrade.rareOff;
            resources.ApplyResources(this.btnGradeRare, "btnGradeRare");
            this.btnGradeRare.Name = "btnGradeRare";
            this.btnGradeRare.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeArcane
            // 
            this.btnGradeArcane.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeArcane.Image = global::auctionHouse.drawableGrade.arcaneOff;
            resources.ApplyResources(this.btnGradeArcane, "btnGradeArcane");
            this.btnGradeArcane.Name = "btnGradeArcane";
            this.btnGradeArcane.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeHeroic
            // 
            this.btnGradeHeroic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeHeroic.Image = global::auctionHouse.drawableGrade.heroicOff;
            resources.ApplyResources(this.btnGradeHeroic, "btnGradeHeroic");
            this.btnGradeHeroic.Name = "btnGradeHeroic";
            this.btnGradeHeroic.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeUnique
            // 
            this.btnGradeUnique.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeUnique.Image = global::auctionHouse.drawableGrade.uniqueOff;
            resources.ApplyResources(this.btnGradeUnique, "btnGradeUnique");
            this.btnGradeUnique.Name = "btnGradeUnique";
            this.btnGradeUnique.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeCelestial
            // 
            this.btnGradeCelestial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeCelestial.Image = global::auctionHouse.drawableGrade.celestialOff;
            resources.ApplyResources(this.btnGradeCelestial, "btnGradeCelestial");
            this.btnGradeCelestial.Name = "btnGradeCelestial";
            this.btnGradeCelestial.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeDivine
            // 
            this.btnGradeDivine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeDivine.Image = global::auctionHouse.drawableGrade.divineOff;
            resources.ApplyResources(this.btnGradeDivine, "btnGradeDivine");
            this.btnGradeDivine.Name = "btnGradeDivine";
            this.btnGradeDivine.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeEpic
            // 
            this.btnGradeEpic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeEpic.Image = global::auctionHouse.drawableGrade.epicOff;
            resources.ApplyResources(this.btnGradeEpic, "btnGradeEpic");
            this.btnGradeEpic.Name = "btnGradeEpic";
            this.btnGradeEpic.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeLegendary
            // 
            this.btnGradeLegendary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeLegendary.Image = global::auctionHouse.drawableGrade.legendaryOff;
            resources.ApplyResources(this.btnGradeLegendary, "btnGradeLegendary");
            this.btnGradeLegendary.Name = "btnGradeLegendary";
            this.btnGradeLegendary.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnGradeMythic
            // 
            this.btnGradeMythic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGradeMythic.Image = global::auctionHouse.drawableGrade.mythicOff;
            resources.ApplyResources(this.btnGradeMythic, "btnGradeMythic");
            this.btnGradeMythic.Name = "btnGradeMythic";
            this.btnGradeMythic.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // pnlListItems
            // 
            resources.ApplyResources(this.pnlListItems, "pnlListItems");
            this.pnlListItems.BackColor = System.Drawing.Color.OldLace;
            this.pnlListItems.Name = "pnlListItems";
            // 
            // pnlBuscador
            // 
            resources.ApplyResources(this.pnlBuscador, "pnlBuscador");
            this.pnlBuscador.BackColor = System.Drawing.Color.OldLace;
            this.pnlBuscador.Controls.Add(this.imgLogo);
            this.pnlBuscador.Controls.Add(this.txtMaxLevel);
            this.pnlBuscador.Controls.Add(this.btnSearch);
            this.pnlBuscador.Controls.Add(this.txtSearch);
            this.pnlBuscador.Controls.Add(this.lblSeparator);
            this.pnlBuscador.Controls.Add(this.txtMinLevel);
            this.pnlBuscador.Controls.Add(this.lblLevel);
            this.pnlBuscador.Controls.Add(this.btnReset);
            this.pnlBuscador.Name = "pnlBuscador";
            // 
            // imgLogo
            // 
            resources.ApplyResources(this.imgLogo, "imgLogo");
            this.imgLogo.ContextMenuStrip = this.contextMenu;
            this.imgLogo.Image = global::auctionHouse.drawable.aaEn;
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.TabStop = false;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.spanishToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.languageMenuItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            resources.ApplyResources(this.spanishToolStripMenuItem, "spanishToolStripMenuItem");
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.languageMenuItem_Click);
            // 
            // txtMaxLevel
            // 
            this.txtMaxLevel.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.txtMaxLevel, "txtMaxLevel");
            this.txtMaxLevel.Name = "txtMaxLevel";
            this.toolTip.SetToolTip(this.txtMaxLevel, resources.GetString("txtMaxLevel.ToolTip"));
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.toolTip.SetToolTip(this.txtSearch, resources.GetString("txtSearch.ToolTip"));
            // 
            // lblSeparator
            // 
            resources.ApplyResources(this.lblSeparator, "lblSeparator");
            this.lblSeparator.Name = "lblSeparator";
            // 
            // txtMinLevel
            // 
            this.txtMinLevel.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.txtMinLevel, "txtMinLevel");
            this.txtMinLevel.Name = "txtMinLevel";
            this.toolTip.SetToolTip(this.txtMinLevel, resources.GetString("txtMinLevel.ToolTip"));
            // 
            // lblLevel
            // 
            resources.ApplyResources(this.lblLevel, "lblLevel");
            this.lblLevel.Name = "lblLevel";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // pnlBuy
            // 
            this.pnlBuy.BackColor = System.Drawing.Color.OldLace;
            this.pnlBuy.Controls.Add(this.lblMyCoins);
            this.pnlBuy.Controls.Add(this.lblTextMyCoins);
            this.pnlBuy.Controls.Add(this.lblPrecio);
            this.pnlBuy.Controls.Add(this.btnBuy);
            resources.ApplyResources(this.pnlBuy, "pnlBuy");
            this.pnlBuy.Name = "pnlBuy";
            // 
            // lblMyCoins
            // 
            resources.ApplyResources(this.lblMyCoins, "lblMyCoins");
            this.lblMyCoins.Name = "lblMyCoins";
            // 
            // lblTextMyCoins
            // 
            resources.ApplyResources(this.lblTextMyCoins, "lblTextMyCoins");
            this.lblTextMyCoins.Name = "lblTextMyCoins";
            // 
            // lblPrecio
            // 
            resources.ApplyResources(this.lblPrecio, "lblPrecio");
            this.lblPrecio.Name = "lblPrecio";
            // 
            // btnBuy
            // 
            resources.ApplyResources(this.btnBuy, "btnBuy");
            this.btnBuy.BackColor = System.Drawing.Color.BurlyWood;
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // toolStripSeparator
            // 
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            this.toolStripSeparator.BackColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator.Name = "toolStripSeparator";
            // 
            // AuctionHouse
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBuy);
            this.Controls.Add(this.pnlBuscador);
            this.Controls.Add(this.pnlListItems);
            this.Controls.Add(this.pnlTree);
            this.Controls.Add(this.toolStrip);
            this.Name = "AuctionHouse";
            this.pnlTree.ResumeLayout(false);
            this.pnlBuyList.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnlBuscador.ResumeLayout(false);
            this.pnlBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.pnlBuy.ResumeLayout(false);
            this.pnlBuy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTree;
        private System.Windows.Forms.TreeView treeAH;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel pnlListItems;
        private System.Windows.Forms.Panel pnlBuscador;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.TextBox txtMinLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtMaxLevel;
        private System.Windows.Forms.Panel pnlBuy;
        private System.Windows.Forms.Button btnBuy;
        private listaPersonalizada.lblPrecio lblPrecio;
        private System.Windows.Forms.ToolStripButton btnGradeCrude;
        private System.Windows.Forms.ToolStripButton btnGradeBasic;
        private System.Windows.Forms.ToolStripButton btnGradeGrand;
        private System.Windows.Forms.ToolStripButton btnGradeRare;
        private System.Windows.Forms.ToolStripButton btnGradeArcane;
        private System.Windows.Forms.Label lblMyCoins;
        private listaPersonalizada.lblPrecio lblTextMyCoins;
        private System.Windows.Forms.ToolStripButton btnGradeHeroic;
        private System.Windows.Forms.ToolStripButton btnGradeUnique;
        private System.Windows.Forms.ToolStripButton btnGradeCelestial;
        private System.Windows.Forms.ToolStripButton btnGradeDivine;
        private System.Windows.Forms.ToolStripButton btnGradeEpic;
        private System.Windows.Forms.ToolStripButton btnGradeLegendary;
        private System.Windows.Forms.ToolStripButton btnGradeMythic;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlBuyList;
        private System.Windows.Forms.Label lblBuyList;
        private System.Windows.Forms.Panel pnlItemsToBuy;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripLabel toolStripLblTitle;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    }
}

