
namespace DemoForXiaoxiang
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRunMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssRunMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_camState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_PLCState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 29);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1019, 27);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(763, 29);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(763, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(256, 29);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "湖南大学潇湘实验室";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSetting,
            this.tsmRunMode,
            this.tsmHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSetting
            // 
            this.tsmSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectSetToolStripMenuItem,
            this.SystemSetToolStripMenuItem});
            this.tsmSetting.Image = ((System.Drawing.Image)(resources.GetObject("tsmSetting.Image")));
            this.tsmSetting.Name = "tsmSetting";
            this.tsmSetting.Size = new System.Drawing.Size(60, 23);
            this.tsmSetting.Text = "设置";
            // 
            // tsmRunMode
            // 
            this.tsmRunMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoRunToolStripMenuItem,
            this.StopRunToolStripMenuItem});
            this.tsmRunMode.Image = ((System.Drawing.Image)(resources.GetObject("tsmRunMode.Image")));
            this.tsmRunMode.Name = "tsmRunMode";
            this.tsmRunMode.Size = new System.Drawing.Size(84, 23);
            this.tsmRunMode.Text = "运行模式";
            // 
            // tsmHelp
            // 
            this.tsmHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsmHelp.Image")));
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(60, 23);
            this.tsmHelp.Text = "帮助";
            // 
            // ProjectSetToolStripMenuItem
            // 
            this.ProjectSetToolStripMenuItem.Name = "ProjectSetToolStripMenuItem";
            this.ProjectSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProjectSetToolStripMenuItem.Text = "项目设置";
            // 
            // SystemSetToolStripMenuItem
            // 
            this.SystemSetToolStripMenuItem.Name = "SystemSetToolStripMenuItem";
            this.SystemSetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SystemSetToolStripMenuItem.Text = "系统设置";
            // 
            // AutoRunToolStripMenuItem
            // 
            this.AutoRunToolStripMenuItem.Name = "AutoRunToolStripMenuItem";
            this.AutoRunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AutoRunToolStripMenuItem.Text = "自动运行";
            // 
            // StopRunToolStripMenuItem
            // 
            this.StopRunToolStripMenuItem.Name = "StopRunToolStripMenuItem";
            this.StopRunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StopRunToolStripMenuItem.Text = "停止运行";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssRunMode,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tss_camState,
            this.toolStripStatusLabel3,
            this.tss_PLCState,
            this.tss_time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1019, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssRunMode
            // 
            this.tssRunMode.Name = "tssRunMode";
            this.tssRunMode.Size = new System.Drawing.Size(72, 21);
            this.tssRunMode.Text = "#####      ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(653, 21);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(32, 21);
            this.toolStripStatusLabel2.Text = "相机";
            // 
            // tss_camState
            // 
            this.tss_camState.ForeColor = System.Drawing.Color.LimeGreen;
            this.tss_camState.Name = "tss_camState";
            this.tss_camState.Size = new System.Drawing.Size(26, 21);
            this.tss_camState.Text = "▇▇ ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(29, 21);
            this.toolStripStatusLabel3.Text = "PLC";
            // 
            // tss_PLCState
            // 
            this.tss_PLCState.ForeColor = System.Drawing.Color.LimeGreen;
            this.tss_PLCState.Name = "tss_PLCState";
            this.tss_PLCState.Size = new System.Drawing.Size(26, 21);
            this.tss_PLCState.Text = "▇▇ ";
            // 
            // tss_time
            // 
            this.tss_time.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tss_time.Name = "tss_time";
            this.tss_time.Size = new System.Drawing.Size(130, 21);
            this.tss_time.Text = "2024/01/01 00:00:00";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 587);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSetting;
        private System.Windows.Forms.ToolStripMenuItem ProjectSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRunMode;
        private System.Windows.Forms.ToolStripMenuItem AutoRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssRunMode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tss_camState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tss_PLCState;
        private System.Windows.Forms.ToolStripStatusLabel tss_time;
    }
}

