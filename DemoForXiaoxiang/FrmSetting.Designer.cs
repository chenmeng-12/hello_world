
namespace DemoForXiaoxiang
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("配方");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.打开图片OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空图片CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tscbxFormulaList = new System.Windows.Forms.ToolStripComboBox();
            this.tsbtnSvae = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOpenImage = new System.Windows.Forms.ToolStripButton();
            this.tsbtnClearImage = new System.Windows.Forms.ToolStripButton();
            this.tscbxCamList = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.自动对焦ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.目标检测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.类别预测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pgdMain = new System.Windows.Forms.PropertyGrid();
            this.tvwMain = new System.Windows.Forms.TreeView();
            this.imageView1 = new System.Windows.Forms.ImageView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvMain = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.tsPicNavBtns = new System.Windows.Forms.ToolStrip();
            this.tsbtnFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPre = new System.Windows.Forms.ToolStripButton();
            this.tstxtIndex = new System.Windows.Forms.ToolStripTextBox();
            this.tslblSlash = new System.Windows.Forms.ToolStripButton();
            this.tslblTotal = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLast = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tsPicNavBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.tsmiEdit,
            this.其他ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiSave,
            this.tsmiDelete,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNew.Image")));
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(180, 22);
            this.tsmiNew.Text = "新建(&N)";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(180, 22);
            this.tsmiSave.Text = "保存(&S)";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmiDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmiDelete.Text = "删除(&D)";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开图片OToolStripMenuItem,
            this.清空图片CToolStripMenuItem});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(59, 21);
            this.tsmiEdit.Text = "编辑(&E)";
            // 
            // 打开图片OToolStripMenuItem
            // 
            this.打开图片OToolStripMenuItem.Name = "打开图片OToolStripMenuItem";
            this.打开图片OToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开图片OToolStripMenuItem.Text = "打开图片(&O)";
            // 
            // 清空图片CToolStripMenuItem
            // 
            this.清空图片CToolStripMenuItem.Name = "清空图片CToolStripMenuItem";
            this.清空图片CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清空图片CToolStripMenuItem.Text = "清空图片(&C)";
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNew,
            this.tscbxFormulaList,
            this.tsbtnSvae,
            this.tsbtnDelete,
            this.tsbtnOpenImage,
            this.tsbtnClearImage,
            this.tscbxCamList,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1206, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNew.Text = "新建配方";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tscbxFormulaList
            // 
            this.tscbxFormulaList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxFormulaList.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscbxFormulaList.Name = "tscbxFormulaList";
            this.tscbxFormulaList.Size = new System.Drawing.Size(121, 25);
            this.tscbxFormulaList.SelectedIndexChanged += new System.EventHandler(this.tscbxFormulaList_SelectedIndexChanged);
            // 
            // tsbtnSvae
            // 
            this.tsbtnSvae.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSvae.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSvae.Image")));
            this.tsbtnSvae.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSvae.Name = "tsbtnSvae";
            this.tsbtnSvae.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSvae.Text = "保存配方";
            this.tsbtnSvae.Click += new System.EventHandler(this.tsbtnSvae_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDelete.Text = "删除当前配方";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsbtnOpenImage
            // 
            this.tsbtnOpenImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpenImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOpenImage.Image")));
            this.tsbtnOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpenImage.Name = "tsbtnOpenImage";
            this.tsbtnOpenImage.Size = new System.Drawing.Size(23, 22);
            this.tsbtnOpenImage.Text = "打开图片";
            this.tsbtnOpenImage.Click += new System.EventHandler(this.tsbtnOpenImage_Click);
            // 
            // tsbtnClearImage
            // 
            this.tsbtnClearImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnClearImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClearImage.Image")));
            this.tsbtnClearImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClearImage.Name = "tsbtnClearImage";
            this.tsbtnClearImage.Size = new System.Drawing.Size(23, 22);
            this.tsbtnClearImage.Text = "清除图片";
            this.tsbtnClearImage.Click += new System.EventHandler(this.tsbtnClearImage_Click);
            // 
            // tscbxCamList
            // 
            this.tscbxCamList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxCamList.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscbxCamList.Name = "tscbxCamList";
            this.tscbxCamList.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动对焦ToolStripMenuItem,
            this.目标检测ToolStripMenuItem,
            this.类别预测ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripDropDownButton1.Text = "运行(&R)";
            // 
            // 自动对焦ToolStripMenuItem
            // 
            this.自动对焦ToolStripMenuItem.Name = "自动对焦ToolStripMenuItem";
            this.自动对焦ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.自动对焦ToolStripMenuItem.Text = "自动对焦";
            // 
            // 目标检测ToolStripMenuItem
            // 
            this.目标检测ToolStripMenuItem.Name = "目标检测ToolStripMenuItem";
            this.目标检测ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.目标检测ToolStripMenuItem.Text = "目标检测";
            // 
            // 类别预测ToolStripMenuItem
            // 
            this.类别预测ToolStripMenuItem.Name = "类别预测ToolStripMenuItem";
            this.类别预测ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.类别预测ToolStripMenuItem.Text = "类别预测";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pgdMain);
            this.splitContainer1.Panel1.Controls.Add(this.tvwMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageView1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1206, 564);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 2;
            // 
            // pgdMain
            // 
            this.pgdMain.Location = new System.Drawing.Point(3, 103);
            this.pgdMain.Name = "pgdMain";
            this.pgdMain.Size = new System.Drawing.Size(237, 464);
            this.pgdMain.TabIndex = 1;
            this.pgdMain.ToolbarVisible = false;
            // 
            // tvwMain
            // 
            this.tvwMain.Location = new System.Drawing.Point(3, 3);
            this.tvwMain.Name = "tvwMain";
            treeNode2.Name = "Root";
            treeNode2.Text = "配方";
            this.tvwMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvwMain.Size = new System.Drawing.Size(237, 94);
            this.tvwMain.TabIndex = 0;
            this.tvwMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwMain_NodeMouseClick);
            // 
            // imageView1
            // 
            this.imageView1.AllowDrop = true;
            this.imageView1.BackColor = System.Drawing.Color.Silver;
            this.imageView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageView1.Image = null;
            this.imageView1.ImageScale = 0F;
            this.imageView1.Location = new System.Drawing.Point(0, 0);
            this.imageView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageView1.Name = "imageView1";
            this.imageView1.Size = new System.Drawing.Size(762, 564);
            this.imageView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvMain);
            this.panel1.Controls.Add(this.tsPicNavBtns);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(762, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 564);
            this.panel1.TabIndex = 0;
            // 
            // lvMain
            // 
            this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMain.HideSelection = false;
            this.lvMain.LargeImageList = this.imageList1;
            this.lvMain.Location = new System.Drawing.Point(0, 25);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(196, 539);
            this.lvMain.TabIndex = 2;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.SelectedIndexChanged += new System.EventHandler(this.lvMain_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(120, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tsPicNavBtns
            // 
            this.tsPicNavBtns.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPicNavBtns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFirst,
            this.tsbtnPre,
            this.tstxtIndex,
            this.tslblSlash,
            this.tslblTotal,
            this.tsbtnNext,
            this.tsbtnLast});
            this.tsPicNavBtns.Location = new System.Drawing.Point(0, 0);
            this.tsPicNavBtns.Name = "tsPicNavBtns";
            this.tsPicNavBtns.Size = new System.Drawing.Size(196, 25);
            this.tsPicNavBtns.TabIndex = 1;
            this.tsPicNavBtns.Text = "toolStrip1";
            // 
            // tsbtnFirst
            // 
            this.tsbtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFirst.Image")));
            this.tsbtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFirst.Name = "tsbtnFirst";
            this.tsbtnFirst.Size = new System.Drawing.Size(23, 22);
            this.tsbtnFirst.Text = "第一张";
            this.tsbtnFirst.Click += new System.EventHandler(this.tsbtnFirst_Click);
            // 
            // tsbtnPre
            // 
            this.tsbtnPre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPre.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPre.Image")));
            this.tsbtnPre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPre.Name = "tsbtnPre";
            this.tsbtnPre.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPre.Text = "上一张";
            this.tsbtnPre.Click += new System.EventHandler(this.tsbtnPre_Click);
            // 
            // tstxtIndex
            // 
            this.tstxtIndex.Name = "tstxtIndex";
            this.tstxtIndex.Size = new System.Drawing.Size(50, 25);
            this.tstxtIndex.Text = "0";
            this.tstxtIndex.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstxtIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstxtIndex_KeyDown);
            // 
            // tslblSlash
            // 
            this.tslblSlash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslblSlash.Name = "tslblSlash";
            this.tslblSlash.Size = new System.Drawing.Size(23, 22);
            this.tslblSlash.Text = "/";
            // 
            // tslblTotal
            // 
            this.tslblTotal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslblTotal.Name = "tslblTotal";
            this.tslblTotal.Size = new System.Drawing.Size(23, 22);
            this.tslblTotal.Text = "0";
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNext.Image")));
            this.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNext.Text = "下一张";
            this.tsbtnNext.Click += new System.EventHandler(this.tsbtnNext_Click);
            // 
            // tsbtnLast
            // 
            this.tsbtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLast.Image")));
            this.tsbtnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLast.Name = "tsbtnLast";
            this.tsbtnLast.Size = new System.Drawing.Size(23, 22);
            this.tsbtnLast.Text = "最后一张";
            this.tsbtnLast.Click += new System.EventHandler(this.tsbtnLast_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 614);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsPicNavBtns.ResumeLayout(false);
            this.tsPicNavBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem 打开图片OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空图片CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
        private System.Windows.Forms.ToolStripComboBox tscbxFormulaList;
        private System.Windows.Forms.ToolStripButton tsbtnSvae;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnOpenImage;
        private System.Windows.Forms.ToolStripButton tsbtnClearImage;
        private System.Windows.Forms.ToolStripComboBox tscbxCamList;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid pgdMain;
        private System.Windows.Forms.TreeView tvwMain;
        private System.Windows.Forms.ToolStripMenuItem 自动对焦ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 目标检测ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 类别预测ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ToolStrip tsPicNavBtns;
        private System.Windows.Forms.ToolStripButton tsbtnFirst;
        private System.Windows.Forms.ToolStripButton tsbtnPre;
        private System.Windows.Forms.ToolStripTextBox tstxtIndex;
        private System.Windows.Forms.ToolStripButton tslblSlash;
        private System.Windows.Forms.ToolStripButton tslblTotal;
        private System.Windows.Forms.ToolStripButton tsbtnNext;
        private System.Windows.Forms.ToolStripButton tsbtnLast;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageView imageView1;
    }
}