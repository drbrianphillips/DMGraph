namespace Graphing_DRAINMOD
{
    partial class Main2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Plot Area     ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("X Axis     ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Primary Y Axis          ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Secondary Y Axis          ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("General Plot Format", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Water Table Depth");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Dry Zone Depth");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Surface Storage");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Rainfall");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Infiltration");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Evaporation");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Drainage");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Surface Runoff");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Water Loss");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Hydrology Variables", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Observed File 1");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Observed File 2");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Observed File 3");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Observed Data Files", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonApplyClose = new System.Windows.Forms.Button();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerMain.BackgroundImage = global::Graphing_DRAINMOD.Properties.Resources.background4;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackgroundImage = global::Graphing_DRAINMOD.Properties.Resources.background4;
            this.splitContainerMain.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerMain.Panel2.Controls.Add(this.panelButtons);
            this.splitContainerMain.Size = new System.Drawing.Size(1150, 536);
            this.splitContainerMain.SplitterDistance = 186;
            this.splitContainerMain.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeGeneral";
            treeNode1.Text = "Plot Area     ";
            treeNode2.Name = "NodeXAxis";
            treeNode2.Text = "X Axis     ";
            treeNode3.Name = "NodePrimaryY";
            treeNode3.Text = "Primary Y Axis          ";
            treeNode4.Name = "NodeSecondaryY";
            treeNode4.Text = "Secondary Y Axis          ";
            treeNode5.BackColor = System.Drawing.Color.White;
            treeNode5.ForeColor = System.Drawing.Color.Black;
            treeNode5.Name = "NodePlotArea";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "General Plot Format";
            treeNode6.Name = "NodeWaterTableDepth";
            treeNode6.Text = "Water Table Depth";
            treeNode7.Name = "NodeDryZoneDepth";
            treeNode7.Text = "Dry Zone Depth";
            treeNode8.Name = "NodeSurfaceStorage";
            treeNode8.Text = "Surface Storage";
            treeNode9.Name = "NodeRainfall";
            treeNode9.Text = "Rainfall";
            treeNode10.Name = "NodeInfiltration";
            treeNode10.Text = "Infiltration";
            treeNode11.Name = "NodeEvaporation";
            treeNode11.Text = "Evaporation";
            treeNode12.Name = "NodeDrainage";
            treeNode12.Text = "Drainage";
            treeNode13.Name = "NodeSurfaceRunoff";
            treeNode13.Text = "Surface Runoff";
            treeNode14.Name = "NodeWaterLoss";
            treeNode14.Text = "Water Loss";
            treeNode15.BackColor = System.Drawing.Color.White;
            treeNode15.Name = "NodeHydrology";
            treeNode15.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode15.Text = "Hydrology Variables";
            treeNode16.Name = "NodeObserved1";
            treeNode16.Text = "Observed File 1";
            treeNode17.Name = "NodeObserved2";
            treeNode17.Text = "Observed File 2";
            treeNode18.Name = "NodeObserved3";
            treeNode18.Text = "Observed File 3";
            treeNode19.BackColor = System.Drawing.Color.White;
            treeNode19.Name = "NodeObserved";
            treeNode19.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode19.Text = "Observed Data Files";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode15,
            treeNode19});
            this.treeView1.Size = new System.Drawing.Size(186, 536);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.BackgroundImage = global::Graphing_DRAINMOD.Properties.Resources.background4;
            this.panelButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Controls.Add(this.buttonApplyClose);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 490);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(960, 46);
            this.panelButtons.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(643, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonApplyClose
            // 
            this.buttonApplyClose.Location = new System.Drawing.Point(771, 11);
            this.buttonApplyClose.Name = "buttonApplyClose";
            this.buttonApplyClose.Size = new System.Drawing.Size(105, 23);
            this.buttonApplyClose.TabIndex = 1;
            this.buttonApplyClose.Text = "Apply and Close";
            this.buttonApplyClose.UseVisualStyleBackColor = true;
            this.buttonApplyClose.Click += new System.EventHandler(this.buttonApplyClose_Click);
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Graphing_DRAINMOD.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 536);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "Main2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DRAINMOD Graphing Preferences";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonApplyClose;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonClose;
    }
}

